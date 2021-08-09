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
    public partial class add_stud_singl : Form
    { 
        static int c = 0,del=0;
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter sda;
        DataSet ds = new DataSet(); DataSet ds5 = new DataSet();
        SqlCommandBuilder scb;
        BindingSource bsource = new BindingSource();

        public add_stud_singl()
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
            addstud_details fr =new addstud_details();
            fr.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            txt_batch.Text = "";
            txt_name.Text = "";
            txt_reg.Text = "";
            txt_roll.Text = "";
           
        }
        public void mmm()
        {
            try
            {
                c_branch_search.SelectedIndex = -1;
                c_sem_search.SelectedIndex = -1;
                txt_name_search.Text = "";
                txt_batch_search.Text = "";
                ds.Clear();
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                con.Open();
                string q1 = "select Regd_no as Registration_no,Branch,name as Name,roll_no as Roll_no,sem as Semester,batch as Batch from std_detail where Regd_no like '%" + txt_reg_search.Text + "%'";
                sda = new SqlDataAdapter(q1, con);
                sda.Fill(ds, "t1");
                dataGridView1.DataSource = ds.Tables[0];

                con.Close();
                b_close.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void b_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_reg.Text == "" || txt_batch.Text == "" || txt_name.Text == "" || txt_roll.Text == "")
                {
                    MessageBox.Show("Please fill up all the details", "Check", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    string s = "select Regd_no as Registration_no,Branch,name as Name,roll_no as Roll_no,sem as Semester,batch as Batch from std_detail where Regd_no='" + txt_reg.Text + "'";
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                    con.Open();
                    sda = new SqlDataAdapter(s, con);
                    sda.Fill(ds, "t");
                    int g = ds.Tables["t"].Rows.Count;
                    con.Close();
                    if (g == 0)
                    {
                        try
                        {
                            ds.Clear();
                            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                            con.Open();
                            string q = "insert into std_detail values('" + txt_reg.Text + "','" + c_branch.SelectedItem.ToString() + "','" + txt_name.Text + "','" + txt_roll.Text + "','" + c_sem.SelectedItem.ToString() + "','" + txt_batch.Text + "','N')";
                            cmd = new SqlCommand(q, con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            c++;
                            txt_batch.Text = "";
                            txt_name.Text = "";
                            txt_reg.Text = "";
                            txt_roll.Text = "";
                            c_branch.SelectedIndex = -1;
                            c_sem.SelectedIndex = -1;
                            MessageBox.Show("Done", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            fill();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("All fields not filed", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Record already Exists", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void fill()
        {
            try
            {
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                con.Open();
                string q1 = "select Regd_no as Registration_no,Branch,name as Name,roll_no as Roll_no,sem as Semester,batch as Batch from std_detail";
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
        private void add_stud_singl_Load(object sender, EventArgs e)
        {
            
            fill();
            foreach (DataGridViewColumn dcol in dataGridView1.Columns)
            {   DataGridViewColumn coloumn0 = dataGridView1.Columns[0];
                coloumn0.Width = 150;
                DataGridViewColumn coloumn1 = dataGridView1.Columns[1];
                coloumn1.Width = 250;
                DataGridViewColumn coloumn2 = dataGridView1.Columns[2];
                coloumn2.Width = 250;
                DataGridViewColumn coloumn3 = dataGridView1.Columns[3];
                coloumn3.Width = 150;
                DataGridViewColumn coloumn4 = dataGridView1.Columns[4];
                coloumn4.Width = 150;
                DataGridViewColumn coloumn5 = dataGridView1.Columns[5];
                coloumn5.Width = 120;

                //dcol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.txt_reg_search, "After entering Registration no.Press Enter");
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show("Are You Sure", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (MessageBox.Show("Are You Sure", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
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
                        c = ds5.Tables["t"].Rows.Count;
                        if (c == 0)
                        {
                            MessageBox.Show("User does not Exist", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            if (pass == ds5.Tables["t"].Rows[0][1].ToString())
                            {
                                fill();
                                scb = new SqlCommandBuilder(sda);
                                sda.Update(ds, "t1");

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

       
        private void b_close_Click(object sender, EventArgs e)
        {
            ds.Clear();
            fill();
            b_close.Visible = true;
            c_branch_search.SelectedIndex = -1;
            c_sem_search.SelectedIndex = -1;
            txt_reg_search.Text = "";
            txt_name_search.Text = "";
            txt_batch_search.Text = "";
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Once data deleted data cannot be retrived further", "Are you Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                            c = ds5.Tables["t"].Rows.Count;
                            if (c == 0)
                            {
                                MessageBox.Show("User does not Exist", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            else
                            {
                                if (pass == ds5.Tables["t"].Rows[0][1].ToString())
                                {
                                    foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                                    {
                                        dataGridView1.Rows.RemoveAt(item.Index);
                                        del++;
                                    }
                                    if (del == 0)
                                    {
                                        MessageBox.Show("Please select Entire Row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);

                                    }
                                    del = 0;
                                    fill();
                                    scb = new SqlCommandBuilder(sda);
                                    sda.Update(ds, "t1");

                                }
                                else
                                {
                                    MessageBox.Show("Please try correct password", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                                }
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

        private void b_excel_Click(object sender, EventArgs e)
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

        private void add_stud_singl_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void b_search_dual_Click(object sender, EventArgs e)
        {
            try
            {
                ds.Clear();
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                con.Open();
                string q1 = "select Regd_no as Registration_no,Branch,name as Name,roll_no as Roll_no,sem as Semester,batch as Batch from std_detail where Branch ='" + c_branch_search.SelectedItem.ToString() + "' and sem='" + c_sem_search.SelectedItem.ToString() + "' and batch='" + txt_batch_search.Text + "'";
                sda = new SqlDataAdapter(q1, con);
                sda.Fill(ds, "t1");
                dataGridView1.DataSource = ds.Tables[0];


                con.Close();
                b_close.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void b_newsem_Click(object sender, EventArgs e)
        {

        }

        private void txt_reg_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void c_branch_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_reg_search.Text = "";
            txt_name_search.Text = "";
            //txt_batch_search.Text = "";
            if ((c_sem_search.SelectedIndex == -1)&&(txt_name_search.Text=="")&&(txt_batch_search.Text=="")&&(txt_reg_search.Text==""))
            {
                try
                {
                    ds.Clear();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                    con.Open();
                    string q1 = "select Regd_no as Registration_no,Branch,name as Name,roll_no as Roll_no,sem as Semester,batch as Batch from std_detail where Branch='" + c_branch_search.SelectedItem.ToString() + "'";
                    sda = new SqlDataAdapter(q1, con);
                    sda.Fill(ds, "t1");
                    dataGridView1.DataSource = ds.Tables[0];


                    con.Close();
                    b_close.Visible = true;
                    txt_batch_search.Text = "";
                    txt_reg_search.Text = "";
              
                }
                catch(Exception ex)
                {
                    
                }

            }
            if ((c_sem_search.SelectedIndex != -1) && (txt_name_search.Text == "") && (txt_batch_search.Text == "") && (txt_reg_search.Text == ""))
            {try
                {ds.Clear();
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                con.Open();
                string q1 = "select Regd_no as Registration_no,Branch,name as Name,roll_no as Roll_no,sem as Semester,batch as Batch from std_detail where sem='" + c_sem_search.SelectedItem.ToString() + "' and Branch='" + c_branch_search.SelectedItem.ToString() + "'";
                sda = new SqlDataAdapter(q1, con);
                sda.Fill(ds, "t1");
                dataGridView1.DataSource = ds.Tables[0];


                con.Close();
                b_close.Visible = true;
                txt_batch_search.Text = "";
                txt_reg_search.Text = "";
              
            }
              catch(Exception ex)
                {
                   
                }
            }
            
        }

        private void c_sem_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_reg_search.Text = "";
            txt_name_search.Text = "";
            txt_batch_search.Text = "";
            try
            {
                if ((c_branch_search.SelectedIndex != -1) && (txt_name_search.Text == "") && (txt_batch_search.Text == "") && (txt_reg_search.Text == ""))
                {
                    ds.Clear();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                    con.Open();
                    string q1 = "select Regd_no as Registration_no,Branch,name as Name,roll_no as Roll_no,sem as Semester,batch as Batch from std_detail where sem='" + c_sem_search.SelectedItem.ToString() + "' and Branch='" + c_branch_search.SelectedItem.ToString() + "'";
                    sda = new SqlDataAdapter(q1, con);
                    sda.Fill(ds, "t1");
                    dataGridView1.DataSource = ds.Tables[0];


                    con.Close();
                    b_close.Visible = true;
                 
                    txt_reg_search.Text = "";
              
                }


                if ((c_branch_search.SelectedIndex == -1) && (txt_name_search.Text == "") && (txt_batch_search.Text == "") && (txt_reg_search.Text == ""))
                {
                    ds.Clear();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                    con.Open();
                    string q1 = "select Regd_no as Registration_no,Branch,name as Name,roll_no as Roll_no,sem as Semester,batch as Batch from std_detail where sem='" + c_sem_search.SelectedItem.ToString() + "'";
                    sda = new SqlDataAdapter(q1, con);
                    sda.Fill(ds, "t1");
                    dataGridView1.DataSource = ds.Tables[0];

                    con.Close();
                    b_close.Visible = true;
                 
                    txt_reg_search.Text = "";
              

                }
            }
            catch (Exception ex)
            {
                
            }
        }
        private void b_search_Click(object sender, EventArgs e)
        {
           
             try
            {
           if ((c_branch_search.SelectedIndex == -1) && (txt_name_search.Text == "") && (txt_batch_search.Text == "") && (c_branch_search.SelectedIndex == -1))
            {
                ds.Clear();
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                con.Open();
                string q1 = "select Regd_no as Registration_no,Branch,name as Name,roll_no as Roll_no,sem as Semester,batch as Batch from std_detail where Regd_no='" + txt_reg_search.Text + "'";
                sda = new SqlDataAdapter(q1, con);
                sda.Fill(ds, "t1");
                dataGridView1.DataSource = ds.Tables[0];

                con.Close();
                b_close.Visible = true;
                c_branch_search.SelectedIndex = -1;
                c_sem_search.SelectedIndex = -1;
                txt_reg_search.Text = "";
               

            }
            if ((c_branch_search.SelectedIndex == -1) && (txt_reg_search.Text == "") && (txt_batch_search.Text == "") && (c_branch_search.SelectedIndex == -1))
            {
                ds.Clear();
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                con.Open();
                string q1 = "select Regd_no as Registration_no,Branch,name as Name,roll_no as Roll_no,sem as Semester,batch as Batch from std_detail where name like'%" + txt_name_search.Text + "%'";
                sda = new SqlDataAdapter(q1, con);
                sda.Fill(ds, "t1");
                dataGridView1.DataSource = ds.Tables[0];

                con.Close();
                b_close.Visible = true;
                c_branch_search.SelectedIndex = -1;
                c_sem_search.SelectedIndex = -1;
                txt_reg_search.Text = "";
              

            }
            if ((c_branch_search.SelectedIndex == -1) && (txt_reg_search.Text == "") && (txt_name_search.Text == "") && (c_branch_search.SelectedIndex == -1))
            {
                ds.Clear();
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                con.Open();
                string q1 = "select Regd_no as Registration_no,Branch,name as Name,roll_no as Roll_no,sem as Semester,batch as Batch from std_detail where batch ='" + txt_batch_search.Text + "'";
                sda = new SqlDataAdapter(q1, con);
                sda.Fill(ds, "t1");
                dataGridView1.DataSource = ds.Tables[0];

                con.Close();
                b_close.Visible = true;
                c_branch_search.SelectedIndex = -1;
                c_sem_search.SelectedIndex = -1;
                txt_reg_search.Text = "";
              
            }
            if ((c_branch_search.SelectedIndex == -1) && (txt_reg_search.Text == "") && (txt_name_search.Text != "") && (c_branch_search.SelectedIndex == -1) && (txt_batch_search.Text != ""))
            {
                ds.Clear();
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                con.Open();
                string q1 = "select Regd_no as Registration_no,Branch,name as Name,roll_no as Roll_no,sem as Semester,batch as Batch from std_detail where batch='" + txt_batch_search.Text + "' and name like'%" + txt_name_search.Text + "%'";
                sda = new SqlDataAdapter(q1, con);
                sda.Fill(ds, "t1");
                dataGridView1.DataSource = ds.Tables[0];

                con.Close();
                b_close.Visible = true;
                c_branch_search.SelectedIndex = -1;
                c_sem_search.SelectedIndex = -1;
                txt_reg_search.Text = "";
              
            }
            }
        catch (Exception ex)
        {
                
                MessageBox.Show("Some error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            
        }
        }

        private void txt_reg_search_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txt_reg_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mmm();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int p2 = ds.Tables["t1"].Rows.Count;
            for (int i = 0; i < p2; i++)
            {
                string p1 = ds.Tables["t1"].Rows[i][4].ToString();
                if (p1 == "Semester 8")
                {
                    ds.Tables["t1"].Rows[i][4] = "Semester 7";
                }
                if (p1 == "Passed out")
                {
                    ds.Tables["t1"].Rows[i][4] = "Semester 8";
                }
            }
            scb = new SqlCommandBuilder(sda);
            sda.Update(ds, "t1");
            
        }

       

        

        private void txt_reg_KeyUp_1(object sender, KeyEventArgs e)
        {

        }

        private void txt_reg_TextChanged(object sender, EventArgs e)
        {
          
                string s12 = txt_reg.Text,k="";
                int r;
                if (!int.TryParse(s12, out  r))
                {
                   // MessageBox.Show("Wrong format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                   
                    for (int i = 0; i < s12.Length - 1; i++)
                    {
                        k = k + s12[i];
                    }
                    txt_reg.Text = k;
                 //   txt_reg.Focus();
                }
                else if(s12.Length>10)
                {
                    MessageBox.Show("Registration no. cannot exceed 10 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    for (int i = 0; i < s12.Length - 1; i++)
                    {
                        k = k + s12[i];
                    }
                    txt_reg.Text = k;
                    txt_reg.Focus();
                }

                if (Regex.IsMatch(txt_name.Text, @"^[\sa-zA-Z0-9]*$")) return;
                {
                    MessageBox.Show("Special characters are not allowed.");
                    txt_name.Text = String.Empty;
                } 
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void c_branch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_stud_singl_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are You Sure", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Application.Exit();
                add_stud_singl a = new add_stud_singl();
                a.Close();
            }
            else
            {
                e.Cancel = true;
                //this.Activate();
            }
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

            char[] originalText = txt_name.Text.ToCharArray();
            foreach (char c in originalText)
            {
                if (Char.IsNumber(c))
                {
                    txt_name.Text = txt_name.Text.Remove(txt_name.Text.IndexOf(c));

                }

            }
            //txt_name.Select(txt_name.Text.Length, 0);
            if (Regex.IsMatch(txt_name.Text, @"^[\sa-zA-Z0-9]*$")) return;
            {
                txt_name.Text = String.Empty;
                MessageBox.Show("Special characters are not allowed.");
            } 
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {

        }
        
   
    }
}
