namespace sinema_bufe
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMısır = new System.Windows.Forms.TextBox();
            this.txtSu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBilet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblKasa = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mısır";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.txtBilet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMısır);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 260);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün miktar";
            // 
            // txtMısır
            // 
            this.txtMısır.Location = new System.Drawing.Point(94, 47);
            this.txtMısır.Name = "txtMısır";
            this.txtMısır.Size = new System.Drawing.Size(100, 27);
            this.txtMısır.TabIndex = 1;
            // 
            // txtSu
            // 
            this.txtSu.Location = new System.Drawing.Point(94, 91);
            this.txtSu.Name = "txtSu";
            this.txtSu.Size = new System.Drawing.Size(100, 27);
            this.txtSu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Su";
            // 
            // txtCay
            // 
            this.txtCay.Location = new System.Drawing.Point(94, 149);
            this.txtCay.Name = "txtCay";
            this.txtCay.Size = new System.Drawing.Size(100, 27);
            this.txtCay.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "çay";
            // 
            // txtBilet
            // 
            this.txtBilet.Location = new System.Drawing.Point(94, 203);
            this.txtBilet.Name = "txtBilet";
            this.txtBilet.Size = new System.Drawing.Size(100, 27);
            this.txtBilet.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(26, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bİlet";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(304, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 260);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fiyat Tablosu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mısır:4TL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Çay:2TL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Su:1TL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "Bilet:8TL";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.lblKasa);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.lblSonuc);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(536, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 260);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kasa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Toplam =";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(131, 63);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(36, 25);
            this.lblSonuc.TabIndex = 1;
            this.lblSonuc.Text = "00";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(78, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Font = new System.Drawing.Font("News706 BT", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(189, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(365, 34);
            this.label11.TabIndex = 3;
            this.label11.Text = " SİNEMA SATIŞ PANELİ";
            // 
            // lblKasa
            // 
            this.lblKasa.AutoSize = true;
            this.lblKasa.Location = new System.Drawing.Point(114, 205);
            this.lblKasa.Name = "lblKasa";
            this.lblKasa.Size = new System.Drawing.Size(36, 25);
            this.lblKasa.TabIndex = 4;
            this.lblKasa.Text = "00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 25);
            this.label13.TabIndex = 3;
            this.label13.Text = "kasa=";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(78, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "TEMİZLE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBilet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMısır;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblKasa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
    }
}

