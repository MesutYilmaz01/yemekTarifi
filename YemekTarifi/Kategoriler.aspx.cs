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

        protected void Page_Load(object sender, EventArgs e)
        {
            MySqlCommand komut = new MySqlCommand("select * from kategori",bgl.baglanti());
            MySqlDataReader dr = komut.ExecuteReader();
            DataList1.DataSource = dr;
            DataList1.DataBind();
        }
    }
}