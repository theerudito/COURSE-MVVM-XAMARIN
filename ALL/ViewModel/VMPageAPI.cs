using ALL.Model;
using MvvmGuia.VistaModelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ALL.ViewModel
{
    public class VMPageAPI : BaseViewModel
    {
        private ObservableCollection<API_Model> _List_data { get; set; }

        public ObservableCollection<API_Model> List_Data2
        {
            get { return _List_data; }
            set
            {
                _List_data = value;
                OnPropertyChanged();
            }
        }

        public async Task LlamarApiAsync()
        {
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri("https://reqres.in/api/users?page=2");
            request.Method = HttpMethod.Get;
            request.Headers.Add("Accept", "application/json");
            var client = new HttpClient();
            HttpResponseMessage response = await client.SendAsync(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                var json = Newtonsoft.Json.JsonConvert.DeserializeObject<List<API_Model>>(content);

                List_Data2 = new ObservableCollection<API_Model>(json);
            }
        }
    }
}