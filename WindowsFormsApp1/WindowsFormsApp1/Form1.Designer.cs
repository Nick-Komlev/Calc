namespace WindowsFormsApp1
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
            this.CurList1 = new System.Windows.Forms.ComboBox();
            this.CurList2 = new System.Windows.Forms.ComboBox();
            this.Value1 = new System.Windows.Forms.TextBox();
            this.Accept = new System.Windows.Forms.Button();
            this.Value2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CurList1
            // 
            this.CurList1.FormattingEnabled = true;
            this.CurList1.Location = new System.Drawing.Point(12, 12);
            this.CurList1.Name = "CurList1";
            this.CurList1.Size = new System.Drawing.Size(183, 21);
            this.CurList1.TabIndex = 0;
            this.CurList1.Text = "Австралийский доллар";
            // 
            // CurList2
            // 
            this.CurList2.FormattingEnabled = true;
            this.CurList2.Location = new System.Drawing.Point(237, 12);
            this.CurList2.Name = "CurList2";
            this.CurList2.Size = new System.Drawing.Size(183, 21);
            this.CurList2.TabIndex = 0;
            this.CurList2.Text = "Австралийский доллар";
            // 
            // Value1
            // 
            this.Value1.Location = new System.Drawing.Point(12, 39);
            this.Value1.Name = "Value1";
            this.Value1.Size = new System.Drawing.Size(183, 20);
            this.Value1.TabIndex = 1;
            this.Value1.Text = "0";
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(180, 76);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(75, 23);
            this.Accept.TabIndex = 2;
            this.Accept.Text = "Рассчитать";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // Value2
            // 
            this.Value2.AutoSize = true;
            this.Value2.Location = new System.Drawing.Point(234, 46);
            this.Value2.Name = "Value2";
            this.Value2.Size = new System.Drawing.Size(13, 13);
            this.Value2.TabIndex = 3;
            this.Value2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 111);
            this.Controls.Add(this.Value2);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.Value1);
            this.Controls.Add(this.CurList2);
            this.Controls.Add(this.CurList1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CurList1;
        private System.Windows.Forms.ComboBox CurList2;
        private System.Windows.Forms.TextBox Value1;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Label Value2;
    }
}

