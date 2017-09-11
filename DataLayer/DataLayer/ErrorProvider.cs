using System;

namespace DataLayer {
    public class ErrorProvider {
        public static bool AddNewError(string Username, string ErrorSeverity, string ErrorState, string ErrorProceedure, string ErrorLine, string ErrorMessage) {
            bool flag = false;
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                ErrorLog error = new ErrorLog() {
                    error_number = "None",
                    error_time = DateTime.Now,
                    username = Username,
                    error_severity = ErrorSeverity,
                    error_proceedure = ErrorProceedure,
                    error_state = ErrorState,
                    error_line = ErrorLine,
                    error_message = ErrorMessage
                };

                db.ErrorLogs.Add(error);
                db.SaveChanges();
            }

            return flag;
        }
    }
}