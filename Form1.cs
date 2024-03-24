using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace faktoriyel_hasaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double carpim = 1;
            double sayi = Convert.ToDouble(textBox1.Text);
            for (int i = 1; i <= sayi; i++)
            {
                carpim = carpim * i;
            }
            label4.Text = carpim.ToString();
        
        
        
        
        
        
        
        
        
        }
    }
}
