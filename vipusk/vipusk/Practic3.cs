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
    public partial class Practic3 : Form
    {
        public Practic3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test3 f = new test3();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _31 f = new _31();
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Practic f = new Practic();
            this.Hide();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _32 f = new _32();
            this.Hide();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _33 f = new _33();
            this.Hide();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _34 f = new _34();
            this.Hide();
            f.Show();
        }
    }
}
