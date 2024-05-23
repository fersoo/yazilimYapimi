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
            lblAd = new Label();
            txtisim = new TextBox();
            lblSoyad = new Label();
            txtSoyisim = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblGirisYap
            // 
            lblGirisYap.AutoSize = true;
            lblGirisYap.Cursor = Cursors.Hand;
            lblGirisYap.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGirisYap.ForeColor = Color.FromArgb(220, 242, 241);
            lblGirisYap.Location = new Point(163, 735);
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
            lblMail.Location = new Point(137, 206);
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
            txtMail.Location = new Point(80, 237);
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
            pictureBox2.Location = new Point(137, 40);
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
            lblHesapVarMi.Location = new Point(129, 719);
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
            checkSifreGoster.Location = new Point(302, 526);
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
            lblBaslayalim.Location = new Point(61, 122);
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
            btnTemizle.Location = new Point(80, 666);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(216, 37);
            btnTemizle.TabIndex = 6;
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
            btnKayitOl.Location = new Point(80, 623);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(216, 37);
            btnKayitOl.TabIndex = 5;
            btnKayitOl.Text = "KAYIT OL";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSifre.ForeColor = Color.FromArgb(220, 242, 241);
            lblSifre.Location = new Point(164, 495);
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
            lblKullaniciAd.Location = new Point(130, 424);
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
            txtSifre.Location = new Point(80, 526);
            txtSifre.Multiline = true;
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '●';
            txtSifre.Size = new Size(216, 28);
            txtSifre.TabIndex = 4;
            // 
            // txtKullaniciAd
            // 
            txtKullaniciAd.BackColor = Color.FromArgb(230, 231, 233);
            txtKullaniciAd.BorderStyle = BorderStyle.None;
            txtKullaniciAd.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKullaniciAd.Location = new Point(80, 455);
            txtKullaniciAd.Multiline = true;
            txtKullaniciAd.Name = "txtKullaniciAd";
            txtKullaniciAd.Size = new Size(216, 28);
            txtKullaniciAd.TabIndex = 3;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAd.ForeColor = Color.FromArgb(220, 242, 241);
            lblAd.Location = new Point(171, 278);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(35, 28);
            lblAd.TabIndex = 34;
            lblAd.Text = "Ad";
            // 
            // txtisim
            // 
            txtisim.BackColor = Color.FromArgb(230, 231, 233);
            txtisim.BorderStyle = BorderStyle.None;
            txtisim.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtisim.Location = new Point(80, 309);
            txtisim.Multiline = true;
            txtisim.Name = "txtisim";
            txtisim.Size = new Size(216, 28);
            txtisim.TabIndex = 1;
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSoyad.ForeColor = Color.FromArgb(220, 242, 241);
            lblSoyad.Location = new Point(158, 350);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(60, 28);
            lblSoyad.TabIndex = 36;
            lblSoyad.Text = "Soyad";
            // 
            // txtSoyisim
            // 
            txtSoyisim.BackColor = Color.FromArgb(230, 231, 233);
            txtSoyisim.BorderStyle = BorderStyle.None;
            txtSoyisim.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoyisim.Location = new Point(80, 381);
            txtSoyisim.Multiline = true;
            txtSoyisim.Name = "txtSoyisim";
            txtSoyisim.Size = new Size(216, 28);
            txtSoyisim.TabIndex = 2;
            // 
            // frmRegister
            // 
            AcceptButton = btnKayitOl;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(54, 84, 134);
            CancelButton = btnTemizle;
            ClientSize = new Size(387, 801);
            Controls.Add(lblSoyad);
            Controls.Add(txtSoyisim);
            Controls.Add(lblAd);
            Controls.Add(txtisim);
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
        private Label lblAd;
        private TextBox txtisim;
        private Label lblSoyad;
        private TextBox txtSoyisim;
    }
}