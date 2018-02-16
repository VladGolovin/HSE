namespace CustomComponentExample.CustomComponents
{    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class NumberTextbox : TextBox
    {
        public NumberTextbox()
        {
            InitializeComponent();
        }

        public NumberTextbox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            int n = 0;

            if (int.TryParse(Text, out n))
                ForeColor = System.Drawing.Color.Black;
            else
                ForeColor = System.Drawing.Color.Red;
        }
    }
}
