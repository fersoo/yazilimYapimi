namespace yazilimYapimi
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtKullaniciAdi.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSifreGoster.Checked)
                txtSifre.PasswordChar = '\0';
            else
                txtSifre.PasswordChar = '●';
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            frmRegister fr = new frmRegister();
            fr.Show();
            this.Hide();
        }

        private void lblSifreUnuttum_Click(object sender, EventArgs e)
        {
            frmForgotPassword ffp = new frmForgotPassword();
            ffp.Show();
            this.Hide();
        }
    }
}
