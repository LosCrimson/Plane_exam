using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaneReporting.Models;

namespace PlaneReporting
{
    public static class CompanyRepository
    {
        public static List<Company> companies= new List<Company>
        {
            new Company("Lockheed Martin"),
            new Company("Airbus"),
            new Company("Boeing"),
            new Company("Raytheon Technologies"),
            new Company("Northrop Grumman"),
            new Company("General Electric"),
            new Company("Safran"),
            new Company("Leonardo"),
            new Company("Bombardier"),
            new Company("United Aircraft Corporation"),
        };
    }
}
