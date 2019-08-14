using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace YemekTarifi
{
    public class sqlSinif
    {
        public MySqlConnection baglanti() {
            MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=dbo_yemektarifi;User=root;Password=;");
            baglan.Open();
            return baglan;
        }
    }
}