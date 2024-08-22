using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;




namespace Proje_Ödevi
{
    public partial class Form1 : Form
    {
        private object txtKullanıcıAdı;

        public Form1()
        {
            InitializeComponent();
        }


        

    private void button1_Click(object sender, EventArgs e)
        {
            
            string kullaniciAdi = txtKullaniciAdi.Text;
            string parola = txtParola.Text;

            
            if (kullaniciAdi == "taha" && parola == "1234")
            {
                MessageBox.Show("Giriş yapıldı");

               
                Form2 form2 = new Form2();
                form2.Show();

               
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
