using BusinessLayer;
using DataLayer;
using EntityLayer;
using Inventory.Helpers;
using Inventory.Model;
using Inventory.Utils;
using Inventory.View.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using static Inventory.Helpers.InventoryHelper;

namespace Inventory.View.Products {
    public partial class SellProducts : UserControl {
        public bool Proceed = true;
        public bool ReadyForSale = false;
        public int ProductStock = 0;
        public decimal TotalAmount = 0.00M;
        public decimal ProdQuantity = 0.00M;
        public decimal SalePrice = 0.00M;
        public string GivenAmount = "";
        public string CustomerChange = "";
        public Guid VariationID = new Guid();
        public ProductVariationEntity SelectedVariation = null;
        public List<ProductSellingEntity> SelectedProducts = new List<ProductSellingEntity>();

        //
        //
        //
        public string Remarks { get; set; }

        public string PaymentType { get; set; }

        public BackgroundWorker worker = new BackgroundWorker();

        public ProductSellingEntity Product { get; set; }

        public SellProducts() {
            InitializeComponent();
            //
            //
            PopulateGridViewAllProducts();
            LoadPaymentTypes();
        }

        public void PopulateGridViewAllProducts() {
            var _productVariations = ProductVariationServices.GetAllProductsWithVariations();
            DataHelpers.LoadGridViewData(grdViewAllProducts, _productVariations);
        }

        public void LoadPaymentTypes() {
            ddlSalesPayType.DataSource = Enum.GetValues(typeof(PaymentType));
        }

        private void btnAdd1_Click(object sender, EventArgs e) {
            if (ReadyForSale) {
                GivenAmount += "1";
                txtCustomerChange.Text = GivenAmount;
            }
        }

        private void btnAdd2_Click(object sender, EventArgs e) {
            if (ReadyForSale) {
                GivenAmount += "2";
                txtCustomerChange.Text = GivenAmount;
            }
        }

        private void btnAdd3_Click(object sender, EventArgs e) {
            if (ReadyForSale) {
                GivenAmount += "3";
                txtCustomerChange.Text = GivenAmount;
            }
        }

        private void btnAdd4_Click(object sender, EventArgs e) {
            if (ReadyForSale) {
                GivenAmount += "4";
                txtCustomerChange.Text = GivenAmount;
            }
        }

        private void btnAdd5_Click(object sender, EventArgs e) {
            if (ReadyForSale) {
                GivenAmount += "5";
                txtCustomerChange.Text = GivenAmount;
            }
        }

        private void btnAdd6_Click(object sender, EventArgs e) {
            if (ReadyForSale) {
                GivenAmount += "6";
                txtCustomerChange.Text = GivenAmount;
            }
        }

        private void btnAdd7_Click(object sender, EventArgs e) {
            if (ReadyForSale) {
                GivenAmount += "7";
                txtCustomerChange.Text = GivenAmount;
            }
        }

        private void btnAdd8_Click(object sender, EventArgs e) {
            if (ReadyForSale) {
                GivenAmount += "8";
                txtCustomerChange.Text = GivenAmount;
            }
        }

        private void btnAdd9_Click(object sender, EventArgs e) {
            if (ReadyForSale) {
                GivenAmount += "9";
                txtCustomerChange.Text = GivenAmount;
            }
        }

        private void btnAdd0_Click(object sender, EventArgs e) {
            if (ReadyForSale) {
                GivenAmount += "0";
                txtCustomerChange.Text = GivenAmount;
            }
        }

        private void btnBackSpace_Click(object sender, EventArgs e) {
            if (ReadyForSale & GivenAmount != "") {
                GivenAmount = GivenAmount.Remove(GivenAmount.Length - 1);
                txtCustomerChange.Text = GivenAmount;
            }
        }

