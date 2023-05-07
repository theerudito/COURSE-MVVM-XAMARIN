using ALL.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ALL.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageAPI_2 : ContentPage
    {
        public PageAPI_2()
        {
            InitializeComponent();
            BindingContext = new VMPageAPI();
        }
    }
}