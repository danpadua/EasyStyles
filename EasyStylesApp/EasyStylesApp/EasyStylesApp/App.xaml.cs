using Prism.Unity;
using EasyStylesApp.Views;
using Xamarin.Forms;

namespace EasyStylesApp
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("InicialPage/NavegacaoPage/MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<InicialPage>();
            Container.RegisterTypeForNavigation<NavegacaoPage>();
            Container.RegisterTypeForNavigation<ListViewPage>();
        }
    }
}
