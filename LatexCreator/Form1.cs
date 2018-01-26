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
            button1.Height = this.Height / 10;
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
            Compile.Location = new Point(this.Width - 102, this.Height - 80);
            Update.Location = new Point(this.Width - 102,this.Height - 109);
            button3.Location = new Point(10, this.Height - 80);
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

        private void Back_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.AppendText("\\documentclass[a4paper]{article}" + Environment.NewLine + "\\usepackage[english]{babel}" + Environment.NewLine + "\\usepackage[utf8x]{inputenc}" + Environment.NewLine + "\\usepackage[T1]{fontenc}" + Environment.NewLine + "\\usepackage[a4paper,top=3cm,bottom=2cm,left=3cm,right=3cm,marginparwidth=1.75cm]{geometry}" + Environment.NewLine + "\\usepackage{amsmath}" + Environment.NewLine + "\\usepackage{graphicx}" + Environment.NewLine + "\\usepackage[colorinlistoftodos]{todonotes}" + Environment.NewLine + "\\usepackage[colorlinks=true, allcolors=blue]{hyperref}" + Environment.NewLine);
            textBox4.AppendText("\\title{" + textBox2.Text + "}");
            textBox4.AppendText(Environment.NewLine);
            textBox4.AppendText("\\author{" + textBox1.Text + "}");
            textBox4.AppendText(Environment.NewLine);
            textBox4.AppendText("\\begin{document}");
            textBox4.AppendText(Environment.NewLine);
            textBox4.AppendText("\\maketitle");
            textBox4.AppendText(Environment.NewLine);
            textBox4.AppendText("\\begin{abstract}");
            textBox4.AppendText(Environment.NewLine);
            textBox4.AppendText(textBox3.Text);
            textBox4.AppendText(Environment.NewLine);
            textBox4.AppendText("\\end{abstract}");
            textBox4.AppendText(Environment.NewLine);
            panel3.Visible = true;
        }

        private void panel3_Resize(object sender, EventArgs e)
        {
            Compile.Location = new Point(this.Width - 100, this.Height - 80);
            Update.Location = new Point(this.Width - 100, this.Height - 109);
            button3.Location = new Point(20, this.Height - 80);
            textBox4.Size = new Size(this.Width - 40, this.Height - 210);
        }

        private void Update_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using(Form2 form2 = new Form2())
            {
                if (form2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    textBox4.Text += "\\section{"+form2.StringText+"}";
                    textBox4.AppendText(Environment.NewLine);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Form3 form3 = new Form3())
            {
                if (form3.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    textBox4.Text += "\\subsection{" + form3.StringText + "}";
                    textBox4.AppendText(Environment.NewLine);
                }
            }
        }

        private void Compile_Click(object sender, EventArgs e)
        {
            textBox4.AppendText("\\end{ document}");
        }
    }
}
