using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Charts
{
    public class ViewModel
    {

        public List<Models> Data { get; set; }

        public ViewModel()
        {
            Data = new List<Models>()
        {
            new Models { Time = "Leden ", BMI = 24 },
            new Models { Time = "Únor", BMI = 26 },
            new Models { Time = "Březen", BMI = 25 },
            new Models { Time = "Duben", BMI = 23 },
            new Models { Time = "Květen", BMI = 22 }
        };
        }
    }
}

