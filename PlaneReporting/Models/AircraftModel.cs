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

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public AircraftModel(string model)
        {
            this.model = model;
        }

    }
}
