using BusinessLayer;
using ComponentFactory.Krypton.Toolkit;
using DataLayer;
using Inventory.View.Helpers;
using System;

namespace Inventory.View.SubCategories {
    public partial class AddUpdateSubCategory : KryptonForm {
        public AddUpdateSubCategory() {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, System.EventArgs e) {
            this.Close();
        }

        private void btnAddSubCategory_Click(object sender, System.EventArgs e) {
            var subcategory_name = txtSubCategoryName.Text.Trim();
            if (subcategory_name.Equals(string.Empty)) {
                ControlHelpers.ErrorNotification("Invalid Input", "SubCategory name cannot be empty!");
                return;
            }

            // Retrieve subcategory by name (if it exists) or create a new one
            // If subcategory exists, return
            var _subcategory = SubCategoryServices.GetSubCategoryByName(subcategory_name);
            if (_subcategory == null) {
                _subcategory = new SubCategory() {
                    name = subcategory_name,
                };
            } else {
                ControlHelpers.ErrorNotification("Category Exists", subcategory_name.ToLower().Replace(subcategory_name.Substring(0, 1), subcategory_name.Substring(0, 1).ToUpper()) + " already exists!");
                return;
            }

            // Add subcategory to database
            // Show success or error message. TODO: Log error message (if any).
            // Log user action
            try {
                int id = SubCategoryServices.AddUpdateSubCategory(_subcategory);
                if (id > 0) {
                    ControlHelpers.SuccessNotification("New SubCategory Created", subcategory_name + " subcategory created successfully!");

                    string description = "Added a new subcategory: " + subcategory_name;
                    //int userid = LoginCredentials.userid;
                    //var flag = ActionHistoryServices.AddActionHistory(userid, description);
                    //if (flag != true) {
                    //    // Log message in text file and Log DB table to show description of action and that creating an ActionHistory failed.
                    //}
                    this.Close();
                } else {
                    ControlHelpers.ErrorNotification("Save Error", "SubCategory was not saved in the database!");
                }
            } catch (Exception) {
                ControlHelpers.ErrorNotification("An error occurred while saving subcategory.", "UnHandled Error!");
            }
        }
    }
}
