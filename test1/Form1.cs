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
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataAdapter sda;
        SqlCommand cmd;
        DataSet ds = new DataSet(); DataSet ds5 = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void b_login_Click(object sender, EventArgs e)
        {
            int c;
            /*if (txt_usr.Text == "souvik" && txt_pass.Text == "1234")
            {
                label1.Visible = false;
                this.Hide();
                Form2 fr = new Form2();
                fr.Show();
               
               
                
            }
            else
            {
                label1.Text = "User id and Pwd does not match";
                label1.Visible = true;
            }*/

            string s = "select * from kkk where UserID ='" + txt_usr.Text + "'" ;
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
                if (txt_pass.Text == ds.Tables["t"].Rows[0][1].ToString())
                {
                    
                    this.Hide();
                    home fr = new home();
                    fr.Show();
                }
                else
                {MessageBox.Show("Please try correct password", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                   
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.button1, "PAES:Project to AutomiZed Examination Section \n Developed by Souvik Bachhar and Madhusmita Rosy(Batch 2011-15) \n under the guidance of Mr.Saumyaranjan Sahu(Asst. Prof.) \n Courtesy:CSE Dept.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Are You Sure", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                b_login_Click(sender,e);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("PAES:Project to AutomiZed Examination Section \n Developed by Souvik Bachhar and Madhusmita Rosy(Batch 2011-15) \n under the guidance of Mr.Saumyaranjan Sahu(Asst. Prof.) \n Courtesy:CSE Dept.", "PAES:Origin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are You Sure", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();

            }
            else
            {
                e.Cancel = true;
                //this.Activate();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void b_forgot_Click(object sender, EventArgs e)
        {
            ds5.Clear();
            string u_name = Microsoft.VisualBasic.Interaction.InputBox("Give User_name", "Authenticate");
            string s = "select * from kkk where UserID ='" + u_name + "'";
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            sda = new SqlDataAdapter(s, con);
            sda.Fill(ds5, "t");
            int c = ds5.Tables["t"].Rows.Count;
            if (c == 0)
            {
                MessageBox.Show("User does not Exist", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string pass = Microsoft.VisualBasic.Interaction.InputBox("Give Master Password", "Authenticate");
                if (pass == "souvik")
                {
                    MessageBox.Show("Your password is :" + ds5.Tables["t"].Rows[0][1].ToString(), "Keep it secret ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    MessageBox.Show("Master password wrong", "Illegal Access", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void b_change_Click(object sender, EventArgs e)
        {
            ds5.Clear();
            string u_name = Microsoft.VisualBasic.Interaction.InputBox("Give User_name", "Authenticate");
            string s = "select * from kkk where UserID ='" + u_name + "'";
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            sda = new SqlDataAdapter(s, con);
            sda.Fill(ds5, "t");
            int c = ds5.Tables["t"].Rows.Count;
            if (c == 0)
            {
                MessageBox.Show("User does not Exist", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string pass = Microsoft.VisualBasic.Interaction.InputBox("Give Master Password", "Authenticate");
                if (pass == "souvik")
                {
                    string p = Microsoft.VisualBasic.Interaction.InputBox("Give new Password", "Please Enter new Password");
                    if (p != "")
                    {
                        try
                        {
                            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                            con.Open();
                            string q = "update kkk set pass='" + p + "' where UserID='" + u_name + "'";
                            cmd = new SqlCommand(q, con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("User does not exists", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cannot leave it blank", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    MessageBox.Show("Master password wrong", "Illegal Access", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
    }
}
