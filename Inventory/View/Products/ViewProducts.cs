using BusinessLayer;
using EntityLayer;
using Inventory.Helpers;
using Inventory.View.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using static Inventory.Helpers.StringHelpers;

namespace Inventory.View.Products {
    public partial class ViewProducts : UserControl {
        public new string ProductName = "";
        public string FileName = "";
        public Guid VariationID = new Guid();
        public int ProductID = 0;
        public List<ProductVariationEntity> ProductEntities = new List<ProductVariationEntity>();
        public List<ProductVariationEntity> SortedEntities = new List<ProductVariationEntity>();
        public ViewProducts() {
            InitializeComponent();

            // Populate GridView
            PopulateGridView(null);

            // Populate Sort ComboBox
            LoadSortChoices();
            LoadSortOrder();
        }

        private void PopulateGridView(List<ProductVariationEntity> products) {
            var _products = new List<ProductVariationEntity>();
            if (products != null) {
                _products = products;
            } else {
                _products = ProductVariationServices.GetAllProductsWithVariations();
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
                var variations = ProductEntities.Where(v => v.ProductName.Equals(searchText, StringComparison.OrdinalIgnoreCase) || v.ProductName.CaseInsensitiveContains(searchText)).ToList();
                SortedEntities = variations;
                PopulateGridView(variations);
            }
        }

        private void btnSearchProductsByBrand_Click(object sender, System.EventArgs e) {
            var searchText = txtSearchProductsByBrand.Text;
            if (searchText != "") {
                var products = ProductEntities.Where(v => v.BrandName.Equals(searchText, StringComparison.OrdinalIgnoreCase) || v.BrandName.CaseInsensitiveContains(searchText)).ToList();
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

            grdViewAllProducts.Sort(grdViewAllProducts.Columns[0], ListSortDirection.Ascending);

            if (sortOrder == "" || sortOrder == null) {
                ControlHelpers.ErrorNotification("Incomplete Input", "Select an order - either Ascending or Descending!");
                return;
            }
            if (selectedSort != null || selectedSort != "") {
                var products = new List<ProductVariationEntity>();
                switch (selectedSort) {
                    case "Name":
                        if (sortOrder == "Ascending") {
                            products = SortedEntities.OrderBy(v => v.ProductName).ToList();
                        } else {
                            products = SortedEntities.OrderByDescending(v => v.ProductName).ToList();
                        }
                        break;
                    case "Brand":
                        if (sortOrder == "Ascending") {
                            products = SortedEntities.OrderBy(v => v.BrandName).ToList();
                        } else {
                            products = SortedEntities.OrderByDescending(v => v.BrandName).ToList();
                        }
                        break;
                    case "Category":
                        if (sortOrder == "Ascending") {
                            products = SortedEntities.OrderBy(v => v.CategoryName).ToList();
                        } else {
                            products = SortedEntities.OrderByDescending(v => v.CategoryName).ToList();
                        }
                        break;
                    case "SubCategory":
                        if (sortOrder == "Ascending") {
                            products = SortedEntities.OrderBy(v => v.SubCategoryName).ToList();
                        } else {
                            products = SortedEntities.OrderByDescending(v => v.SubCategoryName).ToList();
                        }
                        break;
                    case "SalePrice":
                        if (sortOrder == "Ascending") {
                            products = SortedEntities.OrderBy(v => v.retail_price).ToList();
                        } else {
                            products = SortedEntities.OrderByDescending(v => v.retail_price).ToList();
                        }
                        break;
                    case "Stock":
                        if (sortOrder == "Ascending") {
                            products = SortedEntities.OrderBy(v => v.stock).ToList();
                        } else {
                            products = SortedEntities.OrderByDescending(v => v.stock).ToList();
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

        private void btnGenerateReportAsExcel_Click(object sender, EventArgs e) {
            FileName = txtReportFilename.Text;
            if (FileName != "") {
                DocumentHelpers.ExportToExcel(ProductEntities, FileName);
                return;
            }

            DocumentHelpers.ExportToExcel(ProductEntities, @"Our Products");
        }

        private void btnGenerateReportAsCSV_Click(object sender, EventArgs e) {
            FileName = txtReportFilename.Text;
            if (FileName != "") {
                DocumentHelpers.ExportToCSV(ProductEntities, FileName);
                return;
            }

            DocumentHelpers.ExportToCSV(ProductEntities, @"Our Products");
        }

        public enum SortChoices {
            [Description("Name")]
            Name = 0,
            [Description("Brand")]
            Brand = 1,
            [Description("Category")]
            Category = 2,
            [Description("SubCategory")]
            SubCategory = 3,
            [Description("Stock")]
            Stock = 4,
            [Description("Sale Price")]
            SalePrice = 5
        }
    }
}
