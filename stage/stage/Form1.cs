using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            br.Level = Convert.ToDouble(axcopc1.GetVl(0));
            b.Level = Convert.ToDouble(axcopc1.GetVl(1));
            c1.Text = Convert.ToString(axcopc1.GetVl(5));
            c2.Text = Convert.ToString(axcopc1.GetVl(4));


            p60.DiscreteValue1 = Convert.ToBoolean(axcopc1.GetVl(5));
            p.DiscreteValue1 = Convert.ToBoolean(axcopc1.GetVl(4));

            v1.DiscreteValue1 = Convert.ToBoolean(axcopc1.GetVl(6));
            v2.DiscreteValue1 = Convert.ToBoolean(axcopc1.GetVl(7));
            v3.DiscreteValue1 = Convert.ToBoolean(axcopc1.GetVl(8));

        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

            timer1.Enabled = true;

            axcopc1.cnnec();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axcopc1.opcWrt(7, Int16.Parse("0"));
            v2.Band2Color = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axcopc1.opcWrt(7, Int16.Parse("110"));
            v2.Band2Color = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axcopc1.opcWrt(8, Int16.Parse("0"));
            v3.Band2Color = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axcopc1.opcWrt(8, Int16.Parse("110"));
            v3.Band2Color = Color.Green;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axcopc1.opcWrt(6, Int16.Parse("110"));
            v1.Band1Color = Color.Green;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axcopc1.opcWrt(6, Int16.Parse("0"));
            v1.Band1Color = Color.Red;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            axcopc1.opcWrt(4, Int16.Parse("0"));
            p.Band2Color = Color.Red;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            axcopc1.opcWrt(4, Int16.Parse("110"));
            p.Band2Color = Color.Green;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axcopc1.opcWrt(5, Int16.Parse("0"));
            p60.Band2Color = Color.Red;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            axcopc1.opcWrt(5, Int16.Parse("380"));
            p60.Band2Color = Color.Green;
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }
    }
}
