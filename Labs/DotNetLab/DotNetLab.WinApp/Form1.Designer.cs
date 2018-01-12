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
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.btnDeletePoint = new System.Windows.Forms.Button();
            this.btnLoadPoint = new System.Windows.Forms.Button();
            this.btnSavePoint = new System.Windows.Forms.Button();
            this.btnOutArrayList = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox2.Controls.Add(this.btnOutArrayList);
            this.groupBox2.Controls.Add(this.btnSavePoint);
            this.groupBox2.Controls.Add(this.btnLoadPoint);
            this.groupBox2.Controls.Add(this.btnDeletePoint);
            this.groupBox2.Controls.Add(this.btnAddPoint);
            this.groupBox2.Location = new System.Drawing.Point(227, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 343);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ArrayList";
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Location = new System.Drawing.Point(7, 20);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(170, 58);
            this.btnAddPoint.TabIndex = 0;
            this.btnAddPoint.Text = "Добавить";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            // 
            // btnDeletePoint
            // 
            this.btnDeletePoint.Location = new System.Drawing.Point(7, 85);
            this.btnDeletePoint.Name = "btnDeletePoint";
            this.btnDeletePoint.Size = new System.Drawing.Size(170, 58);
            this.btnDeletePoint.TabIndex = 0;
            this.btnDeletePoint.Text = "Удалить";
            this.btnDeletePoint.UseVisualStyleBackColor = true;
            this.btnDeletePoint.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLoadPoint
            // 
            this.btnLoadPoint.Location = new System.Drawing.Point(7, 149);
            this.btnLoadPoint.Name = "btnLoadPoint";
            this.btnLoadPoint.Size = new System.Drawing.Size(170, 58);
            this.btnLoadPoint.TabIndex = 0;
            this.btnLoadPoint.Text = "Загрузить";
            this.btnLoadPoint.UseVisualStyleBackColor = true;
            this.btnLoadPoint.Click += new System.EventHandler(this.btnLoadPoint_Click);
            // 
            // btnSavePoint
            // 
            this.btnSavePoint.Location = new System.Drawing.Point(8, 213);
            this.btnSavePoint.Name = "btnSavePoint";
            this.btnSavePoint.Size = new System.Drawing.Size(170, 58);
            this.btnSavePoint.TabIndex = 0;
            this.btnSavePoint.Text = "Сохранить";
            this.btnSavePoint.UseVisualStyleBackColor = true;
            this.btnSavePoint.Click += new System.EventHandler(this.btnSavePoint_Click);
            // 
            // btnOutArrayList
            // 
            this.btnOutArrayList.Location = new System.Drawing.Point(8, 277);
            this.btnOutArrayList.Name = "btnOutArrayList";
            this.btnOutArrayList.Size = new System.Drawing.Size(169, 58);
            this.btnOutArrayList.TabIndex = 1;
            this.btnOutArrayList.Text = "Вывести";
            this.btnOutArrayList.UseVisualStyleBackColor = true;
            this.btnOutArrayList.Click += new System.EventHandler(this.btnOutArrayList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 361);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = ".Net Lab";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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
    }
}

