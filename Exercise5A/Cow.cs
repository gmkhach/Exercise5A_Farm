﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5A
{
    // Requirement #2 - Create one class with one method.
    // Requirement #3 - create four classes, one method. Lines 11-33. Also see classes Duck, Horse, and Sheep. 
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

        // Requriement #4 - create four methods for each class. Lines 30-59. Also see classes Duck, Horse, and Sheep.
        // Requirement #2 - create one class with one method. lines 29-32
        public void Speak()
        {
            Console.WriteLine($"\n{sound}! I'm a cow. My name is {name}, and I eat hay.");
        }

        public void Eat(string food)
        {
            if (food == "hay")
                size++;
            else
                Console.WriteLine("\nCows eat only hay");
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
