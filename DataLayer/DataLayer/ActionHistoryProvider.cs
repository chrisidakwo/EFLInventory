using System;

namespace DataLayer {
    public class ActionHistoryProvider {
        public static void AddActionHistory(int userid, string description) {
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                ActionHistory ah = new ActionHistory() {
                    userid = userid,
                    description = description,
                    timestamp = DateTime.Now.ToString()
                };

                db.ActionHistories.Add(ah);
                db.SaveChanges();
            }
        }
    }
}