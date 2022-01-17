using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebsite.Controllers
{
    public class RetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
