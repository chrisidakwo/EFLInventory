using DataLayer;
using System.Collections.Generic;

namespace BusinessLayer {
    public class UserServices {
        public static List<User> GetAllUsers() {
            return UserProvider.GetAllUsers();
        }

        public static int AddUpdateUser(User user) {
            return UserProvider.AddUpdateUser(user);
        }

        public static bool CheckLogin(string email, string password) {
            return UserProvider.CheckLogin(email, password);
        }

        public static User GetUserByUsername(string username) {
            return UserProvider.GetUserInfoByUsername(username);
        }

        public static User GetUserInfoById(int id) {
            return UserProvider.GetUserInfoById(id);
        }

        public static bool DeleteUser(int id) {
            return UserProvider.DeleteUser(id);
        }
    }
}