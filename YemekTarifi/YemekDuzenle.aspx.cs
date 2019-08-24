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
    public partial class YemekDuzenle : System.Web.UI.Page
    {
        sqlSinif bgl = new sqlSinif();
        string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["YemekId"];
            if (Page.IsPostBack == false)
            {
                MySqlCommand komut = new MySqlCommand("select * from yemek where YemekId=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", id);
                MySqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    TextBox1.Text = dr[1].ToString();
                    TextBox2.Text = dr[2].ToString();
                    TextBox3.Text = dr[3].ToString();
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
            FileUpload1.SaveAs(Server.MapPath("/resimler/" + FileUpload1.FileName));
            MySqlCommand komut = new MySqlCommand("update yemek set YemekAd=@p1,YemekMalzeme=@p2,YemekTarif=@p3,KategoriId=@p4,YemekResim=@p6 where YemekId=@p5",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",TextBox1.Text);
            komut.Parameters.AddWithValue("@p2", TextBox2.Text);
            komut.Parameters.AddWithValue("@p3", TextBox3.Text);
            komut.Parameters.AddWithValue("@p4", DropDownList1.SelectedValue);
            komut.Parameters.AddWithValue("@p5", id);
            komut.Parameters.AddWithValue("p6","~/resimler/"+FileUpload1.FileName);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Tüm yemekler için duurum 0 oldu
            MySqlCommand komut = new MySqlCommand("update yemek set durum =0",bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            ////günün yemeği için idye gore durumu 1 yapalım
            MySqlCommand komut2 = new MySqlCommand("update yemek set durum=1 where YemekId=@p1",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", id);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}