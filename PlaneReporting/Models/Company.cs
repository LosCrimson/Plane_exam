using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneReporting.Models
{
    public class Company
    {
        private string companyName;
        private int id;
        private Country countryId;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public int Id
        {
            get { return id; }
            private set { }
        }

        public Country CountryId
        {
            get { return countryId; }
            private set { countryId = value; }
        }

        public Company(int id, string companyName, Country countryId)
        {
            this.companyName = companyName;
            this.id = id;
            this.countryId = countryId;
        }
    }
}
