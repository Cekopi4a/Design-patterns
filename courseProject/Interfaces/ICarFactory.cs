using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject.Interfaces
{
    //FACTORY PATTERN AND OBSERVE PATTERN (void Notify - for observe pattern, getCar - for factory pattern)

    //Creating the interface that will call in the GetCar method and the Notify method
    public interface ICarFactory
    {
        ICar GetCar();
        void Notify();
    }
}
