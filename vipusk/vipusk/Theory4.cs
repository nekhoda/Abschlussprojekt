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
    public partial class Theory4 : Form
    {
        public Theory4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Theory f = new Theory();
            this.Hide();
            f.Show();
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            axWindowsMediaPlayer2.Ctlcontrols.pause();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            axWindowsMediaPlayer1.URL = path + "\\video\\3.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void axWindowsMediaPlayer2_Enter(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            axWindowsMediaPlayer2.URL = path + "\\video\\4.mp4";
            axWindowsMediaPlayer2.Ctlcontrols.stop();
        }
    }
}
