using Inventory.Helpers;
using Inventory.View;
using System;
using System.Windows.Forms;

namespace Inventory {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Main());
            DialogResult result;
            using (var loginForm = new Login())
                result = loginForm.ShowDialog();

            if (result == DialogResult.OK) {
                Application.Run(new Main());
            }
        }
    }
}
