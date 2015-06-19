using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dota2Nube.Data;

namespace Dota2Nube.Data.Providers.Countries
{
    class CountryProvider
    {
        public List<Country> getAll()
        {
            Data.Dota2NubeConn1 db = new Dota2NubeConn1();
            List<Country> lstCountry = null;
            using (db)
            {
                lstCountry = db.Country.ToList();
            }
            return lstCountry;
        }
        public Country Save(Country objCountry)
        {
            Data.Dota2NubeConn1 db = new Dota2NubeConn1();
            Country updCountry = null;
            using (db)
            {
                if (objCountry.CountryId == 0)
                {
                    objCountry = db.Country.Add(objCountry);
                }
                else
                {
                    updCountry = db.Country.Where(x => x.CountryId == objCountry.CountryId).FirstOrDefault();
                    updCountry.CountryName = objCountry.CountryName;
                    updCountry.Users = objCountry.Users;
                }
                db.SaveChanges();
            }
            return objCountry;
        }
    }
}
