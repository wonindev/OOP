using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Store
{
    public class Inven
    {
        public string Name { get; set; }
        public string Due { get; set; }

        public string Count { get; set; }
        public Inven(string n = "", string d = "", string c = "")
        {
            Name = n;
            Due = d;
            Count = c;
        }
        public override string ToString()
        {
            return $"품목 이름: {Name}, 유통기한: {Due}, 수량: {Count}";
        }
    }
}
