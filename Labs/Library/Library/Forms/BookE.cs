using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.WinApp.Forms
{
    using DataService;
    using Objects;

    public partial class BookE : Form
    {
        public bool IsNew { get; set; }

        private Book book { get; set; }

        public BookE()
        {
            InitializeComponent();
        }

        public BookE(bool isNew, Book book)
        {
            InitializeComponent();

            IsNew = isNew;

            this.book = book;

            txtTitle.Text = book.Title;
            txtAuthor.Text = book.Author;
            txtYear.Text = book.Year.ToString();
            txtPublishingHouse.Text = book.PublishingHouse;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            book.Title = txtTitle.Text;
            book.Author = txtAuthor.Text;
            book.PublishingHouse = txtPublishingHouse.Text;
            book.Year = int.Parse(txtYear.Text);

            if (IsNew)
            {
                DataServiceProvider.DataService.InsertObject(book);
            }
            else
            {
                DataServiceProvider.DataService.UpdateObject(book);
            }

            IsNew = false;

            Close();
        }
    }
}
