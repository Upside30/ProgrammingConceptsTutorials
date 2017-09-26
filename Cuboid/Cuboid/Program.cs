using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cuboid
{
    public class Program
    {
        static void Main()
        {

            //Prompts the user to select function and catches any exceptions to prevent crashing
            Program cube = new Program();
            Console.WriteLine("Welcome to Cuboid!\nPlease select the function that you would like to use!\n1. Cuboid volume calculator\n2. Cuboid surface area calculator\n3. Average of 3 integers ");
            try
            {
                int userSelect = Convert.ToInt16(Console.ReadLine());
                if (userSelect == 1)
                {
                    cube.cubeVolume();
                }
                else if (userSelect == 2)
                {
                    cube.CubeSurface();
                }
                else if (userSelect == 3)
                {
                    cube.intAverage();
                }
            }

            catch
            {
                Console.Write("\n\nSorry, an ERROR occured. Please make sure you've made a valid selection.\nPress any key to continue...");
                Console.ReadLine();
                Main();
            }
        }

        public void cubeVolume()
        {
            //The try statements prevents the programme from crashing if an error occurs
            try
            {
                double CubeX;
                double CubeY;
                double CubeZ;
                double CubeVolume;

                //Prompts the user to input values of the cuboid

                Console.Write("Please input the width of the cuboid: ");
                CubeX = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please input the height of the cuboid: ");
                CubeY = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please input the length of the cuboid: ");
                CubeZ = Convert.ToDouble(Console.ReadLine());
                CubeVolume = CubeX * CubeY * CubeZ;
                Console.WriteLine("The volume of your cuboid is " + Math.Round(CubeVolume, 2));
                Console.Write("\nWould you like to restart the Cuboid programme? y/n: ");
                string exitPrompt = Console.ReadLine();
                if (exitPrompt == "y")
                {
                    Main();
                }
                else if (exitPrompt == "n")
                {
                    Environment.Exit(0);
                }

            }

            //Catch statement is used when an error occurs
            catch
            {
                Console.WriteLine("SORRY AN ERROR HAS OCCURED!\nPlease enter numbers only!");
                cubeVolume();
                //Main();
            }
        }

        public void CubeSurface()
        {
            //The try statements prevents the programme from crashing if an error occurs
            try
            {
                double CubeX;
                double CubeY;
                double CubeZ;
                double CubeSurface;

                //Prompts the user to input values of the cuboid

                Console.Write("Please input the width of the cuboid: ");
                CubeX = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please input the height of the cuboid: ");
                CubeY = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please input the length of the cuboid: ");
                CubeZ = Convert.ToDouble(Console.ReadLine());
                CubeSurface = 2 * (CubeX * CubeZ + CubeX * CubeY + CubeZ * CubeY);
                Console.WriteLine("The surface area of your cuboid is " + Math.Round(CubeSurface, 2));
                Console.Write("\nWould you like to restart the Cuboid programme? y/n: ");
                string exitPrompt = Console.ReadLine();
                if (exitPrompt == "y")
                {
                    Main();
                }
                else if (exitPrompt == "n")
                {
                    Environment.Exit(0);
                }

            }

            //Catch statement is used when an error occurs
            catch
            {
                Console.WriteLine("SORRY AN ERROR HAS OCCURED!\nPlease enter numbers only!");
                cubeVolume();
                //Main();
            }
        }

        public void intAverage()
        {
            //program to calculate average of 3 integers
            Console.WriteLine("Enter 3 integers: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            double ave = ((double)num1 + (double)num2 + (double)num3) / 3;
            Console.WriteLine("The average of {0}, {1} and {2} is {3}", num1, num2, num3, Math.Round(ave, 2));
            Console.ReadLine();
        }
    }


}

