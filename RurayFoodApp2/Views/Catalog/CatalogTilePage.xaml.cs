using RurayFoodApp2.DataService;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace RurayFoodApp2.Views.Catalog
{
    /// <summary>
    /// Page to show Catalog tile.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CatalogTilePage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogTilePage" /> class.
        /// </summary>
        public CatalogTilePage()
        {
            InitializeComponent();
            this.BindingContext = CatalogDataService.Instance.CatalogPageViewModel;
        }
    }
}