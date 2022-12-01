using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaneReporting.Models;

namespace PlaneReporting
{
    public static class AircraftRepository
    {
        public static List<Aircraft> aircrafts = new List<Aircraft>
        {
            new Aircraft(418, AircraftModelRepository.aircraftModels.ElementAt(5), CompanyRepository.companies.ElementAt(0), CountryRepository.countries.ElementAt(0)),
            new Aircraft(198, AircraftModelRepository.aircraftModels.ElementAt(3), CompanyRepository.companies.ElementAt(9), CountryRepository.countries.ElementAt(1)),
            new Aircraft(978, AircraftModelRepository.aircraftModels.ElementAt(2), CompanyRepository.companies.ElementAt(5), CountryRepository.countries.ElementAt(2)),
            new Aircraft(358, AircraftModelRepository.aircraftModels.ElementAt(1), CompanyRepository.companies.ElementAt(4), CountryRepository.countries.ElementAt(3)),
            new Aircraft(489, AircraftModelRepository.aircraftModels.ElementAt(4), CompanyRepository.companies.ElementAt(1), CountryRepository.countries.ElementAt(4)),
            new Aircraft(358, AircraftModelRepository.aircraftModels.ElementAt(0), CompanyRepository.companies.ElementAt(8), CountryRepository.countries.ElementAt(5)),
            new Aircraft(756, AircraftModelRepository.aircraftModels.ElementAt(6), CompanyRepository.companies.ElementAt(2), CountryRepository.countries.ElementAt(6)),
            new Aircraft(268, AircraftModelRepository.aircraftModels.ElementAt(2), CompanyRepository.companies.ElementAt(6), CountryRepository.countries.ElementAt(2)),
            new Aircraft(002, AircraftModelRepository.aircraftModels.ElementAt(5), CompanyRepository.companies.ElementAt(3), CountryRepository.countries.ElementAt(7)),
        };
    }
}
