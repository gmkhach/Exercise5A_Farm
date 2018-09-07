using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5A
{
    class Dog
    {
        public Dog(string name)
        {
            this.name = name;
        }

        private string name;
        private string kind = "dog";
        private string sound = "ruff";
        private int size = 1;

        public string GetKind() => kind;
        public string GetName() => name;
        public string GetSound() => sound;
        public int GetSize() => size;
    }
}
