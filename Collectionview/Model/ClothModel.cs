using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectionview.Model
{
    public class ClothModel
    {
        public class Category
        {
            public string Name { get; set; }
            public ProductType ClothCategory { get; set; }
        }
        public class Product
        {
            public ImageSource ProductImage { get; set; }
            public string ProductName { get; set; }
            public int ProductPrize { get; set; }
            public ProductType ProductCategory { get; set; }
            public ProductType AllCategory { get; set; }
            public ImageSource ChangeImg { get; set; }

        }

        public enum ProductType
        {
            All,
            Winter,
            Mens,
            Womens,
            Sports,
            Others,
        }

    }
}
