using DbFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWithSubmit.Controllers
{
    public class CountryController : Controller
    {
        Entities db = new Entities();
        public CountryController()
        {
        }
        // GET: Country
        public ActionResult CountryList()
        {
            var countryList = db.countries.ToList();
            return View(countryList);
        }
    }
}