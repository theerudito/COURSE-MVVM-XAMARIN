using ALL.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ALL.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageCollectionView : ContentPage
    {
        public PageCollectionView()
        {
            InitializeComponent();
            BindingContext = new VMCollectionView(Navigation);
        }
    }
}