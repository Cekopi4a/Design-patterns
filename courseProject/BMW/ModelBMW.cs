using courseProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject.BMW
{
    //FACTORY PATTERN

    public class ModelBMW : ICar
    {
        //Here we crate the first car in the project. BMW is superclass. Object of factory. 

        public string getOnRoadName(string model)
        {
            if (model == "BMW")
            {
                return "e30";
            }

            else
            {
                return "Sorry, but the information you are looking for is missing";
            }
        }
    }
}
