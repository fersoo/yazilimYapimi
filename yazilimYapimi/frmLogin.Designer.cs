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
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblKullaniciAdi = new Label();
            lblSifre = new Label();
            btnGirisYap = new Button();
            btnKayitOl = new Button();
            label1 = new Label();
            checkPassword = new CheckBox();
            lblSifreUnuttum = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BackColor = Color.FromArgb(230, 231, 233);
            txtKullaniciAdi.BorderStyle = BorderStyle.None;
            txtKullaniciAdi.Location = new Point(72, 207);
            txtKullaniciAdi.Multiline = true;
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(216, 28);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.FromArgb(230, 231, 233);
            txtSifre.BorderStyle = BorderStyle.None;
            txtSifre.Location = new Point(72, 282);
            txtSifre.Multiline = true;
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(216, 28);
            txtSifre.TabIndex = 1;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblKullaniciAdi.ForeColor = Color.FromArgb(220, 242, 241);
            lblKullaniciAdi.Location = new Point(122, 176);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(116, 28);
            lblKullaniciAdi.TabIndex = 2;
            lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSifre.ForeColor = Color.FromArgb(220, 242, 241);
            lblSifre.Location = new Point(156, 251);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(49, 28);
            lblSifre.TabIndex = 3;
            lblSifre.Text = "Şifre";
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.FromArgb(220, 242, 241);
            btnGirisYap.FlatAppearance.BorderSize = 0;
            btnGirisYap.FlatStyle = FlatStyle.Flat;
            btnGirisYap.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGirisYap.Location = new Point(72, 347);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(216, 37);
            btnGirisYap.TabIndex = 4;
            btnGirisYap.Text = "GIRIS YAP";
            btnGirisYap.UseVisualStyleBackColor = false;
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.Transparent;
            btnKayitOl.FlatStyle = FlatStyle.Flat;
            btnKayitOl.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKayitOl.ForeColor = SystemColors.ButtonFace;
            btnKayitOl.Location = new Point(72, 390);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(216, 37);
            btnKayitOl.TabIndex = 5;
            btnKayitOl.Text = "KAYIT OL";
            btnKayitOl.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe Print", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(220, 242, 241);
            label1.Location = new Point(95, 107);
            label1.Name = "label1";
            label1.Size = new Size(171, 47);
            label1.TabIndex = 6;
            label1.Text = "Hoşgeldiniz";
            // 
            // checkPassword
            // 
            checkPassword.AutoSize = true;
            checkPassword.ForeColor = Color.FromArgb(220, 242, 241);
            checkPassword.Image = (Image)resources.GetObject("checkPassword.Image");
            checkPassword.Location = new Point(296, 286);
            checkPassword.Name = "checkPassword";
            checkPassword.Size = new Size(48, 24);
            checkPassword.TabIndex = 7;
            checkPassword.Text = " ";
            checkPassword.TextImageRelation = TextImageRelation.ImageBeforeText;
            checkPassword.UseVisualStyleBackColor = true;
            checkPassword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // lblSifreUnuttum
            // 
            lblSifreUnuttum.AutoSize = true;
            lblSifreUnuttum.Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSifreUnuttum.ForeColor = Color.FromArgb(220, 242, 241);
            lblSifreUnuttum.Location = new Point(125, 440);
            lblSifreUnuttum.Name = "lblSifreUnuttum";
            lblSifreUnuttum.Size = new Size(110, 13);
            lblSifreUnuttum.TabIndex = 8;
            lblSifreUnuttum.Text = "Şifreni mi unuttun ?";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(54, 84, 134);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(128, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // frmLogin
            // 
            AcceptButton = btnGirisYap;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(54, 84, 134);
            ClientSize = new Size(359, 522);
            Controls.Add(pictureBox1);
            Controls.Add(lblSifreUnuttum);
            Controls.Add(checkPassword);
            Controls.Add(label1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblKullaniciAdi;
        private Label lblSifre;
        private Button btnGirisYap;
        private Button btnKayitOl;
        private Label label1;
        private CheckBox checkPassword;
        private Label lblSifreUnuttum;
        private PictureBox pictureBox1;
    }
}
