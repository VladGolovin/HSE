using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataService
{
    using Objects;

    public interface IDataService
    {
        IEnumerable<T> LoadObjects<T>();

        void InsertObject(DataObject insertObject);

        void UpdateObject(DataObject updatedObject);

        void DeleteObject(DataObject deletedObject);

        IEnumerable<T> Query<T>(Func<T, bool> func);
    }
}
