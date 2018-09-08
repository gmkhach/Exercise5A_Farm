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
            farmAnimals = Utilities.PopulateFarm();
            // creates a list of farm products
            productList = new List<FarmProduct>();
        }
        private List<Object> farmAnimals;
        private List<FarmProduct> productList;
    }
}
