using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DataLayer {
    public class ProductProvider {
        /// <summary>
        /// Add or update a product in DB. Returns the id of the product.
        /// </summary>
        /// <param name="klass"></param>
        /// <returns></returns>
        public static int AddProduct(Product klass) {
            int _productId = 0;
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                Product temp = db.Products.Where(p => p.id == klass.id).FirstOrDefault();

                if (temp == null) {
                    klass.date_created = DateTime.Now;
                    klass.last_updated = DateTime.Now;
                } else {
                    return -1;
                }

                db.Products.Add(klass);
                db.SaveChanges();
                _productId = klass.id;
            }

            return _productId;
        }

        public static int UpdateProduct(Product klass) {
            int _productId = 0;
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                Product temp = db.Products.Where(p => p.id == klass.id).FirstOrDefault();
                if (temp != null) {
                    temp.name = klass.name;
                    temp.brand_id = klass.brand_id;
                    temp.dealer_id = klass.dealer_id;
                    temp.Category_id = klass.Category_id;
                    temp.subCategory_id = klass.subCategory_id;
                    temp.status = klass.status;
                    temp.last_updated = DateTime.Now;

                    db.Entry(temp).State = EntityState.Modified;
                    db.SaveChanges();
                    _productId = temp.id;
                }
            }

            return _productId;
        }

        /// <summary>
        /// Returns a list of all products in DB (irrespective of the status)
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        ///
        public static List<Product> GetAllProducts() {
            List<Product> _products = new List<Product>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                _products = db.Products.Where(p => p.id > 0).OrderBy(p => p.name).ToList();
            }
            return _products;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public static List<Product> GetAllActiveProducts() {
            List<Product> _products = new List<Product>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                _products = db.Products.Where(p => p.id > 0 && p.status).OrderBy(p => p.name).ToList();
            }
            return _products;
        }

        /// <summary>
        /// Returns a product based on the given product id.
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        public static Product GetProduct(int ProductId) {
            Product _product = new Product();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                _product = db.Products.Where(p => p.id.Equals(ProductId) || ProductId.Equals(0)).FirstOrDefault();
            }
            return _product;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="ProductName"></param>
        /// <returns></returns>
        public static List<Product> GetProductsByName(string ProductName) {
            List<Product> _products = new List<Product>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                _products = db.Products.Where(p => p.name == ProductName).ToList();
            }
            return _products;
        }

        public static Product GetProductFromVariation(Guid VariationId) {
            Product product = new Product();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                product = db.ProductVariations.Where(v => v.VariationID == VariationId).Select(v => v.Product).FirstOrDefault();
            }

            return product;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public static List<ProductEntity> GetAllProductEntity() {
            List<ProductEntity> _products = new List<ProductEntity>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                var products = db.Products.ToList();
                var productVariations = db.ProductVariations.ToList();
                var variationList = "";

                foreach (Product item in products) {
                    foreach (ProductVariation variation in productVariations) {
                        if (variation.Product_id == item.id) {
                            variationList += variation.VariationName + ", ";
                        }
                    }

                    ProductEntity entity = new ProductEntity() {
                        id = item.id,
                        name = item.name,
                        Variations = variationList.EndsWith(", ") ? variationList.Remove(variationList.Length - 2) : variationList,
                        BrandID = item.brand_id,
                        BrandName = item.Brand.name,
                        CategoryID = item.Category_id,
                        CategoryName = item.Category.name,
                        SubCategoryID = item.subCategory_id,
                        SubCategoryName = item.SubCategory.name,
                        DealerID = item.dealer_id,
                        DealerName = item.Dealer.name,
                        status = item.status,
                        date_created = item.date_created,
                        last_updated = item.last_updated,
                    };

                    _products.Add(entity);
                    variationList = "";
                }
            }

            return _products;
        }

        /// <summary>
        /// Retrieve products by their name. Returns a list of products that matches the given name.
        /// </summary>
        /// <param name="ProductName"></param>
        /// <returns></returns>
        public static List<ProductEntity> GetProductEntitiesByName(string ProductName) {
            List<ProductEntity> _products = new List<ProductEntity>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                var products = db.Products.ToList();
                var productVariations = db.ProductVariations.ToList();
                var variationList = "";

                foreach (Product item in products) {
                    if ((item.name.Contains(ProductName) && item.status == true) || (ProductName == "" && item.status == true)) {
                        foreach (ProductVariation variation in productVariations) {
                            if (variation.Product_id == item.id) {
                                variationList += variation.VariationName + ", ";
                            }
                        }

                        ProductEntity entity = new ProductEntity() {
                            id = item.id,
                            name = item.name,
                            Variations = variationList.EndsWith(", ") ? variationList.Remove(variationList.Length - 2) : variationList,
                            BrandID = item.brand_id,
                            BrandName = item.Brand.name,
                            CategoryID = item.Category_id,
                            CategoryName = item.Category.name,
                            SubCategoryID = item.subCategory_id,
                            SubCategoryName = item.SubCategory.name,
                            DealerID = item.dealer_id,
                            DealerName = item.Dealer.name,
                            status = item.status,
                            date_created = item.date_created,
                            last_updated = item.last_updated,
                        };

                        _products.Add(entity);
                    }
                }
            }

            return _products;
        }

        /// <summary>
        /// Returns true if a product with exact name exists in DB. False otherwise.
        /// </summary>
        /// <param name="ProductName"></param>
        /// <returns></returns>
        public static bool CheckProductNameAvailable(string ProductName) {
            bool flag = false;
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                int num = db.Products.Where(p => p.name == ProductName).Count();
                if (num > 0) {
                    flag = true;
                }
            }
            return flag;
        }

        /// <summary>
        /// Retrieve a ProductEntity record by its id.
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        public static List<ProductEntity> GetProductEntityById(int ProductId) {
            List<ProductEntity> _products = new List<ProductEntity>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                var products = db.Products.ToList();
                var productVariations = db.ProductVariations.ToList();
                var variationList = "";

                foreach (Product item in products) {
                    if ((item.id == ProductId && item.status.Equals(true)) || (ProductId == 0 && item.status.Equals(true))) {
                        foreach (ProductVariation variation in productVariations) {
                            if (variation.Product_id == item.id) {
                                variationList += variation.VariationName + ", ";
                            }
                        }

                        ProductEntity entity = new ProductEntity() {
                            id = item.id,
                            name = item.name,
                            Variations = variationList.EndsWith(", ") ? variationList.Remove(variationList.Length - 2) : variationList,
                            BrandID = item.brand_id,
                            BrandName = item.Brand.name,
                            CategoryID = item.Category_id,
                            CategoryName = item.Category.name,
                            SubCategoryID = item.subCategory_id,
                            SubCategoryName = item.SubCategory.name,
                            DealerID = item.dealer_id,
                            DealerName = item.Dealer.name,
                            status = item.status,
                            date_created = item.date_created,
                            last_updated = item.last_updated,
                        };

                        _products.Add(entity);
                    }
                }

                return _products;
            }
        }

        public static Dealer GetProductDealer(int ProductId) {
            var dealer = new Dealer();
            if (ProductId > 0) {
                var product = GetProduct(ProductId);
                using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                    dealer = db.Dealers.Where(d => d.id == product.dealer_id).FirstOrDefault();
                }
            }
            return dealer;
        }

        /// <summary>
        /// Return a list of products for a sub Category of specified id
        /// </summary>
        /// <param name="SubCategoryId"></param>
        /// <returns></returns>
        public static List<Product> GetProductsBySubCategory(int SubCategoryId) {
            List<Product> _products = new List<Product>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                _products = db.Products.Where(p => p.subCategory_id.Equals(SubCategoryId)).OrderBy(p => p.name).ToList();
            }
            return _products;
        }
    }
}
