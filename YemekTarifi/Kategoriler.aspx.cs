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
    public partial class Kategoriler : System.Web.UI.Page
    {
        sqlSinif bgl = new sqlSinif();
        string id = "";
        string islem = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                id = Request.QueryString["KategoriId"];
                islem = Request.QueryString["islem"];
            }
                MySqlCommand komut = new MySqlCommand("select * from kategori", bgl.baglanti());
                MySqlDataReader dr = komut.ExecuteReader();
                DataList1.DataSource = dr;
                DataList1.DataBind();
                Panel2.Visible = false;

            //Silme işlemi
            if (islem == "sil") {

                MySqlCommand komutsil = new MySqlCommand("delete from kategori where KategoriId = @p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1",id);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                    }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel2.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Panel2.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Panel4.Visible = true;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Panel4.Visible = false;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            MySqlCommand komut = new MySqlCommand("insert into kategori (KategoriAd) values (@p1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",TextBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}