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
    public partial class TarifOnerDetay : System.Web.UI.Page
    {
        sqlSinif bgl = new sqlSinif();
        string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["TarifId"];
            if (Page.IsPostBack == false)
            {
                MySqlCommand komut = new MySqlCommand("select * from tarif where TarifId=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", id);
                MySqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    TextBox1.Text = dr[1].ToString();
                    TextBox2.Text = dr[2].ToString();
                    TextBox3.Text = dr[3].ToString();
                    TextBox4.Text = dr[5].ToString();
                    TextBox5.Text = dr[6].ToString();
                }
                bgl.baglanti().Close();

                if (Page.IsPostBack == false)
                {
                    //Kategori Listesi
                    MySqlCommand komut2 = new MySqlCommand("select * from kategori ", bgl.baglanti());
                    MySqlDataReader dr2 = komut2.ExecuteReader();
                    DropDownList1.DataTextField = "KategoriAd";
                    DropDownList1.DataValueField = "KategoriId";
                    DropDownList1.DataSource = dr2;
                    DropDownList1.DataBind();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Güncelleme
                MySqlCommand komut = new MySqlCommand("update tarif set TarifDurum=1 where TarifId=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", id);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                //Yemeği Ana Sayfaya Ekleme
                MySqlCommand komut2 = new MySqlCommand("insert into yemek (YemekAd,YemekMalzeme,YemekTarif,KategoriId) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1",TextBox1.Text);
            komut2.Parameters.AddWithValue("@p2",TextBox2.Text);
            komut2.Parameters.AddWithValue("@p3",TextBox3.Text);
            komut2.Parameters.AddWithValue("@p4",DropDownList1.SelectedValue);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}

