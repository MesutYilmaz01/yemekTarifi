﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace YemekTarifi
{
    public partial class Hakkimizda : System.Web.UI.Page
    {
        sqlSinif bgl = new sqlSinif();
        protected void Page_Load(object sender, EventArgs e)
        {
            MySqlCommand komut = new MySqlCommand("select * from hakkimizda", bgl.baglanti());
            MySqlDataReader dr =  komut.ExecuteReader();
            DataList2.DataSource = dr;
            DataList2.DataBind();
            bgl.baglanti().Close();
        }

        protected void DataList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}