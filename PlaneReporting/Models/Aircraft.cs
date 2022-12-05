using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneReporting.Models
{
    public class Aircraft
    {

        private int id;
        private AircraftModel aircraftModel;
        private Country countryWherePlaneRegistered;
        public int Id 
        {
            get { return id; }
            set { id = value; }
        }

        public AircraftModel AircraftModel
        {
            get { return aircraftModel; }
            private set { }
        }
        public Country Country
        {
            get { return countryWherePlaneRegistered; }
            set { countryWherePlaneRegistered = value; } //Not private because country can change
        }

        public Aircraft(int id, AircraftModel aircraftModel, Country countryWherePlaneRegistered)
        {
            this.id = id;
            this.aircraftModel = aircraftModel;
            this.countryWherePlaneRegistered = countryWherePlaneRegistered;
        }
    }
}
