using BusinessLayer;
using ComponentFactory.Krypton.Toolkit;
using DataLayer;
using EntityLayer;
using Inventory.Helpers;
using Inventory.ToastNotification;
using Inventory.View.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ToastNotification;
using static Inventory.Helpers.InventoryHelper;

namespace Inventory.View.Products {
    public partial class SellProducts : UserControl, INotifyPropertyChanged {
        // Qauntity to be sold
        public int ProdQuantity = 0;
        // Product available stock
        public int ProductStock = 0;
        // Total cost of products to be sold
        public decimal TotalAmount = 0.00M;

        public string CustomerName = "";

        public string CustomerInfo = "";

        public string Remarks = "";

        public string PaymentType = "";

        public BackgroundWorker worker = new BackgroundWorker();

        // Products listed in DataGridView
        public List<ProductSellingEntity> SelectedProducts = new List<ProductSellingEntity>();

        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public SellProducts() {
            InitializeComponent();

            // Initialize ComboBoxes with retrieved data
            this.LoadCategories();
            this.LoadPaymentTypes();
        }

        /// <summary>
        /// Retrieve and bind data to categories ComboBox
        /// </summary>
        public void LoadCategories() {
            var _categories = CategoryServices.GetAllCategories();
            DataHelpers.LoadDataSource(ddlCategories, _categories, "name", "id");
        }

        /// <summary>
        /// Retrieve and bind data to payment type ComboBox
        /// </summary>
        public void LoadPaymentTypes() {
            ddlPaymentTypes.DataSource = Enum.GetValues(typeof(PaymentType));
        }

        /// <summary>
        /// Update global ProdQuantity variable with the updated quantity value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void txtProdQuantity_TextChanged(object sender, EventArgs e) {
        //    int quantity = 0;
        //    if (txtProdQuantity.Text != "") {
        //        quantity = Convert.ToInt32(txtProdQuantity.Text);
        //        ProdQuantity = quantity;
        //    } else {
        //        KryptonMessageBox.Show("Quantity should not be empty!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //}

        private void ddlCategories_SelectedIndexChanged(object sender, EventArgs e) {
            int categoryId = 0;

            // Retrieve category id from the selected category
            try {
                var category = ddlCategories.SelectedValue;
                categoryId = Convert.ToInt32(category);
            } catch (Exception) {
                return;
            }

            // Get all subcategories associated with the retrieved category id
            var subcategories = SubCategoryServices.GetSubCategoriesByCategoryId(categoryId);
            // Update subcategories ComboBox with the retrieved list of subcategories
            DataHelpers.LoadDataSource(ddlSubCategories, subcategories, "name", "id");
            ddlSubCategories_SelectedIndexChanged(sender, e);
        }

        private void ddlSubCategories_SelectedIndexChanged(object sender, EventArgs e) {
            int subcategoryid = 0;

            // Retrieve subcagtegory id from the selected subcategory
            try {
                var subcategory = ddlSubCategories.SelectedValue;
                subcategoryid = Convert.ToInt32(subcategory);
            } catch (Exception) {
                return;
            }

            // Get all products associated with the retrieved subcategory id
            var _products = ProductServices.GetProductBySubCategory(subcategoryid);
            // Update product ComboBox with the retrieved list of products
            DataHelpers.LoadDataSource(ddlProducts, _products, "name", "id");
            ddlProducts_SelectedIndexChanged(this, new EventArgs());
        }

        private void ddlProducts_SelectedIndexChanged(object sender, EventArgs e) {
            int productId = 0;
            // Retrieve product id for the selected product
            try {
                var selectedProduct = ddlProducts.SelectedValue;
                productId = Convert.ToInt32(selectedProduct);
            } catch (Exception) {
                return;
            }

            // Retrieve product with productId
            var product = ProductServices.GetProduct(productId);

            // Update selling price TextBox
            ProductStock = Convert.ToInt32(product.Stock);
            txtProdSellingPrice.Text = "";
            txtProdSellingPrice.Text = product.sell_price.ToString();
        }

        /// <summary>
        /// Add a product to list of products in DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddProductsToList_Click(object sender, EventArgs e) {
            // Ensure a product has been selected
            var selectedProduct = ddlProducts.SelectedValue;
            if (selectedProduct == null) {
                Notification n = new Notification("Invalid Input", "Please select a product!", -1, FormAnimator.AnimationMethod.Slide, FormAnimator.AnimationDirection.Up);
                NotificationSound.PlayNotificationSound(NotificationSound.Sounds.Error);
                n.Show();
                return;
            }

