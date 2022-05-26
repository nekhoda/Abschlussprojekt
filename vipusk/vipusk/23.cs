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
    public partial class _23 : Form
    {
        public _23()
        {
            InitializeComponent();
        }
        int vsego_voprosov_v_tabl = 24;
        Random rand = new Random();
        int[] mas;
        int k_voprosov_testa = 12;
        int j = 0;
        int mark = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (j < 12)
            {
                listBox1.Items.RemoveAt(0);
                listBox2.Items.Add(dataGridView1[1, mas[j]].Value.ToString());
                if (Convert.ToInt32(dataGridView1[4, mas[j]].Value.ToString()) == 1)
                {
                    mark++;
                }
                j++;
                label1.Text = "Ваша оцінка: " + mark;
            }
            else
            {
                label2.Text = "Питання закінчились";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (j < 12)
            {
                listBox1.Items.RemoveAt(0);
                listBox3.Items.Add(dataGridView1[2, mas[j]].Value.ToString());
                if (Convert.ToInt32(dataGridView1[4, mas[j]].Value.ToString()) == 2)
                {
                    mark++;
                }
                j++;
                label1.Text = "Ваша оцінка: " + mark;
            }
            else
            {
                label2.Text = "Питання закінчились";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (j < 12)
            {
                listBox1.Items.RemoveAt(0);
                listBox4.Items.Add(dataGridView1[3, mas[j]].Value.ToString());
                if (Convert.ToInt32(dataGridView1[4, mas[j]].Value.ToString()) == 3)
                {
                    mark++;
                }
                j++;
                label1.Text = "Ваша оцінка: " + mark;
            }
            else
            {
                label2.Text = "Питання закінчились";
            }
        }

        private void _23_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            string myXMLfile = Application.StartupPath + "\\xml\\2\\23.xml";
            DataSet ds = new DataSet();
            System.IO.FileStream fsReadXml = new System.IO.FileStream(myXMLfile, System.IO.FileMode.Open);
            try
            {
                ds.ReadXml(fsReadXml);
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "23";
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
                listBox1.Items.Add(dataGridView1[0, mas[i]].Value.ToString());

            }
            label1.Text = "Ваша оцінка: " + mark;
        }
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Practic1 f = new Practic1();
            this.Hide();
            f.Show();
        }
    }
}
