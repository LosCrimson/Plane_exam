using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaneReporting.Models;

namespace PlaneReporting
{
    public static class AircraftModelRepository
    {
        public static List<AircraftModel> aircraftModels = new List<AircraftModel> 
        {new AircraftModel(1, CompanyRepository.companies.Find(x => x.Id == 1), "XB-29E"),
        new AircraftModel(2, CompanyRepository.companies.Find(x => x.Id == 2), "EB-29"),
        new AircraftModel(3, CompanyRepository.companies.Find(x => x.Id == 3), "XB-39 Superfortress"),
        new AircraftModel(4, CompanyRepository.companies.Find(x => x.Id == 4), "Tupolev Tu-4"),
        new AircraftModel(5, CompanyRepository.companies.Find(x => x.Id == 5), "KB-29 Tanker Development"),
        new AircraftModel(6, CompanyRepository.companies.Find(x => x.Id == 6), "B-29C"),
        new AircraftModel(7, CompanyRepository.companies.Find(x => x.Id == 7), "XB-29"),};
    }
}
