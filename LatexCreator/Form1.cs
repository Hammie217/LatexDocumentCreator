using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatexCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ++button1.Height = this.Height / 10;
            button1.Width = this.Width-16;
            if ((this.Height / 2) > this.Width)
                button1.Font = new Font(button1.Font.FontFamily, this.Width / 12);
            else
                button1.Font = new Font(button1.Font.FontFamily, this.Height / 20);
            button2.Location = new Point(this.Width - 120, this.Height - 80);
            Back.Location = new Point(20, this.Height - 80);
            textBox1.Size = new Size(this.Width - 100, 20);
            textBox2.Size = new Size(this.Width - 100, 20);
            textBox3.Size = new Size(this.Width - 100, this.Height - 170);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void Form1_Resize_1(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            button1.Width = this.Width - 16;
            if (this.Height > 500)
            {
                button1.Height = this.Height / 10;

            }
            if ((this.Height / 2) > this.Width)
                button1.Font = new Font(button1.Font.FontFamily, this.Width / 12);
            else
                button1.Font = new Font(button1.Font.FontFamily, this.Height / 20);

        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            button2.Location = new Point(this.Width - 110, this.Height - 80);
            Back.Location = new Point(20, this.Height - 80);
            textBox1.Size = new Size(this.Width - 100, 20);
            textBox2.Size = new Size(this.Width - 100, 20);
            textBox3.Size = new Size(this.Width - 100, this.Height - 170);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
