using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomComponentExample.CustomComponents
{
    public partial class FilePicker : UserControl
    {
        public string FilePath
        {
            get
            {
                return FilePathText.Text;
            }
            set
            {
                FilePathText.Text = value;
            }
        }
        public FilePicker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FilePathText.Text = openFileDialog1.FileName;
            }
            
        }
    }
}
