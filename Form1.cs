using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract2
{
    public partial class Form1 : Form
    {
        int quantity = 0;
        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (yes.Checked)
            {
                field_name.Visible = true;
                field_name.Text="";
                label_name.Visible = true;
                button1.Visible = true;
            }
            else
            {
                field_name.Visible = false;
                button1.Visible = false;
                text_invite.Visible = false;
                label_amount.Visible = false;
                label_name.Visible = false;
                amount.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (no.Checked)
            {
                field_name.Visible = false;
                button1.Visible = false;
                text_invite.Visible = false;
                label_amount.Visible = false;
                label_name.Visible = false;
                amount.Visible = false;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            quantity++;
            string invite = field_name.Text;
            text_invite.Text = "Приглашаем Вас, "+invite+", на наше мероприятие!";
            text_invite.Visible = true;
            label_amount.Visible = true;
            amount.Visible = true;

            amount.Text = ""+quantity+"";




        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void amount_Click(object sender, EventArgs e)
        {

        }
    }
}
