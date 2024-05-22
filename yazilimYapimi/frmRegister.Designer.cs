namespace yazilimYapimi
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            lblGirisYap = new Label();
            lblMail = new Label();
            txtMail = new TextBox();
            pictureBox2 = new PictureBox();
            lblHesapVarMi = new Label();
            checkSifreGoster = new CheckBox();
            lblBaslayalim = new Label();
            btnTemizle = new Button();
            btnKayitOl = new Button();
            lblSifre = new Label();
            lblKullaniciAd = new Label();
            txtSifre = new TextBox();
            txtKullaniciAd = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblGirisYap
            // 
            lblGirisYap.AutoSize = true;
            lblGirisYap.Cursor = Cursors.Hand;
            lblGirisYap.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGirisYap.ForeColor = Color.FromArgb(220, 242, 241);
            lblGirisYap.Location = new Point(149, 579);
            lblGirisYap.Name = "lblGirisYap";
            lblGirisYap.Size = new Size(50, 13);
            lblGirisYap.TabIndex = 32;
            lblGirisYap.Text = "Giriş Yap";
            lblGirisYap.Click += lblGirisYap_Click;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblMail.ForeColor = Color.FromArgb(220, 242, 241);
            lblMail.Location = new Point(123, 213);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(103, 28);
            lblMail.TabIndex = 31;
            lblMail.Text = "Mail Adresi";
            // 
            // txtMail
            // 
            txtMail.BackColor = Color.FromArgb(230, 231, 233);
            txtMail.BorderStyle = BorderStyle.None;
            txtMail.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMail.Location = new Point(66, 244);
            txtMail.Multiline = true;
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(216, 28);
            txtMail.TabIndex = 0;
            txtMail.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(54, 84, 134);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(122, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(105, 79);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // lblHesapVarMi
            // 
            lblHesapVarMi.AutoSize = true;
            lblHesapVarMi.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHesapVarMi.ForeColor = Color.FromArgb(220, 242, 241);
            lblHesapVarMi.Location = new Point(115, 563);
            lblHesapVarMi.Name = "lblHesapVarMi";
            lblHesapVarMi.Size = new Size(118, 13);
            lblHesapVarMi.TabIndex = 28;
            lblHesapVarMi.Text = "Zaten hesabın var mı?";
            // 
            // checkSifreGoster
            // 
            checkSifreGoster.Appearance = Appearance.Button;
            checkSifreGoster.BackgroundImage = (Image)resources.GetObject("checkSifreGoster.BackgroundImage");
            checkSifreGoster.BackgroundImageLayout = ImageLayout.Stretch;
            checkSifreGoster.Cursor = Cursors.Hand;
            checkSifreGoster.FlatAppearance.BorderSize = 0;
            checkSifreGoster.FlatStyle = FlatStyle.Flat;
            checkSifreGoster.ForeColor = Color.FromArgb(54, 84, 134);
            checkSifreGoster.Location = new Point(288, 386);
            checkSifreGoster.Name = "checkSifreGoster";
            checkSifreGoster.Size = new Size(30, 28);
            checkSifreGoster.TabIndex = 27;
            checkSifreGoster.Text = " ";
            checkSifreGoster.TextAlign = ContentAlignment.MiddleCenter;
            checkSifreGoster.UseVisualStyleBackColor = true;
            checkSifreGoster.CheckedChanged += checkSifreGoster_CheckedChanged;
            // 
            // lblBaslayalim
            // 
            lblBaslayalim.AutoSize = true;
            lblBaslayalim.FlatStyle = FlatStyle.Flat;
            lblBaslayalim.Font = new Font("Segoe Print", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBaslayalim.ForeColor = Color.FromArgb(220, 242, 241);
            lblBaslayalim.Location = new Point(46, 122);
            lblBaslayalim.Name = "lblBaslayalim";
            lblBaslayalim.Size = new Size(257, 47);
            lblBaslayalim.TabIndex = 26;
            lblBaslayalim.Text = "Haydi Başlayalım";
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.Transparent;
            btnTemizle.Cursor = Cursors.Hand;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTemizle.ForeColor = SystemColors.ButtonFace;
            btnTemizle.Location = new Point(66, 516);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(216, 37);
            btnTemizle.TabIndex = 4;
            btnTemizle.Text = "TEMIZLE";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.FromArgb(220, 242, 241);
            btnKayitOl.Cursor = Cursors.Hand;
            btnKayitOl.FlatAppearance.BorderSize = 0;
            btnKayitOl.FlatStyle = FlatStyle.Flat;
            btnKayitOl.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKayitOl.Location = new Point(66, 473);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(216, 37);
            btnKayitOl.TabIndex = 3;
            btnKayitOl.Text = "KAYIT OL";
            btnKayitOl.UseVisualStyleBackColor = false;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSifre.ForeColor = Color.FromArgb(220, 242, 241);
            lblSifre.Location = new Point(150, 355);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(49, 28);
            lblSifre.TabIndex = 23;
            lblSifre.Text = "Şifre";
            // 
            // lblKullaniciAd
            // 
            lblKullaniciAd.AutoSize = true;
            lblKullaniciAd.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblKullaniciAd.ForeColor = Color.FromArgb(220, 242, 241);
            lblKullaniciAd.Location = new Point(116, 284);
            lblKullaniciAd.Name = "lblKullaniciAd";
            lblKullaniciAd.Size = new Size(116, 28);
            lblKullaniciAd.TabIndex = 22;
            lblKullaniciAd.Text = "Kullanıcı Adı";
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.FromArgb(230, 231, 233);
            txtSifre.BorderStyle = BorderStyle.None;
            txtSifre.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSifre.Location = new Point(66, 386);
            txtSifre.Multiline = true;
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '●';
            txtSifre.Size = new Size(216, 28);
            txtSifre.TabIndex = 2;
            // 
            // txtKullaniciAd
            // 
            txtKullaniciAd.BackColor = Color.FromArgb(230, 231, 233);
            txtKullaniciAd.BorderStyle = BorderStyle.None;
            txtKullaniciAd.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKullaniciAd.Location = new Point(66, 315);
            txtKullaniciAd.Multiline = true;
            txtKullaniciAd.Name = "txtKullaniciAd";
            txtKullaniciAd.Size = new Size(216, 28);
            txtKullaniciAd.TabIndex = 1;
            // 
            // frmRegister
            // 
            AcceptButton = btnKayitOl;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(54, 84, 134);
            CancelButton = btnTemizle;
            ClientSize = new Size(352, 644);
            Controls.Add(lblGirisYap);
            Controls.Add(lblMail);
            Controls.Add(txtMail);
            Controls.Add(pictureBox2);
            Controls.Add(lblHesapVarMi);
            Controls.Add(checkSifreGoster);
            Controls.Add(lblBaslayalim);
            Controls.Add(btnTemizle);
            Controls.Add(btnKayitOl);
            Controls.Add(lblSifre);
            Controls.Add(lblKullaniciAd);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KAYIT OL";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblGirisYap;
        private Label lblMail;
        private TextBox txtMail;
        private PictureBox pictureBox2;
        private Label lblHesapVarMi;
        private CheckBox checkSifreGoster;
        private Label lblBaslayalim;
        private Button btnTemizle;
        private Button btnKayitOl;
        private Label lblSifre;
        private Label lblKullaniciAd;
        private TextBox txtSifre;
        private TextBox txtKullaniciAd;
    }
}