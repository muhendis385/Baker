using Baker.WebUI.Dtos.Contact;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace Baker.WebUI.ViewComponents
{
    public class DefaultNavbarViewComponent : ViewComponent
    {
       
        public IViewComponentResult Invoke()
        {
            return View();
        }
        
    }
}
