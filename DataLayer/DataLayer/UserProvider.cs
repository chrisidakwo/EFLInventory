using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer {
    public class UserProvider {
        public static List<User> GetAllUsers() {
            List<User> users = new List<User>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                users = db.Users.OrderBy(u => u.username).ToList();
            }
            return users;
        }

        public static bool CheckLogin(string username, string password) {
            bool flag = false;
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                User user = db.Users.Where(u => u.username == username).FirstOrDefault();
                if (user != null) {
                    var userExists = AuthProvider.Confirm(password, user.password, AuthProvider.SupportedHash.SHA512);

                    if (userExists) {
                        flag = true;
                    }
                }

                return flag;
            }
        }

        public static User GetUserInfoById(int id) {
            User user = new User();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                if (id > 0) {
                    user = db.Users.Where(u => u.id == id).FirstOrDefault();
                }
            }

            return user;
        }

        public static User GetUserInfoByUsername(string username) {
            User user = new User();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                if (username != string.Empty) {
                    user = db.Users.Where(u => u.username == username).FirstOrDefault();
                }
            }

            return user;
        }

        public static bool DeleteUser(int id) {
            var flag = false;
            try {
                if (id > 0) {
                    using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                        User user = db.Users.Where(u => u.id == id).FirstOrDefault();
                        if (user != null) {
                            db.Users.Remove(user);
                            db.SaveChanges();
                            flag = true;
                        }
                    }
                }
            } catch (Exception) {
                throw;
            }

            return flag;
        }

        public static int AddUpdateUser(User user) {
            int id = 0;
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                if (user.id > 0) {
                    User temp = db.Users.Where(u => u.id == user.id).FirstOrDefault();
                    if (temp != null) {
                        temp.id = user.id;
                        temp.full_name = user.full_name;
                        temp.username = user.username;
                        temp.is_superuser = user.is_superuser;
                        temp.date_created = user.date_created;
                        temp.last_updated = DateTime.Now.ToString();

                        if (user.password != "") {
                            temp.password = user.password;
                        }

                        db.Entry(temp).State = System.Data.EntityState.Modified;
                    }
                } else {
                    user.date_created = DateTime.Now.ToString();
                    user.last_updated = DateTime.Now.ToString();
                    db.Users.Add(user);
                }

                db.SaveChanges();
                if (user.id > 0) {
                    id = user.id;
                }
            }

            return id;
        }
    }
}