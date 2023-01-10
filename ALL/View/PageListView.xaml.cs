using ALL.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ALL.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListView : ContentPage
    {
        public PageListView()
        {
            InitializeComponent();
            BindingContext = new VMPageListView(Navigation);
        }
    }
}