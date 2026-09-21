namespace Excercise_2;

internal class Program
{
     static void Main(string[] args)
     {

         Car[] cars = new Car[5];
         cars[0] = new Car("Honda", "Civic", 40, 550);
         cars[1] = new Car("Ford", "Mustang", 40, 432);
         cars[2] = new Car("VW", "Golf", 40, 667);
         cars[3] = new Car("Ford", "focus", 40, 600);
         cars[4] = new Car("Chevrolet", "Cruz", 40, 525);

         string option = "";
         

         while (option != "4")
         {
             option = DisplayMenu();


             switch (option)
             {
                 case "1":
                     Console.WriteLine("Display all of the cars");
                     foreach (Car c in cars)
                     {
                         Console.WriteLine(c);
                     }
                     break;
                 case "2":
                     Console.WriteLine("Car with best mileage");
                     double bestFuel = cars[0].CalculateFuelEfficiency();
                     Car bestCar = cars[0];
                     foreach (Car c in cars)
                     {
                         if (c.CalculateFuelEfficiency() < bestFuel)
                         {
                             bestFuel = c.CalculateFuelEfficiency();
                             bestCar = c;
                         }
                     }
                     Console.WriteLine($"The car with the best mileage is" + bestCar);
                     
                     break;
                 case "3":
                     Console.WriteLine("List all Ford cars");
                     foreach (Car c in cars)
                     {
                         if (c.GetMake() == "Ford")
                         {
                             Console.WriteLine(c);
                         } 
                     }
                     break;
                 case "4":
                     Console.WriteLine("You choose option 4");
                     break;
             }
         }
       

     }

     private static string? DisplayMenu()
     {
         string? option;
         Console.WriteLine("CAR APPLICATION");
         Console.WriteLine("===================");
         Console.WriteLine();
        
         Console.WriteLine("MENU");
         Console.WriteLine("1 -  Display all the cars");
         Console.WriteLine("2 -  Display car with best Milage");
         Console.WriteLine("3 -  List all cars from ford");
         Console.WriteLine("4 -  Display all the cars");
         Console.WriteLine();
         Console.Write("Enter Option: ");
         option = Console.ReadLine();
         Console.WriteLine();
         return option;
     }
}