        /// <summary>
        /// Select a product, update quantity and/or selling price and add to list of items to be sold
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddProductToList_Click(object sender, EventArgs e) {
            if (Proceed == true) {
                // Ensure a variation had been selected
                if (SelectedVariation == null) {
                    ControlHelpers.ErrorNotification("Error", "Please select a product!", 3);
                    return;
                }

                // Ensure quantity is above 0
                if (ProdQuantity == 0.00M) {
                    ControlHelpers.ErrorNotification("Incomplete Input", "Quantity should be more than zero (0)!", 3);
                    return;
                }

                // Ensure quantity is not more than product available stock
                bool flag = CheckQuantity();
                if (flag == false) {
                    Proceed = false;
                    return;
                }

                // Retrieve remarks. If empty assign the current datetime
                Remarks = txtSalesRemarks.Text == "" ? DateTime.Now.ToString() : txtSalesRemarks.Text;

                // Create a selling
                SelectedVariation.wholesale_price = chkIsWholesale.Checked ? txtSlctdProdSalePrice.Value : 0.00M;
                var sellingEntity = ConvertToProductSellingEntity(SelectedVariation);
                sellingEntity.Wholesale = chkIsWholesale.Checked;

                SelectedProducts.Add(sellingEntity);
                DataHelpers.LoadGridViewData(grdViewSelectedProducts, SelectedProducts);

                // Calculate the toal cost for all selected products and display in TextBox
                TotalAmount = SelectedProducts.Sum(p => p.Amount);
                txtTotalAmount.Text = Convert.ToString(TotalAmount);

                // Reset selections
                VariationID = new Guid();
                SelectedVariation = new ProductVariationEntity();
                ProdQuantity = 0;
                ProductStock = 0;
                txtSlctdProdQty.Value = 0.00M;
                Proceed = true;
                ReadyForSale = true;
            } else {
                ControlHelpers.ErrorNotification("Error", "Please fix all pending errors!", 3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmSales_Click(object sender, EventArgs e) {
            if (SelectedProducts.Count <= 0) {
                ControlHelpers.ErrorNotification("Empty Cart", "Add a product to the sales cart!");
                return;
            }

            if (ddlSalesPayType.SelectedValue == null) {
                ControlHelpers.ErrorNotification("Incomplete input", "Please select a payment type!", 3);
                return;
            }

            // Retrieve payment type
            PaymentType = ddlSalesPayType.SelectedItem.ToString();

            // Calculate customer change
            try {
                CustomerChange = Convert.ToString(Convert.ToDecimal(GivenAmount) - TotalAmount);
                txtCustomerChange.Text = CustomerChange;
                if (Convert.ToDecimal(CustomerChange) > 0.00M) {
                    ControlHelpers.PromptNotification("Customer's Change", string.Format("Customer's change is: {0}", CustomerChange));
                }
            } catch (Exception ex) {
                ErrorLogger.LogException(ex, LoginCredentials.username ?? "Not Authenticated", "Taking in amount paid by customer and calculating change.");
            }

            // Save transaction history
            List<Transaction_History> transaction = new List<Transaction_History>();
            if (SelectedProducts.Count > 0) {
                foreach (ProductSellingEntity item in SelectedProducts) {
                    transaction.Add(ConvertToSellingHistory(item));
                }

                try {
                    bool flag = TransactionHistoryServices.AddBulkTransactionHistory(transaction);
                    if (flag) {
                        ControlHelpers.SuccessNotification("Products Sold", "Products have been added to transaction history!");
                        //ActionHistoryServices.AddActionHistory(LoginCredentials.username ?? "Authenticated", string.Format("Sold products: {0}", SelectedProducts.Select(p => p.ProductName + ", ")));
                    }
                } catch (Exception ex) {
                    string proceedure = "Confirming sales of products in sales cart!";

                    // Log error to text file
                    ErrorLogger.LogException(ex, LoginCredentials.username ?? "Not Authenticated", proceedure);

                    // Log error in DB
                    ErrorServices.AddNewError(LoginCredentials.username ?? "Not Authenticated", "Very Severe", "0", proceedure, ex.StackTrace, ex.Message);

                    // Display error notification
                    ControlHelpers.ErrorNotification("Sales Error", "Products could not be added to transaction history!");
                    return;
                }

                try {
                    foreach (ProductSellingEntity item in SelectedProducts) {
                        // Reduce product stock
                        ProductVariationServices.UpdateProductVariationStock(item.VariationId, false);
                        // Reduce remaining quantity
                        //ProductOrderServices.UpdateRemainingQuantity(item.VariationId);
                    }
                } catch (Exception ex) {
                    string proceedure = "Updating product stock level!";

                    // Log error to text file
                    ErrorLogger.LogException(ex, LoginCredentials.username ?? "Not Authenticated", proceedure);

                    // Log error in DB
                    ErrorServices.AddNewError(LoginCredentials.username ?? "Not Authenticated", "Very Severe", "0", proceedure, ex.StackTrace, ex.InnerException.Message);

                    // Display error notification
                    ControlHelpers.ErrorNotification("Product Update Error", "Product stock cound not be updated!");
                    return;
                }
            }

            // Reset all resetables
            VariationID = new Guid();
            SelectedVariation = new ProductVariationEntity();
            ProdQuantity = 0;
            ProductStock = 0;
            txtSlctdProdQty.Value = 0.00M;
            Proceed = true;
            ReadyForSale = true;
            TotalAmount = 0.00M;
            SelectedProducts = new List<ProductSellingEntity>();
            GivenAmount = "";
            txtTotalAmount.Text = "";

            // Rebind & reset DataGridViews
            PopulateGridViewAllProducts();
            grdViewSelectedProducts.DataSource = null;
        }

        private void txtSlctdProdQty_ValueChanged(object sender, EventArgs e) {
            if (SelectedVariation != null) {
                ProdQuantity = txtSlctdProdQty.Value;
            }
        }

        private void txtSlctdProdSalePrice_ValueChanged(object sender, EventArgs e) {
            if (SelectedVariation != null) {
                SalePrice = txtSlctdProdSalePrice.Value;
                SelectedVariation.retail_price = SalePrice;
            }
        }

        private void chkIsWholesale_CheckedChanged(object sender, EventArgs e) {
            if (SelectedVariation != null) {
                txtSlctdProdSalePrice.Value = SelectedVariation.wholesale_price;
            }
        }

        private void grdViewAllProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            Proceed = true;
            grdViewAllProducts.Rows[e.RowIndex].Selected = true;
            VariationID = Guid.Parse(grdViewAllProducts.Rows[e.RowIndex].Cells[0].Value.ToString());

            // Retrieve product variation
            SelectedVariation = ProductVariationServices.GetProductVariationEntity(VariationID);

            // Retrieve stock level and retail price from product variation
            ProductStock = SelectedVariation.stock;
            txtSlctdProdSalePrice.Value = Convert.ToDecimal(SelectedVariation.retail_price);

            // Reset ProdQuantity and value box. Doing this, just to ensure that by no means does the variable and numeric box hold a valid value
            ProdQuantity = 0;
            txtSlctdProdQty.Value = 0.00M;

            // Show notification as a cue to let user know that a product has been selected.
            ControlHelpers.PromptNotification("Product Selected", string.Format("{0} has been been selected. Update quantity and add to the selling cart!", SelectedVariation.VariationName), 4);
        }

        private void grdViewSelectedProducts_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            grdViewSelectedProducts.Rows[e.RowIndex].Selected = true;
            var id = grdViewSelectedProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
            var quantity = grdViewSelectedProducts.Rows[e.RowIndex].Cells[2].Value.ToString();

            // Reset ProductStock
            ProductStock = ProductVariationServices.GetProductVariationEntity(Guid.Parse(id)).stock;

            if (Convert.ToInt32(quantity) != ProdQuantity) {
                ProdQuantity = Convert.ToInt32(quantity);
            }

            // Ensure quantity is not more than product available stock
            bool flag = CheckQuantity();
            if (flag == false) {
                Proceed = false;
                return;
            }

            var _variation = SelectedProducts.Where(p => p.VariationId == Guid.Parse(id)).FirstOrDefault();
            SelectedProducts.Remove(_variation);

            _variation.Quantity = Convert.ToInt32(ProdQuantity);
            _variation.Amount = ProdQuantity * _variation.SellingPrice;
            SelectedProducts.Add(_variation);
            TotalAmount = SelectedProducts.Sum(p => p.Amount);
            txtTotalAmount.Text = Convert.ToString(TotalAmount);
            DataHelpers.LoadGridViewData(grdViewSelectedProducts, SelectedProducts);

            Proceed = true;
            ProdQuantity = 0;
            txtSlctdProdQty.Value = 0.00M;
            ReadyForSale = true;
        }

        /// <summary>
        /// Returns True if quantity is more than available product stock. False otherwise.
        /// </summary>
        /// <returns></returns>
        public bool CheckQuantity() {
            bool ok = true;
            if (ProdQuantity > ProductStock && ProductStock == 0) {
                ControlHelpers.ErrorNotification("Empty Stock", "Product stock is empty!", 3);
                ok = false;
            } else {
                if (ProdQuantity > ProductStock && ProductStock > 0) {
                    ControlHelpers.ErrorNotification("Low Stock", string.Format("Quantity is more than product's available stock. There are only {0} items remaining!", ProductStock), -1);
                    ok = false;
                }
            }
            return ok;
        }

        /// <summary>
        /// Create a new ProductSellingEntity from a product.
        /// </summary>
        /// <param name="variation"></param>
        /// <returns></returns>
        protected ProductSellingEntity ConvertToProductSellingEntity(ProductVariationEntity variation) {
            ProductSellingEntity klass = new ProductSellingEntity() {
                ProductId = variation.ProductID,
                VariationId = variation.VariationID,
                ProductName = variation.VariationName,
                VariationName = variation.VariationName,
                Quantity = Convert.ToInt32(ProdQuantity),
                SellingPrice = SalePrice,
                Amount = (variation.retail_price) * ProdQuantity,
            };
            return klass;
        }

        protected Transaction_History ConvertToSellingHistory(ProductSellingEntity product) {
            var _variation = ProductVariationServices.GetProductVariationEntity(product.VariationId);
            Transaction_History temp = new Transaction_History() {
                dealer = _variation.DealerName,
                ProductVariationVariationID = _variation.VariationID,
                quantity = product.Quantity,
                credit = product.Amount,
                debit = 0,
                transaction_type = TransactionType.Credit.ToString(),
                payment_type = PaymentType,
                payment_date = DateTime.Now,
                remarks = Remarks,
                change = Convert.ToDecimal(CustomerChange),
                balance_due = txtSalesBalanceDue.Value,
                //ProductOrderID =
            };

            return temp;
        }

        private void ddlSalesPayType_SelectedIndexChanged(object sender, EventArgs e) {
        }

        private void txtSalesBalanceDue_ValueChanged(object sender, EventArgs e) {
        }

        private void txtSalesRemarks_TextChanged(object sender, EventArgs e) {
        }

        private void txtCustomerChange_TextChanged(object sender, EventArgs e) {
        }
    }
}
