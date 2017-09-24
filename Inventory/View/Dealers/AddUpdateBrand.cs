using BusinessLayer;
using ComponentFactory.Krypton.Toolkit;
using DataLayer;
using Inventory.Helpers;
using Inventory.Model;
using Inventory.Utils;
using Inventory.View.Helpers;
using System;
using System.Linq;

namespace Inventory.View.Dealers {
    public partial class AddUpdateBrand : KryptonForm {
        public static int BrandID { get; set; }
        public static Brand SelectedBrand { get; set; }
        public static string BrandName { get; set; }
        public AddUpdateBrand() {
            InitializeComponent();

            // Load ComboBox
            PopulateDDLBrand();
        }

        /// <summary>
        ///
        /// </summary>
        public void PopulateDDLBrand() {
            var _brands = BrandServices.GetAllBrands();
            DataHelpers.LoadDataSource(ddlSelectBrand, _brands, "name", "id");
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateBrand_Click(object sender, EventArgs e) {
            // Validations
            bool flag = ValidateControls();
            if (!flag) {
                return;
            }

            try {
                int x = BrandServices.AddUpdateBrand(new Brand() { name = BrandName });
                ControlHelpers.SuccessNotification("Nuked as Usual", "Brand item has been created successfully!");
            } catch (Exception ex) {
                ControlHelpers.ErrorNotification("Error", "An error occurred while creating a new brand!");
                ErrorLogger.LogException(ex, LoginCredentials.username ?? "Not Authenticated", "Adding a new brand");
            }

            PopulateDDLBrand();

            // On completion, reset variables
            ResetVariables();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateBrand_Click(object sender, EventArgs e) {
            // Ensure a brand is selected
            if (ddlSelectBrand.SelectedItem == null || BrandID == 0) {
                ControlHelpers.ErrorNotification("You Don Forget", "Oya select a brand before updating!");
                return;
            }

            // Validations
            bool flag = ValidateControls();
            if (!flag) {
                return;
            }

            try {
                int x = BrandServices.AddUpdateBrand(new Brand() { id = BrandID, name = BrandName });
                ControlHelpers.SuccessNotification("Nuked as Usual", "Brand item has been updated successfully!");
            } catch (Exception ex) {
                ControlHelpers.ErrorNotification("Error", "An error occurred while updating brand");
                ErrorLogger.LogException(ex, LoginCredentials.username ?? "Not Authenticated", "Updating a brand name");
            }

            PopulateDDLBrand();

            // On completion, reset variables
            ResetVariables();
        }

        private void ddlSelectBrand_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                BrandID = Convert.ToInt32(ddlSelectBrand.SelectedValue.ToString());
                SelectedBrand = BrandServices.GetBrandById(BrandID);
                txtBrandName.Text = SelectedBrand.name;
            } catch (Exception) {
            }
        }

        public bool ValidateControls() {
            // Ensure name text is not empty
            BrandName = txtBrandName.Text.Trim();
            if (BrandName == "") {
                ControlHelpers.ErrorNotification("Invalid Input", "Brand name cannot be empty!");
                return false;
            }

            // Ensure name doesn't already exists
            var BrandExists = BrandServices.GetAllBrands().Where(b => b.name == BrandName).FirstOrDefault();
            if (BrandExists != null) {
                ControlHelpers.ErrorNotification("Okay, Try Another Name", "Brand name already exists!");
                return false;
            }

            return true;
        }

        /// <summary>
        ///
        /// </summary>
        public void ResetVariables() {
            BrandID = 0;
            BrandName = "";
            SelectedBrand = new Brand();
            txtBrandName.Text = "";
        }
    }
}
