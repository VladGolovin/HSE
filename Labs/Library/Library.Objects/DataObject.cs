using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Library.Objects
{
    using System.Reflection;

    [Serializable]
    public abstract class DataObject
    {
        public Guid PrimaryKey { get; }

        public bool Deleted { get; set; }

        public DataObject()
        {
            PrimaryKey = Guid.NewGuid();
            Deleted = false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return JsonConvert.SerializeObject(obj).Equals(JsonConvert.SerializeObject(this));
        }
    }
}
