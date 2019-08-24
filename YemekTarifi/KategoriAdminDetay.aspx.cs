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
    public partial class KategoriAdminDetay : System.Web.UI.Page
    {
        sqlSinif bgl = new sqlSinif();
        string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["KategoriId"];
            if (Page.IsPostBack == false)
            {
                MySqlCommand komut = new MySqlCommand("select * from kategori where KategoriId=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", id);
                MySqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    TextBox1.Text = dr[1].ToString();
                    TextBox2.Text = dr[2].ToString();
                }
                bgl.baglanti().Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MySqlCommand komut = new MySqlCommand("update kategori set KategoriAd=@p1,KategoriAdet=@p2 where KategoriId=@p3",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",TextBox1.Text);
            komut.Parameters.AddWithValue("@p2",TextBox2.Text);
            komut.Parameters.AddWithValue("@p3",id);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}