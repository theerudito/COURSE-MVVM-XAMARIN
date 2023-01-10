using ALL.View.Pokemon;
using MvvmGuia.VistaModelo;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ALL.ViewModel.VMPokemon
{
    public class VMCrudPokemon : BaseViewModel
    {

        #region VARIABLES

        #endregion

        #region CONSTRUCTOR
        public VMCrudPokemon(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJETOS

        #endregion

        #region METODOS ASYNC
        public async Task openAddPokemon()
        {
            await Navigation.PushAsync(new AddPokemon());
        }
        #endregion

        #region METODOS SIMPLE

        #endregion


        #region COMANDOS
        public ICommand btnGoADDPokemonCommand => new Command(async () => await openAddPokemon());
        #endregion
    }
}
