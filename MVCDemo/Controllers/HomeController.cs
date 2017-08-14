using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public string Index(string id, string name, string city, string )
        //public List<string> Index()
        public ActionResult Index()
        {
            List<string> listCountries = new List<string> { "Pakistan", "France", "UK" };
            //return listCountries;
            //This will return the type System.Collections.Generic.List`1[System.String] and will not print the countries.
            //For the list of countries to print properly we need to use views as view has the capability to print a complex data type.

            //return ("Hello from MVC Application. Good Night");
            //return ("showing Id value =" + id + "name ="+ name + "city =" + city + "country =" + country);
            ViewBag.Countries = listCountries;
            return View();
        }
        public string GetDetails()
        {
            return ("Get Details Invoked");
        }
    }
}