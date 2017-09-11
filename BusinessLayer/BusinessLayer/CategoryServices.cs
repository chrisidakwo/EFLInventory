using DataLayer;
using System.Collections.Generic;

namespace BusinessLayer {
    public class CategoryServices {
        public static Category GetCategory(int CategoryId) {
            return CategoryProvider.GetCategory(CategoryId);
        }

        public static List<Category> GetAllCategories() {
            return CategoryProvider.GetAllCategories();
        }

        public static Category GetCategoryByName(string CategoryName) {
            return CategoryProvider.GetCategoryByName(CategoryName);
        }

        public static int AddUpdateCategory(Category klass) {
            return CategoryProvider.AddUpdateCategory(klass);
        }

        public static bool DeleteCategory(int CategoryId) {
            return CategoryProvider.DeleteCategory(CategoryId);
        }
    }
}