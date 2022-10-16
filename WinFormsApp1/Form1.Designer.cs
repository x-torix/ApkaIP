namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ipa1 = new System.Windows.Forms.TextBox();
            this.ipa2 = new System.Windows.Forms.TextBox();
            this.ipa3 = new System.Windows.Forms.TextBox();
            this.ipa4 = new System.Windows.Forms.TextBox();
            this.mask1 = new System.Windows.Forms.TextBox();
            this.mask2 = new System.Windows.Forms.TextBox();
            this.mask3 = new System.Windows.Forms.TextBox();
            this.mask4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CheckClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adres IP: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Maska: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "sprawdź IP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CheckIP);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Czy IP poprawne: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(90, 23);
            this.textBox1.TabIndex = 9;
            // 
            // ipa1
            // 
            this.ipa1.Location = new System.Drawing.Point(114, 5);
            this.ipa1.Name = "ipa1";
            this.ipa1.Size = new System.Drawing.Size(31, 23);
            this.ipa1.TabIndex = 10;
            // 
            // ipa2
            // 
            this.ipa2.Location = new System.Drawing.Point(151, 5);
            this.ipa2.Name = "ipa2";
            this.ipa2.Size = new System.Drawing.Size(31, 23);
            this.ipa2.TabIndex = 11;
            // 
            // ipa3
            // 
            this.ipa3.Location = new System.Drawing.Point(188, 5);
            this.ipa3.Name = "ipa3";
            this.ipa3.Size = new System.Drawing.Size(30, 23);
            this.ipa3.TabIndex = 12;
            // 
            // ipa4
            // 
            this.ipa4.Location = new System.Drawing.Point(224, 5);
            this.ipa4.Name = "ipa4";
            this.ipa4.Size = new System.Drawing.Size(29, 23);
            this.ipa4.TabIndex = 13;
            // 
            // mask1
            // 
            this.mask1.Location = new System.Drawing.Point(114, 34);
            this.mask1.Name = "mask1";
            this.mask1.Size = new System.Drawing.Size(31, 23);
            this.mask1.TabIndex = 14;
            // 
            // mask2
            // 
            this.mask2.Location = new System.Drawing.Point(151, 34);
            this.mask2.Name = "mask2";
            this.mask2.Size = new System.Drawing.Size(31, 23);
            this.mask2.TabIndex = 15;
            // 
            // mask3
            // 
            this.mask3.Location = new System.Drawing.Point(188, 34);
            this.mask3.Name = "mask3";
            this.mask3.Size = new System.Drawing.Size(31, 23);
            this.mask3.TabIndex = 16;
            // 
            // mask4
            // 
            this.mask4.Location = new System.Drawing.Point(225, 34);
            this.mask4.Name = "mask4";
            this.mask4.Size = new System.Drawing.Size(31, 23);
            this.mask4.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Klasa: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(104, 23);
            this.textBox2.TabIndex = 19;
            // 
            // CheckClass
            // 
            this.CheckClass.Location = new System.Drawing.Point(270, 34);
            this.CheckClass.Name = "CheckClass";
            this.CheckClass.Size = new System.Drawing.Size(75, 23);
            this.CheckClass.TabIndex = 20;
            this.CheckClass.Text = "sprawdź Klasę";
            this.CheckClass.UseVisualStyleBackColor = true;
            this.CheckClass.Click += new System.EventHandler(this.CheckClass_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 602);
            this.Controls.Add(this.CheckClass);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mask4);
            this.Controls.Add(this.mask3);
            this.Controls.Add(this.mask2);
            this.Controls.Add(this.mask1);
            this.Controls.Add(this.ipa4);
            this.Controls.Add(this.ipa3);
            this.Controls.Add(this.ipa2);
            this.Controls.Add(this.ipa1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Label label4;
        private TextBox textBox1;
        private TextBox ipa1;
        private TextBox ipa2;
        private TextBox ipa3;
        private TextBox ipa4;
        private TextBox mask1;
        private TextBox mask2;
        private TextBox mask3;
        private TextBox mask4;
        private Label label3;
        private TextBox textBox2;
        private Button CheckClass;
    }
}