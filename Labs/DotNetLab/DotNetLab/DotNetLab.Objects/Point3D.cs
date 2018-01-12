using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetLab;

namespace DotNetLab.Objects
{
    [Serializable()]
    public class Point3D: Point
    {
        public int z;
        
        public Point3D(): base()
        {
            z = 0;
        }

        public Point3D(int x, int y, int z): base(x, y)
        {
            this.z = z;
        }

        public override double Metric()
        {
            return Math.Sqrt((x * x + y * y + z * z));
        }

        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", x, y, z);
        }

        public void Save()
        {
            SaveFileDialog
        }
    }
}
