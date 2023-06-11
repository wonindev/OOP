using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    internal class Member
    {
        List<Employee> employeeList = new List<Employee>();
        public void Add(Employee em)
        {
            employeeList.Add(em);
        }
        public void AddRange(Employee[] parr)
        {
            employeeList.AddRange(parr);
        }
        public void Remove(int idx)
        {
            employeeList.RemoveAt(idx);
        }

        public void RemoveAll()
        {
            employeeList.RemoveRange(0, employeeList.Count);
        }
        public Employee this[int idx]
        {
            get { return employeeList[idx]; }
        }
        public int Count
        {
            get { return employeeList.Count; }
        }
    }
}