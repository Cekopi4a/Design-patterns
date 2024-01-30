using courseProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject.Audi
{
    //FACTORY PATTERN

    public class ModelAudi : ICar
    {
        //Here we crate the first car in the project. Audi is superclass. Object of factory. 

        public string getOnRoadName(string model)
        {
            if (model == "Audi")
            {
                return "A6";
            }

            else
            {
                return "Sorry, but the information you are looking for is missing";
            }
        }
    }
}
