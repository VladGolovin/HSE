using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Objects
{
    public abstract class DataObject
    {
        private Guid primaryKey;

        private bool deleted;

        public Guid PrimaryKey
        {
            get
            {
                return primaryKey;
            }
        }

        public bool Deleted
        {
            get
            {
                return this.deleted;
            }
            set
            {
                this.deleted = value;
            }
        }

        public DataObject()
        {
            this.primaryKey = new Guid();
            this.deleted = false;
        }
    }
}
