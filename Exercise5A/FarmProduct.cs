using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5A
{
    class FarmProduct
    {
        public FarmProduct(string type, int quantity)
        {
            this.type = type;
            this.quantity = quantity;
        }

        private string type;
        private int quantity;
    }
}
