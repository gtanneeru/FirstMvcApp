using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMvcApp.Models;

namespace FirstMvcApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour<12?"Good Morning":"Good Afternoon";
            return View();
        }
        public ViewResult Gayu()
        { 
            ViewBag.message = "This is an Example";
            return View();
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestresponse)
        {
            return View("Thanks", guestresponse);
        }
    }
}