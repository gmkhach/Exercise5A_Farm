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
    }
}
