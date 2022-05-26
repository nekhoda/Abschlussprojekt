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
    public partial class Practic5 : Form
    {
        public Practic5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test5 f = new test5();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _51 f = new _51();
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
            _52 f = new _52();
            this.Hide();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _53 f = new _53();
            this.Hide();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _54 f = new _54();
            this.Hide();
            f.Show();
        }
    }
}
