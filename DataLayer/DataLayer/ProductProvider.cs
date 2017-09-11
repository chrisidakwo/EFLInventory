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
        public static int AddUpdateProduct(Product klass) {
            int _productId = 0;
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                if (klass.id > 0) {
                    Product temp = db.Products.Where(p => p.id == klass.id).FirstOrDefault();
                    if (!temp.Equals(null)) {
                        temp.id = klass.id;
                        temp.name = klass.name;
                        temp.Category_id = klass.Category_id;
                        temp.image_url = " ";
                        temp.brand = klass.brand;
                        temp.subCategory_id = klass.subCategory_id;
                        temp.cost_price = klass.cost_price;
                        temp.sell_price = klass.sell_price;
                        temp.weight = klass.weight;
                        temp.status = klass.status;
                        temp.Stock = klass.Stock;
                        temp.last_updated = DateTime.Now;

                        db.Entry(temp).State = EntityState.Modified;
                    }
                } else {
                    klass.date_created = DateTime.Now;
                    klass.last_updated = DateTime.Now;
                    db.Products.Add(klass);
                }

                db.SaveChanges();
                if (klass.id > 0) {
                    _productId = klass.id;
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

        public static List<ProductEntity> GetAllProductEntity() {
            List<ProductEntity> _products = new List<ProductEntity>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                _products = (from p in db.Products
                             join c in db.Categories on p.Category_id equals c.id
                             join s in db.SubCategories on p.subCategory_id equals s.id
                             select new ProductEntity {
                                 id = p.id,
                                 name = p.name,
                                 brand = p.brand,
                                 image_url = p.image_url,
                                 category_name = c.name,
                                 subcategory_name = s.name,
                                 category_id = c.id,
                                 subcategory_id = s.id,
                                 Stock = p.Stock,
                                 cost_price = p.cost_price,
                                 sell_price = p.sell_price,
                                 weight = p.weight,
                                 status = p.status,
                             }).OrderBy(p => p.name).ToList();
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
        /// Retrieve products by their name. Returns a list of products that matches the given name.
        /// </summary>
        /// <param name="ProductName"></param>
        /// <returns></returns>
        public static List<ProductEntity> GetProductEntitiesByName(string ProductName) {
            List<ProductEntity> _products = new List<ProductEntity>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                _products = (from p in db.Products
                             join c in db.Categories on p.Category_id equals c.id
                             join s in db.SubCategories on p.subCategory_id equals s.id
                             where (p.name.Contains(ProductName) && (p.status == true)
                             || (ProductName == "") && (p.status == true))
                             select new ProductEntity {
                                 id = p.id,
                                 name = p.name,
                                 image_url = p.image_url,
                                 brand = p.brand,
                                 category_id = p.Category_id,
                                 subcategory_id = p.subCategory_id,
                                 weight = p.weight,
                                 cost_price = p.cost_price,
                                 sell_price = p.sell_price,
                                 status = p.status,
                                 Stock = p.Stock
                             }).ToList();
            }

            return _products;
        }

        public static List<Product> GetProductsByName(string ProductName) {
            List<Product> _products = new List<Product>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                _products = db.Products.Where(p => p.name == ProductName).ToList();
            }
            return _products;
        }

        /// <summary>
        /// Retrieve a ProductEntity record by its id.
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        public static List<ProductEntity> GetProductEntityById(int ProductId) {
            List<ProductEntity> _products = new List<ProductEntity>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                _products = (from p in db.Products
                             join c in db.Categories on p.Category_id equals c.id
                             join s in db.SubCategories on p.subCategory_id equals s.id
                             where (p.id.Equals(ProductId) && p.status.Equals(true)
                             || (ProductId.Equals(0) && p.status.Equals(true)))
                             select new ProductEntity {
                                 id = p.id,
                                 name = p.name,
                                 image_url = p.image_url,
                                 brand = p.brand,
                                 category_id = c.id,
                                 subcategory_id = s.id,
                                 weight = p.weight,
                                 cost_price = p.cost_price,
                                 sell_price = p.sell_price,
                                 status = p.status,
                                 Stock = p.Stock,
                             }).ToList();
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

        /// <summary>
        /// Adds or update an a product stock record. Returns the current stock value of the product.
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        public static int UpdateProductStock(int ProductId) {
            int _currentStock = 0;
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                Product temp = GetProduct(ProductId);
                if (temp != null) {
                    int _creditStock = 0;
                    int _debitStock = 0;

                    try {
                        _creditStock = db.Selling_Histories.Where(s => s.product_id == ProductId &&
                        s.transaction_type_id == 2).Sum(q => q.quantity);  // For debit transactions
                    } catch { }

                    try {
                        _debitStock = db.Selling_Histories.Where(s => s.product_id == ProductId &&
                        s.transaction_type_id == 1).Sum(q => q.quantity);  // For credit transactions
                    } catch { }
                    _currentStock = _creditStock - _debitStock;
                    temp.Stock = _currentStock;
                    AddUpdateProduct(temp);
                }
            }

            return _currentStock;
        }

        /// <summary>
        /// Returns a list of products with no stock
        /// </summary>
        /// <returns></returns>
        public static List<Product> GetEmptyStock() {
            List<Product> _products = new List<Product>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                object zero = 0;
                _products = db.Products.Where(p => p.Stock.HasValue && p.status.Equals(true)).Where(p => p.Stock == 0).ToList();
            }
            return _products;
        }
    }
}