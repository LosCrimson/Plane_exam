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
            new Company(1, "Lockheed Martin", CountryRepository.countries.Find(x => x.Id == 1)),
            new Company(2, "Airbus", CountryRepository.countries.Find(x => x.Id == 2)),
            new Company(3, "Boeing", CountryRepository.countries.Find(x => x.Id == 3)),
            new Company(4, "Raytheon Technologies", CountryRepository.countries.Find(x => x.Id == 4)),
            new Company(5, "Northrop Grumman", CountryRepository.countries.Find(x => x.Id == 5)),
            new Company(6, "General Electric", CountryRepository.countries.Find(x => x.Id == 6)),
            new Company(7, "Safran", CountryRepository.countries.Find(x => x.Id == 7)),
            new Company(8, "Leonardo", CountryRepository.countries.Find(x => x.Id == 8)),
            new Company(9, "Bombardier", CountryRepository.countries.Find(x => x.Id == 4)),
            new Company(10, "United Aircraft Corporation", CountryRepository.countries.Find(x => x.Id == 2)),
        };
    }
}
