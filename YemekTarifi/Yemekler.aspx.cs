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
    public partial class Yemekler : System.Web.UI.Page
    {
        sqlSinif bgl = new sqlSinif();
        string islem = "";
        string id ="";
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            Panel4.Visible = false;

            if (Page.IsPostBack == false) {

                id = Request.QueryString["YemekId"];
                islem = Request.QueryString["islem"];
                //Kategori Listesi
                MySqlCommand komut2 = new MySqlCommand("select * from kategori ", bgl.baglanti());
                MySqlDataReader dr2 = komut2.ExecuteReader();
                DropDownList1.DataTextField = "KategoriAd";
                DropDownList1.DataValueField = "KategoriId";
                DropDownList1.DataSource = dr2;
                DropDownList1.DataBind();
            }

            //Yemek Listesi 
            MySqlCommand komut = new MySqlCommand("select * from yemek",bgl.baglanti());
            MySqlDataReader dr = komut.ExecuteReader();
            DataList1.DataSource = dr;
            DataList1.DataBind();

            if (islem == "sil")
            {

                MySqlCommand sil = new MySqlCommand("delete from yemek where YemekId=@p1",bgl.baglanti());
                sil.Parameters.AddWithValue("@p1",id);
                sil.ExecuteNonQuery();
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
            MySqlCommand komut = new MySqlCommand("insert into yemek (YemekAd,YemekMalzeme,YemekTarif,KategoriId) values (@p1,@p2,@p3,@p4)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",TextBox1.Text);
            komut.Parameters.AddWithValue("@p2", TextBox2.Text);
            komut.Parameters.AddWithValue("@p3", TextBox3.Text);
            komut.Parameters.AddWithValue("@p4",DropDownList1.SelectedValue);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            //Kategori Sayısını Arttırma
            MySqlCommand komut2 = new MySqlCommand("update kategori set KategoriAdet=KategoriAdet+1 where KategoriId=@p1",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", DropDownList1.SelectedValue);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}