using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KdarsVehicleRepair
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string carMake;
            string mechanicName;
            string insurance;
            string caseDescription;
            string carModel;
            bool hasInsurance;

            Console.Write("Please input client's name: ");
            name = Console.ReadLine();
            Console.Write("Please input the make of the car:");
            carMake = Console.ReadLine();
            Console.Write("Please input the model of the car:");
            carModel = Console.ReadLine();
            Console.Write("Do you have insurance? (Y/N)");
            insurance = Console.ReadLine();
            Console.WriteLine("Please input a Case Description:");
            caseDescription = Console.ReadLine();

            if ( insurance== "Y")
            {
                hasInsurance = true;

            }
            else
            {
                hasInsurance = false;
            }

            /* bool statment captures whether or  not the user has insurance - possibly add package pricing 
             * at later date */

            Console.Write("Please input name of mechanic on the job?");
            mechanicName = Console.ReadLine();
            Console.Write("Output: Name : {2} | Make : {0} : | Model : {1} :", carMake, carModel, name);
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("Reports");
            Console.WriteLine("*******************************************************************");

            Mechanic Bud = new Mechanic("Bud",true, 25.00);
            Mechanic Buddy = new Mechanic("Buddy",false, 15.50);
            Mechanic Buddie = new Mechanic("Buddie", false, 50.00);

            Console.WriteLine("");
            Console.WriteLine("Client Report");
            Console.WriteLine("*******************************************************************");

            Client client = new Client(name, carMake, carModel, mechanicName, caseDescription);

            Console.WriteLine("");
            Console.WriteLine("Car Report");
            Console.WriteLine("********************************************************************");

            Car car = new Car(carMake, carModel, caseDescription, mechanicName);

            Console.ReadKey();
        
        }
    }
}
