using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Storeage
    {
        List<Inven> invenList = new List<Inven>();
        public void Add(Inven per)
        {
            invenList.Add(per);
        }
        public void AddRange(Inven[] parr)
        {
            invenList.AddRange(parr);
        }
        public void Remove(int idx)
        {
            invenList.RemoveAt(idx);
        }

        public void RemoveAll()
        {
            invenList.RemoveRange(0, invenList.Count);
        }
        public Inven this[int idx]
        {
            get { return invenList[idx]; }
        }
        public int Count
        {
            get { return invenList.Count; }
        }
    }
}
