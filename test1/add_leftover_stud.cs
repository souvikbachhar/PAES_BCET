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
    public partial class add_leftover_stud : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter sda;
        DataSet ds = new DataSet(); DataSet ds5 = new DataSet();
        SqlCommandBuilder scb;
        BindingSource bsource = new BindingSource();
        public add_leftover_stud()
        {
            InitializeComponent();
        }

        private void add_leftover_stud_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                con.Open();
                string q1 = "select * from std_detail where misc='N'";
                sda = new SqlDataAdapter(q1, con);
                sda.Fill(ds, "t1");

                dataGridView1.DataSource = ds.Tables[0];


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            home a = new home();
            a.Show();
        }



        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 fr = new Form1();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void b_allow_Click_1(object sender, EventArgs e)
        {
            if (t_session.Text == "")
            {
                MessageBox.Show("Session Cannot be left blank", "Fill Session", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                int c5 = ds.Tables["t1"].Rows.Count;
                for (int i = 0; i < c5; i++)
                {
                    try
                    {
                       
                        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                        con.Open();
                        string q = "insert into Reg_detail (Reg_no,Semester,Reg_Status,Branch,Session,batch) values('" + ds.Tables["t1"].Rows[i][0].ToString() + "','" + ds.Tables["t1"].Rows[i][4].ToString() + "','" + 'N' + "','" + ds.Tables["t1"].Rows[i][1].ToString() + "','" + t_session.Text + "','" + ds.Tables["t1"].Rows[i][5].ToString() + "')";
                        cmd = new SqlCommand(q, con);
                        cmd.ExecuteNonQuery();
                        con.Close();


                        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                        con.Open();
                        string q5 = "update std_detail set misc='Y' where Regd_no='" + ds.Tables["t1"].Rows[i][0].ToString() + "'";
                        cmd = new SqlCommand(q5, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Allowed for Current Semester","Done",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");

                        ds.Clear();
                        con.Open();
                        string q1 = "select * from std_detail where misc='N'";
                        sda = new SqlDataAdapter(q1, con);
                        sda.Fill(ds, "t1");

                        dataGridView1.DataSource = ds.Tables[0];


                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error");
                    }

                }
            }
        }

        private void add_leftover_stud_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void add_leftover_stud_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are You Sure", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               // Application.Exit();
                add_leftover_stud a = new add_leftover_stud();
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