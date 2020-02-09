using CodeFirstDb.Models;
using CodeFirstDb.Utility;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDb
{
    public class DataContext : DbContext
    {
        static string Conn = @"Data Source=(localdb)\MSSQLLocalDB; AttachDbFilename=" + Helper.Dbpath + @";Integrated Security=True;Connect Timeout=30;";
        public DataContext() : base(Conn)
        {

        }
        public DbSet<BusinessPartner> BusinessPartners { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
