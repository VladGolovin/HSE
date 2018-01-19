namespace DotNetLab.WinApp
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
            this.btnCreatePoints = new System.Windows.Forms.Button();
            this.btnSortPoints = new System.Windows.Forms.Button();
            this.btnPrintPoints = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnOutArrayList = new System.Windows.Forms.Button();
            this.btnSavePoint = new System.Windows.Forms.Button();
            this.btnLoadPoint = new System.Windows.Forms.Button();
            this.btnDeletePoint = new System.Windows.Forms.Button();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreatePoints
            // 
            this.btnCreatePoints.Location = new System.Drawing.Point(6, 19);
            this.btnCreatePoints.Name = "btnCreatePoints";
            this.btnCreatePoints.Size = new System.Drawing.Size(190, 59);
            this.btnCreatePoints.TabIndex = 0;
            this.btnCreatePoints.Text = "Create Points";
            this.btnCreatePoints.UseVisualStyleBackColor = true;
            this.btnCreatePoints.Click += new System.EventHandler(this.btnCreatePoints_Click);
            // 
            // btnSortPoints
            // 
            this.btnSortPoints.Location = new System.Drawing.Point(6, 84);
            this.btnSortPoints.Name = "btnSortPoints";
            this.btnSortPoints.Size = new System.Drawing.Size(190, 59);
            this.btnSortPoints.TabIndex = 0;
            this.btnSortPoints.Text = "Sort Points";
            this.btnSortPoints.UseVisualStyleBackColor = true;
            this.btnSortPoints.Click += new System.EventHandler(this.btnSortPoints_Click);
            // 
            // btnPrintPoints
            // 
            this.btnPrintPoints.Location = new System.Drawing.Point(6, 149);
            this.btnPrintPoints.Name = "btnPrintPoints";
            this.btnPrintPoints.Size = new System.Drawing.Size(190, 59);
            this.btnPrintPoints.TabIndex = 0;
            this.btnPrintPoints.Text = "Print Points";
            this.btnPrintPoints.UseVisualStyleBackColor = true;
            this.btnPrintPoints.Click += new System.EventHandler(this.btnPrintPoints_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreatePoints);
            this.groupBox1.Controls.Add(this.btnPrintPoints);
            this.groupBox1.Controls.Add(this.btnSortPoints);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 343);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Статический массив";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChange);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnOutArrayList);
            this.groupBox2.Controls.Add(this.btnSavePoint);
            this.groupBox2.Controls.Add(this.btnLoadPoint);
            this.groupBox2.Controls.Add(this.btnDeletePoint);
            this.groupBox2.Controls.Add(this.btnAddPoint);
            this.groupBox2.Location = new System.Drawing.Point(226, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 343);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Коллекции";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(7, 60);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(170, 29);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton7);
            this.groupBox4.Controls.Add(this.radioButton4);
            this.groupBox4.Controls.Add(this.radioButton5);
            this.groupBox4.Controls.Add(this.radioButton6);
            this.groupBox4.Location = new System.Drawing.Point(183, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(189, 187);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Переключить источник данных";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton7.Location = new System.Drawing.Point(19, 128);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(153, 28);
            this.radioButton7.TabIndex = 2;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "PointCollection";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.pointCollection_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton4.Location = new System.Drawing.Point(19, 94);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(116, 28);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "StaticArray";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton5.Location = new System.Drawing.Point(19, 63);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(55, 28);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "List";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton6.Location = new System.Drawing.Point(19, 31);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(99, 28);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "ArrayList";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(183, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(189, 187);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Переключить источник данных";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(19, 99);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(116, 28);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "StaticArray";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(19, 65);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 28);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "List";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(19, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(99, 28);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ArrayList";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnOutArrayList
            // 
            this.btnOutArrayList.Location = new System.Drawing.Point(8, 213);
            this.btnOutArrayList.Name = "btnOutArrayList";
            this.btnOutArrayList.Size = new System.Drawing.Size(169, 36);
            this.btnOutArrayList.TabIndex = 1;
            this.btnOutArrayList.Text = "Вывести";
            this.btnOutArrayList.UseVisualStyleBackColor = true;
            this.btnOutArrayList.Click += new System.EventHandler(this.btnOutArrayList_Click);
            // 
            // btnSavePoint
            // 
            this.btnSavePoint.Location = new System.Drawing.Point(7, 170);
            this.btnSavePoint.Name = "btnSavePoint";
            this.btnSavePoint.Size = new System.Drawing.Size(170, 37);
            this.btnSavePoint.TabIndex = 0;
            this.btnSavePoint.Text = "Сохранить";
            this.btnSavePoint.UseVisualStyleBackColor = true;
            this.btnSavePoint.Click += new System.EventHandler(this.btnSavePoint_Click);
            // 
            // btnLoadPoint
            // 
            this.btnLoadPoint.Location = new System.Drawing.Point(7, 134);
            this.btnLoadPoint.Name = "btnLoadPoint";
            this.btnLoadPoint.Size = new System.Drawing.Size(170, 30);
            this.btnLoadPoint.TabIndex = 0;
            this.btnLoadPoint.Text = "Загрузить";
            this.btnLoadPoint.UseVisualStyleBackColor = true;
            this.btnLoadPoint.Click += new System.EventHandler(this.btnLoadPoint_Click);
            // 
            // btnDeletePoint
            // 
            this.btnDeletePoint.Location = new System.Drawing.Point(7, 98);
            this.btnDeletePoint.Name = "btnDeletePoint";
            this.btnDeletePoint.Size = new System.Drawing.Size(170, 30);
            this.btnDeletePoint.TabIndex = 0;
            this.btnDeletePoint.Text = "Удалить";
            this.btnDeletePoint.UseVisualStyleBackColor = true;
            this.btnDeletePoint.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Location = new System.Drawing.Point(7, 20);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(170, 33);
            this.btnAddPoint.TabIndex = 0;
            this.btnAddPoint.Text = "Добавить";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 364);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = ".Net Lab";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreatePoints;
        private System.Windows.Forms.Button btnSortPoints;
        private System.Windows.Forms.Button btnPrintPoints;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSavePoint;
        private System.Windows.Forms.Button btnLoadPoint;
        private System.Windows.Forms.Button btnDeletePoint;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.Button btnOutArrayList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Button btnChange;
    }
}

