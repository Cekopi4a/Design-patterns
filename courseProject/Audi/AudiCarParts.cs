using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject.Audi
{
    //FACADE PATTERN - structural pattern

    //Creating a class that contain car`s parameters
    public class AudiCarParts
    {
        public void AssembleTyre()
        {
            Console.WriteLine("Condition: New, not used");
        }
        public void AssembleBody()
        {
            Console.WriteLine("Color: black");
        }
        public void AssembleEnginer()
        {
            Console.WriteLine("Audi A6 diesel");
        }
        public void AssembleSeat()
        {
            Console.WriteLine("4/5 seats");
        }
    }
}
