using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_project
{
    public partial class Form1 : Form
    {
        int r;
        float f;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            s_size.Visible = false;
            t_size.Visible = false;
            b_f.Visible = false;
            n_r.Visible = false;
            r_size.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label5.Visible = true;
            s_size.Visible = true;
            t_size.Visible = true;
            r_size.Visible = true;
             r = int.Parse(t_size.Text) / int.Parse(r_size.Text);
             f = float.Parse(s_size.Text) % float.Parse(r_size.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
              
                MessageBox.Show("number of records / track = " + r + " \n\n Amount of fragmentation = " + f);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label5.Visible = true;
            t_size.Visible = true;
            r_size.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            b_f.Visible = true;
            n_r.Visible = true;


        }
    }
}
