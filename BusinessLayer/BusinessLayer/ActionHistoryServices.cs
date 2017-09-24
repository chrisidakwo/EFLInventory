using DataLayer;

namespace BusinessLayer {
    public class ActionHistoryServices {
        public static bool AddActionHistory(string username, string description) {
            bool flag = false;
            string name = username == "" ? "Test" : username;
            ActionHistoryProvider.AddActionHistory(name, description);
            //if (username != "" && description != "") {
            //    ActionHistoryProvider.AddActionHistory(username, description);
            //    flag = true;
            //}

            return flag;
        }
    }
}
