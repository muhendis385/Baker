using Microsoft.AspNetCore.Mvc;

namespace Baker.WebUI.ViewComponents
{
    public class DefaultStatisticViewComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultStatisticViewComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();

            var responseChef = await client.GetAsync("https://localhost:7029/api/Chef/CountChef");
            if (responseChef.IsSuccessStatusCode)
            {
                var jsonData = await responseChef.Content.ReadAsStringAsync();
                ViewBag.chefCount = jsonData; 
            }

            var responseProduct = await client.GetAsync("https://localhost:7029/api/Product/CountProduct");
            if (responseProduct.IsSuccessStatusCode)
            {
                ViewBag.productCount = await responseProduct.Content.ReadAsStringAsync();
            }

            var responseService = await client.GetAsync("https://localhost:7029/api/Service/CountService");
            if (responseService.IsSuccessStatusCode)
            {
                ViewBag.productService = await responseService.Content.ReadAsStringAsync();
            }

            return View();
        }
    }
}
