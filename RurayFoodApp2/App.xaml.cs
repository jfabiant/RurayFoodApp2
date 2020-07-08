using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RurayFoodApp2
{
    public partial class App : Application
    {
        public static string BaseImageUrl { get; } = "https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/";
        public App()
        {
            InitializeComponent();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mjc5MDQ5QDMxMzgyZTMxMmUzMFFQaUNxRTF2bTRRNFZCTVJBbmVQT0t5cEJtK0tqZnU1RzAxakQ3VXY4Zjg9");

            //MainPage = new Views.Transaction.CheckoutPage();
            MainPage = new NavigationPage(new Views.LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
