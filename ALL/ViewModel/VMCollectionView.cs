using ALL.Model;
using MvvmGuia.VistaModelo;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ALL.ViewModel
{
    public class VMCollectionView : BaseViewModel
    {

        #region VARIABLES
        public List<Naruto> listCharacters { get; set; }
        #endregion

        #region CONSTRUCTOR
        public VMCollectionView(INavigation navigation)
        {
            Navigation = navigation;
            GET_Characters();
        }
        #endregion



        #region OBJETOS
        #endregion



        #region METODOS ASYNC
        public async Task Select_Character(Naruto _naruto)
        {
            await DisplayAlert("Infor", _naruto.Name, "OK");
        }
        #endregion



        #region METODOS SIMPLE
        public void GET_Characters()
        {
            listCharacters = new List<Naruto>
            {
                new Naruto { Id = 1,  Name = "Naruto", Age = 12 , Clan = "Uzumaki", Image = "https://i.pinimg.com/236x/33/ae/6d/33ae6d8cf36e1c309394638bf08d7fe3.jpg" },
                new Naruto { Id = 2,  Name = "Sakura", Age = 12 , Clan = "Haruno", Image = "https://i.pinimg.com/564x/72/f2/3f/72f23f72bdb02f7aa37d9906b34fdf66.jpg" },
                new Naruto { Id = 3,  Name = "Sasuke", Age = 12 , Clan = "Uchiha", Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSdWbOLG-D3OOKSYKFZHtfqVfEwh1uLNR2W2xqnSezV88trxFTS_dx6XJ3mLbMF8mz8RKM&usqp=CAU" },
            };
        }
        #endregion




        #region COMANDOS
        public ICommand btnSelectCharacterCommand => new Command<Naruto>(async (character) => await Select_Character(character));
        #endregion
    }
}

