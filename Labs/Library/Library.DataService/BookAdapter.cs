
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataService
{
    using System;
    using System.IO;
    using System.Collections.Generic;

    using Objects;

    public class BookAdapter
    {
        public IEnumerable<Book> Get()
        {
            return new Book[0];
        }
    }
}
