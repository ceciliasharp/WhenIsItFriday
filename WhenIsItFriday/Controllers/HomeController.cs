using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using WhenIsItFriday.Localization;


namespace WhenIsItFriday.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.FridayToday =
                DateTime.Now.DayOfWeek == DayOfWeek.Friday ?
                Resource.Yes : Resource.No;

            ViewBag.FridayTomorrow =
                DateTime.Now.AddDays(1).DayOfWeek == DayOfWeek.Friday ?
                Resource.Yes : Resource.No;

            ViewBag.FridayAnyDay = Resource.Yes;

            return View();
        }
    }
}