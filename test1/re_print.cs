using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace test1
{
    public partial class re_print : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        DataSet ds = new DataSet(); DataSet ds1 = new DataSet(); DataSet ds2 = new DataSet(); string re = "";
        SqlDataAdapter sda;
        public re_print()
        {
            InitializeComponent();
        }
        public void Work()
        {
            ds.Clear();
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            string q3 = "select * from std_detail where Regd_no='" + t_regno.Text + "'";
            sda = new SqlDataAdapter(q3, con);
            sda.Fill(ds, "t");
            int c = ds.Tables["t"].Rows.Count;
            if (c == 0)
            {
                MessageBox.Show("No such student Exists.", "Check", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                t_name.Text = "";
                t_branch.Text = "";
                t_roll.Text = "";
                t_sem.Text = "";
                t_batch.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                textBox12.Text = "";
                textBox13.Text = "";
                textBox14.Text = "";
                textBox15.Text = "";
                textBox16.Text = "";
                textBox17.Text = "";
                textBox18.Text = "";
                textBox22.Text = "";
                textBox21.Text = "";
                textBox23.Text = "";
                textBox24.Text = "";
                t_session.Text = "";
               // t_regno.Text = "";
                t_regno.Focus(); button5.Visible = false;
            }
            else
            {
                ds1.Clear();
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                string q5 = "select * from Reg_detail where Reg_no='" + t_regno.Text + "' and Semester='" + ds.Tables["t"].Rows[0][4].ToString() + "' and Reg_status='R'";
                sda = new SqlDataAdapter(q5, con);
                sda.Fill(ds1, "t");
                int c9 = ds1.Tables["t"].Rows.Count;
                if (c9 == 0)
                {
                    MessageBox.Show("Student yet not Registered", "Check", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    t_name.Text = "";
                    t_branch.Text = "";
                    t_roll.Text = "";
                    t_sem.Text = "";
                    t_batch.Text = "";
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox10.Text = "";
                    textBox11.Text = "";
                    textBox12.Text = "";
                    textBox13.Text = "";
                    textBox14.Text = "";
                    textBox15.Text = "";
                    textBox16.Text = "";
                    textBox17.Text = "";
                    textBox18.Text = "";
                    textBox22.Text = "";
                    textBox21.Text = "";
                    textBox23.Text = "";
                    textBox24.Text = "";
                    t_session.Text = "";
                   // t_regno.Text = "";
                    t_regno.Focus();
                    button5.Visible = false;
                }
                else
                {
                    re = "" + ds1.Tables["t"].Rows[0][0].ToString();
                    t_session.Text = "" + ds1.Tables["t"].Rows[0][5].ToString();
                    t_name.Text = "" + ds.Tables["t"].Rows[0][2].ToString();
                    t_branch.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                    t_roll.Text = "" + ds.Tables["t"].Rows[0][3].ToString();
                    t_sem.Text = "" + ds.Tables["t"].Rows[0][4].ToString();
                    t_batch.Text = "" + ds.Tables["t"].Rows[0][5].ToString();
                    t_total.Text = "" + ds1.Tables["t"].Rows[0][8].ToString();
                    t_date.Text = "" + ds1.Tables["t"].Rows[0][7].ToString();

                    if (t_total.Text == "1500")
                    {
                        fine.Text = "";
                    }
                    else if (t_total.Text == "2000")
                    {
                        fine.Text = "500";
                    }
                    else if (t_total.Text == "2500")
                    {
                        fine.Text = "1000";
                    }
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                    con.Open();
                    string q4 = "select * from sub_detail where Branch='" + t_branch.Text + "' and Semester='" + t_sem.Text + "'";
                    sda = new SqlDataAdapter(q4, con);
                    sda.Fill(ds, "t1");
                    int d = ds.Tables["t1"].Rows.Count;
             
                        textBox1.Text = "" + ds.Tables["t1"].Rows[0][2].ToString();
                        textBox2.Text = "" + ds.Tables["t1"].Rows[0][3].ToString();
                        textBox3.Text = "" + ds.Tables["t1"].Rows[0][4].ToString();
                        textBox4.Text = "" + ds.Tables["t1"].Rows[0][5].ToString();
                        textBox5.Text = "" + ds.Tables["t1"].Rows[0][6].ToString();
                        textBox6.Text = "" + ds.Tables["t1"].Rows[0][7].ToString();
                        textBox7.Text = "" + ds.Tables["t1"].Rows[0][8].ToString();
                        textBox8.Text = "" + ds.Tables["t1"].Rows[0][9].ToString();
                        textBox9.Text = "" + ds.Tables["t1"].Rows[0][10].ToString();
                        textBox10.Text = "" + ds.Tables["t1"].Rows[0][11].ToString();
                        textBox11.Text = "" + ds.Tables["t1"].Rows[0][12].ToString();
                        textBox12.Text = "" + ds.Tables["t1"].Rows[0][13].ToString();
                        if (ds.Tables["t1"].Rows[0][14].ToString() == "--Select--")
                        {
                            textBox13.Text = "";
                        }
                        else
                        {
                            textBox13.Text = "" + ds.Tables["t1"].Rows[0][14].ToString();
                        }


                        textBox14.Text = "" + ds.Tables["t1"].Rows[0][15].ToString();
                        textBox15.Text = "" + ds.Tables["t1"].Rows[0][16].ToString();
                        textBox16.Text = "" + ds.Tables["t1"].Rows[0][17].ToString();
                        textBox17.Text = "" + ds.Tables["t1"].Rows[0][18].ToString();
                        textBox18.Text = "" + ds.Tables["t1"].Rows[0][19].ToString();
                        textBox22.Text = "" + ds.Tables["t1"].Rows[0][20].ToString();
                        textBox21.Text = "" + ds.Tables["t1"].Rows[0][21].ToString();
                        textBox23.Text = "" + ds.Tables["t1"].Rows[0][22].ToString();
                        textBox24.Text = "" + ds.Tables["t1"].Rows[0][23].ToString();
                        // t_session.Text = "" + ds.Tables["t1"].Rows[0][24].ToString();

                        button5.Visible = true;
                    }

                
            
            }
        }
        private void re_print_Load(object sender, EventArgs e)
        {

        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            Work();
        }

        private void t_regno_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                Work();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            home h = new home();
            h.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.Show();
        }

        private void t_regno_TextChanged(object sender, EventArgs e)
        {
            string s12 = t_regno.Text, k = "";
            int r;
            if (!int.TryParse(s12, out  r))
            {
                // MessageBox.Show("Wrong format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                for (int i = 0; i < s12.Length - 1; i++)
                {
                    k = k + s12[i];
                }
                t_regno.Text = k;
                //   txt_reg.Focus();
            }
            else if (s12.Length > 10)
            {
                MessageBox.Show("Registration no. cannot exceed 10 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                for (int i = 0; i < s12.Length - 1; i++)
                {
                    k = k + s12[i];
                }
                t_regno.Text = k;
                t_regno.Focus();
            }

            if (Regex.IsMatch(t_regno.Text, @"^[\sa-zA-Z0-9]*$")) return;
            {
                MessageBox.Show("Special characters are not allowed.");
                t_regno.Text = String.Empty;
            } 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            re_reg_print r = new re_reg_print(t_regno.Text, t_name.Text, t_branch.Text, t_sem.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text, textBox15.Text, textBox16.Text, textBox17.Text, textBox18.Text, textBox22.Text, textBox21.Text, t_total.Text, textBox23.Text, textBox24.Text, t_roll.Text,t_date.Text,re);
            r.Show();
        }

        private void re_print_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are You Sure", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Application.Exit();
                re_print a = new re_print();
                a.Close();
            }
            else
            {
                e.Cancel = true;
                //this.Activate();
            }
        }

        private void re_print_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Are You Sure", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
