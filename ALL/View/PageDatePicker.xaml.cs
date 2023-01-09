using ALL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ALL.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageDatePicker : ContentPage
    {
        public PageDatePicker()
        {
            InitializeComponent();
            BindingContext = new VMDatePicker(Navigation);
        }
    }
}