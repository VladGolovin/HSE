namespace Library.Objects
{
    using System;

    [Serializable]
    public class Book: DataObject
    {
        public string Author { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public string PublishingHouse { get; set; }
    }
}
