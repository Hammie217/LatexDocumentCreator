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
    public partial class Form7 : Form
    {
        public string StringText { get; set; }
        public string StringText1 { get; set; }
        public string StringText2 { get; set; }
        public string StringText3 { get; set; }
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            textBox1.Size = new Size(this.Width - 131, 20);
            textBox2.Size = new Size(this.Width - 131, 20);
            textBox3.Size = new Size(this.Width - 131, 20);
            textBox4.Size = new Size(this.Width - 46, 20);
            button1.Location = new Point(20, this.Height - 80);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringText = textBox1.Text;
            StringText1 = textBox2.Text;
            StringText2 = textBox3.Text;
            StringText3 = textBox4.Text;
        }

        private void Form7_Resize(object sender, EventArgs e)
        {
            textBox1.Size = new Size(this.Width - 131, 20);
            textBox2.Size = new Size(this.Width - 131, 20);
            textBox3.Size = new Size(this.Width - 131, 20);
            textBox4.Size = new Size(this.Width - 46, 20);
            button1.Location = new Point(20, this.Height - 80);
        }
    }
}
