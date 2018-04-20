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
    public partial class StarSettings : Form
    {
        public int PointsCount { get; set; }

        public int Radius { get; set; }

        public bool Filled { get; set; }

        public StarSettings()
        {
            InitializeComponent();

            RadiusBox.Maximum = 1000;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            PointsCount = (int)PointsCountBox.Value;

            Radius = (int)RadiusBox.Value;

            Filled = FilledCheckBox.Checked;
        }
    }
}
