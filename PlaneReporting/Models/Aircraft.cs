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
        private int aircraftModel;
        private int countryWherePlaneRegistered;
        public int Id 
        {
            get { return id; }
            set { id = value; }
        }

        public int AircraftModel
        {
            get { return aircraftModel; }
            private set { }
        }
        public int Country
        {
            get { return countryWherePlaneRegistered; }
            set { countryWherePlaneRegistered = value; } //Not private because country can change
        }

        public Aircraft(int id, int aircraftModel, int countryWherePlaneRegistered)
        {
            this.id = id;
            this.aircraftModel = aircraftModel;
            this.countryWherePlaneRegistered = countryWherePlaneRegistered;
        }
    }
}
