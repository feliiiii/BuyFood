using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adminCode.Controllers
{
    public class Product_StatisticsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
