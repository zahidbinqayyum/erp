using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstDb.Models
{
    public static class Config
    {
        public static string Path { get; set; }
        public static string Conn { get; set; }
        //var path = Server.MapPath(@"\App_Data\ERP.mdf");
    }
}