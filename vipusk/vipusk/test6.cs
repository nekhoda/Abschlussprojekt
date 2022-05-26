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
    public partial class test6 : Form
    {
        public test6()
        {
            InitializeComponent();
        }
        int vsego_voprosov_v_tabl = 12;
        int index, v_next, radio_index;
        Random rand = new Random();
        int[] mas;
        int k_voprosov_testa = 12;
        string[,] rezult = new string[30, 5];
        int N_in_rezult = 0;
        RadioButton[] rb = new RadioButton[6];
        int mark = 0;
        private void test6_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                rb[i] = new RadioButton();
                rb[i].Text = "text" + i.ToString();
                rb[i].Location = new System.Drawing.Point(30, 50 + i * 40);
                rb[i].AutoSize = true;
                this.Controls.Add(rb[i]);
                rb[i].Click += rb_click;
            }
            string myXMLfile = Application.StartupPath + "\\xml\\6\\test6.xml";
            DataSet ds = new DataSet();
            System.IO.FileStream fsReadXml = new System.IO.FileStream(myXMLfile, System.IO.FileMode.Open);
            try
            {
                ds.ReadXml(fsReadXml);
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "test6";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                fsReadXml.Close();
            }
            //vsego_voprosov_v_tabl = dataGridView1.Rows.Count;
            mas = new int[vsego_voprosov_v_tabl];
            mix(ref mas);
            v_next = 0;
            index = mas[v_next];
            listBox2.Items.Add(index);
            label2.Text = dataGridView1[1, index].Value.ToString();
            rb[1].Text = dataGridView1[2, index].Value.ToString();
            rb[2].Text = dataGridView1[3, index].Value.ToString();
            rb[3].Text = dataGridView1[4, index].Value.ToString();
            rb[4].Text = dataGridView1[5, index].Value.ToString();
            rb[5].Text = dataGridView1[6, index].Value.ToString();
            label1.Text = dataGridView1[7, index].Value.ToString();
            rb[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            v_next = v_next + 1;
            if (v_next < k_voprosov_testa)
            {
                index = mas[v_next];
                for (int i = 1; i <= 5; i++)
                {
                    rb[i].Enabled = true;
                }
                listBox2.Items.Add(index);
                label2.Text = dataGridView1[1, index].Value.ToString();
                rb[1].Text = dataGridView1[2, index].Value.ToString();
                rb[2].Text = dataGridView1[3, index].Value.ToString();
                rb[3].Text = dataGridView1[4, index].Value.ToString();
                rb[4].Text = dataGridView1[5, index].Value.ToString();
                rb[5].Text = dataGridView1[6, index].Value.ToString();
                label1.Text = dataGridView1[7, index].Value.ToString();
                rb[0].Checked = true;
            }
            else
            {
                for (int i = 1; i <= 5; i++)
                {
                    rb[i].Visible = false;
                }
                label2.Text = "ПИТАННЯ ЗАКІНЧИЛИСЯ, ВАША ОЦІНКА: " + mark;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Practic6 f = new Practic6();
            this.Hide();
            f.Show();
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
            for (int i = 0; i < vsego_voprosov_v_tabl; i++)
            {
                listBox1.Items.Add(arr[i]);
            }
        }
        public void rb_click(object sender, EventArgs e)
        {
            radio_index = 0;
            for (int j = 1; j <= 5; j++)
            {
                if (rb[j].Checked == true) radio_index = j;
            }
            rezult[N_in_rezult, 0] = label2.Text;
            rezult[N_in_rezult, 1] = rb[radio_index].Text;
            rezult[N_in_rezult, 2] = rb[Convert.ToInt32(label1.Text)].Text;
            if (radio_index == Convert.ToInt32(label1.Text))
            {
                label3.ForeColor = Color.Green;
                label3.Text = " ПРАВИЛЬНО ";
                rezult[N_in_rezult, 3] = "ПРАВИЛЬНО";
                mark++;
            }
            else
            {
                label3.ForeColor = Color.Red;
                label3.Text = " ПОМИЛКА ";
                rezult[N_in_rezult, 3] = "ПОМИЛКА";
                for (int i = 1; i <= 5; i++)
                {
                    rb[i].Enabled = false;
                }
            }
            N_in_rezult = N_in_rezult + 1;
        }
    }
}
