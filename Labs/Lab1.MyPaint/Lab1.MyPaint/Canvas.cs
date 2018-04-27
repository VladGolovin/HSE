using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1.MyPaint
{
    public partial class Canvas : Form
    {
        private int oldX;

        private int oldY;

        private Bitmap bmp;

        private string FileName;

        private ImageFormat ImageFormat;

        private bool HasChanges;

        public StarSettings StarSettings = new StarSettings();

        public CanvasTool CurrentTool { get; set; }

        public int CanvasWidth
        {
            get
            {
                return pictureBox1.Width;
            }
            set
            {
                pictureBox1.Width = value;
                Bitmap tbmp = new Bitmap(value, pictureBox1.Height);
                Graphics g = Graphics.FromImage(tbmp);
                g.Clear(Color.White);
                g.DrawImage(bmp, new Point(0, 0));
                bmp = tbmp;
                pictureBox1.Image = bmp;
            }
        }

        public int CanvasHeight
        {
            get
            {
                return pictureBox1.Height;
            }
            set
            {
                pictureBox1.Height = value;
                Bitmap tbmp = new Bitmap(pictureBox1.Width, value);
                Graphics g = Graphics.FromImage(tbmp);
                g.Clear(Color.White);
                g.DrawImage(bmp, new Point(0, 0));
                bmp = tbmp;
                pictureBox1.Image = bmp;
            }
        }

        public void Save()
        {
            if (string.IsNullOrEmpty(FileName))
                SaveAs();
            else
                bmp.Save(FileName, ImageFormat);

            HasChanges = false;
        }

        public void SaveAs()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.AddExtension = true;
            dlg.Filter = "Windows Bitmap (*.bmp) | *.bmp | Файлы JPEG (*.jpg) | *.jpg";

            ImageFormat[] ff = { ImageFormat.Bmp, ImageFormat.Jpeg };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FileName = dlg.FileName;
                ImageFormat = ff[dlg.FilterIndex - 1];

                bmp.Save(FileName, ImageFormat);             
            }

            HasChanges = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (CurrentTool == CanvasTool.Pen && e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(bmp);
                g.DrawLine(new Pen(MainForm.CurColor, MainForm.CurWidth), oldX, oldY, e.X, e.Y);
                oldX = e.X;
                oldY = e.Y;

                pictureBox1.Invalidate();

                HasChanges = true;
            }
        }
        
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            oldX = e.X;
            oldY = e.Y;
        }

        public Canvas()
        {
            InitializeComponent();

            bmp = new Bitmap(ClientSize.Width, ClientSize.Height);
            pictureBox1.Image = bmp;

            CurrentTool = CanvasTool.Pen;

            //HasChanges = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (CurrentTool == CanvasTool.Star)
            {
                Graphics g = Graphics.FromImage(bmp);

                g.DrawStar(new Pen(MainForm.CurColor, MainForm.CurWidth), StarSettings.PointsCount, StarSettings.Radius, ((MouseEventArgs)e).X, ((MouseEventArgs)e).Y, StarSettings.Filled);

                pictureBox1.Invalidate();

                //HasChanges = true;
            }
        }

        public Canvas(String FileName, ImageFormat format)
        {
            InitializeComponent();
            bmp = new Bitmap(FileName);
            Graphics g = Graphics.FromImage(bmp);
            pictureBox1.Width = bmp.Width;
            pictureBox1.Height = bmp.Height;
            pictureBox1.Image = bmp;

            this.FileName = FileName;
            ImageFormat = format;

            HasChanges = false;
        }

        public enum CanvasTool
        {
            Pen,
            Star
        }

        private void Canvas_Load(object sender, EventArgs e)
        {

        }

        private void Canvas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (HasChanges)
            {
                var closeResult = MessageBox.Show("Сохранить эских перед закрытием?", "Закрытие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                switch (closeResult)
                {
                    case DialogResult.None:
                        break;
                    case DialogResult.OK:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    case DialogResult.Abort:
                        break;
                    case DialogResult.Retry:
                        break;
                    case DialogResult.Ignore:
                        break;
                    case DialogResult.Yes:
                        Save();
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }
       
        }

        private void pictureBox1_BackgroundImageLayoutChanged(object sender, EventArgs e)
        {
            HasChanges = true;
        }
    }
}
