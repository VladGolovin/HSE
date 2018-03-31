using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    public class Library: Organization
    {
        public bool IsDigital { get; set; }

        public int BookCount { get; set; }
    }
}
