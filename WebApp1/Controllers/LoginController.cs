using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp1.Models;

namespace WebApp1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult UserLogin()
        {
            if (Session["User"] != null)
                return RedirectToAction("Index", "Home");
            else
                return View();
        }

        [HttpPost]
        public ActionResult UserLogin(BusinessPartner user)
        {
            var serverpath = Server.MapPath(@"\App_Data\ERP.mdf");
            string Conn = @"Data Source=(localdb)\MSSQLLocalDB; AttachDbFilename=" + serverpath + @";Integrated Security=True;Connect Timeout=30;";

            DataContext db = new DataContext(Conn);
            var List = db.BusinessPartner.ToList();
            var IsUserExists = List.Where(x => x.LoginName == user.LoginName).SingleOrDefault();
            if (IsUserExists != null)
            {
                Session["User"] = IsUserExists.LoginName;
                return RedirectToAction("Index", "Home");
            }
            else
                return RedirectToAction("UserLogin", "Login");
        }


    }
}