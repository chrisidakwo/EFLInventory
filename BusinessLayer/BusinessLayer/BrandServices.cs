using DataLayer;
using System.Collections.Generic;

namespace BusinessLayer {
    public class BrandServices {
        public static List<Brand> GetAllBrands() {
            return BrandProvider.GetAllBrands();
        }

        public static Brand GetBrandById(int BrandId) {
            return BrandProvider.GetBrandById(BrandId);
        }

        public static int AddUpdateBrand(Brand brand) {
            return BrandProvider.AddUpdateBrand(brand);
        }
    }
}
