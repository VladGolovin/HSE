using System;

using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static class Keys 
        {
            public static string Libraries = "Libraries";

            public static string Shipbuilding = "Shipbuilding";

            public static string Insurance = "Insurance";

            public static string Factories = "Factories";
        }

        public static void FillCollections()
        {

        }

        static void Main(string[] args)
        {
            var orgs = new Dictionary<string, List<Organization>>();

            orgs.Add(Keys.Libraries, new List<Organization>()
            {
                new Library() { Address = "г. Пермь, ул. Докучаева 38", BookCount = 1000, IsDigital = true, Name = "Библиотека № 14 им. М. Ю. Лермонтова" },
                new Library() { Name = "Пермская краевая медицинская библиотека", Address = "ш. Космонавтов, 16, Пермь", BookCount = 1220, IsDigital = false },
                new Library() { Name = "Библиотека №30", Address = "г. Москва, ул. Новокузнецкая 32", IsDigital = true, BookCount = 3000 }
            });

            orgs.Add(Keys.)
        }
    }
}
