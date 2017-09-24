using BusinessLayer;
using ComponentFactory.Krypton.Toolkit;
using DataLayer;
using EntityLayer;
using Inventory.Helpers;
using Inventory.View.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Inventory.View.SubCategories {
    public partial class ViewSubCategories : UserControl {
        private int RowID = 0;
        private string SubCategoryName = "";
        private List<SubCategoryEntity> SubCategories = new List<SubCategoryEntity>();
        private List<SubCategoryEntity> SortedSubCategories = new List<SubCategoryEntity>();
        public ViewSubCategories() {
            InitializeComponent();

            // Populate DataGridView
            PopulateGridView(null);

            // Populate Categories ComboBox
            PopulateDDLCategories(null);

            // Populate sort ComboBoxes
            ddlSortBy.DataSource = Enum.GetValues(typeof(SortBy));
            ddlSortOrder.DataSource = Enum.GetValues(typeof(InventoryHelper.SortOrder));
        }

        public void PopulateGridView(List<SubCategoryEntity> subcategories) {
            var _subcategories = new List<SubCategoryEntity>();
            if (subcategories != null) {
                _subcategories = subcategories;
            } else {
                _subcategories = SubCategoryServices.GetAllSubCategoryEntity();
                SubCategories = _subcategories;
                SortedSubCategories = _subcategories;
            }
            DataHelpers.LoadGridViewData(grdViewSubCategories, _subcategories);
        }

        public void PopulateDDLCategories(List<Category> _categories) {
            var categories = new List<Category>();
            if (_categories != null) {
                categories = _categories;
            } else {
                categories = CategoryServices.GetAllCategories();
            }
            DataHelpers.LoadDataSource(ddlCategories, categories, "name", "id");
        }

        private void btnAddSubCategory_Click(object sender, System.EventArgs e) {
            SubCategoryName = txtSubCategoryName.Text.Trim();
            if (SubCategoryName == "") {
                ControlHelpers.ErrorNotification("Invalid Input", "SubCategory name cannot be empty!");
                return;
            }

            if (ddlCategories.SelectedValue.ToString() == "0" || ddlCategories.SelectedValue.ToString() == "") {
                ControlHelpers.ErrorNotification("Invalid Input", "Select a category!");
                return;
            }

            // If subcategory exists, return. Create a new one otherwise.
            var subCategoryEntity = SubCategories.Where(s => s.name == SubCategoryName).FirstOrDefault();
            var subCategory = new SubCategory();

            if (subCategoryEntity == null) {
                subCategory.name = SubCategoryName;
                subCategory.Category_id = Convert.ToInt32(ddlCategories.SelectedValue);
            } else {
                ControlHelpers.ErrorNotification("Duplicate Name", "SubCategory with similar name already exists!");
                return;
            }

            // Save created SubCategory to db
            try {
                int id = SubCategoryServices.AddUpdateSubCategory(subCategory);
                if (id > 0) {
                    PopulateGridView(null);
                    ControlHelpers.SuccessNotification("New SubCategory Created", SubCategoryName + " subcategory created successfully!");
                    txtSubCategoryName.Text = "";
                    SubCategoryName = "";
                } else {
                    ControlHelpers.ErrorNotification("Save Error", "SubCategory was not saved in the database!");
                }
            } catch (Exception) {
                ControlHelpers.ErrorNotification("Database Error", "An error occurred while saving subcategory.");
            }
        }

        private void btnUpdateSubCategory_Click(object sender, System.EventArgs e) {
            SubCategoryName = txtSubCategoryName.Text.Trim();

            #region Run checks on RowID, txtSubCategory, and ddlCategories
            if (RowID == 0) {
                ControlHelpers.ErrorNotification("Invalid Selection", "Please select a row!");
                return;
            }

            if (SubCategoryName == "") {
                ControlHelpers.ErrorNotification("Invalid Input", "SubCategory name should not be empty!");
                return;
            }

            var subCategoryEntity = SubCategories.Where(s => s.name == SubCategoryName).FirstOrDefault();
            if (subCategoryEntity != null) {
                ControlHelpers.ErrorNotification("Duplicate Name", "SubCategory with similar name already exists!");
                return;
            }

            if (ddlCategories.SelectedValue.ToString() == "0" || ddlCategories.SelectedValue.ToString() == "") {
                ControlHelpers.ErrorNotification("Invalid Input", "Please select a category");
                return;
            }
            #endregion Run checks on RowID, txtSubCategory, and ddlCategories

            // Once all checks are fine, create a new SubCategory from RowID, ddlCategories selection and txtSubCategory value
            SubCategory sc = new SubCategory() {
                id = RowID,
                name = SubCategoryName,
                Category_id = Convert.ToInt32(ddlCategories.SelectedValue.ToString())
            };

            // Try update subcategory with the provided ID. If any error, catch and display error notification
            try {
                SubCategoryServices.AddUpdateSubCategory(sc);
                PopulateGridView(null);
                ControlHelpers.SuccessNotification("SubCategory Updated", "SubCategory has been updated successfully!");
                RowID = 0;
                SubCategoryName = "";
                txtSubCategoryName.Text = "";
            } catch (Exception) {
                ControlHelpers.ErrorNotification("Database Error", "An error occurred while updating " + SubCategoryName + " in the database!");
            }
        }

        private void btnDeleteSubCategory_Click(object sender, EventArgs e) {
            SubCategoryName = txtSubCategoryName.Text.Trim();
            #region Run checks on RowID, txtSubCategoryName, ddlCategories
            if (RowID == 0) {
                ControlHelpers.ErrorNotification("Invalid Selection", "Please select a row!");
                return;
            }

            if (txtSubCategoryName.Text == "") {
                ControlHelpers.ErrorNotification("Invalid Input", "SubCategory name should not be empty!");
                return;
            }

            if (ddlCategories.SelectedValue.ToString() == "0" || ddlCategories.SelectedValue.ToString() == "") {
                ControlHelpers.ErrorNotification("Invalid Input", "Please select a category");
                return;
            }
            #endregion Run checks on RowID, txtSubCategoryName, ddlCategories

            var subProducts = ProductServices.GetAllProducts().Where(p => p.subCategory_id == RowID).Count();
            if (subProducts > 0) {
                ControlHelpers.ErrorNotification("Cannot Delete SubCategory", "Subcategory is associated with products which must first be deleted or disassociated to avoid conflicts in your records!");
                return;
            }

            bool flag = false;
            try {
                DialogResult dr = new DialogResult();
                dr = KryptonMessageBox.Show(string.Format("Are you sure you want to delete SubCategory: {0}", SubCategoryName), "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (dr) {
                    case DialogResult.Yes:
                        flag = SubCategoryServices.DeleteSubCategory(RowID);
                        break;
                    case DialogResult.No:
                        break;
                }
            } catch (Exception) {
                ControlHelpers.ErrorNotification("Database Error", "An error occurred while deleting subcategory from the database");
            }

            if (flag) {
                PopulateGridView(null);
                ControlHelpers.SuccessNotification("SubCategory Deleted", "SubCategory has been deleted successfully");
                RowID = 0;
                SubCategoryName = "";
                txtSubCategoryName.Text = "";
            } else {
                ControlHelpers.ErrorNotification("Delete Action Stopped", "SubCategory was not deleted!");
            }
        }

        private void grdViewSubCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            grdViewSubCategories.Rows[e.RowIndex].Selected = true;
            RowID = Convert.ToInt32(grdViewSubCategories.Rows[e.RowIndex].Cells[0].Value.ToString());
            var subCategory = SubCategoryServices.GetSubCategory(RowID);
            txtSubCategoryName.Text = subCategory.name;
            SubCategoryName = subCategory.name;
            ddlCategories.SelectedValue = subCategory.Category_id;
        }

        private void btnSearchSubCategories_Click(object sender, EventArgs e) {
            var sortBy = ddlSortBy.SelectedItem.ToString();
            var sortOrder = ddlSortOrder.SelectedItem.ToString();
            var searchText = txtSearchSubCategories.Text.Trim();

            switch (sortBy) {
                case "Name":
                    if (searchText != "") {
                        SortedSubCategories = SubCategories.Where(s => s.name == searchText || s.name.CaseInsensitiveContains(searchText)).ToList();
                    }

                    if (sortOrder == "Ascending") {
                        SortedSubCategories = SortedSubCategories.OrderBy(s => s.name).ToList();
                    } else if (sortOrder == "Descending") {
                        SortedSubCategories = SortedSubCategories.OrderByDescending(s => s.name).ToList();
                    }
                    break;
                case "Category":
                    if (searchText != "") {
                        SortedSubCategories = SubCategories.Where(s => s.category_name == searchText || s.category_name.CaseInsensitiveContains(searchText)).ToList();
                    }

                    if (sortOrder == "Ascending") {
                        SortedSubCategories = SubCategories.OrderBy(s => s.category_name).ToList();
                    } else if (sortOrder == "Descending") {
                        SortedSubCategories = SortedSubCategories.OrderByDescending(s => s.category_name).ToList();
                    }
                    break;
            }

            PopulateGridView(SortedSubCategories);
        }

        private void btnResetSubCategories_Click(object sender, EventArgs e) {
            PopulateGridView(null);
            txtSearchSubCategories.Text = "";
            ddlSortBy.SelectedIndex = 0;
            ddlSortOrder.SelectedIndex = 0;
        }

        private void ddlSortBy_SelectedIndexChanged(object sender, EventArgs e) {
            btnSearchSubCategories_Click(this, new EventArgs());
        }

        private void ddlSortOrder_SelectedIndexChanged(object sender, EventArgs e) {
            btnSearchSubCategories_Click(this, new EventArgs());
        }
    }

    public enum SortBy {
        Name = 0,
        Category = 1
    }
}
