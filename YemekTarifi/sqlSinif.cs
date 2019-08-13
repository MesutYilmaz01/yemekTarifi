using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace YemekTarifi
{
    public class sqlSinif
    {
        public SqlConnection baglanti() {
            SqlConnection baglan = new SqlConnection("Server=localhost;Uid=root;Pwd=;Database=dbo_yemektarifi;");
            baglan.Open();
            return baglan;
        }
    }
}