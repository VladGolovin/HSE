namespace CustomControlLab.Components
{
    partial class ColorPicker
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.redColorPickerParameter = new CustomControlLab.Components.ColorPickerParameter(this.components);
            this.greenColorPickerParameter = new CustomControlLab.Components.ColorPickerParameter(this.components);
            this.blueColorPickerParameter = new CustomControlLab.Components.ColorPickerParameter(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DecCheck = new System.Windows.Forms.RadioButton();
            this.HexCheck = new System.Windows.Forms.RadioButton();
            this.ColorPalette = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // redColorPickerParameter
            // 
            this.redColorPickerParameter.Location = new System.Drawing.Point(65, 15);
            this.redColorPickerParameter.Name = "redColorPickerParameter";
            this.redColorPickerParameter.Size = new System.Drawing.Size(78, 20);
            this.redColorPickerParameter.TabIndex = 0;
            this.redColorPickerParameter.TextChanged += new System.EventHandler(this.colorChanged);
            // 
            // greenColorPickerParameter
            // 
            this.greenColorPickerParameter.Location = new System.Drawing.Point(65, 42);
            this.greenColorPickerParameter.Name = "greenColorPickerParameter";
            this.greenColorPickerParameter.Size = new System.Drawing.Size(78, 20);
            this.greenColorPickerParameter.TabIndex = 1;
            this.greenColorPickerParameter.TextChanged += new System.EventHandler(this.colorChanged);
            // 
            // blueColorPickerParameter
            // 
            this.blueColorPickerParameter.Location = new System.Drawing.Point(65, 69);
            this.blueColorPickerParameter.Name = "blueColorPickerParameter";
            this.blueColorPickerParameter.Size = new System.Drawing.Size(78, 20);
            this.blueColorPickerParameter.TabIndex = 2;
            this.blueColorPickerParameter.TextChanged += new System.EventHandler(this.colorChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Красный:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Зелёный:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Синий:";
            // 
            // DecCheck
            // 
            this.DecCheck.AutoSize = true;
            this.DecCheck.Location = new System.Drawing.Point(8, 117);
            this.DecCheck.Name = "DecCheck";
            this.DecCheck.Size = new System.Drawing.Size(45, 17);
            this.DecCheck.TabIndex = 7;
            this.DecCheck.TabStop = true;
            this.DecCheck.Text = "Dec";
            this.DecCheck.UseVisualStyleBackColor = true;
            // 
            // HexCheck
            // 
            this.HexCheck.AutoSize = true;
            this.HexCheck.Location = new System.Drawing.Point(65, 117);
            this.HexCheck.Name = "HexCheck";
            this.HexCheck.Size = new System.Drawing.Size(44, 17);
            this.HexCheck.TabIndex = 8;
            this.HexCheck.TabStop = true;
            this.HexCheck.Text = "Hex";
            this.HexCheck.UseVisualStyleBackColor = true;
            // 
            // ColorPalette
            // 
            this.ColorPalette.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.ColorPalette.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ColorPalette.Location = new System.Drawing.Point(158, 14);
            this.ColorPalette.Name = "ColorPalette";
            this.ColorPalette.Size = new System.Drawing.Size(120, 120);
            this.ColorPalette.TabIndex = 9;
            this.ColorPalette.Text = "label4";
            this.ColorPalette.Click += new System.EventHandler(this.label4_Click);
            // 
            // ColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ColorPalette);
            this.Controls.Add(this.HexCheck);
            this.Controls.Add(this.DecCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blueColorPickerParameter);
            this.Controls.Add(this.greenColorPickerParameter);
            this.Controls.Add(this.redColorPickerParameter);
            this.Name = "ColorPicker";
            this.Size = new System.Drawing.Size(293, 149);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColorPickerParameter redColorPickerParameter;
        private ColorPickerParameter greenColorPickerParameter;
        private ColorPickerParameter blueColorPickerParameter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton DecCheck;
        private System.Windows.Forms.RadioButton HexCheck;
        private System.Windows.Forms.Label ColorPalette;
    }
}
