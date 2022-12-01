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
        private Company company;
        private Country country;
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

        public Company Company
        {
            get { return company; }
            set { company = value; } //Not private because company can change
        }

        public Country Country
        {
            get { return country; }
            set { country = value; } //Not private because country can change
        }

        public Aircraft(int id, AircraftModel aircraftModel, Company company, Country country)
        {
            this.id = id;
            this.aircraftModel = aircraftModel;
            this.company = company;
            this.country = country;
        }
    }
}
