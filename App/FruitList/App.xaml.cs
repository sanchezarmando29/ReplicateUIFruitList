using FruitList.Data.Fruits;
using FruitList.Framework.DataSources;
using FruitList.UI.Fruits.ViewModels;
using FruitList.UI.Fruits.Views;
using FruitList.UseCases.Fruits;
using Prism;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FruitList
{
    public partial class App
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/ListPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();

            containerRegistry.RegisterForNavigation<ListPage, ListViewModel>();

            containerRegistry.Register<FruitsRepository>();
            containerRegistry.Register<IFruitsSource, InMemoryFruitsSource>();
            containerRegistry.Register<GetCurrentUserFruits>();
        }
    }
}