using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaneReporting.Models;

namespace PlaneReporting
{
    public static class CountryRepository
    {
        public static List<Country> countries = new List<Country>
        {new Country("Spain", true),
        new Country("Thailand", false),
        new Country("Sweden", true),
        new Country("Norway", true),
        new Country("USA", false),
        new Country("Japan", false),
        new Country("russia", false),
        new Country("Ukraine", true),};
    }
}
