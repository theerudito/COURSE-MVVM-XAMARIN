using ALL.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ALL.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageAlert : ContentPage
    {
        public PageAlert()
        {
            InitializeComponent();
            BindingContext = new VMPageAlert(Navigation);
        }
    }
}