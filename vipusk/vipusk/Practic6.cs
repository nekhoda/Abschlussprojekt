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
    public partial class Practic6 : Form
    {
        public Practic6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            _61 f = new _61();
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test6 f = new test6();
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
            _62 f = new _62();
            this.Hide();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _63 f = new _63();
            this.Hide();
            f.Show();
        }
    }
}
