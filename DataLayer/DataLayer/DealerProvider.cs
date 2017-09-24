using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer {
    public class DealerProvider {
        /// <summary>
        /// Retrieve all dealers in DB. Returns a list of dealers.
        /// </summary>
        /// <returns></returns>
        public static List<Dealer> GetAllDealers() {
            List<Dealer> _dealers = new List<Dealer>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                _dealers = db.Dealers.OrderBy(d => d.name).ToList();
            }

            return _dealers;
        }

        /// <summary>
        /// Retrieve all dealers for a given brand of BrandID
        /// </summary>
        /// <param name="BrandID"></param>
        /// <returns></returns>
        public static List<Dealer> GetDealersByBrand(int BrandID) {
            return GetAllDealers().Where(d => d.Brand_id == BrandID).ToList();
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public static List<DealerEntity> GetAllDealerEntity() {
            string productList = "";
            List<DealerEntity> _dealers = new List<DealerEntity>();

            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                var dealers = db.Dealers.OrderBy(d => d.name).ToList();
                var products = db.Products.OrderBy(p => p.name).ToList();

                foreach (Dealer item in dealers) {
                    var dealerId = item.id;
                    foreach (Product _product in products) {
                        if (_product.dealer_id == dealerId) {
                            productList += (_product.name + ", ");
                        }
                    }

                    if (productList.Length > 0) {
                        if (productList.EndsWith(", ")) {
                            var newList = productList.Remove(productList.Length - 2);
                            productList = newList;
                        }
                    }

                    DealerEntity d = new DealerEntity() {
                        id = item.id,
                        name = item.name,
                        email = item.email,
                        phone = item.phone,
                        address = item.address,
                        brand_id = item.Brand_id,
                        products = productList
                    };
                    _dealers.Add(d);
                    productList = "";
                }
            }
            return _dealers;
        }

        /// <summary>
        /// Retrieve a dealer by the id. Returns a single dealer.
        /// </summary>
        /// <param name="DealerId"></param>
        /// <returns></returns>
        public static Dealer GetDealer(int DealerId) {
            Dealer _dealer = new Dealer();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                _dealer = db.Dealers.Where(d => d.id == DealerId).FirstOrDefault();
            }
            return _dealer;
        }

        /// <summary>
        /// Retrieve a dealer by the name. Returns a single dealer.
        /// </summary>
        /// <param name="DealerName"></param>
        /// <returns></returns>
        public static Dealer GetDealerByName(string DealerName) {
            Dealer _dealer = new Dealer();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                _dealer = db.Dealers.Where(d => d.name == DealerName).FirstOrDefault();
            }
            return _dealer;
        }

        /// <summary>
        /// Add or update a dealer in DB. Returns the id of the dealer.
        /// </summary>
        /// <param name="klass"></param>
        /// <returns></returns>
        public static int AddUpdateDealer(Dealer klass) {
            int _dealerId = 0;
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                if (klass.id > 0) {
                    Dealer temp = db.Dealers.Where(d => d.id == klass.id).FirstOrDefault();
                    if (temp != null) {
                        temp.id = klass.id;
                        temp.name = klass.name;
                        temp.phone = klass.phone;
                        temp.email = klass.email;
                        temp.address = klass.address;
                        temp.Brand_id = klass.Brand_id;
                        temp.last_updated = DateTime.Now;

                        db.Entry(temp).State = System.Data.EntityState.Modified;
                    }
                } else {
                    klass.date_created = DateTime.Now;
                    klass.last_updated = DateTime.Now;
                    db.Dealers.Add(klass);
                }

                db.SaveChanges();
                if (klass.id > 0) {
                    _dealerId = klass.id;
                }
            }
            return _dealerId;
        }

        /// <summary>
        /// Delete a delear record. Returns True if deleted successfully. False otherwise.
        /// </summary>
        /// <param name="DealerId"></param>
        /// <returns></returns>
        public static bool DeleteDealer(int DealerId) {
            bool flag = false;
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                Dealer temp = db.Dealers.Where(d => d.id == DealerId).FirstOrDefault();
                if (temp != null) {
                    db.Dealers.Remove(temp);
                    db.SaveChanges();
                    flag = true;
                }
            }
            return flag;
        }
    }
}
