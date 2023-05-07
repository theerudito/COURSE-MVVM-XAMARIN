using ALL.Model;
using MvvmGuia.VistaModelo;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ALL.ViewModel
{
    public class VMPageAPI_JPH : BaseViewModel
    {
        public VMPageAPI_JPH()
        {
            LlamarApiAsync();
        }

        private ObservableCollection<JPH_Model> _List_Data;

        public ObservableCollection<JPH_Model> List_Data
        {
            get { return _List_Data; }
            set { _List_Data = value; OnPropertyChanged(); }
        }

        public async Task LlamarApiAsync()
        {
            var client = new HttpClient();

            var response = await client.GetAsync("https://jsonplaceholder.typicode.com/users");

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();

                var json = Newtonsoft.Json.JsonConvert.DeserializeObject<List<JPH_Model>>(content);

                List_Data = new ObservableCollection<JPH_Model>(json);
            }
        }
    }
}