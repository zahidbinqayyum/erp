using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp1.Utility
{
    public class Helper
    {
        public static string Dbpath = HttpContext.Current.Request.MapPath(@"\App_Data\ERP.mdf");

    }
}