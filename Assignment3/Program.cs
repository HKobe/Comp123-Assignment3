using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * @Author: Hassan Kobeissi
 * @StudentNumber: 300847239
 * @DateCreated: June, 06,2016
 * @DateReleased: June, 17,2016
 * @Description: This program tests the GiantPlanet and TerrestrialPlanet classes.
 * Version #: 0.0.3
 */
namespace Assignment3
{
    public class Program
    {
        /// <summary>
        /// Main Method
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {

            #region GiantPlanet
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Planet Saturn = new GiantPlanet("Saturn", 95.5, 92.5, "Gas");
            Console.WriteLine("************************************************");
            Console.WriteLine(Saturn.ToString());
            Console.WriteLine("************************************************");
            #endregion

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;

            #region TerrestrialPlanet
            
            TerrestrialPlanet Nebula = new TerrestrialPlanet("Nebula", 70.2, 80.3, true);
            Console.WriteLine("************************************************");
            Console.WriteLine(Nebula.ToString());
            Console.WriteLine("************************************************");
            
            #endregion

            Console.WriteLine();
            
            waitForAnyKey();
   
        }
        /// <summary>
        /// Utility method to wait for a console key press from the user.
        /// </summary>
        /// @Returns Void
        /// @Method WaitForAnyKey()
        public static void waitForAnyKey()
        {
            /*Console.WriteLine("enter 'x' to exit: ");
            Console.WriteLine("Hassan Kobeissi - 300847239");
            Console.WriteLine("S - To choose Saturn");
            Console.WriteLine("G - To choose Giant Planet");
            string choice = Console.ReadLine();
           /* switch (choice)
            {
               
                case "x":
                    break;
              
            }*/
            Console.WriteLine("Press Any Key to exit: ");
            Console.ReadKey();
        }
    }
}
