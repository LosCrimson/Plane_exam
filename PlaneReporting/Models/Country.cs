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

        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }

        public Country(string countryName)
        {
            this.countryName = countryName;
        }
    }
}
