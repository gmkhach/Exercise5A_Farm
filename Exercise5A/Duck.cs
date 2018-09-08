using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5A
{
    class Duck
    {
        public Duck(string name)
        {
            this.name = name;
        }

        private string name;
        private string kind = "duck";
        private string sound = "Quack, quack";
        private int size = 1;

        public string GetName() => name;
        public string GetKind() => kind;
        public string GetSound() => sound;
        public int GetSize() => size;

        // Requriement #4 - create four methods for each class. Lines 27-56
        public void Speak()
        {
            Console.WriteLine($"{sound}! I'm a duck. My name is {name}, and I eat snails.");
        }

        public void Eat(string food)
        {
            if(food == "snail")
                size++;
            else
                Console.WriteLine("Ducks eat only snails");
        }

        public void Product(List<FarmProduct> productList)
        {
            productList[0].SetQuantity(1);
        }

        public List<Duck> Multiply()
        {
            List<Duck> ducklings = new List<Duck>();
            Random rnd = new Random();
            for (int i=0; i < rnd.Next(7); i++)
            {
                string name = $"duckling{i}";
                Duck duckling = new Duck(name);
                ducklings.Add(duckling);
            }
            return ducklings;
        }
    }
}
