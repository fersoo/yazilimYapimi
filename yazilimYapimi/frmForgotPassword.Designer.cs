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
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.FromArgb(54, 84, 134);
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(120, 70);
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
            lblSifreniMiUnuttun.Location = new Point(22, 152);
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
            lblMerakEtme.Location = new Point(76, 191);
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
            lblLutfenMail.Location = new Point(88, 216);
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
            txtMail.Location = new Point(50, 263);
            txtMail.Multiline = true;
            txtMail.Name = "txtMail";
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
            btnKodGonder.Location = new Point(88, 297);
            btnKodGonder.Name = "btnKodGonder";
            btnKodGonder.Size = new Size(169, 33);
            btnKodGonder.TabIndex = 34;
            btnKodGonder.Text = "KOD GONDER";
            btnKodGonder.UseVisualStyleBackColor = false;
            // 
            // lblGirisEkranınaDon
            // 
            lblGirisEkranınaDon.AutoSize = true;
            lblGirisEkranınaDon.Cursor = Cursors.Hand;
            lblGirisEkranınaDon.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblGirisEkranınaDon.ForeColor = Color.FromArgb(220, 242, 241);
            lblGirisEkranınaDon.Location = new Point(79, 417);
            lblGirisEkranınaDon.Name = "lblGirisEkranınaDon";
            lblGirisEkranınaDon.Size = new Size(186, 23);
            lblGirisEkranınaDon.TabIndex = 35;
            lblGirisEkranınaDon.Text = "Giris yapma ekranına dön";
            lblGirisEkranınaDon.Click += label3_Click;
            // 
            // frmForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(54, 84, 134);
            ClientSize = new Size(352, 517);
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
    }
}