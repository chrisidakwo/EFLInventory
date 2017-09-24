using ClosedXML.Excel;
using ComponentFactory.Krypton.Toolkit;
using Inventory.Model;
using Inventory.Utils;
using Inventory.View.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Inventory.Helpers {
    public class DocumentHelpers {
        public static string SaveDirectory = @"EFLInventory\Reports\";
        public static string SaveFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), SaveDirectory);

        public static bool ExportToCSV(KryptonDataGridView grdView, string filename) {
            bool flag = false;

            // Create report folder if it doesn't exist
            IOHelpers.CreateFolder(SaveFolder);

            try {
                var csv = CsvExporter.CreateCsvFromDataGridView(grdView);
                var save = new SaveFileDialog();
                save.InitialDirectory = SaveFolder;
                save.FileName = filename != "" ? filename : "Report Summary.csv";
                save.Filter = "Comma Seperated Values (CSV) | *.csv";
                if (save.ShowDialog() == DialogResult.OK) {
                    // Compose a string that consists of three lines.

                    // Write the string to a file.
                    var file = new StreamWriter(save.FileName);
                    file.WriteLine(csv);

                    file.Close();
                    file.Dispose();

                    if (File.Exists(save.FileName)) {
                        ControlHelpers.SuccessNotification("Success", string.Format("'{0}' has been saved successfully!", save.FileName));

                        System.Diagnostics.Process.Start(save.FileName);
                        flag = true;
                    }
                } else if (save.ShowDialog() == DialogResult.Cancel) {
                    return false;
                }
            } catch (Exception e) {
                throw (e);
            }

            return flag;
        }

        public static bool ExportToCSV<T>(List<T> data, string filename) {
            bool flag = false;

            // Create report folder if it doesn't exist
            IOHelpers.CreateFolder(SaveFolder);

            string name = filename != "" ? filename : "Report Summary.csv";

            var save = new SaveFileDialog();
            save.InitialDirectory = SaveFolder;
            save.FileName = name;
            save.Filter = "Comma Seperated Values (CSV) | *.csv";

            if (save.ShowDialog() == DialogResult.OK) {
                StreamWriter sw = new StreamWriter(save.FileName);
                DataTable dataTable = data.ConvertToDataTable();

                // Write out the headers of the file
                List<string> columnNames = new List<string>();
                foreach (DataColumn column in dataTable.Columns) {
                    columnNames.Add(column.ColumnName);
                }
                sw.WriteLine(string.Join(",", columnNames));

                // Now write all rows
                int iColCount = dataTable.Columns.Count;
                foreach (DataRow dr in dataTable.Rows) {
                    List<string> columnData = new List<string>();
                    for (int i = 0; i < iColCount; i++) {
                        if (!Convert.IsDBNull(dr[i])) {
                            columnData.Add(dr[i].ToString());
                        }
                    }
                    sw.WriteLine(string.Join(",", columnData.ToArray()));
                }

                sw.Close();
                sw.Dispose();
                if (File.Exists(save.FileName)) {
                    ControlHelpers.SuccessNotification("Success", string.Format("'{0}' has been saved successfully!", name));

                    // Open file if it exists
                    System.Diagnostics.Process.Start(save.FileName);
                    return true;
                }
            } else {
                return false;
            }

            return flag;
        }

        public static bool ExportToExcelInterop(KryptonDataGridView gridview, string filename) {
            bool flag = false;

            // Create report folder if it doesn't exist
            IOHelpers.CreateFolder(SaveFolder);

            try {
                object misValue = System.Reflection.Missing.Value;
                Excel._Application app = new Excel.Application();
                app.DisplayAlerts = false;
                Excel._Workbook workbook = app.Workbooks.Add(misValue);
                Excel._Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);
                app.Visible = true;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = filename != "" ? filename : "Report Summary.xlsx";

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
                    sfd.InitialDirectory = SaveFolder;
                    sfd.Filter = "Microsoft Excel Document (*.xlsx)|*.xlsx";
                    sfd.FileName = worksheet.Name;

                    if (sfd.ShowDialog() == DialogResult.OK) {
                        workbook.SaveAs(sfd.FileName);
                        flag = true;
                        ControlHelpers.SuccessNotification("Success", string.Format("'{0}.xlsx' has been saved successfully!", sfd.FileName));

                        if (File.Exists(sfd.FileName))
                            System.Diagnostics.Process.Start(sfd.FileName);

                        return flag;
                    }
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

        public static bool ExportToExcel<T>(List<T> data, string filename) {
            var flag = false;

            // Create report folder if it doesn't exist
            IOHelpers.CreateFolder(SaveFolder);

            string name = filename != "" ? filename : "Report Summary.xlsx";

            DataTable workbookData = DataHelpers.ConvertToDataTable<T>(data);

            XLWorkbook workbook = new XLWorkbook();
            workbook.Worksheets.Add(workbookData, name);

            // Get the location and filename of the excel to save from user
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = SaveFolder;
            sfd.Filter = "Microsoft Excel Document (*.xlsx)|*.xlsx";
            sfd.FileName = name;

            if (sfd.ShowDialog() == DialogResult.OK) {
                workbook.SaveAs(sfd.FileName);
                flag = true;
                ControlHelpers.SuccessNotification("Success", string.Format("'{0}.xlsx' has been saved successfully!", name));

                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);

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
                ControlHelpers.ErrorNotification("Error", "Exception occurred while releasing object " + ex.ToString());
            } finally {
                GC.Collect();
            }
        }
    }
}
