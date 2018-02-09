using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    using Objects;

    using DataService;

    using WinApp.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            bookDataSource.DataSource = DataServiceProvider.DataService.LoadObjects<Book>().Cast<Book>().ToList();
            BookGridView.DataSource = bookDataSource;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookE createForm = new BookE(true, new Book());

            createForm.ShowDialog();

            if (createForm.DialogResult == DialogResult.Cancel)
            {
                RefreshList();   
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in BookGridView.SelectedRows)
            {
                DataServiceProvider.DataService.DeleteObject((Book)row.DataBoundItem);
            }

            RefreshList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BookGridView.SelectedRows.Count == 1)
            {
                BookE createForm = new BookE(false, (Book)BookGridView.SelectedRows[0].DataBoundItem);

                createForm.ShowDialog();

                if (createForm.DialogResult == DialogResult.Cancel)
                {
                    RefreshList();
                }
            } 
        }

        private void RefreshList()
        {
            int startPeriod = int.TryParse(filterStartPeriod.Text, out startPeriod)
                ? startPeriod
                : int.MinValue;

            int endPeriod = int.TryParse(filterEndPeriod.Text, out endPeriod)
                ? endPeriod
                : int.MaxValue;

            string author = String.IsNullOrWhiteSpace(filterAuthor.Text) ? string.Empty : filterAuthor.Text;

            bookDataSource.DataSource = DataServiceProvider.DataService.Query<Book>(b => b.Year <= endPeriod && b.Year >= startPeriod && b.Author.Contains(author)).Cast<Book>().ToList();
            BookGridView.Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void BookGridView_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {

        }
    }
}
