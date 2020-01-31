using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApp1.Models
{
    public class DataContext : DbContext
    {
        static string path = "";

        /* con.ConnectionString = @"Data Source=.\SQLEXPRESS;
                           AttachDbFilename=c:\folder\SampleDatabase.mdf;
                           Integrated Security=True;
                           Connect Timeout=30;
                           User Instance=True";  
                           */
        //static string Conn = @"Data Source=(localdb)\MSSQLLocalDB; AttachDbFilename=C:\Users\Administrator\Desktop\New folder\trunk\WebApp1\App_Data\ERP.mdf;Integrated Security=True;Connect Timeout=30;";
        //static string Conn = @"Data Source=(localdb)\MSSQLLocalDB; AttachDbFilename=C:\Users\Administrator\Desktop\New folder\trunk\WebApp1\App_Data\ERP.mdf;Integrated Security=True;Connect Timeout=30;";
        //static string Conn = @"Data Source=(localdb)\MSSQLLocalDB; AttachDbFilename=" + path + @";Integrated Security=True;Connect Timeout=30;";

        public DataContext(string serverpath) : base(serverpath)
        {
        }

        public DbSet<BusinessPartner> BusinessPartners { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }

    }
}