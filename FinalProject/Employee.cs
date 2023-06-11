using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Birthdate { get; set; }

        public string Money { get; set; }
        public Employee(string n = "", string b = "", string m = "")
        {
            Name = n;
            Birthdate = b;
            Money = m;

        }
        public override string ToString()
        {
            return $"이름: {Name}, 생년월일: {Birthdate}, 월급:{Money}";
        }
    }
}