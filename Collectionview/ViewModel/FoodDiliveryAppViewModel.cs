using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectionview.ViewModel
{
    public class MyData
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public ImageSource ProductImage { get; set; }
        public Color Backgroundcolor { get; set; }
        public FlowDirection ChangeFlow { get; set; }

        public HorizontalAlignment HorizontalValue { get; set; }
        public HorizontalAlignment HorizontalName { get; set; }
    }

    public class FoodDiliveryAppViewModel
    {
       
        
            public ObservableCollection<MyData> MyData { get; set; }

            public FoodDiliveryAppViewModel()
            {
                MyData = new ObservableCollection<MyData>
            {
                new MyData()
                {
                    Name="MCSpicy Chicken Burger",
                    ProductImage="dotnet_bot",
                    Backgroundcolor= Colors.Red,
                    Value= 300,

                },

                new MyData()
                {
                    Name="MCVegg Burger",
                    ProductImage="dotnet_bot",
                    Backgroundcolor= Colors.LawnGreen,
                    Value=200,
                    ChangeFlow= FlowDirection.RightToLeft,
                    HorizontalName = HorizontalAlignment.Right,

                },
                 new MyData()
                {
                    Name="MCVegg Subway",
                    ProductImage="dotnet_bot",
                    Backgroundcolor= Colors.LawnGreen,
                    Value=300,
                    ChangeFlow= FlowDirection.RightToLeft,
                },
                  new MyData()
                {
                    Name="MCSpicy Chicken Burger",
                    ProductImage="dotnet_bot",
                    Backgroundcolor= Colors.Red,
                    Value=100,
                },

                   new MyData()
                {
                    Name="MCSpicy Chicken Pizza",
                    ProductImage="dotnet_bot",
                    Backgroundcolor= Colors.Red,
                    Value=400,
                },

                    new MyData()
                {
                    Name="MCSpicy Chicken Swarma",
                    ProductImage="dotnet_bot",
                    Backgroundcolor= Colors.Red,
                    Value=600,
                },
            };
            }



        
    }
}
