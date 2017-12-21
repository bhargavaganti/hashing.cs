using classes;
using forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            base64 bs = new base64();
            string output = bs.encode(textBox1.Text);

            textBox2.Text = output;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            base64 bs = new base64();
            string output = bs.decode(textBox2.Text);

            textBox1.Text = output;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            md5 md5 = new md5();
            string output = md5.encode(textBox1.Text);

            textBox2.Text = output;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sha256 sha = new sha256();
            string output = sha.encode(textBox1.Text);

            textBox2.Text = output;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sha512 sha = new sha512();
            string output = sha.encode(textBox1.Text);

            textBox2.Text = output;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "A quick brown fox jumps over the lazy dog.";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sha256ascii sha = new sha256ascii();
            string output = sha.encode(textBox1.Text);

            textBox2.Text = output;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sha512ascii sha = new sha512ascii();
            string output = sha.encode(textBox1.Text);

            textBox2.Text = output;
        }
    }
}
