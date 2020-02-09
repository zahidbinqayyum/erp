using CodeFirstDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDb
{
    public class BusinessPartnerRepo
    {
        DataContext db;
        public BusinessPartnerRepo()
        {
            db = new DataContext();
        }
        public List<BusinessPartner> GetAllBusinessartner()
        {
            List <BusinessPartner> list = db.BusinessPartners.ToList();
            return list;
        }
    }
}
