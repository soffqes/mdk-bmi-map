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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            panel1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label1.Text = "Финиш";
            label2.Text = " ";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label1.Text = "МЦК Лужники";
            label2.Text = "Особенности:\nСтенд питья\nБатончики";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            pictureBox14.Visible = false;
            pictureBox15.Visible = true;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label1.Text = "Новодевичей монастырь";
            label2.Text = "Особенности:\nСтенд питья\nБатончики\nТуалеты\nСтенд информации\nМедпункт";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label1.Text = "Метро Киевская";
            label2.Text = "Особенности:\nСтенд питья\nБатончики\nТуалеты";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            pictureBox14.Visible = false;
            pictureBox15.Visible = true;
            pictureBox16.Visible = false;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label1.Text = "МИД";
            label2.Text = "Особенности:\nСтенд питья\nБатончики\nТуалеты\nМедпункт";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            pictureBox14.Visible = false;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label1.Text = "Парк Горького";
            label2.Text = "Особенности:\nСтенд питья\nБатончики\nТуалеты\nСтенд информации";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = false;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label1.Text = "Здания РАН";
            label2.Text = "Особенности:\nСтенд питья\nБатончики\nТуалеты";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            pictureBox14.Visible = false;
            pictureBox15.Visible = true;
            pictureBox16.Visible = false;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            label1.Text = "Метро Воробьевы горы";
            label2.Text = "Особенности:\nСтенд питья\nБатончики\nТуалеты\nСтенд информации\nМедпункт";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            label1.Text = "Стадион Лужники";
            label2.Text = "Особенности:\nСтенд питья\nБатончики\nТуалеты\nСтенд информации\nМедпункт";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            label1.Text = "Старт";
            label2.Text = " ";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            label1.Text = "Старт";
            label2.Text = " ";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            label1.Text = "Старт";
            label2.Text = " ";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
