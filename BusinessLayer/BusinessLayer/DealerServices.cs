using DataLayer;
using EntityLayer;
using System.Collections.Generic;

namespace BusinessLayer {
    public class DealerServices {
        public static List<Dealer> GetAllDealers() {
            return DealerProvider.GetAllDealers();
        }

        public static List<DealerEntity> GetAllDealerEntity() {
            return DealerProvider.GetAllDealerEntity();
        }

        public static Dealer GetDealer(int DealerId) {
            return DealerProvider.GetDealer(DealerId);
        }

        public static Dealer GetDealerByName(string DealerName) {
            return DealerProvider.GetDealerByName(DealerName);
        }

        public static int AddUpdateDealer(Dealer klass) {
            return DealerProvider.AddUpdateDealer(klass);
        }

        public static bool DeleteDealer(int DealerId) {
            return DealerProvider.DeleteDealer(DealerId);
        }
    }
}