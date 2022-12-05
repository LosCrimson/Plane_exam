using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneReporting.Models
{
    public class Country
    {
        private string countryName;
        private bool isFromEurope;
        private int id;

        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }

        public bool IsFromEurope
        {
            get { return isFromEurope; }
            private set { }
        }

        public int Id
        {
            get { return id; }
            private set { }
        }

        public Country(int id, string countryName, bool isFromEurope)
        {
            this.countryName = countryName;
            this.isFromEurope = isFromEurope;
            this.id = id;
        }
    }
}
