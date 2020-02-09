using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DbFirst.Utility
{
    public class Helper
    {
        public static string Dbpath = HttpContext.Current.Server.MapPath(@"\ERP.mdf");

    }
}