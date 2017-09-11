using BusinessLayer;
using ComponentFactory.Krypton.Toolkit;
using DataLayer;
using Inventory.Helpers;
using Inventory.Model;
using Inventory.Utils;
using Inventory.View.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Inventory.View {
    public partial class UserAccountConfig : KryptonForm {
        private BackgroundWorker worker = new BackgroundWorker();
        private List<User> Users = new List<User>();
        private int UserId = 0;

        public UserAccountConfig() {
            InitializeComponent();

            var currentUser = Users.Where(u => u.username == LoginCredentials.username).Where(u => u.is_superuser == true).FirstOrDefault();
            if (currentUser == null) {
                Close();
            }

            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.RunWorkerAsync();
        }

        public void worker_DoWork(object sender, DoWorkEventArgs e) {
            try {
                List<User> _users = UserServices.GetAllUsers();
                this.Users = _users;
            } catch (Exception) {
                throw;
            }
        }

        public void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            try {
                DataHelpers.LoadDataSource(ddlSelectUser, Users, "username", "id");
            } catch (Exception) {
                throw;
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e) {
            if (ValidateInputs()) {
                return;
            }

            var currentUser = Users.Where(u => u.username == LoginCredentials.username).Where(u => u.is_superuser == true).FirstOrDefault();
            if (currentUser == null) {
                ErrorLogger.LogException(new Exception("User tried creating a new user account"), LoginCredentials.username, "Create a new user");
                ControlHelpers.ErrorNotification("Action Restricted", "You do not have the priviledge to create a user!");
                return;
            }

            var userExists = Users.Where(u => u.username == txtUsername.Text.Trim());
            if (userExists.Count() > 0) {
                ControlHelpers.ErrorNotification("Duplicate Username", "Username already exists. Try another!");
                return;
            }

            User user = new User() {
                username = txtUsername.Text.Trim(),
                full_name = txtFullName.Text.Trim(),
                is_superuser = chkIsSuperUser.Checked,
                password = HashedPassword(txtPassword.Text.Trim()),
            };

            try {
                var id = UserServices.AddUpdateUser(user);
                if (id > 0) {
                    ControlHelpers.SuccessNotification("New User Created", "User was created successfully!");
                    ClearControlValues();
                    worker.DoWork += new DoWorkEventHandler(worker_DoWork);
                    worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
                    worker.RunWorkerAsync();
                }
            } catch (Exception) {
                ControlHelpers.ErrorNotification("Database Error", "An error occurred while creating user!");
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e) {
            if (txtUsername.Text.Trim() == "") {
                ControlHelpers.ErrorNotification("Invalid Input", "User must have a username");
                return;
            }

            var currentUser = Users.Where(u => u.username == LoginCredentials.username).Where(u => u.is_superuser == true).FirstOrDefault();
            if (currentUser == null) {
                ErrorLogger.LogException(new Exception("User tried creating a new user account"), LoginCredentials.username, "Create a new user");
                ControlHelpers.ErrorNotification("Action Restricted", "You do not have the priviledge to create a user!");
                return;
            }

            User user = new User() {
                id = UserId,
                username = txtUsername.Text.Trim(),
                full_name = txtFullName.Text.Trim(),
                is_superuser = chkIsSuperUser.Checked,
            };

            if (txtPassword.Text != "" & txtPasswordConfirm.Text != "") {
                // CHheck password match
                if (txtPassword.Text.Trim() != txtPasswordConfirm.Text.Trim()) {
                    ControlHelpers.ErrorNotification("Input Error", "Your password inputs do not match!");
                    return;
                }

                user.password = HashedPassword(txtPassword.Text.Trim());
            }

            try {
                UserServices.AddUpdateUser(user);
                ControlHelpers.SuccessNotification("User Updated", "User reocrd has been updated successfully!");
                ClearControlValues();
                worker.DoWork += new DoWorkEventHandler(worker_DoWork);
                worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
                worker.RunWorkerAsync();
            } catch (Exception) {
                throw;
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e) {
            var flag = false;
            if (UserId == 0) {
                ControlHelpers.ErrorNotification("Input Error", "Please select an existing user!");
                return;
            }

            if (UserId > 0) {
                var user = UserServices.GetUserInfoById(UserId);
                DialogResult result = new DialogResult();
                result = KryptonMessageBox.Show("Are yo sure you want to delete user: " + user.username + " ?!", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                switch (result) {
                    case DialogResult.Yes:
                        flag = UserServices.DeleteUser(UserId);
                        break;
                    case DialogResult.No:
                        break;
                }
            }

            if (flag) {
                ControlHelpers.SuccessNotification("User Deleted!", "User has been deleted successfuly!");
                worker.DoWork += new DoWorkEventHandler(worker_DoWork);
                worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
                worker.RunWorkerAsync();
            }
        }

        private void ddlSelectUser_SelectedIndexChanged(object sender, EventArgs e) {
            var selection = ddlSelectUser.SelectedValue; ;
            var selectedUser = new User();

            try {
                selectedUser = UserServices.GetUserInfoById(Convert.ToInt32(selection));

                if (selectedUser != null) {
                    UserId = selectedUser.id;
                    txtUsername.Text = selectedUser.username;
                    txtFullName.Text = selectedUser.full_name;
                    chkIsSuperUser.Checked = selectedUser.is_superuser;
                }
            } catch (Exception) {
            }
        }

        public bool ValidateInputs() {
            bool flag = false;
            if (txtUsername.Text.Trim() == "") {
                ControlHelpers.ErrorNotification("Input Error", "User must have a username!");
                flag = true;
            }

            if (txtPassword.Text.Trim() == "") {
                ControlHelpers.ErrorNotification("Input Error", "User must have a password!");
                flag = true;
            }

            // CHheck password match
            if (txtPassword.Text.Trim() != txtPasswordConfirm.Text.Trim()) {
                ControlHelpers.ErrorNotification("Input Error", "Your password inputs do not match!");
                flag = true;
            }

            return flag;
        }

        public string HashedPassword(string password) {
            return AuthProvider.ComputeHash(password, AuthProvider.SupportedHash.SHA512, null);
        }

        public void ClearControlValues() {
            txtFullName.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtPasswordConfirm.Text = "";
            chkIsSuperUser.Checked = false;
        }
    }
}