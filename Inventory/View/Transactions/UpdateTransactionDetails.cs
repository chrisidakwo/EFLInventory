using BusinessLayer;
using ComponentFactory.Krypton.Toolkit;
using DataLayer;
using EntityLayer;
using Inventory.Model;
using Inventory.Utils;
using Inventory.View.Helpers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Inventory.View.Transactions {
    public partial class UpdateTransactionDetails : KryptonForm {
        public ProductVariation Variation = new ProductVariation();
        public ProductVariationEntity VariationEntity = new ProductVariationEntity();
        public int InitialQuantity = 0;
        public int FinalQuantity = 0;
        public string TransactionType = "";
        public UpdateTransactionDetails() {
            InitializeComponent();

            if (BaseObject<TransactionPurchaseEntity>.value != null) {
                var purchaseHistory = BaseObject<TransactionPurchaseEntity>.value;
                txtTransactionID.Text = purchaseHistory.ID.ToString();
                txtProductName.Text = purchaseHistory.ProductName;
                VariationEntity = ProductVariationServices.GetAllProductsWithVariations().Where(v => v.VariationName == purchaseHistory.ProductName).FirstOrDefault();
                Variation = ProductVariationServices.GetProductVariation(VariationEntity.VariationID);
                txtProdQuantity.Value = purchaseHistory.Quantity;
                InitialQuantity = purchaseHistory.Quantity;
                FinalQuantity = InitialQuantity;
                txtTotalAmount.Text = purchaseHistory.Debit.Value.ToString();
                txtProdBalanceDue.Value = purchaseHistory.BalanceDue;
                txtProdChange.Value = 0.00m;
                txtRemarks.Text = purchaseHistory.Remarks;
                TransactionType = "Debit";
            }

            if (BaseObject<TransactionSellingEntity>.value != null) {
                var salesHistory = BaseObject<TransactionSellingEntity>.value;
                txtTransactionID.Text = salesHistory.ID.ToString();
                txtProductName.Text = salesHistory.ProductName; ;
                VariationEntity = ProductVariationServices.GetAllProductsWithVariations().Where(v => v.VariationName == salesHistory.ProductName).FirstOrDefault();
                Variation = ProductVariationServices.GetProductVariation(VariationEntity.VariationID);
                txtProdQuantity.Value = salesHistory.Quantity;
                InitialQuantity = salesHistory.Quantity;
                FinalQuantity = InitialQuantity;
                txtTotalAmount.Text = salesHistory.Credit.ToString();
                txtProdChange.Value = salesHistory.Change;
                txtProdBalanceDue.Value = salesHistory.BalanceDue;
                txtRemarks.Text = salesHistory.Remarks;
                TransactionType = "Credit";
            }
        }

        private void btnCancel_Click(object sender, System.EventArgs e) {
            Close();
        }

        private void btnUpdateTransactionHistory_Click(object sender, EventArgs e) {
            #region Initialize variables
            var quantity = FinalQuantity != 0 ? FinalQuantity : InitialQuantity;
            var balanceDue = txtProdBalanceDue.Value;
            int ID = 0;
            DateTime PayDate = new DateTime();
            string PaymentType = "";
            decimal Credit = 0.00m;
            decimal Debit = 0.00m;
            #endregion Initialize variables

            #region Update variables value
            if (BaseObject<TransactionSellingEntity>.value != null) {
                ID = BaseObject<TransactionSellingEntity>.value.ID;
                PayDate = BaseObject<TransactionSellingEntity>.value.PaymentDate;
                PaymentType = BaseObject<TransactionSellingEntity>.value.PaymentType;
                Credit = Convert.ToDecimal(txtTotalAmount.Text);
                Debit = 0.00m;
            } else {
                ID = BaseObject<TransactionPurchaseEntity>.value.ID;
                PayDate = BaseObject<TransactionPurchaseEntity>.value.PaymentDate;
                PaymentType = BaseObject<TransactionPurchaseEntity>.value.PaymentType;
                Debit = Convert.ToDecimal(txtTotalAmount.Text);
                Credit = 0.00m;
            }
            #endregion Update variables value

            Transaction_History transaction = new Transaction_History() {
                id = ID,
                balance_due = balanceDue,
                quantity = Convert.ToInt32(quantity),
                transaction_type = TransactionType,
                payment_date = PayDate,
                payment_type = PaymentType,
                dealer = VariationEntity.DealerName,
                remarks = txtRemarks.Text ?? DateTime.Now.ToString(),
                ProductVariationVariationID = VariationEntity.VariationID,
                change = txtProdChange.Value,
                credit = Credit,
                debit = Debit,
            };

            try {
                // Update the transaction history
                int x = TransactionHistoryServices.AddUpdateTransactionHistory(transaction);
                ControlHelpers.SuccessNotification("Updated", "Transaction history has been updated successfully!");

                bool allowed = true;
                if (Variation != null) {
                    if (InitialQuantity != FinalQuantity) {
                        if (FinalQuantity == 0) {
                            DialogResult result = KryptonMessageBox.Show("Are you sure you want item quantity at zero (0)?", "Confirm Quantity", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            switch (result) {
                                case DialogResult.Yes:
                                    break;
                                case DialogResult.No:
                                    allowed = false;
                                    break;
                            }
                        }

                        if (allowed) {
                            if (FinalQuantity == 0) {
                                Variation.stock += InitialQuantity;
                            } else {
                                if (InitialQuantity < FinalQuantity) {
                                    Variation.stock += (InitialQuantity - FinalQuantity);
                                }

                                if (InitialQuantity > FinalQuantity) {
                                    Variation.stock -= (FinalQuantity - InitialQuantity);
                                }
                            }

                            try {
                                // Update product stock
                                ProductVariationServices.UpdateProductVariation(Variation);
                                ControlHelpers.SuccessNotification("Stock Updated", "Product stock updated");
                            } catch (Exception ex) {
                                ErrorLogger.LogException(ex, LoginCredentials.username ?? "Not Authenticated", "Updating product stock on update of transaction history");
                                ErrorServices.AddNewError(LoginCredentials.username ?? "Not Authenticated", "Very Severe", "0", "Updating product stock on update of transaction history", ex.StackTrace, ex.InnerException.Message ?? ex.Message);
                            }
                        }
                    }
                }
            } catch (Exception ex) {
                ErrorLogger.LogException(ex, LoginCredentials.username ?? "Not Authenticated", "Updating a transaction history!");
                ControlHelpers.ErrorNotification("Error", "An error occurred while updating transaction history. Contact the developer as soon as possible!");
                try {
                    ErrorServices.AddNewError(LoginCredentials.username ?? "Not Authenticated", "Very Severe", "0", "Updating a transaction history", ex.StackTrace, ex.InnerException.Message ?? ex.Message);
                } catch (Exception) {
                }
            }
        }

        private void txtProdQuantity_ValueChanged(object sender, EventArgs e) {
            FinalQuantity = Convert.ToInt32(txtProdQuantity.Value);
            if (!chkIsWholeSale.Checked) {
                txtTotalAmount.Text = (FinalQuantity * VariationEntity.retail_price).ToString();
            } else {
                txtTotalAmount.Text = (FinalQuantity * VariationEntity.wholesale_price).ToString();
            }
        }

        private void chkIsWholeSale_CheckedChanged(object sender, EventArgs e) {
            txtProdQuantity_ValueChanged(sender, e);
        }
    }
}
