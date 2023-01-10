using MvvmGuia.VistaModelo;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ALL.ViewModel.VMPokemon
{
    public class VMAddPokemon : BaseViewModel
    {

        #region VARIABLES
        string _TextNombre;
        string _TextColorFondo;
        string _TextNumPokemon;
        string _TextIcono;
        string _TextPower;
        string _TextColorPoder;



        #endregion

        #region CONSTRUCTOR
        public VMAddPokemon(INavigation navigation)
        {
            Navigation = navigation;
        }

        #endregion

        #region OBJETOS
        public string TextNombre
        {
            get { return _TextNombre; }
            set { SetValue(ref _TextNombre, value); }
        }
        public string TextColorFondo
        {
            get { return _TextColorFondo; }
            set { SetValue(ref _TextColorFondo, value); }
        }
        public string TextNumPokemon
        {
            get { return _TextNumPokemon; }
            set { SetValue(ref _TextNumPokemon, value); }
        }
        public string TextIcono
        {
            get { return _TextIcono; }
            set { SetValue(ref _TextIcono, value); }
        }
        public string TextPower
        {
            get { return _TextPower; }
            set { SetValue(ref _TextPower, value); }
        }

        public string TextColorPoder
        {
            get { return _TextColorPoder; }
            set { SetValue(ref _TextColorPoder, value); }
        }



        #endregion

        #region METODOS ASYNC
        public async Task MetodoAsincrono()
        {
            await Task.Delay(1000);

        }
        #endregion

        #region METODOS SIMPLE
        public void MetodoSimple()
        {

        }
        #endregion


        #region COMANDOS
        public ICommand AlertaAsincrona => new Command(async () => await MetodoAsincrono());
        public ICommand AlertaSimple => new Command(() => MetodoSimple());
        #endregion
    }
}
