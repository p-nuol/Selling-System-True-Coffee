using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrueCoffee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string = " ";
            double discount = 0, total = 0,alltotal = 0,price1 = 0,price2 = 0, price3 = 0, price4 = 0, price5 = 0;
           
            if(checkBox1.Checked)
            {
                price1 = 75;
            }
            if (checkBox2.Checked)
            {
                price2 = 75;
            }
            if (checkBox3.Checked)
            {
                price3 = 75;
            }
            if (checkBox4.Checked)
            {
                price4 = 85;
            }
            if (checkBox5.Checked)
            {
                price5 = 65;
            }

            total = price1 + price2 + price3 + price4 + price5;

            if(radioButton1.Checked)
            {

                discount = total * 0.1;
                alltotal = total - discount;
            }
            else if(radioButton2.Checked)
            {
                discount = total * 0.2;
                alltotal = total - discount;
            }
            else if(radioButton3.Checked)
            {
                discount = 0;
                alltotal = total;
            }

            MessageBox.Show("ราคาเต็ม: " + total +
                            "\nราคาที่ลด: " + discount +
                            "\nราคาสุทธิ: " + alltotal);
        }
    }
}
