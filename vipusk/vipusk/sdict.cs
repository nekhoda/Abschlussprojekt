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
    public partial class sdict : Form
    {
        public sdict()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sdict1 f = new sdict1();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sdict2 f = new sdict2();
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sdict3 f = new sdict3();
            this.Hide();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Practic f = new Practic();
            this.Hide();
            f.Show();
        }
    }
}
