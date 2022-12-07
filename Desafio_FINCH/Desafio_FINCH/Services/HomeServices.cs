using Desafio_FINCH.Models;
using System.Net.Http.Headers;

namespace Desafio_FINCH.Services
{
    public class HomeServices : IHomeServices
    {
        public HomeServices() { }

        public Bored GetBored() {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("http://www.boredapi.com/api/activity/").Result;
            return response.Content.ReadAsAsync<Bored>().Result;
        }
    }
}
