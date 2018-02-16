using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControlLab.Components
{
    public partial class ColorPickerParameter : TextBox
    {
        public ColorPickerParameter()
        {
            InitializeComponent();
        }

        public ColorPickerParameter(IContainer container)
        {
            container.Add(this);


            InitializeComponent();
        }
    }
}
