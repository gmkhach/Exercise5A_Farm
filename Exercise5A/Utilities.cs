using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5A
{
    class Utilities
    {
        // prompts the user to type in animal names and creates an object of a coresponding animal type for each name.
        public static List<object> PopulateFarm()
        {

            var farmAnimals = new List<object>();

            string[] animals = { "cows", "horses", "dogs", "ducks" };
            Console.WriteLine("Hello. Let's create your farm animals.");
            try
            {
                foreach (string animal in animals)
                {
                    bool keepLooping = true;
                    do
                    {
                        Console.Write($"\nEntery the names for your {animal}, separated by commas. At least four names.\n\n>>> ");
                        var names = Console.ReadLine().Split(',');
                        if (names.Count() >= 4 && names[names.Count() - 1] != "")
                        {
                            keepLooping = false;
                            foreach (string name in names)
                            {
                                switch (animal)
                                {
                                    case "cows":
                                        farmAnimals.Add(new Cow(name));
                                        break;
                                    case "horses":
                                        farmAnimals.Add(new Horse(name));
                                        break;
                                    case "dogs":
                                        farmAnimals.Add(new Dog(name));
                                        break;
                                    case "ducks":
                                        farmAnimals.Add(new Duck(name));
                                        break;
                                }
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("At least four names must be entered.");
                        }
                        if (animal == "ducks")
                        {
                            keepLooping = false;
                        }
                    } while (keepLooping);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return farmAnimals;
        }
    }
}
