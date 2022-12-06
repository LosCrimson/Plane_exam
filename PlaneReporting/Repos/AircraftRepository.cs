using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaneReporting.Models;

namespace PlaneReporting
{
    public class AircraftRepository
    {
        public static List<Aircraft> aircrafts = new List<Aircraft>
        {
            new Aircraft(418, 1, 8),
            new Aircraft(198, 2, 7),
            new Aircraft(978, 3, 6),
            new Aircraft(358, 4, 5),
            new Aircraft(489, 5, 4),
            new Aircraft(358, 6, 3),
            new Aircraft(756, 7, 2),
            new Aircraft(268, 2, 1),
            new Aircraft(002, 4, 8),
        };

        public List<Aircraft> Retrieve() { return aircrafts; }

        public Aircraft Retrieve(int id) { return aircrafts[id];}
    }
}
