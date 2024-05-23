using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazilimYapimi
{
    public partial class frmForgotPassword : Form
    {
        string randomcode;
        public static string to;
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmLogin fl = new frmLogin();
            fl.Show();
            this.Close();
        }

        private void btnKodGonder_Click(object sender, EventArgs e)
        {
            if(txtMail.Text == "")
                MessageBox.Show("Lütfen mail adresinizi giriniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string from, pass, messagebody;
                Random rand = new Random();
                randomcode = (rand.Next(999999)).ToString();

                MailMessage message = new MailMessage();

                to = (txtMail.Text).ToString();
                from = "kezberle@gmail.com";
                pass = "epmk pngz ayrd crav";
                messagebody = $"Şifre yenileme kodunuz ---> {randomcode}";

                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messagebody;
                message.Subject = "ŞİFRE YENİLEME KODUNUZ";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Şifre yenileme kodunuz gönderilmiştir", "Kod gönderildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblKodBasari.Visible = true;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblKodBasarisiz.Visible = true;
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (randomcode == (txtDogrulamaKodu.Text).ToString())
            {
                to = txtMail.Text;
                frmResetPassword frp = new frmResetPassword();
                frp.Show();
                this.Hide();
            }
            else            
                MessageBox.Show("Doğrulama kodunuz yanlış girdiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);           
        }
    }
}
