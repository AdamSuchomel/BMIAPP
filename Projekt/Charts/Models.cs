using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Charts
{
    public class Models
    {
      public Models(string Time, double BMI)
            {
                this.Time = Time;
                this.BMI = BMI;
            }
        public string Time { get; set; }
        public double BMI { get; set; }
    }
}
