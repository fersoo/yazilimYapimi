namespace yazilimYapimi
{
    partial class frmHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePage));
            btnKelimeEkle = new Button();
            btnKelimelerim = new Button();
            btnSinavOl = new Button();
            btnAyarlar = new Button();
            lblKullaniciAdi = new Label();
            lblAktifKullanici = new Label();
            label1 = new Label();
            lblisim = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnKelimeEkle
            // 
            btnKelimeEkle.BackColor = Color.FromArgb(220, 242, 241);
            btnKelimeEkle.BackgroundImageLayout = ImageLayout.None;
            btnKelimeEkle.FlatStyle = FlatStyle.Flat;
            btnKelimeEkle.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelimeEkle.Image = (Image)resources.GetObject("btnKelimeEkle.Image");
            btnKelimeEkle.ImageAlign = ContentAlignment.MiddleRight;
            btnKelimeEkle.Location = new Point(47, 162);
            btnKelimeEkle.Name = "btnKelimeEkle";
            btnKelimeEkle.Size = new Size(256, 44);
            btnKelimeEkle.TabIndex = 0;
            btnKelimeEkle.Text = "KELIME EKLE";
            btnKelimeEkle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKelimeEkle.UseVisualStyleBackColor = false;
            // 
            // btnKelimelerim
            // 
            btnKelimelerim.BackColor = Color.FromArgb(220, 242, 241);
            btnKelimelerim.FlatStyle = FlatStyle.Flat;
            btnKelimelerim.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelimelerim.Image = (Image)resources.GetObject("btnKelimelerim.Image");
            btnKelimelerim.ImageAlign = ContentAlignment.MiddleRight;
            btnKelimelerim.Location = new Point(47, 212);
            btnKelimelerim.Name = "btnKelimelerim";
            btnKelimelerim.Size = new Size(256, 44);
            btnKelimelerim.TabIndex = 1;
            btnKelimelerim.Text = "KELIMELERIM";
            btnKelimelerim.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKelimelerim.UseVisualStyleBackColor = false;
            // 
            // btnSinavOl
            // 
            btnSinavOl.BackColor = Color.FromArgb(220, 242, 241);
            btnSinavOl.FlatStyle = FlatStyle.Flat;
            btnSinavOl.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSinavOl.Image = (Image)resources.GetObject("btnSinavOl.Image");
            btnSinavOl.ImageAlign = ContentAlignment.MiddleRight;
            btnSinavOl.Location = new Point(47, 262);
            btnSinavOl.Name = "btnSinavOl";
            btnSinavOl.Size = new Size(256, 44);
            btnSinavOl.TabIndex = 2;
            btnSinavOl.Text = "SINAV OL";
            btnSinavOl.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSinavOl.UseVisualStyleBackColor = false;
            // 
            // btnAyarlar
            // 
            btnAyarlar.BackColor = Color.FromArgb(220, 242, 241);
            btnAyarlar.FlatStyle = FlatStyle.Flat;
            btnAyarlar.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAyarlar.Image = (Image)resources.GetObject("btnAyarlar.Image");
            btnAyarlar.ImageAlign = ContentAlignment.MiddleRight;
            btnAyarlar.Location = new Point(47, 312);
            btnAyarlar.Name = "btnAyarlar";
            btnAyarlar.Size = new Size(256, 44);
            btnAyarlar.TabIndex = 3;
            btnAyarlar.Text = "AYARLAR";
            btnAyarlar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAyarlar.UseVisualStyleBackColor = false;
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Font = new Font("Nirmala UI", 9F);
            lblKullaniciAdi.ForeColor = Color.FromArgb(220, 242, 241);
            lblKullaniciAdi.Location = new Point(47, 74);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(73, 15);
            lblKullaniciAdi.TabIndex = 4;
            lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // lblAktifKullanici
            // 
            lblAktifKullanici.AutoSize = true;
            lblAktifKullanici.Font = new Font("Nirmala UI", 9F);
            lblAktifKullanici.ForeColor = Color.FromArgb(220, 242, 241);
            lblAktifKullanici.Location = new Point(59, 89);
            lblAktifKullanici.Name = "lblAktifKullanici";
            lblAktifKullanici.Size = new Size(48, 15);
            lblAktifKullanici.TabIndex = 5;
            lblAktifKullanici.Text = "örnektir";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 9F);
            label1.ForeColor = Color.FromArgb(220, 242, 241);
            label1.Location = new Point(59, 40);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 7;
            label1.Text = "örnektir";
            label1.Click += label1_Click;
            // 
            // lblisim
            // 
            lblisim.AutoSize = true;
            lblisim.Font = new Font("Nirmala UI", 9F);
            lblisim.ForeColor = Color.FromArgb(220, 242, 241);
            lblisim.Location = new Point(47, 25);
            lblisim.Name = "lblisim";
            lblisim.Size = new Size(73, 15);
            lblisim.TabIndex = 6;
            lblisim.Text = "İsim Soyisim";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(54, 84, 134);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(198, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(105, 79);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // frmHomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(54, 84, 134);
            ClientSize = new Size(352, 426);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(lblisim);
            Controls.Add(lblAktifKullanici);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(btnAyarlar);
            Controls.Add(btnSinavOl);
            Controls.Add(btnKelimelerim);
            Controls.Add(btnKelimeEkle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmHomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KELIME EZBERLE - ANA SAYFA";
            Load += frmHomePage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKelimeEkle;
        private Button btnKelimelerim;
        private Button btnSinavOl;
        private Button btnAyarlar;
        private Label lblKullaniciAdi;
        private Label lblAktifKullanici;
        private Label label1;
        private Label lblisim;
        private PictureBox pictureBox2;
    }
}