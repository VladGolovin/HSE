using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControlLab.Components
{
    public partial class ColorPicker: UserControl
    {
        public ColorPicker()
        {
            InitializeComponent();

            DecCheck.Checked = true;

            redColorPickerParameter.ValueChanged += colorParameterChanged;
            greenColorPickerParameter.ValueChanged += colorParameterChanged;
            blueColorPickerParameter.ValueChanged += colorParameterChanged;
        }

        private void colorParameterChanged(object sender, EventArgs e)
        {
            ColorPalette.BackColor = Color.FromArgb(
                redColorPickerParameter.Value,
                greenColorPickerParameter.Value,
                blueColorPickerParameter.Value);
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void HexCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (HexCheck.Checked)
            {
                redColorPickerParameter.CurrentInputMode = tInputMode.Hex;
                blueColorPickerParameter.CurrentInputMode = tInputMode.Hex;
                greenColorPickerParameter.CurrentInputMode = tInputMode.Hex;
            }
        }

        private void DecCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (DecCheck.Checked)
            {
                redColorPickerParameter.CurrentInputMode = tInputMode.Dec;
                blueColorPickerParameter.CurrentInputMode = tInputMode.Dec;
                greenColorPickerParameter.CurrentInputMode = tInputMode.Dec;
            }
        }
    }
}
