using ALL.Data;
using ALL.Model;
using MvvmGuia.VistaModelo;
using Supabase;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ALL.ViewModel
{
    public class VMPageSupabase : BaseViewModel
    {
        public VMPageSupabase(INavigation navigation)
        {
            Navigation = navigation;

            Task.Run(async () => await Get());
        }

        public async Task Add()
        {
        }

        public async Task Get()
        {
            var options = new SupabaseOptions
            {
                AutoConnectRealtime = true
            };

            var supabase = new Supabase.Client(SupabaseData.url, SupabaseData.key, options);

            await supabase.InitializeAsync();

            var result = await supabase.From<MSupabase>().Get();
            var data = result.Models;

            foreach (var city in data)
            {
                await DisplayAlert("Alert", city.Name, "OK");
            }
        }

        public ICommand btnAddRegister => new Command(async () => await Add());
    }
}