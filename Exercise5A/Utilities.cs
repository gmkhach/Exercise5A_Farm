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
        public static List<Object> PopulateFarm()
        {
            var farmAnimals = new List<Object>();
            string[] animals = { "cows", "horses", "sheeps", "ducks" };
            Console.WriteLine("\nHello. Let's create your farm animals.");
            try
            {
                foreach (string animal in animals)
                {
                    bool keepLooping = true;
                    do
                    {
                        Console.Write($"\nEnter the names for your {animal}, separated by commas. At least four names.\n\n>>> ");
                        var input = Console.ReadLine().Split(',').Select(x => x.Trim());
                        // create an array of entered names that are not empty strings or strings of empty spaces only.
                        var names = input.Where(x => !string.IsNullOrEmpty(x));
                        // validates that the user entered at least four names, and non of them are empty strings
                        if (names.Count() >= 4)
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
                                    case "sheeps":
                                        farmAnimals.Add(new Sheep(name));
                                        break;
                                    case "ducks":
                                        farmAnimals.Add(new Duck(name));
                                        break;
                                }
                            }
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\nAt least four names must be entered.");
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

        // creates a list of all four farm products with their initial quantities being 0;
        public static List<FarmProduct> FarmProducts()
        {
            List<FarmProduct> productList = new List<FarmProduct>();
            string[] products = { "egg", "hide", "wool", "milk" };
            foreach(string product in products)
            {
                productList.Add(new FarmProduct(product, 0));
            }
            return productList;
        }
    }
}
