using BusinessLayer;
using ComponentFactory.Krypton.Toolkit;
using DataLayer;
using System;
using ToastNotification;
using static Inventory.ToastNotification.NotificationSound;
using static ToastNotification.FormAnimator;

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
                Notification n = new Notification("Invalid Input", "Category name cannot be empty!", -1, AnimationMethod.Slide, AnimationDirection.Up);
                PlayNotificationSound(Sounds.Error);
                n.Show();
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
                Notification n = new Notification("Category Exists", category_name.ToLower().Replace(category_name.Substring(0, 1), category_name.Substring(0, 1).ToUpper()) + " already exists!", -1, AnimationMethod.Slide, AnimationDirection.Up);
                PlayNotificationSound(Sounds.Error);
                n.Show();
                //KryptonMessageBox.Show(category_name + " already exists!", "Category Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Add category to database
            // Show success or error message. TODO: Log error message (if any).
            // Log user action
            try {
                int id = CategoryServices.AddUpdateCategory(_category);
                if (id > 0) {
                    Notification n = new Notification("New Category Created", category_name + " category created successfully!", -1, AnimationMethod.Slide, AnimationDirection.Up);
                    PlayNotificationSound(Sounds.Success);
                    n.Show();

                    string description = "Added a new category: " + category_name;
                    //int userid = LoginCredentials.userid;
                    //var flag = ActionHistoryServices.AddActionHistory(userid, description);
                    //if (flag != true) {
                    //    // Log message in text file and Log DB table to show description of action and that creating an ActionHistory failed.
                    //}
                    this.Close();
                } else {
                    Notification n = new Notification("Save Error", "Category was not saved in the database!", -1, AnimationMethod.Slide, AnimationDirection.Up);
                    PlayNotificationSound(Sounds.Error);
                    n.Show();
                }
            } catch (Exception) {
                Notification n = new Notification("An error occurred while saving category.", "UnHandled Error!", -1, AnimationMethod.Slide, AnimationDirection.Up);
                PlayNotificationSound(Sounds.Error);
                n.Show();
            }
        }
    }
}