using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5A
{
    class Farm
    {
        public Farm()
        {
            // creates a list of animals to be used throughout the program
            animals = Utilities.PopulateFarm();
            // creates a list of farm products
            products = new List<FarmProduct>();
        }

        private List<Object> animals;
        private List<FarmProduct> products;

        public List<Object> GetAnimals() => animals;
        public List<FarmProduct> GetProducts() => products;

        public void animalIntroduction()
        {
            for (int i = 0; i < animals.Count(); i++)
            {
                if (animals[i].GetType() == typeof(Cow))
                {
                    Cow myCow = (Cow)animals[i];
                    myCow.Speak();
                }
                else if (animals[i].GetType() == typeof(Horse))
                {
                    Horse myCow = (Horse)animals[i];
                    myCow.Speak();
                }
                else if (animals[i].GetType() == typeof(Sheep))
                {
                    Sheep myCow = (Sheep)animals[i];
                    myCow.Speak();
                }
                else if (animals[i].GetType() == typeof(Duck))
                {
                    Duck myCow = (Duck)animals[i];
                    myCow.Speak();
                }
            }
        }
    }
}
