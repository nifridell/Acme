using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Acme.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id)
        {
            return Content("In homecontroller/index" + id);
        }
    }
}