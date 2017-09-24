using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer {
    public class InventoryServices {
        public static List<InventorySummaryEntity> GetInventorySummary() {
            List<ProductVariationEntity> _products = ProductVariationServices.GetAllProductsWithVariations();
            List<InventorySummaryEntity> _summary = new List<InventorySummaryEntity>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                foreach (ProductVariationEntity variation in _products) {
                    InventorySummaryEntity se = new InventorySummaryEntity();
                    se.productID = variation.ProductID;
                    se.VariationID = variation.VariationID;
                    se.VariationName = variation.VariationName;
                    se.availableStock = variation.stock;
                    se.unit_measurement = variation.weight.ToString() + " " + variation.measured_by;
                    se.retailPrice = Convert.ToDouble(variation.retail_price);
                    se.wholesalePrice = Convert.ToDouble(variation.wholesale_price);

                    decimal total_sales = 0.00M;

                    try {
                        total_sales = db.Transaction_Histories.Where(s => s.ProductVariationVariationID == variation.VariationID).Sum(s => s.credit);
                    } catch (Exception) {
                    }

                    if (total_sales != Convert.ToDecimal(0)) {
                        se.totalSales = (double)total_sales;
                    } else {
                        se.totalSales = Convert.ToDouble(0);
                    }

                    _summary.Add(se);
                }
            }
            return _summary;
        }
    }
}
