namespace Lab1.MyPaint
{
    partial class StarSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FilledCheckBox = new System.Windows.Forms.CheckBox();
            this.OkBtn = new System.Windows.Forms.Button();
            this.RadiusBox = new System.Windows.Forms.NumericUpDown();
            this.PointsCountBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointsCountBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Радиус:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество вершин:";
            // 
            // FilledCheckBox
            // 
            this.FilledCheckBox.AutoSize = true;
            this.FilledCheckBox.Location = new System.Drawing.Point(12, 107);
            this.FilledCheckBox.Name = "FilledCheckBox";
            this.FilledCheckBox.Size = new System.Drawing.Size(95, 17);
            this.FilledCheckBox.TabIndex = 4;
            this.FilledCheckBox.Text = "Закрашенная";
            this.FilledCheckBox.UseVisualStyleBackColor = true;
            // 
            // OkBtn
            // 
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(32, 130);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 5;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // RadiusBox
            // 
            this.RadiusBox.Location = new System.Drawing.Point(12, 42);
            this.RadiusBox.Name = "RadiusBox";
            this.RadiusBox.Size = new System.Drawing.Size(120, 20);
            this.RadiusBox.TabIndex = 6;
            // 
            // PointsCountBox
            // 
            this.PointsCountBox.Location = new System.Drawing.Point(12, 81);
            this.PointsCountBox.Name = "PointsCountBox";
            this.PointsCountBox.Size = new System.Drawing.Size(120, 20);
            this.PointsCountBox.TabIndex = 7;
            // 
            // StarSettings
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(146, 182);
            this.Controls.Add(this.PointsCountBox);
            this.Controls.Add(this.RadiusBox);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.FilledCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StarSettings";
            ((System.ComponentModel.ISupportInitialize)(this.RadiusBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointsCountBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox FilledCheckBox;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.NumericUpDown RadiusBox;
        private System.Windows.Forms.NumericUpDown PointsCountBox;
    }
}