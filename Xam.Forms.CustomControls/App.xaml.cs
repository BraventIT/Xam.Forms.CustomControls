using Xam.Forms.CustomControls.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Xam.Forms.CustomControls
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainView());
            (Current.MainPage as NavigationPage).BarBackgroundColor = Color.FromHex("#CED345");
            (Current.MainPage as NavigationPage).BarTextColor = Color.White;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
