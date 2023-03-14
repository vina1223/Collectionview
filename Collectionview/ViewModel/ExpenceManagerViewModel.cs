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
using System.Xml.Linq;

namespace Collectionview.ViewModel
{
    public class ExpenceManagerViewModel  : INotifyPropertyChanged
    {
        public string _Name;
        public int _Money;
        public int _TotalValue;
        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
               
            }
        }
        public int Money
        {
            get { return _Money; }
            set
            {
                _Money = value;
                OnPropertyChanged();
            }
        }
       
        public int TotalValue 
        {
            get { return _TotalValue; }
            set
            {
                _TotalValue = value;
                OnPropertyChanged();
            }
        }

         
            public string _DisplayName;
            public int _DisplayValue;
           
            public string DisplayName
            {
                get { return _DisplayName; }
                set
                {
                    _DisplayName = value;
                    OnPropertyChanged();
                }
            }

            public int DisplayValue 
            {
                get { return _DisplayValue; }
                set
                {
                    _DisplayValue = value;
                    OnPropertyChanged();
                }
            }

        public ICommand MyCommnad { get; set; }
        public ICommand DeleteCommand { get; set; }

        public void MyMethod()
        { 
            ListData.Add(new ExpenceManagerViewModel
            {
                DisplayName = Name,
                DisplayValue = Money,
                
            });
            TotalValue = ListData.Sum(x => x.DisplayValue);
        }

        public void Delete(ExpenceManagerViewModel s)
        {
            ListData.Remove(s);
            TotalValue = ListData.Sum(x => x.DisplayValue);
        }

        public ObservableCollection<ExpenceManagerViewModel> ListData { get; set; }

        public ExpenceManagerViewModel()
        {
            MyCommnad = new Command(MyMethod);
            DeleteCommand = new Command<ExpenceManagerViewModel>(Delete);
            ListData = new ObservableCollection<ExpenceManagerViewModel>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
