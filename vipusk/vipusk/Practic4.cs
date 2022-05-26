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
    public partial class Practic4 : Form
    {
        public Practic4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test4 f = new test4();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _41 f = new _41();
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Practic f = new Practic();
            this.Hide();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _44 f = new _44();
            this.Hide();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _42 f = new _42();
            this.Hide();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _43 f = new _43();
            this.Hide();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _45 f = new _45();
            this.Hide();
            f.Show();
        }
    }
}
