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
using System.IO;

namespace yazilimYapimi
{

    public partial class frmAddWord : Form
    {
        public frmAddWord()
        {
            InitializeComponent();
        }
        public static int kullaniciID;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void frmAddWord_Load(object sender, EventArgs e)
        {
            lblAktifKullanici.Text = frmLogin.nickname;

            SqlCommand cmd = new SqlCommand("SELECT userID FROM TBL_USER WHERE userNickname = @p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", lblAktifKullanici.Text);
            kullaniciID = (int)cmd.ExecuteScalar();
            lblAktifID.Text = kullaniciID.ToString();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmHomePage hp = new frmHomePage();
            hp.Show();
            this.Close();
        }

        private void btniceaktar_Click(object sender, EventArgs e)
        {


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.ShowDialog();
                string filepath = openFileDialog1.FileName;
                pictureBoxOrnekResim.Image = Image.FromFile(filepath);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            pictureBoxOrnekResim.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] pic = stream.ToArray();

            if (txtENG.Text == "" || txtTR.Text == "")
                MessageBox.Show("Lütfen kelimenin türkçe ve ingilizce anlamını girin.", "Bir Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                SqlCommand cmd2 = new SqlCommand("INSERT INTO TBL_WORD(wordENG,wordTR,wordExample1,wordExample2,wordExample3,wordImage,userID) VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
                cmd2.Parameters.AddWithValue("@p1", txtENG.Text);
                cmd2.Parameters.AddWithValue("@p2", txtTR.Text);
                cmd2.Parameters.AddWithValue("@p3", txtOrnekCumle.Text);
                cmd2.Parameters.AddWithValue("@p4", txtOrnekCumle2.Text);
                cmd2.Parameters.AddWithValue("@p5", txtOrnekCumle3.Text);
                cmd2.Parameters.AddWithValue("@p6", pic);
                cmd2.Parameters.AddWithValue("@p7", lblAktifID.Text);
                cmd2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kelimeniz başarıyla eklenmiştir.", "Kelime ekleme başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtENG.Text = "";
                txtTR.Text = "";
                txtOrnekCumle.Text = "";
                txtOrnekCumle2.Text = "";
                txtOrnekCumle3.Text = "";
                pictureBoxOrnekResim.Image = null;

                txtENG.Focus();
            }
        }
    }
}
