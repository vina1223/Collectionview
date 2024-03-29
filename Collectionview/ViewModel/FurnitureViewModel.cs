﻿using Collectionview.Model;
using CommunityToolkit.Maui.Core.Extensions;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using static Collectionview.Model.FurnitureModel;

namespace Collectionview.ViewModel
{
    public class FurnitureViewModel : INotifyPropertyChanged
    {  
        public ICommand TapCommand { get; private set; }
        

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private FurnitureCategoryListData itemSelect;
        public FurnitureCategoryListData ItemSelect
        {
            get { return itemSelect; }
            set
            {
                itemSelect = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<FurnitureTrendingList> _furnituretrendinglist;
        public ObservableCollection<FurnitureTrendingList> MyFurnitureTrendingLists
        {
            get { return _furnituretrendinglist; }
            set
            {
                _furnituretrendinglist = value;
                OnPropertyChanged();
            }
        }


        public ObservableCollection<FurnitureCategoryListData> FurnitureProductCategory { get; set; }
        private ObservableCollection<FurnitureTrendingList> FurnitureProductList { get; set; }
       
        public FurnitureViewModel()
        {
            TapCommand = new Command(MyMethod);
            FurnitureProductCategory = new ObservableCollection<FurnitureCategoryListData>
            {
                new FurnitureCategoryListData
                {
                CategoriesImage = "dotnet_bot",
                CategoriesName= "Chair",
                CategoriesValue = "4",
                Categoryval = FurnitureCategories.Chair,
                },
            new FurnitureCategoryListData
            {
                CategoriesImage = "dotnet_bot",
                CategoriesName= "Table",
                CategoriesValue ="2",
                Categoryval = FurnitureCategories.Table,
            },

              new FurnitureCategoryListData
            {
                CategoriesImage = "dotnet_bot",
                CategoriesName= "Sofa",
                CategoriesValue = "1",
                Categoryval = FurnitureCategories.Sofa,
            },

               new FurnitureCategoryListData
            {
                CategoriesImage = "dotnet_bot",
                CategoriesName= "CubBoard",
                CategoriesValue = "0",
                Categoryval = FurnitureCategories.CubBoard,
            },  

            };
            ItemSelect = FurnitureProductCategory.FirstOrDefault();
            
            FurnitureProductList = new ObservableCollection<FurnitureTrendingList> 
            {
                 new FurnitureTrendingList
                 {
                     TrendingListImage="dotnet_bot",
                     TrendingListName = "Ivonne chair",
                     TrendingListPrize = 300,
                     Category = FurnitureCategories.Chair,
                     
                 },
                 new FurnitureTrendingList
                 {
                     TrendingListImage="dotnet_bot",
                     TrendingListName = "Office chair",
                     TrendingListPrize = 300,
                     Category = FurnitureCategories.Chair,
                 },
                 new FurnitureTrendingList
                 {
                     TrendingListImage="dotnet_bot",
                     TrendingListName = "Armchair",
                     TrendingListPrize = 200,
                     Category = FurnitureCategories.Chair,
                 },
                 new FurnitureTrendingList
                 {
                     TrendingListImage="dotnet_bot",
                     TrendingListName = "Pattern chair",
                     TrendingListPrize = 400,
                     Category = FurnitureCategories.Chair,
                 },
                 new FurnitureTrendingList
                 {
                     TrendingListImage="dotnet_bot",
                     TrendingListName = "Office Table",
                     TrendingListPrize = 300,
                     Category = FurnitureCategories.Table,
                 },
                 new FurnitureTrendingList
                 {
                     TrendingListImage="dotnet_bot",
                     TrendingListName = "Wooden Table",
                     TrendingListPrize = 300,
                     Category = FurnitureCategories.Table,
                 },
                 new FurnitureTrendingList
                 {
                     TrendingListImage="dotnet_bot",
                     TrendingListName = "Luxuri Sofa",
                     TrendingListPrize = 300,
                     Category = FurnitureCategories.Sofa,
                 },
            };

            var details = FurnitureProductList.Where(x => x.Category== ItemSelect.Categoryval).ToObservableCollection();
             MyFurnitureTrendingLists= details;
        }

        public void MyMethod()
        {
            var details = FurnitureProductList.Where(x => x.Category == ItemSelect.Categoryval).ToObservableCollection();
            MyFurnitureTrendingLists = details;
        }
        
    }
   
}
