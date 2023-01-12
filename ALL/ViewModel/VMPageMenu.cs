using ALL.Model;
using ALL.View;
using MvvmGuia.VistaModelo;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ALL.ViewModel
{
    public class VMPageMenu : BaseViewModel
    {
        #region VARIABLES
        public List<MMenu> PageMenu { get; set; }
        #endregion



        #region    CONSTRUCTOR
        public VMPageMenu(INavigation navigation)
        {
            Navigation = navigation;
            MostrarMenu();
        }
        #endregion



        #region    METODOS
        public void MostrarMenu()
        {
            PageMenu = new List<MMenu>
            {
                new MMenu { Id= 1, Pages = "Entry Page", Icon = "https://i.postimg.cc/1tNnMmMN/web.png" },
                new MMenu { Id= 2, Pages = "Calculator Page", Icon = "https://i.postimg.cc/1tNnMmMN/web.png" },
                new MMenu { Id= 3, Pages = "Alert Page", Icon = "https://i.postimg.cc/1tNnMmMN/web.png" },
                new MMenu { Id= 4, Pages = "Picker Page", Icon = "https://i.postimg.cc/1tNnMmMN/web.png" },
                new MMenu { Id= 5, Pages = "PickerDate Page", Icon = "https://i.postimg.cc/1tNnMmMN/web.png" },
                new MMenu { Id= 6, Pages = "CollectionView Page", Icon = "https://i.postimg.cc/1tNnMmMN/web.png" },
                new MMenu { Id= 7, Pages = "ListView Page", Icon = "https://i.postimg.cc/1tNnMmMN/web.png" },
            };
        }

        public async Task NavigationPage(MMenu parametros)
        {
            string page = parametros.Pages;

            if (page.Contains("Entry Page"))
            {
                await Navigation.PushAsync(new EntryPage());
            }
            if (page.Contains("Calculator Page"))
            {
                await Navigation.PushAsync(new Calculadora());
            }
            if (page.Contains("Alert Page"))
            {
                await Navigation.PushAsync(new PageAlert());
            }
            if (page.Contains("Picker Page"))
            {
                await Navigation.PushAsync(new PagePicker());
            }
            if (page.Contains("PickerDate Page"))
            {
                await Navigation.PushAsync(new PageDatePicker());
            }
            if (page.Contains("CollectionView Page"))
            {
                await Navigation.PushAsync(new PageCollectionView());
            }
            if (page.Contains("ListView Page"))
            {
                await Navigation.PushAsync(new PageListView());
            }


        }
        #endregion


        #region    COMANDOS
        public ICommand NavegationCommando => new Command<MMenu>(async (parametros) => await NavigationPage(parametros));
        #endregion






    }
}
