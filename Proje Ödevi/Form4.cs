using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Ödevi
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            
            if (chkKullaniciSozlesmesi.Checked)
            {
                Form5 form5 = new Form5();
                form5.Show(); 
                this.Close(); 
            }
            else
            {
                
                MessageBox.Show("Satın alma işlemi için kullanıcı sözleşmesini onaylamanız gerekmektedir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Form2 form2 = new Form2();
            form2.Show(); 
        }
    }
}
