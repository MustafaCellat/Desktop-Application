using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadimRadiatorInterface
{
    public class ProductToCategories
    {
        public class Product
        {
            public int id { get; set; }
        }
        public class Category
        {
            public int id { get; set; }
        }
        public class ProductToCategoriesInformation
        {
            public int id { get; set; }
            public Nullable<int> sortOrder { get; set; }
            public Product product { get; set; }
            public Category category { get; set; }
        }
    }
}
