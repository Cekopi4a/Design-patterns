using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject.Interfaces
{
    //FACTORY PATTERN - creational pattern for create 3 superclasses
    // Creating the interface that takes the names of the car

    public interface ICar
    {
        string getOnRoadName(string model);
    }
}
