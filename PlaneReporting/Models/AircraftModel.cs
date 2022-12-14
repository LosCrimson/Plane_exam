using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneReporting.Models
{
    public class AircraftModel
    {

        private string model;
        private int id;
        private int companyData;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Id
        {
            get { return id; }
            private set { }
        }

        public int CompanyData
        {
            get { return companyData; }
            set { companyData = value; }
        }

        public AircraftModel(int id, int companyData, string model)
        {
            this.model = model;
            this.id = id;
            this.companyData = companyData;
        }

    }
}
