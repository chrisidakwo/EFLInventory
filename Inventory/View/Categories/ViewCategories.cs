using BusinessLayer;
using ComponentFactory.Krypton.Toolkit;
using DataLayer;
using Inventory.Helpers;
using Inventory.View.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ToastNotification;
using static Inventory.ToastNotification.NotificationSound;
using static ToastNotification.FormAnimator;

namespace Inventory.View.Categories {
    public partial class ViewCategories : UserControl {
        public int RowID = 0;
        public string CategoryNAME = "";
        public List<Category> Categories = new List<Category>();
        public List<Category> SortedCategories = new List<Category>();
        public ViewCategories() {
            InitializeComponent();

            // Populate DataGridView
            this.PopulateGridView(null);

            // Populate Sort By ComboBox
            this.LoadDLLSortOrder();
        }

        public void LoadDLLSortOrder() {
            ddlSortCategoryName.DataSource = Enum.GetValues(typeof(InventoryHelper.SortOrder));
        }

        public void PopulateGridView(List<Category> categories) {
            var _categories = new List<Category>();
            if (categories != null) {
                _categories = categories;
            } else {
                _categories = CategoryServices.GetAllCategories();
                Categories = _categories;
                SortedCategories = _categories;
            }

            DataHelpers.LoadGridViewData(grdViewCategories, _categories);
        }

