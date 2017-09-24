using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;

namespace BusinessLayer {
    public class ProductVariationServices {
        /// <summary>
        ///
        /// </summary>
        /// <param name="product_id"></param>
        /// <param name="Product"></param>
        /// <returns></returns>
        public static Guid AddProductVariation(ProductVariation Product) {
            return ProductVariationProvider.AddProductVariation(Product);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="Product"></param>
        /// <returns></returns>
        public static Guid UpdateProductVariation(ProductVariation Product) {
            return ProductVariationProvider.UpdateProductVariation(Product);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="VariationID"></param>
        /// <returns></returns>
        public static ProductVariation GetProductVariation(Guid VariationID) {
            return ProductVariationProvider.GetProductVariation(VariationID);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="VariationName"></param>
        /// <returns></returns>
        public static ProductVariation GetProductVariation(string VariationName) {
            return ProductVariationProvider.GetProductVariation(VariationName);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        public static List<ProductVariation> GetVariationsForProduct(int ProductId) {
            return ProductVariationProvider.GetVarationsForProduct(ProductId);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="SubCategoryId"></param>
        /// <returns></returns>
        public static List<ProductVariationEntity> GetProductVariationsBySubCategory(int SubCategoryId) {
            return ProductVariationProvider.GetProductVariationsBySubCategory(SubCategoryId);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="VariationID"></param>
        /// <returns></returns>
        public static ProductVariationEntity GetProductVariationEntity(Guid VariationID) {
            return ProductVariationProvider.GetProductVariationEntity(VariationID);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public static List<ProductVariationEntity> GetAllProductsWithVariations() {
            return ProductVariationProvider.GetAllProductsWithVariations();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="VarationID"></param>
        /// <returns></returns>
        public static int UpdateProductVariationStock(Guid VarationID, bool purchase, int threshold = 0) {
            return ProductVariationProvider.UpdateProductVariationStock(VarationID, purchase, threshold);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public static List<ProductVariationEntity> GetEmptyStock() {
            return ProductVariationProvider.GetEmptyStock();
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public List<ProductVariationEntity> GetProductsOnLowStock() {
            return ProductVariationProvider.GetProductsOnLowStock();
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public static List<ProductVariationEntity> GetExpiredProducts() {
            return ProductVariationProvider.GetExpiredProducts();
        }
    }
}
