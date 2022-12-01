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
        {new AircraftModel("XB-29E"),
        new AircraftModel("EB-29"),
        new AircraftModel("XB-39 Superfortress"),
        new AircraftModel("Tupolev Tu-4"),
        new AircraftModel("KB-29 Tanker Development"),
        new AircraftModel("B-29C"),
        new AircraftModel("XB-29"),};
    }
}
