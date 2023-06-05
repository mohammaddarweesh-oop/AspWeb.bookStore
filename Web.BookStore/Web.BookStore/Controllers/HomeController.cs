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
        //[HttpGet("Index")]
        public ViewResult Index()
        {
            //return View("~/TempView/Temp.cshtml");
            return View("../../TempView/Temp");
        }

        //[HttpPost("Index")]
        //public ViewResult Index2()
        //{
        //    return View();
        //}

        public ViewResult AboutUS()
        {
            return View();
        }
        
        public ViewResult Contact()
        {
            return View();
        }
    }
}
