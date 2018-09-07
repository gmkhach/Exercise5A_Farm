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
        private string sound = "moo";
        private int size = 1;

        public string GetKind() => kind;
        public string GetName() => name;
        public string GetSound() => sound;
        public int GetSize() => size;
    }
}
