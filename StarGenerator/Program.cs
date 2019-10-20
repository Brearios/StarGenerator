using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StarGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random name Generator
            Console.WriteLine("Welcome to the Star System Generator! How many stars would you like to generate?");
            int stars = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < stars; i++)
            {
                GenerateStar();
                // Console.WriteLine("Press Y to generate another system, or any other key to exit.");
            }
            Console.ReadLine();
        }

        static void GenerateStar()
        {
            Random rand = new Random();

            string[] starSyllables = { "al", "be", "gam", "del", "the", "kap", "io", "chi", "neth", "mat", "than", "bre", "epa", "sil", "on", "cha", "cet", "pha", "ma", "pa", "ta", "nik", "lop", "in", "sia", "ios" };

            string starName = null;
            int numberOfSyllables = rand.Next(2, 5);
            for (int i = 0; i < numberOfSyllables; i++)
            {
                int starSyllableIndex = rand.Next(starSyllables.Length);
                starName += starSyllables[starSyllableIndex];
                // Sleep time prevents duplicate results due to Random using system clock
                Thread.Sleep(20);
                starName = char.ToUpper(starName[0]) + starName.Substring(1);
            }
            char[] starClasses = { 'O', 'B', 'A', 'F', 'G', 'K', 'M' };
            int starClassIndex = rand.Next(starClasses.Length);
            char starClass = starClasses[starClassIndex];
            int lightYears = rand.Next(4, 102034);
            string lightYearsString = lightYears.ToString("N0");
            Console.WriteLine(starName + " is a class " + starClass + " star, " + lightYearsString + " light years away.");
            int numOrbits = rand.Next(1, 18);
            if (numOrbits == 1)
            {
                Console.WriteLine("There are " + numOrbits + " planetary object orbiting " + starName + ".");
            }
            else
            {
                Console.WriteLine("There are " + numOrbits + " planetary objects orbiting " + starName + ".");
            }
            Console.WriteLine();
            for (int i = 1; (i < numOrbits + 1); i++)
            {
                int orbitType = rand.Next(1, 5);
                switch(orbitType)
                {
                    case 1:
                        int rockyMoons = rand.Next(0, 5);
                        Console.WriteLine(starName + " " + i + " is a rocky world with " + rockyMoons + " moons.");
                        break;

                    case 2:
                        int gasMoons = rand.Next(0, 5);
                        Console.WriteLine(starName + " " + i + " is a gas giant with " + gasMoons + " moons.");
                        break;
                    case 3:
                        int dwarfMoons = rand.Next(0, 5);
                        Console.WriteLine(starName + " " + i + " is a dwarf planet with " + dwarfMoons + " moons.");
                        break;
                    case 4:
                        Console.WriteLine(starName + " has an asteroid belt at orbital position " + i + ".");
                        break;
                }    
            }
            Console.WriteLine();
            

            // To-Do:
            // Compare Middle syllables to make sure they're not re-used
            // Implement opening syllables and ending syllables
            // Randomly select class

            // Console.WriteLine(starName + " is a class " + starClass + " star.");

            // Generate number of planets
            // Name planets StarName+I-XV

            // Console.WriteLine(starName + " has " + numPlanets + " planets with the following characteristics:");

            // Assign each planet rocky or gas
            // Generate number of moons per planet 1-4 rocky, 8-45 gaseous
            // Add diameter and mass to planets?

        }
    }
}
