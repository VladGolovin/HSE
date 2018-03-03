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
        private string decimalPattern => "\b[0-9]{3}\b";

        private string hexPattern => "\b[0-9A-Fa-f]{6}\b";

        public tInputMode CurrentInputMode
        {
            get
            {
                return CurrentInputMode;
            }
            set
            {
                CurrentInputMode = value;

                bool isDecimal = Regex.IsMatch(Text, decimalPattern);

                switch (value)
                {
                    case tInputMode.Hex:
                        if (!string.IsNullOrEmpty(Text))
                        {
                            Text = Int32.Parse(Text, NumberStyles.HexNumber).ToString();
                        }
                        break;
                    case tInputMode.Dec:
                    default:
                        break;
                }
            }
        }

        public ColorPickerParameter()
        {
            InitializeComponent();
        }

        public ColorPickerParameter(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            try
            {
                switch (CurrentInputMode)
                {   
                    case tInputMode.Hex:
                        Int32.Parse(Text, NumberStyles.HexNumber);
                        break;
                    case tInputMode.Dec:
                    default:
                        Int32.Parse(Text);
                        break;
                }

                StateNormal();
            }
            catch (FormatException)
            {
                StateError();
            }

            base.OnTextChanged(e);
        }

        private void StateNormal()
        {
            this.BackColor = System.Drawing.Color.Blue;
        }

        private void StateError()
        {
            this.BackColor = System.Drawing.Color.Red;
        }
    }
}
