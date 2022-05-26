﻿using System;
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
    public partial class _32 : Form
    {
        public _32()
        {
            InitializeComponent();
        }
        int vsego_voprosov_v_tabl = 19;
        Random rand = new Random();
        int[] mas;
        int k_voprosov_testa = 6;
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
        private void button1_Click(object sender, EventArgs e)
        {
            int k = 0;
            for (int i = 0; i < k_voprosov_testa; i++)
            {
                if (dataGridView2[1, i].Value.ToString() == dataGridView1[1, mas[i]].Value.ToString())
                {
                    k++;
                    dataGridView2[1, i].Style.ForeColor = Color.Green;
                }
                else
                {
                    dataGridView2[1, i].Style.ForeColor = Color.Red;
                }
                if (dataGridView2[2, i].Value.ToString() == dataGridView1[2, mas[i]].Value.ToString())
                {
                    k++;
                    dataGridView2[2, i].Style.ForeColor = Color.Green;
                }
                else
                {
                    dataGridView2[2, i].Style.ForeColor = Color.Red;
                }
            }
            label1.Text = "Оцінка " + k;
        }

        private void _32_Load(object sender, EventArgs e)
        {

            dataGridView2.ColumnCount = 3;
            dataGridView2.RowCount = k_voprosov_testa;
            string myXMLfile = Application.StartupPath + "\\xml\\3\\32.xml";
            DataSet ds = new DataSet();
            System.IO.FileStream fsReadXml = new System.IO.FileStream(myXMLfile, System.IO.FileMode.Open);
            try
            {
                ds.ReadXml(fsReadXml);
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "32";
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
                dataGridView2[0, i].Value = dataGridView1[0, mas[i]].Value;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Practic3 f = new Practic3();
            this.Hide();
            f.Show();
        }
    }
}
