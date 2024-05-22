using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
