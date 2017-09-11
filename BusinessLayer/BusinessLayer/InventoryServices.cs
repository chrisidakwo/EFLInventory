using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer {
    public class InventoryServices {
        public static List<InventorySummaryEntity> GetInventorySummary() {
            List<Product> _products = ProductServices.GetAllActiveProducts();
            List<InventorySummaryEntity> _summary = new List<InventorySummaryEntity>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                foreach (Product product in _products) {
                    InventorySummaryEntity se = new InventorySummaryEntity();
                    se.productID = product.id;
                    se.productName = product.name;
                    se.availableStock = product.Stock;
                    se.purchasedPrice = (double)product.cost_price;

                    var total_sales = db.Selling_Histories.Where(s => s.product_id == product.id).Sum(s => s.credit);

                    if (total_sales.HasValue) {
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