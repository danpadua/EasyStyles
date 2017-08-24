using EasyStylesApp.Models;
using EasyStylesApp.Utils;
using Prism.Mvvm;
using Prism.Navigation;

namespace EasyStylesApp.ViewModels
{
    public class MenuPageViewModel : BindableBase, INavigatedAware
    {
        private RangeEnabledObservableCollections<MenuItem> _listMenuItems;
        public RangeEnabledObservableCollections<MenuItem> ListMenuItems 
        {
            get { return _listMenuItems; }
            set { SetProperty(ref _listMenuItems, value); }
        }

        private readonly INavigationService _navigationService;

        public MenuPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            ListMenuItems = new RangeEnabledObservableCollections<MenuItem>();
            for (var i = 1; i <= 15; i++)
            {
                var item = new MenuItem { Description = $"Opção {i}", Id = i };
                ListMenuItems.Add(item);
            }
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            throw new System.NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            throw new System.NotImplementedException();
        }
    }
}
