using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1.MyPaint
{
    public partial class CanvasSize : Form
    {
        public int CanvasWidth
        {
            get
            {
                return int.Parse(widthInput.Text);
            }
            set
            {
                widthInput.Text = value.ToString();
            }
        }

        public int CanvasHeight
        {
            get
            {
                return int.Parse(heightInput.Text);
            }
            set
            {
                heightInput.Text = value.ToString();
            }
        }

        public CanvasSize()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
