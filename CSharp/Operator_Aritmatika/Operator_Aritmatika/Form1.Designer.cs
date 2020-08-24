namespace Operator_Aritmatika
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
            this.label1 = new System.Windows.Forms.Label();
            this.Kotak_Nilai_A = new System.Windows.Forms.TextBox();
            this.Tombol_Tambah = new System.Windows.Forms.Button();
            this.Kotak_Nilai_B = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Kotak_Hasil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tombol_Kurang = new System.Windows.Forms.Button();
            this.Tombol_Kali = new System.Windows.Forms.Button();
            this.Tombol_Bagi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nilai A";
            // 
            // Kotak_Nilai_A
            // 
            this.Kotak_Nilai_A.Location = new System.Drawing.Point(182, 30);
            this.Kotak_Nilai_A.Name = "Kotak_Nilai_A";
            this.Kotak_Nilai_A.Size = new System.Drawing.Size(100, 26);
            this.Kotak_Nilai_A.TabIndex = 1;
            // 
            // Tombol_Tambah
            // 
            this.Tombol_Tambah.Location = new System.Drawing.Point(369, 29);
            this.Tombol_Tambah.Name = "Tombol_Tambah";
            this.Tombol_Tambah.Size = new System.Drawing.Size(114, 49);
            this.Tombol_Tambah.TabIndex = 2;
            this.Tombol_Tambah.Text = "+";
            this.Tombol_Tambah.UseVisualStyleBackColor = true;
            this.Tombol_Tambah.Click += new System.EventHandler(this.Tombol_Tambah_Click);
            // 
            // Kotak_Nilai_B
            // 
            this.Kotak_Nilai_B.Location = new System.Drawing.Point(182, 82);
            this.Kotak_Nilai_B.Name = "Kotak_Nilai_B";
            this.Kotak_Nilai_B.Size = new System.Drawing.Size(100, 26);
            this.Kotak_Nilai_B.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nilai B";
            // 
            // Kotak_Hasil
            // 
            this.Kotak_Hasil.Location = new System.Drawing.Point(182, 135);
            this.Kotak_Hasil.Name = "Kotak_Hasil";
            this.Kotak_Hasil.Size = new System.Drawing.Size(100, 26);
            this.Kotak_Hasil.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasil";
            // 
            // Tombol_Kurang
            // 
            this.Tombol_Kurang.Location = new System.Drawing.Point(369, 88);
            this.Tombol_Kurang.Name = "Tombol_Kurang";
            this.Tombol_Kurang.Size = new System.Drawing.Size(114, 49);
            this.Tombol_Kurang.TabIndex = 7;
            this.Tombol_Kurang.Text = "-";
            this.Tombol_Kurang.UseVisualStyleBackColor = true;
            this.Tombol_Kurang.Click += new System.EventHandler(this.Tombol_Kurang_Click);
            // 
            // Tombol_Kali
            // 
            this.Tombol_Kali.Location = new System.Drawing.Point(369, 143);
            this.Tombol_Kali.Name = "Tombol_Kali";
            this.Tombol_Kali.Size = new System.Drawing.Size(114, 49);
            this.Tombol_Kali.TabIndex = 8;
            this.Tombol_Kali.Text = "x";
            this.Tombol_Kali.UseVisualStyleBackColor = true;
            this.Tombol_Kali.Click += new System.EventHandler(this.Tombol_Kali_Click);
            // 
            // Tombol_Bagi
            // 
            this.Tombol_Bagi.Location = new System.Drawing.Point(369, 200);
            this.Tombol_Bagi.Name = "Tombol_Bagi";
            this.Tombol_Bagi.Size = new System.Drawing.Size(114, 49);
            this.Tombol_Bagi.TabIndex = 9;
            this.Tombol_Bagi.Text = "/";
            this.Tombol_Bagi.UseVisualStyleBackColor = true;
            this.Tombol_Bagi.Click += new System.EventHandler(this.Tombol_Bagi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 261);
            this.Controls.Add(this.Tombol_Bagi);
            this.Controls.Add(this.Tombol_Kali);
            this.Controls.Add(this.Tombol_Kurang);
            this.Controls.Add(this.Kotak_Hasil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Kotak_Nilai_B);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tombol_Tambah);
            this.Controls.Add(this.Kotak_Nilai_A);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Kotak_Nilai_A;
        private System.Windows.Forms.Button Tombol_Tambah;
        private System.Windows.Forms.TextBox Kotak_Nilai_B;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Kotak_Hasil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Tombol_Kurang;
        private System.Windows.Forms.Button Tombol_Kali;
        private System.Windows.Forms.Button Tombol_Bagi;
    }
}

