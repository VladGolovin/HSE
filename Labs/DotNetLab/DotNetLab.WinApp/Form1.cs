using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using DotNetLab;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetLab.WinApp
{
    public partial class Form1 : Form
    {
        private Point[] points = new Point[3];

        private PointCollection genPoints = new PointCollection();

        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreatePoints_Click(object sender, EventArgs e)
        {
            points[0] = new Point(2, 2);

            points[1] = new Point3D(4, 3, 2);

            points[2] = new Point(5, 6);
        }

        private void btnSortPoints_Click(object sender, EventArgs e)
        {
            Array.Sort(points);
        }

        private void btnPrintPoints_Click(object sender, EventArgs e)
        {
            List<string> result = new List<string>();
            for (Int32 i = 0; i < points.Length; i++)
                result.Add(String.Format("Point {0}: {1}\n", i, points[i]));

            MessageBox.Show(String.Concat(result));
        }

        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            genPoints.Add(new Point(r.Next(0, 10), r.Next(0, 10)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (genPoints.Count > 0)
            {
                genPoints.Remove(genPoints[genPoints.Count - 1]);
            }
        }

        private void btnLoadPoint_Click(object sender, EventArgs e)
        {
            genPoints = PointCollection.Load();
        }

        private void btnSavePoint_Click(object sender, EventArgs e)
        {
            genPoints.Save();
        }

        private void btnOutArrayList_Click(object sender, EventArgs e)
        {
            List<string> result = new List<string>();
            for (Int32 i = 0; i < genPoints.Count; i++)
                result.Add(String.Format("Point {0}: {1}\n", i, genPoints[i]));

            MessageBox.Show(String.Concat(result));
        }
    }
}
