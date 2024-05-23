using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace yazilimYapimi
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void checkSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSifreGoster.Checked)
                txtSifre.PasswordChar = '\0';
            else
                txtSifre.PasswordChar = '●';
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtMail.Text = "";
            txtisim.Text = "";
            txtSoyisim.Text = "";
            txtKullaniciAd.Text = "";
            txtSifre.Text = "";
            txtMail.Focus();
        }

        private void lblGirisYap_Click(object sender, EventArgs e)
        {
            frmLogin fl = new frmLogin();
            fl.Show();
            this.Close();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (txtMail.Text == "" || txtisim.Text == "" || txtSoyisim.Text == "" || txtKullaniciAd.Text == "" || txtSifre.Text == "")
                MessageBox.Show("Lütfen boş alanları doldurun.","Bir Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                SqlCommand komut = new SqlCommand("INSERT INTO TBL_USER(userName, userSurname, userMail, userNickname, userPassword) VALUES(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtisim.Text);
                komut.Parameters.AddWithValue("@p2", txtSoyisim.Text);
                komut.Parameters.AddWithValue("@p3", txtMail.Text);
                komut.Parameters.AddWithValue("@p4", txtKullaniciAd.Text);
                komut.Parameters.AddWithValue("@p5", txtSifre.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kaydınız başarıyla tamamlanmıştır", "Kayıt Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}

