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
    public partial class Form2 : Form
    {
        public string StringText { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Size = new Size(this.Width - 40, 20);
            button1.Location = new Point(20, this.Height - 80);
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            textBox1.Size = new Size(this.Width - 40, 20);
            button1.Location = new Point(20, this.Height - 80);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringText = textBox1.Text;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}
