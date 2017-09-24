using EntityLayer;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer {
    public class SubCategoryProvider {
        public static List<SubCategoryEntity> GetAllSubCategoryEntity() {
            List<SubCategoryEntity> _subcategory = new List<SubCategoryEntity>();
            var productList = "";
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                var subcategories = db.SubCategories.ToList();
                var categories = db.Categories.ToList();
                var products = db.Products.ToList();

                foreach (SubCategory item in subcategories) {
                    foreach (Category category in categories) {
                        if (item.Category_id == category.id) {
                            foreach (Product product in products) {
                                if (product.subCategory_id == item.id && product.Category_id == category.id) {
                                    productList += product.name + ", ";
                                }
                            }

                            SubCategoryEntity s = new SubCategoryEntity();
                            s.id = item.id;
                            s.name = item.name;
                            s.category_id = category.id;
                            s.category_name = category.name;
                            s.products = productList.EndsWith(", ") ? productList.Remove(productList.Length - 2) : productList;

                            _subcategory.Add(s);

                            productList = "";
                        }
                    }
                }
            }
            return _subcategory;
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
                        if (subCat.id == item.id) {
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

                    c.SubCategories = subCategoryList.EndsWith(", ") ? subCategoryList.Remove(productList.Length - 2) : subCategoryList;
                    c.Products = productList.EndsWith(", ") ? productList.Remove(productList.Length - 2) : productList;

                    _category.Add(c);
                }
            }

            return _category;
        }

        public static List<SubCategoryEntity> GetAllSubCategoryEntity(int subCategoryId, int CategoryId) {
            List<SubCategoryEntity> _subcategory = new List<SubCategoryEntity>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                _subcategory = (from u in db.SubCategories
                                join c in db.Categories on u.Category_id equals c.id
                                where ((subCategoryId.Equals(null)) || (u.id == subCategoryId) || (subCategoryId == 0) &&
                                ((CategoryId == 0) || (c.id == CategoryId) || (CategoryId.Equals(null))))
                                select new SubCategoryEntity {
                                    id = u.id,
                                    category_id = c.id,
                                    category_name = c.name,
                                    name = u.name
                                }).ToList();
            }
            return _subcategory;
        }

        /// <summary>
        /// Retrieves all sub categories in DB. Returns a list of sub categories
        /// </summary>
        /// <param name="Category_Name"></param>
        /// <param name="CategoryId"></param>
        /// <returns></returns>
        public static List<SubCategory> GetAllSubCategories() {
            List<SubCategory> _sub_categories = new List<SubCategory>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                _sub_categories = db.SubCategories.ToList();
            }
            return _sub_categories;
        }

        public static SubCategory GetSubCategoryByName(string SubCategoryName) {
            var _subcategory = new SubCategory();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                _subcategory = db.SubCategories.Where(s => s.name.Equals(SubCategoryName)).FirstOrDefault();
            }

            return _subcategory;
        }

        public static List<SubCategory> GetSubCategoriesByCategoryId(int CategoryId) {
            List<SubCategory> _sub_categories = new List<SubCategory>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                _sub_categories = db.SubCategories.Where(s => s.Category_id == CategoryId).OrderBy(s => s.name).ToList();
            }
            return _sub_categories;
        }

        public static List<SubCategory> GetAllSubCategory(int subCategoryId, int CategoryId) {
            List<SubCategory> _category = new List<SubCategory>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                _category = (from u in db.SubCategories
                             where (((subCategoryId.Equals(null)) || (u.id == subCategoryId) || (subCategoryId == 0))
       && ((CategoryId == 0) || (u.Category_id == CategoryId) || (CategoryId.Equals(null))))
                             select u).ToList();
            }
            return _category;
        }

        /// <summary>
        /// Add or update a sub category in DB. Returns the id of the sub category.
        /// </summary>
        /// <param name="ob"></param>
        /// <returns></returns>
        public static int AddUpdateSubCategory(SubCategory ob) {
            int _subCategoryid = 0;
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                if (ob.id > 0) {
                    SubCategory temp = db.SubCategories.Where(u => u.id == ob.id).FirstOrDefault();
                    if (temp != null) {
                        temp.id = ob.id;
                        temp.name = ob.name;
                        temp.Category_id = ob.Category_id;

                        db.Entry(temp).State = System.Data.EntityState.Modified;
                    }
                } else {
                    db.SubCategories.Add(ob);
                }

                db.SaveChanges();
                if (ob.id > 0) {
                    _subCategoryid = ob.id;
                }
            }
            return _subCategoryid;
        }

        /// <summary>
        /// Delete sub categories of a given category. Returns true if deleted successfully. False otherwise.
        /// </summary>
        /// <param name="SubCategory_id"></param>
        /// <returns></returns>
        public static bool DeleteSubCategoriesByCategory(int SubCategory_id) {
            bool flag = false;
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                SubCategory temp = db.SubCategories.Where(u => u.id == SubCategory_id).FirstOrDefault();
                if (temp != null) {
                    db.SubCategories.Remove(temp);
                    db.SaveChanges();
                    flag = true;
                }
            }
            return flag;
        }

        public static bool DeleteSubCategory(int subCategoryId) {
            bool flag = false;
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                SubCategory temp = db.SubCategories.Where(s => s.id == subCategoryId).FirstOrDefault();
                if (temp != null) {
                    db.SubCategories.Remove(temp);
                    db.SaveChanges();
                    flag = true;
                }
            }

            return flag;
        }
    }
}
