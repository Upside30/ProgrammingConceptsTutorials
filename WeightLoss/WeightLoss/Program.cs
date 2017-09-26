using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightLoss
{
    class Program
    {
        static void Main(string[] args)
        {
            const int calBurnCycle = 200;
            const int calBurnRun = 475;
            const int calBurnSwim = 275;
            const int poundPerCalories = 3500;

            //Prompts for time inputs
            Console.Write("Please enter time spent cycling in minutes: ");
            int cycleTime = int.Parse(Console.ReadLine());
            Console.Write("Please enter time spent running in minutes: ");
            int runningTime = int.Parse(Console.ReadLine());
            Console.Write("Please enter time spent swimming in minutes: ");
            int swimTime = int.Parse(Console.ReadLine());
            int totalTime = cycleTime + runningTime + swimTime;

            //Variables for calories burned
            double cycleCal = ((double)cycleTime / 60) * calBurnCycle;
            double runCal = ((double)runningTime / 60) * calBurnRun;
            double swimCal = ((double)swimTime / 60) * calBurnSwim;
            double totalCal = cycleCal + runCal + swimCal;

            //Variables for weight loss
            double cycleWeight = cycleCal / poundPerCalories;
            double runWeight = runCal / poundPerCalories;
            double swimWeight = swimCal / poundPerCalories;
            double totalWeight = cycleWeight + runWeight + swimWeight;

            TimeSpan ts = TimeSpan.FromMinutes(cycleTime);
            string w = new DateTime(ts.Ticks).ToString("hh:mm");
            TimeSpan ts1 = TimeSpan.FromMinutes(swimTime);
            string a = new DateTime(ts1.Ticks).ToString("hh:mm");
            TimeSpan ts2 = TimeSpan.FromMinutes(runningTime);
            string s = new DateTime(ts2.Ticks).ToString("hh:mm");
            TimeSpan ts3 = TimeSpan.FromMinutes(totalTime);
            string d = new DateTime(ts3.Ticks).ToString("hh:mm");

            //Table with results
            Console.WriteLine("\n{0, 20}{1, 20}{2, 20}{3, 20}\n ", "Activity", "Time Spent", "Calories Burnt", "Pounds Lost");
            Console.WriteLine("{0, 20}{1, 20}{2, 20}{3, 20}", "Cycling", w, Math.Round(cycleCal, 2), Math.Round(cycleWeight, 2));
            Console.WriteLine("{0, 20}{1, 20}{2, 20}{3, 20}", "Running", a, Math.Round(runCal, 2), Math.Round(runWeight, 2));
            Console.WriteLine("{0, 20}{1, 20}{2, 20}{3, 20}\n", "Swimming", s, Math.Round(swimCal, 2), Math.Round(swimWeight, 2));
            Console.WriteLine("{0, 20}{1, 20}{2, 20}{3, 20}\n", "Total", d, Math.Round(totalCal, 2), Math.Round(totalWeight, 2));
            Console.ReadLine();
        }
    }
}
