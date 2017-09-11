using System.Collections.Generic;

namespace EntityLayer {
    public class CategoryEntity {
        public CategoryEntity() {
            Products = new HashSet<ProductEntity>();
            SubCategories = new HashSet<SubCategoryEntity>();
        }

        public int id { get; set; }
        public string name { get; set; }

        public virtual ICollection<ProductEntity> Products { get; set; }
        public virtual ICollection<SubCategoryEntity> SubCategories { get; set; }
    }
}