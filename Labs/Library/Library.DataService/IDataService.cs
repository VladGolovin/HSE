using System;
using System.Collections.Generic;

namespace Library.DataService
{
    public interface IDataService
    {
        IEnumerable<T> LoadObjects<T>() where T: DataObject;

        void InsertObject(DataObject insertObject);

        void UpdateObject(DataObject updatedObject);

        void DeleteObject(DataObject deletedObject);

        IEnumerable<T> Query<T>(Func<T, bool> func) where T: DataObject;
    }
}
