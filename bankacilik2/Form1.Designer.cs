namespace bankacilik2
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
            label1 = new Label();
            txtAd = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            txtSoyad = new TextBox();
            txtTCNo = new TextBox();
            label4 = new Label();
            lblHesapMiktari = new Label();
            label6 = new Label();
            label7 = new Label();
            txtParaMiktari = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(26, 77);
            label1.Name = "label1";
            label1.Size = new Size(51, 35);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 15F);
            txtAd.Location = new Point(120, 74);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(174, 41);
            txtAd.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(96, 281);
            button1.Name = "button1";
            button1.Size = new Size(124, 61);
            button1.TabIndex = 2;
            button1.Text = "giriş";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(26, 135);
            label2.Name = "label2";
            label2.Size = new Size(88, 35);
            label2.TabIndex = 3;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(26, 206);
            label3.Name = "label3";
            label3.Size = new Size(47, 35);
            label3.TabIndex = 4;
            label3.Text = "TC:";
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 15F);
            txtSoyad.Location = new Point(120, 132);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(174, 41);
            txtSoyad.TabIndex = 5;
            // 
            // txtTCNo
            // 
            txtTCNo.Font = new Font("Segoe UI", 15F);
            txtTCNo.Location = new Point(120, 200);
            txtTCNo.Name = "txtTCNo";
            txtTCNo.Size = new Size(174, 41);
            txtTCNo.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(413, 77);
            label4.Name = "label4";
            label4.Size = new Size(151, 35);
            label4.TabIndex = 7;
            label4.Text = "Para miktarı:";
            // 
            // lblHesapMiktari
            // 
            lblHesapMiktari.AutoSize = true;
            lblHesapMiktari.Font = new Font("Segoe UI", 15F);
            lblHesapMiktari.Location = new Point(580, 77);
            lblHesapMiktari.Name = "lblHesapMiktari";
            lblHesapMiktari.Size = new Size(28, 35);
            lblHesapMiktari.TabIndex = 8;
            lblHesapMiktari.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(723, 74);
            label6.Name = "label6";
            label6.Size = new Size(40, 35);
            label6.TabIndex = 9;
            label6.Text = "TL";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(328, 144);
            label7.Name = "label7";
            label7.Size = new Size(249, 35);
            label7.TabIndex = 10;
            label7.Text = "Gönderilecek miktar: ";
            // 
            // txtParaMiktari
            // 
            txtParaMiktari.Font = new Font("Segoe UI", 15F);
            txtParaMiktari.Location = new Point(580, 138);
            txtParaMiktari.Name = "txtParaMiktari";
            txtParaMiktari.Size = new Size(174, 41);
            txtParaMiktari.TabIndex = 11;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(461, 200);
            button2.Name = "button2";
            button2.Size = new Size(174, 61);
            button2.TabIndex = 12;
            button2.Text = "para gönder";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(txtParaMiktari);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lblHesapMiktari);
            Controls.Add(label4);
            Controls.Add(txtTCNo);
            Controls.Add(txtSoyad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(txtAd);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAd;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox txtSoyad;
        private TextBox txtTCNo;
        private Label label4;
        private Label lblHesapMiktari;
        private Label label6;
        private Label label7;
        private TextBox txtParaMiktari;
        private Button button2;
    }
}
