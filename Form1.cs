using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string F = textBox1.Text;       //ประกาศตัวแปร F ใน Textbox1
                double cen = double.Parse(F);       //รับค่า String มาแปลง double และประกาศตัวแปร F 
                string N = textBox1.Text;
                double nev = double.Parse(N);

                D(cen);         //mathod
            }
            catch (Exception ex) { MessageBox.Show("กรุณากรอกข้อมูลเป็นตัวเลขเท่านั้น"); }
        }
        private void button2_Click(object sender, EventArgs e)
        { 
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Clear();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        } 
        private void D(double x)        // แทนค่า x ใน mathod D 

        {
            double F = x * 30.48;       //รับค่า x ที่เป็น cen * 30.48
            textBox2.Text = F.ToString();       //รับค่ามาแสดงใน textbox2
            double N = x * 12;      //รับค่า x ที่เป็น cen * 12
            textBox3.Text = N.ToString();       //รับค่ามาแสดงใน textbox3
        }
    }
}
