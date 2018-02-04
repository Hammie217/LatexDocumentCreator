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
    public partial class Form5 : Form
    {
        public string StringText { get; set; }

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox1.Size = new Size(this.Width - 40, this.Height - 112);

            button1.Location = new Point(20, this.Height - 80);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringText = textBox1.Text;

        }

        private void Form5_Resize(object sender, EventArgs e)
        {
            textBox1.Size = new Size(this.Width - 40, this.Height - 112);
            button1.Location = new Point(20, this.Height - 80);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
