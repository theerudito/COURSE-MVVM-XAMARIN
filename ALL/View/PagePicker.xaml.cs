using ALL.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ALL.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePicker : ContentPage
    {
        public PagePicker()
        {
            InitializeComponent();
            BindingContext = new VMPagePicker(Navigation);
        }
    }
}