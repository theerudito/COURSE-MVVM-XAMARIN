using ALL.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ALL.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageSupabase : ContentPage
    {
        public PageSupabase()
        {
            InitializeComponent();

            BindingContext = new VMPageSupabase(Navigation);
        }
    }
}