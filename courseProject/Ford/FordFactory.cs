using courseProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject.Ford
{
    //FACTORY METHOD

    //Creating a method for the first car that will create a new "First Car"
    public class FordFactory : ICarFactory
    {
        public ICar GetCar()
        {
            return new ModelFord();
        }

        //OBSERVE PATTERN

        //Creating a message type
        public void Notify()
        {
            Console.WriteLine("Notification will be send by E-mail.");
        }
    }

}
