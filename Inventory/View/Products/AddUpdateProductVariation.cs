using BusinessLayer;
using ComponentFactory.Krypton.Toolkit;
using DataLayer;
using Inventory.Helpers;
using Inventory.Model;
using Inventory.View.Helpers;
using System;

namespace Inventory.View.Products {
    public partial class AddUpdateProductVariation : KryptonForm {
        public AddUpdateProductVariation() {
            InitializeComponent();

            PopulateDDLProduct();
            PopulateMeasuringUnits();
        }

        public void PopulateDDLProduct() {
            var _products = ProductServices.GetAllProducts();
            DataHelpers.LoadDataSource(ddlSelectProduct, _products, "name", "id");
        }

        public void PopulateMeasuringUnits() {
            var _measuringUnits = MeasuringServices.GetAllMeasuringTypes();
            DataHelpers.LoadDataSource(ddlProdMeasuredBy, _measuringUnits, "name", "id");
        }

        private void btnSaveProductVariation_Click(object sender, EventArgs e) {
            // Validate the values of all controls
            bool flag = ValidateControls();
            if (flag == false) {
                return;
            }

            Guid variationId = new Guid();

            if (BaseObject<ProductVariation>.value != null) {
                ProductVariation variation = new ProductVariation() {
                    VariationID = BaseObject<ProductVariation>.value.VariationID,
                    Product_id = BaseObject<ProductVariation>.value.Product_id,
                    VariationName = txtProdVariationName.Text.Trim(),
                    image_url = "",
                    measured_by = Convert.ToInt32(ddlProdMeasuredBy.SelectedValue),
                    retail_price = txtProdVariationSalePrice.Value,
                    wholesale_price = 0.00M,
                    cost_price = txtProdVariationCostPrice.Value,
                    weight = txtProdVariationWeight.Value
                };

                variationId = ProductVariationServices.UpdateProductVariation(variation);
                ControlHelpers.SuccessNotification("Success", "Product variation has been updated successfully!");
                ActionHistoryServices.AddActionHistory(LoginCredentials.username, string.Format("Updated a product variation - {0}", BaseObject<ProductVariation>.value.Product.name));
            } else {
                ProductVariation variation = new ProductVariation() {
                    VariationID = Guid.NewGuid(),
                    Product_id = Convert.ToInt32(ddlSelectProduct.SelectedValue),
                    VariationName = txtProdVariationName.Text.Trim(),
                    image_url = "",
                    measured_by = Convert.ToInt32(ddlProdMeasuredBy.SelectedValue),
                    retail_price = txtProdVariationSalePrice.Value,
                    wholesale_price = 0.00M,
                    cost_price = txtProdVariationCostPrice.Value,
                    weight = txtProdVariationWeight.Value
                };

                variationId = ProductVariationServices.AddProductVariation(variation);
                ControlHelpers.SuccessNotification("Success", "Product variation has been saved successfully!");
                ActionHistoryServices.AddActionHistory(LoginCredentials.username, string.Format("Added a product variation - {0}", BaseObject<ProductVariation>.value.Product.name));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        public bool ValidateControls() {
            bool flag = true;
            if (ddlSelectProduct.SelectedValue == null) {
                ControlHelpers.ErrorNotification("Incomplete Input", "Please select a product!");
                return false;
            }

            if (ddlProdMeasuredBy.SelectedValue == null) {
                ControlHelpers.ErrorNotification("Incomplete Input", "Please select a measuring unit!");
                return false;
            }

            if (txtProdVariationWeight.Value == 0.00M) {
                ControlHelpers.ErrorNotification("Incomplete Input", "Please enter a value for weight!");
                return false;
            }

            if (txtProdVariationCostPrice.Value == 0.00M) {
                ControlHelpers.ErrorNotification("Incomplete Input", "Please enter a value for cost price!");
                return false;
            }

            if (txtProdVariationSalePrice.Value == 0.00M) {
                ControlHelpers.ErrorNotification("Incomplete Input", "Please enter a value for sale price!");
                return false;
            }

            return flag;
        }
    }
}
