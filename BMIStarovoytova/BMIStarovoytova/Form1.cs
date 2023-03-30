using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMIStarovoytova
{
    public partial class Form1 : Form
    {
        double index;
        double r;
        double v;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            r = float.Parse(rost.Text);
            v = float.Parse(ves.Text);
            r = r / 100;
            index = v /( r * r);
            BMI.Text = index.ToString("N");
            trackBar1.Value = (int)index;
            if (index < 10)
            { trackBar1.Value = 10; label15.Text = "Недостаточный"; }
            if ((index < 18.5) && (index >=10))
                 { trackBar1.Value = Convert.ToInt32(index); label15.Text = "Недостаточный"; }
            if ((index >= 18.5) && (index <=24.9))
            { trackBar1.Value = Convert.ToInt32(index); label15.Text = "Здоровый"; }
            if ((index <=30) && (index > 24.9))
            { trackBar1.Value = Convert.ToInt32(index); label15.Text = "Избыточный"; }
            if ((index >= 30))
            { trackBar1.Value = Convert.ToInt32(index); label15.Text = "Ожирение"; }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
