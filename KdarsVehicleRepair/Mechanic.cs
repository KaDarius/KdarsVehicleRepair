using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KdarsVehicleRepair
{
    class Mechanic
    {
        private string name;
        private bool onClaim;
        private double hourlyRate;
        private double weeklyRate;

        public Mechanic(string Name, bool onClaim, double HourlyRate)
        {
            name = Name;
            onClaim = OnClaim;
            hourlyRate = HourlyRate;
            weeklyRate = hourlyRate;

            weeklyRate = PayCalc();
            PrintReport();

        }

        public string Name { get => name; set => name = value; }
        public bool OnClaim { get => onClaim; set => onClaim = value; }
        public double HourlyRate { get => hourlyRate; set => hourlyRate = value; }

        public double PayCalc()
        {
            return (40 * HourlyRate);
        }

        public void PrintReport()
        {
          Console.WriteLine("Mechanic Name: {0:c}", Name);
          Console.WriteLine("Hourly Rate: {0:c}", HourlyRate);
          Console.WriteLine("Mechanic currently on job?: {0:c}", OnClaim);
          Console.WriteLine("Weekly Pay: {O:c}", weeklyRate);
          Console.WriteLine("");  
        }
    }
}
