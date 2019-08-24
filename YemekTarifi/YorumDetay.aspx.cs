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
    public partial class YorumDetay : System.Web.UI.Page
    {
        sqlSinif bgl = new sqlSinif();
        string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["YorumId"];

            if (Page.IsPostBack == false)
            {

                MySqlCommand komut = new MySqlCommand("select YorumAdSoyad,YorumMail,YorumIcerik,YemekAd from yorum inner join yemek on yorum.YemekId = yemek.YemekId where YorumId=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", id);
                MySqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    TextBox1.Text = dr[0].ToString();
                    TextBox2.Text = dr[1].ToString();
                    TextBox3.Text = dr[2].ToString();
                    TextBox4.Text = dr[3].ToString();

                }
                bgl.baglanti().Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MySqlCommand komut2 = new MySqlCommand("update yorum set YorumIcerik=@p1,YorumOnay=@p2 where YorumId=@p3",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1",TextBox3.Text);
            komut2.Parameters.AddWithValue("@p2",1);
            komut2.Parameters.AddWithValue("@p3",id);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}