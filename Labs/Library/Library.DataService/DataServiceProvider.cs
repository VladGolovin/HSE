using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataService
{
    public class DataServiceProvider
    {
        private static FileDataService dataService = new FileDataService();

        private DataServiceProvider() { }

        public static FileDataService DataService
        {
            get
            {
                return dataService;
            }
        }

    }
}
