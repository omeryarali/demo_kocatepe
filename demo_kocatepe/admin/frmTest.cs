using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_kocatepe.admin
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void btnkare_Click(object sender, EventArgs e)
        {
            int sayi, sonuc;
            sayi = Convert.ToInt32(textBox1.Text);
            sonuc = sayi * sayi;
            label1.Text = sonuc.ToString();

        }

        private void btntekmiciftmi_Click(object sender, EventArgs e)
        {
            int sayi=Convert.ToInt32(textBox1.Text);
            if(sayi%2==0)
            {
                label1.Text = "Çift";

            }
            else
            {
                label1.Text = "Tek";
            }
        }

        private void btnbasamak_Click(object sender, EventArgs e)
        {
            int sayi;

            sayi=Convert.ToInt32(textBox1.Text);

            int a1,a2,a3;

            a1 = sayi % 10;
            sayi=sayi/10;
            a2 = sayi % 10;
            sayi = sayi / 10;
            a3 = sayi;

            int sonuc=a1+a2 +a3;

            label1.Text=sonuc.ToString();
        }

        private void btnbakteri_Click(object sender, EventArgs e, int sonuc)
        {


            long i,bk=1,sonuc;

            for(i=0;i<24;i++)
            {
               sonuc = bk * 2;


            }

            label1.Text = sonuc.ToString();

        }
        //olmadı dene

    }
}
