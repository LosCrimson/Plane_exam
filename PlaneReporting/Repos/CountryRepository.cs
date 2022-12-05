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
        {new Country(1, "Spain", true),
        new Country(2, "Thailand", false),
        new Country(3, "Sweden", true),
        new Country(4, "Norway", true),
        new Country(5, "USA", false),
        new Country(6, "Japan", false),
        new Country(7, "russia", false),
        new Country(8, "Ukraine", true),};
    }
}
