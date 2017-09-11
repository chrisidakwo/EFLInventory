using DataLayer;

namespace BusinessLayer {
    public class ActionHistoryServices {
        public static bool AddActionHistory(int userid, string description) {
            bool flag = false;

            if (userid.ToString() != string.Empty && description != string.Empty) {
                ActionHistoryProvider.AddActionHistory(userid, description);
                flag = true;
            }

            return flag;
        }
    }
}