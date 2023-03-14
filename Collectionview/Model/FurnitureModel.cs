using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectionview.Model
{
    public  class FurnitureModel
    {
        public class FurnitureCategoryListData
        {
            public FurnitureCategories Categoryval { get; set; }

            public ImageSource CategoriesImage { get; set; }
            public string CategoriesName { get; set; }


            public String CategoriesValue { get; set; }

        }

        public class FurnitureTrendingList
        {
            public FurnitureCategories Category { get; set; }
            public ImageSource TrendingListImage { get; set; }

            public string TrendingListName { get; set; }

            public int TrendingListPrize { get; set; }

        }

        public enum FurnitureCategories
        {
            Chair,
            Table,
            Sofa,
            CubBoard,
        }
    }
}
