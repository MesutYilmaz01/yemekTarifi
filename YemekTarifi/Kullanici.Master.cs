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
    public partial class Kullanici : System.Web.UI.MasterPage
    {

        sqlSinif bgl = new sqlSinif();
        protected void Page_Load(object sender, EventArgs e)
        {
            MySqlCommand komut = new MySqlCommand("Select * from kategori",bgl.baglanti());
            MySqlDataReader oku = komut.ExecuteReader();
            DataList1.DataSource = oku;
            DataList1.DataBind();
        }

    }
}