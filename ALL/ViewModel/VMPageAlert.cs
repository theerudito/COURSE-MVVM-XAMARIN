using MvvmGuia.VistaModelo;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ALL.ViewModel
{
    public class VMPageAlert : BaseViewModel
    {
        #region VARIABLES
        string _Text;
        #endregion

        #region CONSTRUCTOR
        public VMPageAlert(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJETOS
        public string Text
        {
            get { return _Text; }
            set { SetValue(ref _Text, value); }
        }
        #endregion

        #region METODOS ASYNC
        public async Task MetodoAsincronoAlerta()
        {
            await Application.Current.MainPage.DisplayAlert("Alerta", "Mensaje de alerta Asincrona", "Aceptar");
        }
        #endregion

        #region METODOS SIMPLE
        public void MetodoSimpleAlerta()
        {
            Application.Current.MainPage.DisplayAlert("Alerta", "Mensaje de alerta Simple", "Aceptar");
        }
        #endregion


        #region COMANDOS
        public ICommand btnShowAlertCommand => new Command(async () => await MetodoAsincronoAlerta());
        public ICommand btnShowAlertCommandSimple => new Command(() => MetodoSimpleAlerta());
        #endregion

    }
}
