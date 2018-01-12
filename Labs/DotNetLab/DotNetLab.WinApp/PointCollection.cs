using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace DotNetLab.WinApp
{
    [Serializable()]
    public class PointCollection: System.Collections.CollectionBase
    {
        public Point Add()
        {
            Point Item = new Point();
            List.Add(Item);
            return Item;
        }

        public Point Add(Point Item)
        {
            List.Add(Item);
            return Item;
        }

        public void Insert(int Index, Point Item)
        {
            List.Insert(Index, Item);
        }

        public void Remove(Point Item)
        {
            List.Remove(Item);
        }

        public Point this[int Index]
        {
            get
            {
                return (Point)List[Index];
            }
        }

        public void Save()
        {
            SaveFileDialog svfDialog = new SaveFileDialog();
            svfDialog.Filter = "Point file (*.pf)|*.pf";
            svfDialog.DefaultExt = "pf";
            if (svfDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fStream = null;
                SoapFormatter mySoapFormatter = new SoapFormatter();

                try
                {
                    fStream = new FileStream(svfDialog.FileName,
                        FileMode.Create, FileAccess.Write);
                    mySoapFormatter.Serialize(fStream, this);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    if (fStream != null) fStream.Close();
                }
            }
        }

        public static PointCollection Load()
        {
            FileStream fStream = null;
            PointCollection mc;
            SoapFormatter mySoapFormatter = new SoapFormatter();
            OpenFileDialog opfDialog = new OpenFileDialog();
            opfDialog.Filter = "Point file (*.pf)|*pf";

            if (opfDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fStream = new FileStream(opfDialog.FileName, FileMode.Open, FileAccess.Read);
                    mc = (PointCollection)mySoapFormatter.Deserialize(fStream);
                    return mc;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    if (fStream != null) fStream.Close();
                }
            }
            return null;
        }
    }
}
