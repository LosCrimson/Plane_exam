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
        public int Id 
        {
            get { return id; }
            set { id = value; }
        }

        public Aircraft(int id)
        {
            this.id = id;
        }
    }
}
