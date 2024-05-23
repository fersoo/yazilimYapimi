namespace yazilimYapimi
{
    partial class frmForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForgotPassword));
            pictureBoxLogo = new PictureBox();
            lblSifreniMiUnuttun = new Label();
            lblMerakEtme = new Label();
            lblLutfenMail = new Label();
            txtMail = new TextBox();
            btnKodGonder = new Button();
            lblGirisEkranınaDon = new Label();
            btnDogrula = new Button();
            txtDogrulamaKodu = new TextBox();
            lblKodBasari = new Label();
            lblKodBasarisiz = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.FromArgb(54, 84, 134);
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(122, 70);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(105, 79);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 30;
            pictureBoxLogo.TabStop = false;
            // 
            // lblSifreniMiUnuttun
            // 
            lblSifreniMiUnuttun.AutoSize = true;
            lblSifreniMiUnuttun.Font = new Font("Segoe Print", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSifreniMiUnuttun.ForeColor = Color.FromArgb(220, 242, 241);
            lblSifreniMiUnuttun.Location = new Point(24, 152);
            lblSifreniMiUnuttun.Name = "lblSifreniMiUnuttun";
            lblSifreniMiUnuttun.Size = new Size(301, 47);
            lblSifreniMiUnuttun.TabIndex = 31;
            lblSifreniMiUnuttun.Text = "Şifreni mi unuttun ?";
            // 
            // lblMerakEtme
            // 
            lblMerakEtme.AutoSize = true;
            lblMerakEtme.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblMerakEtme.ForeColor = Color.FromArgb(220, 242, 241);
            lblMerakEtme.Location = new Point(78, 191);
            lblMerakEtme.Name = "lblMerakEtme";
            lblMerakEtme.Size = new Size(193, 23);
            lblMerakEtme.TabIndex = 32;
            lblMerakEtme.Text = "Merak etme biz yanındayız";
            lblMerakEtme.Click += label1_Click;
            // 
            // lblLutfenMail
            // 
            lblLutfenMail.AutoSize = true;
            lblLutfenMail.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblLutfenMail.ForeColor = Color.FromArgb(220, 242, 241);
            lblLutfenMail.Location = new Point(90, 216);
            lblLutfenMail.Name = "lblLutfenMail";
            lblLutfenMail.Size = new Size(169, 23);
            lblLutfenMail.TabIndex = 33;
            lblLutfenMail.Text = "Lütfen mail adresini gir";
            // 
            // txtMail
            // 
            txtMail.BackColor = Color.FromArgb(230, 231, 233);
            txtMail.BorderStyle = BorderStyle.None;
            txtMail.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMail.Location = new Point(55, 299);
            txtMail.Multiline = true;
            txtMail.Name = "txtMail";
            txtMail.PlaceholderText = "Mail adresiniz";
            txtMail.Size = new Size(244, 28);
            txtMail.TabIndex = 0;
            // 
            // btnKodGonder
            // 
            btnKodGonder.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnKodGonder.BackColor = Color.FromArgb(220, 242, 241);
            btnKodGonder.Cursor = Cursors.Hand;
            btnKodGonder.FlatAppearance.BorderSize = 0;
            btnKodGonder.FlatStyle = FlatStyle.Flat;
            btnKodGonder.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKodGonder.Location = new Point(115, 333);
            btnKodGonder.Name = "btnKodGonder";
            btnKodGonder.Size = new Size(125, 33);
            btnKodGonder.TabIndex = 34;
            btnKodGonder.Text = "KOD GONDER";
            btnKodGonder.UseVisualStyleBackColor = false;
            btnKodGonder.Click += btnKodGonder_Click;
            // 
            // lblGirisEkranınaDon
            // 
            lblGirisEkranınaDon.AutoSize = true;
            lblGirisEkranınaDon.Cursor = Cursors.Hand;
            lblGirisEkranınaDon.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblGirisEkranınaDon.ForeColor = Color.FromArgb(220, 242, 241);
            lblGirisEkranınaDon.Location = new Point(81, 511);
            lblGirisEkranınaDon.Name = "lblGirisEkranınaDon";
            lblGirisEkranınaDon.Size = new Size(186, 23);
            lblGirisEkranınaDon.TabIndex = 35;
            lblGirisEkranınaDon.Text = "Giris yapma ekranına dön";
            lblGirisEkranınaDon.Click += label3_Click;
            // 
            // btnDogrula
            // 
            btnDogrula.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDogrula.BackColor = Color.FromArgb(220, 242, 241);
            btnDogrula.Cursor = Cursors.Hand;
            btnDogrula.FlatAppearance.BorderSize = 0;
            btnDogrula.FlatStyle = FlatStyle.Flat;
            btnDogrula.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDogrula.Location = new Point(115, 443);
            btnDogrula.Name = "btnDogrula";
            btnDogrula.Size = new Size(125, 33);
            btnDogrula.TabIndex = 37;
            btnDogrula.Text = "DOGRULA";
            btnDogrula.UseVisualStyleBackColor = false;
            btnDogrula.Click += button1_Click;
            // 
            // txtDogrulamaKodu
            // 
            txtDogrulamaKodu.BackColor = Color.FromArgb(230, 231, 233);
            txtDogrulamaKodu.BorderStyle = BorderStyle.None;
            txtDogrulamaKodu.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDogrulamaKodu.Location = new Point(55, 409);
            txtDogrulamaKodu.Multiline = true;
            txtDogrulamaKodu.Name = "txtDogrulamaKodu";
            txtDogrulamaKodu.PlaceholderText = "Doğrulama kodu";
            txtDogrulamaKodu.Size = new Size(244, 28);
            txtDogrulamaKodu.TabIndex = 36;
            // 
            // lblKodBasari
            // 
            lblKodBasari.AutoSize = true;
            lblKodBasari.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblKodBasari.ForeColor = Color.FromArgb(220, 242, 241);
            lblKodBasari.Location = new Point(55, 273);
            lblKodBasari.Name = "lblKodBasari";
            lblKodBasari.Size = new Size(183, 23);
            lblKodBasari.TabIndex = 38;
            lblKodBasari.Text = "Kod başarıyla gönderildi...";
            lblKodBasari.Visible = false;
            // 
            // lblKodBasarisiz
            // 
            lblKodBasarisiz.AutoSize = true;
            lblKodBasarisiz.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblKodBasarisiz.ForeColor = Color.FromArgb(220, 242, 241);
            lblKodBasarisiz.Location = new Point(55, 273);
            lblKodBasarisiz.Name = "lblKodBasarisiz";
            lblKodBasarisiz.Size = new Size(247, 23);
            lblKodBasarisiz.TabIndex = 39;
            lblKodBasarisiz.Text = "Kod gönderilemedi. Tekrar deneyin";
            lblKodBasarisiz.Visible = false;
            // 
            // frmForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(54, 84, 134);
            ClientSize = new Size(352, 592);
            Controls.Add(lblKodBasarisiz);
            Controls.Add(lblKodBasari);
            Controls.Add(btnDogrula);
            Controls.Add(txtDogrulamaKodu);
            Controls.Add(lblGirisEkranınaDon);
            Controls.Add(btnKodGonder);
            Controls.Add(txtMail);
            Controls.Add(lblLutfenMail);
            Controls.Add(lblMerakEtme);
            Controls.Add(lblSifreniMiUnuttun);
            Controls.Add(pictureBoxLogo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SIFREMI UNUTTUM";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private Label lblSifreniMiUnuttun;
        private Label lblMerakEtme;
        private Label lblLutfenMail;
        private TextBox txtMail;
        private Button btnKodGonder;
        private Label lblGirisEkranınaDon;
        private Button btnDogrula;
        private TextBox txtDogrulamaKodu;
        private Label lblKodBasari;
        private Label lblKodBasarisiz;
    }
}