using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Collectionview.ViewModel
{
    public class Data
    {
        public string ProductName{ get;set; }
        public ImageSource ProductImage { get; set; }
        public string NewProduct { get; set; }
        public string Rating { get; set; }
        public string Calories { get; set; }
        public string Time { get; set; }
        public bool Visible { get; set; }
    }
    public class RecipiViewModel
    {
        public ObservableCollection<Data> ProductDetails { get; set; }
        public RecipiViewModel()
        {
            ProductDetails = new ObservableCollection<Data>
            {
                new Data()
                {
                    ProductName ="Cheese Piza",
                    ProductImage = "dotnet_bot",
                    NewProduct ="New",
                    Visible= true,
                    Rating = "4.5",
                    Calories = "150Cal",
                    Time = "25.00",
                },

                 new Data()
                {
                    ProductName ="Burger",
                    ProductImage = "dotnet_bot",
                    NewProduct ="New",
                    Rating = "4.5",
                    Calories = "150Cal",
                    Time = "30.00",
                },

                  new Data()
                {
                    ProductName ="Burger",
                    ProductImage = "dotnet_bot",
                    Visible = true,
                    NewProduct ="New",
                    Rating = "4.5",
                    Calories = "150Cal",
                    Time = "30.00",
                },
                new Data()
                {
                    ProductName ="Burger",
                    ProductImage = "dotnet_bot",
                    NewProduct ="New",
                    Rating = "4.5",
                    Calories = "150Cal",
                    Time = "30.00",
                },

                 new Data()
                {
                    ProductName ="Burger",
                    ProductImage = "dotnet_bot",
                    NewProduct ="New",
                    Rating = "4.5",
                    Calories = "150Cal",
                    Time = "30.00",
                },

                  new Data()
                {
                    ProductName ="Burger",
                    ProductImage = "dotnet_bot",
                    Visible =true,
                    NewProduct ="New",
                    Rating = "4.5",
                    Calories = "150Cal",
                    Time = "30.00",
                },

                    new Data()
                {
                    ProductName ="Burger",
                    ProductImage = "dotnet_bot",
                    NewProduct ="New",
                    Rating = "4.5",
                    Calories = "150Cal",
                    Time = "30.00",
                },


            };
        }
    }
}
