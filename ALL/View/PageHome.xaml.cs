using ALL.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ALL.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageHome : ContentPage
    {
        public PageHome()
        {
            InitializeComponent();
            BindingContext = new VMPageHome(Navigation);
        }
    }
}