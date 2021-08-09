using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test1
{
    public partial class addstud_bulk : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter sda;
        DataSet ds = new DataSet();
        static string s_name = "", s_regno = "", s_roll = "", s_sem = "", s_batch = "",s_branch="",pq="";
        static int t = 0,k=0,m=0,n=0,ch=0;
        public addstud_bulk()
        {
            InitializeComponent();
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
           
            try
            {
                string s = textBox1.Text;
                for (int i = 1; i < s.Length; i++)
                {
                   
                   
                        if (s[i] == '\n')
                        {
                            //if (ch == 0)
                            //{
                            //    for (int kt = 0; kt < i; kt++)
                            //    {
                            //        pq = pq + s[kt];
                            //        ch = 1;
                            //    }
                            //    if (pq != "Registration_no\tName\tRoll_no\tSemester\tBatch\r")
                            //    {
                            //        MessageBox.Show("Wrong Format.Try: \n Registration_no,Name,Roll_no,Semester,Batch", "Check", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            //        textBox1.Text = "";
                            //        ch = 0;
                            //        break;

                            //    }
                            //}
                            k = i;
                            while (s[i + 1] != '\t')
                            {
                                s_regno = s_regno + s[i + 1];
                                i++;

                            }
                            m = i;
                            i = k;
                            ++t;
                        }
                        if ((s[i] == '\t') && (t == 1))
                        {
                            k = i;
                            while (s[i + 1] != '\t')
                            {
                                s_name = s_name + s[i + 1];
                                i++;
                            }
                            ++t; m = i;
                            i = k;
                            continue;
                        }
                        if ((s[i] == '\t') && (t == 2))
                        {
                            k = i;
                            while (s[i + 1] != '\t')
                            {
                                s_roll = s_roll + s[i + 1];
                                i++;
                            }
                            ++t; m = i;
                            i = k;
                            s_branch = "" + s_roll[3] + s_roll[4]+s_roll[5];
                            if (s_branch == "CS/")
                            {
                                s_branch = "Computer Science & Engg.";
                            }
                            if (s_branch == "ME/")
                            {
                                s_branch = "Mechanical Engg.";
                            }
                            if (s_branch == "ET/")
                            {
                                s_branch = "Electronics & Telecommunication Engg.";
                            }
                            if (s_branch == "EE/")
                            {
                                s_branch = "Electrical Engg.";
                            }
                            if (s_branch == "IT/")
                            {
                                s_branch = "Information Technology";
                            }
                            if (s_branch == "EI/")
                            {
                                s_branch = "Electronics & Instrumentation Engg.";
                            }
                            if (s_branch == "EEE")
                            {
                                s_branch = "Electrical & Electronics Engg.";
                            }
                            if (s_branch == "CE/")
                            {
                                s_branch = "Civil Engg.";
                            }
                            continue;
                        }
                        if ((s[i] == '\t') && (t == 3))
                        {
                            k = i;
                            while (s[i + 1] != '\t')
                            {
                                s_sem = s_sem + s[i + 1];
                                i++;
                            }
                            ++t; m = i;
                            i = k; continue;
                        }

                        if ((s[i] == '\t') && (t == 4))
                        {
                            k = i;
                            while (s[i + 1] != '\r')
                            {
                                s_batch = s_batch + s[i + 1];
                                i++;
                            }
                            if (s_name != "Registration_no")
                            {
                                ds.Clear();
                                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                                con.Open();
                                string q1 = "select * from std_detail where Regd_no ='" + s_regno + "'";
                                sda = new SqlDataAdapter(q1, con);
                                sda.Fill(ds, "t1");
                                int c = ds.Tables["t1"].Rows.Count;
                                if (c == 0)
                                {
                                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                                    con.Open();
                                    string q = "insert into std_detail values('" + s_regno + "','" + s_branch + "','" + s_name + "','" + s_roll + "','" + s_sem + "','" + s_batch + "','N')";
                                    cmd = new SqlCommand(q, con);
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                    n++;
                                    
                                }
                                else
                                {
                                    MessageBox.Show("Data already exists for registraton no." + s_regno + ".If you want to edit it go in single mode in student details", "Check", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                   
                                }
                                s_batch = "";
                                s_branch = "";
                                s_name = "";
                                s_regno = "";
                                s_roll = "";
                                s_sem = "";

                            }
                            t = 0; m = i;
                            i = k;

                        }

                    

                }
            }
           catch (Exception ex)
            {
                MessageBox.Show(n + "data entered", "Check", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                MessageBox.Show("Done", "Check ", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                textBox1.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            addstud_details a = new addstud_details();
            a.Show();
            
        }

        private void addstud_bulk_Load(object sender, EventArgs e)
        {

        }

        private void addstud_bulk_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void addstud_bulk_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are You Sure", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Application.Exit();
                addstud_bulk a = new addstud_bulk();
                a.Close();
            }
            else
            {
                e.Cancel = true;
                //this.Activate();
            }
        }
    }
}
