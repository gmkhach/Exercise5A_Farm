using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5A
{
    class Horse
    {
        public Horse(string name)
        {
            this.name = name;
        }

        private string name;
        private string kind = "horse";
        private string sound = "Neigh";
        private int size = 1;

        public string GetKind() => kind;
        public string GetName() => name;
        public string GetSound() => sound;
        public int GetSize() => size;

        // Requriement #4 - create four methods for each class. Lines 27-56
        public void Speak()
        {
            Console.WriteLine($"\n{sound}! I'm a horse. My name is {name}, and I eat apples.");
        }

        public void Eat(string food)
        {
            if (food == "apple")
                size++;
            else
                Console.WriteLine("\nHorses eat only apples");
        }

        public void Product(List<FarmProduct> productList)
        {
            productList[1].SetQuantity(1);
        }

        public List<Horse> Multiply()
        {
            List<Horse> foals = new List<Horse>();
            Random rnd = new Random();
            for (int i = 0; i < rnd.Next(7); i++)
            {
                string name = $"foal{i}";
                Horse foal = new Horse(name);
                foals.Add(foal);
            }
            return foals;
        }
    }
}
