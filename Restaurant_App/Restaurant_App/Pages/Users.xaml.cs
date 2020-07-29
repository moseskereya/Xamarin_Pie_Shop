using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Restaurant_App.Pages
{

    public partial class Users : ContentPage
    {
        public class user
        {
            public int id { get; set; }
            public string name { get; set; }
            public string email { get; set; }
        }
        public Users()
        {
            InitializeComponent();
            LoadData();
        }
        public async void LoadData()
        {
            var content = "";
            HttpClient client = new HttpClient();
            var RestURL = "https://jsonplaceholder.typicode.com/comments";
            client.BaseAddress = new Uri(RestURL);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync(RestURL);
            content = await response.Content.ReadAsStringAsync();
            var Items = JsonConvert.DeserializeObject<List<user>>(content);
            ListView1.ItemsSource = Items;
        }
    }
}