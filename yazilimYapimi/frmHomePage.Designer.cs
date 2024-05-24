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
            lblAktifKullaniciAdi = new Label();
            lblAktifAdSoyad = new Label();
            lblAdSoyad = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnKelimeEkle
            // 
            btnKelimeEkle.BackColor = Color.FromArgb(220, 242, 241);
            btnKelimeEkle.BackgroundImageLayout = ImageLayout.None;
            btnKelimeEkle.Cursor = Cursors.Hand;
            btnKelimeEkle.FlatAppearance.BorderSize = 0;
            btnKelimeEkle.FlatStyle = FlatStyle.Flat;
            btnKelimeEkle.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelimeEkle.Image = (Image)resources.GetObject("btnKelimeEkle.Image");
            btnKelimeEkle.ImageAlign = ContentAlignment.MiddleRight;
            btnKelimeEkle.Location = new Point(47, 180);
            btnKelimeEkle.Name = "btnKelimeEkle";
            btnKelimeEkle.Size = new Size(256, 44);
            btnKelimeEkle.TabIndex = 0;
            btnKelimeEkle.Text = "KELIME EKLE";
            btnKelimeEkle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKelimeEkle.UseVisualStyleBackColor = false;
            btnKelimeEkle.Click += btnKelimeEkle_Click;
            // 
            // btnKelimelerim
            // 
            btnKelimelerim.BackColor = Color.FromArgb(220, 242, 241);
            btnKelimelerim.BackgroundImageLayout = ImageLayout.None;
            btnKelimelerim.Cursor = Cursors.Hand;
            btnKelimelerim.FlatAppearance.BorderSize = 0;
            btnKelimelerim.FlatStyle = FlatStyle.Flat;
            btnKelimelerim.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelimelerim.Image = (Image)resources.GetObject("btnKelimelerim.Image");
            btnKelimelerim.ImageAlign = ContentAlignment.MiddleRight;
            btnKelimelerim.Location = new Point(47, 230);
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
            btnSinavOl.Cursor = Cursors.Hand;
            btnSinavOl.FlatAppearance.BorderSize = 0;
            btnSinavOl.FlatStyle = FlatStyle.Flat;
            btnSinavOl.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSinavOl.Image = (Image)resources.GetObject("btnSinavOl.Image");
            btnSinavOl.ImageAlign = ContentAlignment.MiddleRight;
            btnSinavOl.Location = new Point(47, 280);
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
            btnAyarlar.Cursor = Cursors.Hand;
            btnAyarlar.FlatAppearance.BorderSize = 0;
            btnAyarlar.FlatStyle = FlatStyle.Flat;
            btnAyarlar.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAyarlar.Image = (Image)resources.GetObject("btnAyarlar.Image");
            btnAyarlar.ImageAlign = ContentAlignment.MiddleRight;
            btnAyarlar.Location = new Point(47, 330);
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
            lblKullaniciAdi.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKullaniciAdi.ForeColor = Color.FromArgb(220, 242, 241);
            lblKullaniciAdi.Location = new Point(47, 82);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(84, 21);
            lblKullaniciAdi.TabIndex = 4;
            lblKullaniciAdi.Text = "Kullanıcı Adı";
            lblKullaniciAdi.Click += lblKullaniciAdi_Click;
            // 
            // lblAktifKullaniciAdi
            // 
            lblAktifKullaniciAdi.AutoSize = true;
            lblAktifKullaniciAdi.Font = new Font("Nirmala UI", 9F);
            lblAktifKullaniciAdi.ForeColor = Color.FromArgb(220, 242, 241);
            lblAktifKullaniciAdi.Location = new Point(47, 103);
            lblAktifKullaniciAdi.Name = "lblAktifKullaniciAdi";
            lblAktifKullaniciAdi.Size = new Size(48, 15);
            lblAktifKullaniciAdi.TabIndex = 5;
            lblAktifKullaniciAdi.Text = "örnektir";
//            lblAktifKullaniciAdi.Click += this.lblAktifKullaniciAdi_Click;
            // 
            // lblAktifAdSoyad
            // 
            lblAktifAdSoyad.AutoSize = true;
            lblAktifAdSoyad.Font = new Font("Nirmala UI", 9F);
            lblAktifAdSoyad.ForeColor = Color.FromArgb(220, 242, 241);
            lblAktifAdSoyad.Location = new Point(47, 57);
            lblAktifAdSoyad.Name = "lblAktifAdSoyad";
            lblAktifAdSoyad.Size = new Size(48, 15);
            lblAktifAdSoyad.TabIndex = 7;
            lblAktifAdSoyad.Text = "örnektir";
            lblAktifAdSoyad.Click += label1_Click;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdSoyad.ForeColor = Color.FromArgb(220, 242, 241);
            lblAdSoyad.Location = new Point(47, 36);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(69, 21);
            lblAdSoyad.TabIndex = 6;
            lblAdSoyad.Text = "Ad Soyad";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(54, 84, 134);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(198, 36);
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
            ClientSize = new Size(352, 423);
            Controls.Add(pictureBox2);
            Controls.Add(lblAktifAdSoyad);
            Controls.Add(lblAdSoyad);
            Controls.Add(lblAktifKullaniciAdi);
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
        private Label lblAktifKullaniciAdi;
        private Label lblAktifAdSoyad;
        private Label lblAdSoyad;
        private PictureBox pictureBox2;
    }
}