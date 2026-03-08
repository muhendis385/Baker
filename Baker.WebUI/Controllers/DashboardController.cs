using Baker.WebUI.Dtos.Category;
using Baker.WebUI.Dtos.Chef;
using Baker.WebUI.Dtos.Product;
using Baker.WebUI.Dtos.Services;
using Baker.WebUI.Dtos.Subscribe;
using Baker.WebUI.Dtos.Testimonial;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace Baker.WebUI.Controllers
{
    public class DashboardController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public DashboardController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        public async Task<IActionResult> Dashboard()
        {
            var client = _httpClientFactory.CreateClient();

            
            var responseChef = await client.GetAsync("https://localhost:7029/api/Chef");
            if (responseChef.IsSuccessStatusCode)
            {
                var data = await responseChef.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultChefDto>>(data);
                ViewBag.ChefCount = values.Count;
            }
            ////////////////////////////////////////////////////////////


            
            var responseCat = await client.GetAsync("https://localhost:7029/api/Category");
            if (responseCat.IsSuccessStatusCode)
            {
                var data = await responseCat.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(data);
                ViewBag.CategoryCount = values.Count;
            }
            ////////////////////////////////////////////////////////////

            var responseProduct = await client.GetAsync("https://localhost:7029/api/Product/CountProduct"); 
            if (responseProduct.IsSuccessStatusCode)
            {
                var jsonData = await responseProduct.Content.ReadAsStringAsync();
  
                ViewBag.ProductCount = int.Parse(jsonData);
            }
            else
            {
                ViewBag.ProductCount = "!";
            }

            ////////////////////////////////////////////////////////////

            var responseService = await client.GetAsync("https://localhost:7029/api/Service");
            if (responseService.IsSuccessStatusCode)
            {
                var data = await responseService.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultServicesDto>>(data);
                ViewBag.ServiceCount = values.Count;
            }

            ////////////////////////////////////////////////////////////

            var responseTestimonial = await client.GetAsync("https://localhost:7029/api/Testimonial");
            if (responseTestimonial.IsSuccessStatusCode)
            {
                var data = await responseTestimonial.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultTestimonialDto>>(data);
                ViewBag.TestimonialCount = values.Count;
            }

            ////////////////////////////////////////////////////////////
            ///
            var responseSubscribe = await client.GetAsync("https://localhost:7029/api/Subscribe");
            if (responseSubscribe.IsSuccessStatusCode)
            {
                var data = await responseSubscribe.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSubscribeDto>>(data);
                ViewBag.SubscribeCount = values.Count;
            }

            return View();
        }
    }
}
