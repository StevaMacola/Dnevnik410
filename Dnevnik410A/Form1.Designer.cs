namespace Dnevnik410A
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
            this.IDtB = new System.Windows.Forms.TextBox();
            this.prezimetB = new System.Windows.Forms.MaskedTextBox();
            this.jmbgtB = new System.Windows.Forms.TextBox();
            this.mailtB = new System.Windows.Forms.TextBox();
            this.lozinkatB = new System.Windows.Forms.TextBox();
            this.imetB = new System.Windows.Forms.TextBox();
            this.adresatB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.ulogatB = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IDtB
            // 
            this.IDtB.Location = new System.Drawing.Point(970, 39);
            this.IDtB.Margin = new System.Windows.Forms.Padding(6);
            this.IDtB.Name = "IDtB";
            this.IDtB.Size = new System.Drawing.Size(164, 31);
            this.IDtB.TabIndex = 0;
            this.IDtB.TextChanged += new System.EventHandler(this.IDtB_TextChanged);
            // 
            // prezimetB
            // 
            this.prezimetB.Location = new System.Drawing.Point(970, 155);
            this.prezimetB.Margin = new System.Windows.Forms.Padding(6);
            this.prezimetB.Name = "prezimetB";
            this.prezimetB.Size = new System.Drawing.Size(164, 31);
            this.prezimetB.TabIndex = 1;
            this.prezimetB.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.prezimetB_MaskInputRejected);
            // 
            // jmbgtB
            // 
            this.jmbgtB.Location = new System.Drawing.Point(970, 268);
            this.jmbgtB.Margin = new System.Windows.Forms.Padding(6);
            this.jmbgtB.Name = "jmbgtB";
            this.jmbgtB.Size = new System.Drawing.Size(164, 31);
            this.jmbgtB.TabIndex = 2;
            // 
            // mailtB
            // 
            this.mailtB.Location = new System.Drawing.Point(970, 334);
            this.mailtB.Margin = new System.Windows.Forms.Padding(6);
            this.mailtB.Name = "mailtB";
            this.mailtB.Size = new System.Drawing.Size(164, 31);
            this.mailtB.TabIndex = 3;
            // 
            // lozinkatB
            // 
            this.lozinkatB.Location = new System.Drawing.Point(970, 396);
            this.lozinkatB.Margin = new System.Windows.Forms.Padding(6);
            this.lozinkatB.Name = "lozinkatB";
            this.lozinkatB.Size = new System.Drawing.Size(164, 31);
            this.lozinkatB.TabIndex = 4;
            // 
            // imetB
            // 
            this.imetB.Location = new System.Drawing.Point(970, 94);
            this.imetB.Margin = new System.Windows.Forms.Padding(6);
            this.imetB.Name = "imetB";
            this.imetB.Size = new System.Drawing.Size(164, 31);
            this.imetB.TabIndex = 5;
            // 
            // adresatB
            // 
            this.adresatB.Location = new System.Drawing.Point(970, 210);
            this.adresatB.Margin = new System.Windows.Forms.Padding(6);
            this.adresatB.Name = "adresatB";
            this.adresatB.Size = new System.Drawing.Size(164, 31);
            this.adresatB.TabIndex = 6;
            this.adresatB.TextChanged += new System.EventHandler(this.adresatB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(833, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Broj učenika :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 12F);
            this.label2.Location = new System.Drawing.Point(833, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ime :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 12F);
            this.label3.Location = new System.Drawing.Point(833, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Prezime :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 12F);
            this.label4.Location = new System.Drawing.Point(833, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Adresa:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Imprint MT Shadow", 12F);
            this.label5.Location = new System.Drawing.Point(833, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "JMBG :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Imprint MT Shadow", 12F);
            this.label6.Location = new System.Drawing.Point(833, 337);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "E-mail :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(833, 396);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Lozinka :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1288, 765);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 24);
            this.label8.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(152, 570);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 42);
            this.button1.TabIndex = 22;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(447, 570);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 42);
            this.button2.TabIndex = 23;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(727, 570);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 42);
            this.button3.TabIndex = 24;
            this.button3.Text = "Dodaj";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Location = new System.Drawing.Point(984, 570);
            this.button4.Margin = new System.Windows.Forms.Padding(6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 42);
            this.button4.TabIndex = 25;
            this.button4.Text = "Menjaj";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(1242, 570);
            this.button5.Margin = new System.Windows.Forms.Padding(6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 42);
            this.button5.TabIndex = 26;
            this.button5.Text = "Briši";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button6.Location = new System.Drawing.Point(1498, 570);
            this.button6.Margin = new System.Windows.Forms.Padding(6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 42);
            this.button6.TabIndex = 27;
            this.button6.Text = ">";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button7.Location = new System.Drawing.Point(1746, 570);
            this.button7.Margin = new System.Windows.Forms.Padding(6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 42);
            this.button7.TabIndex = 28;
            this.button7.Text = ">>";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // ulogatB
            // 
            this.ulogatB.Location = new System.Drawing.Point(970, 461);
            this.ulogatB.Margin = new System.Windows.Forms.Padding(6);
            this.ulogatB.Name = "ulogatB";
            this.ulogatB.Size = new System.Drawing.Size(164, 31);
            this.ulogatB.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(833, 464);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 24);
            this.label9.TabIndex = 30;
            this.label9.Text = "Uloga :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(2564, 1172);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ulogatB);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adresatB);
            this.Controls.Add(this.imetB);
            this.Controls.Add(this.lozinkatB);
            this.Controls.Add(this.mailtB);
            this.Controls.Add(this.jmbgtB);
            this.Controls.Add(this.prezimetB);
            this.Controls.Add(this.IDtB);
            this.Font = new System.Drawing.Font("Imprint MT Shadow", 12F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDtB;
        private System.Windows.Forms.MaskedTextBox prezimetB;
        private System.Windows.Forms.TextBox jmbgtB;
        private System.Windows.Forms.TextBox mailtB;
        private System.Windows.Forms.TextBox lozinkatB;
        private System.Windows.Forms.TextBox imetB;
        private System.Windows.Forms.TextBox adresatB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox ulogatB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label9;
    }
}

