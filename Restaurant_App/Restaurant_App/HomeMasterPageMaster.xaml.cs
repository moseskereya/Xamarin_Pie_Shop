using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Restaurant_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeMasterPageMaster : ContentPage
    {
        public ListView ListView;

        public HomeMasterPageMaster()
        {
            InitializeComponent();

            BindingContext = new HomeMasterPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class HomeMasterPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<HomeMasterPageMasterMenuItem> MenuItems { get; set; }

            public HomeMasterPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<HomeMasterPageMasterMenuItem>(new[]
                {
                    new HomeMasterPageMasterMenuItem { Id = 0, Title = "Page 1" },
                    new HomeMasterPageMasterMenuItem { Id = 1, Title = "Page 2" },
                    new HomeMasterPageMasterMenuItem { Id = 2, Title = "Page 3" },
                    new HomeMasterPageMasterMenuItem { Id = 3, Title = "Page 4" },
                    new HomeMasterPageMasterMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}