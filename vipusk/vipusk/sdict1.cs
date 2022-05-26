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
    public partial class sdict1 : Form
    {
        public sdict1()
        {
            InitializeComponent();
        }
        string vopros;
        string[] vopros1;
        string verno;
        string[] verno1;
        private void button2_Click(object sender, EventArgs e)
        {
            sdict f = new sdict();
            this.Hide();
            f.Show();
            axWindowsMediaPlayer1.Ctlcontrols.pause();
           
        }

        private void sdict1_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            richTextBox2.LoadFile(path + "\\dict\\4.rtf");
            verno = richTextBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = 12, n, j1, l;
            if (int.TryParse(richTextBox1.Text, out l) && l > 0)
            {
                vopros = richTextBox1.Text;
                verno1 = verno.Split(' ');
                vopros1 = vopros.Split(' ');
                n = verno1.Length;
                if (verno1.Length > vopros1.Length)
                {
                    k = 0;
                    n = vopros1.Length;
                    for (int i = 0; i < n; i++)
                    {
                        k++;
                        if (vopros1[i] != verno1[i])
                        {
                            k--;
                            j1 = 0;
                            while (j1 <= richTextBox1.Text.Length - vopros1[i].Length)
                            {
                                j1 = richTextBox1.Text.IndexOf(vopros1[i], j1);
                                if (j1 < 0) break;
                                richTextBox1.SelectionStart = j1;
                                richTextBox1.SelectionLength = vopros1[i].Length;
                                richTextBox1.SelectionColor = Color.Red;
                                j1 += vopros1[i].Length;
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (vopros1[i] != verno1[i])
                        {
                            k--;
                            j1 = 0;
                            while (j1 <= richTextBox1.Text.Length - vopros1[i].Length)
                            {
                                j1 = richTextBox1.Text.IndexOf(vopros1[i], j1);
                                if (j1 < 0) break;
                                richTextBox1.SelectionStart = j1;
                                richTextBox1.SelectionLength = vopros1[i].Length;
                                richTextBox1.SelectionColor = Color.Red;
                                j1 += vopros1[i].Length;
                            }
                        }
                    }
                }

            }
            else
            {
                k = 0;
            }
            label1.Text = "Оцінка: " + k;

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            axWindowsMediaPlayer1.URL = path + "\\audio\\4.mp4";
        }
    }
}
