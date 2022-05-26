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
    public partial class _14 : Form
    {
        public _14()
        {
            InitializeComponent();
        }
        int vsego_voprosov_v_tabl = 12;
        Random rand = new Random();
        int[] mas;
        int k_voprosov_testa = 6;
        string vopros;
        string[] vopros1;
        string verno;
        string[] verno1;
        public void mix(ref int[] arr)
        {
            for (int i = 0; i < vsego_voprosov_v_tabl; i++)
            {
                arr[i] = i;
            }
            int tmp1, tmp2;
            for (int i = 0; i < vsego_voprosov_v_tabl; i++)
            {
                tmp1 = rand.Next(0, vsego_voprosov_v_tabl);
                tmp2 = arr[tmp1];
                arr[tmp1] = arr[i];
                arr[i] = tmp2;
            }
            for (int i = 0; i < vsego_voprosov_v_tabl; i++)
            {
                listBox1.Items.Add(arr[i]);
            }
        }
        private void _14_Load(object sender, EventArgs e)
        {
            string myXMLfile = Application.StartupPath + "\\xml\\1\\14.xml";
            DataSet ds = new DataSet();
            System.IO.FileStream fsReadXml = new System.IO.FileStream(myXMLfile, System.IO.FileMode.Open);
            try
            {
                ds.ReadXml(fsReadXml);
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "14";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                fsReadXml.Close();
            }
            mas = new int[vsego_voprosov_v_tabl];
            mix(ref mas);
            for (int i = 0; i < k_voprosov_testa; i++)
            {
                vopros = vopros + " " + dataGridView1[0, mas[i]].Value.ToString();
                verno = verno + " " + dataGridView1[1, mas[i]].Value.ToString();
                richTextBox1.Text = richTextBox1.Text + " " + dataGridView1[0, mas[i]].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            practic2 f = new practic2();
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = 12, n, j1;
            vopros = richTextBox1.Text;
            verno1 = verno.Split(' ');
            vopros1 = vopros.Split(' ');
            n = verno1.Length;
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
            label1.Text = "Оцінка: " + k;
        }

       
    }
}
