namespace Lab1.MyPaint
{
    using System;
    using System.Windows.Forms;

    public partial class StarSettingsEditor : Form
    {
        public StarSettings Settings { get; set; }

        public StarSettingsEditor()
        {
            InitializeComponent();

            Settings = new StarSettings();
        }

        public StarSettingsEditor(StarSettings starSettings)
        {
            InitializeComponent();

            Settings = starSettings;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            Settings.PointsCount = (int)PointsCountBox.Value;

            Settings.Radius = (int)RadiusBox.Value;

            Settings.Filled = FilledCheckBox.Checked;
        }
    }
}
