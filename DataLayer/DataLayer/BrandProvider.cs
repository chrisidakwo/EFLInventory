using System.Collections.Generic;
using System.Linq;

namespace DataLayer {
    public class BrandProvider {
        public static List<Brand> GetAllBrands() {
            List<Brand> _brands = new List<Brand>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                _brands = db.Brands.OrderBy(b => b.name).ToList();
            }

            return _brands;
        }

        public static Brand GetBrandById(int BrandId) {
            Brand _brand = new Brand();
            if (BrandId > 0) {
                using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                    _brand = db.Brands.Where(b => b.id == BrandId).FirstOrDefault();
                }
            }

            return _brand;
        }

        public static int AddUpdateBrand(Brand brand) {
            int _brandId = 0;
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                Brand temp = db.Brands.Where(b => b.id == brand.id).FirstOrDefault();
                if (temp != null) {
                    temp.name = brand.name;
                    db.Entry(temp).State = System.Data.EntityState.Modified;
                } else {
                    db.Brands.Add(brand);
                }

                db.SaveChanges();
                _brandId = brand.id;

                return _brandId;
            }
        }
    }
}
