using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;

namespace BusinessLayer {
    public class ProductServices {
        public static int AddProduct(Product klass) {
            return ProductProvider.AddProduct(klass);
        }

        public static int UpdateProduct(Product klass) {
            return ProductProvider.UpdateProduct(klass);
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

        public static Product GetProductFromVariation(Guid VariationId) {
            return ProductProvider.GetProductFromVariation(VariationId);
        }

        public static Dealer GetProductDealer(int ProductId) {
            return ProductProvider.GetProductDealer(ProductId);
        }

        public static List<Product> GetProductBySubCategory(int subcategoryId) {
            return ProductProvider.GetProductsBySubCategory(subcategoryId);
        }

        public static bool CheckProductNameAvailable(string ProductName) {
            return ProductProvider.CheckProductNameAvailable(ProductName);
        }
    }
}
