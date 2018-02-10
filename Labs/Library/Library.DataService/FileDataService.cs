namespace Library.DataService
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;

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

        public IEnumerable<T> LoadObjects<T>() where T: DataObject
        {
            List<T> dataObjects = new List<T>();

            using (FileStream fs = new FileStream(GetFileName(typeof(T)), FileMode.OpenOrCreate))
            {
                if (fs.Length > 0)
                {
                    do
                    {
                        var dataObject = (T)formatter.Deserialize(fs);

                        if (!dataObject.Deleted)
                        {
                            dataObjects.Add(dataObject);
                        }
                    } while (fs.Position != fs.Length);
                }
            }

            return dataObjects;
        }

        public void InsertObject(DataObject insertObject)
        {            
            using (FileStream fs = new FileStream(GetFileName(insertObject.GetType()), FileMode.Append))
            {
                formatter.Serialize(fs, insertObject);
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
                }
            }
        }

        public void DeleteObject(DataObject deletedObject)
        {
            int deletedObjects = 0;
            int objectsCount = 0;
            string fileName = GetFileName(deletedObject.GetType());

            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                if (fs.Length > 0)
                {
                    long backStep = fs.Position;

                    do
                    {
                        var dataObject = (DataObject)formatter.Deserialize(fs);

                        if (dataObject.PrimaryKey.Equals(deletedObject.PrimaryKey))
                        {
                            fs.Position = backStep;

                            dataObject.Deleted = true;
                            formatter.Serialize(fs, dataObject);

                        }

                        if (dataObject.Deleted)
                        {
                            deletedObjects++;
                        }
                        objectsCount++;

                        backStep = fs.Position;
                    } while (fs.Position != fs.Length);
                }
            }

            if (objectsCount / 2 <= deletedObjects)
            {
                string tempFileName = $"temp_{fileName}";
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                {
                    using (FileStream fs_temp = new FileStream(tempFileName, FileMode.Create))
                    {
                        while (fs.Position != fs.Length)
                        {
                            var dataObject = (DataObject)formatter.Deserialize(fs);

                            if (!dataObject.Deleted)
                            {
                                formatter.Serialize(fs_temp, dataObject);
                            }
                        }
                    }
                }

                File.Delete(fileName);
                File.Move(tempFileName, fileName);
            }
        }

        public IEnumerable<T> Query<T>(Func<T, bool> func) where T: DataObject
        {
            List<T> dataObjects = new List<T>();

            using (FileStream fs = new FileStream(GetFileName(typeof(T)), FileMode.OpenOrCreate))
            {
                if (fs.Length > 0)
                {
                    do
                    {
                        var dataObject = (T)formatter.Deserialize(fs);
                        if (!dataObject.Deleted && func(dataObject))
                        {
                            dataObjects.Add(dataObject);
                        }
                    } while (fs.Position != fs.Length);

                    fs.Close();
                }
            }

            return dataObjects;
        }
    }
}
