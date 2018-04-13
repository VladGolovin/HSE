namespace CustomComponentExample
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.numberTextbox3 = new CustomComponentExample.CustomComponents.NumberTextbox(this.components);
            this.numberTextbox2 = new CustomComponentExample.CustomComponents.NumberTextbox(this.components);
            this.numberTextbox1 = new CustomComponentExample.CustomComponents.NumberTextbox(this.components);
            this.filePicker1 = new CustomComponentExample.CustomComponents.FilePicker();
            this.filePicker2 = new CustomComponentExample.CustomComponents.FilePicker();
            this.SuspendLayout();
            // 
            // numberTextbox3
            // 
            this.numberTextbox3.ForeColor = System.Drawing.Color.Red;
            this.numberTextbox3.Location = new System.Drawing.Point(12, 109);
            this.numberTextbox3.Name = "numberTextbox3";
            this.numberTextbox3.Size = new System.Drawing.Size(100, 20);
            this.numberTextbox3.TabIndex = 2;
            // 
            // numberTextbox2
            // 
            this.numberTextbox2.ForeColor = System.Drawing.Color.Red;
            this.numberTextbox2.Location = new System.Drawing.Point(12, 71);
            this.numberTextbox2.Name = "numberTextbox2";
            this.numberTextbox2.Size = new System.Drawing.Size(100, 20);
            this.numberTextbox2.TabIndex = 1;
            // 
            // numberTextbox1
            // 
            this.numberTextbox1.ForeColor = System.Drawing.Color.Red;
            this.numberTextbox1.Location = new System.Drawing.Point(12, 35);
            this.numberTextbox1.Name = "numberTextbox1";
            this.numberTextbox1.Size = new System.Drawing.Size(100, 20);
            this.numberTextbox1.TabIndex = 0;
            // 
            // filePicker1
            // 
            this.filePicker1.Location = new System.Drawing.Point(49, 276);
            this.filePicker1.Name = "filePicker1";
            this.filePicker1.Size = new System.Drawing.Size(255, 52);
            this.filePicker1.TabIndex = 3;
            // 
            // filePicker2
            // 
            this.filePicker2.Location = new System.Drawing.Point(37, 203);
            this.filePicker2.Name = "filePicker2";
            this.filePicker2.Size = new System.Drawing.Size(255, 52);
            this.filePicker2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 353);
            this.Controls.Add(this.filePicker2);
            this.Controls.Add(this.filePicker1);
            this.Controls.Add(this.numberTextbox3);
            this.Controls.Add(this.numberTextbox2);
            this.Controls.Add(this.numberTextbox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomComponents.NumberTextbox numberTextbox1;
        private CustomComponents.NumberTextbox numberTextbox2;
        private CustomComponents.NumberTextbox numberTextbox3;
        private CustomComponents.FilePicker filePicker1;
        private CustomComponents.FilePicker filePicker2;
    }
}

