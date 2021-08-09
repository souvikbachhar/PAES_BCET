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
    public partial class home : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter sda;
        DataSet ds = new DataSet();
        SqlCommandBuilder scb;
        BindingSource bsource = new BindingSource();
        public home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            addstud_details a = new addstud_details();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
           assign_subject a = new assign_subject();
            a.Show();

        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are You Sure", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (MessageBox.Show("Are You Sure", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void home_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration a = new Registration();
            a.Show();
        }

        private void b_enablenew_Click(object sender, EventArgs e)
        { 
            int c;
            string s = "select * from Reg_detail where Reg_status ='N'";
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            sda = new SqlDataAdapter(s, con);
            sda.Fill(ds, "t");
            c = ds.Tables["t"].Rows.Count;
            
            
            if(c!=0)
            {
                MessageBox.Show("All students of current session not yet registered.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Go to Add left over students to add left over students", "Check", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                button9.Focus();
            }

            else
            {
                 this.Hide();
                 enable_new_session a = new enable_new_session();
                 a.Show();
            }
        }


        private void b_report_Click(object sender, EventArgs e)
        {

            this.Hide();
            report a = new report();
            a.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            re_print a = new re_print();
            a.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string u_name = Microsoft.VisualBasic.Interaction.InputBox("Give User_name", "Authenticate");
            if (u_name != "")
            {
                ds.Clear();
                string pass = Microsoft.VisualBasic.Interaction.InputBox("Give Password", "Authenticate");
                if (pass != "")
                {
                    string s = "select * from kkk where UserID ='" + u_name + "'";
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                    con.Open();
                    sda = new SqlDataAdapter(s, con);
                    sda.Fill(ds, "t");
                    int c = ds.Tables["t"].Rows.Count;
                    if (c == 0)
                    {
                        MessageBox.Show("User does not Exist", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        if (pass == ds.Tables["t"].Rows[0][1].ToString())
                        {
                            this.Hide();
                            add_leftover_stud a = new add_leftover_stud();
                            a.Show();

                        }
                        else
                        {
                            MessageBox.Show("Please try correct password", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        }
                    }

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            certificate a = new certificate();
            a.Show();

        }

        private void home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are You Sure", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Application.Exit();
                home a = new home();
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
