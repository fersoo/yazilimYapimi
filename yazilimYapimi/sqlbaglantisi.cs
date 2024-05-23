using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace yazilimYapimi
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=CELIK\\SQLEXPRESS;Initial Catalog=232802076_YazilimYapimi;Integrated Security=True;");
            baglan.Open();
            return baglan;
        }


    }
}
