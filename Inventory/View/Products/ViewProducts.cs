using BusinessLayer;
using DataLayer;
using EntityLayer;
using Inventory.Helpers;
using Inventory.Model;
using Inventory.View.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static Inventory.Helpers.InventoryHelper;
using static Inventory.Helpers.StringHelpers;

namespace Inventory.View.Products {
    public partial class ViewProducts : UserControl {
        public new string ProductName = "";
        public int ProductID = 0;
        public List<ProductEntity> ProductEntities = new List<ProductEntity>();
        public List<ProductEntity> SortedEntities = new List<ProductEntity>();
        public ViewProducts() {
            InitializeComponent();

            // Populate GridView
            PopulateGridView(null);

            // Populate Sort ComboBox
            LoadSortChoices();
            LoadSortOrder();
        }

        private void PopulateGridView(List<ProductEntity> products) {
            var _products = new List<ProductEntity>();
            if (products != null) {
                _products = products;
            } else {
                _products = ProductServices.GetAllProductEntity();
                ProductEntities = _products;
                SortedEntities = _products;
            }
            DataHelpers.LoadGridViewData(grdViewAllProducts, _products);
        }

        public void LoadSortChoices() {
            ddlSortProducts.DataSource = Enum.GetValues(typeof(SortChoices));
        }

        public void LoadSortOrder() {
            ddlSortOrder.DataSource = Enum.GetValues(typeof(InventoryHelper.SortOrder));
        }

        private void btnSearchProductByName_Click(object sender, System.EventArgs e) {
            var searchText = txtSearchProductByName.Text;
            if (searchText != "") {
                var products = ProductEntities.Where(p => p.name.Equals(searchText, StringComparison.OrdinalIgnoreCase) || p.name.CaseInsensitiveContains(searchText)).ToList();
                SortedEntities = products;
                PopulateGridView(products);
            }
        }

        private void btnSearchProductsByBrand_Click(object sender, System.EventArgs e) {
            var searchText = txtSearchProductsByBrand.Text;
            if (searchText != "") {
                var products = ProductEntities.Where(p => p.brand.Equals(searchText, StringComparison.OrdinalIgnoreCase) || p.brand.CaseInsensitiveContains(searchText)).ToList();
                SortedEntities = products;
                PopulateGridView(products);
            }
        }

        private void btnResetSearch_Click(object sender, EventArgs e) {
            PopulateGridView(null);
            txtSearchProductByName.Text = "";
            txtSearchProductsByBrand.Text = "";
        }

        private void ddlSortProducts_SelectedIndexChanged(object sender, EventArgs e) {
            var selectedSort = ddlSortProducts.SelectedItem.ToString();
            var sortOrder = ddlSortOrder.SelectedItem.ToString();
            if (sortOrder == "" || sortOrder == null) {
                ControlHelpers.ErrorNotification("Incomplete Input", "Select an order - either Ascending or Descending!");
                return;
            }
            if (selectedSort != null || selectedSort != "") {
                var products = new List<ProductEntity>();
                switch (selectedSort) {
                    case "Name":
                        if (sortOrder == "Ascending") {
                            products = SortedEntities.OrderBy(p => p.name).ToList();
                        } else {
                            products = SortedEntities.OrderByDescending(p => p.name).ToList();
                        }
                        break;
                    case "Brand":
                        if (sortOrder == "Ascending") {
                            products = SortedEntities.OrderBy(p => p.brand).ToList();
                        } else {
                            products = SortedEntities.OrderByDescending(p => p.brand).ToList();
                        }
                        break;
                    case "Category":
                        if (sortOrder == "Ascending") {
                            products = SortedEntities.OrderBy(p => p.category_name).ToList();
                        } else {
                            products = SortedEntities.OrderByDescending(p => p.category_name).ToList();
                        }
                        break;
                    case "SubCategory":
                        if (sortOrder == "Ascending") {
                            products = SortedEntities.OrderBy(p => p.subcategory_name).ToList();
                        } else {
                            products = SortedEntities.OrderByDescending(p => p.subcategory_name).ToList();
                        }
                        break;
                    case "SalePrice":
                        if (sortOrder == "Ascending") {
                            products = SortedEntities.OrderBy(p => p.sell_price).ToList();
                        } else {
                            products = SortedEntities.OrderByDescending(p => p.sell_price).ToList();
                        }
                        break;
                    case "Stock":
                        if (sortOrder == "Ascending") {
                            products = SortedEntities.OrderBy(p => p.Stock).ToList();
                        } else {
                            products = SortedEntities.OrderByDescending(p => p.Stock).ToList();
                        }
                        break;
                }

                PopulateGridView(products);
            } else {
                PopulateGridView(null);
            }
        }

        private void ddlSortOrder_SelectedIndexChanged(object sender, EventArgs e) {
            ddlSortProducts_SelectedIndexChanged(this, new EventArgs());
        }

        private void grdViewAllProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            grdViewAllProducts.Rows[e.RowIndex].Selected = true;
            ProductName = grdViewAllProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
            var product = ProductServices.GetProductsByName(ProductName).FirstOrDefault();
            ProductID = product.id;

            BaseObject<Product>.name = "Product";
            BaseObject<Product>.value = product;

            using (AddUpdateProduct p = new AddUpdateProduct()) {
                p.ShowDialog(this);
            }
        }
    }
}