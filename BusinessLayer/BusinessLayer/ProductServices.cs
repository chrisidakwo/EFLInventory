using DataLayer;
using EntityLayer;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer {
    public class ProductServices {
        public static int AddUpdateProduct(Product klass) {
            return ProductProvider.AddUpdateProduct(klass);
        }

        public static Product GetProduct(int ProductId) {
            return ProductProvider.GetProduct(ProductId);
        }

        public static List<Product> GetAllActiveProducts() {
            return ProductProvider.GetAllActiveProducts();
        }

        public static List<Product> GetAllProducts() {
            return ProductProvider.GetAllProducts();
        }

        public static List<ProductEntity> GetAllProductEntity() {
            return ProductProvider.GetAllProductEntity();
        }

        public static List<ProductEntity> GetProductEntitiesByName(string ProductName) {
            return ProductProvider.GetProductEntitiesByName(ProductName);
        }

        public static List<Product> GetProductsByName(string ProductName) {
            return ProductProvider.GetProductsByName(ProductName);
        }

        public static List<ProductEntity> GetProductsEntityById(int ProductId) {
            return ProductProvider.GetProductEntityById(ProductId);
        }

        public static ProductEntity GetProductEntityById(int ProductId) {
            return ProductProvider.GetProductEntityById(ProductId).FirstOrDefault();
        }

        public static Dealer GetProductDealer(int ProductId) {
            return ProductProvider.GetProductDealer(ProductId);
        }

        public static List<Product> GetProductBySubCategory(int subcategoryId) {
            return ProductProvider.GetProductsBySubCategory(subcategoryId);
        }

        public static int UpdateProductStock(int ProductId) {
            return ProductProvider.UpdateProductStock(ProductId);
        }

        public static List<Product> GetEmptyStockList() {
            return ProductProvider.GetEmptyStock();
        }

        public static bool CheckProductNameAvailable(string ProductName) {
            return ProductProvider.CheckProductNameAvailable(ProductName);
        }
    }
}