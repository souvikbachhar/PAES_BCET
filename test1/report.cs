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
    public partial class report : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter sda;
        DataSet ds = new DataSet(); DataSet ds5 = new DataSet(); DataSet ds1 = new DataSet();
        SqlCommandBuilder scb;
        BindingSource bsource = new BindingSource();
        public report()
        {
            InitializeComponent();
        }
        public void fill()
        {
            try
            {

                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                con.Open();
                string q1 = "select * from Reg_detail";
                sda = new SqlDataAdapter(q1, con);
                sda.Fill(ds, "t1");

                dataGridView1.DataSource = ds.Tables[0];

                int p2 = ds.Tables["t1"].Rows.Count;

                for (int i = 0; i < p2; i++)
                {
                    if (ds.Tables["t1"].Rows[i][3].ToString() == "N")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                    }
                    if (ds.Tables["t1"].Rows[i][3].ToString() == "S")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            home fr = new home();
            fr.Show();
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
                if (dataGridView1.Visible == true)
                {
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
                }
                if (dataGridView2.Visible == true)
                {
                    for (int i = 1; i < dataGridView2.Columns.Count +1 ; i++)
                    {
                        ExcelApp.Cells[1, i] = dataGridView2.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView2.Columns.Count; j++)
                        {
                            ExcelApp.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value.ToString();

                        }
                    }
                }
                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();
            }
        }

        private void b_search_Click(object sender, EventArgs e)
        {
            b_sub_update.Visible = false;
            b_update.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            c_session.SelectedIndex = 0;
            try
            {
                if (c_sem_search.SelectedIndex == -1 && c_branch_search.SelectedIndex== -1)
                {
                    
                    ds.Clear();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");

                    
                    con.Open();
                    string q1 = "select * from Reg_detail where batch='" + c_batch.SelectedItem.ToString() + "'";
                    sda = new SqlDataAdapter(q1, con);
                    sda.Fill(ds, "t1");
                    dataGridView1.DataSource = ds.Tables[0];


                    con.Close();
                    b_close.Visible = true;
                    int c = ds.Tables["t1"].Rows.Count;
                    txt_reg_search.Text = "";
                   
                    double total = 0, f = 0;
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() =="")
                        {
                        }
                        else
                        {
                            total = total + Convert.ToDouble(ds.Tables["t1"].Rows[i][8].ToString());
                        }

                    }
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() =="")
                        {
                        }
                        else
                        {
                            f = f + Convert.ToDouble(ds.Tables["t1"].Rows[i][6].ToString());
                        }
                        


                    }
                    txt_tot.Text = total.ToString(); txt_fine.Text = f.ToString();
                    int p2 = ds.Tables["t1"].Rows.Count;

                    for (int i = 0; i < p2; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][3].ToString() == "N")
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                        }
                        if (ds.Tables["t1"].Rows[i][3].ToString() == "S")
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                }
                else
                {
                    ds.Clear();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                    con.Open();
                    string q1 = "select * from Reg_detail where Semester='" + c_sem_search.SelectedItem.ToString() + "' and Branch='" + c_branch_search.SelectedItem.ToString() + "'and batch='" + c_batch.SelectedItem.ToString() + "'";
                    sda = new SqlDataAdapter(q1, con);
                    sda.Fill(ds, "t1");
                    dataGridView1.DataSource = ds.Tables[0];


                    con.Close();
                    b_close.Visible = true;
                    int c = ds.Tables["t1"].Rows.Count;
                    txt_reg_search.Text = "";

                    double total = 0, f = 0;
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                        {
                        }
                        else
                        {
                            total = total + Convert.ToDouble(ds.Tables["t1"].Rows[i][8].ToString());
                        }

                    }
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                        {
                        }
                        else
                        {
                            f = f + Convert.ToDouble(ds.Tables["t1"].Rows[i][6].ToString());
                        }



                    }
                    txt_tot.Text = total.ToString(); txt_fine.Text = f.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Select a option", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            c_session.SelectedIndex = -1;

            b_sub_update.Visible = false;
            b_update.Visible = true;
            c_batch.SelectedIndex = -1;
        }

        private void txt_reg_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            b_sub_update.Visible = false;
            b_update.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;

            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    c_branch_search.SelectedIndex = -1;
                    c_sem_search.SelectedIndex = -1;
                    c_batch.SelectedIndex = -1;
                    ds.Clear();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                    con.Open();
                    string q1 = "select * from Reg_detail where Reg_no like '%" + txt_reg_search.Text + "%'";
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
        }

        private void report_Load(object sender, EventArgs e)
        {
            try
            {
                b_sub_update.Visible = false;
                b_update.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = false; c_branch_search.SelectedIndex = -1;
                c_sem_search.SelectedIndex = -1;

                dataGridView2.Visible = false;
                dataGridView1.Visible = true;
                toolTip1 = new ToolTip();
                toolTip1.ShowAlways = true;
                toolTip1.SetToolTip(this.txt_reg_search, "After entering Registration no.Press Enter");
                // toolTip1.SetToolTip(this.dateTimePicker2,"Select 1 day ahead");
                ds.Clear();
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                con.Open();
                string q1 = "select * from Reg_detail";
                sda = new SqlDataAdapter(q1, con);
                sda.Fill(ds, "t1");

                dataGridView1.DataSource = ds.Tables[0];

                int p2 = ds.Tables["t1"].Rows.Count;

                for (int i = 0; i < p2; i++)
                {
                    if (ds.Tables["t1"].Rows[i][3].ToString() == "N")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                    }
                }

                con.Close();
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                con.Open();
                string q2 = "select distinct session from Reg_detail";
                sda = new SqlDataAdapter(q2, con);
                sda.Fill(ds, "dis");
                con.Close();
                int p3 = ds.Tables["dis"].Rows.Count;

                for (int i = 0; i < p3; i++)
                {
                    string dis = ds.Tables["dis"].Rows[i][0].ToString();
                    c_session.Items.Add(dis);


                }
                con.Close();
                con.Open();
                string q3 = "select distinct batch from Reg_detail";
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
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void c_sem_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                b_sub_update.Visible = false;
                b_update.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
                int d = 0;
                if (c_sem_search.SelectedIndex != -1)
                {
                    d = 1;
                }

                if (c_sem_search.SelectedIndex != -1 && c_branch_search.SelectedIndex != -1)
                {
                    d = 2;

                }

                if (c_sem_search.SelectedIndex != -1 && c_batch.SelectedIndex != -1)
                {
                    d = 4;

                }
                if (c_sem_search.SelectedIndex != -1 && c_branch_search.SelectedIndex != -1 && c_batch.SelectedIndex != -1)
                {
                    d = 3;
                }
                if (d == 1)
                {
                    ds.Clear();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                    con.Open();
                    string q1 = "select * from Reg_detail where Semester='" + c_sem_search.SelectedItem.ToString() + "'";
                    sda = new SqlDataAdapter(q1, con);
                    sda.Fill(ds, "t1");
                    dataGridView1.DataSource = ds.Tables[0];
                    con.Close();
                    b_close.Visible = true;
                    int c = ds.Tables["t1"].Rows.Count;
                    double total = 0, f = 0;
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                        {
                        }
                        else
                        {
                            total = total + Convert.ToDouble(ds.Tables["t1"].Rows[i][8].ToString());
                        }

                    }
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                        {
                        }
                        else
                        {
                            f = f + Convert.ToDouble(ds.Tables["t1"].Rows[i][6].ToString());
                        }



                    }
                    txt_reg_search.Text = ""; txt_tot.Text = total.ToString(); txt_fine.Text = f.ToString();
                }
                else if (d == 2)
                {
                    ds.Clear();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                    con.Open();
                    string q1 = "select * from Reg_detail where Semester='" + c_sem_search.SelectedItem.ToString() + "' and batch='" + c_batch.SelectedItem.ToString() + "'";
                    sda = new SqlDataAdapter(q1, con);
                    sda.Fill(ds, "t1");
                    dataGridView1.DataSource = ds.Tables[0];


                    con.Close();
                    b_close.Visible = true;
                    int c = ds.Tables["t1"].Rows.Count;
                    double total = 0, f = 0;
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                        {
                        }
                        else
                        {
                            total = total + Convert.ToDouble(ds.Tables["t1"].Rows[i][8].ToString());
                        }

                    }
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                        {
                        }
                        else
                        {
                            f = f + Convert.ToDouble(ds.Tables["t1"].Rows[i][6].ToString());
                        }



                    }
                    txt_reg_search.Text = ""; txt_tot.Text = total.ToString(); txt_fine.Text = f.ToString();
                }
                else if (d == 4)
                {
                    ds.Clear();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                    con.Open();
                    string q1 = "select * from Reg_detail where Semester='" + c_sem_search.SelectedItem.ToString() + "' and Branch='" + c_branch_search.SelectedItem.ToString() + "'";
                    sda = new SqlDataAdapter(q1, con);
                    sda.Fill(ds, "t1");
                    dataGridView1.DataSource = ds.Tables[0];

                    int c = ds.Tables["t1"].Rows.Count;
                    double total = 0, f = 0;
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                        {
                        }
                        else
                        {
                            total = total + Convert.ToDouble(ds.Tables["t1"].Rows[i][8].ToString());
                        }

                    }
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                        {
                        }
                        else
                        {
                            f = f + Convert.ToDouble(ds.Tables["t1"].Rows[i][6].ToString());
                        }



                    }
                    con.Close();
                    b_close.Visible = true;

                    txt_reg_search.Text = ""; txt_tot.Text = total.ToString(); txt_fine.Text = f.ToString();
                }
                else if (d == 3)
                {
                    ds.Clear();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                    con.Open();
                    string q1 = "select * from Reg_detail where Semester='" + c_sem_search.SelectedItem.ToString() + "' and Branch='" + c_branch_search.SelectedItem.ToString() + "' and batch ='" + c_batch.SelectedItem.ToString() + "'";
                    sda = new SqlDataAdapter(q1, con);
                    sda.Fill(ds, "t1");
                    dataGridView1.DataSource = ds.Tables[0];
                    int g = ds.Tables["t"].Rows.Count;
                    int c = ds.Tables["t1"].Rows.Count;
                    double total = 0, f = 0;
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                        {
                        }
                        else
                        {
                            total = total + Convert.ToDouble(ds.Tables["t1"].Rows[i][8].ToString());
                        }

                    }
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                        {
                        }
                        else
                        {
                            f = f + Convert.ToDouble(ds.Tables["t1"].Rows[i][6].ToString());
                        }



                    }
                    con.Close();
                    b_close.Visible = true;

                    txt_reg_search.Text = ""; txt_tot.Text = total.ToString(); txt_fine.Text = f.ToString();
                }
                int p2 = ds.Tables["t1"].Rows.Count;

                for (int i = 0; i < p2; i++)
                {
                    if (ds.Tables["t1"].Rows[i][3].ToString() == "N")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                    }
                    if (ds.Tables["t1"].Rows[i][3].ToString() == "S")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void c_branch_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                b_sub_update.Visible = false;
                b_update.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
                int d = 0;
                if (c_branch_search.SelectedIndex != -1)
                {
                    d = 1;
                }
                if (c_sem_search.SelectedIndex != -1 && c_branch_search.SelectedIndex != -1)
                {
                    d = 2;

                }
                if (c_batch.SelectedIndex != -1 && c_branch_search.SelectedIndex != -1)
                {
                    d = 4;

                }
                if (c_sem_search.SelectedIndex != -1 && c_branch_search.SelectedIndex != -1 && c_batch.SelectedIndex != -1)
                {
                    d = 3;

                }
                if (d == 1)
                {

                    ds.Clear();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                    con.Open();
                    string q1 = "select * from Reg_detail where Branch='" + c_branch_search.SelectedItem.ToString() + "'";
                    sda = new SqlDataAdapter(q1, con);
                    sda.Fill(ds, "t1");
                    dataGridView1.DataSource = ds.Tables[0];

                    int c = ds.Tables["t1"].Rows.Count;
                    double total = 0, f = 0;
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                        {
                        }
                        else
                        {
                            total = total + Convert.ToDouble(ds.Tables["t1"].Rows[i][8].ToString());
                        }

                    }
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                        {
                        }
                        else
                        {
                            f = f + Convert.ToDouble(ds.Tables["t1"].Rows[i][6].ToString());
                        }



                    }
                    con.Close();
                    b_close.Visible = true;

                    txt_reg_search.Text = ""; txt_tot.Text = total.ToString(); txt_fine.Text = f.ToString();
                }
                else if (d == 2)
                {
                    ds.Clear();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                    con.Open();
                    string q1 = "select * from Reg_detail where Semester='" + c_sem_search.SelectedItem.ToString() + "' and Branch='" + c_branch_search.SelectedItem.ToString() + "'";
                    sda = new SqlDataAdapter(q1, con);
                    sda.Fill(ds, "t1");
                    dataGridView1.DataSource = ds.Tables[0];
                    int c = ds.Tables["t1"].Rows.Count;
                    double total = 0, f = 0;
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                        {
                        }
                        else
                        {
                            total = total + Convert.ToDouble(ds.Tables["t1"].Rows[i][8].ToString());
                        }

                    }
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                        {
                        }
                        else
                        {
                            f = f + Convert.ToDouble(ds.Tables["t1"].Rows[i][6].ToString());
                        }



                    }

                    con.Close();
                    b_close.Visible = true;

                    txt_reg_search.Text = ""; txt_tot.Text = total.ToString(); txt_fine.Text = f.ToString();
                }
                else if (d == 4)
                {
                    ds.Clear();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                    con.Open();
                    string q1 = "select * from Reg_detail where batch='" + c_batch.SelectedItem.ToString() + "' and Branch='" + c_branch_search.SelectedItem.ToString() + "'";
                    sda = new SqlDataAdapter(q1, con);
                    sda.Fill(ds, "t1");
                    dataGridView1.DataSource = ds.Tables[0];


                    con.Close();
                    b_close.Visible = true;
                    int c = ds.Tables["t1"].Rows.Count;
                    double total = 0, f = 0;
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                        {
                        }
                        else
                        {
                            total = total + Convert.ToDouble(ds.Tables["t1"].Rows[i][8].ToString());
                        }

                    }
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                        {
                        }
                        else
                        {
                            f = f + Convert.ToDouble(ds.Tables["t1"].Rows[i][6].ToString());
                        }



                    }
                   
                    txt_reg_search.Text = ""; txt_tot.Text = total.ToString(); txt_fine.Text = f.ToString();
                }
                else if (d == 3)
                {
                    ds.Clear();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                    con.Open();
                    string q1 = "select * from Reg_detail where Semester='" + c_sem_search.SelectedItem.ToString() + "' and Branch='" + c_branch_search.SelectedItem.ToString() + "' and batch='" + c_batch.SelectedItem.ToString() + "'";
                    sda = new SqlDataAdapter(q1, con);
                    sda.Fill(ds, "t1");
                    dataGridView1.DataSource = ds.Tables[0];

                    int c = ds.Tables["t1"].Rows.Count;
                    double total = 0, f = 0;
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                        {
                        }
                        else
                        {
                            total = total + Convert.ToDouble(ds.Tables["t1"].Rows[i][8].ToString());
                        }

                    }
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                        {
                        }
                        else
                        {
                            f = f + Convert.ToDouble(ds.Tables["t1"].Rows[i][6].ToString());
                        }



                    }
                    con.Close();
                    b_close.Visible = true;

                    txt_reg_search.Text = ""; txt_tot.Text = total.ToString(); txt_fine.Text = f.ToString();
                }
                int p2 = ds.Tables["t1"].Rows.Count;

                for (int i = 0; i < p2; i++)
                {
                    if (ds.Tables["t1"].Rows[i][3].ToString() == "N")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                    }
                    if (ds.Tables["t1"].Rows[i][3].ToString() == "S")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void b_today_Click(object sender, EventArgs e)
        {
            
        }



        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                b_sub_update.Visible = false;
                b_update.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
                label2.Visible = true;
                label3.Visible = true;
                txt_fine.Visible = true;
                txt_tot.Visible = true;
                double total = 0, f = 0;
                string p = monthCalendar1.SelectionStart.Date.ToShortDateString();
                ds.Clear();
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                con.Open();
                string q1 = "select * from Reg_detail where d_t like '%" + p + "%'";
                sda = new SqlDataAdapter(q1, con);
                sda.Fill(ds, "t1");
                dataGridView1.DataSource = ds.Tables[0];
                int c = ds.Tables["t1"].Rows.Count;

                for (int i = 0; i < c; i++)
                {
                    if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                    {
                    }
                    else
                    {
                        total = total + Convert.ToDouble(ds.Tables["t1"].Rows[i][8].ToString());
                    }

                }
                for (int i = 0; i < c; i++)
                {
                    if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                    {
                    }
                    else
                    {
                        f = f + Convert.ToDouble(ds.Tables["t1"].Rows[i][6].ToString());
                    }



                }
                int p2 = ds.Tables["t1"].Rows.Count;

                for (int i = 0; i < p2; i++)
                {
                    if (ds.Tables["t1"].Rows[i][6].ToString() == "500")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
                    }
                    if (ds.Tables["t1"].Rows[i][6].ToString() == "1000")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.Green;
                    }
                }
                con.Close();

                txt_tot.Text = total.ToString(); txt_fine.Text = f.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }


        private void b_amount_search_Click(object sender, EventArgs e)
        {
            try
            {
                b_sub_update.Visible = false;
                b_update.Visible = true;
                dataGridView2.Visible = false;
                dataGridView1.Visible = true;

                double total = 0, f = 0;
                string k = dateTimePicker1.Value.ToShortDateString();
                string p = dateTimePicker2.Value.ToLongDateString();
                ds.Clear();
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                con.Open();
                string q1 = "select * from Reg_detail where d_t between '" + k + "' and'" + p + "'";
                sda = new SqlDataAdapter(q1, con);
                sda.Fill(ds, "t1");
                dataGridView1.DataSource = ds.Tables[0];
                int c = ds.Tables["t1"].Rows.Count;
                for (int i = 0; i < c; i++)
                {
                    if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                    {
                    }
                    else
                    {
                        total = total + Convert.ToDouble(ds.Tables["t1"].Rows[i][8].ToString());
                    }

                }
                for (int i = 0; i < c; i++)
                {
                    if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                    {
                    }
                    else
                    {
                        f = f + Convert.ToDouble(ds.Tables["t1"].Rows[i][6].ToString());
                    }



                }
                txt_tot.Text = total.ToString(); txt_fine.Text = f.ToString();
                int p2 = ds.Tables["t1"].Rows.Count;

                for (int i = 0; i < p2; i++)
                {
                    if (ds.Tables["t1"].Rows[i][6].ToString() == "500")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
                    }
                    if (ds.Tables["t1"].Rows[i][6].ToString() == "1000")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.Green;
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                        int c = ds5.Tables["t"].Rows.Count;
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
                MessageBox.Show("Some error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void txt_reg_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_subjects_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.Visible = true;
                dataGridView1.Visible = false;
                b_update.Visible = false;
                b_sub_update.Visible = true;


                ds.Clear();




                ds1.Clear();
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                string q1 = "select * from sub_detail";
                sda = new SqlDataAdapter(q1, con);
                sda.Fill(ds1, "t1");
                dataGridView2.DataSource = ds1.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void b_sub_update_Click(object sender, EventArgs e)
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
                                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                                con.Open();
                                string q1 = "select * from sub_detail";
                                sda = new SqlDataAdapter(q1, con);
                                sda.Fill(ds1, "t1");

                                dataGridView1.DataSource = ds1.Tables[0];
                                con.Close();
                                scb = new SqlCommandBuilder(sda);
                                sda.Update(ds1, "t1");
                                ds1.Clear();
                                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                                con.Open();
                                string q2 = "select * from sub_detail";
                                sda = new SqlDataAdapter(q2, con);
                                sda.Fill(ds1, "t1");
                                dataGridView1.DataSource = ds1.Tables[0];
                                con.Close();
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
                MessageBox.Show("Some error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void c_session_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                b_sub_update.Visible = false;
                b_update.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
                if (c_session.SelectedIndex != -1)
                {
                    ds.Clear();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                    con.Open();
                    string q1 = "select * from Reg_detail where Session='" + c_session.SelectedItem.ToString() + "'";
                    sda = new SqlDataAdapter(q1, con);
                    sda.Fill(ds, "t1");
                    dataGridView1.DataSource = ds.Tables[0];
                    con.Close();
                    b_close.Visible = true;
                    int c = ds.Tables["t1"].Rows.Count;
                    double total = 0, f = 0;
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                        {
                        }
                        else
                        {
                            total = total + Convert.ToDouble(ds.Tables["t1"].Rows[i][8].ToString());
                        }

                    }
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                        {
                        }
                        else
                        {
                            f = f + Convert.ToDouble(ds.Tables["t1"].Rows[i][6].ToString());
                        }



                    }
                    int p2 = ds.Tables["t1"].Rows.Count;

                    for (int i = 0; i < p2; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][3].ToString() == "N")
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                        }
                        if (ds.Tables["t1"].Rows[i][3].ToString() == "S")
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                    txt_reg_search.Text = "";
                    c_batch.SelectedIndex = -1;
                    c_sem_search.SelectedIndex = -1;
                    c_branch_search.SelectedIndex = -1;
                    txt_tot.Text = total.ToString(); txt_fine.Text = f.ToString();
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
                b_sub_update.Visible = false;
                b_update.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
                int d = 0;
                if (c_batch.SelectedIndex != -1)
                {
                    d = 1;
                }

                if (c_sem_search.SelectedIndex != -1 && c_batch.SelectedIndex != -1)
                {
                    d = 2;

                }
                if (c_branch_search.SelectedIndex != -1 && c_batch.SelectedIndex != -1)
                {
                    d = 4;

                }

                if (c_sem_search.SelectedIndex != -1 && c_branch_search.SelectedIndex != -1 && c_batch.SelectedIndex != -1)
                {
                    d = 3;
                }
                if (d == 1)
                {
                    ds.Clear();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                    con.Open();
                    string q1 = "select * from Reg_detail where batch='" + c_batch.SelectedItem.ToString() + "'";
                    sda = new SqlDataAdapter(q1, con);
                    sda.Fill(ds, "t1");
                    dataGridView1.DataSource = ds.Tables[0];
                    con.Close();
                    b_close.Visible = true;

                    txt_reg_search.Text = "";
                    int c = ds.Tables["t1"].Rows.Count;
                    double total = 0, f = 0;
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                        {
                        }
                        else
                        {
                            total = total + Convert.ToDouble(ds.Tables["t1"].Rows[i][8].ToString());
                        }

                    }
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                        {
                        }
                        else
                        {
                            f = f + Convert.ToDouble(ds.Tables["t1"].Rows[i][6].ToString());
                        }

                        txt_tot.Text = total.ToString(); txt_fine.Text = f.ToString();

                    }
                }
                else if (d == 2)
                {
                    ds.Clear();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                    con.Open();
                    string q1 = "select * from Reg_detail where Semester='" + c_sem_search.SelectedItem.ToString() + "' and batch='" + c_batch.SelectedItem.ToString() + "'";
                    sda = new SqlDataAdapter(q1, con);
                    sda.Fill(ds, "t1");
                    dataGridView1.DataSource = ds.Tables[0];


                    con.Close();
                    b_close.Visible = true;

                    txt_reg_search.Text = "";
                    int c = ds.Tables["t1"].Rows.Count;
                    double total = 0, f = 0;
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                        {
                        }
                        else
                        {
                            total = total + Convert.ToDouble(ds.Tables["t1"].Rows[i][8].ToString());
                        }

                    }
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                        {
                        }
                        else
                        {
                            f = f + Convert.ToDouble(ds.Tables["t1"].Rows[i][6].ToString());
                        }

                        txt_tot.Text = total.ToString(); txt_fine.Text = f.ToString();

                    }
                }
                else if (d == 4)
                {
                    ds.Clear();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                    con.Open();
                    string q1 = "select * from Reg_detail where Branch='" + c_branch_search.SelectedItem.ToString() + "' and batch='" + c_batch.SelectedItem.ToString() + "'";
                    sda = new SqlDataAdapter(q1, con);
                    sda.Fill(ds, "t1");
                    dataGridView1.DataSource = ds.Tables[0];


                    con.Close();
                    b_close.Visible = true;

                    txt_reg_search.Text = "";
                    int c = ds.Tables["t1"].Rows.Count;
                    double total = 0, f = 0;
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                        {
                        }
                        else
                        {
                            total = total + Convert.ToDouble(ds.Tables["t1"].Rows[i][8].ToString());
                        }

                    }
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                        {
                        }
                        else
                        {
                            f = f + Convert.ToDouble(ds.Tables["t1"].Rows[i][6].ToString());
                        }

                        txt_tot.Text = total.ToString(); txt_fine.Text = f.ToString();

                    }
                }
                else if (d == 3)
                {
                    ds.Clear();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                    con.Open();
                    string q1 = "select * from Reg_detail where Semester='" + c_sem_search.SelectedItem.ToString() + "' and Branch='" + c_branch_search.SelectedItem.ToString() + "' and batch ='" + c_batch.SelectedItem.ToString() + "'";
                    sda = new SqlDataAdapter(q1, con);
                    sda.Fill(ds, "t1");
                    dataGridView1.DataSource = ds.Tables[0];


                    con.Close();
                    b_close.Visible = true;

                    txt_reg_search.Text = "";
                    int c = ds.Tables["t1"].Rows.Count;
                    double total = 0, f = 0;
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                        {
                        }
                        else
                        {
                            total = total + Convert.ToDouble(ds.Tables["t1"].Rows[i][8].ToString());
                        }

                    }
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                        {
                        }
                        else
                        {
                            f = f + Convert.ToDouble(ds.Tables["t1"].Rows[i][6].ToString());
                        }


                        txt_tot.Text = total.ToString(); txt_fine.Text = f.ToString();
                    }
                }
                else if (d == 2)
                {
                    ds.Clear();
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");


                    con.Open();
                    string q1 = "select * from Reg_detail where Semester='" + c_sem_search.SelectedItem.ToString() + "' and batch='" + c_batch.SelectedItem.ToString() + "'";
                    sda = new SqlDataAdapter(q1, con);
                    sda.Fill(ds, "t1");
                    dataGridView1.DataSource = ds.Tables[0];


                    con.Close();
                    b_close.Visible = true;

                    txt_reg_search.Text = "";
                    int c = ds.Tables["t1"].Rows.Count;
                    double total = 0, f = 0;
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                        {
                        }
                        else
                        {
                            total = total + Convert.ToDouble(ds.Tables["t1"].Rows[i][8].ToString());
                        }

                    }
                    for (int i = 0; i < c; i++)
                    {
                        if (ds.Tables["t1"].Rows[i][8].ToString() == "")
                        {
                        }
                        else
                        {
                            f = f + Convert.ToDouble(ds.Tables["t1"].Rows[i][6].ToString());
                        }
                        txt_tot.Text = total.ToString(); txt_fine.Text = f.ToString();


                    }
                }
                int p2 = ds.Tables["t1"].Rows.Count;

                for (int i = 0; i < p2; i++)
                {
                    if (ds.Tables["t1"].Rows[i][3].ToString() == "N")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                    }
                    if (ds.Tables["t1"].Rows[i][3].ToString() == "S")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void txt_fine_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_tot_TextChanged(object sender, EventArgs e)
        {
            if (txt_tot.Text != "" && txt_fine.Text != "")
            {
                double tot = Convert.ToDouble(txt_tot.Text);
                double fine = Convert.ToDouble(txt_fine.Text);
                int k = 0;
                k = Convert.ToInt32(tot) - Convert.ToInt32(fine);
                k = k / 1500;
                txt_reg_studs.Text = k.ToString();

            }
        }

        private void report_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are You Sure", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Application.Exit();
                report a = new report();
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