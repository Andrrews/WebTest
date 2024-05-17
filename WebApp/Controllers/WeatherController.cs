using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


using WebApp.Models;

namespace WebApp.Controllers
{
    public class WeatherController : Controller
    {
        // GET: WeatherController
        public async Task<ActionResult> Index()
        {
            string baseUrl = "http://localhost:5018";
            Uri uri = new Uri(baseUrl);
            HttpClient client = new HttpClient();
            client.BaseAddress = uri;

            var response = await client.GetFromJsonAsync<List<WeatherModel>>("WeatherForecast");

            //var result = await response.Content.ReadAsStringAsync();

           // var obj = JsonSerializer.Deserialize<List<WeatherModel>>(result);

            return View(response);
        }

       
    }
}
