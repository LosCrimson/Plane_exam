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
            new Aircraft(418, AircraftModelRepository.aircraftModels.Find(x => x.Id == 1), CountryRepository.countries.Find(x => x.Id == 8)),
            new Aircraft(198, AircraftModelRepository.aircraftModels.Find(x => x.Id == 2), CountryRepository.countries.Find(x => x.Id == 7)),
            new Aircraft(978, AircraftModelRepository.aircraftModels.Find(x => x.Id == 3), CountryRepository.countries.Find(x => x.Id == 6)),
            new Aircraft(358, AircraftModelRepository.aircraftModels.Find(x => x.Id == 4), CountryRepository.countries.Find(x => x.Id == 5)),
            new Aircraft(489, AircraftModelRepository.aircraftModels.Find(x => x.Id == 5), CountryRepository.countries.Find(x => x.Id == 4)),
            new Aircraft(358, AircraftModelRepository.aircraftModels.Find(x => x.Id == 6), CountryRepository.countries.Find(x => x.Id == 3)),
            new Aircraft(756, AircraftModelRepository.aircraftModels.Find(x => x.Id == 7), CountryRepository.countries.Find(x => x.Id == 2)),
            new Aircraft(268, AircraftModelRepository.aircraftModels.Find(x => x.Id == 2), CountryRepository.countries.Find(x => x.Id == 1)),
            new Aircraft(002, AircraftModelRepository.aircraftModels.Find(x => x.Id == 4), CountryRepository.countries.Find(x => x.Id == 8)),
        };
    }
}
