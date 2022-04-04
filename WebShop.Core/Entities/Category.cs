using System;
using System.Collections.Generic;

namespace WebShop.Core.Entities
{
    public partial class Category
    {
        public Category()
        {
            ProductCategories = new HashSet<ProductCategory>();
        }

        public int CategoryId { get; set; }
        public string Category1 { get; set; } = null!;

        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
