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
    public partial class YemekDetay : System.Web.UI.Page
    {
        sqlSinif bgl = new sqlSinif();
        string yemekid = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            yemekid = Request.QueryString["yemekid"];

            MySqlCommand komut = new MySqlCommand("select YemekAd from yemek where YemekId =@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",yemekid);
            MySqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Label3.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            //Yorumları Listeleme
            MySqlCommand yorumkomut =new MySqlCommand("select * from yorum where YemekId =@p2",bgl.baglanti());
            yorumkomut.Parameters.AddWithValue("@p2",yemekid);
            MySqlDataReader dr2 = yorumkomut.ExecuteReader();
            DataList2.DataSource = dr2;
            DataList2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MySqlCommand komut = new MySqlCommand("insert into yorum (YorumAdSoyad,YorumMail,YorumIcerik,YemekId) values (@p1,@p2,@p3,@p4)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",TextBox1.Text);
            komut.Parameters.AddWithValue("@p2", TextBox2.Text);
            komut.Parameters.AddWithValue("@p3", TextBox3.Text);
            komut.Parameters.AddWithValue("@p4", yemekid);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}