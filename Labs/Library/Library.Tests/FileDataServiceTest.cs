using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Library.Tests
{
    using Objects;
    using DataService;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.IO;
    using System.Linq;

    [TestClass]
    public class FileDataServiceTest
    {
        FileDataService ds;

        public FileDataServiceTest()
        {
            ds = new FileDataService();
        }

        [TestMethod]
        public void LoadObjectsTest()
        {
            ClearDataSource();

            Book book = new Book();
            book.Author = "Л.Н. Толстой";
            book.Title = "Война и мир";
            book.PublishingHouse = "Фламинго";
            book.Year = 1867;

            Book book1 = new Book();
            book1.Author = "А. С. Пушкин";
            book1.Title = "Пиковая дама";
            book1.PublishingHouse = "Феникс";
            book1.Year = 1834;

            using (FileStream fs = new FileStream(ds.GetFileName(typeof(Book)), FileMode.Append))
            {
                var bf = new BinaryFormatter();
                bf.Serialize(fs, book);
                bf.Serialize(fs, book1);
                fs.Close();
            }

            var books = ds.LoadObjects<Book>();

            Assert.AreEqual(2, books.Count());
        }

        [TestMethod]
        public void InsertObjectTest()
        {
            ClearDataSource();

            Book book = new Book();
            book.Author = "Л.Н. Толстой";
            book.Title = "Война и мир";
            book.PublishingHouse = "Фламинго";
            book.Year = 1867;

            ds.InsertObject(book);

            using (FileStream fs = new FileStream(ds.GetFileName(typeof(Book)), FileMode.Open))
            {
                var bf = new BinaryFormatter();

                var bookFromFile = (Book)bf.Deserialize(fs);

                Assert.AreEqual(book, bookFromFile);
            }
        }

        [TestMethod]
        public void UpdateObjectTest()
        {
            ClearDataSource();

            Book book = new Book();
            book.Author = "Л.Н. Толстой";
            book.Title = "Война и мир";
            book.PublishingHouse = "Фламинго";
            book.Year = 1867;

            var bf = new BinaryFormatter();

            using (FileStream fs = new FileStream(ds.GetFileName(typeof(Book)), FileMode.Open))
            {
                bf.Serialize(fs, book);

                fs.Close();
            }

            book.Author = "А. С. Пушкин";

            ds.UpdateObject(book);

            using (FileStream fs = new FileStream(ds.GetFileName(typeof(Book)), FileMode.Open))
            {
                var updatedBook = (Book)bf.Deserialize(fs);

                fs.Close();

                Assert.AreEqual(book.Author, updatedBook.Author);
            }
        }

        [TestMethod]
        public void DeleteObjectTest()
        {
            ClearDataSource();

            Book book = new Book();
            book.Author = "Л.Н. Толстой";
            book.Title = "Война и мир";
            book.PublishingHouse = "Фламинго";
            book.Year = 1867;

            var bf = new BinaryFormatter();

            using (FileStream fs = new FileStream(ds.GetFileName(typeof(Book)), FileMode.Open))
            {
                bf.Serialize(fs, book);

                fs.Close();
            }

            ds.DeleteObject(book);

            using (FileStream fs = new FileStream(ds.GetFileName(typeof(Book)), FileMode.Open))
            {
                var deletedBook = (Book)bf.Deserialize(fs);

                fs.Close();

                Assert.AreEqual(true, deletedBook.Deleted);
            }
        }

        private void ClearDataSource()
        {
            File.Create(ds.GetFileName(typeof(Book))).Close();
        }
    }
}
