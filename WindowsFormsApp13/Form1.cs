using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        fiyat sonuc;
        private void button1_Click(object sender, EventArgs e)
        {
            double l = Convert.ToDouble(lt.Text);
            
           {

                if (lt.Text == "")
                {
                    MessageBox.Show("sayı giriniz");
                }
                else
                {
                    label1.Text =Convert.ToString(sonuc);
                }
                
           }    
        }
        




    }
}
