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
    public partial class KategoriDetay : System.Web.UI.Page
    {
        sqlSinif bgl = new sqlSinif();
        string kategoriid = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            kategoriid = Request.QueryString["KategoriId"];
            MySqlCommand komut = new MySqlCommand("select * from yemek where KategoriId=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", kategoriid);
            MySqlDataReader dr = komut.ExecuteReader();
            DataList2.DataSource = dr;
            DataList2.DataBind();
        }
    }
}