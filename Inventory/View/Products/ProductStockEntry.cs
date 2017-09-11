using BusinessLayer;
using ComponentFactory.Krypton.Toolkit;
using DataLayer;
using Inventory.Helpers;
using Inventory.Model;
using Inventory.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Inventory.Helpers.InventoryHelper;

namespace Inventory.View.Products {
    public partial class ProductStockEntry : KryptonForm {
        public ProductStockEntry() {
            InitializeComponent();

            // Populate Category ComboBox
            this.ProductCategories();

            // Populate PaymentType ComboBox
            this.PaymentTypes();
        }

        /// <summary>
        /// Close this form window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e) {
            // Close Form
            this.Close();
        }

        /// <summary>
        /// Load data source for categories ComboBox.
        /// </summary>
        private void ProductCategories() {
            var _categories = CategoryServices.GetAllCategories();
            DataHelpers.LoadDataSource(ddlProdCategory, _categories, "name", "id");
        }

        /// <summary>
        /// Load data source for the payment types ComboBox.
        /// </summary>
        private void PaymentTypes() {
            ddlProdPaymentType.DataSource = Enum.GetValues(typeof(PaymentType));
        }

        /// <summary>
        /// Update subcategory ComboBox with subcategory items associated to the selected category.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ddlProdCategory_SelectedIndexChanged(object sender, EventArgs e) {
            var selectedCategoryId = ddlProdCategory.SelectedValue;
            var _subCategories = SubCategoryServices.GetSubCategoriesByCategoryId(Convert.ToInt32(selectedCategoryId));
            DataHelpers.LoadDataSource(ddlProdSubCategory, _subCategories, "name", "id");
        }

        /// <summary>
        /// Update products ComboBox with list of products associated to the selected subcategory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ddlProdSubCategory_SelectedIndexChanged(object sender, EventArgs e) {
            var subCategoryId = ddlProdSubCategory.SelectedValue;
            List<Product> _products = new List<Product>();
            try {
                _products = ProductServices.GetProductBySubCategory(Convert.ToInt32(subCategoryId));
                DataHelpers.LoadDataSource(ddlProduct, _products, "name", "id");
            } catch (Exception) {
                return;
            }
        }

        /// <summary>
        /// Update dealer's name, product cost price and sale price.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ddlProduct_SelectedIndexChanged(object sender, EventArgs e) {
            var productId = ddlProduct.SelectedValue;
            try {
                int _productId = Convert.ToInt32(productId);
                var _product = ProductServices.GetProduct(_productId);
                txtProdCostPrice.Text = _product.cost_price.ToString();
                txtProdSalePrice.Text = _product.sell_price.ToString();
                txtProdDealer.Text = ProductServices.GetProductDealer(_productId).name;
            } catch {
                return;
            }
        }

        /// <summary>
        /// Update product amount as quantity increases or decreases.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtProdQuantity_ValueChanged(object sender, EventArgs e) {
            var quantity = txtProdQuantity.Value;
            var _productSalePrice = 0;
            if (txtProdSalePrice.Text != string.Empty) {
                _productSalePrice = Convert.ToInt32(txtProdSalePrice.Text);
            }
            var amount = quantity * _productSalePrice;
            txtProdAmount.Text = amount.ToString();
        }

        /// <summary>
        /// Create a new debit transaction as a selling history. Update Product Stock.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddProductStock_Click(object sender, EventArgs e) {
            #region Ensure product quantity is greater than zero
            if (txtProdQuantity.Value == Convert.ToDecimal(0)) {
                KryptonMessageBox.Show("Product quantity should have a valid value", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion Ensure product quantity is greater than zero

            #region Ensure product amount is calculated and not zero or empty
            if (txtProdAmount.Text == string.Empty || Convert.ToInt32(txtProdAmount.Text) == 0) {
                KryptonMessageBox.Show("Product stock amount cannot be zero", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion Ensure product amount is calculated and not zero or empty

            #region Retrieve product id from selected product item
            var productId = 0;
            try {
                productId = Convert.ToInt32(ddlProduct.SelectedValue);
                if (productId == 0) {
                    KryptonMessageBox.Show("Please select a product!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            } catch (Exception) {
                return;
            }
            #endregion Retrieve product id from selected product item

            #region Initialize variables
            var product = ProductServices.GetProduct(productId);
            var dealerId = product.dealer_id;
            var stock = txtProdQuantity.Value;
            #endregion Initialize variables

            #region Create a new debit transaction as a SellingHistory
            // Add SellingHistory object to database
            Selling_History sh = new Selling_History() {
                dealer_id = dealerId,
                product_id = productId,
                quantity = Convert.ToInt32(txtProdQuantity.Value),
                credit = 0,
                debit = Convert.ToDecimal(txtProdAmount.Text),
                customer_info = "",
                customer_name = "",
                payment_type = ddlProdPaymentType.SelectedItem.ToString(),
                transaction_type_id = (int)TransactionType.Debit,
                remarks = (txtRemarks.Text == string.Empty) ? DateTime.Now.ToString() : txtRemarks.Text,
                payment_date = DateTime.Now,
            };
            try {
                Console.WriteLine(sh.transaction_type_id);
                int x = SellingHistoryServices.AddUpdateSellingHistory(sh);
                if (x > 0) {
                    KryptonMessageBox.Show("Your product purchase history has been saved successfully", "Purchase History Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // TODO: Log ActionHistory
                }
            } catch (Exception ex) {
                ErrorLogger.LogException(ex, LoginCredentials.username, "Adding a new purchase history");
                KryptonMessageBox.Show("An error occured while saving!", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // TODO: Log error in DB and text file
                return;
            }
            #endregion Create a new debit transaction as a SellingHistory

            #region Update product stock value
            try {
                ProductServices.UpdateProductStock(productId);
                // Log ActionHistory
            } catch (Exception) {
                // TODO: Why not consider deleting the SellingHistiry just entered so when user tries to save a new one, the stock value does not add up to a conflicting value
                KryptonMessageBox.Show("An error occured while updating stock for product: " + product.name + "!", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // TODO: Log error in DB and text file
            }
            #endregion Update product stock value

            ClearControlValues();
        }

        public void ClearControlValues() {
            txtProdAmount.Text = "";
            txtProdCostPrice.Text = "";
            txtProdQuantity.Value = 0;
            txtProdDealer.Text = "";
            txtProdSalePrice.Text = "";
            txtRemarks.Text = "";
        }
    }
}