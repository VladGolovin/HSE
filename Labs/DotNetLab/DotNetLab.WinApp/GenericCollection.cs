using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab.WinApp
{
    public class GenericCollection<T> : System.Collections.CollectionBase
    {
        public T Add()
        {
            T Item = Activator.CreateInstance<T>();
            List.Add(Item);
            return Item;
        }

        public T Add(T Item)
        {
            List.Add(Item);
            return Item;
        }

        public void Insert(int Index, T Item)
        {
            List.Insert(Index, Item);
        }

        public void Remove(T Item)
        {
            List.Remove(Item);
        }

        public T this[int Index]
        {
            get
            {
                return (T)List[Index];
            }
        }
    }
}
