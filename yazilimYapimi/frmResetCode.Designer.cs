namespace yazilimYapimi
{
    partial class frmResetCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResetCode));
            lblGirisEkranınaDon = new Label();
            btnDogrula = new Button();
            txtKod = new TextBox();
            lblKoduGir = new Label();
            lblLutfenMail = new Label();
            lblSifreniMiUnuttun = new Label();
            pictureBoxLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // lblGirisEkranınaDon
            // 
            lblGirisEkranınaDon.AutoSize = true;
            lblGirisEkranınaDon.Cursor = Cursors.Hand;
            lblGirisEkranınaDon.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblGirisEkranınaDon.ForeColor = Color.FromArgb(220, 242, 241);
            lblGirisEkranınaDon.Location = new Point(80, 420);
            lblGirisEkranınaDon.Name = "lblGirisEkranınaDon";
            lblGirisEkranınaDon.Size = new Size(186, 23);
            lblGirisEkranınaDon.TabIndex = 42;
            lblGirisEkranınaDon.Text = "Giris yapma ekranına dön";
            // 
            // btnDogrula
            // 
            btnDogrula.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDogrula.BackColor = Color.FromArgb(220, 242, 241);
            btnDogrula.Cursor = Cursors.Hand;
            btnDogrula.FlatAppearance.BorderSize = 0;
            btnDogrula.FlatStyle = FlatStyle.Flat;
            btnDogrula.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDogrula.Location = new Point(89, 300);
            btnDogrula.Name = "btnDogrula";
            btnDogrula.Size = new Size(169, 33);
            btnDogrula.TabIndex = 41;
            btnDogrula.Text = "DOGRULA";
            btnDogrula.UseVisualStyleBackColor = false;
            // 
            // txtKod
            // 
            txtKod.BackColor = Color.FromArgb(230, 231, 233);
            txtKod.BorderStyle = BorderStyle.None;
            txtKod.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKod.Location = new Point(89, 266);
            txtKod.Multiline = true;
            txtKod.Name = "txtKod";
            txtKod.Size = new Size(169, 28);
            txtKod.TabIndex = 36;
            // 
            // lblKoduGir
            // 
            lblKoduGir.AutoSize = true;
            lblKoduGir.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblKoduGir.ForeColor = Color.FromArgb(220, 242, 241);
            lblKoduGir.Location = new Point(140, 219);
            lblKoduGir.Name = "lblKoduGir";
            lblKoduGir.Size = new Size(67, 23);
            lblKoduGir.TabIndex = 40;
            lblKoduGir.Text = "Kodu gir";
            // 
            // lblLutfenMail
            // 
            lblLutfenMail.AutoSize = true;
            lblLutfenMail.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblLutfenMail.ForeColor = Color.FromArgb(220, 242, 241);
            lblLutfenMail.Location = new Point(49, 196);
            lblLutfenMail.Name = "lblLutfenMail";
            lblLutfenMail.Size = new Size(248, 23);
            lblLutfenMail.TabIndex = 39;
            lblLutfenMail.Text = "Lütfen mail adresine gönderdiğimiz";
            // 
            // lblSifreniMiUnuttun
            // 
            lblSifreniMiUnuttun.AutoSize = true;
            lblSifreniMiUnuttun.Font = new Font("Segoe Print", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSifreniMiUnuttun.ForeColor = Color.FromArgb(220, 242, 241);
            lblSifreniMiUnuttun.Location = new Point(23, 155);
            lblSifreniMiUnuttun.Name = "lblSifreniMiUnuttun";
            lblSifreniMiUnuttun.Size = new Size(301, 47);
            lblSifreniMiUnuttun.TabIndex = 38;
            lblSifreniMiUnuttun.Text = "Şifreni mi unuttun ?";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.FromArgb(54, 84, 134);
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(121, 73);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(105, 79);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 37;
            pictureBoxLogo.TabStop = false;
            // 
            // frmResetCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(54, 84, 134);
            ClientSize = new Size(352, 517);
            Controls.Add(lblGirisEkranınaDon);
            Controls.Add(btnDogrula);
            Controls.Add(txtKod);
            Controls.Add(lblKoduGir);
            Controls.Add(lblLutfenMail);
            Controls.Add(lblSifreniMiUnuttun);
            Controls.Add(pictureBoxLogo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmResetCode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SIFREMI UNUTTUM";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGirisEkranınaDon;
        private Button btnDogrula;
        private TextBox txtKod;
        private Label lblKoduGir;
        private Label lblLutfenMail;
        private Label lblSifreniMiUnuttun;
        private PictureBox pictureBoxLogo;
    }
}