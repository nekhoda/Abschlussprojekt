using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vipusk
{
    public partial class Practic : Form
    {
        public Practic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Practic1 f = new Practic1();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            practic2 f = new practic2();
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Practic3 f  = new Practic3();
            this.Hide();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Practic4 f = new Practic4();
            this.Hide();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Practic5 f = new Practic5();
            this.Hide();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Practic6 f = new Practic6();
            this.Hide();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void титульнийСлайдToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Titul f = new Titul();
            this.Hide();
            f.Show();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void теоріяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Theory f = new Theory();
            this.Hide();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dict f = new dict();
            this.Hide();
            f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sdict f = new sdict();
            this.Hide();
            f.Show();
        }
    }
}
