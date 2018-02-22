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
            string carDescription;
            bool hasInsurance;

            Console.Write("Please input client's name: ");
            name = Console.ReadLine();
            Console.Write("Please input the make of the car:");
            carMake = Console.ReadLine();
            Console.Write("Please input the model of the car:");
            carModel = Console.ReadLine();
            Console.Write("Do you have insurance? (Y/N)");
            insurance = Console.ReadLine();

            if ( insurance== "Y")
            {
                hasInsurance = true;

            }
            else
            {
                hasInsurance = false;
            }
            Console.WriteLine(hasInsurance);

            /* bool statment captures whether or  not the user has insurance - possibly add package pricing 
             * at later date */

            Console.Write("Please input name of mechanic on the job?");
            mechanicName = Console.ReadLine();
            Console.Write("Output: Name : {2} make {0} and model {1}:", carMake, carModel, name);
            Console.ReadKey();


           
        }
    }
}
