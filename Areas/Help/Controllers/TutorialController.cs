using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebSiteApp2.Areas.Help.Controllers
{
    [Area("Help")]
    public class TutorialController : Controller
    {
        [Route("/[area]/[controller]/[action]/Page{id}")]
        public IActionResult Index(int id)
        {
            if (id == 2)
            {
                return View("Page2");
            }
            else if (id == 3)
            {
                return View("Page3");
            }
            else 
            {
                return View("Page1");
            }
        }
    }
}
