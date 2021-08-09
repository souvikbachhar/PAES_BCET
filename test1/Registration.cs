using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic.PowerPacks.Printing;
using System.Drawing.Printing;
using System.Text.RegularExpressions;


namespace test1
{
    public partial class Registration : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        DataSet ds = new DataSet(); DataSet ds1 = new DataSet(); DataSet ds2 = new DataSet(); DataSet ds3 = new DataSet();
        SqlDataAdapter sda;
        static string rec_no;
        public Registration()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown+=new KeyEventHandler(Registration_KeyDown);
            this.KeyPress+=new KeyPressEventHandler(Registration_KeyPress);
            
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            t_regno.Focus();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

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
                MessageBox.Show("No such student Exists. Go and insert student details in add student details single mode", "Check", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                t_name.Text = "" ;
                t_branch.Text = "";
                t_roll.Text = "" ;
                t_sem.Text = "" ;
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
             //   t_regno.Text = "";
                t_regno.Focus();
            }
            else
            {
                ds1.Clear();
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                string q5 = "select session from Reg_detail where Reg_no='" + t_regno.Text + "' and Semester='" + ds.Tables["t"].Rows[0][4].ToString()+"'";
                sda = new SqlDataAdapter(q5, con);
                sda.Fill(ds1, "t");
                int c9 = ds1.Tables["t"].Rows.Count;
                if (c9 == 0)
                {
                    MessageBox.Show("Student yet not allowed", "Check", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
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
                  
                    t_regno.Focus();
                }
                else
                {
                    t_session.Text = "" + ds1.Tables["t"].Rows[0][0].ToString();
                    t_name.Text = "" + ds.Tables["t"].Rows[0][2].ToString();
                    t_branch.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                    t_roll.Text = "" + ds.Tables["t"].Rows[0][3].ToString();
                    t_sem.Text = "" + ds.Tables["t"].Rows[0][4].ToString();
                    t_batch.Text = "" + ds.Tables["t"].Rows[0][5].ToString();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                    con.Open();
                    string q4 = "select * from sub_detail where Branch='" + t_branch.Text + "' and Semester='" + t_sem.Text + "'";
                    sda = new SqlDataAdapter(q4, con);
                    sda.Fill(ds, "t1");
                    int d = ds.Tables["t1"].Rows.Count;
                    if (d == 0)
                    {
                        MessageBox.Show("Subject not assigned for this semester of this branch", "Check", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
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
                    }
                    else
                    {
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
                       

                    }

                }

            }
          
        }
        private void b_ok_Click(object sender, EventArgs e)
        {
            Work();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //b_ok.Visible = false;
            //var k = new PrintDialog();
            //if (k.ShowDialog() == DialogResult.OK)
            //{
            //    printForm1.PrinterSettings = k.PrinterSettings;
            //    printForm1.Print(this, PrintForm.PrintOption.ClientAreaOnly);
            //}
            //b_ok.Visible = true;



        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            home h = new home();
            h.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                textBox20.Text = "2000";
            }
            if (checkBox1.Checked == false)
            {
                textBox20.Text = "1500";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                textBox20.Text = "2500";
            }
            if (checkBox2.Checked == false)
            {
                textBox20.Text = "1500";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        public void abcd()
        {
            if (MessageBox.Show("Are You Sure", "Register", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    int f = 0, tot = 0;
                    if (textBox20.Text == "1500")
                    {
                        f = 0; tot = 1500;
                    }
                    if (textBox20.Text == "2000")
                    {
                        f = 500; tot = 2000;
                    }
                    if (textBox20.Text == "2500")
                    {
                        f = 1000; tot = 2500;
                    }
                    ds2.Clear();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                    con.Open();
                    string q4 = "select * from Reg_detail where Reg_no='" + t_regno.Text + "' and Semester='" + ds.Tables["t"].Rows[0][4].ToString() + "'";
                    sda = new SqlDataAdapter(q4, con);
                    sda.Fill(ds2, "t1");
                    int c3r = ds2.Tables["t1"].Rows.Count;

                    ds3.Clear();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                    con.Open();
                    string q5 = "select * from Reg_detail where Session='" + t_session.Text + "' and Recipt_no!='' and Semester='"+t_sem.Text+"'";
                    sda = new SqlDataAdapter(q5, con);
                    sda.Fill(ds3, "t1");
                    int c2r = ds3.Tables["t1"].Rows.Count;
                    ++c2r;
                    string r=t_sem.Text.ToString();
                    if ((r[9] %2)==0)
                    {
                        rec_no = t_session.Text + "/2/" + c2r;
                    }
                    else
                    {
                        rec_no = t_session.Text + "/1/" + c2r;
                    }
                    if (ds2.Tables["t1"].Rows[0][3].ToString() == "N")
                    {

                        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                        con.Open();
                        string q = "update Reg_detail set Recipt_no='"+rec_no+"' ,Reg_status='R" + "',Fine='" + f + "',d_t='" + DateTime.Now + "',total='" + tot + "' where Reg_no='" + t_regno.Text + "' and Semester='" + ds.Tables["t"].Rows[0][4].ToString() + "'";
                        cmd = new SqlCommand(q, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Done", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                       
                    }
                    else
                    {
                        MessageBox.Show("Student already registered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        t_regno.Text = "";
                        t_regno.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Some Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    t_regno.Text = "";
                    t_regno.Focus();
                }
            }
        }
        private void b_reg_Click(object sender, EventArgs e)
        {
            abcd(); button5.Visible = true;
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

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
            button5.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            reg_print r = new reg_print(t_regno.Text,t_name.Text,t_branch.Text,t_sem.Text,textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,textBox6.Text,textBox7.Text,textBox8.Text,textBox9.Text,textBox10.Text,textBox11.Text,textBox12.Text,textBox13.Text,textBox14.Text,textBox15.Text,textBox16.Text,textBox17.Text,textBox18.Text,textBox22.Text,textBox21.Text,textBox20.Text,textBox23.Text,textBox24.Text,t_roll.Text,rec_no);
            r.Show();
        }

        private void t_regno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Work();
            }
        }

        private void Registration_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.Control && e.KeyCode == Keys.S)
            //{
            //    abcd();
            //    e.SuppressKeyPress = false;
            //}
        }

        private void Registration_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 18)
            //{
            //    abcd();
            //    // e.SuppressKeyPress = false;
            //}
        }

        private void t_sem_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Session_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are You Sure", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Application.Exit();
                Registration a = new Registration();
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
