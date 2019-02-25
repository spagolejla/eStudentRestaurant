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

namespace eStudentRestaurant_Xamarin.Navigations
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClientNavigationMaster : ContentPage
    {
        public ListView ListView;

        public ClientNavigationMaster()
        {
            InitializeComponent();

            BindingContext = new ClientNavigationMasterViewModel();
            ListView = MenuItemsListView;
        }

        class ClientNavigationMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<ClientNavigationMenuItem> MenuItems { get; set; }
            
            public ClientNavigationMasterViewModel()
            {
                MenuItems = new ObservableCollection<ClientNavigationMenuItem>(new[]
                {
                    new ClientNavigationMenuItem {Title = "Reservations" , Icon = "list.png", TargetType = typeof(MainPage)},
                    new ClientNavigationMenuItem {Title = "Make reservation" , Icon = "plus-16.png", TargetType = typeof(MainPage)},
                    new ClientNavigationMenuItem {Title = "Profile" , Icon = "guest-16.png", TargetType = typeof(MainPage)},
                    new ClientNavigationMenuItem {Title = "Logut" , Icon = "logout-16.png", TargetType = typeof(MainPage)},
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