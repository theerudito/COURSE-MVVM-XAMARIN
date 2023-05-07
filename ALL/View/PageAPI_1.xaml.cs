using ALL.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ALL.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageAPI_1 : ContentPage
    {
        public PageAPI_1()
        {
            InitializeComponent();
            BindingContext = new VMPageAPI_JPH();
        }
    }
}