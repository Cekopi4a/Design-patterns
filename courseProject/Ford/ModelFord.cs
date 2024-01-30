using courseProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject.Ford
{
    //FACTORY PATTERN

    public class ModelFord : ICar
    {
        //Here we crate the first car in the project. Ford is superclass. Object of factory. 

        public string getOnRoadName(string model)
        {
            if (model == "Ford")
            {
                return "Mustang";
            }

            else
            {
                return "Sorry, but the information you are looking for is missing";
            }
        }
    }
}
