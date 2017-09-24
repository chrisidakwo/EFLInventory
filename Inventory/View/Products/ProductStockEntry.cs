using BusinessLayer;
using ComponentFactory.Krypton.Toolkit;
using DataLayer;
using EntityLayer;
using Inventory.Helpers;
using Inventory.Model;
using Inventory.Utils;
using Inventory.View.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Inventory.Helpers.InventoryHelper;

namespace Inventory.View.Products {
    public partial class ProductStockEntry : KryptonForm {
        public decimal ProductCostPrice = 0.00M;
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
            List<ProductVariationEntity> _products = new List<ProductVariationEntity>();
            try {
                _products = ProductVariationServices.GetProductVariationsBySubCategory(Convert.ToInt32(subCategoryId));
                DataHelpers.LoadDataSource(ddlProduct, _products, "VariationName", "VariationID");
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
            var variationId = ddlProduct.SelectedValue;
            try {
                var _variation = ProductVariationServices.GetProductVariationEntity(Guid.Parse(variationId.ToString()));
                ProductCostPrice = _variation.cost_price;
                txtProdCostPrice.Text = ProductCostPrice.ToString();
                txtProdRetailPrice.Text = _variation.retail_price.ToString();
                txtProdWholesalePrice.Text = _variation.wholesale_price.ToString();
                txtProdDealer.Text = _variation.DealerName;
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
            if (txtProdRetailPrice.Text != string.Empty) {
                _productSalePrice = Convert.ToInt32(txtProdRetailPrice.Text);
            }
            var amount = quantity * ProductCostPrice;
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
                ControlHelpers.ErrorNotification("Invalid Input", "Product quantity should be more than zero(0)!");
                return;
            }
            #endregion Ensure product quantity is greater than zero

            #region Ensure product amount is calculated and not zero or empty
            if (txtProdAmount.Text == string.Empty || Convert.ToInt32(Convert.ToDecimal(txtProdAmount.Text)) == 0) {
                ControlHelpers.ErrorNotification("Invalid Input", "Product stock amount cannot be zero");
                return;
            }
            #endregion Ensure product amount is calculated and not zero or empty

            #region Ensure expiry date is greater than today
            bool validDate = false;
            if (txtProdStockExpiryDate.Value.Date == DateTime.Now.Date) {
                DialogResult result = KryptonMessageBox.Show("Are you sure this stock expires today?", "Confirm Expiry Date", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (result) {
                    case DialogResult.Yes:
                        validDate = true;
                        break;
                    case DialogResult.No:
                        break;
                }

                if (!validDate) {
                    return;
                }
            }
            #endregion Ensure expiry date is greater than today

            #region Ensure stock threshold value is valid
            bool validThreshold = false;
            var stock_threshold = Convert.ToInt32(txtProdStockThreshold.Value);
            if (stock_threshold == 0) {
                DialogResult result = KryptonMessageBox.Show("Are you sure you want the stock threshold at zero (0)?", "Confirm Stock Threshold", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (result) {
                    case DialogResult.Yes:
                        validThreshold = true;
                        break;
                    case DialogResult.No:
                        break;
                }

                if (!validThreshold) {
                    return;
                }
            }
            #endregion Ensure stock threshold value is valid

            #region Retrieve product id from selected product item
            Guid variationId = new Guid();
            try {
                variationId = Guid.Parse(ddlProduct.SelectedValue.ToString());
                Guid guid = new Guid();
                if (variationId == null || variationId == guid) {
                    ControlHelpers.ErrorNotification("Incomplete Input", "Please select a product!");
                    return;
                }
            } catch (Exception) {
                return;
            }
            #endregion Retrieve product id from selected product item

            #region Initialize variables
            var variation = ProductVariationServices.GetProductVariationEntity(variationId);
            var stock = txtProdQuantity.Value;
            #endregion Initialize variables

            #region Create a new debit transaction as a SellingHistory
            // Add SellingHistory object to database
            Transaction_History sh = new Transaction_History() {
                dealer = variation.DealerName,
                ProductVariationVariationID = variationId,
                quantity = Convert.ToInt32(txtProdQuantity.Value),
                credit = 0,
                debit = Convert.ToDecimal(txtProdAmount.Text),
                balance_due = txtProdBalanceDue.Value,
                change = 0.00M,
                payment_type = ddlProdPaymentType.SelectedItem.ToString(),
                transaction_type = TransactionType.Debit.ToString(),
                remarks = txtRemarks.Text == string.Empty ? DateTime.Now.ToString() : txtRemarks.Text,
                payment_date = DateTime.Now.Date,
            };
            try {
                int x = TransactionHistoryServices.AddUpdateTransactionHistory(sh);
                if (x > 0) {
                    ControlHelpers.SuccessNotification("Purchase History Saved", "Your product purchase history has been saved successfully");
                    // TODO: Log ActionHistory
                }
            } catch (Exception ex) {
                ErrorLogger.LogException(ex, LoginCredentials.username ?? "Not Authenticated", "Adding a new purchase history");
                ControlHelpers.ErrorNotification("Save Error", "An error occured while saving!");
                // TODO: Log error in DB
                return;
            }
            #endregion Create a new debit transaction as a SellingHistory

            #region Update product stock value
            try {
                int threshold = Convert.ToInt32(txtProdStockThreshold.Value);
                //DateTime expiryDate = txtProdStockExpiryDate.Value.Date;
                ProductVariationServices.UpdateProductVariationStock(variationId, true, threshold);
                // Log ActionHistory
            } catch (Exception ex) {
                // TODO: Why not consider deleting the SellingHistory just entered so when user tries to save a new one, the stock value does not add up to a conflicting value
                string proceedure = "Updating product stock value on new stock purchase";
                ErrorLogger.LogException(ex, LoginCredentials.username, proceedure);
                ControlHelpers.ErrorNotification("Update Error", "An error occured while updating stock for product: " + variation.ProductName + "!");
                // TODO: Log error in DB
            }
            #endregion Update product stock value

            ClearControlValues();
        }

        public void ClearControlValues() {
            txtProdAmount.Text = "";
            txtProdCostPrice.Text = "";
            txtProdQuantity.Value = 0;
            txtProdDealer.Text = "";
            txtProdRetailPrice.Text = "";
            txtRemarks.Text = "";
        }
    }
}
