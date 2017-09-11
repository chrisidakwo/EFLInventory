using ComponentFactory.Krypton.Toolkit;
using Inventory.Model;
using Inventory.Utils;
using Inventory.View.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Inventory.Helpers {
    public class DocumentHelpers {
        public static bool ExportToCsv<T>(KryptonDataGridView grdView) {
            bool flag = false;
            try {
                var csv = CsvExporter.CreateCsvFromDataGridView(grdView);
                var save = new SaveFileDialog();
                save.Filter = "CSV | *.csv";
                if (save.ShowDialog() != DialogResult.OK) return false;
                // Compose a string that consists of three lines.

                // Write the string to a file.
                var file = new System.IO.StreamWriter(save.FileName);
                file.WriteLine(csv);

                file.Close();
                flag = true;
            } catch (Exception e) {
                throw (e);
            }

            return flag;
        }

        public static bool ExportToCsv<T>(List<T> data) {
            bool flag = false;
            try {
                var csv = CsvExporter.CreateCsvTextFile(data);
                var save = new SaveFileDialog();
                save.Filter = "CSV | *.csv";
                if (save.ShowDialog() != DialogResult.OK) return false;
                // Compose a string that consists of three lines.

                // Write the string to a file.
                var file = new StreamWriter(save.FileName);
                file.WriteLine(csv);

                file.Close();
                flag = true;
                ControlHelpers.SuccessNotification("Success", "'Inventory Summary.xlsx' has been saved successfully!");
                if (File.Exists(save.FileName)) {
                    System.Diagnostics.Process.Start(save.FileName);
                }
            } catch (Exception e) {
                throw (e);
            }

            return flag;
        }

        public static bool ExportToExcelInterop(KryptonDataGridView gridview) {
            bool flag = false;

            try {
                object misValue = System.Reflection.Missing.Value;
                Excel._Application app = new Excel.Application();
                app.DisplayAlerts = false;
                Excel._Workbook workbook = app.Workbooks.Add(misValue);
                Excel._Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);
                app.Visible = true;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Inventory Summary";

                try {
                    for (int i = 0; i < gridview.Columns.Count; i++)
                        worksheet.Cells[1, i + 1] = gridview.Columns[i].HeaderText;

                    for (int i = 0; i < gridview.Rows.Count; i++) {
                        for (int j = 0; j < gridview.Columns.Count; j++) {
                            if (gridview.Rows[i].Cells[j].Value != null) {
                                worksheet.Cells[i + 2, j + 1] = gridview.Rows[i].Cells[j].Value.ToString();
                            } else {
                                worksheet.Cells[i + 2, j + 1] = "";
                            }
                        }
                    }

                    // Get the location and filename of the excel to save from user
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "MS Excel Documents (*.xlsx)|*.xlsx";
                    sfd.FileName = "Inventory Summary.xlsx";

                    if (sfd.ShowDialog() == DialogResult.OK) {
                        workbook.SaveAs(sfd.FileName);
                        flag = true;
                        ControlHelpers.SuccessNotification("Success", "'Inventory Summary.xlsx' has been saved successfully!");
                    }

                    if (File.Exists(sfd.FileName))
                        System.Diagnostics.Process.Start(sfd.FileName);
                } catch (Exception ex) {
                    ErrorLogger.LogException(ex, LoginCredentials.username, "Generating an MS Excel document from Inventory Summary KryptonGridView");
                    ControlHelpers.ErrorNotification("", "An error occurred while storing rows and columns to Excel document");
                    return flag;
                }
            } catch (Exception ex) {
                ErrorLogger.LogException(ex, LoginCredentials.username, "Generating an MS Excel document from Inventory Summary KryptonGridView");
                ControlHelpers.ErrorNotification("Initialization Error", "An error occurred while trying to initialize a new Excel WorkBook!");
                return flag;
            }

            return flag;
        }

        private static void CopyToClipboard(KryptonDataGridView gridview) {
            gridview.RowHeadersVisible = false;
            gridview.SelectAll();
            DataObject dataObj = gridview.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private static void ReleaseObject(object obj) {
            try {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            } catch (Exception ex) {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            } finally {
                GC.Collect();
            }
        }
    }
}