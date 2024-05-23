namespace yazilimYapimi
{
    partial class frmResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResetPassword));
            lblGirisEkranınaDon = new Label();
            btnDegistir = new Button();
            txtSifre = new TextBox();
            lblYeniSifre = new Label();
            lblHarika = new Label();
            pictureBoxLogo = new PictureBox();
            txtSifreOnay = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // lblGirisEkranınaDon
            // 
            lblGirisEkranınaDon.AutoSize = true;
            lblGirisEkranınaDon.Cursor = Cursors.Hand;
            lblGirisEkranınaDon.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblGirisEkranınaDon.ForeColor = Color.FromArgb(220, 242, 241);
            lblGirisEkranınaDon.Location = new Point(83, 420);
            lblGirisEkranınaDon.Name = "lblGirisEkranınaDon";
            lblGirisEkranınaDon.Size = new Size(186, 23);
            lblGirisEkranınaDon.TabIndex = 42;
            lblGirisEkranınaDon.Text = "Giris yapma ekranına dön";
            lblGirisEkranınaDon.Click += lblGirisEkranınaDon_Click;
            // 
            // btnDegistir
            // 
            btnDegistir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDegistir.BackColor = Color.FromArgb(220, 242, 241);
            btnDegistir.Cursor = Cursors.Hand;
            btnDegistir.FlatAppearance.BorderSize = 0;
            btnDegistir.FlatStyle = FlatStyle.Flat;
            btnDegistir.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDegistir.Location = new Point(116, 312);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(121, 33);
            btnDegistir.TabIndex = 41;
            btnDegistir.Text = "DEGISTIR";
            btnDegistir.UseVisualStyleBackColor = false;
            btnDegistir.Click += btnDegistir_Click;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.FromArgb(230, 231, 233);
            txtSifre.BorderStyle = BorderStyle.None;
            txtSifre.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSifre.Location = new Point(73, 232);
            txtSifre.Multiline = true;
            txtSifre.Name = "txtSifre";
            txtSifre.PlaceholderText = "Yeni Şifre";
            txtSifre.Size = new Size(206, 28);
            txtSifre.TabIndex = 36;
            // 
            // lblYeniSifre
            // 
            lblYeniSifre.AutoSize = true;
            lblYeniSifre.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblYeniSifre.ForeColor = Color.FromArgb(220, 242, 241);
            lblYeniSifre.Location = new Point(73, 194);
            lblYeniSifre.Name = "lblYeniSifre";
            lblYeniSifre.Size = new Size(206, 23);
            lblYeniSifre.TabIndex = 39;
            lblYeniSifre.Text = "Yeni şifreni girmeye hazırsın!";
            // 
            // lblHarika
            // 
            lblHarika.AutoSize = true;
            lblHarika.Font = new Font("Segoe Print", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblHarika.ForeColor = Color.FromArgb(220, 242, 241);
            lblHarika.Location = new Point(116, 155);
            lblHarika.Name = "lblHarika";
            lblHarika.Size = new Size(121, 47);
            lblHarika.TabIndex = 38;
            lblHarika.Text = "Harika!";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.FromArgb(54, 84, 134);
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(124, 73);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(105, 79);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 37;
            pictureBoxLogo.TabStop = false;
            // 
            // txtSifreOnay
            // 
            txtSifreOnay.BackColor = Color.FromArgb(230, 231, 233);
            txtSifreOnay.BorderStyle = BorderStyle.None;
            txtSifreOnay.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSifreOnay.Location = new Point(73, 266);
            txtSifreOnay.Multiline = true;
            txtSifreOnay.Name = "txtSifreOnay";
            txtSifreOnay.PlaceholderText = "Yeni Şifre (Tekrar)";
            txtSifreOnay.Size = new Size(206, 28);
            txtSifreOnay.TabIndex = 43;
            // 
            // frmResetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(54, 84, 134);
            ClientSize = new Size(352, 517);
            Controls.Add(txtSifreOnay);
            Controls.Add(lblGirisEkranınaDon);
            Controls.Add(btnDegistir);
            Controls.Add(txtSifre);
            Controls.Add(lblYeniSifre);
            Controls.Add(lblHarika);
            Controls.Add(pictureBoxLogo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmResetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SIFRE YENILE";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGirisEkranınaDon;
        private Button btnDegistir;
        private TextBox txtSifre;
        private Label lblYeniSifre;
        private Label lblHarika;
        private PictureBox pictureBoxLogo;
        private TextBox txtSifreOnay;
    }
}