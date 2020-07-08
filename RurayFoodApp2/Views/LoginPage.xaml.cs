using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RurayFoodApp2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private async void Button_Login(object sender, EventArgs e)
        {

            var newPage = new Catalog.EventListPage();
            await Navigation.PushAsync(newPage);

        }
    }
}