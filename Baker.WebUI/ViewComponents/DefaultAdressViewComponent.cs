using Baker.WebUI.Dtos.AdressInfo;
using Baker.WebUI.Dtos.Contact;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Baker.WebUI.ViewComponents
{
    public class DefaultAdressViewComponent : ViewComponent
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultAdressViewComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7029/api/Contact");

            if (response.IsSuccessStatusCode)
            {
                var jsondata = await response.Content.ReadAsStringAsync();

                var allContacts = JsonConvert.DeserializeObject<List<ResultAdressInfoDto>>(jsondata);

                var singleContact = allContacts.FirstOrDefault();

                return View(singleContact);
            }
            return View();
        }
    }
}
