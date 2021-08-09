using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace test1
{
    public partial class enable_new_session : Form
    {
        static int y=0, z=0;
        SqlConnection con;
        SqlDataAdapter sda;
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet(); DataSet ds2 = new DataSet();
        SqlCommandBuilder scb;
        SqlCommand cmd;
        BindingSource bsource = new BindingSource();
       
        public enable_new_session()
        {
            InitializeComponent();
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            try
            {
                int c;
                string s = "select * from kkk where UserID ='" + t_uid.Text + "'";
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                sda = new SqlDataAdapter(s, con);
                sda.Fill(ds, "t");
                c = ds.Tables["t"].Rows.Count;
                if (c == 0)
                {
                    MessageBox.Show("User does not Exist", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    if (t_pwd.Text == ds.Tables["t"].Rows[0][1].ToString())
                    {
                        b_check.Visible = true;
                        label5.Visible = true;
                        t_pwd.Visible = false;
                        t_uid.Visible = false;
                        label1.Visible = false;
                        label2.Visible = false;
                        label3.Visible = false;
                        b_ok.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Please try correct password", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (y == 1 && z == 0)
            {
                MessageBox.Show("Please allow them to register otherwise there will be unrecoverable data discrepancy", "Allow Students to register", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.Hide();

                home fr = new home();
                fr.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void enable_new_session_Load(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("By clicking it you are enabling a new session", "Are you Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    progressBar1.Visible = true;
                    // backgroundWorker1.RunWorkerAsync();
                    y = 1;
                    ds.Clear();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                    con.Open();
                    string q1 = "select * from std_detail";

                    sda = new SqlDataAdapter(q1, con);
                    sda.Fill(ds, "t1");
                    con.Close();

                    int p2 = ds.Tables["t1"].Rows.Count;
                    progressBar1.Maximum = p2;
                    for (int i = 0; i < p2; i++)
                    {
                        string p1 = ds.Tables["t1"].Rows[i][4].ToString();
                        if (p1 == "Semester 1")
                        {
                            ds.Tables["t1"].Rows[i][4] = "Semester 2";
                        }
                        if (p1 == "Semester 2")
                        {
                            ds.Tables["t1"].Rows[i][4] = "Semester 3";
                        }
                        if (p1 == "Semester 3")
                        {
                            ds.Tables["t1"].Rows[i][4] = "Semester 4";
                        }
                        if (p1 == "Semester 4")
                        {
                            ds.Tables["t1"].Rows[i][4] = "Semester 5";
                        }
                        if (p1 == "Semester 5")
                        {
                            ds.Tables["t1"].Rows[i][4] = "Semester 6";
                        }
                        if (p1 == "Semester 6" && ds.Tables["t1"].Rows[i][4].ToString() == "MCA")
                        {
                            ds.Tables["t1"].Rows[i][4] = "Passed Out";

                        }
                        if (p1 == "Semester 6" && ds.Tables["t1"].Rows[i][4].ToString() == "MBA")
                        {
                            ds.Tables["t1"].Rows[i][4] = "Passed Out";

                        }
                        if (p1 == "Semester 6")
                        {
                            ds.Tables["t1"].Rows[i][4] = "Semester 7";

                        }

                        if (p1 == "Semester 7")
                        {
                            ds.Tables["t1"].Rows[i][4] = "Semester 8";

                        }
                        if (p1 == "Semester 8")
                        {
                            ds.Tables["t1"].Rows[i][4] = "Passed out";

                        }
                        progressBar1.Value = i + 1;
                        progressBar1.Refresh();
                    }
                    scb = new SqlCommandBuilder(sda);
                    sda.Update(ds, "t1");

                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                    b_check.Visible = false;

                    con.Open();
                    string q2 = "select * from std_detail where sem != 'Passed out'";
                    sda = new SqlDataAdapter(q2, con);
                    sda.Fill(ds1, "t2");
                    int c5 = ds1.Tables["t2"].Rows.Count;
                    MessageBox.Show(c5 + " Eligible students", "Eligible", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = ds1.Tables[0];
                    if (c5 == 0)
                    {
                        z = 1;
                    }

                    con.Close();



                    //Inserting into Certificate details
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                    con.Open();
                    string q3 = "select * from std_detail where sem = 'Passed out'";
                    sda = new SqlDataAdapter(q3, con);
                    sda.Fill(ds2, "t2");
                    int c6 = ds2.Tables["t2"].Rows.Count;
                    con.Close();
                    for (int i = 0; i < c6; i++)
                    {
                        try
                        {

                            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                            con.Open();
                            string q = "insert into cer_detail (Reg_no,name,Branch,Batch) values('" + ds2.Tables["t2"].Rows[i][0].ToString() + "','" + ds2.Tables["t2"].Rows[i][2].ToString() + "','" + ds2.Tables["t2"].Rows[i][1].ToString() + "','" + ds2.Tables["t2"].Rows[i][5].ToString() + "')";
                            cmd = new SqlCommand(q, con);
                            cmd.ExecuteNonQuery();
                            con.Close();


                        }
                        catch (Exception eee)
                        {
                            continue;
                        }
                    }
                    txt_sess.Visible = true;
                    b_allow.Visible = true;
                    label4.Visible = true;
                    progressBar1.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void b_allow_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value = 0;
                progressBar1.Visible = true;
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                string q3 = "delete  from sub_detail";
                cmd = new SqlCommand(q3, con);
                cmd.ExecuteNonQuery();
                con.Close();
                z = 1;
                int abcd = 0;
                if (txt_sess.Text == "")
                {
                    MessageBox.Show("Session can not be left blank", "Session...????", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int c5 = ds1.Tables["t2"].Rows.Count;
                    for (int i = 0; i < c5; i++)
                    {
                        try
                        {
                            ds.Clear();
                            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                            con.Open();
                            string q = "insert into Reg_detail (Reg_no,Semester,Reg_Status,Branch,Session,batch) values('" + ds1.Tables["t2"].Rows[i][0].ToString() + "','" + ds1.Tables["t2"].Rows[i][4].ToString() + "','" + 'N' + "','" + ds1.Tables["t2"].Rows[i][1].ToString() + "','" + txt_sess.Text + "','" + ds1.Tables["t2"].Rows[i][5].ToString() + "')";
                            cmd = new SqlCommand(q, con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            abcd++;

                            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                            con.Open();
                            string q5 = "update std_detail set misc='Y' where Regd_no='" + ds1.Tables["t2"].Rows[i][0].ToString() + "'";
                            cmd = new SqlCommand(q5, con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            progressBar1.Value = i + 1;
                            progressBar1.Refresh();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ds1.Tables["t2"].Rows[i][0].ToString() + "already allowed for" + ds1.Tables["t2"].Rows[i][4].ToString(), "Allowed????", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            continue;
                        }
                    }
                    MessageBox.Show(abcd + "Students allowed to Register", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    b_assign.Visible = true;
                    b_allow.Visible = false;
                    txt_sess.Visible = false;
                    progressBar1.Visible = false;
                    label4.Visible = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void b_assign_Click(object sender, EventArgs e)
        {

            this.Hide();
            assign_subject a = new assign_subject();
            a.Show();
        }

        private void enable_new_session_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (y == 1 && z == 0)
            {
                MessageBox.Show("Please allow them to register otherwise there will be unrecoverable data discrepancy", "Allow Students to register", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Cancel = true;
            }
            else
            {
               //Application.Exit();
                enable_new_session a = new enable_new_session();
                a.Close();
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //for (int i = 1; i <= 100; i++)
            //{
            //    Thread.Sleep(100);
            //    backgroundWorker1.ReportProgress(i);
            //}
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //progressBar1.Value = e.ProgressPercentage;
            //this.Text = e.ProgressPercentage.ToString();
        }
    }
}
