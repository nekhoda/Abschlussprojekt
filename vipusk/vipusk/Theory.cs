using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace vipusk
{
    public partial class Theory : Form
    {
        public Theory()
        {
            InitializeComponent();
            TreeNode a = treeView1.Nodes.Add("Правопис ненаголошених голосних е, и, о, а");
            a.Tag = 0;
            TreeNode b = treeView1.Nodes.Add("Вживання м’якого знака та апострофа");
            b.ExpandAll();
            b.Tag = 9;
            b.Nodes.Add("М'який знак").Tag = 1;
            b.Nodes.Add("Апостроф").Tag = 2;
            TreeNode c = treeView1.Nodes.Add("Подвоєння та подовження приголосних");
            c.ExpandAll();
            c.Tag = 10;
            c.Nodes.Add("Подвоєння приголосних").Tag = 3;
            c.Nodes.Add("Подовження приголосних").Tag = 4;
            TreeNode d = treeView1.Nodes.Add("Правопис префіксів і суфіксів");
            d.ExpandAll();
            d.Tag = 11;
            d.Nodes.Add("Правопис префіксів").Tag = 5;
            d.Nodes.Add("Правопис суфіксів").Tag = 6;
            TreeNode k = treeView1.Nodes.Add("Чергування приголосних при словозміні");
            k.Tag = 7;
            TreeNode f = treeView1.Nodes.Add("Велика літера у власних назвах");
            f.Tag = 8;            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = Application.StartupPath;
            string st1 = treeView1.SelectedNode.Text;
            //if (st1 == "Правопис ненаголошених голосних е, и, о, а") richTextBox1.LoadFile(path + "\text\1.rtf");
            //richTextBox1.LoadFile(System.IO.Path.GetFullPath("1.rtf"));
            //richTextBox1.
    
           if (st1 == "Правопис ненаголошених голосних е, и, о, а") webBrowser1.Navigate(path + "\\text\\10.htm");
           if (st1 == "М'який знак") webBrowser1.Navigate(path + "\\text\\2.10.htm");
           if (st1 == "Апостроф") webBrowser1.Navigate(path + "\\text\\2.20.htm");
           if (st1 == "Подвоєння приголосних") webBrowser1.Navigate(path + "\\text\\3.10.htm");
           if (st1 == "Подовження приголосних") webBrowser1.Navigate(path + "\\text\\3.20.htm");
           if (st1 == "Правопис префіксів") webBrowser1.Navigate(path + "\\text\\4.10.htm");
           if (st1 == "Правопис суфіксів") webBrowser1.Navigate(path + "\\text\\4.20.htm");
           if (st1 == "Чергування приголосних при словозміні") webBrowser1.Navigate(path + "\\text\\50.htm");
           if (st1 == "Велика літера у власних назвах") webBrowser1.Navigate(path + "\\text\\60.htm");
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void практикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Practic f = new Practic();
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void титульнийСлайдToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Titul f = new Titul();
            this.Hide();
            f.Show();
        }

        private void Theory_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Theory1 f = new Theory1();
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Theory2 f = new Theory2();
            this.Hide();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Theory3 f = new Theory3();
            this.Hide();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Theory4 f = new Theory4();
            this.Hide();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Theory5 f = new Theory5();
            this.Hide();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Theory6 f = new Theory6();
            this.Hide();
            f.Show();
        }
    }
}
