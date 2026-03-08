using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Baker.WebUI.Dtos.Chef; // DTO'larınızın olduğu namespace

namespace Baker.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}