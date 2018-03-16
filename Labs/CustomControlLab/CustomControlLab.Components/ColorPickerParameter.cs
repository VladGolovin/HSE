namespace CustomControlLab.Components
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Globalization;

    public partial class ColorPickerParameter : TextBox
    {
        private const string maxDecValue = "255";

        private const string minValue = "0";

        private const string maxHexValue = "FF";

        private tInputMode currentInputMode;

        public tInputMode CurrentInputMode
        {
            get { return currentInputMode; }
            set
            {
                if (currentInputMode != value)
                {
                    currentInputMode = value;

                    switch (value)
                    {
                        case tInputMode.Hex:
                            if (!string.IsNullOrEmpty(Text))
                                Text = Int32.Parse(Text).ToString("X");
                            MaxLength = 6;
                            break;
                        case tInputMode.Dec:
                            if (!string.IsNullOrEmpty(Text))
                            {
                                int current = Int32.Parse(Text, NumberStyles.HexNumber);
                                Text = current > 255 ? 255.ToString() : current.ToString();
                            }
                            MaxLength = 3;
                            break;
                        default:
                            break;
                    }
                }

            }
        }

        public int Value
        {
            get
            {
                return currentInputMode == tInputMode.Dec ? Int32.Parse(Text) : Int32.Parse(Text, NumberStyles.HexNumber);
            }
            set
            {
                Text = currentInputMode == tInputMode.Dec ? value.ToString() : value.ToString("X");
            }
        }

        public event EventHandler ValueChanged;

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            switch (CurrentInputMode)
            {
                case tInputMode.Hex:
                    if (e.KeyChar != 8 &&                           // не Backspace
                        !((e.KeyChar >= 48 && e.KeyChar <= 57)      // 0 - 9
                        || (e.KeyChar >= 65 && e.KeyChar <= 70)     // A - F
                        || (e.KeyChar >= 97 && e.KeyChar <= 102)))  // a - f
                        e.Handled = true;
                    break;
                case tInputMode.Dec:
                default:
                    if (e.KeyChar != 8 &&                           // не Backspace
                        !char.IsDigit(e.KeyChar))
                        e.Handled = true;
                    break;
            }


            base.OnKeyPress(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            switch (currentInputMode)
            {
                case tInputMode.Hex:
                    int hexValue = Int32.Parse(Text, NumberStyles.HexNumber);

                    if (hexValue > 255)
                        Text = maxHexValue;
                    if (hexValue < 0)
                        Text = minValue;
                    break;
                case tInputMode.Dec:
                default:
                    int decValue = Int32.Parse(Text);

                    if (decValue > 255)
                        Text = maxDecValue;
                    if (decValue < 0)
                        Text = minValue;
                    break;
            }

            ValueChanged?.Invoke(this, e);
        }

        public ColorPickerParameter()
        {
            InitializeComponent();

            SetDefautlProperties();
        }

        public ColorPickerParameter(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            SetDefautlProperties();
        }

        private void SetDefautlProperties()
        {
            CurrentInputMode = tInputMode.Dec;

            Text = "0";
        }
    }
}
