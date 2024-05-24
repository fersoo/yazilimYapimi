namespace yazilimYapimi
{
    partial class frmAddWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddWord));
            txtTR = new TextBox();
            txtENG = new TextBox();
            txtOrnekCumle2 = new TextBox();
            txtOrnekCumle3 = new TextBox();
            txtOrnekCumle = new TextBox();
            pictureBoxOrnekResim = new PictureBox();
            lblENGkelime = new Label();
            lblTRkelime = new Label();
            lblOrnekCumle = new Label();
            lblOrnekCumle2 = new Label();
            lblOrnekCumle3 = new Label();
            lblOrnekResim = new Label();
            btnEkle = new Button();
            btnGeri = new Button();
            pictureBox2 = new PictureBox();
            btniceaktar = new Button();
            lblAktifKullanici = new Label();
            lblAktifID = new Label();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOrnekResim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtTR
            // 
            txtTR.BackColor = Color.FromArgb(230, 231, 233);
            txtTR.BorderStyle = BorderStyle.None;
            txtTR.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTR.Location = new Point(28, 252);
            txtTR.Multiline = true;
            txtTR.Name = "txtTR";
            txtTR.Size = new Size(182, 28);
            txtTR.TabIndex = 2;
            // 
            // txtENG
            // 
            txtENG.BackColor = Color.FromArgb(230, 231, 233);
            txtENG.BorderStyle = BorderStyle.None;
            txtENG.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtENG.Location = new Point(28, 154);
            txtENG.Multiline = true;
            txtENG.Name = "txtENG";
            txtENG.Size = new Size(182, 28);
            txtENG.TabIndex = 1;
            // 
            // txtOrnekCumle2
            // 
            txtOrnekCumle2.BackColor = Color.FromArgb(230, 231, 233);
            txtOrnekCumle2.BorderStyle = BorderStyle.None;
            txtOrnekCumle2.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOrnekCumle2.Location = new Point(249, 283);
            txtOrnekCumle2.Multiline = true;
            txtOrnekCumle2.Name = "txtOrnekCumle2";
            txtOrnekCumle2.Size = new Size(228, 95);
            txtOrnekCumle2.TabIndex = 3;
            // 
            // txtOrnekCumle3
            // 
            txtOrnekCumle3.BackColor = Color.FromArgb(230, 231, 233);
            txtOrnekCumle3.BorderStyle = BorderStyle.None;
            txtOrnekCumle3.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOrnekCumle3.Location = new Point(249, 412);
            txtOrnekCumle3.Multiline = true;
            txtOrnekCumle3.Name = "txtOrnekCumle3";
            txtOrnekCumle3.Size = new Size(228, 95);
            txtOrnekCumle3.TabIndex = 4;
            // 
            // txtOrnekCumle
            // 
            txtOrnekCumle.BackColor = Color.FromArgb(230, 231, 233);
            txtOrnekCumle.BorderStyle = BorderStyle.None;
            txtOrnekCumle.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOrnekCumle.Location = new Point(249, 154);
            txtOrnekCumle.Multiline = true;
            txtOrnekCumle.Name = "txtOrnekCumle";
            txtOrnekCumle.Size = new Size(228, 95);
            txtOrnekCumle.TabIndex = 5;
            // 
            // pictureBoxOrnekResim
            // 
            pictureBoxOrnekResim.BackColor = Color.FromArgb(230, 231, 233);
            pictureBoxOrnekResim.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxOrnekResim.InitialImage = (Image)resources.GetObject("pictureBoxOrnekResim.InitialImage");
            pictureBoxOrnekResim.Location = new Point(28, 355);
            pictureBoxOrnekResim.Name = "pictureBoxOrnekResim";
            pictureBoxOrnekResim.Size = new Size(182, 152);
            pictureBoxOrnekResim.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxOrnekResim.TabIndex = 6;
            pictureBoxOrnekResim.TabStop = false;
            // 
            // lblENGkelime
            // 
            lblENGkelime.AutoSize = true;
            lblENGkelime.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblENGkelime.ForeColor = Color.FromArgb(220, 242, 241);
            lblENGkelime.Location = new Point(28, 123);
            lblENGkelime.Name = "lblENGkelime";
            lblENGkelime.Size = new Size(136, 28);
            lblENGkelime.TabIndex = 23;
            lblENGkelime.Text = "Ingilizce Kelime";
            // 
            // lblTRkelime
            // 
            lblTRkelime.AutoSize = true;
            lblTRkelime.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTRkelime.ForeColor = Color.FromArgb(220, 242, 241);
            lblTRkelime.Location = new Point(28, 221);
            lblTRkelime.Name = "lblTRkelime";
            lblTRkelime.Size = new Size(130, 28);
            lblTRkelime.TabIndex = 24;
            lblTRkelime.Text = "Türkçe Anlamı";
            // 
            // lblOrnekCumle
            // 
            lblOrnekCumle.AutoSize = true;
            lblOrnekCumle.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblOrnekCumle.ForeColor = Color.FromArgb(220, 242, 241);
            lblOrnekCumle.Location = new Point(249, 123);
            lblOrnekCumle.Name = "lblOrnekCumle";
            lblOrnekCumle.Size = new Size(205, 28);
            lblOrnekCumle.TabIndex = 25;
            lblOrnekCumle.Text = "Örnek cümle (opsiyonel)";
            // 
            // lblOrnekCumle2
            // 
            lblOrnekCumle2.AutoSize = true;
            lblOrnekCumle2.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblOrnekCumle2.ForeColor = Color.FromArgb(220, 242, 241);
            lblOrnekCumle2.Location = new Point(249, 252);
            lblOrnekCumle2.Name = "lblOrnekCumle2";
            lblOrnekCumle2.Size = new Size(223, 28);
            lblOrnekCumle2.TabIndex = 26;
            lblOrnekCumle2.Text = "Örnek cümle 2 (opsiyonel)";
            // 
            // lblOrnekCumle3
            // 
            lblOrnekCumle3.AutoSize = true;
            lblOrnekCumle3.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblOrnekCumle3.ForeColor = Color.FromArgb(220, 242, 241);
            lblOrnekCumle3.Location = new Point(249, 381);
            lblOrnekCumle3.Name = "lblOrnekCumle3";
            lblOrnekCumle3.Size = new Size(223, 28);
            lblOrnekCumle3.TabIndex = 27;
            lblOrnekCumle3.Text = "Örnek cümle 3 (opsiyonel)";
            // 
            // lblOrnekResim
            // 
            lblOrnekResim.AutoSize = true;
            lblOrnekResim.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblOrnekResim.ForeColor = Color.FromArgb(220, 242, 241);
            lblOrnekResim.Location = new Point(28, 324);
            lblOrnekResim.Name = "lblOrnekResim";
            lblOrnekResim.Size = new Size(159, 28);
            lblOrnekResim.TabIndex = 28;
            lblOrnekResim.Text = "Örnek Resim (ops)";
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.LightSkyBlue;
            btnEkle.FlatAppearance.BorderColor = Color.Black;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnEkle.Image = (Image)resources.GetObject("btnEkle.Image");
            btnEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btnEkle.Location = new Point(370, 43);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(107, 44);
            btnEkle.TabIndex = 31;
            btnEkle.Text = "EKLE";
            btnEkle.TextAlign = ContentAlignment.MiddleRight;
            btnEkle.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.IndianRed;
            btnGeri.FlatAppearance.BorderColor = Color.Black;
            btnGeri.FlatStyle = FlatStyle.Flat;
            btnGeri.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnGeri.ForeColor = SystemColors.ButtonHighlight;
            btnGeri.Image = (Image)resources.GetObject("btnGeri.Image");
            btnGeri.ImageAlign = ContentAlignment.MiddleLeft;
            btnGeri.Location = new Point(249, 43);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(107, 44);
            btnGeri.TabIndex = 32;
            btnGeri.Text = "GERI";
            btnGeri.TextAlign = ContentAlignment.MiddleRight;
            btnGeri.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(28, 43);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(109, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // btniceaktar
            // 
            btniceaktar.Location = new Point(83, 513);
            btniceaktar.Name = "btniceaktar";
            btniceaktar.Size = new Size(75, 23);
            btniceaktar.TabIndex = 3;
            btniceaktar.Text = "İçe aktar...";
            btniceaktar.UseVisualStyleBackColor = true;
            btniceaktar.Click += btniceaktar_Click;
            // 
            // lblAktifKullanici
            // 
            lblAktifKullanici.AutoSize = true;
            lblAktifKullanici.ForeColor = SystemColors.ButtonFace;
            lblAktifKullanici.Location = new Point(28, 9);
            lblAktifKullanici.Name = "lblAktifKullanici";
            lblAktifKullanici.Size = new Size(80, 15);
            lblAktifKullanici.TabIndex = 34;
            lblAktifKullanici.Text = "Aktif Kullanıcı";
            lblAktifKullanici.Click += label1_Click;
            // 
            // lblAktifID
            // 
            lblAktifID.AutoSize = true;
            lblAktifID.ForeColor = SystemColors.ButtonFace;
            lblAktifID.Location = new Point(28, 24);
            lblAktifID.Name = "lblAktifID";
            lblAktifID.Size = new Size(94, 15);
            lblAktifID.TabIndex = 35;
            lblAktifID.Text = "Aktif Kullanıcı ID";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAddWord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(54, 84, 134);
            ClientSize = new Size(500, 565);
            Controls.Add(lblAktifID);
            Controls.Add(lblAktifKullanici);
            Controls.Add(btniceaktar);
            Controls.Add(pictureBox2);
            Controls.Add(btnGeri);
            Controls.Add(btnEkle);
            Controls.Add(lblOrnekResim);
            Controls.Add(lblOrnekCumle3);
            Controls.Add(lblOrnekCumle2);
            Controls.Add(lblOrnekCumle);
            Controls.Add(lblTRkelime);
            Controls.Add(lblENGkelime);
            Controls.Add(pictureBoxOrnekResim);
            Controls.Add(txtOrnekCumle);
            Controls.Add(txtOrnekCumle3);
            Controls.Add(txtOrnekCumle2);
            Controls.Add(txtENG);
            Controls.Add(txtTR);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmAddWord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KELIME EZBERLE - KELIME EKLEME";
            Load += frmAddWord_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxOrnekResim).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTR;
        private TextBox txtENG;
        private TextBox txtOrnekCumle2;
        private TextBox txtOrnekCumle3;
        private TextBox txtOrnekCumle;
        private PictureBox pictureBoxOrnekResim;
        private Label lblENGkelime;
        private Label lblTRkelime;
        private Label lblOrnekCumle;
        private Label lblOrnekCumle2;
        private Label lblOrnekCumle3;
        private Label lblOrnekResim;
        private Button btnEkle;
        private Button btnGeri;
        private PictureBox pictureBox2;
        private Button btniceaktar;
        private Label lblAktifKullanici;
        private Label lblAktifID;
        private OpenFileDialog openFileDialog1;
    }
}