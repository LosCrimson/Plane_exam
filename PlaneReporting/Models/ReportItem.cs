using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneReporting.Models
{
    public class ReportItem
    {
        private AircraftRepository aircrafts;
        private AircraftModelRepository aircraftModels;
        private CompanyRepository companies;
        private CountryRepository countries;

        public AircraftRepository Aircrafts
        {
            get { return aircrafts; }
            set { aircrafts = value; }
        }

        public AircraftModelRepository AircraftModels
        {
            get { return aircraftModels; }
            set { aircraftModels = value; }
        }

        public CompanyRepository Companies
        {
            get { return companies; }
            set { companies = value; }
        }
        public CountryRepository Countries
        {
            get { return countries; }
            set { countries = value; }
        }



        public ReportItem(AircraftRepository aircrafts, AircraftModelRepository aircraftModels, CompanyRepository companies, CountryRepository countries)
        {
            this.countries = countries;
            this.aircrafts = aircrafts;
            this.aircraftModels = aircraftModels;
            this.companies = companies;
        }

    }
}
