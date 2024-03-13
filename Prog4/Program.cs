/*
 * Grading ID: K3194
 * Program 4
 * Due Date: 4/18/2022
 * Course Section: CIS 199-01
 * Description: Creates 5 Superhero objects, modifies them, and prints them out before and after object modification
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    class Program
    {
        //Precondition: None (Program Entry)
        //Postcondition: Program ends execution (Program Exit)
        static void Main(string[] args)
        {
            Superhero sh1 = new Superhero("John", "Bardstown", "Invisibility", 2001, "Laser Eyes"); //Create 5 superhero objects
            Superhero sh2 = new Superhero("Tyler", "Louisville", "Super Speed", 1994, "Underwater Breathing");
            Superhero sh3 = new Superhero("Jackson", "Nashville", "Super Jumping", 1900, "Immortal");
            Superhero sh4 = new Superhero("Preston", "Chicago", "Flexible Limbs", 1983, "Magnetic");
            Superhero sh5 = new Superhero("Carrie", "New York City", "Immortal", 1999, "Super Strength");

            Superhero[] sHeroArray = { sh1, sh2, sh3, sh4, sh5 }; //Create an array to hold the 5 unique Superhero objects

            printSuperheroes(sHeroArray); //Call printSuperheroes function passing in a Superhero array as a parameter

            sh1.FirstSuperpower = "Telekinesis"; //Modify superhero fields
            sh2.SecondSuperpower = "Extreme Flexibility";
            sh3.FirstSuperpower = "Unlimited Endurance";
            sh4.SecondSuperpower = "Fire Casting";
            sh5.FirstSuperpower = "High Intelligence";
            sh2.OffPlanetEarth();
            sh4.OffPlanetEarth();

            printSuperheroes(sHeroArray);

            sh1.OffPlanetEarth(); //Set the rest of the superheros to Off Planet Earth status
            sh3.OffPlanetEarth();
            sh5.OffPlanetEarth();

            printSuperheroes(sHeroArray);
        }

        //Preconditions: Must pass in an array of Superhero objects
        //Postconditions: Superhero Info/Data Printed to Console
        static void printSuperheroes(Superhero[] sHeroArray)
        {
            foreach(Superhero s in sHeroArray) //Loop through each Superhero in array
            {
                Console.WriteLine(s + "\n"); //Use overridden ToString to print Superhero details and add line break at end of each record for readability
            }
        }
    }
}
