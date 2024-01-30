using courseProject.Audi;
using courseProject.BMW;
using courseProject.Ford;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject
{
    //FACADE PATTERN
    public class CarFacade
    {
        AudiCarParts bodyAudi, engineAudi, tyreAudi, accessoriesAudi;

        BMWCarParts bodyBMW, engineBMW, tyreBMW, accessoriesBMW;

        FordCarParts bodyFord, engineFord, tyreFord, accessoriesFord;

        public CarFacade()
        {
             bodyAudi = new AudiCarParts();
             engineAudi = new AudiCarParts();
             tyreAudi = new AudiCarParts();
             accessoriesAudi = new AudiCarParts();

             bodyBMW = new BMWCarParts();
             engineBMW = new BMWCarParts();
             tyreBMW = new BMWCarParts();
             accessoriesBMW = new BMWCarParts();

             bodyFord = new FordCarParts();
             engineFord = new FordCarParts();
             tyreFord = new FordCarParts();
             accessoriesFord = new FordCarParts();
        }

        //Calling the paremeters (parts) from AudiCarParts
        public void AssembleAudiCar()
        {
            Console.WriteLine("Car`s paremeters for Audi");
            bodyAudi.AssembleBody();
            engineAudi.AssembleEnginer();
            tyreAudi.AssembleTyre();
            accessoriesAudi.AssembleSeat();
        }

        //Calling the paremeters (parts) from BMWCarParts
        public void AssembleBMWCar()
        {
            Console.WriteLine("Car`s paremeters for BMW");
            bodyBMW.AssembleBody();
            engineBMW.AssembleEnginer();
            tyreBMW.AssembleTyre();
            accessoriesBMW.AssembleSeat();
        }

        //Calling the paremeters (parts) from FordCarParts
        public void AssembleFordCar()
        {
            Console.WriteLine("Car`s paremeters for Ford");
            bodyFord.AssembleBody();
            engineFord.AssembleEnginer();
            tyreFord.AssembleTyre();
            accessoriesFord.AssembleSeat();
        }
    }
}
