using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace LoginForm
{
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;

        public Form2()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-74S6HO0;Initial Catalog=odev;Integrated Security=True");
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string query = "SELECT Musteri_tablo.*, Adres_tablo.sokak, Adres_tablo.bina_no, Adres_tablo.ilce, Adres_tablo.il " +
                          "FROM Musteri_tablo " +
                          "INNER JOIN Adres_tablo ON Musteri_tablo.adres_id = Adres_tablo.adres_id";



            
            con.Open();

            
            da = new SqlDataAdapter(query, con);
            dt = new DataTable();
            da.Fill(dt);

           
            dataGridView1.DataSource = dt;

            
            con.Close();
        }


        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string query = "SELECT * FROM vw_personel_sube"; 

            
            con.Open();

            
            da = new SqlDataAdapter(query, con);
            dt = new DataTable();
            da.Fill(dt);

            
            dataGridView1.DataSource = dt;

            
            con.Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string query = "SELECT Kategori_tablo.kategori_ad, " +
                  "Menu_tablo.menu_ad, " +
                  "Urun_tablo.urun_ad " +
                  "FROM ((menu_urun_tablo " +
                  "INNER JOIN Menu_tablo ON menu_urun_tablo.menu_id = Menu_tablo.menu_id) " +
                  "INNER JOIN Urun_tablo ON menu_urun_tablo.urun_id = Urun_tablo.urun_id) " +
                  "INNER JOIN Kategori_tablo ON menu_urun_tablo.kategori_id = Kategori_tablo.kategori_id";

            
            con.Open();

           
            da = new SqlDataAdapter(query, con);
            dt = new DataTable();
            da.Fill(dt);

           
            dataGridView1.DataSource = dt;

            
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }




    }
}
