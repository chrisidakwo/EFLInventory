using DataLayer;
using EntityLayer;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer {
    public class SubCategoryServices {
        public static List<SubCategoryEntity> GetAllSubCategoryEntity(int subCategoryId, int CategoryId) {
            return SubCategoryProvider.GetAllSubCategoryEntity(subCategoryId, CategoryId);
        }

        public static List<SubCategory> GetAllSubCategories() {
            return SubCategoryProvider.GetAllSubCategories();
        }

        public static List<SubCategory> GetAllSubCategory(int subCategoryId, int CategoryId) {
            return SubCategoryProvider.GetAllSubCategory(subCategoryId, CategoryId);
        }

        public static List<SubCategoryEntity> GetAllSubCategoryEntity() {
            return SubCategoryProvider.GetAllSubCategoryEntity();
        }

        public static SubCategory GetSubCategory(int SubCategoryId) {
            return SubCategoryProvider.GetAllSubCategory(SubCategoryId, 0).FirstOrDefault();
        }

        public static SubCategory GetSubCategoryByName(string SubCategoryName) {
            return SubCategoryProvider.GetSubCategoryByName(SubCategoryName);
        }

        public static List<SubCategory> GetSubCategoriesByCategoryId(int CategoryId) {
            return SubCategoryProvider.GetSubCategoriesByCategoryId(CategoryId);
        }

        public static int AddUpdateSubCategory(SubCategory klass) {
            return SubCategoryProvider.AddUpdateSubCategory(klass);
        }

        public static bool DeleteSubCategories(int Category_id) {
            return SubCategoryProvider.DeleteSubCategoriesByCategory(Category_id);
        }

        public static bool DeleteSubCategory(int subCategoryId) {
            return SubCategoryProvider.DeleteSubCategory(subCategoryId);
        }
    }
}