using BusinessLayer;
using ComponentFactory.Krypton.Toolkit;
using DataLayer;
using Inventory.Helpers;
using Inventory.Model;
using Inventory.Utils;
using Inventory.View.Helpers;
using System;
using System.Windows.Forms;

namespace Inventory.View.Products {
    public partial class AddUpdateProduct : KryptonForm {
        private int ProductID = 0;
        private string _selectedPath;
        public string _Path = string.Empty;
        public string SelectedPath {
            get {
                if (_selectedPath == "" || _selectedPath == null) {
                    _selectedPath = InventoryHelper.ImageNA;
                }
                return _selectedPath;
            }

            set {
                _selectedPath = value;
            }
        }

        public AddUpdateProduct() {
            InitializeComponent();

            // Populate Dealer ComboBox
            PopulateDDLProdDealer();

            // Populate Category ComboBox
            PopulateDDLProdCategory();

            // Populate SubCategory ComboBox if action is for an update
            if (BaseObject<Product>.value != null) {
                var subCategories = SubCategoryServices.GetAllSubCategories();
                DataHelpers.LoadDataSource(ddlProdSubCategory, subCategories, "name", "id");
            }

            // Populate Controls with data with if any
            PopulateControls();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            // Close Window
            Close();
        }

        private void btnAddUpdateProduct_Click(object sender, EventArgs e) {
            var productName = txtProductName.Text.Trim();
            if (productName == string.Empty) {
                KryptonMessageBox.Show("Product name should not be empty!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ProductServices.CheckProductNameAvailable(productName) && BaseObject<Product>.name == "") {
                KryptonMessageBox.Show("Product name is already taken!", "Name Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try {
                Product _product = new Product();
                if (BaseObject<Product>.value != null & ProductID != 0) {
                    var id = BaseObject<Product>.value.id;
                    _product = ProductServices.GetProduct(id);
                }

                _product.name = productName;
                _product.brand = txtProductBrand.Text.Trim();
                _product.dealer_id = Convert.ToInt32(ddlProductDealer.SelectedValue);
                _product.cost_price = txtProductCostPrice.Value;
                _product.sell_price = txtProductSalePrice.Value;
                _product.Category_id = Convert.ToInt32(ddlProductCategory.SelectedValue);
                _product.subCategory_id = Convert.ToInt32(ddlProdSubCategory.SelectedValue);
                _product.weight = Convert.ToString(Convert.ToDecimal(txtProductWeight.Value));
                _product.Stock = 0;
                _product.status = true;

                int productId = ProductServices.AddUpdateProduct(_product);
                if (productId > 0) {
                    if (_product.id == 0) {
                        ControlHelpers.SuccessNotification("Product Added", "Product was created succesfully!");
                    } else {
                        ControlHelpers.SuccessNotification("Product Updated", "Product was updated successfully");
                    }

                    ClearControlValues();
                    BaseObject<Product>.value = null;
                    BaseObject<Product>.name = "";
                }
            } catch (Exception ex) {
                ErrorLogger.LogException(ex, LoginCredentials.username, "Adding/Updating a new product");
                //KryptonMessageBox.Show("Product could not be saved!", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void PopulateDDLProdDealer() {
            var _dealers = DealerServices.GetAllDealers();
            DataHelpers.LoadDataSource(ddlProductDealer, _dealers, "name", "id");
        }

        public void PopulateDDLProdCategory() {
            var _categories = CategoryServices.GetAllCategories();
            DataHelpers.LoadDataSource(ddlProductCategory, _categories, "name", "id");
        }

        private void ddlProductCategory_SelectedIndexChanged(object sender, EventArgs e) {
            var selectedCategoryId = ddlProductCategory.SelectedValue;
            var _subcategories = SubCategoryServices.GetSubCategoriesByCategoryId(Convert.ToInt32(selectedCategoryId));
            DataHelpers.LoadDataSource(ddlProdSubCategory, _subcategories, "name", "id");
        }

        private void ClearControlValues() {
            txtProductName.Text = "";
            txtProductBrand.Text = "";
            txtProductSalePrice.Value = 0;
            txtProductWeight.Value = 0;
            txtProductCostPrice.Value = 0;
            txtProdSuppliedQty.Value = 0;
        }

        private void PopulateControls() {
            if (BaseObject<Product>.value != null) {
                ProductID = BaseObject<Product>.value.id;
                txtProductName.Text = BaseObject<Product>.value.name;
                txtProductBrand.Text = BaseObject<Product>.value.brand;
                ddlProductDealer.SelectedValue = BaseObject<Product>.value.dealer_id;
                ddlProductCategory.SelectedValue = BaseObject<Product>.value.Category_id;
                ddlProdSubCategory.SelectedValue = BaseObject<Product>.value.subCategory_id;
                txtProductSalePrice.Value = BaseObject<Product>.value.sell_price;
                txtProductWeight.Value = Convert.ToDecimal(BaseObject<Product>.value.weight);
                txtProductCostPrice.Value = Convert.ToDecimal(BaseObject<Product>.value.cost_price);
            }
        }
    }
}