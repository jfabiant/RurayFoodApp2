using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace RurayFoodApp2.Views.Transaction
{
    /// <summary>
    /// Page to show the payment success.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaymentSuccessPage : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSuccessPage" /> class.
        /// </summary>
        public PaymentSuccessPage()
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