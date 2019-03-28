using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiyiBasamaklaraAyirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int uzunluk = 0;
       

        int nokta = 0;
        private void txtSayi_TextChanged(object sender, EventArgs e)
        {

            string sayi = txtSayi.Text;
            uzunluk = sayi.Length;

            uzunluk = uzunluk - nokta;
            
            if (uzunluk % 3 == 0)
            {                     
               txtSayi.Text = sayi + ".";
               txtSayi.Select(txtSayi.Text.Length, 0);
               nokta++;
                
            }
            
        }
    }
}
