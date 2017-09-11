using System.Collections.Generic;

namespace EntityLayer {
    public class SubCategoryEntity {
        public SubCategoryEntity() {
            Products = new HashSet<ProductEntity>();
        }

        public int id { get; set; }
        public string name { get; set; }
        public int category_id { get; set; }
        public string category_name { get; set; }

        public virtual ICollection<ProductEntity> Products { get; set; }
        public virtual CategoryEntity Category { get; set; }
    }
}