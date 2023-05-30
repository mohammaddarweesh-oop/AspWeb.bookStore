using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.BookStore.Controllers
{
    //                          : = inheretance
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
