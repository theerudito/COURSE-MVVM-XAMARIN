using ALL.View;
using MvvmGuia.VistaModelo;
using System.Windows.Input;
using Xamarin.Forms;

namespace ALL.ViewModel
{
    public class VMPageHome : BaseViewModel
    {
        public VMPageHome(INavigation navigation)
        {
            Navigation = navigation;
        }

        public ICommand btnGoAlertCommand => new Command(async () => await Navigation.PushAsync(new PageAlert()));
        public ICommand btnGoEntryCommand => new Command(async () => await Navigation.PushAsync(new EntryPage()));
        public ICommand btnGoCalculatorCommand => new Command(async () => await Navigation.PushAsync(new Calculadora()));
        public ICommand btnGoPickerCommand => new Command(async () => await Navigation.PushAsync(new PagePicker()));
        public ICommand btnGoDatePickerCommand => new Command(async () => await Navigation.PushAsync(new PageDatePicker()));
        public ICommand btnGoCollectionCommand => new Command(async () => await Navigation.PushAsync(new PageCollectionView()));
        public ICommand btnGoListViewCommand => new Command(async () => await Navigation.PushAsync(new PageListView()));
        public ICommand btnGoMenuCommand => new Command(async () => await Navigation.PushAsync(new PageMenu()));
        public ICommand btnGoAPI1Command => new Command(async () => await Navigation.PushAsync(new PageAPI_1()));
        public ICommand btnGoAPI2Command => new Command(async () => await Navigation.PushAsync(new PageAPI_2()));
        public ICommand btnGoSUpabaseCommand => new Command(async () => await Navigation.PushAsync(new PageSupabase()));
    }
}