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
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label1.Text = "Finish";
            label2.Text = " ";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label1.Text = "МЦК Лужники";
            label2.Text = "Особенности:\nСтенд питья\nБатончики";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label1.Text = "Новодевичей\nмонастырь";
            label2.Text = "Особенности:\nСтенд питья\nБатончики\nТуалеты\nСтенд информации\nМедпункт";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label1.Text = "Метро\nКиевская";
            label2.Text = "Особенности:\nСтенд питья\nБатончики\nТуалеты";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label1.Text = "МИД";
            label2.Text = "Особенности:\nСтенд питья\nБатончики\nТуалеты\nМедпункт";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label1.Text = "Парк Горького";
            label2.Text = "Особенности:\nСтенд питья\nБатончики\nТуалеты\nСтенд информации";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label1.Text = "Здания РАН";
            label2.Text = "Особенности:\nСтенд питья\nБатончики\nТуалеты";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            label1.Text = "Метро\nВоробьевы горы";
            label2.Text = "Особенности:\nСтенд питья\nБатончики\nТуалеты\nСтенд информации\nМедпункт";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            label1.Text = "Стадион\nЛужники";
            label2.Text = "Особенности:\nСтенд питья\nБатончики\nТуалеты\nСтенд информации\nМедпункт";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }
    }
}
