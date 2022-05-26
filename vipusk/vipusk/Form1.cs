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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Theory f= new Theory();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Practic f = new Practic();
            this.Hide();
            f.Show();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }      

        private void теоріяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Theory f = new Theory();
            this.Hide();
            f.Show();
        }

        private void практикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Practic f = new Practic();
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void титульнийСлайдToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Titul f = new Titul();
            this.Hide();
            f.Show();
        }
    }
}
