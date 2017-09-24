using EntityLayer;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer {
    public class CategoryProvider {
        /// <summary>
        /// Returns a list of all categories in DB.
        /// </summary>
        /// <param name="CategoryId"></param>
        /// <returns></returns>
        public static List<Category> GetAllCategories() {
            List<Category> _categories = new List<Category>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                _categories = db.Categories.OrderBy(c => c.name).ToList();
            }
            return _categories;
        }

        public static List<CategoryEntity> GetAllCategoryEntities() {
            List<CategoryEntity> _category = new List<CategoryEntity>();
            var subCategoryList = "";
            var productList = "";
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                var _categories = db.Categories.ToList();
                var _products = db.Products.ToList();
                var subCategories = db.SubCategories.ToList();

                foreach (Category item in _categories) {
                    foreach (SubCategory subCat in subCategories) {
                        if (subCat.Category_id == item.id) {
                            subCategoryList += subCat.name + ", ";

                            foreach (Product product in _products) {
                                if (product.subCategory_id == subCat.id) {
                                    productList += product.name + ", ";
                                }
                            }
                        }
                    }

                    CategoryEntity c = new CategoryEntity();
                    c.id = item.id;
                    c.name = item.name;

                    c.SubCategories = subCategoryList.EndsWith(", ") ? subCategoryList.Remove(subCategoryList.Length - 2) : subCategoryList;
                    c.Products = productList.EndsWith(", ") ? productList.Remove(productList.Length - 2) : productList;

                    _category.Add(c);

                    subCategoryList = "";
                    productList = "";
                }
            }

            return _category;
        }

        /// <summary>
        /// Retrieve a category based on a given id. Returns a single category.
        /// </summary>
        /// <param name="CategoryId"></param>
        /// <returns></returns>
        public static Category GetCategory(int CategoryId) {
            Category _category = new Category();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                _category = (from u in db.Categories
                             where (u.id == CategoryId)
                             select u).FirstOrDefault();
            }
            return _category;
        }

        /// <summary>
        /// Retrieve a category by name. Returns a single category.
        /// </summary>
        /// <param name="CategoryName"></param>
        /// <returns></returns>
        public static Category GetCategoryByName(string CategoryName) {
            Category _category = new Category();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                _category = (from u in db.Categories where (u.name.ToLower() == CategoryName.ToLower()) select u).FirstOrDefault();
            }
            return _category;
        }

        /// <summary>
        /// Add or update a category in DB. Returns the id of the category.
        /// </summary>
        /// <param name="klass"></param>
        /// <returns></returns>
        public static int AddUpdateCategory(Category klass) {
            int _Categoryid = 0;
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                if (klass.id > 0) {
                    Category temp = db.Categories.Where(u => u.id == klass.id).FirstOrDefault();
                    if (temp != null) {
                        temp.name = klass.name;
                        db.Entry(temp).State = System.Data.EntityState.Modified;
                    }
                } else {
                    db.Categories.Add(klass);
                }

                db.SaveChanges();
                _Categoryid = klass.id;
            }
            return _Categoryid;
        }

        /// <summary>
        /// Delete a category based on a given category id. Returns True if deleted successfully. False otherwise.
        /// </summary>
        /// <param name="Category_id"></param>
        /// <returns></returns>
        public static bool DeleteCategory(int Category_id) {
            try {
                bool flag = false;
                using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                    Category temp = db.Categories.Where(u => u.id == Category_id).FirstOrDefault();
                    if (temp != null) {
                        db.Categories.Remove(temp);
                        db.SaveChanges();
                        flag = true;
                    }
                }
                return flag;
            } catch {
                return false;
            }
        }
    }
}
