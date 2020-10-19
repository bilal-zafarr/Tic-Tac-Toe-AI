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

namespace T
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            this.Close();
        }

        //3x3 list show
        int noOfRecords3x3;
        private void button4_Click(object sender, EventArgs e)
        {
            top3:
            try {
                StreamReader sr = new StreamReader(@"D://3x3noOfRecords.txt");

                noOfRecords3x3 = int.Parse(sr.ReadLine());
                sr.Close();
                if (noOfRecords3x3 < 1)
                    MessageBox.Show("No record exists at the moment", "Oops!");
                else
                {
                    for (int i = 1; i <= noOfRecords3x3; i++)
                        listBox1.Items.Add(i);
                    listBox1.Visible = true;
                    button4.Enabled = false;
                    label4.Visible = true;
                    richTextBox1.Visible = true;
                    button7.Visible = true;
                }
            }
            catch(Exception ex)
            {
                StreamWriter sw = new StreamWriter(@"D://3x3noOfRecords.txt");
                sw.Write(0);
                sw.Close();
                goto top3;
            }
            
            
        }

        //3x3 OK BUTTON
        private void button7_Click(object sender, EventArgs e)
        {
            try {
                int num = Int32.Parse(richTextBox1.Text);
                if (num < 1 || num > noOfRecords3x3)
                    MessageBox.Show("No such Record Exists", "Oops!");
                else
                {
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.loadFromFile(num);
                    f2.ShowDialog();
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No such Record Exists", "Oops!");
            }
                        
        }

        //4x4 list show
        int noOfRecords4x4;
        private void button5_Click(object sender, EventArgs e)
        {
            top4:
            try {
                StreamReader sr = new StreamReader(@"D://4x4noOfRecords.txt");

                noOfRecords4x4 = int.Parse(sr.ReadLine());
                sr.Close();
                if (noOfRecords4x4 < 1)
                    MessageBox.Show("No Record Exists at the moment", "Oops!");
                else
                {
                    for (int i = 1; i <= noOfRecords4x4; i++)
                        listBox2.Items.Add(i);
                    listBox2.Visible = true;
                    button5.Enabled = false;
                    label4.Visible = true;
                    richTextBox2.Visible = true;
                    button8.Visible = true;
                }
            }
            catch(Exception ex)
            {
                StreamWriter sw = new StreamWriter(@"D://4x4noOfRecords.txt");
                sw.Write(0);
                sw.Close();
                goto top4;
            }
            
        }
        //4x4 ok button
        private void button8_Click(object sender, EventArgs e)
        {
            try {
                int num = Int32.Parse(richTextBox2.Text);
                if (num < 1 || num > noOfRecords4x4)
                    MessageBox.Show("No such Record Exists", "Oops!");
                else
                {
                    this.Hide();
                    Form3 f3 = new Form3();
                    f3.loadFromFile(num);
                    f3.ShowDialog();
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No such Record Exists", "Oops!");
            }
            
        }

        //5x5 list show
        int noOfRecords5x5;
        private void button6_Click(object sender, EventArgs e)
        {
            top5:
            try {
                StreamReader sr = new StreamReader(@"D:/5x5noOfRecords.txt");

                noOfRecords5x5 = int.Parse(sr.ReadLine());
                sr.Close();
                if (noOfRecords5x5 < 1)
                    MessageBox.Show("No Record Exist at the moment", "Oops!");
                else
                {
                    for (int i = 1; i <= noOfRecords5x5; i++)
                        listBox3.Items.Add(i);
                    listBox3.Visible = true;
                    button6.Enabled = false;
                    label4.Visible = true;
                    richTextBox3.Visible = true;
                    button9.Visible = true;
                }
            }
            catch (Exception ex)
            {
                StreamWriter sw = new StreamWriter(@"D://5x5noOfRecords.txt");
                sw.Write(0);
                sw.Close();
                goto top5;
            }

        }

        //5x5 ok button 
        private void button9_Click(object sender, EventArgs e)
        {
            try {
                int num = Int32.Parse(richTextBox3.Text);
                if (num < 1 || num > noOfRecords5x5)
                    MessageBox.Show("No such Record Exist", "Oops!");
                else
                {
                    this.Hide();
                    Form4 f4 = new Form4();
                    f4.loadFromFile(num);
                    f4.ShowDialog();
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No such Record Exist", "Oops!");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
