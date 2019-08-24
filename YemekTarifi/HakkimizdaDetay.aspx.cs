using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace YemekTarifi
{
    public partial class HakkimizdaDetay : System.Web.UI.Page
    {
        sqlSinif bgl = new sqlSinif();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false) {
                MySqlCommand komut = new MySqlCommand("select * from hakkimizda", bgl.baglanti());
                MySqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    TextBox1.Text = dr[0].ToString();
                }
                bgl.baglanti().Close(); }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MySqlCommand komut = new MySqlCommand("update hakkimizda set metin=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",TextBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}