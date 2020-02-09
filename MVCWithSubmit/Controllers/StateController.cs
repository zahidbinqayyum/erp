using MVCWithSubmit.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWithSubmit.Controllers
{
    public class StateController : Controller
    {
        ERPEntities db;
        public StateController()
        {
            db = new ERPEntities();
        }
        // GET: State
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult StateList()
        {
            var stateList = db.states.ToList();
            return View(stateList);
        }
    }
}