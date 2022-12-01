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
            new Aircraft(418),
            new Aircraft(198),
            new Aircraft(978),
            new Aircraft(358),
            new Aircraft(489),
            new Aircraft(358),
            new Aircraft(756),
            new Aircraft(268),
            new Aircraft(002),
        };
    }
}
