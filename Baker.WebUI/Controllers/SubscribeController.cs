using Baker.WebUI.Dtos.Services;
using Baker.WebUI.Dtos.Subscribe;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace Baker.WebUI.Controllers
{
    public class SubscribeController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public SubscribeController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> SubscribeList()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7029/api/Subscribe");

            if (response.IsSuccessStatusCode)
            {
                var jsondata = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSubscribeDto>>(jsondata);

                return View(values);
            }
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> Subscribe(string Mail) 
        {
            if (string.IsNullOrEmpty(Mail))
            {
                return Json(new { success = false, message = "E-posta boş olamaz." });
            }

            var client = _httpClientFactory.CreateClient();

            var newSubscriber = new { Mail = Mail };

            var jsonData = JsonConvert.SerializeObject(newSubscriber);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("https://localhost:7029/api/Subscribe", content);

            if (response.IsSuccessStatusCode)
            {
                return Json(new { success = true });
            }

            return Json(new { success = false });
        }

        [HttpGet]
        public async Task<IActionResult> UpdateSubscribe(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7029/api/Subscribe/" + id);
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<UpdateSubscribeDto>(jsonData);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateSubscribe(int id, UpdateSubscribeDto model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var response = await client.PutAsync("https://localhost:7029/api/Subscribe/", content);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("SubscribeList");
            }

            return View();
        }

        public async Task<IActionResult> DeleteSubscribe(int id)
        {
            var client = _httpClientFactory.CreateClient();

            await client.DeleteAsync($"https://localhost:7029/api/Subscribe?id={id}");

            return RedirectToAction("SubscribeList");
        }
    }
}
