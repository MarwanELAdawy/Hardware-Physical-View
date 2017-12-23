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
using System.Xml;
using System.Xml.Serialization;


namespace File_project
{
    public partial class Form2 : Form
    {

        bool x;
        bool q;
        int req_s;
        int num_r_s;
        int block_f;
        int req_b;
        int num_r;
        public Form2(bool c, bool a, int r, int m, int b, int w,int z)
        {
            InitializeComponent();
            x = c;
            q = a;
            req_s = r;
            num_r_s = m;
            block_f = b;
            req_b = w;
            num_r = z;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region sector
            employee em = new employee();
            if (x)
            {
                if (grd.Rows.Count - 1 <= num_r)
                {
                    if (!File.Exists("project_s.xml"))
                    {
                        XmlWriter xm = XmlWriter.Create("project_s.xml");
                        xm.WriteStartDocument();
                        xm.WriteStartElement("disk");
                        xm.WriteStartElement("Track");
                        int i = 0;

                        for (int j = 0; j < req_s; j++)
                        {
                            xm.WriteStartElement("Sector");
                            int g = 0;
                            for (; i < grd.Rows.Count - 1; i++)
                            {

                                if (g < num_r_s)
                                {
                                    em.id = grd.Rows[i].Cells[0].Value.ToString();
                                    em.name = grd.Rows[i].Cells[1].Value.ToString();
                                    em.salary = grd.Rows[i].Cells[2].Value.ToString();
                                    xm.WriteStartElement("employee");
                                    xm.WriteStartElement("id");
                                    xm.WriteString(em.id);
                                    xm.WriteEndElement();
                                    xm.WriteStartElement("name");
                                    xm.WriteString(em.name);
                                    xm.WriteEndElement();
                                    xm.WriteStartElement("salary");
                                    xm.WriteString(em.salary);
                                    xm.WriteEndElement();
                                    xm.WriteEndElement();
                                    g++;
                                }
                                else
                                    break;

                            }

                            xm.WriteEndElement();

                        }


                        xm.WriteEndElement();
                        xm.WriteEndElement();
                        xm.WriteEndDocument();
                        xm.Close();
                        MessageBox.Show("successfully added");
                    }


                    else
                    {
                        XmlDocument doc = new XmlDocument();
                        int i = 0;
                        XmlElement Track = doc.CreateElement("Track");
                        for (int j = 0; j < req_s; j++)
                        {
                            XmlElement sector = doc.CreateElement("Sector");
                            Track.AppendChild(sector);
                            int g = 0;
                            for (; i < grd.Rows.Count - 1; i++)
                            {
                                if (g < num_r_s)
                                {
                                    XmlElement emp = doc.CreateElement("employee");
                                    sector.AppendChild(emp);
                                    XmlElement node = doc.CreateElement("Id");
                                    node.InnerText = grd.Rows[i].Cells[0].Value.ToString();
                                    emp.AppendChild(node);

                                    node = doc.CreateElement("name");
                                    node.InnerText = grd.Rows[i].Cells[1].Value.ToString();
                                    emp.AppendChild(node);

                                    node = doc.CreateElement("salary");
                                    node.InnerText = grd.Rows[i].Cells[2].Value.ToString();
                                    emp.AppendChild(node);
                                    sector.AppendChild(emp);
                                    g++;
                                }
                                else
                                    break;
                            }
                            doc.Load("project_s.xml");
                            XmlElement root = doc.DocumentElement;
                            root.AppendChild(Track);
                            doc.Save("project_s.xml");
                        }
                        MessageBox.Show("successfully added");
                    }
                }
                else
                    MessageBox.Show("alot of records , please delete some ");
             
            }
            #endregion
            #region Blocks
            else
            {
                if (q)
                {
                    if (grd.Rows.Count - 1 <= num_r)
                    {
                        if (!File.Exists("project_b.xml"))
                        {
                            XmlWriter xm = XmlWriter.Create("project_b.xml");
                            xm.WriteStartDocument();
                            xm.WriteStartElement("disk");
                            xm.WriteStartElement("Track");
                            int i = 0;
                            for (int j = 0; j < req_b; j++)
                            {
                                xm.WriteStartElement("Block");
                                int g = 0;
                                for (; i < grd.Rows.Count - 1; i++)
                                {
                                    if (g < block_f)
                                    {
                                        em.id = grd.Rows[i].Cells[0].Value.ToString();
                                        em.name = grd.Rows[i].Cells[1].Value.ToString();
                                        em.salary = grd.Rows[i].Cells[2].Value.ToString();
                                        xm.WriteStartElement("employee");
                                        xm.WriteStartElement("id");
                                        xm.WriteString(em.id);
                                        xm.WriteEndElement();
                                        xm.WriteStartElement("name");
                                        xm.WriteString(em.name);
                                        xm.WriteEndElement();
                                        xm.WriteStartElement("salary");
                                        xm.WriteString(em.salary);
                                        xm.WriteEndElement();
                                        xm.WriteEndElement();
                                        g++;
                                    }
                                    else
                                        break;



                                }
                                xm.WriteEndElement();
                            }


                            xm.WriteEndElement();
                            xm.WriteEndElement();
                            xm.WriteEndDocument();
                            xm.Close();
                            MessageBox.Show("successfully added");
                        }


                        else
                        {
                            XmlDocument doc = new XmlDocument();
                            int i = 0;
                            XmlElement Track = doc.CreateElement("Track");
                            for (int j = 0; j < req_b; j++)
                            {
                                XmlElement block = doc.CreateElement("Block");
                                Track.AppendChild(block);
                                int g = 0;
                                for (; i < grd.Rows.Count - 1; i++)
                                {
                                    if (g < block_f)
                                    {
                                        XmlElement emp = doc.CreateElement("employee");
                                        block.AppendChild(emp);
                                        XmlElement node = doc.CreateElement("Id");
                                        node.InnerText = grd.Rows[i].Cells[0].Value.ToString();
                                        emp.AppendChild(node);

                                        node = doc.CreateElement("name");
                                        node.InnerText = grd.Rows[i].Cells[1].Value.ToString();
                                        emp.AppendChild(node);

                                        node = doc.CreateElement("salary");
                                        node.InnerText = grd.Rows[i].Cells[2].Value.ToString();
                                        emp.AppendChild(node);
                                        block.AppendChild(emp);
                                        g++;
                                    }
                                    else
                                        break;
                                }
                                doc.Load("project_b.xml");
                                XmlElement root = doc.DocumentElement;
                                root.AppendChild(Track);
                                doc.Save("project_b.xml");
                            }

                            MessageBox.Show("successfully added");
                        }
                    }
                        else
                        MessageBox.Show("alot of records , please delete some ");
                    }
                else
                    MessageBox.Show("Please enter the disk information");   
            }
        }
    
    
        #endregion
    }
}  

