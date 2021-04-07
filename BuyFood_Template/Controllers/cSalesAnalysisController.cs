using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adminCode.Controllers
{
    public class cSalesAnalysisController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
