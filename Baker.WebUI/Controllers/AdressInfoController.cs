using Baker.WebUI.Dtos.AdressInfo;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace Baker.WebUI.Controllers
{
    public class AdressInfoController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdressInfoController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> AdressInfoList()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7029/api/AdressInfo");

            if (response.IsSuccessStatusCode)
            {
                var jsondata = await response.Content.ReadAsStringAsync();

                var allValues = JsonConvert.DeserializeObject<List<ResultAdressInfoDto>>(jsondata);
                var singleValue = allValues.FirstOrDefault();

                return View(singleValue);
            }
            return View();
        }

        [HttpGet]
        public IActionResult CreateAdressInfo()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAdressInfo(CreateAdressInfoDto model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:7029/api/AdressInfo", content);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("AdressInfoList");
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateAdressInfo(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:7029/api/AdressInfo/" + id);
            var jsondata = await response.Content.ReadAsStringAsync();
            var value = JsonConvert.DeserializeObject<UpdateAdressInfoDto>(jsondata);
            return View(value);

        }

        [HttpPost]
        public async Task<IActionResult> UpdateAdressInfo(int id, UpdateAdressInfoDto model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var response = await client.PutAsync("https://localhost:7029/api/AdressInfo/", content);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("AdressInfoList");
            }

            return View();
        }

        public async Task<IActionResult> DeleteAdressInfo(int id)
        {
            var client = _httpClientFactory.CreateClient();

            await client.DeleteAsync($"https://localhost:7029/api/AdressInfo?id={id}");

            return RedirectToAction("AdressInfoList");
        }
    }
}
