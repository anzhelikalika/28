namespace WindowsFormsApp1
{
    partial class Form1
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
            this.bSubmitForm = new System.Windows.Forms.Button();
            this.tbCreditAmount = new System.Windows.Forms.TextBox();
            this.tbCreditPeriod = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bSelect = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bSubmitForm
            // 
            this.bSubmitForm.Location = new System.Drawing.Point(12, 174);
            this.bSubmitForm.Margin = new System.Windows.Forms.Padding(4);
            this.bSubmitForm.Name = "bSubmitForm";
            this.bSubmitForm.Size = new System.Drawing.Size(132, 46);
            this.bSubmitForm.TabIndex = 0;
            this.bSubmitForm.Text = "Подобрать";
            this.bSubmitForm.UseVisualStyleBackColor = true;
            this.bSubmitForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbCreditAmount
            // 
            this.tbCreditAmount.Location = new System.Drawing.Point(13, 43);
            this.tbCreditAmount.Margin = new System.Windows.Forms.Padding(4);
            this.tbCreditAmount.Name = "tbCreditAmount";
            this.tbCreditAmount.Size = new System.Drawing.Size(131, 22);
            this.tbCreditAmount.TabIndex = 1;
            this.tbCreditAmount.Tag = "";
            // 
            // tbCreditPeriod
            // 
            this.tbCreditPeriod.Location = new System.Drawing.Point(13, 88);
            this.tbCreditPeriod.Margin = new System.Windows.Forms.Padding(4);
            this.tbCreditPeriod.Name = "tbCreditPeriod";
            this.tbCreditPeriod.Size = new System.Drawing.Size(131, 22);
            this.tbCreditPeriod.TabIndex = 2;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(13, 132);
            this.tbAge.Margin = new System.Windows.Forms.Padding(4);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(131, 22);
            this.tbAge.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(153, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Сумма кредита";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(153, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Срок кредита  (лет)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(153, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ваш возраст";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(378, 13);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(665, 468);
            this.listBox1.TabIndex = 12;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bSelect);
            this.panel1.Controls.Add(this.bSubmitForm);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbCreditAmount);
            this.panel1.Controls.Add(this.tbCreditPeriod);
            this.panel1.Controls.Add(this.tbAge);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 554);
            this.panel1.TabIndex = 13;
            // 
            // bSelect
            // 
            this.bSelect.Location = new System.Drawing.Point(921, 498);
            this.bSelect.Name = "bSelect";
            this.bSelect.Size = new System.Drawing.Size(122, 44);
            this.bSelect.TabIndex = 13;
            this.bSelect.Text = "Выбрать";
            this.bSelect.UseVisualStyleBackColor = true;
            this.bSelect.Click += new System.EventHandler(this.bSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ListBox listBox1;

        private System.Windows.Forms.Button bSubmitForm;


        public System.Windows.Forms.TextBox tbAge;

        private System.Windows.Forms.CheckBox TextBox;

        public System.Windows.Forms.TextBox tbCreditPeriod;

        public System.Windows.Forms.TextBox tbCreditAmount;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bSelect;
    }
}
