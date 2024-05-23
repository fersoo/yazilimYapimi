using System.Data.SqlClient;

namespace yazilimYapimi
{
    public partial class frmLogin : Form
    {
        public static string nickname;
        public frmLogin()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
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

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM TBL_USER WHERE userNickname=@p1 and userPassword=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            nickname = txtKullaniciAdi.Text;
            if (dr.Read())
            {
                frmHomePage hp = new frmHomePage();
                hp.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Hatalı giriş yaptınız.","HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            bgl.baglanti().Close();
        }
    }
}
