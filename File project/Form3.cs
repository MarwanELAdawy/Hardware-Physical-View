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
    public partial class Form3 : Form
    {
        int r;
        double f;
        int r1;
        double f1;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            int req_s;
            int num_r_s;
            int block_f;
            int req_b;
            int num_r;
            
            num_r = int.Parse(n_r.Text);
            num_r_s = int.Parse(s_size.Text) / int.Parse(r_size.Text);
            int num_s_t = int.Parse(t_size.Text) / int.Parse(s_size.Text);
            r = num_r_s * num_s_t;
            double f_s = double.Parse(s_size.Text) - num_r_s * double.Parse(r_size.Text);
            req_s = num_r / num_r_s + num_r % num_r_s;
            f = f_s * req_s;
            block_f = int.Parse(b_f.Text);
            req_b = int.Parse(n_r.Text) / block_f + int.Parse(n_r.Text) % block_f;
            int b_size = int.Parse(b_f.Text) * int.Parse(r_size.Text);
            int num_b_t = int.Parse(t_size.Text) / b_size;
            r1 = num_b_t * block_f;
            double f_t = int.Parse(t_size.Text) - num_b_t * b_size;
            int num_r_t = num_b_t * block_f;
            int req_t = int.Parse(n_r.Text) / num_r_t;
            f1 = req_t * f_t;
            MessageBox.Show(" Amount of fragmentation in Sector origanization = " + f + "\n\n Record per track in sector organization = " + r + " \n\n Amount of fragmentation in Block origanization = " + f1 + "\n\n Record per track in Block organization = " + r1);
            b_f.Clear();
            n_r.Clear();
            t_size.Clear();
            r_size.Clear();
            s_size.Clear();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            chart1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Show();
            this.chart1.Series["Rec_Sec"].Points.AddXY(f, r);
            this.chart1.Series["Rec_Block"].Points.AddXY(f1, r1);
        }
    }
}
