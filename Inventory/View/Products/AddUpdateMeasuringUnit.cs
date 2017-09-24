using BusinessLayer;
using ComponentFactory.Krypton.Toolkit;
using DataLayer;
using Inventory.Helpers;
using Inventory.Model;
using Inventory.Utils;
using Inventory.View.Helpers;
using System;
using System.Linq;

namespace Inventory.View.Products {
    public partial class AddUpdateMeasuringUnit : KryptonForm {
        private int UnitID { get; set; }
        private string UnitName { get; set; }
        private MeasuringType SelectedUnit { get; set; }

        public AddUpdateMeasuringUnit() {
            InitializeComponent();

            PopulateDDLMeasuringUnit();
        }

        public void PopulateDDLMeasuringUnit() {
            var _units = MeasuringServices.GetAllMeasuringTypes();
            DataHelpers.LoadDataSource(ddlSelectMeasuringUnit, _units, "name", "id");
        }

        private void btnCreateMeasuringUnit_Click(object sender, EventArgs e) {
            // Validations
            bool flag = ValidateControls();
            if (!flag) {
                return;
            }

            try {
                int x = MeasuringServices.AddUpdateMeasuringType(new MeasuringType() { name = UnitName });
                ControlHelpers.SuccessNotification("Nuked", "Measuring unit has been created successfully!");
            } catch (Exception ex) {
                ErrorLogger.LogException(ex, LoginCredentials.username ?? "Not Authenticated", "Adding a new measuring type");
            }

            PopulateDDLMeasuringUnit();

            // Reset variables
            ResetVariables();
        }

        private void btnUpdateMeasuringUnit_Click(object sender, EventArgs e) {
            // Ensure a unit is selected
            if (ddlSelectMeasuringUnit.SelectedItem == null || UnitID == 0) {
                ControlHelpers.ErrorNotification("You Don Forget", "Oya select a unit before updating!");
                return;
            }

            // Validations
            bool flag = ValidateControls();
            if (!flag) {
                return;
            }

            try {
                int x = MeasuringServices.AddUpdateMeasuringType(new MeasuringType() { id = UnitID, name = UnitName });
                ControlHelpers.SuccessNotification("Nuked as Usual", "Measuring unit has been updated successfully!");
            } catch (Exception ex) {
                ControlHelpers.ErrorNotification("Error", "An error occured while updating measuring unit!");
                ErrorLogger.LogException(ex, LoginCredentials.username ?? "Not Authenticated", "Updating a measuring type");
            }

            PopulateDDLMeasuringUnit();

            // On completion, reset variables
            ResetVariables();
        }

        private void ddlSelectMeasuringUnit_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                UnitID = Convert.ToInt32(ddlSelectMeasuringUnit.SelectedValue.ToString());
                SelectedUnit = MeasuringServices.GetMeasuringType(UnitID);
                txtUnitName.Text = SelectedUnit.name;
            } catch (Exception) {
            }
        }

        public bool ValidateControls() {
            // Ensure texbox is not empty
            UnitName = txtUnitName.Text.Trim();
            if (UnitName == "") {
                ControlHelpers.ErrorNotification("You Don Forget?", "A name for the measuring unit suppose dey na!");
                return false;
            }

            // Ensure exact name doesn't already exists
            var unitExists = MeasuringServices.GetAllMeasuringTypes().Where(u => u.name == UnitName).FirstOrDefault();
            if (unitExists != null) {
                ControlHelpers.ErrorNotification("Okay, Try Another Name", "Exact unit name already exists!");
                return false;
            }

            return true;
        }

        public void ResetVariables() {
            UnitName = "";
            UnitID = 0;
            SelectedUnit = new MeasuringType();
            txtUnitName.Text = "";
        }
    }
}
