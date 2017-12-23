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
        double f;
        bool x;
        bool b;
        bool y;
        int req_s;
        int num_r_s;
        int block_f;
        int req_b;
        int num_r;
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
            label3.Visible = false;
            label4.Visible = true;
            label5.Visible = true;
            s_size.Visible = true;
            t_size.Visible = true;
            r_size.Visible = true;
            b_f.Visible = false;
            n_r.Visible = true;
            x = true;
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (x || b)
            {
                if (x)
                {
                    if(s_size.Text != string.Empty && t_size.Text != string.Empty && n_r.Text != string.Empty && r_size.Text != string.Empty)
                {
                         try
                    {

                        num_r = int.Parse(n_r.Text);
                        num_r_s = int.Parse(s_size.Text) / int.Parse(r_size.Text);
                        int num_s_t = int.Parse(t_size.Text) / int.Parse(s_size.Text);
                        r = num_r_s * num_s_t;
                        double f_s = double.Parse(s_size.Text) - num_r_s * double.Parse(r_size.Text);
                        req_s = num_r / num_r_s + num_r % num_r_s;
                        f = f_s * req_s;
                        y = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("sector size shouhd be greater than record size and smaller than track size ");
                    }
                } 
             else
                    {
                        MessageBox.Show("Enter all data");
                        y = false;
                    }
                
                }

                else
                {
                    if (b_f.Text != string.Empty && t_size.Text != string.Empty && n_r.Text != string.Empty && r_size.Text != string.Empty)
                    {
                         try
                        {
                             block_f = int.Parse(b_f.Text);
                             req_b = int.Parse(n_r.Text) / block_f + int.Parse(n_r.Text) % block_f;
                             int b_size = int.Parse(b_f.Text) * int.Parse(r_size.Text);
                             int num_b_t = int.Parse(t_size.Text) / b_size;
                             r = num_b_t * block_f;
                             double f_t = int.Parse(t_size.Text) - num_b_t * b_size;
                             int num_r_t = num_b_t * block_f;
                             int req_t = int.Parse(n_r.Text) / num_r_t;
                             f = req_t * f_t;
                             y = true;
                        }
                        catch (Exception)
                       {
                           MessageBox.Show("Block size shouhd be greater than record size and smaller than track size ");
                       }
                    }
                    else
                    {
                        MessageBox.Show("Enter all data");
                        y = false;
                    }
                }
                   
                
                MessageBox.Show("number of records / track = " + r + " \n\n Amount of fragmentation = " + f);
                b_f.Clear();
                n_r.Clear();
                t_size.Clear();
                r_size.Clear();
                s_size.Clear();
            }
            else
            {
                MessageBox.Show("Please enter the disk information");
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            s_size.Visible = false;
            label1.Visible = false;
            label2.Visible = true;
            label5.Visible = true;
            t_size.Visible = true;
            r_size.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            b_f.Visible = true;
            n_r.Visible = true;
            x = false;
            b = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (y)
            {
                Form2 f = new Form2(x, b, req_s, num_r_s, block_f, req_b,num_r);
                this.Hide();
                f.Show();
            }
            else if(!y)
                MessageBox.Show("Please enter the disk information");

           //if (!x && !b)
           // {
           //     MessageBox.Show("Please enter the disk information");
           // }
            else
            {
                Form2 f = new Form2(x, b, req_s, num_r_s, block_f, req_b, num_r);
                this.Hide();
                f.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void s_size_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
