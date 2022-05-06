using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
namespace MyWebSiteApp2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            var contacts = new List<string>
            
                {"555-555-5555",
                "me@mywebsite.com",
                "facebook.com/mywebsite"};
            return View(contacts);
        }
    }
}
