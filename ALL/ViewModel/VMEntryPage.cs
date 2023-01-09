using MvvmGuia.VistaModelo;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ALL.ViewModel
{
    public class VMEntryPage : BaseViewModel
    {
        #region VARIABLES
        string _Mensaje;
        #endregion

        #region CONSTRUCTOR
        public VMEntryPage(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJETO
        public string Mensaje
        {
            get { return _Mensaje; }
            set { SetValue(ref _Mensaje, value); }
        }
        #endregion

        #region METODO
        public async Task MostrarMensaje()
        {
            await Application.Current.MainPage.DisplayAlert("Alerta", Mensaje, "Aceptar");
        }
        #endregion

        #region COMANDO
        public ICommand btnShowMensajeCommand => new Command(async () => await MostrarMensaje());
        #endregion
    }
}
