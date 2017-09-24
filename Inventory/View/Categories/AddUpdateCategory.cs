using BusinessLayer;
using ComponentFactory.Krypton.Toolkit;
using DataLayer;
using Inventory.View.Helpers;
using System;

namespace Inventory.View.Categories {
    public partial class AddUpdateCategory : KryptonForm {
        public AddUpdateCategory() {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            // Close Window
            Close();
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
            var _category = CategoryServices.GetCategoryByName(category_name);
            if (_category == null) {
                _category = new Category() {
                    name = category_name,
                };
            } else {
                ControlHelpers.ErrorNotification("Category Exists", category_name.ToLower().Replace(category_name.Substring(0, 1), category_name.Substring(0, 1).ToUpper()) + " already exists!");
                //KryptonMessageBox.Show(category_name + " already exists!", "Category Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Add category to database
            // Show success or error message. TODO: Log error message (if any).
            // Log user action
            try {
                int id = CategoryServices.AddUpdateCategory(_category);
                if (id > 0) {
                    ControlHelpers.SuccessNotification("New Category Created", category_name + " category created successfully!");

                    string description = "Added a new category: " + category_name;
                    //int userid = LoginCredentials.userid;
                    //var flag = ActionHistoryServices.AddActionHistory(userid, description);
                    //if (flag != true) {
                    //    // Log message in text file and Log DB table to show description of action and that creating an ActionHistory failed.
                    //}
                    this.Close();
                } else {
                    ControlHelpers.ErrorNotification("Save Error", "Category was not saved in the database!");
                }
            } catch (Exception) {
                ControlHelpers.ErrorNotification("An error occurred while saving category.", "UnHandled Error!");
            }
        }
    }
}
