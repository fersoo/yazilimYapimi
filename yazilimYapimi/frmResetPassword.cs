using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazilimYapimi
{
    public partial class frmResetPassword : Form
    {
        string email = frmForgotPassword.to;
        public frmResetPassword()
        {
            InitializeComponent();
        }

        private void lblGirisEkranınaDon_Click(object sender, EventArgs e)
        {
            frmLogin fl = new frmLogin();
            fl.Show();
            this.Hide();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if(txtSifre.Text == txtSifreOnay.Text)
            {
                SqlCommand komut = new SqlCommand("UPDATE TBL_USER SET userPassword = @p1 WHERE userMail = @p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtSifreOnay.Text);
                komut.Parameters.AddWithValue("@p2", email);
                komut.ExecuteNonQuery();

                MessageBox.Show("Şifreniz başarıyla değişmiştir.", "ŞİFRE DEĞİŞTİRİLDİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bgl.baglanti().Close();
            }
            else
                MessageBox.Show("Şifre değiştirilirken bir hata meydana geldi. Şifreniz uyuşmamaktadır.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
        }
    }
}
