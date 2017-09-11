using DataLayer;

namespace BusinessLayer {
    public class ErrorServices {
        public static bool AddNewError(string Username, string ErrorSeverity, string ErrorState, string ErrorProceedure, string ErrorLine, string ErrorMessage) {
            return ErrorProvider.AddNewError(Username, ErrorSeverity, ErrorState, ErrorProceedure, ErrorLine, ErrorMessage);
        }
    }
}