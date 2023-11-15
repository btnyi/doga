namespace doga
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
            lblNev = new Label();
            txtBoxNev = new TextBox();
            btnKosz = new Button();
            lblUdv = new Label();
            txtBoxOssz1 = new TextBox();
            txtBoxOssz2 = new TextBox();
            btnOsszAd = new Button();
            btnKivon = new Button();
            btnSzoroz = new Button();
            btnOszt = new Button();
            label3 = new Label();
            txtBoyEredmeny = new TextBox();
            btnSzamol = new Button();
            btnEx = new Button();
            btnAlaphely = new Button();
            lblPiros = new Label();
            lblZold = new Label();
            lblKek = new Label();
            SuspendLayout();
            // 
            // lblNev
            // 
            lblNev.AutoSize = true;
            lblNev.Location = new Point(51, 52);
            lblNev.Name = "lblNev";
            lblNev.Size = new Size(29, 15);
            lblNev.TabIndex = 0;
            lblNev.Text = "név:";
            // 
            // txtBoxNev
            // 
            txtBoxNev.Location = new Point(86, 49);
            txtBoxNev.Name = "txtBoxNev";
            txtBoxNev.Size = new Size(190, 23);
            txtBoxNev.TabIndex = 1;
            // 
            // btnKosz
            // 
            btnKosz.Location = new Point(282, 49);
            btnKosz.Name = "btnKosz";
            btnKosz.Size = new Size(75, 23);
            btnKosz.TabIndex = 2;
            btnKosz.Text = "Köszönj!";
            btnKosz.UseVisualStyleBackColor = true;
            // 
            // lblUdv
            // 
            lblUdv.BackColor = Color.Yellow;
            lblUdv.Font = new Font("Rockwell Extra Bold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUdv.Location = new Point(51, 89);
            lblUdv.Name = "lblUdv";
            lblUdv.Size = new Size(306, 40);
            lblUdv.TabIndex = 3;
            lblUdv.Text = "###UDVOZLES###";
            lblUdv.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxOssz1
            // 
            txtBoxOssz1.Location = new Point(51, 173);
            txtBoxOssz1.Multiline = true;
            txtBoxOssz1.Name = "txtBoxOssz1";
            txtBoxOssz1.Size = new Size(68, 44);
            txtBoxOssz1.TabIndex = 4;
            txtBoxOssz1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBoxOssz2
            // 
            txtBoxOssz2.Location = new Point(259, 174);
            txtBoxOssz2.Multiline = true;
            txtBoxOssz2.Name = "txtBoxOssz2";
            txtBoxOssz2.Size = new Size(64, 44);
            txtBoxOssz2.TabIndex = 5;
            txtBoxOssz2.TextAlign = HorizontalAlignment.Center;
            // 
            // btnOsszAd
            // 
            btnOsszAd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOsszAd.Location = new Point(153, 168);
            btnOsszAd.Name = "btnOsszAd";
            btnOsszAd.Size = new Size(30, 28);
            btnOsszAd.TabIndex = 6;
            btnOsszAd.Text = "+";
            btnOsszAd.UseVisualStyleBackColor = true;
            // 
            // btnKivon
            // 
            btnKivon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKivon.Location = new Point(189, 168);
            btnKivon.Name = "btnKivon";
            btnKivon.Size = new Size(30, 28);
            btnKivon.TabIndex = 7;
            btnKivon.Text = "-";
            btnKivon.UseVisualStyleBackColor = true;
            // 
            // btnSzoroz
            // 
            btnSzoroz.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSzoroz.Location = new Point(153, 202);
            btnSzoroz.Name = "btnSzoroz";
            btnSzoroz.Size = new Size(30, 28);
            btnSzoroz.TabIndex = 8;
            btnSzoroz.Text = "*";
            btnSzoroz.UseVisualStyleBackColor = true;
            // 
            // btnOszt
            // 
            btnOszt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOszt.Location = new Point(189, 202);
            btnOszt.Name = "btnOszt";
            btnOszt.Size = new Size(30, 28);
            btnOszt.TabIndex = 9;
            btnOszt.Text = "/";
            btnOszt.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(346, 174);
            label3.Name = "label3";
            label3.Size = new Size(49, 35);
            label3.TabIndex = 10;
            label3.Text = "=";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoyEredmeny
            // 
            txtBoyEredmeny.Location = new Point(413, 174);
            txtBoyEredmeny.Multiline = true;
            txtBoyEredmeny.Name = "txtBoyEredmeny";
            txtBoyEredmeny.Size = new Size(208, 44);
            txtBoyEredmeny.TabIndex = 11;
            // 
            // btnSzamol
            // 
            btnSzamol.Location = new Point(51, 236);
            btnSzamol.Name = "btnSzamol";
            btnSzamol.Size = new Size(573, 30);
            btnSzamol.TabIndex = 12;
            btnSzamol.Text = "Számolj!";
            btnSzamol.UseVisualStyleBackColor = true;
            // 
            // btnEx
            // 
            btnEx.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnEx.ForeColor = Color.Red;
            btnEx.Location = new Point(448, 272);
            btnEx.Name = "btnEx";
            btnEx.Size = new Size(176, 36);
            btnEx.TabIndex = 13;
            btnEx.Text = "Kilépés";
            btnEx.UseVisualStyleBackColor = true;
            // 
            // btnAlaphely
            // 
            btnAlaphely.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlaphely.ForeColor = Color.Blue;
            btnAlaphely.Location = new Point(248, 272);
            btnAlaphely.Name = "btnAlaphely";
            btnAlaphely.Size = new Size(194, 36);
            btnAlaphely.TabIndex = 14;
            btnAlaphely.Text = "Alaphelyzet";
            btnAlaphely.UseVisualStyleBackColor = true;
            // 
            // lblPiros
            // 
            lblPiros.BackColor = Color.FromArgb(255, 128, 128);
            lblPiros.Location = new Point(398, 44);
            lblPiros.Name = "lblPiros";
            lblPiros.Size = new Size(54, 54);
            lblPiros.TabIndex = 15;
            lblPiros.Text = "piros";
            // 
            // lblZold
            // 
            lblZold.BackColor = Color.Lime;
            lblZold.Location = new Point(458, 44);
            lblZold.Name = "lblZold";
            lblZold.Size = new Size(54, 54);
            lblZold.TabIndex = 15;
            lblZold.Text = "zöld";
            // 
            // lblKek
            // 
            lblKek.BackColor = Color.Cyan;
            lblKek.Location = new Point(518, 44);
            lblKek.Name = "lblKek";
            lblKek.Size = new Size(54, 54);
            lblKek.TabIndex = 15;
            lblKek.Text = "kék";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 322);
            Controls.Add(lblKek);
            Controls.Add(lblZold);
            Controls.Add(lblPiros);
            Controls.Add(btnAlaphely);
            Controls.Add(btnEx);
            Controls.Add(btnSzamol);
            Controls.Add(txtBoyEredmeny);
            Controls.Add(label3);
            Controls.Add(btnOszt);
            Controls.Add(btnSzoroz);
            Controls.Add(btnKivon);
            Controls.Add(btnOsszAd);
            Controls.Add(txtBoxOssz2);
            Controls.Add(txtBoxOssz1);
            Controls.Add(lblUdv);
            Controls.Add(btnKosz);
            Controls.Add(txtBoxNev);
            Controls.Add(lblNev);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNev;
        private TextBox txtBoxNev;
        private Button btnKosz;
        private Label lblUdv;
        private TextBox txtBoxOssz1;
        private TextBox txtBoxOssz2;
        private Button btnOsszAd;
        private Button btnKivon;
        private Button btnSzoroz;
        private Button btnOszt;
        private Label label3;
        private TextBox txtBoyEredmeny;
        private Button btnSzamol;
        private Button btnEx;
        private Button btnAlaphely;
        private Label lblPiros;
        private Label lblZold;
        private Label lblKek;
    }
}