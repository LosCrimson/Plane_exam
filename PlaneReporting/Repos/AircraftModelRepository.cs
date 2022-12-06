using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaneReporting.Models;

namespace PlaneReporting
{
    public class AircraftModelRepository
    {
        public static List<AircraftModel> aircraftModels = new List<AircraftModel>
        {
        new AircraftModel(1, 1, "XB-29E"),
        new AircraftModel(2, 2, "EB-29"),
        new AircraftModel(3, 3, "XB-39 Superfortress"),
        new AircraftModel(4, 4, "Tupolev Tu-4"),
        new AircraftModel(5, 5, "KB-29 Tanker Development"),
        new AircraftModel(6, 6, "B-29C"),
        new AircraftModel(7, 7, "XB-29"),
        };
        public List<AircraftModel> Retrieve() { return aircraftModels; }

        public AircraftModel Retrieve(int id) { return aircraftModels[id];}
    }
}
