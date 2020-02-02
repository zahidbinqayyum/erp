using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApp1.Models;
using WebApp1.Utility;
using System.Web.Razor;
using System.Web.Mvc;

namespace WebApp1.Controllers
{
    public class ApiLoginController : ApiController
    {
        public IHttpActionResult UserLogin(BusinessPartner user)
        {
            string Conn = @"Data Source=(localdb)\MSSQLLocalDB; AttachDbFilename=" + Helper.Dbpath + @";Integrated Security=True;Connect Timeout=30;";

            DataContext db = new DataContext();
            var List = db.BusinessPartners.ToList();
            var IsUserExists = List.Where(x => x.LoginName == user.LoginName).SingleOrDefault();
            if (IsUserExists != null)
            {
                System.Web.HttpContext.Current.Session["User"] = IsUserExists.LoginName;
                HttpContext.Current.Response.Redirect("Home/Index");
                //System.Uri uri = new System.Uri(url);
                //return Redirect(uri);

                return Ok();
            }
            else
                HttpContext.Current.Response.Redirect("Home/Index");
                return NotFound();

        }
    }
}
