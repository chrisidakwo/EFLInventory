using BusinessLayer;
using DataLayer;
using Inventory.Helpers;
using Inventory.Model;
using Inventory.Utils;
using Inventory.View.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Inventory.View.Products {
    public partial class AddUpdateProduct : UserControl {
        public new string ProductName { get; set; }
        public int ProductID { get; set; }
        public Guid VariationID { get; set; }
        public List<ProductVariation> ProductVariations { get; set; }

        public AddUpdateProduct() {
            InitializeComponent();

            // Populate ComboBoxes
            PopulateDDLBrand();
            PopulateDDLProdDealer();
            PopulateDDLProdCategory();
            PopulateMeasuringUnits();

            // Populate GridView
            PopulateGridView();
        }

        public void PopulateGridView() {
            var products = ProductServices.GetAllProductEntity();
            DataHelpers.LoadGridViewData(grdAllProducts, products);
        }

        //
        //
        //

        #region Product Form
        public void PopulateDDLProdDealer() {
            var _dealers = DealerServices.GetAllDealers();
            DataHelpers.LoadDataSource(ddlProductDealer, _dealers, "name", "id");
        }

        public void PopulateDDLBrand() {
            var _brands = BrandServices.GetAllBrands();
            DataHelpers.LoadDataSource(ddlProductBrand, _brands, "name", "id");
        }

        public void PopulateDDLProdCategory() {
            var _categories = CategoryServices.GetAllCategories();
            DataHelpers.LoadDataSource(ddlProductCategory, _categories, "name", "id");
        }

        private void btnSaveProduct_Click(object sender, EventArgs e) {
            ProductName = txtProductName.Text.Trim();
            if (ProductName == "") {
                ControlHelpers.ErrorNotification("Incomplete Input", "Product name should not be empty!");
                return;
            }

            if (ProductServices.CheckProductNameAvailable(ProductName) & ProductID == 0) {
                ControlHelpers.ErrorNotification("Name Already Exists", "Two products cannot have the same name! Use another name to identify the product!");
                return;
            }

            int _productId = 0;

            try {
                Product _product = new Product();
                if (ProductID != 0) { // ==> It's an update action
                    _product = ProductServices.GetProduct(ProductID);
                    _productId = _product.id;
                }

                _product.name = ProductName;
                _product.brand_id = Convert.ToInt32(ddlProductBrand.SelectedValue);
                _product.dealer_id = Convert.ToInt32(ddlProductDealer.SelectedValue);
                _product.Category_id = Convert.ToInt32(ddlProductCategory.SelectedValue);
                _product.subCategory_id = Convert.ToInt32(ddlProdSubCategory.SelectedValue);
                _product.status = chkProductIsActive.Checked;

                int productId = 0;
                if (ProductID > 0) {
                    productId = ProductServices.UpdateProduct(_product);

                    // Re-bind GridView
                    PopulateGridView();

                    // Notification
                    ControlHelpers.SuccessNotification("Product Updated", "Product was updated successfully");

                    // Add action history
                    ActionHistoryServices.AddActionHistory(LoginCredentials.username, string.Format("Updated product: {0}", ProductName));

                    ProductID = 0;
                    ProductName = "";
                    ClearControlValues();
                } else {
                    productId = ProductServices.AddProduct(_product);

                    // Re-bind GridView
                    PopulateGridView();

                    // Notification
                    ControlHelpers.SuccessNotification("Product Added", "Product was created succesfully!");

                    // Add action history
                    ActionHistoryServices.AddActionHistory(LoginCredentials.username, string.Format("Added a new product: {0}", ProductName));

                    ProductID = 0;
                    ProductName = "";
                    ClearControlValues();
                }
            } catch (Exception ex) {
                ErrorLogger.LogException(ex, LoginCredentials.username, "Adding/updating a product");
                if (ex.InnerException != null) {
                    ErrorServices.AddNewError(LoginCredentials.username, "Severe", "0", "Adding/updating a product", ex.StackTrace, ex.InnerException.Message);
                }
                return;
            }
        }

        private void ClearControlValues() {
            txtProductName.Text = "";
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e) {
            var variations = ProductServices.GetAllActiveProducts().Where(p => p.ProductVariations.Count > 0).ToList();
            if (variations != null) {
                ControlHelpers.ErrorNotification("Cannot Delete Product", "Please remove all associated variations before deleting this product!");
                return;
            }

            ControlHelpers.ErrorNotification("Action Not Supported", "Delete action is not supported, for now!");
            return;
        }

        private void ddlProductCategory_SelectedIndexChanged(object sender, EventArgs e) {
            var selectedCategoryId = ddlProductCategory.SelectedValue;
            var _subcategories = SubCategoryServices.GetSubCategoriesByCategoryId(Convert.ToInt32(selectedCategoryId));
            DataHelpers.LoadDataSource(ddlProdSubCategory, _subcategories, "name", "id");
        }
        #endregion Product Form

        //
        //
        //

        #region Variation Form
        public void PopulateMeasuringUnits() {
            var _measuringUnits = MeasuringServices.GetAllMeasuringTypes();
            DataHelpers.LoadDataSource(ddlMeasuringUnit, _measuringUnits, "name", "id");
        }

        public void PopulateDDlProductVariations() {
            var _variations = ProductVariationServices.GetVariationsForProduct(ProductID);
            DataHelpers.LoadDataSource(ddlProductVariation, _variations, "VariationName", "VariationID");
        }

        private void btnSaveVariation_Click(object sender, EventArgs e) {
            // Validate the values of all controls
            bool flag = ValidateControls();
            if (flag == false) {
                return;
            }

            Guid variationId = new Guid();
            Product product = new Product();

            if (VariationID != variationId) {
                product = ProductServices.GetProduct(ProductID);
                ProductVariation variation = new ProductVariation() {
                    VariationID = VariationID,
                    Product_id = product.id,
                    VariationName = txtVariationName.Text.Trim(),
                    image_url = "",
                    measured_by = Convert.ToInt32(ddlMeasuringUnit.SelectedValue),
                    retail_price = txtVariationRetailPrice.Value,
                    wholesale_price = txtVariationWholesalePrice.Value,
                    cost_price = txtVariationCostPrice.Value,
                    weight = txtVariationWeight.Value
                };

                variationId = ProductVariationServices.UpdateProductVariation(variation);
                ControlHelpers.SuccessNotification("Success", "Product variation has been updated successfully!");
                ProductID = 0;
                ProductName = "";
                try {
                    ActionHistoryServices.AddActionHistory(LoginCredentials.username, string.Format("Updated a product variation - {0}", variation.VariationName));
                } catch (Exception ex) {
                    ErrorLogger.LogException(ex, LoginCredentials.username ?? "Not Authenticated", "Trying to save an action history for adding/updating product variation");
                }
                PopulateGridView();
                btnReset_Click(sender, new EventArgs());
            } else {
                ProductVariation variation = new ProductVariation() {
                    VariationID = Guid.NewGuid(),
                    Product_id = ProductID,
                    VariationName = txtVariationName.Text.Trim(),
                    image_url = "",
                    measured_by = Convert.ToInt32(ddlMeasuringUnit.SelectedValue),
                    retail_price = txtVariationRetailPrice.Value,
                    wholesale_price = txtVariationWholesalePrice.Value,
                    cost_price = txtVariationCostPrice.Value,
                    weight = txtVariationWeight.Value,
                };

                variationId = ProductVariationServices.AddProductVariation(variation);
                ControlHelpers.SuccessNotification("Success", "Product variation has been added successfully!");
                ProductID = 0;
                ProductName = "";
                ActionHistoryServices.AddActionHistory(LoginCredentials.username, string.Format("Added a product variation - {0}", variation.VariationName));
                PopulateGridView();
                btnReset_Click(sender, new EventArgs());
            }
        }

        private void btnDeleteVariation_Click(object sender, EventArgs e) {
            ControlHelpers.ErrorNotification("Action Not Supported", "Delete action is not supported, for now!");
            return;
        }
        #endregion Variation Form

        //
        //
        //

        public bool ValidateControls() {
            bool flag = true;
            if (ProductID == 0) {
                ControlHelpers.ErrorNotification("Incomplete Input", "Please select a product!");
                return false;
            }

            if (ddlMeasuringUnit.SelectedValue == null) {
                ControlHelpers.ErrorNotification("Incomplete Input", "Please select a measuring unit!");
                return false;
            }

            if (txtVariationName.Text.Trim() == "") {
                ControlHelpers.ErrorNotification("Incomplete Input", "Please enter a name for this variation!");
                return false;
            }

            if (txtVariationWeight.Value == 0.00M) {
                ControlHelpers.ErrorNotification("Incomplete Input", "Please enter a value for weight!");
                return false;
            }

            if (txtVariationCostPrice.Value == 0.00M) {
                ControlHelpers.ErrorNotification("Incomplete Input", "Please enter a value for cost price!");
                return false;
            }

            if (txtVariationRetailPrice.Value == 0.00M) {
                ControlHelpers.ErrorNotification("Incomplete Input", "Please enter a value for sale price!");
                return false;
            }

            if (txtVariationWholesalePrice.Value == 0.00M) {
                ControlHelpers.ErrorNotification("Incomplete Input", "Please enter a value for sale price!");
                return false;
            }

            return flag;
        }

        private void grdAllProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            grdAllProducts.Rows[e.RowIndex].Selected = true;
            ProductID = Convert.ToInt32(grdAllProducts.Rows[e.RowIndex].Cells[0].Value);
            var _product = ProductServices.GetProduct(ProductID);
            ProductVariations = ProductVariationServices.GetVariationsForProduct(ProductID);
            PopulateDDlProductVariations();
            txtProductName.Text = _product.name;
            ddlProductBrand.SelectedValue = _product.brand_id;
            ddlProductCategory.SelectedValue = _product.Category_id;
            ddlProductDealer.SelectedValue = _product.dealer_id;
            ddlProdSubCategory.SelectedValue = _product.subCategory_id;
            chkProductIsActive.Checked = _product.status;
        }

        private void btnReset_Click(object sender, EventArgs e) {
            ProductID = 0;
            ProductName = "";
            ProductVariations = new List<ProductVariation>();
            VariationID = new Guid();
            txtVariationName.Text = "";
            txtProductName.Text = "";
        }

        private void ddlProductVariation_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                VariationID = Guid.Parse(ddlProductVariation.SelectedValue.ToString());
                var variation = ProductVariationServices.GetProductVariation(VariationID);
                txtVariationName.Text = variation.VariationName;
                ddlMeasuringUnit.SelectedValue = variation.measured_by;
                txtVariationWeight.Value = variation.weight;
                txtVariationCostPrice.Value = variation.cost_price;
                txtVariationRetailPrice.Value = variation.retail_price;
            } catch (Exception) {
            }
        }

        private void ddlProductVariation_DropDownClosed(object sender, EventArgs e) {
        }

        private void btnAddNewMeasuringUnit_Click(object sender, EventArgs e) {
            AddUpdateMeasuringUnit unit = new AddUpdateMeasuringUnit();
            unit.ShowDialog(this);
            PopulateMeasuringUnits();
        }
    }
}
