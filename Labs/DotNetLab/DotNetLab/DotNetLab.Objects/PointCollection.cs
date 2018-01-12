using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab.Objects
{
    [Serializable()]
    class PointCollection: System.Collections.CollectionBase
    {
        public Point Add()
        {
            Point Item = new Point();
            List.Add(Item);
            return Item;
        }

        public Point Add(Point Item)
        {
            List.Add(Item);
            return Item;
        }

        public void Insert(int Index, Point Item)
        {
            List.Insert(Index, Item);
        }

        public void Remove(Point Item)
        {
            List.Remove(Item);
        }

        public Point this[int Index]
        {
            get
            {
                return (Point)List[Index];
            }
        }
    }
}