            // Ensure quantity is above 0
            int prodQty = 0;
            var quantity = txtProdQuantity.Text;
            try {
                prodQty = Convert.ToInt32(quantity);
                if (quantity.Equals("0")) {
                    Notification n = new Notification("Invalid Input", "Quantity should not be equal to zero!", -1, FormAnimator.AnimationMethod.Slide, FormAnimator.AnimationDirection.Up);
                    NotificationSound.PlayNotificationSound(NotificationSound.Sounds.Error);
                    n.Show();
                    //KryptonMessageBox.Show("Quantity should not be equal to zero!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Set global variable - ProdQuantity, to the value of inputted quantity from TextBox
                ProdQuantity = prodQty;
            } catch (Exception) {
                Notification n = new Notification("Invalid Input", "Quantity should not be empty!", -1, FormAnimator.AnimationMethod.Slide, FormAnimator.AnimationDirection.Up);
                NotificationSound.PlayNotificationSound(NotificationSound.Sounds.Error);
                n.Show();
                return;
            }

            // Retrieve product from selected product id
            var _product = ProductServices.GetProduct(Convert.ToInt32(ddlProducts.SelectedValue));

            // Set global variable - ProductStock to the value of product available stock
            if (ProductStock != Convert.ToInt32(_product.Stock)) {
                ProductStock = Convert.ToInt32(_product.Stock);
            }

            // Ensure quantity is not more than product available stock
            bool flag = CheckQuantity();
            if (flag == true) {
                return;
            }

            CustomerName = txtCustomerName.Text;
            CustomerInfo = txtCustomerInfo.Text;
            PaymentType = ddlPaymentTypes.SelectedItem.ToString();
            if (txtRemarks.Text == "") {
                Remarks = DateTime.Now.ToString();
            } else {
                Remarks = txtRemarks.Text;
            }
            // Create/Update a selling list and append product and quantity details to the list for each selected product
            // Convert selected product to a ProductSellingEntity
            var sellingEntity = ConvertToProductSellingEntity(_product);
            SelectedProducts.Add(sellingEntity);
            DataHelpers.LoadGridViewData(grdViewSelectedProducts, SelectedProducts);

            // Calculate the total cost for all selected products and display in TextBox
            TotalAmount = SelectedProducts.Sum(s => s.Amount);
            txtTotalSaleAmount.Text = Convert.ToString(TotalAmount);

            // Reset selections
            ddlProducts.SelectedValue = 0;
            txtProdQuantity.Text = "0";
        }

        /// <summary>
        /// Save to DB all product items listed in DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmitProductList_Click(object sender, EventArgs e) {
            if (SelectedProducts.Count <= 0) {
                Notification n = new Notification("Invalid Input", "You have not added a product to the DataGrid", -1, FormAnimator.AnimationMethod.Slide, FormAnimator.AnimationDirection.Up);
                NotificationSound.PlayNotificationSound(NotificationSound.Sounds.Error);
                n.Show();
                return;
            }
            List<Selling_History> sh = new List<Selling_History>();
            if (SelectedProducts != null) {
                foreach (ProductSellingEntity item in SelectedProducts) {
                    sh.Add(ConvertToSellingHistory(item));
                }

                try {
                    bool flag = SellingHistoryServices.AddBulkSellingHistory(sh);
                    if (flag) {
                        // Reload inventory summary and labelheader values
                        ControlHelpers.SuccessNotification("Product Sold", "Products added to transaction history!");
                    }
                } catch (Exception) {
                    KryptonMessageBox.Show("Products could not be added to transaction history!", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Log error in db and text file
                    return;
                }

                try {
                    foreach (ProductSellingEntity item in SelectedProducts) {
                        ProductServices.UpdateProductStock(item.ProductId);
                    }
                } catch (Exception) {
                    Notification n = new Notification("Product Update Error", "Product stock could not be updated!", -1, FormAnimator.AnimationMethod.Slide, FormAnimator.AnimationDirection.Up);
                    NotificationSound.PlayNotificationSound(NotificationSound.Sounds.Error);
                    n.Show();
                    // Log error in db and text file
                    return;
                }
            }

            SelectedProducts = new List<ProductSellingEntity>();
            DataHelpers.LoadGridViewData(grdViewSelectedProducts, SelectedProducts);

            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerAsync();
        }

        /// <summary>
        /// Returns True if quantity is more than available product stock. False otherwise.
        /// </summary>
        /// <returns></returns>
        public bool CheckQuantity() {
            if (ProdQuantity > ProductStock) {
                Notification n = new Notification("Invalid Input", "Quantity is greater than stock!", -1, FormAnimator.AnimationMethod.Slide, FormAnimator.AnimationDirection.Up);
                NotificationSound.PlayNotificationSound(NotificationSound.Sounds.Error);
                n.Show();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Create a new ProductSellingEntity from a product.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        protected ProductSellingEntity ConvertToProductSellingEntity(Product product) {
            ProductSellingEntity klass = new ProductSellingEntity() {
                ProductId = product.id,
                ProductName = product.name,
                Quantity = ProdQuantity,
                SellingPrice = product.sell_price,
                Amount = (product.sell_price) * ProdQuantity,
            };
            return klass;
        }

        protected Selling_History ConvertToSellingHistory(ProductSellingEntity product) {
            var _product = ProductServices.GetProduct(product.ProductId);
            Selling_History temp = new Selling_History() {
                dealer_id = _product.dealer_id,
                product_id = _product.id,
                quantity = product.Quantity,
                credit = product.Amount,
                debit = 0,
                transaction_type_id = (int)TransactionType.Credit,
                customer_name = CustomerName,
                customer_info = CustomerInfo,
                payment_type = PaymentType,
                payment_date = DateTime.Now,
                remarks = Remarks,
            };

            return temp;
        }

        public void worker_DoWork(object sender, DoWorkEventArgs e) {
            // Update label header text values
            DateTime _todaysDate = DateTime.Now.Date;
            DateTime firstDayOfMonth = new DateTime(_todaysDate.Year, _todaysDate.Month, 1);
            DateTime lastDayOfMonth = new DateTime(_todaysDate.Year, _todaysDate.Month, 1).AddMonths(1).AddDays(-1);

            TransactionsHelpers.GetTotalSaleForToday(_todaysDate);
            TransactionsHelpers.GetTotalSalesForMonth(firstDayOfMonth, lastDayOfMonth);
            TransactionsHelpers.GetTotalSalesForHalfYear(_todaysDate);
        }
    }
}