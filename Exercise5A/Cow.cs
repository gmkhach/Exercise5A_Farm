using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5A
{
    class Cow
    {
        public Cow(string name)
        {
            this.name = name;
        }

        private string name;
        private string kind = "cow";
        private string sound = "Moo";
        private int size = 1;

        public string GetKind() => kind;
        public string GetName() => name;
        public string GetSound() => sound;
        public int GetSize() => size;

        public void Speak()
        {
            Console.WriteLine($"{sound}! I'm a cow. My name is {name}, and I eat hay.");
        }

        public void Eat(string food)
        {
            if (food == "hay")
                size++;
            else
                Console.WriteLine("Cows eat only hay");
        }

        public void Product(List<FarmProduct> productList)
        {
            productList[3].SetQuantity(1);
        }

        public List<Cow> Multiply()
        {
            List<Cow> calves = new List<Cow>();
            Random rnd = new Random();
            for (int i = 0; i < rnd.Next(7); i++)
            {
                string name = $"calf{i}";
                Cow calf = new Cow(name);
                calves.Add(calf);
            }
            return calves;
        }

    }
}
