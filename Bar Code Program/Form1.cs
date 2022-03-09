using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_Code_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox1.Image = barcode.Draw(textBox4.Text,50);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox2.Image = qrcode.Draw(textBox4.Text,25);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                DateTime dt1 = dateTimePicker1.Value;
                int days = Convert.ToInt32(textBox5.Text);
                DateTime newDate1 = dt1.AddDays(days);
                string a1 = newDate1.ToShortDateString();
                dateTimePicker2.Value = Convert.ToDateTime(a1);
            }
            if (radioButton3.Checked == true)
            {
                DateTime dt2 = dateTimePicker1.Value;
                int months = Convert.ToInt32(textBox5.Text);
                DateTime newDate2 = dt2.AddMonths(months);
                string a2 = newDate2.ToShortDateString();
                dateTimePicker2.Value = Convert.ToDateTime(a2);
            }
            if (radioButton2.Checked == true)
            {

                DateTime dt3 = dateTimePicker1.Value;
                int year = Convert.ToInt32(textBox5.Text);
                DateTime newDate3 = dt3.AddYears(year);
                string a3 = newDate3.ToShortDateString();
                dateTimePicker2.Value = Convert.ToDateTime(a3);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
