using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using DotNetLab;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace DotNetLab.WinApp
{
    public partial class Form1 : Form
    {
        private Point[] points = new Point[3];

        private PointCollection pointCollection = new PointCollection();

        private List<Point> listPoints = new List<Point>();

        private ArrayList arrayListPoints = new ArrayList();

        private Type currentDataSourceType;

        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
            
            currentDataSourceType = typeof(PointCollection);
            radioButton7.Checked = true;
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
            Point point = new Point(r.Next(0, 10), r.Next(0, 10));

            if (currentDataSourceType == typeof(PointCollection))
            {
                pointCollection.Add(point);
            } 
            else if (currentDataSourceType == typeof(ArrayList))
            {
                arrayListPoints.Add(point);
            }
            else if (currentDataSourceType == typeof(List<Point>))
            {
                listPoints.Add(point);
            } 
            else if (currentDataSourceType == typeof(Point[]))
            {
                int newArrayLength = points.Length;

                Point[] temp = new Point[newArrayLength];

                for (int i = 0; i < newArrayLength - 1; i++)
                {
                    temp[i] = points[i];
                }

                temp[newArrayLength - 1] = point;

                points = temp;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentDataSourceType == typeof(PointCollection))
            {
                pointCollection.Remove(pointCollection[pointCollection.Count - 1]);
            }
            else if (currentDataSourceType == typeof(ArrayList))
            {
                arrayListPoints.Remove(arrayListPoints[arrayListPoints.Count - 1]);
            }
            else if (currentDataSourceType == typeof(List<Point>))
            {
                listPoints.Remove(listPoints[listPoints.Count - 1]);
            }
            else if (currentDataSourceType == typeof(Point[]))
            {
                int newArrayLength = points.Length - 1;

                Point[] temp = new Point[newArrayLength];

                for (int i = 0; i < newArrayLength; i++)
                {
                    temp[i] = points[i];
                }

                points = temp;
            }
        }

        private void btnLoadPoint_Click(object sender, EventArgs e)
        {
            if (currentDataSourceType == typeof(PointCollection))
            {
                pointCollection = PointCollection.Load();
            }
        }

        private void btnSavePoint_Click(object sender, EventArgs e)
        {
            if (currentDataSourceType == typeof(PointCollection))
            {
                pointCollection.Save();
            }
        }

        private void btnOutArrayList_Click(object sender, EventArgs e)
        {
            List<string> result = new List<string>();

            result.Add($"{currentDataSourceType.Name}:\n");

            if (currentDataSourceType == typeof(PointCollection))
            {
                for (Int32 i = 0; i < pointCollection.Count; i++)
                    result.Add(String.Format("Point {0}: {1}\n", i, pointCollection[i]));
            }
            else if (currentDataSourceType == typeof(ArrayList))
            {
                for (Int32 i = 0; i < arrayListPoints.Count; i++)
                    result.Add(String.Format("Point {0}: {1}\n", i, arrayListPoints[i]));
            }
            else if (currentDataSourceType == typeof(List<Point>))
            {
                for (Int32 i = 0; i < listPoints.Count; i++)
                    result.Add(String.Format("Point {0}: {1}\n", i, listPoints[i]));
            }
            else if (currentDataSourceType == typeof(Point[]))
            {
                for (Int32 i = 0; i < points.Length; i++)
                    result.Add(String.Format("Point {0}: {1}\n", i, points[i]));
            }

            MessageBox.Show(String.Concat(result));
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                currentDataSourceType = typeof(ArrayList);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                currentDataSourceType = typeof(Point[]);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                currentDataSourceType = typeof(List<Point>);
            }
        }

        private void pointCollection_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                currentDataSourceType = typeof(PointCollection);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (currentDataSourceType == typeof(PointCollection))
            {
                pointCollection[pointCollection.Count - 1].y = r.Next(0, 10);
            }
            else if (currentDataSourceType == typeof(ArrayList))
            {
                ((Point)arrayListPoints[arrayListPoints.Count - 1]).y = r.Next(0, 10);
            }
            else if (currentDataSourceType == typeof(List<Point>))
            {
                listPoints[listPoints.Count - 1].y = r.Next(0, 10);
            }
            else if (currentDataSourceType == typeof(Point[]))
            {
                points[points.Length - 1].y = r.Next(0, 10);
            }
        }
    }
}
