using System;
using System.Net;
using System.IO;
using System.Net.Mail;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Windows.Forms.DataVisualization.Charting;
using System.Security.Cryptography;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private DataTable table;
        private listTeacher mainlist;
        public Form1()
        {
            InitializeComponent();
        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(label16.Text);
            Adress add1 = new Adress("Spain", "Alicante", "Carrer Castanos", 43);
            bool habbits = true;
            if (radioButton1.Checked == true)
            {
                habbits = true;
            }
            else if (radioButton2.Checked == false)
                habbits = false;
            Teacher teacher = new Teacher(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), habbits, Nation.French, add1, textBox6.Text, Convert.ToInt32(textBox9.Text), textBox10.Text, KeyWords.python, Convert.ToInt32(textBox9.Text));
            mainlist.add(teacher);
            comboBox1.Items.Add(textBox2.Text);
            treeView1.Nodes.Add(textBox2.Text);
            if (i == 0)
            {
                dataGridView1.Rows[i].Cells[0].Value = (textBox1.Text);
                dataGridView1.Rows[i].Cells[1].Value = (textBox2.Text);
                dataGridView1.Rows[i].Cells[2].Value = (textBox3.Text);
            }
            else
            {
                dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
            }
            label16.Text = Convert.ToString(Convert.ToInt32(label16.Text) + 1);

            Series series = new Series();
            chart1.Series.Add(textBox1.Text + " " + textBox2.Text);
            chart1.Series[0].Points.Add(treeView1.Nodes[i].Nodes.Count);

            textBox1.Clear(); textBox2.Clear();
            textBox3.Clear(); textBox4.Clear();
            textBox5.Clear(); textBox6.Clear();
            textBox9.Clear(); textBox10.Clear();
            textBox11.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            button4.Visible = true; comboBox3.Visible = true;
            label1.Visible = false; textBox1.Visible = false;
            label2.Visible = false; textBox2.Visible = false;
            label3.Visible = false; textBox3.Visible = false;
            label4.Visible = false; textBox4.Visible = false;
            label5.Visible = false; textBox5.Visible = false;
            label6.Visible = false; textBox6.Visible = false;
            label7.Visible = false; radioButton1.Visible = false; radioButton2.Visible = false;
            treeView1.Visible = false;

            createbutton.Visible = false; textBox9.Visible = false; textBox10.Visible = false;
            textBox11.Visible = false; label12.Visible = false; label13.Visible = false;
            label14.Visible = false; label9.Visible = false;
            pictureBox1.Visible = false; button5.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            mainlist = new listTeacher();
            dataGridView1.Columns.Add("column1", "Name");
            dataGridView1.Columns.Add("column2", "Surname");
            dataGridView1.Columns.Add("column3", "Age");
            dataGridView2.Columns.Add("column1", "Name");
            dataGridView2.Columns.Add("column2", "Surname");
            dataGridView2.Columns.Add("column3", "Age");
            chart1.Series.RemoveAt(0);
            chart1.Titles.Add("К-кість студентів");
            chart1.Palette = ChartColorPalette.Light;
            

            label1.Visible= false; textBox1.Visible=false;
            label2.Visible= false; textBox2.Visible = false;
            label3.Visible= false; textBox3.Visible = false;
            label4.Visible= false; textBox4.Visible = false;
            label5.Visible= false; textBox5.Visible = false;
            label6.Visible= false; textBox6.Visible = false;
            label7.Visible= false; radioButton1.Visible=false; radioButton2.Visible=false;

            button1.Visible=false; createbutton.Visible=false; button2.Visible=false;
            comboBox1.Visible=false; comboBox2.Visible=false;
            textBox12.Visible=false; textBox13.Visible=false; textBox14.Visible=false;
            label8.Visible = false; label9.Visible = false; label15.Visible = false;
            label10.Visible = false; label11.Visible = false; label12.Visible = false;
            label13.Visible = false; label14.Visible = false;
            textBox7.Visible=false; textBox8.Visible=false;
            textBox9.Visible=false; textBox10.Visible=false; textBox11.Visible=false;
            treeView1.Visible =false;
            button5.Visible=false; pictureBox1.Visible=false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(label17.Text);
            Adress add1 = new Adress("Spain", "Alicante", "Carrer Castanos", 5);
            bool habbits = true;
            if (radioButton1.Checked == true)
            {
                habbits = true;
            }
            else if (radioButton2.Checked == false)
                habbits = false;
            Student student = new Student(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), habbits, Nation.French, add1, textBox6.Text, Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text), Key.js);
            find(student);
            comboBox2.Items.Add(textBox2.Text);
            treeView1.Nodes[comboBox1.SelectedIndex].Nodes.Add(textBox1.Text + " " + textBox2.Text);
            if (i == 0)
            {
                dataGridView2.Rows[i].Cells[0].Value = (textBox1.Text);
                dataGridView2.Rows[i].Cells[1].Value = (textBox2.Text);
                dataGridView2.Rows[i].Cells[2].Value = (textBox3.Text);
            }
            else
            {
                dataGridView2.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
            }
            label17.Text = Convert.ToString(Convert.ToInt32(label17.Text) + 1);
            textBox1.Clear(); textBox2.Clear();
            textBox3.Clear(); textBox4.Clear();
            textBox5.Clear(); textBox6.Clear();
            textBox7.Clear(); textBox8.Clear();
            textBox9.Clear(); textBox10.Clear();
            textBox11.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button4.Visible = true; comboBox3.Visible = true;
            label1.Visible = false; textBox1.Visible = false;
            label2.Visible = false; textBox2.Visible = false;
            label3.Visible = false; textBox3.Visible = false;
            label4.Visible = false; textBox4.Visible = false;
            label5.Visible = false; textBox5.Visible = false;
            label6.Visible = false; textBox6.Visible = false;
            label7.Visible = false; radioButton1.Visible = false; radioButton2.Visible = false;
            treeView1.Visible = false;

            label8.Visible = false; label10.Visible = false; label11.Visible = false;
            button1.Visible = false; textBox7.Visible = false; textBox8.Visible = false; comboBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CourseWork kurs = new CourseWork(textBox12.Text, textBox13.Text, Convert.ToDateTime(textBox14.Text));

            for (int i = 0; i < mainlist.List.Count; i++)
                for(int j = 0;j < mainlist.List[i].List.Count; j++)
                {
                    if (mainlist.List[i].List[j].Surname == ((comboBox2.SelectedItem).ToString()))
                    {
                        treeView1.Nodes[i].Nodes[j].Nodes.Add(textBox13.Text);
                    }
                }
            textBox12.Text = "Name"; textBox13.Text = "Description"; textBox14.Text = "Date";
            button4.Visible = true; comboBox3.Visible = true;

            treeView1.Visible = false; button2.Visible = false;
            textBox12.Visible = false; textBox13.Visible = false; textBox14.Visible = false;
            label15.Visible = false; comboBox2.Visible = false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ShowChart(mainlist.List);
        }

        public void ShowChart(List<Teacher> lst)
        {
            this.chart1.Series[0].Points.Clear();
            for (int i = 0; i < lst.Count; i++)
            {
                this.chart1.Series[0].Points.AddXY(lst[i].Surname, lst[i].List.Count );
            }
        }

        public void find(Student student)
        {
            for (int i = 0; i < mainlist.List.Count; i++)
            {
                if (mainlist.List[i].Surname == ((comboBox1.SelectedItem).ToString()))
                {
                    mainlist.List[i].List.Add(student);
                    Console.WriteLine(mainlist.List[i].List.Count);
                    break;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (((comboBox3.SelectedItem).ToString()) == "Student")
            {
                label1.Visible = true; textBox1.Visible = true;
                label2.Visible = true; textBox2.Visible = true;
                label3.Visible = true; textBox3.Visible = true;
                label4.Visible = true; textBox4.Visible = true;
                label5.Visible = true; textBox5.Visible = true;
                label6.Visible = true; textBox6.Visible = true;
                label7.Visible = true; radioButton1.Visible = true; radioButton2.Visible = true;
                treeView1.Visible = true;

                label8.Visible = true; label10.Visible = true; label11.Visible = true;
                button1.Visible = true; textBox7.Visible = true; textBox8.Visible = true; comboBox1.Visible = true;
                button4.Visible = false; comboBox3.Visible = false;
            }
            if (((comboBox3.SelectedItem).ToString()) == "Coursework")
            {
                treeView1.Visible = true; button2.Visible = true; 
                textBox12.Visible = true; textBox13.Visible = true; textBox14.Visible = true;
                label15.Visible = true; comboBox2.Visible = true;

                button4.Visible = false; comboBox3.Visible = false;
            }
            if (((comboBox3.SelectedItem).ToString()) == "Teacher")
            {
                label1.Visible = true; textBox1.Visible = true;
                label2.Visible = true; textBox2.Visible = true;
                label3.Visible = true; textBox3.Visible = true;
                label4.Visible = true; textBox4.Visible = true;
                label5.Visible = true; textBox5.Visible = true;
                label6.Visible = true; textBox6.Visible = true;
                label7.Visible = true; radioButton1.Visible = true; radioButton2.Visible = true;
                treeView1.Visible = true; button5.Visible = true; 

                createbutton.Visible = true; textBox9.Visible = true; textBox10.Visible = true;
                textBox11.Visible = true; label12.Visible = true; label13.Visible = true;
                label14.Visible = true; label9.Visible = true;

                button4.Visible = false; comboBox3.Visible = false;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Thread t = new Thread((ThreadStart)(() => {
                OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP; *.JPG; *.PNG).|*.BMP; *.JPG; *.PNG|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                }
        }    ));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
            pictureBox1.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mainlist.save_json();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress("christinabakhir@gmail.com");
            MailAddress to = new MailAddress("christinabakhir@gmail.com");
            MailMessage m = new MailMessage(from, to);
            m.Subject = "C#";
            m.IsBodyHtml= true;
            m.Body = "<h3>ListOfTeachers</h3>";
            m.Attachments.Add(new Attachment("C:\\Users\\Olexii\\source\\repos\\WindowsFormsApp2\\WindowsFormsApp2\\bin\\Debug\\ListOfTeachers.json"));
            SmtpClient smtp= new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("christinabakhir@gmail.com", "zxzpvwpmhjypfyaq");
            smtp.EnableSsl = true;
            smtp.Send(m);
        }
    }
}