namespace Library.DataService
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.IO;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;

    using Objects;
    using System.Linq.Expressions;

    public class FileDataService : IDataService
    {
        private IFormatter formatter;

        public FileDataService()
        {
            this.formatter = new BinaryFormatter();
        }

        public FileDataService(IFormatter formatter)
        {
            this.formatter = formatter;
        }

        public string GetFileName(Type type)
        {
            return $"t_{type.Name}.data";
        }

        public IEnumerable<T> LoadObjects<T>()
        {
            Contract.Assert(typeof(T).IsSubclassOf(typeof(DataObject)), $"Передаваемый тип должен наследоваться от {typeof(DataObject).FullName}");

            List<T> dataObjects = new List<T>();

            using (FileStream fs = new FileStream(GetFileName(typeof(T)), FileMode.OpenOrCreate))
            {
                if (fs.Length > 0)
                {
                    do
                    {
                        var dataObject = formatter.Deserialize(fs);

                        if (!((DataObject)dataObject).Deleted)
                        {
                            dataObjects.Add((T)dataObject);
                        }
                    } while (fs.Position != fs.Length);
                    
                    fs.Close();
                }
            }

            return dataObjects;
        }

        public void InsertObject(DataObject insertObject)
        {            
            using (FileStream fs = new FileStream(GetFileName(insertObject.GetType()), FileMode.Append))
            {
                formatter.Serialize(fs, insertObject);

                fs.Close();
            }
        }

        public void UpdateObject(DataObject updatedObject)
        {
            using (FileStream fs = new FileStream(GetFileName(updatedObject.GetType()), FileMode.Open))
            {
                if (fs.Length > 0)
                {
                    long backStep = fs.Position;

                    do
                    {
                        var dataObject = (DataObject)formatter.Deserialize(fs);
                        
                        if (dataObject.PrimaryKey.Equals(updatedObject.PrimaryKey))
                        {
                            fs.Position = backStep;

                            formatter.Serialize(fs, updatedObject);

                            fs.Position = fs.Length;
                        }

                        backStep = fs.Position;
                    } while (fs.Position != fs.Length);

                    fs.Close();
                }
            }
        }

        public void DeleteObject(DataObject deletedObject)
        {
            List<DataObject> objects = new List<DataObject>();
            int deletedObjects = 0;
            string fileName = GetFileName(deletedObject.GetType());

            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                if (fs.Length > 0)
                {
                    long backStep = fs.Position;

                    do
                    {
                        var dataObject = (DataObject)formatter.Deserialize(fs);

                        objects.Add(dataObject);

                        if (dataObject.Deleted)
                        {
                            deletedObjects++;
                        }

                        if (dataObject.PrimaryKey.Equals(deletedObject.PrimaryKey))
                        {
                            fs.Position = backStep;

                            dataObject.Deleted = true;
                            formatter.Serialize(fs, dataObject);

                            deletedObjects++;
                        }

                        backStep = fs.Position;
                    } while (fs.Position != fs.Length);

                    fs.Close();
                }
            }

            if (objects.Count/2 <= deletedObjects)
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                {
                    objects.ForEach(dataObject =>
                    {
                        if (!dataObject.Deleted)
                        {
                            formatter.Serialize(fs, dataObject);
                        }
                    });
                }
            }
        }

        public IEnumerable<T> Query<T>(Func<T, bool> func)
        {
            Contract.Assert(typeof(T).IsSubclassOf(typeof(DataObject)), $"Передаваемый тип должен наследоваться от {typeof(DataObject).FullName}");

            List<T> dataObjects = new List<T>();

            using (FileStream fs = new FileStream(GetFileName(typeof(T)), FileMode.OpenOrCreate))
            {
                if (fs.Length > 0)
                {
                    do
                    {
                        var dataObject = formatter.Deserialize(fs);
                        if (!((DataObject)dataObject).Deleted && func((T)dataObject))
                        {
                            dataObjects.Add((T)dataObject);
                        }
                    } while (fs.Position != fs.Length);

                    fs.Close();
                }
            }

            return dataObjects;
        }
    }
}
