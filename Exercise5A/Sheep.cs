using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5A
{
    class Sheep
    {
        public Sheep(string name)
        {
            this.name = name;
        }

        private string name;
        private string kind = "sheep";
        private string sound = "Baa";
        private int size = 1;

        public string GetKind() => kind;
        public string GetName() => name;
        public string GetSound() => sound;
        public int GetSize() => size;

        // Requriement #4 - create four methods for each class. Lines 27-56
        public void Speak()
        {
            Console.WriteLine($"\n{sound}! I'm a sheep. My name is {name}, and I grass .");
        }

        public void Eat(string food)
        {
            if(food == "grass")
                size++;
            else
                Console.WriteLine("\nSheeps eat only grass");
        }

        public void Product(List<FarmProduct> productList)
        {
            productList[2].SetQuantity(1);
        }

        public List<Sheep> Multiply()
        {
            List<Sheep> lambs = new List<Sheep>();
            Random rnd = new Random();
            for (int i = 0; i < rnd.Next(7); i++)
            {
                string name = $"puppy{i}";
                Sheep lamb = new Sheep(name);
                lambs.Add(lamb);
            }
            return lambs;
        }
    }
}
