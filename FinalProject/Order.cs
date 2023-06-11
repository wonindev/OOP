using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Order
    {
        public string Name { get; set; }
        public string Cost { get; set; }
        public Order(string n = "", string c = "")
        {
            Name = n;
            Cost = c;
        }
        public override string ToString()
        {
            return $"음식명: {Name}, 가격: {Cost}";
        }
    }
}
