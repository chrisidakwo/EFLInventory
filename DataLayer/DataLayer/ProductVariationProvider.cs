using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer {
    public class ProductVariationProvider {
        /// <summary>
        ///
        /// </summary>
        /// <param name="ProductID"></param>
        /// <param name="Variation"></param>
        /// <returns></returns>
        public static Guid AddProductVariation(ProductVariation Variation) {
            Guid VariationID = new Guid();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                ProductVariation temp = db.ProductVariations.Where(v => v.VariationID == Variation.VariationID).FirstOrDefault();
                if (temp == null) {
                    //Variation.VariationID = Guid.NewGuid();
                    Variation.date_created = DateTime.Now;
                    Variation.last_updated = DateTime.Now;
                    db.ProductVariations.Add(Variation);
                    db.SaveChanges();
                    VariationID = Variation.VariationID;
                }
            }

            return VariationID;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="product_id"></param>
        /// <param name="temp"></param>
        public static Guid UpdateProductVariation(ProductVariation Product) {
            Guid VariationID = new Guid();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                ProductVariation temp = db.ProductVariations.Where(v => v.VariationID == Product.VariationID).FirstOrDefault();
                if (temp != null) {
                    temp.VariationID = Product.VariationID;
                    temp.Product_id = Product.Product_id;
                    temp.VariationName = Product.VariationName;
                    temp.image_url = Product.image_url;
                    temp.measured_by = Product.measured_by;
                    temp.weight = Product.weight;
                    temp.cost_price = Product.cost_price;
                    temp.retail_price = Product.retail_price;
                    temp.wholesale_price = Product.wholesale_price;
                    temp.stock_threshold = Product.stock_threshold;
                    temp.stock = Product.stock;
                    temp.last_updated = DateTime.Now;

                    db.Entry(temp).State = System.Data.EntityState.Modified;
                    db.SaveChanges();
                }
            }

            return VariationID;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="VariationID"></param>
        /// <returns></returns>
        public static ProductVariation GetProductVariation(Guid VariationID) {
            ProductVariation _variation = new ProductVariation();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                ProductVariation temp = db.ProductVariations.Where(v => v.VariationID == VariationID).FirstOrDefault();
                if (temp != null) {
                    _variation = temp;
                }
            }

            return _variation;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="VariationName"></param>
        /// <returns></returns>
        public static ProductVariation GetProductVariation(string VariationName) {
            ProductVariation _variation = new ProductVariation();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                ProductVariation temp = db.ProductVariations.Where(v => v.VariationName == VariationName).FirstOrDefault();

                if (temp != null) {
                    _variation = temp;
                }
            }

            return _variation;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public static List<ProductVariation> GetAllProductVariations() {
            List<ProductVariation> _variations = new List<ProductVariation>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                _variations = db.ProductVariations.OrderBy(v => v.Product.name).ToList();
            }
            return _variations;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public static List<ProductVariation> GetVarationsForProduct(int productId) {
            List<ProductVariation> _variations = new List<ProductVariation>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                _variations = db.ProductVariations.Where(v => v.Product_id == productId).OrderBy(v => v.VariationName).ToList();
            }

            return _variations;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="SubCategoryId"></param>
        /// <returns></returns>
        public static List<ProductVariationEntity> GetProductVariationsBySubCategory(int SubCategoryId) {
            List<ProductVariationEntity> _variations = new List<ProductVariationEntity>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                _variations = GetAllProductsWithVariations().Where(v => v.SubCategoryID == SubCategoryId).OrderBy(v => v.VariationName).ToList();
            }

            return _variations;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="VariationID"></param>
        /// <returns></returns>
        public static ProductVariationEntity GetProductVariationEntity(Guid VariationID) {
            ProductVariationEntity _variation = new ProductVariationEntity();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                _variation = (from v in db.ProductVariations
                              join p in db.Products on v.Product_id equals p.id
                              join d in db.Dealers on p.dealer_id equals d.id
                              join m in db.MeasuringTypes on v.measured_by equals m.id
                              where v.VariationID == VariationID
                              select new ProductVariationEntity {
                                  VariationID = v.VariationID,
                                  ProductID = p.id,
                                  ProductName = p.name,
                                  VariationName = p.name + " " + v.VariationName,
                                  BrandName = p.Brand.name,
                                  BrandID = p.brand_id,
                                  DealerName = d.name,
                                  DealerID = p.dealer_id,
                                  CategoryID = p.Category_id,
                                  CategoryName = p.Category.name,
                                  SubCategoryID = p.subCategory_id,
                                  SubCategoryName = p.SubCategory.name,
                                  status = p.status,
                                  image_url = v.image_url,
                                  measured_by = m.name,
                                  MeasuringTypeID = m.id,
                                  weight = v.weight,
                                  cost_price = v.cost_price,
                                  retail_price = v.retail_price,
                                  wholesale_price = v.wholesale_price,
                                  stock_threshold = v.stock_threshold,
                                  stock = v.stock,
                              }).FirstOrDefault();
            }

            return _variation;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public static List<ProductVariationEntity> GetAllProductsWithVariations() {
            List<ProductVariationEntity> _products = new List<ProductVariationEntity>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                _products = (from v in db.ProductVariations
                             join p in db.Products on v.Product_id equals p.id
                             join d in db.Dealers on p.dealer_id equals d.id
                             join m in db.MeasuringTypes on v.measured_by equals m.id
                             select new ProductVariationEntity {
                                 VariationID = v.VariationID,
                                 ProductID = p.id,
                                 ProductName = p.name,
                                 VariationName = p.name + " " + v.VariationName,
                                 BrandName = p.Brand.name,
                                 BrandID = p.brand_id,
                                 DealerName = d.name,
                                 DealerID = p.dealer_id,
                                 CategoryID = p.Category_id,
                                 CategoryName = p.Category.name,
                                 SubCategoryID = p.subCategory_id,
                                 SubCategoryName = p.SubCategory.name,
                                 status = p.status,
                                 image_url = v.image_url,
                                 measured_by = m.name,
                                 MeasuringTypeID = m.id,
                                 weight = v.weight,
                                 cost_price = v.cost_price,
                                 retail_price = v.retail_price,
                                 wholesale_price = v.wholesale_price,
                                 stock_threshold = v.stock_threshold,
                                 stock = v.stock,
                             }).OrderBy(v => v.ProductName).ToList();
            }

            return _products;
        }

        /// <summary>
        /// Adds or update an a product stock record. Returns the current stock value of the product.
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        public static int UpdateProductVariationStock(Guid VariationID, bool purchase, int threshold = 0) {
            int _currentStock = 0;
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                ProductVariation temp = GetProductVariation(VariationID);
                if (temp != null) {
                    int _creditStock = 0;
                    int _debitStock = 0;

                    try {
                        _creditStock = db.Transaction_Histories.Where(s => s.ProductVariationVariationID == VariationID &&
                        s.transaction_type == "Debit").Sum(q => q.quantity);  // For debit transactions (purchase)
                    } catch { }

                    try {
                        _debitStock = db.Transaction_Histories.Where(s => s.ProductVariationVariationID == VariationID &&
                        s.transaction_type == "Credit").Sum(q => q.quantity);  // For credit transactions (sales)
                    } catch { }
                    _currentStock = _creditStock - _debitStock;
                    temp.stock = _currentStock;
                    if (purchase) {
                        temp.stock_threshold = threshold;
                    }
                    UpdateProductVariation(temp);
                }
            }

            return _currentStock;
        }

        /// <summary>
        /// Returns a list of products with no stock
        /// </summary>
        /// <returns></returns>
        public static List<ProductVariationEntity> GetEmptyStock() {
            List<ProductVariationEntity> _products = new List<ProductVariationEntity>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                _products = (from v in db.ProductVariations
                             join p in db.Products on v.Product_id equals p.id
                             join d in db.Dealers on p.dealer_id equals d.id
                             join m in db.MeasuringTypes on v.measured_by equals m.id
                             where v.stock == 0 && v.Product.status.Equals(true)
                             select new ProductVariationEntity {
                                 VariationID = v.VariationID,
                                 ProductID = p.id,
                                 ProductName = p.name,
                                 VariationName = p.name + " " + v.VariationName,
                                 BrandName = p.Brand.name,
                                 BrandID = p.brand_id,
                                 DealerName = d.name,
                                 DealerID = p.dealer_id,
                                 CategoryID = p.Category_id,
                                 CategoryName = p.Category.name,
                                 SubCategoryID = p.subCategory_id,
                                 SubCategoryName = p.SubCategory.name,
                                 status = p.status,
                                 image_url = v.image_url,
                                 measured_by = m.name,
                                 MeasuringTypeID = m.id,
                                 weight = v.weight,
                                 cost_price = v.cost_price,
                                 retail_price = v.retail_price,
                                 wholesale_price = v.wholesale_price,
                                 stock_threshold = v.stock_threshold,
                                 stock = v.stock,
                             }).OrderBy(v => v.ProductName).ToList();
            }
            return _products;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public static List<ProductVariationEntity> GetProductsOnLowStock() {
            List<ProductVariationEntity> _products = new List<ProductVariationEntity>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                _products = (from v in db.ProductVariations
                             join p in db.Products on v.Product_id equals p.id
                             join d in db.Dealers on p.dealer_id equals d.id
                             join m in db.MeasuringTypes on v.measured_by equals m.id
                             where v.stock < v.stock_threshold && v.stock != 0
                             select new ProductVariationEntity {
                                 VariationID = v.VariationID,
                                 ProductID = p.id,
                                 ProductName = p.name,
                                 VariationName = p.name + " " + v.VariationName,
                                 BrandName = p.Brand.name,
                                 BrandID = p.brand_id,
                                 DealerName = d.name,
                                 DealerID = p.dealer_id,
                                 CategoryID = p.Category_id,
                                 CategoryName = p.Category.name,
                                 SubCategoryID = p.subCategory_id,
                                 SubCategoryName = p.SubCategory.name,
                                 status = p.status,
                                 image_url = v.image_url,
                                 measured_by = m.name,
                                 MeasuringTypeID = m.id,
                                 weight = v.weight,
                                 cost_price = v.cost_price,
                                 retail_price = v.retail_price,
                                 wholesale_price = v.wholesale_price,
                                 stock_threshold = v.stock_threshold,
                                 stock = v.stock,
                             }).OrderBy(v => v.ProductName).ToList();
            }
            return _products;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public static List<ProductVariationEntity> GetExpiredProducts() {
            List<ProductVariationEntity> _products = new List<ProductVariationEntity>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                _products = (from v in db.ProductVariations
                             join p in db.Products on v.Product_id equals p.id
                             join m in db.MeasuringTypes on v.measured_by equals m.id
                             select new ProductVariationEntity {
                                 VariationID = v.VariationID,
                                 ProductID = p.id,
                                 ProductName = p.name,
                                 VariationName = p.name + " " + v.VariationName,
                                 BrandName = p.Brand.name,
                                 BrandID = p.brand_id,
                                 DealerName = p.Dealer.name,
                                 DealerID = p.dealer_id,
                                 CategoryID = p.Category_id,
                                 CategoryName = p.Category.name,
                                 SubCategoryID = p.subCategory_id,
                                 SubCategoryName = p.SubCategory.name,
                                 status = p.status,
                                 image_url = v.image_url,
                                 measured_by = m.name,
                                 MeasuringTypeID = m.id,
                                 weight = v.weight,
                                 cost_price = v.cost_price,
                                 retail_price = v.retail_price,
                                 wholesale_price = v.wholesale_price,
                                 stock_threshold = v.stock_threshold,
                                 stock = v.stock,
                             }).OrderBy(v => v.ProductName).ToList();
            }
            return _products;
        }
    }
}