        private void btnAddCategory_Click(object sender, EventArgs e) {
            // Ensure category name is not empty
            var category_name = txtCategoryName.Text.Trim();
            if (category_name.Equals(String.Empty)) {
                ControlHelpers.ErrorNotification("Invalid Input", "Category name cannot be empty!");
                return;
            }

            // Retrieve category by name (if it exists) or create a new one
            // If category exists, return
            var _category = Categories.Where(c => c.name == category_name).FirstOrDefault();
            if (_category == null) {
                _category = new Category() {
                    name = category_name,
                };
            } else {
                ControlHelpers.ErrorNotification("Category Exists", category_name.ToLower().Replace(category_name.Substring(0, 1), category_name.Substring(0, 1).ToUpper()) + " already exists!");
                return;
            }

            // Add category to database
            // Show success or error message. TODO: Log error message (if any).
            // Log user action
            try {
                int id = CategoryServices.AddUpdateCategory(_category);
                if (id > 0) {
                    PopulateGridView(null);
                    Notification n = new Notification("New Category Created", category_name + " category created successfully!", 7, AnimationMethod.Slide, AnimationDirection.Up);
                    PlayNotificationSound(Sounds.Success);
                    n.Show();
                    txtCategoryName.Text = "";
                    CategoryNAME = "";

                    string description = "Added a new category: " + category_name;
                    //int userid = LoginCredentials.userid;
                    //var flag = ActionHistoryServices.AddActionHistory(userid, description);
                    //if (flag != true) {
                    //    // Log message in text file and Log DB table to show description of action and that creating an ActionHistory failed.
                    //}
                } else {
                    Notification n = new Notification("Save Error", "Category was not saved in the database!", 7, AnimationMethod.Slide, AnimationDirection.Up);
                    PlayNotificationSound(Sounds.Error);
                    n.Show();
                }
            } catch (Exception) {
                Notification n = new Notification("An error occurred while saving category.", "Database Error!", 7, AnimationMethod.Slide, AnimationDirection.Up);
                PlayNotificationSound(Sounds.Error);
                n.Show();
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e) {
            if (RowID == 0) {
                Notification n = new Notification("Invalid Input", "Click to select a row!", 7, AnimationMethod.Slide, AnimationDirection.Up);
                PlayNotificationSound(Sounds.Error);
                n.Show();
                return;
            }

            if (txtCategoryName.Text == "") {
                Notification n = new Notification("Invalid Input", "Category name cannot be empty!", 7, AnimationMethod.Slide, AnimationDirection.Up);
                PlayNotificationSound(Sounds.Error);
                n.Show();
                return;
            }

            var category = new Category() {
                id = RowID,
                name = CategoryNAME
            };

            try {
                int x = CategoryServices.AddUpdateCategory(category);
                if (x > 0) {
                    PopulateGridView(null);
                    ControlHelpers.SuccessNotification("Category Updated!", "Category name has been updated successfuly!");
                    RowID = 0;
                    CategoryNAME = "";
                    txtCategoryName.Text = "";
                } else {
                    Notification n = new Notification("Update Error", "Category name was not updated!", 7, AnimationMethod.Slide, AnimationDirection.Up);
                    PlayNotificationSound(Sounds.Error);
                    n.Show();
                }
            } catch (Exception) {
                Notification n = new Notification("An error occurred while updating category name.", "Database Error!", 7, AnimationMethod.Slide, AnimationDirection.Up);
                PlayNotificationSound(Sounds.Error);
                n.Show();
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e) {
            if (RowID == 0) {
                ControlHelpers.ErrorNotification("Invalid Input", "Click to select a row!");
                return;
            }

            var categorySubCategories = SubCategoryServices.GetAllSubCategories().Where(s => s.Category_id == RowID).Count();
            var categoryProduct = ProductServices.GetAllProducts().Where(p => p.Category_id == RowID).Count();

            if (categorySubCategories > 0) {
                ControlHelpers.ErrorNotification("Cannot Delete Category", "There are subcategories associated with this category. Ensure to remove or delete such association(s) before trying again!");
                return;
            }

            if (categoryProduct > 0) {
                ControlHelpers.ErrorNotification("Cannot Delete Category", "There are products associated with this category. Ensure to remove such association(s) before trying again!");
                return;
            }

            bool flag = false;
            try {
                DialogResult dr = new DialogResult();
                dr = KryptonMessageBox.Show(string.Format("I suggest that you do not delete this category, but rather disassociate products and subcategories from it, to avoid conflicts in your record.\n\n" + "Click 'Yes' if you still want to delete category: {0}", CategoryNAME), "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (dr) {
                    case DialogResult.Yes:
                        flag = CategoryServices.DeleteCategory(RowID);
                        break;
                    case DialogResult.No:
                        break;
                }
            } catch (Exception) {
                ControlHelpers.ErrorNotification("An error occurred while deleting category!", "Database Error!");
            }

            if (flag) {
                PopulateGridView(null);
                ControlHelpers.SuccessNotification("Category Deleted!", "Category has been deleted successfuly!");
                RowID = 0;
                CategoryNAME = "";
                txtCategoryName.Text = "";
            } else {
                ControlHelpers.ErrorNotification("Delete Action Stopped", "Category was not deleted!");
            }
        }

        private void grdViewCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            grdViewCategories.Rows[e.RowIndex].Selected = true;
            RowID = Convert.ToInt32(grdViewCategories.Rows[e.RowIndex].Cells[0].Value.ToString());
            var category = Categories.Where(c => c.id == RowID).FirstOrDefault();
            txtCategoryName.Text = category.name;
            CategoryNAME = category.name;
        }

        private void btnSearchCategoryName_Click(object sender, EventArgs e) {
            var searchText = txtSearchCategoryName.Text;
            var sortOrder = ddlSortCategoryName.SelectedItem.ToString();
            var categories = new List<Category>();

            if (searchText != "") {
                if (sortOrder == "Ascending") {
                    categories = Categories.Where(c => c.name.Equals(searchText, StringComparison.OrdinalIgnoreCase) || c.name.CaseInsensitiveContains(searchText)).OrderBy(c => c.name).ToList();
                } else if (sortOrder == "Descending") {
                    categories = Categories.Where(c => c.name.Equals(searchText, StringComparison.OrdinalIgnoreCase) || c.name.CaseInsensitiveContains(searchText)).OrderByDescending(c => c.name).ToList();
                }

                SortedCategories = categories;
                PopulateGridView(categories);
            }
        }

        private void ddlSortCategoryName_SelectedIndexChanged(object sender, EventArgs e) {
            var sortOrder = ddlSortCategoryName.SelectedItem.ToString();
            var categories = new List<Category>();
            switch (sortOrder) {
                case "Ascending":
                    categories = SortedCategories.OrderBy(c => c.name).ToList();
                    break;
                case "Descending":
                    categories = SortedCategories.OrderByDescending(c => c.name).ToList();
                    break;
            }

            PopulateGridView(categories);
        }

        private void btnResetSortCategories_Click(object sender, EventArgs e) {
            PopulateGridView(null);
            txtSearchCategoryName.Text = "";
            ddlSortCategoryName.SelectedIndex = 0;
        }
    }
}