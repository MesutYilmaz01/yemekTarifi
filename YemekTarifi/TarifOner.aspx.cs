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
    public partial class TarifOner : System.Web.UI.Page
    {

        sqlSinif bgl = new sqlSinif();
        protected void Page_Load(object sender, EventArgs e)
        {   

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void BtnTarifOner_Click(object sender, EventArgs e)
        {
            MySqlCommand komut = new MySqlCommand("insert into tarif (TarifAd,TarifMalzeme,TarifYapilis,TarifSahip,TarifSahipEmail,TarifResim) values (@t1,@t2,@t3,@t4,@t5,@t6)",bgl.baglanti());
            komut.Parameters.AddWithValue("@t1",TxtTarifAd.Text);
            komut.Parameters.AddWithValue("@t2", TxtTarifMalzeme.Text);
            komut.Parameters.AddWithValue("@t3", TxtTarifYapilis.Text);
            komut.Parameters.AddWithValue("@t4", TxtTarifÖneren.Text);
            komut.Parameters.AddWithValue("@t5", TxtTarifMail.Text);
            komut.Parameters.AddWithValue("@t6", TarifResim.FileName);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Response.Write("Tarifiniz Alınmıştır");
        }
    }
}