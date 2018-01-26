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
    public partial class Form4 : Form
    {
        public string StringText { get; set; }
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringText = textBox1.Text;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Size = new Size(this.Width - 40, 20);
            button1.Location = new Point(20, this.Height - 80);
        }

        private void Form4_Resize(object sender, EventArgs e)
        {
            textBox1.Size = new Size(this.Width - 40, 20);
            button1.Location = new Point(20, this.Height - 80);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
