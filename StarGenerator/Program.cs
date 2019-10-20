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
            Console.WriteLine("Welcome to the Star System Generator! To generate a star system, press any key.");
            Console.ReadLine();
            string letter;
            do
            {
                NameStar();
                // GeneratePlanets();
                Console.WriteLine("Press Y to generate another system, or any other key to exit.");
                letter = Console.ReadLine();
            }
            while (letter == "Y" || letter == "y");
        }

        static void NameStar()
        {
            Random rand = new Random();

            string[] starSyllables = { "al", "be", "gam", "del", "the", "kap", "io", "chi", "neth", "mat", "than", "bre", "epa", "sil", "on", "cha", "cet", "pha", "ma", "pa", "ta", "nik", "lop", "in", "sia", "ios" };

            string starName = null;
            int numberOfSyllables = rand.Next(2, 5);
            for (int i = 0; i < numberOfSyllables; i++)
            {
                int starSyllableIndex = rand.Next(starSyllables.Length);
                starName += starSyllables[starSyllableIndex];
                Thread.Sleep(20);
                starName = char.ToUpper(starName[0]) + starName.Substring(1);
            }
            char[] starClasses = { 'O', 'B', 'A', 'F', 'G', 'K', 'M' };
            int starClassIndex = rand.Next(starClasses.Length);
            char starClass = starClasses[starClassIndex];
            int lightYears = rand.Next(4, 102034);
            string lightYearsString = lightYears.ToString("N0");
            Console.WriteLine(starName + " is a class " + starClass + " star, " + lightYearsString + " light years away.");
        }
        // Compare Middle syllables to make sure they're not re-used
        // Implement opening syllables and ending syllables
        // Randomly select class

        // Console.WriteLine(starName + " is a class " + starClass + " star.");

        // Generate number of planets
        // Name planets StarName+I-XV

        // Console.WriteLine(starName + " has " + numPlanets + " planets with the following characteristics:");

        // Assign each planet rocky or gas
        // Generate number of moons per planet 1-4 rocky, 8-45 gaseous
        // Assign 

    }
}
