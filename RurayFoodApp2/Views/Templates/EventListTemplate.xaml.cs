using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace RurayFoodApp2.Views.Templates
{
    /// <summary>
    /// Event list template.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventListTemplate : Grid
    {
        public EventListTemplate()
        {
            InitializeComponent();
        }

        private async void SfButton_Clicked(object sender, System.EventArgs e)
        {
            var newPage = new Transaction.CheckoutPage();
            await Navigation.PushAsync(newPage);
        }
    }
}