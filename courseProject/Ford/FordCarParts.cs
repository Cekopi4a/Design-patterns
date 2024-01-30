using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject.Ford
{
    //FACADE PATTERN - structural pattern

    //Creating a class that contain car`s parameters
    public class FordCarParts
    {
        public void AssembleTyre()
        {
            Console.WriteLine("Condition: New, not used");
        }
        public void AssembleBody()
        {
            Console.WriteLine("Color: red");
        }
        public void AssembleEnginer()
        {
            Console.WriteLine("Ford Mustang diesel");
        }
        public void AssembleSeat()
        {
            Console.WriteLine("4/5 seats");
        }
    }

}
