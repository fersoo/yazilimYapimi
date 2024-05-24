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
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void frmHomePage_Load(object sender, EventArgs e)
        {
            lblAktifKullaniciAdi.Text = frmLogin.nickname;

            SqlCommand komut = new SqlCommand("SELECT userName, userSurname FROM TBL_USER WHERE userNickname=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblAktifKullaniciAdi.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAktifAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnKelimeEkle_Click(object sender, EventArgs e)
        {
            frmAddWord add = new frmAddWord();
            add.Show();
        }

        private void lblKullaniciAdi_Click(object sender, EventArgs e)
        {

        }
    }
}
