using MVCWithSubmit.Db;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWithSubmit.Controllers
{
    public class CountryController : Controller
    {
        ERPEntities db = new ERPEntities();
        public CountryController()
        {
        }
        // GET: Country
        public ActionResult CountryList()
        {
            var countryList = db.countries.ToList();
            return View(countryList);
        }
        public ActionResult AddCountry()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCountry(country country)
        {
            if (country.id > 0)
            {
                db.Entry(country).State = EntityState.Modified;
            }
            else
            {
                var newId = db.countries.Max(x => x.id + 1);
                country.id = newId;
                db.countries.Add(country);
            }
            db.SaveChanges();
            return RedirectToAction("CountryList");
        }

        public ActionResult Edit(int id)
        {
            var country = db.countries.Where(x => x.id == id).SingleOrDefault();
            return View("AddCountry", country);
        }

        public ActionResult Delete(int id)
        {
            var country = db.countries.Where(x => x.id == id).SingleOrDefault();
            db.countries.Remove(country);
            db.SaveChanges();
            return RedirectToAction("CountryList");
        }

    }
}