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
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataReader dr;
         SqlCommand com;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            con = new SqlConnection("Data Source=DESKTOP-74S6HO0;Initial Catalog=odev;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM kullanici WHERE kullanici_adi = '" + textBox1.Text +
                  "' AND sifre = '" + textBox2.Text + "'";

            dr = com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler, Giriş Başarılı!");
                Form2 gecis = new Form2();
                gecis.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!");
            }
            con.Close();
        }
    }
}
