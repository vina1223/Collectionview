using CommunityToolkit.Maui.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static Collectionview.Model.ClothModel;

namespace Collectionview.ViewModel
{
    public class ClothStoreViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Product> _ClothProduct;
        private ObservableCollection<Product> _MyProduct;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(propertyName, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<Product> ClothProduct
        {
            get { return _ClothProduct; }
            set
            {
                _ClothProduct = value;
                OnPropertyChanged();

            }
        }
        private Category _Category;
        public Category SelectCategory
        {
            get { return _Category; }
            set
            {
                _Category = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Category> ClothCategory { get; set; }
        public ICommand MyCommand { get; set; }
       
        public ClothStoreViewModel() 
        {

            MyCommand = new Command(MyMethod);
            ClothCategory = new ObservableCollection<Category>
           {
               new Category
               {
                   Name="All",
                   ClothCategory= ProductType.All,
               },
               new Category
               {
                   Name="Winter",
                   ClothCategory= ProductType.Winter,
               },
               new Category
               {
                   Name="Mens",
                   ClothCategory=ProductType.Mens,
               },
               new Category
               {
                   Name="Womens",
                   ClothCategory= ProductType.Womens,
               },
               new Category
               {
                   Name="Sports",
                   ClothCategory= ProductType.Sports,
               },
               new Category
               {
                   Name="Others",
                   ClothCategory= ProductType.Others,
               },

           };
            SelectCategory = ClothCategory.FirstOrDefault();
           _MyProduct= new ObservableCollection<Product> 
           {
              new Product
              {
                  ProductImage = "dotnet_bot",
                  ProductName ="ClothName",
                  ProductPrize = 100,
                  ProductCategory= ProductType.Winter,
                  AllCategory = ProductType.All,
              },
              new Product
              {
                  ProductImage = "dotnet_bot",
                  ProductName ="ClothName",
                  ProductPrize = 100,
                  ProductCategory= ProductType.Mens,
                  AllCategory = ProductType.All,
              },
              new Product
              {
                  ProductImage = "dotnet_bot",
                  ProductName ="ClothName",
                  ProductPrize = 100,
                  ProductCategory= ProductType.Winter,
                  AllCategory = ProductType.All,
              },new Product
              {
                  ProductImage = "dotnet_bot",
                  ProductName ="ClothName",
                  ProductPrize = 100,
                  ProductCategory= ProductType.Winter,
                  AllCategory = ProductType.All,
              },
              new Product
              {
                  ProductImage = "dotnet_bot",
                  ProductName ="ClothName",
                  ProductPrize = 100,
                  ProductCategory= ProductType.Mens,
                  AllCategory = ProductType.All,
              },
               new Product
              {
                  ProductImage = "dotnet_bot",
                  ProductName ="ClothName",
                  ProductPrize = 100,
                  ProductCategory= ProductType.Womens,
                  AllCategory = ProductType.All,
              },
                new Product
              {
                  ProductImage = "dotnet_bot",
                  ProductName ="ClothName",
                  ProductPrize = 100,
                  ProductCategory= ProductType.Womens,
                  AllCategory = ProductType.All,
              },
                new Product
              {
                  ProductImage = "dotnet_bot",
                  ProductName ="ClothName",
                  ProductPrize = 100,
                  ProductCategory= ProductType.Sports,
                  AllCategory = ProductType.All,
              },
                new Product
              {
                  ProductImage = "dotnet_bot",
                  ProductName ="ClothName",
                  ProductPrize = 100,
                  ProductCategory= ProductType.Sports,
                  AllCategory = ProductType.All,
              },

                new Product
              {
                  ProductImage = "dotnet_bot",
                  ProductName ="ClothName",
                  ProductPrize = 100,
                  ProductCategory= ProductType.Sports,
                  AllCategory = ProductType.All,
              },
                new Product
              {
                    AllCategory = ProductType.All,
                  ProductImage = "dotnet_bot",
                  ProductName ="ClothName",
                  ProductPrize = 100,
                  ProductCategory= ProductType.Others,
                  
              },
                new Product
              {
                  ProductImage = "dotnet_bot",
                  ProductName ="ClothName",
                  ProductPrize = 100,
                  ProductCategory= ProductType.Others,
                  AllCategory = ProductType.All,
              },
           };

            var ShowDetails = _MyProduct.Where(x => x.AllCategory.Equals(SelectCategory.ClothCategory)).ToObservableCollection();
            ClothProduct = ShowDetails;
        }

        public void MyMethod()
        {
            if (SelectCategory.ClothCategory == ProductType.All)
            {
                var ShowDetails = _MyProduct.Where(x => x.AllCategory.Equals(SelectCategory.ClothCategory)).ToObservableCollection();
                ClothProduct = ShowDetails;
            }
            else
            {
                var ShowDetails = _MyProduct.Where(x => x.ProductCategory.Equals(SelectCategory.ClothCategory)).ToObservableCollection();
                ClothProduct = ShowDetails;
            }
            
        }
    }
}
