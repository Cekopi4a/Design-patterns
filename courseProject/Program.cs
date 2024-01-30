using courseProject;
using courseProject.Audi;
using courseProject.BMW;
using courseProject.Ford;
using courseProject.Interfaces;

//Car project with Factory, Facade and observe patterns

CarFacade carFacade = new CarFacade();
ICarFactory obj1 = new AudiFactory();
ICarFactory obj2 = new BMWFactory();
ICarFactory obj3 = new FordFactory();
Notify msg = new Notify();

//Giving values to the variables
ICarFactory carFactory = new AudiFactory();
ICar car = carFactory.GetCar();
string model = "Audi";
Console.WriteLine("The car that will be shown on the console is {0}, and the model is: {1} ", model, car.getOnRoadName(model));

//Calling the Facade pattern
carFacade.AssembleAudiCar();

//Creating a message action (observe pattern)
msg.AddService(obj1);

//Execute the message action
msg.ExecuteService();

//closing the case
msg.RemoveService(obj1);

Console.WriteLine();

//Giving values to the variables
carFactory = new BMWFactory();
car = carFactory.GetCar();
model = "BMW";
Console.WriteLine("The car that will be shown on the console is {0}, and the model is: {1} ", model, car.getOnRoadName(model));

//Calling the Facade pattern
carFacade.AssembleBMWCar();

//Creating a message action (observe pattern)
msg.AddService(obj2);

//Execute the message action
msg.ExecuteService();

//closing the case
msg.RemoveService(obj2);

Console.WriteLine();


//Giving values to the variables
carFactory = new FordFactory();
car = carFactory.GetCar();
model = "Ford";
Console.WriteLine("The car that will be shown on the console is {0}, and the model is: {1} ", model, car.getOnRoadName(model));

//Calling the Facade pattern
carFacade.AssembleFordCar();

//Creating a message action (observe pattern)
msg.AddService(obj3);

//Execute the message action
msg.ExecuteService();

//closing the case
msg.RemoveService(obj3);