namespace yazilimYapimi
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBoxLogo = new PictureBox();
            lblSifreUnuttum = new Label();
            checkSifreGoster = new CheckBox();
            lblHosgeldiniz = new Label();
            btnKayitOl = new Button();
            btnGirisYap = new Button();
            lblSifre = new Label();
            lblKullaniciAdi = new Label();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.FromArgb(54, 84, 134);
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(125, 33);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(105, 79);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 29;
            pictureBoxLogo.TabStop = false;
            // 
            // lblSifreUnuttum
            // 
            lblSifreUnuttum.AutoSize = true;
            lblSifreUnuttum.Cursor = Cursors.Hand;
            lblSifreUnuttum.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSifreUnuttum.ForeColor = Color.FromArgb(220, 242, 241);
            lblSifreUnuttum.Location = new Point(122, 448);
            lblSifreUnuttum.Name = "lblSifreUnuttum";
            lblSifreUnuttum.Size = new Size(110, 13);
            lblSifreUnuttum.TabIndex = 4;
            lblSifreUnuttum.Text = "Şifreni mi unuttun ?";
            lblSifreUnuttum.Click += lblSifreUnuttum_Click;
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
            checkSifreGoster.Location = new Point(291, 290);
            checkSifreGoster.Name = "checkSifreGoster";
            checkSifreGoster.Size = new Size(30, 28);
            checkSifreGoster.TabIndex = 5;
            checkSifreGoster.Text = " ";
            checkSifreGoster.TextAlign = ContentAlignment.MiddleCenter;
            checkSifreGoster.UseVisualStyleBackColor = true;
            checkSifreGoster.CheckedChanged += checkSifreGoster_CheckedChanged;
            // 
            // lblHosgeldiniz
            // 
            lblHosgeldiniz.AutoSize = true;
            lblHosgeldiniz.FlatStyle = FlatStyle.Flat;
            lblHosgeldiniz.Font = new Font("Segoe Print", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHosgeldiniz.ForeColor = Color.FromArgb(220, 242, 241);
            lblHosgeldiniz.Location = new Point(92, 115);
            lblHosgeldiniz.Name = "lblHosgeldiniz";
            lblHosgeldiniz.Size = new Size(171, 47);
            lblHosgeldiniz.TabIndex = 6;
            lblHosgeldiniz.Text = "Hoşgeldiniz";
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.Transparent;
            btnKayitOl.Cursor = Cursors.Hand;
            btnKayitOl.FlatStyle = FlatStyle.Flat;
            btnKayitOl.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKayitOl.ForeColor = SystemColors.ButtonFace;
            btnKayitOl.Location = new Point(69, 398);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(216, 37);
            btnKayitOl.TabIndex = 3;
            btnKayitOl.Text = "KAYIT OL";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // btnGirisYap
            // 
            btnGirisYap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGirisYap.BackColor = Color.FromArgb(220, 242, 241);
            btnGirisYap.Cursor = Cursors.Hand;
            btnGirisYap.FlatAppearance.BorderSize = 0;
            btnGirisYap.FlatStyle = FlatStyle.Flat;
            btnGirisYap.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGirisYap.Location = new Point(69, 355);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(216, 37);
            btnGirisYap.TabIndex = 2;
            btnGirisYap.Text = "GIRIS YAP";
            btnGirisYap.UseVisualStyleBackColor = false;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSifre.ForeColor = Color.FromArgb(220, 242, 241);
            lblSifre.Location = new Point(153, 259);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(49, 28);
            lblSifre.TabIndex = 23;
            lblSifre.Text = "Şifre";
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblKullaniciAdi.ForeColor = Color.FromArgb(220, 242, 241);
            lblKullaniciAdi.Location = new Point(119, 184);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(116, 28);
            lblKullaniciAdi.TabIndex = 22;
            lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.FromArgb(230, 231, 233);
            txtSifre.BorderStyle = BorderStyle.None;
            txtSifre.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSifre.Location = new Point(69, 290);
            txtSifre.Multiline = true;
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '●';
            txtSifre.Size = new Size(216, 28);
            txtSifre.TabIndex = 1;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BackColor = Color.FromArgb(230, 231, 233);
            txtKullaniciAdi.BorderStyle = BorderStyle.None;
            txtKullaniciAdi.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKullaniciAdi.Location = new Point(69, 215);
            txtKullaniciAdi.Multiline = true;
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(216, 28);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // frmLogin
            // 
            AcceptButton = btnGirisYap;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(54, 84, 134);
            ClientSize = new Size(352, 517);
            Controls.Add(pictureBoxLogo);
            Controls.Add(lblSifreUnuttum);
            Controls.Add(checkSifreGoster);
            Controls.Add(lblHosgeldiniz);
            Controls.Add(btnKayitOl);
            Controls.Add(btnGirisYap);
            Controls.Add(lblSifre);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GIRIS YAP";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBoxLogo;
        private Label lblSifreUnuttum;
        private CheckBox checkSifreGoster;
        private Label lblHosgeldiniz;
        private Button btnKayitOl;
        private Button btnGirisYap;
        private Label lblSifre;
        private Label lblKullaniciAdi;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
    }
}
