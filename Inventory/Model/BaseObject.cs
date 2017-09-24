using System.ComponentModel;

namespace Inventory.Model {
    public class BaseObject<T> {
        private static string _name = "";
        public static string name {
            get { return _name; }
            set { _name = value; }
        }

        private static T _value;
        public static T value {
            get { return _value; }
            set { _value = value; }
        }

        public BaseObject() {
        }
    }

    public static class LoginCredentials {
        private static string _username = "";
        public static string username {
            get { return _username; }
            set {
                _username = value;
            }
        }

        private static int _userid = 0;
        public static int userid {
            get { return _userid; }
            set { _userid = value; }
        }
    }

    public class Global : INotifyPropertyChanged {
        private string _TotalSalesToday;
        public string TotalSalesToday {
            get { return _TotalSalesToday; }
            set {
                if (_TotalSalesToday == value) {
                    return;
                }
                _TotalSalesToday = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalSalesToday"));
            }
        }

        private string _TotalSalesMonth;
        public string TotalSalesMonth {
            get { return _TotalSalesMonth; }
            set {
                if (_TotalSalesMonth == value) {
                    return;
                }
                _TotalSalesMonth = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalSalesMonth"));
            }
        }

        private string _TotalSalesHalfYear;
        public string TotalSalesHalfYear {
            get { return _TotalSalesHalfYear; }
            set {
                if (_TotalSalesHalfYear == value) {
                    return;
                }
                _TotalSalesHalfYear = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalSalesHalfYear"));
            }
        }

        private string _InventoryBalance;
        public string InventoryBalance {
            get { return _InventoryBalance; }
            set {
                if (_InventoryBalance == value) {
                    return;
                }
                _InventoryBalance = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("InventoryBalance"));
            }
        }

        private string _InventoryValue;
        public string InventoryValue {
            get { return _InventoryValue; }
            set {
                if (_InventoryValue == value) {
                    return;
                }
                _InventoryValue = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("InventoryValue"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private Global() {
        }

        public static readonly Global Get = new Global();
    }
}
