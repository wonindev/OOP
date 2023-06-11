using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Food
    {
        List<Order> perList = new List<Order>();
        public void Add(Order per)
        {
            perList.Add(per);
        }
        public void AddRange(Order[] parr)
        {
            perList.AddRange(parr);
        }
        public void Remove(int idx)
        {
            perList.RemoveAt(idx);
        }

        public void RemoveAll()
        {
            perList.RemoveRange(0, perList.Count);
        }
        public Order this[int idx]
        {
            get { return perList[idx]; }
        }
        public int Count
        {
            get { return perList.Count; }
        }
    }
}
