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
    public partial class certificate : Form
    {
        SqlConnection con;
        SqlDataAdapter sda;
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet(); DataSet ds2 = new DataSet(); DataSet ds5 = new DataSet(); DataSet ds3 = new DataSet();
        SqlCommandBuilder scb;
        SqlCommand cmd;
        BindingSource bsource = new BindingSource();
        static int a = 0,d=0;
        
        public certificate()
        {
            InitializeComponent();
        }
        public void work()
        {
            try
            {
                ds.Clear();
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                string q1 = "select Reg_no as Registration_no,name as Name,branch,batch,pro_no as Provisional_no,pro_iss_date as Provisional_Issuedate,ori_no as Orignal_cerno,ori_iss_date as Orignal_Issuedate from cer_detail";
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
        public void sss()
        {
            ds3.Clear();
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            string q1 = "select * from cer_detail where Reg_no ='" + txt_reg_search.Text + "'";
            sda = new SqlDataAdapter(q1, con);
            sda.Fill(ds3, "t1");

            l_pno.Text = ds3.Tables["t1"].Rows[0][2].ToString();
            l_proiss.Text = ds3.Tables["t1"].Rows[0][3].ToString();
            l_ono.Text = ds3.Tables["t1"].Rows[0][4].ToString();
            l_oriiss.Text = ds3.Tables["t1"].Rows[0][5].ToString();
        }

        private void certificate_Load(object sender, EventArgs e)
        {
            try
            {
                l_reg.Text = "";
                l_name.Text = "";
                l_branch.Text = "";
                l_roll.Text = "";
                l_batch.Text = "";
                l_pno.Text = "";
                l_proiss.Text = "";
                l_ono.Text = "";
                l_oriiss.Text = "";
                txt_reg_search.Focus();
                work();
                foreach (DataGridViewColumn dcol in dataGridView1.Columns)
                {
                    DataGridViewColumn coloumn0 = dataGridView1.Columns[0];
                    coloumn0.Width = 150;
                    DataGridViewColumn coloumn1 = dataGridView1.Columns[1];
                    coloumn1.Width = 200;
                    DataGridViewColumn coloumn2 = dataGridView1.Columns[2];
                    coloumn2.Width = 200;
                    DataGridViewColumn coloumn3 = dataGridView1.Columns[3];
                    coloumn3.Width = 100;
                    DataGridViewColumn coloumn4 = dataGridView1.Columns[4];
                    coloumn4.Width = 200;
                    DataGridViewColumn coloumn5 = dataGridView1.Columns[5];
                    coloumn5.Width = 100;
                    DataGridViewColumn coloumn6 = dataGridView1.Columns[6];
                    coloumn5.Width = 130;
                    DataGridViewColumn coloumn7 = dataGridView1.Columns[7];
                    coloumn5.Width = 130;

                    //dcol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                con.Open();
                string q3 = "select distinct batch from std_detail where sem = 'Passed out' ";
                sda = new SqlDataAdapter(q3, con);
                sda.Fill(ds, "bat");
                con.Close();
                int p4 = ds.Tables["bat"].Rows.Count;

                for (int i = 0; i < p4; i++)
                {
                    string dis = ds.Tables["bat"].Rows[i][0].ToString();
                    c_batch.Items.Add(dis);


                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void certificate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are You Sure", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //  Application.Exit();
                certificate a = new certificate();
                a.Close();
            }
            else
            {
                e.Cancel = true;
                //this.Activate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            home a = new home();
            a.Show();
        }

        private void b_update_Click(object sender, EventArgs e)
        {
            try
            {
                string u_name = Microsoft.VisualBasic.Interaction.InputBox("Give User_name", "Authenticate");
                if (u_name != "")
                {
                    ds5.Clear();
                    string pass = Microsoft.VisualBasic.Interaction.InputBox("Give Password", "Authenticate");
                    if (pass != "")
                    {
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
                            if (pass == ds5.Tables["t"].Rows[0][1].ToString())
                            {
                                //work();
                                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                                con.Open();
                                string q1 = "select Reg_no as Registration_no,name as Name,branch,batch,pro_no as Provisional_no,pro_iss_date as Provisional_Issuedate,ori_no as Orignal_cerno,ori_iss_date as Orignal_Issuedate from cer_detail";
                                sda = new SqlDataAdapter(q1, con);
                                sda.Fill(ds, "t1");

                                dataGridView1.DataSource = ds.Tables[0];


                                con.Close();
                                scb = new SqlCommandBuilder(sda);
                                sda.Update(ds, "t1");
                                work();
                            }
                            else
                            {
                                MessageBox.Show("Please try correct password", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration no already exists", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_reg_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    c_branch_search.SelectedIndex = -1;
                    c_batch.SelectedIndex = -1;
                    ds1.Clear();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                    con.Open();
                    string q1 = "select * from cer_detail where Reg_no ='" + txt_reg_search.Text + "'";
                    sda = new SqlDataAdapter(q1, con);
                    sda.Fill(ds1, "t1");
                    //dataGridView1.DataSource = ds.Tables[0];
                    int p4 = ds1.Tables["t1"].Rows.Count;
                    con.Close();
                    if (p4 == 0)
                    {
                        MessageBox.Show("No such Student exists or Student had not passed out yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        if (ds1.Tables["t1"].Rows[0][2].ToString() == "")
                        {
                            string pno = Microsoft.VisualBasic.Interaction.InputBox("Provisional yet not recieved\n\n\nLeft it blank and press OK if not yet recieved", "Enter Provisional certificate no");

                            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                            con.Open();
                            string q = "update cer_detail set pro_no='" + pno + "' where Reg_no='" + txt_reg_search.Text + "'";
                            cmd = new SqlCommand(q, con);
                            cmd.ExecuteNonQuery();
                            con.Close();

                        }
                        if (ds1.Tables["t1"].Rows[0][4].ToString() == "")
                        {
                            string pno = Microsoft.VisualBasic.Interaction.InputBox("Orignal yet not recieved\n\n\nLeft it blank and press OK if not yet recieved", "Enter Orignal certificate no");

                            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                            con.Open();
                            string q = "update cer_detail set ori_no='" + pno + "' where Reg_no='" + txt_reg_search.Text + "'";
                            cmd = new SqlCommand(q, con);
                            cmd.ExecuteNonQuery();
                            con.Close();

                        }


                        dataGridView1.DataSource = ds1.Tables[0];
                        ds2.Clear();
                        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                        con.Open();
                        string q4 = "select * from std_detail where Regd_no ='" + txt_reg_search.Text + "'";
                        sda = new SqlDataAdapter(q4, con);
                        sda.Fill(ds2, "t1");
                        ds1.Clear();
                        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                        con.Open();
                        string q3 = "select * from cer_detail where Reg_no ='" + txt_reg_search.Text + "'";
                        sda = new SqlDataAdapter(q3, con);
                        sda.Fill(ds1, "t1");
                        int p5 = ds1.Tables["t1"].Rows.Count;
                        l_reg.Text = ds2.Tables["t1"].Rows[0][0].ToString();
                        l_name.Text = ds2.Tables["t1"].Rows[0][2].ToString();
                        l_branch.Text = ds2.Tables["t1"].Rows[0][1].ToString();
                        l_roll.Text = ds2.Tables["t1"].Rows[0][3].ToString();
                        l_batch.Text = ds2.Tables["t1"].Rows[0][5].ToString();
                        l_pno.Text = ds1.Tables["t1"].Rows[0][2].ToString();
                        l_proiss.Text = ds1.Tables["t1"].Rows[0][3].ToString();
                        l_ono.Text = ds1.Tables["t1"].Rows[0][4].ToString();
                        l_oriiss.Text = ds1.Tables["t1"].Rows[0][5].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Some error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void b_proiss_Click(object sender, EventArgs e)
        {
            try
            {
                if (l_reg.Text == "")
                {
                    MessageBox.Show("Enter Registration no.", "Give details", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txt_reg_search.Focus();
                }
                else
                {
                    if (l_pno.Text == "")
                    {
                        MessageBox.Show("Provisional not yet recieved", "Not yet recieved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        if (l_proiss.Text != "")
                        {
                            MessageBox.Show("Already issued", "Issued", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                            con.Open();
                            string q = "update cer_detail set pro_iss_date='" + DateTime.Now + "' where Reg_no='" + txt_reg_search.Text + "'";
                            cmd = new SqlCommand(q, con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Issued Sucessfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            sss();
                            work();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void b_oriiss_Click(object sender, EventArgs e)
        {
            try
            {
                if (l_reg.Text == "")
                {
                    MessageBox.Show("Enter Registration no.", "Give details", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txt_reg_search.Focus();
                }
                else
                {
                    if (l_proiss.Text == "")
                    {
                        MessageBox.Show("Issue Provisional first", "Check", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        if (l_ono.Text == "")
                        {
                            MessageBox.Show("Orignal not yet recieved", "Not yet recieved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            if (l_oriiss.Text != "")
                            {
                                MessageBox.Show("Already issued", "Issued", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            else
                            {
                                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                                con.Open();
                                string q = "update cer_detail set ori_iss_date='" + DateTime.Now + "' where Reg_no='" + txt_reg_search.Text + "'";
                                cmd = new SqlCommand(q, con);
                                cmd.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Issued Sucessfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                        }
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
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel Files(2003)|*.xls|Excel Files(2007)|*.xlsx|Excel Files(2013)|*.xlsx";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);
                ExcelApp.Columns.ColumnWidth = 20;
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    ExcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();

                    }
                }
                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();
            }
        }

        private void b_close_Click(object sender, EventArgs e)
        {

            l_reg.Text = "";
            l_name.Text = "";
            l_branch.Text = "";
            l_roll.Text = "";
            l_batch.Text = "";
            l_pno.Text = "";
            l_proiss.Text = "";
            l_ono.Text = "";
            l_oriiss.Text = "";
            txt_reg_search.Focus();
            a = 1;
            c_branch_search.SelectedIndex = -1;
            c_batch.SelectedIndex = -1;
            a = 0;
            txt_reg_search.Text = "";
            work();
        }

        private void c_branch_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (c_batch.SelectedIndex == -1 && a != 1)
                {
                    ds.Clear();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                    con.Open();
                    string q1 = "select Reg_no as Registration_no,name as Name,branch,batch,pro_no as Provisional_no,pro_iss_date as Provisional_Issuedate,ori_no as Orignal_cerno,ori_iss_date as Orignal_Issuedate from cer_detail where Branch='" + c_branch_search.SelectedItem.ToString() + "'";
                    sda = new SqlDataAdapter(q1, con);
                    sda.Fill(ds, "t1");

                    dataGridView1.DataSource = ds.Tables[0];


                    con.Close();
                }
                else if (c_branch_search.SelectedIndex != -1)
                {
                    ds.Clear();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                    con.Open();
                    string q1 = "select Reg_no as Registration_no,name as Name,branch,batch,pro_no as Provisional_no,pro_iss_date as Provisional_Issuedate,ori_no as Orignal_cerno,ori_iss_date as Orignal_Issuedate from cer_detail where Branch='" + c_branch_search.SelectedItem.ToString() + "' and Batch ='" + c_batch.SelectedItem.ToString() + "'";
                    sda = new SqlDataAdapter(q1, con);
                    sda.Fill(ds, "t1");

                    dataGridView1.DataSource = ds.Tables[0];


                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void c_batch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (c_branch_search.SelectedIndex == -1 && a != 1)
                {
                    ds.Clear();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                    con.Open();
                    string q1 = "select Reg_no as Registration_no,name as Name,branch,batch,pro_no as Provisional_no,pro_iss_date as Provisional_Issuedate,ori_no as Orignal_cerno,ori_iss_date as Orignal_Issuedate from cer_detail where Branch='" + c_batch.SelectedItem.ToString() + "'";
                    sda = new SqlDataAdapter(q1, con);
                    sda.Fill(ds, "t1");

                    dataGridView1.DataSource = ds.Tables[0];


                    con.Close();
                }
                else if (c_batch.SelectedIndex != -1)
                {
                    ds.Clear();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                    con.Open();
                    string q1 = "select Reg_no as Registration_no,name as Name,branch,batch,pro_no as Provisional_no,pro_iss_date as Provisional_Issuedate,ori_no as Orignal_cerno,ori_iss_date as Orignal_Issuedate from cer_detail where Branch='" + c_branch_search.SelectedItem.ToString() + "' and Batch ='" + c_batch.SelectedItem.ToString() + "'";
                    sda = new SqlDataAdapter(q1, con);
                    sda.Fill(ds, "t1");

                    dataGridView1.DataSource = ds.Tables[0];


                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void b_search_Click(object sender, EventArgs e)
        {
            try
            {
                c_branch_search.SelectedIndex = -1;
                c_batch.SelectedIndex = -1;
                ds1.Clear();
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                string q1 = "select * from cer_detail where Reg_no ='" + txt_reg_search.Text + "'";
                sda = new SqlDataAdapter(q1, con);
                sda.Fill(ds1, "t1");
                //dataGridView1.DataSource = ds.Tables[0];
                int p4 = ds1.Tables["t1"].Rows.Count;
                con.Close();
                if (p4 == 0)
                {
                    MessageBox.Show("No such Student exists or Student had not passed out yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    if (ds1.Tables["t1"].Rows[0][2].ToString() == "")
                    {
                        string pno = Microsoft.VisualBasic.Interaction.InputBox("Provisional yet not recieved\n\n\nLeft it blank and press OK if not yet recieved", "Enter Provisional certificate no");

                        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                        con.Open();
                        string q = "update cer_detail set pro_no='" + pno + "' where Reg_no='" + txt_reg_search.Text + "'";
                        cmd = new SqlCommand(q, con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                    }
                    if (ds1.Tables["t1"].Rows[0][4].ToString() == "")
                    {
                        string pno = Microsoft.VisualBasic.Interaction.InputBox("Orignal yet not recieved\n\n\nLeft it blank and press OK if not yet recieved", "Enter Orignal certificate no");

                        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                        con.Open();
                        string q = "update cer_detail set ori_no='" + pno + "' where Reg_no='" + txt_reg_search.Text + "'";
                        cmd = new SqlCommand(q, con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                    }


                    dataGridView1.DataSource = ds1.Tables[0];
                    ds2.Clear();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                    con.Open();
                    string q4 = "select * from std_detail where Regd_no ='" + txt_reg_search.Text + "'";
                    sda = new SqlDataAdapter(q4, con);
                    sda.Fill(ds2, "t1");
                    int p5 = ds1.Tables["t1"].Rows.Count;
                    l_reg.Text = ds2.Tables["t1"].Rows[0][0].ToString();
                    l_name.Text = ds2.Tables["t1"].Rows[0][2].ToString();
                    l_branch.Text = ds2.Tables["t1"].Rows[0][1].ToString();
                    l_roll.Text = ds2.Tables["t1"].Rows[0][3].ToString();
                    l_batch.Text = ds2.Tables["t1"].Rows[0][5].ToString();
                    l_pno.Text = ds1.Tables["t1"].Rows[0][2].ToString();
                    l_proiss.Text = ds1.Tables["t1"].Rows[0][3].ToString();
                    l_ono.Text = ds1.Tables["t1"].Rows[0][4].ToString();
                    l_oriiss.Text = ds1.Tables["t1"].Rows[0][5].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (d == 0)
            {
                int r = e.RowIndex;
                string p = dataGridView1.Rows[r].Cells[0].Value.ToString();

                try
                {
                    c_branch_search.SelectedIndex = -1;
                    c_batch.SelectedIndex = -1;
                    ds1.Clear();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                    con.Open();
                    string q1 = "select * from cer_detail where Reg_no ='" + p + "'";
                    sda = new SqlDataAdapter(q1, con);
                    sda.Fill(ds1, "t1");
                    //dataGridView1.DataSource = ds.Tables[0];
                    int p4 = ds1.Tables["t1"].Rows.Count;
                    con.Close();
                    if (p4 == 0)
                    {
                        MessageBox.Show("No such Student exists or Student had not passed out yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        if (ds1.Tables["t1"].Rows[0][2].ToString() == "")
                        {
                            string pno = Microsoft.VisualBasic.Interaction.InputBox("Provisional yet not recieved\n\n\nLeft it blank and press OK if not yet recieved", "Enter Provisional certificate no");

                            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                            con.Open();
                            string q = "update cer_detail set pro_no='" + pno + "' where Reg_no='" + p + "'";
                            cmd = new SqlCommand(q, con);
                            cmd.ExecuteNonQuery();
                            con.Close();

                        }
                        if (ds1.Tables["t1"].Rows[0][4].ToString() == "")
                        {
                            string pno = Microsoft.VisualBasic.Interaction.InputBox("Orignal yet not recieved\n\n\nLeft it blank and press OK if not yet recieved", "Enter Orignal certificate no");

                            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                            con.Open();
                            string q = "update cer_detail set ori_no='" + pno + "' where Reg_no='" + p + "'";
                            cmd = new SqlCommand(q, con);
                            cmd.ExecuteNonQuery();
                            con.Close();

                        }


                        dataGridView1.DataSource = ds1.Tables[0];
                        ds2.Clear();
                        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                        con.Open();
                        string q4 = "select * from std_detail where Regd_no ='" +p + "'";
                        sda = new SqlDataAdapter(q4, con);
                        sda.Fill(ds2, "t1");
                        int p5 = ds1.Tables["t1"].Rows.Count;
                        l_reg.Text = ds2.Tables["t1"].Rows[0][0].ToString();
                        l_name.Text = ds2.Tables["t1"].Rows[0][2].ToString();
                        l_branch.Text = ds2.Tables["t1"].Rows[0][1].ToString();
                        l_roll.Text = ds2.Tables["t1"].Rows[0][3].ToString();
                        l_batch.Text = ds2.Tables["t1"].Rows[0][5].ToString();
                        l_pno.Text = ds1.Tables["t1"].Rows[0][2].ToString();
                        l_proiss.Text = ds1.Tables["t1"].Rows[0][3].ToString();
                        l_ono.Text = ds1.Tables["t1"].Rows[0][4].ToString();
                        l_oriiss.Text = ds1.Tables["t1"].Rows[0][5].ToString();
                        txt_reg_search.Text = p;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Some error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            
        }

        private void b_enableedit_Click(object sender, EventArgs e)
        {
            d = 1;
            b_disable.Visible = true;
            b_enableedit.Visible = false;


        }

        private void b_disable_Click(object sender, EventArgs e)
        {
            d = 0;
            b_disable.Visible = false;
            b_enableedit.Visible = true;

        }

        private void txt_reg_search_TextChanged(object sender, EventArgs e)
        {
            string s12 = txt_reg_search.Text, k = "";
            int r;
            if (!int.TryParse(s12, out  r))
            {
                // MessageBox.Show("Wrong format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                for (int i = 0; i < s12.Length - 1; i++)
                {
                    k = k + s12[i];
                }
                txt_reg_search.Text = k;
                //   txt_reg.Focus();
            }
            else if (s12.Length > 10)
            {
                MessageBox.Show("Registration no. cannot exceed 10 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                for (int i = 0; i < s12.Length - 1; i++)
                {
                    k = k + s12[i];
                }
                txt_reg_search.Text = k;
                txt_reg_search.Focus();
            }

            if (Regex.IsMatch(txt_reg_search.Text, @"^[\sa-zA-Z0-9]*$")) return;
            {
                MessageBox.Show("Special characters are not allowed.");
                txt_reg_search.Text = String.Empty;
            } 
        }
    }
}