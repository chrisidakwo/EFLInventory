using BusinessLayer;
using DataLayer;
using EntityLayer;
using Inventory.Helpers;
using Inventory.View.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Inventory.View.Dealers {
    public partial class ViewDealers : UserControl {
        public int RowID = 0;
        public string DealerName = "";
        public List<DealerEntity> Dealers = new List<DealerEntity>();
        public List<DealerEntity> SortedDealers = new List<DealerEntity>();
        public ViewDealers() {
            InitializeComponent();

            // Populate DataGridView
            this.PopulateGridView(null);

            // Populate Brands
            PopulateDDLBrand();

            // Populate sort order ComboBox
            ddlSortOrder.DataSource = Enum.GetValues(typeof(InventoryHelper.SortOrder));

            // Populate sort by ComboBox
            ddlSortBy.DataSource = Enum.GetValues(typeof(SortDealersBy));
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="dealers"></param>
        public void PopulateGridView(List<DealerEntity> dealers) {
            var _dealers = new List<DealerEntity>();
            if (dealers != null) {
                _dealers = dealers;
            } else {
                _dealers = DealerServices.GetAllDealerEntity();
                Dealers = _dealers;
                SortedDealers = _dealers;
            }

            DataHelpers.LoadGridViewData(grdViewAllDealers, _dealers);
        }

        public void PopulateDDLBrand() {
            var _brands = BrandServices.GetAllBrands();
            DataHelpers.LoadDataSource(ddlSelectBrand, _brands, "name", "id");
        }

        private void btnAddDealer_Click(object sender, EventArgs e) {
            var _dealerName = txtDealerName.Text.Trim();
            DealerName = _dealerName;

            #region Run check on txtDealerName
            if (_dealerName == "") {
                ControlHelpers.ErrorNotification("Input Error", "Dealer's name cannot be empty");
                return;
            }

            var nameExists = Dealers.Where(d => d.name == _dealerName).Count();
            if (nameExists > 0) {
                ControlHelpers.ErrorNotification("Name Exists!", "Exact name already exists in your. Add a little more information to the name.");
                return;
            }
            #endregion Run check on txtDealerName

            #region Instantiate variables and a new Dealer instance
            var phone = txtDealerPhone.Text.Trim();
            var email = txtDealerEmail.Text.Trim();
            var address = txtDealerAddress.Text.Trim();
            var brandId = ddlSelectBrand.SelectedValue.ToString();
            Dealer _dealer = new Dealer() {
                name = DealerName,
                email = email,
                phone = phone,
                Brand_id = Convert.ToInt32(brandId),
                address = address
            };
            #endregion Instantiate variables and a new Dealer instance

            #region Try add the _dealer instance
            try {
                int id = DealerServices.AddUpdateDealer(_dealer);
                if (id > 0) {
                    PopulateGridView(null);
                    ControlHelpers.SuccessNotification("Dealer Added", "Dealer was added successfully!");
                }
            } catch (Exception) {
                ControlHelpers.ErrorNotification("Database Error", "A database error occurred while saving dealer's information");
            }
            #endregion Try add the _dealer instance

            // Reset global variables
            ResetValues();
        }

        private void btnUpdateDealer_Click(object sender, EventArgs e) {
            if (RowID == 0) {
                ControlHelpers.ErrorNotification("Input Error", "Select a row!");
                return;
            }

            if (txtDealerPhone.Text == "") {
                ControlHelpers.ErrorNotification("Input Error", "Input a phone number!");
                return;
            }

            DealerName = txtDealerName.Text.Trim();

            #region Run check on txtDealerName
            if (DealerName == "") {
                ControlHelpers.ErrorNotification("Input Error", "Dealer's name cannot be empty");
                return;
            }
            #endregion Run check on txtDealerName

            #region Instantiate variables and a new Dealer instance
            var phone = txtDealerPhone.Text.Trim();
            var email = txtDealerEmail.Text.Trim();
            var address = txtDealerAddress.Text.Trim();
            var brandID = ddlSelectBrand.SelectedValue.ToString();
            Dealer _dealer = new Dealer() {
                id = RowID,
                name = DealerName,
                email = email,
                phone = phone,
                Brand_id = Convert.ToInt32(brandID),
                address = address
            };
            #endregion Instantiate variables and a new Dealer instance

            #region Try update the _dealer instance
            try {
                DealerServices.AddUpdateDealer(_dealer);
                PopulateGridView(null);
                ControlHelpers.SuccessNotification("Dealer Updated", "Dealer was updated successfully!");
            } catch (Exception) {
                ControlHelpers.ErrorNotification("Database Error!", "Dealer's information could nto be updated!A database error occurred while updating dealer's information");
            }
            #endregion Try update the _dealer instance

            // Reset global variables
            ResetValues();
        }

        private void btnSearchDealerByName_Click(object sender, EventArgs e) {
            var sortOrder = ddlSortOrder.SelectedItem.ToString();
            var sortBy = ddlSortBy.SelectedItem.ToString();
            var searchText = txtSearchDealer.Text.Trim();

            switch (sortBy) {
                case "Name":
                    if (searchText != "") {
                        SortedDealers = Dealers.Where(d => d.name == searchText || d.name.CaseInsensitiveContains(searchText)).ToList();
                    }
                    if (sortOrder == "Ascending") {
                        SortedDealers = SortedDealers.OrderBy(d => d.name).ToList();
                    } else if (sortOrder == "Descending") {
                        SortedDealers = SortedDealers.OrderByDescending(d => d.name).ToList();
                    }
                    break;
                case "Products":
                    if (searchText != "") {
                        SortedDealers = Dealers.Where(d => d.products == searchText || d.products.CaseInsensitiveContains(searchText)).ToList();
                    }
                    if (sortOrder == "Ascending") {
                        SortedDealers = SortedDealers.OrderBy(d => d.name).ToList();
                    } else if (sortOrder == "Descending") {
                        SortedDealers = SortedDealers.OrderByDescending(d => d.products).ToList();
                    }
                    break;
            }

            PopulateGridView(SortedDealers);
        }

        private void btnResetSort_Click(object sender, EventArgs e) {
            PopulateGridView(null);
            RowID = 0;
            txtSearchDealer.Text = "";
        }

        private void ddlSortBy_SelectedIndexChanged(object sender, EventArgs e) {
            btnSearchDealerByName_Click(this, new EventArgs());
        }

        private void ddlSortOrder_SelectedIndexChanged(object sender, EventArgs e) {
            btnSearchDealerByName_Click(this, new EventArgs());
        }

        public void grdViewAllDealers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            grdViewAllDealers.Rows[e.RowIndex].Selected = true;
            RowID = Convert.ToInt32(grdViewAllDealers.Rows[e.RowIndex].Cells[0].Value.ToString());
            var dealer = Dealers.Where(d => d.id == RowID).FirstOrDefault();
            DealerName = dealer.name;
            txtDealerName.Text = DealerName;
            txtDealerEmail.Text = dealer.email;
            txtDealerPhone.Text = dealer.phone;
            txtDealerAddress.Text = dealer.address;
            ddlSelectBrand.SelectedValue = dealer.brand_id;
        }

        public void ResetValues() {
            RowID = 0;
            DealerName = "";
            txtDealerName.Text = "";
            txtDealerPhone.Text = "";
            txtDealerEmail.Text = "";
            txtDealerAddress.Text = "";
        }

        private void btnAddNewBrand_Click(object sender, EventArgs e) {
            AddUpdateBrand brand = new AddUpdateBrand();
            brand.ShowDialog(this);
            PopulateDDLBrand();
        }
    }

    public enum SortDealersBy {
        Name = 1,
        Products = 2
    }
}
