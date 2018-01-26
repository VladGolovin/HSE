using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataService
{
    using System.IO;
    using System.Runtime.Serialization;

    using Objects;
    using System.Runtime.Serialization.Formatters.Binary;

    public class FileDataService
    {
        private string connectionString;

        private IFormatter formatter;

        public FileDataService()
        {
            this.connectionString = "\base.data";
            this.formatter = new BinaryFormatter();
        }

        public FileDataService(string connectionString, IFormatter formatter)
        {
            this.connectionString = connectionString;
            this.formatter = formatter;
        }

        public IEnumerable<DataObject> LoadObjects()
        {
            FileStream fs = new FileStream(connectionString, FileMode.Open);

            List<DataObject> dataObjects = new List<DataObject>();

            DataObject dataObject = (DataObject)formatter.Deserialize(fs);

            while(dataObject != null)
            {
                dataObjects.Add(dataObject);

                dataObject = (DataObject)formatter.Deserialize(fs);
            }

            fs.Close();

            return dataObjects;
        }

        public void InsertObject(DataObject insertObject)
        {
            FileStream fs = new FileStream(connectionString, FileMode.Append);

            formatter.Serialize(fs, insertObject);          

            fs.Close();
        }

        public void UpdateObject(DataObject updatedObject)
        {
            FileStream fs = new FileStream(connectionString, FileMode.Open);

            DataObject dataObject = (DataObject)formatter.Deserialize(fs);

            while (dataObject != null)
            {
                dataObject = (DataObject)formatter.Deserialize(fs);

                if (dataObject.PrimaryKey.Equals(updatedObject.PrimaryKey))
                {
                    formatter.Serialize(fs, updatedObject);
                }
            }

            fs.Close();
        }

        public void DeleteObject(DataObject deletedObject)
        {
            FileStream fs = new FileStream(connectionString, FileMode.Open);

            DataObject dataObject = (DataObject)formatter.Deserialize(fs);

            while (dataObject != null)
            {
                dataObject = (DataObject)formatter.Deserialize(fs);

                if (dataObject.PrimaryKey.Equals(deletedObject.PrimaryKey))
                {
                    dataObject.Deleted = true;
                    formatter.Serialize(fs, dataObject);
                }
            }

            fs.Close();
        }
    }
}
