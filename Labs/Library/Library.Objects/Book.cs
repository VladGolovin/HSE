namespace Library.Objects
{
    using System;

    [Serializable]
    public class Book: DataObject
    {
        private string author;

        private string name;

        private int year;

        private string publishingHouse;

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                this.author = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                this.year = value;
            }
        }

        public string PublishingHouse
        {
            get
            {
                return publishingHouse;
            }
            set
            {
                this.publishingHouse = value;
            }
        }
    }
}
