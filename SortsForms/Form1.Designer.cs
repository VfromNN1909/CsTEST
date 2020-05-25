namespace SortsForms
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
            this.textBoxNonSorted = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSorted = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonMergeSort = new System.Windows.Forms.RadioButton();
            this.radioButtonQuickSort = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonDescending = new System.Windows.Forms.RadioButton();
            this.radioButtonAscending = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNonSorted
            // 
            this.textBoxNonSorted.Location = new System.Drawing.Point(11, 44);
            this.textBoxNonSorted.Name = "textBoxNonSorted";
            this.textBoxNonSorted.Size = new System.Drawing.Size(378, 20);
            this.textBoxNonSorted.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Несортированный массив";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Отсортированный массив";
            // 
            // textBoxSorted
            // 
            this.textBoxSorted.Location = new System.Drawing.Point(11, 109);
            this.textBoxSorted.Name = "textBoxSorted";
            this.textBoxSorted.Size = new System.Drawing.Size(378, 20);
            this.textBoxSorted.TabIndex = 2;
            this.textBoxSorted.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonQuickSort);
            this.groupBox1.Controls.Add(this.radioButtonMergeSort);
            this.groupBox1.Location = new System.Drawing.Point(423, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите метод сортировки";
            // 
            // radioButtonMergeSort
            // 
            this.radioButtonMergeSort.AutoSize = true;
            this.radioButtonMergeSort.Location = new System.Drawing.Point(7, 29);
            this.radioButtonMergeSort.Name = "radioButtonMergeSort";
            this.radioButtonMergeSort.Size = new System.Drawing.Size(138, 17);
            this.radioButtonMergeSort.TabIndex = 0;
            this.radioButtonMergeSort.TabStop = true;
            this.radioButtonMergeSort.Text = "Сортировка слиянием";
            this.radioButtonMergeSort.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuickSort
            // 
            this.radioButtonQuickSort.AutoSize = true;
            this.radioButtonQuickSort.Location = new System.Drawing.Point(7, 53);
            this.radioButtonQuickSort.Name = "radioButtonQuickSort";
            this.radioButtonQuickSort.Size = new System.Drawing.Size(131, 17);
            this.radioButtonQuickSort.TabIndex = 1;
            this.radioButtonQuickSort.TabStop = true;
            this.radioButtonQuickSort.Text = "Быстрая сортировка";
            this.radioButtonQuickSort.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Отсортировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonDescending);
            this.groupBox2.Controls.Add(this.radioButtonAscending);
            this.groupBox2.Location = new System.Drawing.Point(598, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выберите порядок сортировки";
            // 
            // radioButtonDescending
            // 
            this.radioButtonDescending.AutoSize = true;
            this.radioButtonDescending.Location = new System.Drawing.Point(7, 53);
            this.radioButtonDescending.Name = "radioButtonDescending";
            this.radioButtonDescending.Size = new System.Drawing.Size(93, 17);
            this.radioButtonDescending.TabIndex = 1;
            this.radioButtonDescending.TabStop = true;
            this.radioButtonDescending.Text = "По убыванию";
            this.radioButtonDescending.UseVisualStyleBackColor = true;
            // 
            // radioButtonAscending
            // 
            this.radioButtonAscending.AutoSize = true;
            this.radioButtonAscending.Location = new System.Drawing.Point(7, 29);
            this.radioButtonAscending.Name = "radioButtonAscending";
            this.radioButtonAscending.Size = new System.Drawing.Size(109, 17);
            this.radioButtonAscending.TabIndex = 0;
            this.radioButtonAscending.TabStop = true;
            this.radioButtonAscending.Text = "По возрастанию";
            this.radioButtonAscending.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Больше рандома богу рандома";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 197);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSorted);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNonSorted);
            this.Name = "Form1";
            this.Text = "Контрольная работа Власов";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNonSorted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSorted;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonQuickSort;
        private System.Windows.Forms.RadioButton radioButtonMergeSort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonDescending;
        private System.Windows.Forms.RadioButton radioButtonAscending;
        private System.Windows.Forms.Button button2;
    }
}

