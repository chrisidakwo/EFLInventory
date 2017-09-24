using DataLayer;
using EntityLayer;
using System.Collections.Generic;

namespace BusinessLayer {
    public class DealerServices {
        /// <summary>
        /// Retrieve all dealers in DB. Returns a list of dealers.
        /// </summary>
        /// <returns></returns>
        public static List<Dealer> GetAllDealers() {
            return DealerProvider.GetAllDealers();
        }

        /// <summary>
        /// Retrieve all dealers for a given brand of BrandID
        /// </summary>
        /// <param name="BrandID"></param>
        /// <returns></returns>
        public static List<Dealer> GetDealersByBrand(int BrandID) {
            return DealerProvider.GetDealersByBrand(BrandID);
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
