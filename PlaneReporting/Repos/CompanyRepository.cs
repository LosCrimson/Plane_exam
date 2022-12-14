using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaneReporting.Models;

namespace PlaneReporting
{
    public class CompanyRepository
    {
        public static List<Company> companies= new List<Company>
        {
            new Company(1, "Lockheed Martin", 1),
            new Company(2, "Airbus", 2),
            new Company(3, "Boeing", 3),
            new Company(4, "Raytheon Technologies", 4),
            new Company(5, "Northrop Grumman", 5),
            new Company(6, "General Electric", 6),
            new Company(7, "Safran", 7),
            new Company(8, "Leonardo", 8),
            new Company(9, "Bombardier", 4),
            new Company(10, "United Aircraft Corporation", 2),
        };

        public List<Company> Retrieve() { return companies; }

        public Company Retrieve(int id) { return companies[id]; }
    }
}
