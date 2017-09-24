using BusinessLayer;
using DataLayer;
using Inventory.Helpers;
using Inventory.Model;
using Inventory.Utils;
using Inventory.View.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Inventory.View {
    public partial class InventorySettings : UserControl {
        public InventorySettings() {
            InitializeComponent();
        }

        public void PopulateDDLMeasuringTypes() {
            var _units = MeasuringServices.GetAllMeasuringTypes();
            DataHelpers.LoadDataSource(ddlMeasurementTypes, _units, "name", "id");
        }

        private void btnSaveMeasurementType_Click(object sender, EventArgs e) {
            List<MeasuringType> _units = MeasuringServices.GetAllMeasuringTypes();

            // Validate values of Controls
            if (txtMeasuringTypeName.Text.Trim() == "") {
                ControlHelpers.ErrorNotification("Incomplete Input", "Name should not be empty!");
                return;
            }

            if (_units.Where(u => u.name == txtMeasuringTypeName.Text.Trim()).FirstOrDefault() != null) {
                ControlHelpers.ErrorNotification("Invalid Input", "Similar name already exists!");
                return;
            }

            MeasuringType mType = new MeasuringType();
            if (ddlMeasurementTypes.SelectedValue != null) {
                var id = ddlMeasurementTypes.SelectedValue;
                mType = MeasuringServices.GetMeasuringType(Convert.ToInt32(id));
                try {
                    MeasuringServices.AddUpdateMeasuringType(mType);
                    ControlHelpers.SuccessNotification("Success", "A measuring unit has been updated successfully!");
                    ActionHistoryServices.AddActionHistory(LoginCredentials.username ?? "Not Authenticated", string.Format("Updated a measuring unit - {0}", mType.name));
                } catch (Exception ex) {
                    ControlHelpers.ErrorNotification("Error Saving", "An error occurred while updating measuring unit!");

                    ErrorLog log = new ErrorLog() {
                        username = LoginCredentials.username ?? "Not Authenticated",
                        error_proceedure = "Updating a Measuring Type",
                        error_message = ex.InnerException.ToString(),
                        error_time = DateTime.Now,
                        error_severity = "Severe",
                        error_line = ex.StackTrace,
                        timestamp = DateTime.Now,
                    };

                    ErrorLogger.LogException(ex, LoginCredentials.username ?? "Not authenticated", "Updating a Measuring Type");
                }
            } else {
                MeasuringType temp = new MeasuringType();
                temp.name = txtMeasuringTypeName.Text.Trim();
                if (_units.Where(u => u.name == txtMeasuringTypeName.Text.Trim()).FirstOrDefault() != null) {
                    ControlHelpers.ErrorNotification("Invalid Input", "Similar name already exists!");
                    return;
                }

                try {
                    MeasuringServices.AddUpdateMeasuringType(temp);
                    ControlHelpers.SuccessNotification("Success", "Measuring unit added successfully!");
                    ActionHistoryServices.AddActionHistory(LoginCredentials.username ?? "Not Authenticated", string.Format("Added a new measuring unit - {0}", mType.name));
                } catch (Exception ex) {
                    ControlHelpers.ErrorNotification("Error Saving", "An error occurred while updating measuring unit!");

                    ErrorLog log = new ErrorLog() {
                        username = LoginCredentials.username ?? "Not Authenticated",
                        error_proceedure = "Updating a Measuring Type",
                        error_message = ex.InnerException.ToString(),
                        error_time = DateTime.Now,
                        error_severity = "Severe",
                        error_line = ex.StackTrace,
                        timestamp = DateTime.Now,
                    };

                    ErrorLogger.LogException(ex, LoginCredentials.username ?? "Not authenticated", "Updating a Measuring Type");
                }
            }
        }

        private void btnDeleteMeasuringType_Click(object sender, EventArgs e) {
            ControlHelpers.ErrorNotification("No Support For Action!", "Deleting a measuring unit is not supported!");
        }
    }
}
