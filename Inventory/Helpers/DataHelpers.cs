using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Inventory.Helpers {
    public static class DataHelpers {
        public static void LoadDataSource<T>(Control control, List<T> list, string display, string value) {
            BindingSource bd = new BindingSource();

            bd.DataSource = list;
            dynamic ctrl = control;
            ctrl.DataSource = bd;
            ctrl.DisplayMember = display;
            ctrl.ValueMember = value;
            bd.ResetBindings(false);
        }

        /// <summary>
        /// Binds a list data source to a <see cref="System.Windows.Forms.DataGridView"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="grdView"></param>
        /// <param name="sourceList"></param>
        public static void LoadGridViewData<T>(DataGridView grdView, List<T> sourceList) {
            grdView.AutoGenerateColumns = false;
            var dataList = sourceList;
            var bindingList = new BindingList<T>(dataList);
            var source = new BindingSource(bindingList, null);
            grdView.DataSource = source;
            grdView.Invalidate();
        }

        /// <summary>
        /// Bind a list data source to a <seealso cref="ComponentFactory.Krypton.Toolkit.KryptonDataGridView"/>
        /// </summary>
        /// <typeparam name="T">object</typeparam>
        /// <param name="grdView"></param>
        /// <param name="sourceList"></param>
        public static void LoadGridViewData<T>(KryptonDataGridView grdView, List<T> sourceList) {
            grdView.AutoGenerateColumns = false;
            var dataList = sourceList;
            var bindingList = new BindingList<T>(dataList);
            var source = new BindingSource(bindingList, null);
            grdView.DataSource = source;
            grdView.Invalidate();
        }

        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public static DataTable ConvertToDataTable<T>(this IList<T> data) {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data) {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }
    }
}
