using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChuckNorris
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                HttpClient client = new HttpClient();

                var response = await client.GetStringAsync("https://api.chucknorris.io/jokes/random");

                var items = JsonConvert.DeserializeObject<Items>(response);

                value.Text = items.value;
            }
            catch(Exception ex)
            {
                await DisplayAlert("ATTENTION", ex.ToString(), "OK");
            }
        }
    }
}
