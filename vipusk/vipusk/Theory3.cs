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
    public partial class Theory3 : Form
    {
        public Theory3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Theory f = new Theory();
            this.Hide();
            f.Show();
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            axWindowsMediaPlayer1.URL = path + "\\video\\6.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
    }
}
