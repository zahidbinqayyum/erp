
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DbFirst;
namespace MVCWithSubmit.Controllers
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
        public ActionResult AjaxLogin()
        {
            if (Session["User"] != null)
                return RedirectToAction("Index", "Home");
            else
                return View();
        }
        [HttpPost]
        public ActionResult UserLogin(BusinessPartner user)
        {
            //BusinessPartnerRepo repo = new BusinessPartnerRepo();
            //var List = repo.GetAllBusinessartner();

            Entities db = new Entities();
            var List = db.BusinessPartners.ToList();
            var IsUserExists = List.Where(x => x.LoginName == user.LoginName && x.Password == user.Password).SingleOrDefault();
            if (IsUserExists != null)
            {
                Session["User"] = IsUserExists.LoginName;
                return RedirectToAction("Index", "Home");
            }
            else
                return RedirectToAction("UserLogin", "Login");
        }
        //[HttpPost]
        //public string UserLoginAjax(BusinessPartner user)
        //{
        //    try
        //    {
        //        DataContext db = new DataContext();
        //        var List = db.BusinessPartners.ToList();
        //        var IsUserExists = List.Where(x => x.LoginName == user.LoginName && x.Password == user.Password).SingleOrDefault();
        //    if (IsUserExists != null)
        //    {
        //        Session["User"] = IsUserExists.LoginName;
        //        return "/Home/Index";
        //    }
        //    else
        //        return "/Login/AjaxLogin";
        //    }
        //    catch (Exception ex)
        //    {
        //        return "/Error.cshtml";
        //    }

        //}
        public ActionResult LogOut()
        {
            Session.Abandon();
            Session.Clear();
            return RedirectToAction("UserLogin", "Login");
        }

    }
}