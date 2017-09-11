using BusinessLayer;
using ComponentFactory.Krypton.Toolkit;
using DataLayer;
using System;
using ToastNotification;
using static Inventory.ToastNotification.NotificationSound;
using static ToastNotification.FormAnimator;

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
                Notification n = new Notification("Invalid Input", "SubCategory name cannot be empty!", -1, AnimationMethod.Slide, AnimationDirection.Up);
                PlayNotificationSound(Sounds.Error);
                n.Show();
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
                Notification n = new Notification("Category Exists", subcategory_name.ToLower().Replace(subcategory_name.Substring(0, 1), subcategory_name.Substring(0, 1).ToUpper()) + " already exists!", -1, AnimationMethod.Slide, AnimationDirection.Up);
                PlayNotificationSound(Sounds.Error);
                n.Show();
                return;
            }

            // Add subcategory to database
            // Show success or error message. TODO: Log error message (if any).
            // Log user action
            try {
                int id = SubCategoryServices.AddUpdateSubCategory(_subcategory);
                if (id > 0) {
                    Notification n = new Notification("New SubCategory Created", subcategory_name + " subcategory created successfully!", -1, AnimationMethod.Slide, AnimationDirection.Up);
                    PlayNotificationSound(Sounds.Success);
                    n.Show();

                    string description = "Added a new subcategory: " + subcategory_name;
                    //int userid = LoginCredentials.userid;
                    //var flag = ActionHistoryServices.AddActionHistory(userid, description);
                    //if (flag != true) {
                    //    // Log message in text file and Log DB table to show description of action and that creating an ActionHistory failed.
                    //}
                    this.Close();
                } else {
                    Notification n = new Notification("Save Error", "SubCategory was not saved in the database!", -1, AnimationMethod.Slide, AnimationDirection.Up);
                    PlayNotificationSound(Sounds.Error);
                    n.Show();
                }
            } catch (Exception) {
                Notification n = new Notification("An error occurred while saving subcategory.", "UnHandled Error!", -1, AnimationMethod.Slide, AnimationDirection.Up);
                PlayNotificationSound(Sounds.Error);
                n.Show();
            }
        }
    }
}