using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks.Printing;
using System.Data.SqlClient;

namespace test1
{
    public partial class assign_subject : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter sda;
        DataSet ds = new DataSet();
        public assign_subject()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            home h = new home();
            h.Show();
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            
            c_sc1.Items.Clear();
            c_sc2.Items.Clear();
            c_sc3.Items.Clear();
            c_sc4.Items.Clear();
            c_sc5.Items.Clear();
            c_sc6.Items.Clear();
            c_sc7.Items.Clear();
            s_code8.Text = "";
            s_code9.Text = "";
            s_code10.Text = "";
            s_code11.Text = "";
            s_name1.Text = "";
            s_name2.Text = "";
            s_name3.Text = "";
            s_name4.Text = "";
            s_name5.Text = "";
            s_name6.Text = "";
            s_name7.Text = "";
            s_name8.Text = "";
            s_name9.Text = "";
            s_name10.Text = "";
            s_name11.Text = "";
            c_branch.SelectedIndex =0;
            c_Sem.SelectedIndex = 0;
           

        }

        private void b_assign_Click(object sender, EventArgs e)
        {

           try
            {
                
                
                    if (MessageBox.Show("Are You Sure", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ds.Clear();
                        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                        con.Open();
                        string q1 = "select * from sub_detail where Branch ='" + c_branch.SelectedItem.ToString() + "' and Semester='"+c_Sem.SelectedItem.ToString()+"'";
                        sda = new SqlDataAdapter(q1, con);
                        sda.Fill(ds, "t1");
                        int c = ds.Tables["t1"].Rows.Count;

                        if (c == 0)
                        {
                            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                            con.Open();
                            string q = "insert into sub_detail values('" + c_branch.SelectedItem.ToString() + "','" + c_Sem.SelectedItem.ToString() + "','" + c_sc1.SelectedItem.ToString() + "','" + s_name1.Text + "','" + c_sc2.SelectedItem.ToString() + "','" + s_name2.Text + "','" + c_sc3.SelectedItem.ToString() + "','" + s_name3.Text + "','" + c_sc4.SelectedItem.ToString() + "','" + s_name4.Text + "','" + c_sc5.SelectedItem.ToString() + "','" + s_name5.Text + "','" + c_sc6.SelectedItem.ToString() + "','" + s_name6.Text + "','" + c_sc7.SelectedItem.ToString() + "','" + s_name7.Text + "','" + s_code8.Text + "','" + s_name8.Text + "','" + s_code9.Text + "','" + s_name9.Text + "','" + s_code10.Text + "','" + s_name10.Text + "','" + s_code11.Text + "','" + s_name11.Text + "')";
                            cmd = new SqlCommand(q, con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Done", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                            c_sc1.Items.Clear();
                            c_sc2.Items.Clear();
                            c_sc3.Items.Clear();
                            c_sc4.Items.Clear();
                            c_sc5.Items.Clear();
                            c_sc6.Items.Clear();
                            c_sc7.Items.Clear();
                            s_code8.Text = "";
                            s_code9.Text = "";
                            s_code10.Text = "";
                            s_code11.Text = "";
                            s_name1.Text = "";
                            s_name2.Text = "";
                            s_name3.Text = "";
                            s_name4.Text = "";
                            s_name5.Text = "";
                            s_name6.Text = "";
                            s_name7.Text = "";
                            s_name8.Text = "";
                            s_name9.Text = "";
                            s_name10.Text = "";
                            s_name11.Text = "";
                            c_branch.SelectedIndex = 0;
                            c_Sem.SelectedIndex = 0;
                           
                        }
                        else
                        {
                            if (MessageBox.Show("Subject details already exists .Want to update", "Update...???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Souvik Bachhar\documents\visual studio 2010\Projects\test1\test1\Database1.mdf;Integrated Security=True;User Instance=True");
                            con.Open();
                            string q = "update sub_detail set sc1='" + c_sc1.SelectedItem.ToString() + "',s1='" + s_name1.Text + "',sc2='" + c_sc2.SelectedItem.ToString() + "',s2='" + s_name2.Text + "',sc3='" + c_sc3.SelectedItem.ToString() + "',s3='" + s_name3.Text + "',sc4='" + c_sc4.SelectedItem.ToString() + "',s4='" + s_name4.Text + "',sc5='" + c_sc5.SelectedItem.ToString() + "',s5='" + s_name5.Text + "',sc6='" + c_sc6.SelectedItem.ToString() + "',s6='" + s_name6.Text + "',sc7='" + c_sc7.SelectedItem.ToString() + "',s7='" + s_name7.Text + "',sc8='" + s_code8.Text + "',s8='" + s_name8.Text + "',sc9='" + s_code9.Text + "',s9='" + s_name9.Text + "',sc10='" + s_code10.Text + "',s10='" + s_name10.Text + "',sc11='" + s_code11.Text + "',s11='" + s_name11.Text + "' where Branch='"+c_branch.SelectedItem.ToString()+"' and Semester='"+c_Sem.SelectedItem.ToString()+"'";
                            cmd = new SqlCommand(q, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Done", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                            c_sc1.Items.Clear();
                            c_sc2.Items.Clear();
                            c_sc3.Items.Clear();
                            c_sc4.Items.Clear();
                            c_sc5.Items.Clear();
                            c_sc6.Items.Clear();
                            c_sc7.Items.Clear();
                            s_code8.Text = "";
                            s_code9.Text = "";
                            s_code10.Text = "";
                            s_code11.Text = "";
                            s_name1.Text = "";
                            s_name2.Text = "";
                            s_name3.Text = "";
                            s_name4.Text = "";
                            s_name5.Text = "";
                            s_name6.Text = "";
                            s_name7.Text = "";
                            s_name8.Text = "";
                            s_name9.Text = "";
                            s_name10.Text = "";
                            s_name11.Text = "";
                            c_branch.SelectedIndex = 0;
                            c_Sem.SelectedIndex = 0;
                           
                            }
                        
                    }
                }
            }
           catch (Exception ex)
           {
               MessageBox.Show("Some Error Occured", "Check", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are You Sure", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (MessageBox.Show("Are You Sure", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void b_print_Click(object sender, EventArgs e)
        {
            var k = new PrintDialog();
            if (k.ShowDialog() == DialogResult.OK)
            {

                printForm1.PrinterSettings = k.PrinterSettings;
                printForm1.PrinterSettings.DefaultPageSettings.Landscape = true;

                printForm1.PrinterSettings.DefaultPageSettings.Margins.Left = 0;
                printForm1.PrinterSettings.DefaultPageSettings.Margins.Top = 0;
                printForm1.PrinterSettings.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("PaperA4", 1000, 1280);
                printForm1.Print(this, PrintForm.PrintOption.CompatibleModeClientAreaOnly);




            }
        }

        private void b_gen_Click(object sender, EventArgs e)
        {
            

            
        }

        private void assign_subject_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void c_sc1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (c_sc1.SelectedItem.ToString() == "HSSM3401")
            {
                s_name1.Text = "Enterpreneurship Development";
            }

            if (c_sc1.SelectedItem.ToString() == "MCC101")
            {
                s_name1.Text = "Programming in C ";
            }
            if (c_sc1.SelectedItem.ToString() == "MGT-101")
            {
                s_name1.Text = "Managing Organisations";
            }
            if (c_sc1.SelectedItem.ToString() == "MGT-201")
            {
                s_name1.Text = "Marketing Management-II";
            }
            if (c_sc1.SelectedItem.ToString() == "MCC201")
            {
                s_name1.Text = "Data Structures Using C ";
            }
            if (c_sc1.SelectedItem.ToString() == "MCC301")
            {
                s_name1.Text = "Analysis and Design of Algorithms";
            }
            if (c_sc1.SelectedItem.ToString() == "MCC401")
            {
                s_name1.Text = "Programming with Java";
            }
            if (c_sc1.SelectedItem.ToString() == "MCC501")
            {
                s_name1.Text = "Artificial Intelligence and Expert system";
            }
            if (c_sc1.SelectedItem.ToString() == "HSSM3402")
            {
                s_name1.Text = "Environmental Engineering";
            }
            if (c_sc1.SelectedItem.ToString() == "HSSM3301")
            {
                s_name1.Text = "Principles of Management";
            }
            if (c_sc1.SelectedItem.ToString() == "HSSM3302")
            {
                s_name1.Text = "Optimization in Engineering";
            }
            if (c_sc1.SelectedItem.ToString() == "BSCM1205")
            {
                s_name1.Text = "Mathematics-III";
            }
            if (c_sc1.SelectedItem.ToString() == "BSCM1211")
            {
                s_name1.Text = "Discrete Mathematics";
            }
            if (c_sc1.SelectedItem.ToString() == "BSCM1205")
            {
                s_name1.Text = "Mathematics – III";
            }
            if (c_sc1.SelectedItem.ToString() == "BSCM1210")
            {
                s_name1.Text = "Mathematics – IV";
            }
            if (c_sc1.SelectedItem.ToString() == "HSSM3303")
            {
                s_name1.Text = "Environmental Engineering & Safety";
            }
            if (c_sc1.SelectedItem.ToString() == "HSSM3301")
            {
                s_name1.Text = "Principles of Management";
            }

            if (c_sc1.SelectedItem.ToString() == "PCCI4401")
            {
                s_name1.Text = "Foundation Engineering";
            }
            if (c_sc1.SelectedItem.ToString() == "PECI5407")
            {
                s_name1.Text = "Structural Dynamics & Earthquake Engineering";
            }
            if (c_sc1.SelectedItem.ToString() == "PECI5408")
            {
                s_name1.Text = "Construction Equipments, Planning & Management";
            }
            if (c_sc1.SelectedItem.ToString() == "PECI5409")
            {
                s_name1.Text = "Water Resources Management";
            }
            if (c_sc1.SelectedItem.ToString() == "PECI5410")
            {
                s_name1.Text = "Traffic Engineering & Transportation Planning";
            }
            if (c_sc1.SelectedItem.ToString() == "PCEC4205")
            {
                s_name1.Text = "Electromagnetic Fields & Waves";
            }
            if (c_sc1.SelectedItem.ToString() == "HSSM3302")
            {
                s_name1.Text = "Optimization in Engineering";
            }
            if (c_sc1.SelectedItem.ToString() == "HSSM3401")
            {
                s_name1.Text = "Entrepreneurship Development";
            }
            if (c_sc1.SelectedItem.ToString() == "PCEE4402")
            {
                s_name1.Text = "Power System Protection";
            }
            if (c_sc1.SelectedItem.ToString() == "BEME2209")
            {
                s_name1.Text = "Fluid Mechanics & Machines";
            }
            if (c_sc1.SelectedItem.ToString() == "PCEC4402")
            {
                s_name1.Text = "Microwave Engineering";
            }
            if (c_sc1.SelectedItem.ToString() == "BEME2209")
            {
                s_name1.Text = "Fluid Mechanics and Machines";
            }
            if (c_sc1.SelectedItem.ToString() == "PEEI5404")
            {
                s_name1.Text = "Analog VLSI Design";
            }
            if (c_sc1.SelectedItem.ToString() == "PECS5406")
            {
                s_name1.Text = "Digital Image Processing";
            }
            if (c_sc1.SelectedItem.ToString() == "PEEI5405")
            {
                s_name1.Text = "Micro-Electro-Mechanical Systems (MEMS)";
            }
            if (c_sc1.SelectedItem.ToString() == "PEEI5406")
            {
                s_name1.Text = "Adaptive Control";
            }
            if (c_sc1.SelectedItem.ToString() == "PCME4301")
            {
                s_name1.Text = "Machine Dynamics";
            }
            if (c_sc1.SelectedItem.ToString() == "HSSM3302")
            {
                s_name1.Text = "Optimization in Engineering";
            }
            if (c_sc1.SelectedItem.ToString() == "PCME4401")
            {
                s_name1.Text = "Product Design and Production Tooling";
            }
            if (c_sc1.SelectedItem.ToString() == "HSSM3402")
            {
                s_name1.Text = "Environmental Engineering";
            }
        }

        private void c_sc2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (c_sc2.SelectedItem.ToString() == "PCCS4401")
            {
                s_name2.Text = "Computer Graphics";
            }
            if (c_sc2.SelectedItem.ToString() == "MCC102")
            {
                s_name2.Text = "Micro-processors and Assembly Language Programming";
            }
            if (c_sc2.SelectedItem.ToString() == "MCC202")
            {
                s_name2.Text = "Computer Organization and System architecture";
            }
            if (c_sc2.SelectedItem.ToString() == "MGT-102")
            {
                s_name2.Text = "Managerial Economics";
            }
            if (c_sc2.SelectedItem.ToString() == "MGT-202")
            {
                s_name2.Text = "Financial Management";
            }
            if (c_sc2.SelectedItem.ToString() == "MCC302")
            {
                s_name2.Text = "Operating Systems";
            }
            if (c_sc2.SelectedItem.ToString() == "MCC402")
            {
                s_name2.Text = "Computer Graphics & Multimedia";
            }
            if (c_sc2.SelectedItem.ToString() == "MCC502")
            {
                s_name2.Text = "Object Oriented Analysis and Design with UML";
            }
            if (c_sc2.SelectedItem.ToString() == "PECS5406")
            {
                s_name2.Text = "Digital Image Processing";
            }
            if (c_sc2.SelectedItem.ToString() == "PECS5407")
            {
                s_name2.Text = "Wireless Sensor Networks";
            }
            if (c_sc2.SelectedItem.ToString() == "PECS5408")
            {
                s_name2.Text = "Embedded System Development";
            }
            if (c_sc2.SelectedItem.ToString() == "PCCS4301")
            {
                s_name2.Text = "Computer Organization";
            }
            if (c_sc2.SelectedItem.ToString() == "PCEL4303")
            {
                s_name2.Text = "Microprocessor & Microcontrollers";
            }
            if (c_sc2.SelectedItem.ToString() == "BEES2211")
            {
                s_name2.Text = "Network Theory";
            }
            if (c_sc2.SelectedItem.ToString() == "PCCS4203")
            {
                s_name2.Text = "System Programming";
            }
            if (c_sc2.SelectedItem.ToString() == "HSSM3204")
            {
                s_name2.Text = "Engineering Economics and Costing";
            }
            if (c_sc2.SelectedItem.ToString() == "HSSM3205")
            {
                s_name2.Text = "Organizational Behavior";
            }
            if (c_sc2.SelectedItem.ToString() == "PCCI4303")
            {
                s_name2.Text = "Advanced Mechanics of Materials";
            }
            if (c_sc2.SelectedItem.ToString() == "PCCI4304")
            {
                s_name2.Text = "Structural Analysis -II";
            }
            if (c_sc2.SelectedItem.ToString() == "PCCI4402")
            {
                s_name2.Text = "Water Supply & Sanitary Engg";
            }
            if (c_sc2.SelectedItem.ToString() == "PECI5411")
            {
                s_name2.Text = "Ground Improvement Technique";
            }
            if (c_sc2.SelectedItem.ToString() == "PECI5412")
            {
                s_name2.Text = "Advanced Foundation Engineering";
            }
            if (c_sc2.SelectedItem.ToString() == "PECI5413")
            {
                s_name2.Text = "Soil Dynamics and Earthquake Engineering";
            }
            if (c_sc2.SelectedItem.ToString() == "PECI5414")
            {
                s_name2.Text = "Soil Structure Interaction";
            }
            if (c_sc2.SelectedItem.ToString() == "BSCP1207")
            {
                s_name2.Text = "Physics of Semiconductor Devices";
            }
            if (c_sc2.SelectedItem.ToString() == "BSMS1213")
            {
                s_name2.Text = "Materials Science & Engineering";
            }
            if (c_sc2.SelectedItem.ToString() == "PCEC4303")
            {
                s_name2.Text = "Control Systems Engineering";
            }
            if (c_sc2.SelectedItem.ToString() == "PCEL4303")
            {
                s_name2.Text = "Microprocessor & Microcontrollers";
            }
            if (c_sc2.SelectedItem.ToString() == "PCEE4401")
            {
                s_name2.Text = "Electrical Power Transmission and Distribution";
            }
            if (c_sc2.SelectedItem.ToString() == "PEEE5410")
            {
                s_name2.Text = "Advanced Power Electronics";
            }
            if (c_sc2.SelectedItem.ToString() == "PEEL5403")
            {
                s_name2.Text = "Electrical Power Quality";
            }
            if (c_sc2.SelectedItem.ToString() == "PEEI5402")
            {
                s_name2.Text = "Optimal Control";
            }
            if (c_sc2.SelectedItem.ToString() == "PCEL4401")
            {
                s_name2.Text = "Power System Operation and Contr";
            }
            if (c_sc2.SelectedItem.ToString() == "PEEI5403")
            {
                s_name2.Text = "Industrial Instrumentation";
            }
            if (c_sc2.SelectedItem.ToString() == "PCEC4304")
            {
                s_name2.Text = "Digital Signal Processing";
            }
            if (c_sc2.SelectedItem.ToString() == "PEEI5404")
            {
                s_name2.Text = "Analog VLSI Design";
            }
            if (c_sc2.SelectedItem.ToString() == "PEEC5405")
            {
                s_name2.Text = "Embedded Systems";
            }
            if (c_sc2.SelectedItem.ToString() == "PECS5406")
            {
                s_name2.Text = "Digital Image Processing";

            }
            if (c_sc2.SelectedItem.ToString() == "PEEC5418")
            {
                s_name2.Text = "Satellite Communication Systems";
            }
            if (c_sc2.SelectedItem.ToString() == "PCEI4301")
            {
                s_name2.Text = "Communication System Engineering";
            }
            if (c_sc2.SelectedItem.ToString() == "PCEI4303")
            {
                s_name2.Text = "Control Systems";
            }
            if (c_sc2.SelectedItem.ToString() == "PCEC4401")
            {
                s_name2.Text = "VLSI Design";
            }
            if (c_sc2.SelectedItem.ToString() == "PEEC5405")
            {
                s_name2.Text = "Embedded Systems";
            }
            if (c_sc2.SelectedItem.ToString() == "PEEI5402")
            {
                s_name2.Text = "Optimal Control";
            }
            if (c_sc2.SelectedItem.ToString() == "PEEI5403")
            {
                s_name2.Text = "Industrial Instrumentation";
            }
            if (c_sc2.SelectedItem.ToString() == "PCME4303")
            {
                s_name2.Text = "Design of Machine Elements";
            }
            if (c_sc2.SelectedItem.ToString() == "PCME4307")
            {
                s_name2.Text = "Advanced Mechanics of Solids";
            }
            if (c_sc2.SelectedItem.ToString() == "PCME4402")
            {
                s_name2.Text = "Refrigeration & Air Conditioning";
            }
            if (c_sc2.SelectedItem.ToString() == "PCME4404")
            {
                s_name2.Text = "Production and Operation Management";
            }
        }

        private void c_sc3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (c_sc3.SelectedItem.ToString() == "PCCS4402")
            {
                s_name3.Text = "Principles and Practices in Software Engineering";
            }
            if (c_sc3.SelectedItem.ToString() == "MCC103")
            {
                s_name3.Text = "Discrete Mathematics ";
            }
            if (c_sc3.SelectedItem.ToString() == "MGT-103")
            {
                s_name3.Text = "Quantitative Techniques";
            }
            if (c_sc3.SelectedItem.ToString() == "MGT-203")
            {
                s_name3.Text = "Human Resource Management";
            }
            if (c_sc3.SelectedItem.ToString() == "MCC203")
            {
                s_name3.Text = "Object orientated Programming using C++";
            }
            if (c_sc3.SelectedItem.ToString() == "MCC303")
            {
                s_name3.Text = "Computer Networks";
            }
            if (c_sc3.SelectedItem.ToString() == "MCC403")
            {
                s_name3.Text = "Software Engineering";
            }
            if (c_sc3.SelectedItem.ToString() == "MCC503")
            {
                s_name3.Text = "Internet Technology and enterprise Java";
            }
            if (c_sc3.SelectedItem.ToString() == "PECS5409")
            {
                s_name3.Text = "Data and Web Mining";
            }
            if (c_sc3.SelectedItem.ToString() == "PECS5410")
            {
                s_name3.Text = "Algorithms for Bio-Informatics";
            }
            if (c_sc3.SelectedItem.ToString() == "PECS5411")
            {
                s_name3.Text = "Parallel & Distributed Systems";
            }
            if (c_sc3.SelectedItem.ToString() == "PCCS4302")
            {
                s_name3.Text = "Data Communication & Computer Network";
            }
            if (c_sc3.SelectedItem.ToString() == "PCCS4304")
            {
                s_name3.Text = "Operating System";
            }
            if (c_sc3.SelectedItem.ToString() == "BSCP1207")
            {
                s_name3.Text = "Physics of Semiconductor Devices";
            }
            if (c_sc3.SelectedItem.ToString() == "PCCS4204")
            {
                s_name3.Text = "Design and Analysis of Algorithm";
            }
            if (c_sc3.SelectedItem.ToString() == "BECS2212")
            {
                s_name3.Text = "C++ & Object Oriented Programming";
            }
            if (c_sc3.SelectedItem.ToString() == "PCCE4204")
            {
                s_name3.Text = "Structural Analysis-1";
            }
            if (c_sc3.SelectedItem.ToString() == "PCCI4302")
            {
                s_name3.Text = "Transportation Engineering- I";
            }
            if (c_sc3.SelectedItem.ToString() == "PCCI4305")
            {
                s_name3.Text = "Irrigation Engineering";
            }
            if (c_sc3.SelectedItem.ToString() == "PECI5401")
            {
                s_name3.Text = "Water Resources Engineering";
            }
            if (c_sc3.SelectedItem.ToString() == "PECI5402")
            {
                s_name3.Text = "Ground Water Hydrology";
            }
            if (c_sc3.SelectedItem.ToString() == "PECI5415")
            {
                s_name3.Text = "Prestressed Concrete";
            }
            if (c_sc3.SelectedItem.ToString() == "PECI5416")
            {
                s_name3.Text = "Finite Element Method of Analysis";
            }
            if (c_sc3.SelectedItem.ToString() == "PECI5417")
            {
                s_name3.Text = "Performance & Evaluation of Pavements";
            }
            if (c_sc3.SelectedItem.ToString() == "PECI5418")
            {
                s_name3.Text = "Town Planning";
            }
            if (c_sc3.SelectedItem.ToString() == "HSSM3204")
            {
                s_name3.Text = "Engineering Economics and Costing";
            }
            if (c_sc3.SelectedItem.ToString() == "HSSM3205")
            {
                s_name3.Text = "Organizational Behavior";
            }
            if (c_sc3.SelectedItem.ToString() == "PCEL4301")
            {
                s_name3.Text = "Power Electronics";
            }
            if (c_sc3.SelectedItem.ToString() == "PCEC4304")
            {
                s_name3.Text = "Digital Signal Processing";
            }
            if (c_sc3.SelectedItem.ToString() == "PEEE5406")
            {
                s_name3.Text = "Soft Computing";
            }
            if (c_sc3.SelectedItem.ToString() == "PEEE5407")
            {
                s_name3.Text = "Industrial Automation & Control";
            }
            if (c_sc3.SelectedItem.ToString() == "PCEC4401")
            {
                s_name3.Text = "VLSI Design";
            }
            if (c_sc3.SelectedItem.ToString() == "PEEE5408")
            {
                s_name3.Text = "High Voltage DC Transmission";
            }
            if (c_sc3.SelectedItem.ToString() == "PEEE5409")
            {
                s_name3.Text = "Flexible AC Transmission System";
            }
            if (c_sc3.SelectedItem.ToString() == "PEEC5418")
            {
                s_name3.Text = "Satelite Communication Systems";
            }
            if (c_sc3.SelectedItem.ToString() == "PECS5406")
            {
                s_name3.Text = "Digital Image Processing";
            }
            if (c_sc3.SelectedItem.ToString() == "PEEI5403")
            {
                s_name3.Text = "Industrial Instrumentation";
            }
            if (c_sc3.SelectedItem.ToString() == "PEEC5405")
            {
                s_name3.Text = "Embedded Systems";
            }
            if (c_sc3.SelectedItem.ToString() == "PCEE4301")
            {
                s_name3.Text = "Transmission and Distribution System";
            }
            if (c_sc3.SelectedItem.ToString() == "PEEL5402")
            {
                s_name3.Text = "Special Electromechanical Devices";
            }
            if (c_sc3.SelectedItem.ToString() == "PEEI5406")
            {
                s_name3.Text = "Adaptive Control";
            }
            if (c_sc3.SelectedItem.ToString() == "BSCP1207")
            {
                s_name3.Text = "Physics of Semiconductor Devices";
            }
            if (c_sc3.SelectedItem.ToString() == "BSMS1213")
            {
                s_name3.Text = "Materials Science & Engineering";
            }
            if (c_sc3.SelectedItem.ToString() == "PCEC4301")
            {
                s_name3.Text = "Microprocessors";
            }
            if (c_sc3.SelectedItem.ToString() == "PCEC4305")
            {
                s_name3.Text = "Digital Communication Techniques";
            }
            if (c_sc3.SelectedItem.ToString() == "PEEC5416")
            {
                s_name3.Text = "Biomedical Instrumentation";
            }
            if (c_sc3.SelectedItem.ToString() == "PEEC5417")
            {
                s_name3.Text = "Digital Switching & Telecom Networks";
            }
            if (c_sc3.SelectedItem.ToString() == "PEEC5414")
            {
                s_name3.Text = "Advance Control Systems";
            }
            if (c_sc3.SelectedItem.ToString() == "PEEL5401")
            {
                s_name3.Text = "Adaptive Signal Processing";
            }
            if (c_sc3.SelectedItem.ToString() == "FECE6404")
            {
                s_name3.Text = "Network Security and Cryptography";
            }
            if (c_sc3.SelectedItem.ToString() == "FECE6405")
            {
                s_name3.Text = "Internet Technology and Applications";
            }
            if (c_sc3.SelectedItem.ToString() == "PEEI5405")
            {
                s_name3.Text = "MEMS";
            }
            if (c_sc3.SelectedItem.ToString() == "PEEI5403")
            {
                s_name3.Text = "Industrial Instrumentation";
            }
            if (c_sc3.SelectedItem.ToString() == "PECS5407")
            {
                s_name3.Text = "Wireless Sensor Networks";
            }
            if (c_sc3.SelectedItem.ToString() == "PCEC4304")
            {
                s_name3.Text = "Digital Signal Processing";
            }
            if (c_sc3.SelectedItem.ToString() == "PEEC5414")
            {
                s_name3.Text = "Advanced Control Systems";
            }
            if (c_sc3.SelectedItem.ToString() == "PEEI5401")
            {
                s_name3.Text = "Microcontroller & Applications";
            }
            if (c_sc3.SelectedItem.ToString() == "PCEC4402")
            {
                s_name3.Text = "Microwave Engineering";
            }
            if (c_sc3.SelectedItem.ToString() == "PEEC5418")
            {
                s_name3.Text = "Satellite Communication Systems";
            }
            if (c_sc3.SelectedItem.ToString() == "PCME4201")
            {
                s_name3.Text = "Fluid Mechanics & Hydraulic Machine";
            }
            if (c_sc3.SelectedItem.ToString() == "PCME4204")
            {
                s_name3.Text = "Kinematics & Dynamics of Machines";
            }
            if (c_sc3.SelectedItem.ToString() == "PCME4304")
            {
                s_name3.Text = "Machining Science & Technology";
            }
            if (c_sc3.SelectedItem.ToString() == "PCME4306")
            {
                s_name3.Text = "Design of Machine Components";
            }
            if (c_sc3.SelectedItem.ToString() == "PCME4403")
            {
                s_name3.Text = "Mechanical Measurement and Control";
            }
            if (c_sc3.SelectedItem.ToString() == "PEME5409")
            {
                s_name3.Text = "Power Plant Engineering";
            }
            if (c_sc3.SelectedItem.ToString() == "PEME5410")
            {
                s_name3.Text = "Fatigue, Creep & Fracture";
            }
            if (c_sc3.SelectedItem.ToString() == "PEME5411")
            {
                s_name3.Text = "Experimental Stress Analysis";
            }
            if (c_sc3.SelectedItem.ToString() == "PEME5412")
            {
                s_name3.Text = "Smart Materials & Structures";
            }
            if (c_sc3.SelectedItem.ToString() == "PEME5413")
            {
                s_name3.Text = "Machinery Fault Diagnostics & Condition Monitoring.";
            }
        }

        private void c_sc4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (c_sc4.SelectedItem.ToString() == "PECS5401")
            {
                s_name4.Text = "Artificial Intelligence";
            }
            if (c_sc4.SelectedItem.ToString() == "MCC104")
            {
                s_name4.Text = "Engineering Economics and Costing";
            }
            if (c_sc4.SelectedItem.ToString() == "MCC204")
            {
                s_name4.Text = "Theory of Computation";
            }
            if (c_sc4.SelectedItem.ToString() == "MCC304")
            {
                s_name4.Text = "Data Base Systems";
            }
            if (c_sc4.SelectedItem.ToString() == "MCC404")
            {
                s_name4.Text = "Compiler Design";
            }
            if (c_sc4.SelectedItem.ToString() == "MGT-104")
            {
                s_name4.Text = "Organization Behaviour";
            }
            if (c_sc4.SelectedItem.ToString() == "MGT-204")
            {
                s_name4.Text = "Operations Management";
            }
            if (c_sc4.SelectedItem.ToString() == "MCC504")
            {
                s_name4.Text = "Quantitative Techniques-II (Modeling & Simulation)";
            }
            if (c_sc4.SelectedItem.ToString() == "PECS5402")
            {
                s_name4.Text = "Cryptography & Network Security";
            }
            if (c_sc4.SelectedItem.ToString() == "PECS5403")
            {
                s_name4.Text = "Real Time Systems";
            }
            if (c_sc4.SelectedItem.ToString() == "PEEC5418")
            {
                s_name4.Text = "Satelite Communication Systems";
            }
            if (c_sc4.SelectedItem.ToString() == "PEEI5405")
            {
                s_name4.Text = "MEMS";
            }
            if (c_sc4.SelectedItem.ToString() == "PCBM4402")
            {
                s_name4.Text = "Medical Imaging Techniques";
            }
            if (c_sc4.SelectedItem.ToString() == "PCIT4303")
            {
                s_name4.Text = "Java Programming";
            }
            if (c_sc4.SelectedItem.ToString() == "PCCS4305")
            {
                s_name4.Text = "Compiler Design";
            }
            if (c_sc4.SelectedItem.ToString() == "BECS2207")
            {
                s_name4.Text = "Object Oriented Programming";
            }
            if (c_sc4.SelectedItem.ToString() == "PCCS4205")
            {
                s_name4.Text = "Database Engineering";
            }
            if (c_sc4.SelectedItem.ToString() == "PCME4202")
            {
                s_name4.Text = "Mechanics of Solids";
            }
            if (c_sc4.SelectedItem.ToString() == "PCCE4205")
            {
                s_name4.Text = "Surveying -1";
            }
            if (c_sc4.SelectedItem.ToString() == "PCCI4301")
            {
                s_name4.Text = "Design of Concrete Structures";
            }
            if (c_sc4.SelectedItem.ToString() == "PECI5301")
            {
                s_name4.Text = "Design of Steel Structure";
            }
            if (c_sc4.SelectedItem.ToString() == "PECI5403")
            {
                s_name4.Text = "Design of Advanced Concrete Structures";
            }
            if (c_sc4.SelectedItem.ToString() == "PECI5404")
            {
                s_name4.Text = "Composite material and Structures";
            }
            if (c_sc4.SelectedItem.ToString() == "HSSM3403")
            {
                s_name4.Text = "Marketing Management";
            }
            if (c_sc4.SelectedItem.ToString() == "PCME4404")
            {
                s_name4.Text = "Production & Operation Management";
            }
            if (c_sc4.SelectedItem.ToString() == "PETX5412")
            {
                s_name4.Text = "Management Information System";
            }
            if (c_sc4.SelectedItem.ToString() == "FECE6405")
            {
                s_name4.Text = "Internet Technology & Applications";
            }
            if (c_sc4.SelectedItem.ToString() == "BEES2211")
            {
                s_name4.Text = "Network Theory";
            }
            if (c_sc4.SelectedItem.ToString() == "PCEE4203")
            {
                s_name4.Text = "Electrical Machines-I";
            }
            if (c_sc4.SelectedItem.ToString() == "PCEL4302")
            {
                s_name4.Text = "Electrical Machines-II";
            }
            if (c_sc4.SelectedItem.ToString() == "PCEE4304")
            {
                s_name4.Text = "Communication Engineering";
            }
            if (c_sc4.SelectedItem.ToString() == "PEEC5414")
            {
                s_name4.Text = "Advanced Control Systems";
            }
            if (c_sc4.SelectedItem.ToString() == "PEEC5402")
            {
                s_name4.Text = "Advanced Communication Systems";
            }
            if (c_sc4.SelectedItem.ToString() == "PCEL4401")
            {
                s_name4.Text = "Power System Operation and Control";
            }
            if (c_sc4.SelectedItem.ToString() == "FEEE6401")
            {
                s_name4.Text = "Power Station Engg and Economy";
            }
            if (c_sc4.SelectedItem.ToString() == "HSSM3403")
            {
                s_name4.Text = "Marketing Management";
            }
            if (c_sc4.SelectedItem.ToString() == "PCME4404")
            {
                s_name4.Text = "Production & Operations Management";
            }
            if (c_sc4.SelectedItem.ToString() == "PCEE4302")
            {
                s_name4.Text = "Electromagnetic Theory";
            }
            if (c_sc4.SelectedItem.ToString() == "PEEE5407")
            {
                s_name4.Text = "Industrial Automation and Control";
            }
            if (c_sc4.SelectedItem.ToString() == "PEEL5401")
            {
                s_name4.Text = "Adaptive Signal Processing";
            }
            if (c_sc4.SelectedItem.ToString() == "PEEC5414")
            {
                s_name4.Text = "Advanced Control Systems.";
            }
            if (c_sc4.SelectedItem.ToString() == "BEEC2214")
            {
                s_name4.Text = "Energy Conversion Devices";
            }
            if (c_sc4.SelectedItem.ToString() == "PCEC4302")
            {
                s_name4.Text = "Analog Communication Techniques";
            }
            if (c_sc4.SelectedItem.ToString() == "PEEC5304")
            {
                s_name4.Text = "Antennas and Wave Propagation";
            }
            if (c_sc4.SelectedItem.ToString() == "PEEC5303")
            {
                s_name4.Text = "Radar and TV Engineering";
            }
            if (c_sc4.SelectedItem.ToString() == "FECE6401")
            {
                s_name4.Text = "Computer System Architecture";
            }
            if (c_sc4.SelectedItem.ToString() == "PECS5403")
            {
                s_name4.Text = "Real Time Systems";
            }
            if (c_sc4.SelectedItem.ToString() == "PEEI5401")
            {
                s_name4.Text = "Microcontroller & Applications";
            }
            if (c_sc4.SelectedItem.ToString() == "PCCS4401")
            {
                s_name4.Text = "Computer Graphics";
            }
            if (c_sc4.SelectedItem.ToString() == "PCCS7402")
            {
                s_name4.Text = "Microwave Engineering Laboratory";
            }
            if (c_sc4.SelectedItem.ToString() == "PCEI4302")
            {
                s_name4.Text = "Instrumentation Devices and Systems – I";
            }
            if (c_sc4.SelectedItem.ToString() == "FEEI6402")
            {
                s_name4.Text = "Digital Communication";
            }
            if (c_sc4.SelectedItem.ToString() == "FEEI6401")
            {
                s_name4.Text = "TV & Radar Engineering";
            }
            if (c_sc4.SelectedItem.ToString() == "PCEI7401")
            {
                s_name4.Text = "Instrumentation Systems Simulation Lab";
            }
            if (c_sc4.SelectedItem.ToString() == "PCEI4305")
            {
                s_name4.Text = "Instrumentation Devices and Systems – II";
            }
            if (c_sc4.SelectedItem.ToString() == "PCME4202")
            {
                s_name4.Text = "Mechanics of Solids";
            }
            if (c_sc4.SelectedItem.ToString() == "PCME4205")
            {
                s_name4.Text = "Engg.Thermodynamics";
            }
            if (c_sc4.SelectedItem.ToString() == "PCME4302")
            {
                s_name4.Text = "I.C. Engines & Gas Turbines";
            }
            if (c_sc4.SelectedItem.ToString() == "PCME4305")
            {
                s_name4.Text = "Heat Transfer";
            }
            if (c_sc4.SelectedItem.ToString() == "PEME5401")
            {
                s_name4.Text = "Mechanical Vibration";
            }
            if (c_sc4.SelectedItem.ToString() == "PEME5402")
            {
                s_name4.Text = "Advanced Fluid Mechanics";
            }
            if (c_sc4.SelectedItem.ToString() == "PEME5403")
            {
                s_name4.Text = "Fluid Power & Control";
            }
            if (c_sc4.SelectedItem.ToString() == "PEME5404")
            {
                s_name4.Text = "Computational Fluid Dynamics";
            }
            if (c_sc4.SelectedItem.ToString() == "PETX5412")
            {
                s_name4.Text = "Management Information System";
            }
            if (c_sc4.SelectedItem.ToString() == "HSSM3403")
            {
                s_name4.Text = "Marketing Managements";
            }
            if (c_sc4.SelectedItem.ToString() == "PECS5407")
            {
                s_name4.Text = "Wireless Sensor Networks";
            }
            if (c_sc4.SelectedItem.ToString() == "PEEI5405")
            {
                s_name4.Text = "Micro Electro Mechanical Systems(MEMS)";
            }
        }

        private void c_sc5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (c_sc5.SelectedItem.ToString() == "PECS5404")
            {
                s_name5.Text = "Advanced Computer Architecture";
            }
            if (c_sc5.SelectedItem.ToString() == "MCC105")
            {
                s_name5.Text = "Financial Accounting";
            }
            if (c_sc5.SelectedItem.ToString() == "MCC205")
            {
                s_name5.Text = "Computer Based Numerical Methods";
            }
            if (c_sc5.SelectedItem.ToString() == "MGT-105")
            {
                s_name5.Text = "Financial Accounting for Managers";
            }
            if (c_sc5.SelectedItem.ToString() == "MGT-205")
            {
                s_name5.Text = "Financial Markets and Institutions";
            }
            if (c_sc5.SelectedItem.ToString() == "MCC305")
            {
                s_name5.Text = "Probability and Statistics";
            }
            if (c_sc5.SelectedItem.ToString() == "MCC405")
            {
                s_name5.Text = "Quantitative Techniques-I (Operations Research)";
            }
            if (c_sc5.SelectedItem.ToString() == "MCE405")
            {
                s_name5.Text = "Distributed Systems";
            }
            if (c_sc5.SelectedItem.ToString() == "MCE406")
            {
                s_name5.Text = "Parallel Computing";
            }
            if (c_sc5.SelectedItem.ToString() == "MCE407")
            {
                s_name5.Text = "Image Processing";
            }
            if (c_sc5.SelectedItem.ToString() == "MCE408")
            {
                s_name5.Text = "Web Engineering";
            }
            if (c_sc5.SelectedItem.ToString() == "PCIT4401")
            {
                s_name5.Text = "Principles of Soft Computing";
            }
            if (c_sc5.SelectedItem.ToString() == "PCIT4402")
            {
                s_name5.Text = "Software Project Managment";
            }
            if (c_sc5.SelectedItem.ToString() == "PEEI5404")
            {
                s_name5.Text = "Analog VLSI Design";
            }
            if (c_sc5.SelectedItem.ToString() == "PEME5407")
            {
                s_name5.Text = "Mechatronics";
            }
            if (c_sc5.SelectedItem.ToString() == "PEEI5403")
            {
                s_name5.Text = "Industrial Instrumentation";
            }
            if (c_sc5.SelectedItem.ToString() == "PECS5301")
            {
                s_name5.Text = "Mobile Computing";
            }
            if (c_sc5.SelectedItem.ToString() == "PECS5302")
            {
                s_name5.Text = "Principles of Programming Languages";
                }

            if (c_sc5.SelectedItem.ToString() == "PECS5304")
                {
                    s_name5.Text = "Theory of Computation";
                }
            if (c_sc5.SelectedItem.ToString() == "PCIT4301")
            {
                s_name5.Text = "Internet & Web Technology";
            }
            if (c_sc5.SelectedItem.ToString() == "PECS5303")
            {
                s_name5.Text = "Pattern Recognition";
            }
            if (c_sc5.SelectedItem.ToString() == "PCEC4304")
            {
                s_name5.Text = "Digital Signal Processing";
            }
            if (c_sc5.SelectedItem.ToString() == "PCEC4201")
            {
                s_name5.Text = "Analog Electronics Circuit";
            }
            if (c_sc5.SelectedItem.ToString() == "PCEC4202")
            {
                s_name5.Text = "Digital Electronics Circuit";
            }
            if (c_sc5.SelectedItem.ToString() == "PCCE4203")
            {
                s_name5.Text = "Building Material & Building Construction";
            }
            if (c_sc5.SelectedItem.ToString() == "PCCE4206")
            {
                s_name5.Text = "Geo Technical Engineering";
            }
            if (c_sc5.SelectedItem.ToString() == "PECI5303")
            {
                s_name5.Text = "Surveying - II";
            }
            if (c_sc5.SelectedItem.ToString() == "PECI5302")
            {
                s_name5.Text = "Remote Sensing & GIS";
            }
            if (c_sc5.SelectedItem.ToString() == "PECI5304")
            {
                s_name5.Text = "Transportation Engineering - II";
            }
            if (c_sc5.SelectedItem.ToString() == "PECI5305")
            {
                s_name5.Text = "Pavement Design";
            }
            if (c_sc5.SelectedItem.ToString() == "PECI5405")
            {
                s_name5.Text = "Estimation, Costing & Professional Practice";
            }
            if (c_sc5.SelectedItem.ToString() == "PECI5406")
            {
                s_name5.Text = "Bridge Engineering";
            }
            if (c_sc5.SelectedItem.ToString() == "PCCI7404")
            {
                s_name5.Text = "Major Project";
            }
            if (c_sc5.SelectedItem.ToString() == "BECS2212")
            {
                s_name5.Text = "C++ & Object Oriented Programming";
            }
            if (c_sc5.SelectedItem.ToString() == "PCEE4204")
            {
                s_name5.Text = "Electrical & Electronics Measurement";
            }
            if (c_sc5.SelectedItem.ToString() == "PEEL5302")
            {
                s_name5.Text = "Renewable Energy Systems";
            }
            if (c_sc5.SelectedItem.ToString() == "PEEL5301")
            {
                s_name5.Text = "Sensors and Transducers";
            }
            if (c_sc5.SelectedItem.ToString() == "PEEC4301")
            {
                s_name5.Text = "Advanced Electronic Circuits";
            }
            if (c_sc5.SelectedItem.ToString() == "PEME5305")
            {
                s_name5.Text = "Robotics & Robot Applications";
            }
            if (c_sc5.SelectedItem.ToString() == "PEEE5301")
            {
                s_name5.Text = "Optoelectronics Devices & Instrumentation";
            }
            if (c_sc5.SelectedItem.ToString() == "PEEL5303")
            {
                s_name5.Text = "Electric Drives";
            }
            if (c_sc5.SelectedItem.ToString() == "PEEC5416")
            {
                s_name5.Text = "Biomedical Instrumentation";
            }
            if (c_sc5.SelectedItem.ToString() == "PEEL5401")
            {
                s_name5.Text = "Adaptive Signal Processing";
            }
            if (c_sc5.SelectedItem.ToString() == "PEME5407")
            {
                s_name5.Text = "Mechatronics";
            }
            if (c_sc5.SelectedItem.ToString() == "PCEE7404")
            {
                s_name5.Text = "Major Project";
            }
            if (c_sc5.SelectedItem.ToString() == "PEEC4302")
            {
                s_name5.Text = "Fibre Optics & Optoelectronics Devices";
            }
            if (c_sc5.SelectedItem.ToString() == "PEEL5302")
            {
                s_name5.Text = "Renewable Energy Systems";
            }
            if (c_sc5.SelectedItem.ToString() == "PEEL5301")
            {
                s_name5.Text = "Sensors and Transducers";
            }
            if (c_sc5.SelectedItem.ToString() == "PEEL5303")
            {
                s_name5.Text = "Electric Drives";
            }
            if (c_sc5.SelectedItem.ToString() == "PCEE4304")
            {
                s_name5.Text = "Communication Engineering";
            }
            if (c_sc5.SelectedItem.ToString() == "PCEC4304")
            {
                s_name5.Text = "Digital Signal Processing";
            }
            if (c_sc5.SelectedItem.ToString() == "FEEE6402")
            {
                s_name5.Text = "High Voltage Engg.";
            }
            if (c_sc5.SelectedItem.ToString() == "PCEL7404")
            {
                s_name5.Text = "Major Project";
            }
            if (c_sc5.SelectedItem.ToString() == "PEEC4301")
            {
                s_name5.Text = "Advanced Electronic Circuits";
            }
            if (c_sc5.SelectedItem.ToString() == "PCEL7405")
            {
                s_name5.Text = "Major Project";
            }
            if (c_sc5.SelectedItem.ToString() == "PCEE4204")
            {
                s_name5.Text = "Electrical & Electronic Measurement";
            }
            if (c_sc5.SelectedItem.ToString() == "BECS2212")
            {
                s_name5.Text = "C++ & Object Oriented Programming";
            }
            if (c_sc5.SelectedItem.ToString() == "PEEC5304")
            {
                s_name5.Text = "Antennas and Wave Propagation";
            }
            if (c_sc5.SelectedItem.ToString() == "PEEC5303")
            {
                s_name5.Text = "Radar and TV Engineering";
            }
            if (c_sc5.SelectedItem.ToString() == "PEEC5302")
            {
                s_name5.Text = "Mobile Communication";
            }
            if (c_sc5.SelectedItem.ToString() == "PEEC5301")
            {
                s_name5.Text = "Information Theory and Coding";
            }
            if (c_sc5.SelectedItem.ToString() == "PEEC4304")
            {
                s_name5.Text = "Computer Network & Data Communication";
            }
            if (c_sc5.SelectedItem.ToString() == "FECE6402")
            {
                s_name5.Text = "Principles of Mobile Computing";
            }
            if (c_sc5.SelectedItem.ToString() == "PEEE5407")
            {
                s_name5.Text = "Industrial Automation & Control";
            }
            if (c_sc5.SelectedItem.ToString() == "FECE6403")
            {
                s_name5.Text = "Mathematics for Communication Engineers";
            }
            if (c_sc5.SelectedItem.ToString() == "PECS5401")
            {
                s_name5.Text = "Artificial Intelligence";
            }
            if (c_sc5.SelectedItem.ToString() == "PCEC7404")
            {
                s_name5.Text = "Project (50% External Evaluation)";
            }
            if (c_sc5.SelectedItem.ToString() == "PEEC4303")
            {
                s_name5.Text = "Electronic Devices and Modelling";
            }
            if (c_sc5.SelectedItem.ToString() == "PCBM4302")
            {
                s_name5.Text = "Signals and Systems";
            }
            if (c_sc5.SelectedItem.ToString() == "PEEI5303")
            {
                s_name5.Text = "Electromagnetic Waves and Fields";
            }
            if (c_sc5.SelectedItem.ToString() == "PCEL4301")
            {
                s_name5.Text = "Power Electronics";
            }
            if (c_sc5.SelectedItem.ToString() == "PEEI5302")
            {
                s_name5.Text = "Analog Signal Processing";
            }
            if (c_sc5.SelectedItem.ToString() == "PEEI5301")
            {
                s_name5.Text = "Analytical Instrumentation";
            }
            if (c_sc5.SelectedItem.ToString() == "PEEE5301")
            {
                s_name5.Text = "Optoelectronics Devices & Instrumentation";
            }
            if (c_sc5.SelectedItem.ToString() == "PEEI5304")
            {
                s_name5.Text = "Intelligent & Virtual Instrumentation";
            }
            if (c_sc5.SelectedItem.ToString() == "PCEI7404")
            {
                s_name5.Text = "Project (50% External Evaluation)";
            }
            if (c_sc5.SelectedItem.ToString() == "PCME4203")
            {
                s_name5.Text = "Introduction to Physical Metallurgy & Engg Materials";
            }
            if (c_sc5.SelectedItem.ToString() == "PCME4206")
            {
                s_name5.Text = "Basic Manufacturing Processes";
            }
            if (c_sc5.SelectedItem.ToString() == "PEME5301")
            {
                s_name5.Text = "Automobile Engineering";
            }
            if (c_sc5.SelectedItem.ToString() == "PEME5302")
            {
                s_name5.Text = "CAD & CAM";
            }
            if (c_sc5.SelectedItem.ToString() == "PEME5304")
            {
                s_name5.Text = "Tribology";
            }
            if (c_sc5.SelectedItem.ToString() == "PEME5303")
            {
                s_name5.Text = "Rapid Prototyping";
            }
            if (c_sc5.SelectedItem.ToString() == "PEME5305")
            {
                s_name5.Text = "Robotics & Robot Applications";
            }
            if (c_sc5.SelectedItem.ToString() == "PEME5306")
            {
                s_name5.Text = "Modern Manufacturing Processes";
            }
            if (c_sc5.SelectedItem.ToString() == "PEME5307")
            {
                s_name5.Text = "Computer Integrated Manufacturing & FMS";
            }
            if (c_sc5.SelectedItem.ToString() == "PEME5308")
            {
                s_name5.Text = "Non Conventional Energy Sources";
            }
            if (c_sc5.SelectedItem.ToString() == "PEME5405")
            {
                s_name5.Text = "Metrology, Quality Control & Reliability";
            }
            if (c_sc5.SelectedItem.ToString() == "PEME5406")
            {
                s_name5.Text = "Simulation Modeling and Control";
            }
            if (c_sc5.SelectedItem.ToString() == "PEME5407")
            {
                s_name5.Text = "Mechatronics";
            }
            if (c_sc5.SelectedItem.ToString() == "PEME5408")
            {
                s_name5.Text = "Composite Materials";
            }
            if (c_sc5.SelectedItem.ToString() == "PCME7404")
            {
                s_name5.Text = "Project";
            }
        }

        private void c_sc6_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (c_sc6.SelectedItem.ToString() == "PCEC4401")
            {
                s_name6.Text = "VLSI Design";
            }
            if (c_sc6.SelectedItem.ToString() == "MCC106")
            {
                s_name6.Text = "Communicative English";
            }
            if (c_sc6.SelectedItem.ToString() == "MCC206")
            {
                s_name6.Text = "Business Communication in English";
            }
            if (c_sc6.SelectedItem.ToString() == "MCC306")
            {
                s_name6.Text = "Management Information System";
            }
            if (c_sc6.SelectedItem.ToString() == "MGT-106")
            {
                s_name6.Text = "Marketing Management-I";
            }
            if (c_sc6.SelectedItem.ToString() == "MGT-206")
            {
                s_name6.Text = "Business Research Methods";
            }
            if (c_sc6.SelectedItem.ToString() == "MCE509")
            {
                s_name6.Text = "Computer Security";
            }
            if (c_sc6.SelectedItem.ToString() == "MCE510")
            {
                s_name6.Text = "Software Design";
            }
            if (c_sc6.SelectedItem.ToString() == "MCE511")
            {
                s_name6.Text = "Bioinformatics";
            }
            if (c_sc6.SelectedItem.ToString() == "MCE512")
            {
                s_name6.Text = "Soft Computing";
            }
            if (c_sc6.SelectedItem.ToString() == "MCC406")
            {
                s_name6.Text = "E-Commerce & ERP";
            }
            if (c_sc6.SelectedItem.ToString() == "PEEC5416")
            {
                s_name6.Text = "Biomedical Instrumentation";
            }
            if (c_sc6.SelectedItem.ToString() == "PEEC5417")
            {
                s_name6.Text = "Digital Switching & Telecommunication  Network ";
            }
            if (c_sc6.SelectedItem.ToString() == "FECS6401")
            {
                s_name6.Text = "Introduction to Digital Signal Processing";
            }
            if (c_sc6.SelectedItem.ToString() == "PCCS7403")
            {
                s_name6.Text = "Major Project";
            }
            if (c_sc6.SelectedItem.ToString() == "PCBM4302")
            {
                s_name6.Text = "Signals & Systems";
            }
            if (c_sc6.SelectedItem.ToString() == "PCEC4302")
            {
                s_name6.Text = "Analog Communication Techniques";
            }
            if (c_sc6.SelectedItem.ToString() == "PCEC4303")
            {
                s_name6.Text = "Control System Engineering";
            }
            if (c_sc6.SelectedItem.ToString() == "PCEC4305")
            {
                s_name6.Text = "Digital Communication Techniques";
            }
            if (c_sc6.SelectedItem.ToString() == "PCEE4304")
            {
                s_name6.Text = "Communication Engineering";
            }
            if (c_sc6.SelectedItem.ToString() == "PEME5305")
            {
                s_name6.Text = "Robotics & Robot Applications";
            }
            if (c_sc6.SelectedItem.ToString() == "PEEE5301")
            {
                s_name6.Text = "Optoelectronics Devices& Instrumentation";
            }
            if (c_sc6.SelectedItem.ToString() == "HSSM3204")
            {
                s_name6.Text = "Engineering Economics and Costing";
            }
            if (c_sc6.SelectedItem.ToString() == "HSSM3205")
            {
                s_name6.Text = "Organizational Behavior";
            }
            if (c_sc6.SelectedItem.ToString() == "PCME4201")
            {
                s_name6.Text = "Fluid Mechanics and Hydraulic Machines";
            }
            if (c_sc6.SelectedItem.ToString() == "PCME4201")
            {
                s_name6.Text = "Fluid Mechanics and Hydraulic Machines";
            }
            if (c_sc6.SelectedItem.ToString() == "FEEC2216")
            {
                s_name6.Text = "Analog & Digital Electronics,";

            }
            if (c_sc6.SelectedItem.ToString() == "FECS2208")
            {
                s_name6.Text = "Data Base Management Systems";
            }
            if (c_sc6.SelectedItem.ToString() == "FEEE2215")
            {
                s_name6.Text = "Energy Conversion Technique.";
            }
            if (c_sc6.SelectedItem.ToString() == "PCCS4301")
            {
                s_name6.Text = "Computer Organization";
            }
            if (c_sc6.SelectedItem.ToString() == "PCIT4303")
            {
                s_name6.Text = "Java Programming";
            }
            if (c_sc6.SelectedItem.ToString() == "FESM6302")
            {
                s_name6.Text = "Advance Numerical Methods";
            }
            if (c_sc6.SelectedItem.ToString() == "HSSM3302")
            {
                s_name6.Text = "Optimization in Engineering";
            }
            if (c_sc6.SelectedItem.ToString() == "PEME5308")
            {
                s_name6.Text = "Non-conventional Energy sources";
            }
            if (c_sc6.SelectedItem.ToString() == "PEIT5301")
            {
                s_name6.Text = "E-Commerce";
            }
            if (c_sc6.SelectedItem.ToString() == "HSSM3401")
            {
                s_name6.Text = "Entrepreneurship Development";
            }
            if (c_sc6.SelectedItem.ToString() == "PEME5408")
            {
                s_name6.Text = "Composite Materials";
            }
            if (c_sc6.SelectedItem.ToString() == "PCCS4401")
            {
                s_name6.Text = "Computer Graphics";
            }
            if (c_sc6.SelectedItem.ToString() == "PECS5401")
            {
                s_name6.Text = "Artificial Intelligence";
            }
            if (c_sc6.SelectedItem.ToString() == "PCCI7406")
            {
                s_name6.Text = "Viva-voce";
            }
            if (c_sc6.SelectedItem.ToString() == "PCEC4201")
            {
                s_name6.Text = "Analog Electronics Circuit";
            }
            if (c_sc6.SelectedItem.ToString() == "PCEC4202")
            {
                s_name6.Text = "Digital Electronics Circuit";
            }
            if (c_sc6.SelectedItem.ToString() == "FESM6301")
            {
                s_name6.Text = "Numerical methods";
            }
            if (c_sc6.SelectedItem.ToString() == "FEEC6301")
            {
                s_name6.Text = "Data Base Management Systems";
            }
            if (c_sc6.SelectedItem.ToString() == "PCCS4301")
            {
                s_name6.Text = "Computer Organization";
            }
            if (c_sc6.SelectedItem.ToString() == "PCIT4303")
            {
                s_name6.Text = "Java Programming";
            }
            if (c_sc6.SelectedItem.ToString() == "PEEC4304")
            {
                s_name6.Text = "ComputerNetworks& Data Communication";
            }
            if (c_sc6.SelectedItem.ToString() == "PCCS4304")
            {
                s_name6.Text = "Operating Systems";
            }
            if (c_sc6.SelectedItem.ToString() == "FEEE6301")
            {
                s_name6.Text = "Industrial Process Control and Dynamics";
            }
            if (c_sc6.SelectedItem.ToString() == "PCEE7401")
            {
                s_name6.Text = "Power System Lab.";
            }
            if (c_sc6.SelectedItem.ToString() == "PCEE7405")
            {
                s_name6.Text = "Comprehensive Viva-Voce";
            }
            if (c_sc6.SelectedItem.ToString() == "PCBM4301")
            {
                s_name6.Text = "Elements of Biomedical Instrumentation";
            }
            if (c_sc6.SelectedItem.ToString() == "PEEC4304")
            {
                s_name6.Text = "Computer Networks &Data Communication";
            }
            if (c_sc6.SelectedItem.ToString() == "PEME5305")
            {
                s_name6.Text = "Robotics & Robot Application";
            }
            if (c_sc6.SelectedItem.ToString() == "PCEL7404")
            {
                s_name6.Text = "Comprehensive Viva-Voce";
            }
            if (c_sc6.SelectedItem.ToString() == "PCEC4201")
            {
                s_name6.Text = "Analog Electronics Circuit";
            }
            if (c_sc6.SelectedItem.ToString() == "PCEC4202")
            {
                s_name6.Text = "Digital Electronics Circuit";
            }
            if (c_sc6.SelectedItem.ToString() == "HSSM3302")
            {
                s_name6.Text = "Optimization in Engineering";
            }
            if (c_sc6.SelectedItem.ToString() == "FEEC6302")
            {
                s_name6.Text = "Applied Physiology";
            }
            if (c_sc6.SelectedItem.ToString() == "FESM6301")
            {
                s_name6.Text = "Numerical Methods";
            }
            if (c_sc6.SelectedItem.ToString() == "PEEI5302")
            {
                s_name6.Text = "Analog Signal Processing";
            }
            if (c_sc6.SelectedItem.ToString() == "PCBM4304")
            {
                s_name6.Text = "Biomedical Signal Processing";
            }
            if (c_sc6.SelectedItem.ToString() == "PEME5305")
            {
                s_name6.Text = "Robotics & Robot Applications";
            }
            if (c_sc6.SelectedItem.ToString() == "PCEC7401")
            {
                s_name6.Text = "VLSI Design Laboratory";
            }
            if (c_sc6.SelectedItem.ToString() == "PCEC7405")
            {
                s_name6.Text = "Comprehensive Viva-Voce (External Evaluation)";
            }
            if (c_sc6.SelectedItem.ToString() == "PCEI7405")
            {
                s_name6.Text = "Comprehensive Viva-Voce (External Evaluation)";
            }
            if (c_sc6.SelectedItem.ToString() == "BECS2208")
            {
                s_name6.Text = "Data Base Management Systems (DBMS)";
            }
            if (c_sc6.SelectedItem.ToString() == "BEEE2215")
            {
                s_name6.Text = "Energy Conversion Techniques";
            }
            if (c_sc6.SelectedItem.ToString() == "PCCE4205")
            {
                s_name6.Text = "Surveying";
            }
            if (c_sc6.SelectedItem.ToString() == "BECS2212")
            {
                s_name6.Text = "C++ & Object Oriented Programming/";
            }
            if (c_sc6.SelectedItem.ToString() == "BEEC2216")
            {
                s_name6.Text = "Analog and Digital Electronics";
            }
            if (c_sc6.SelectedItem.ToString() == "FESM6302")
            {
                s_name6.Text = "Advance Numerical Methods";
            }
            if (c_sc6.SelectedItem.ToString() == "PCEC4301")
            {
                s_name6.Text = "Microprocessors";
            }
            if (c_sc6.SelectedItem.ToString() == "FEME6302")
            {
                s_name6.Text = "Project Management";
            }
            if (c_sc6.SelectedItem.ToString() == "PCBM4301")
            {
                s_name6.Text = "Elements of Biomedical Instrumentation";
            }
            if (c_sc6.SelectedItem.ToString() == "PCIT4303")
            {
                s_name6.Text = "Java Programming.";
            }
            if (c_sc6.SelectedItem.ToString() == "FEME6301")
            {
                s_name6.Text = "Finite Element Method";
            }
            if (c_sc6.SelectedItem.ToString() == "PCEC4304")
            {
                s_name6.Text = "Digital Signal Processing";
            }
            if (c_sc6.SelectedItem.ToString() == "PCIT4301")
            {
                s_name6.Text = "Internet and web technology";
            }
            if (c_sc6.SelectedItem.ToString() == "PECS5303")
            {
                s_name6.Text = "Pattern Recognition";
            }
            if (c_sc6.SelectedItem.ToString() == "PEIT5301")
            {
                s_name6.Text = "Ecommerce";
            }
            if (c_sc6.SelectedItem.ToString() == "FEME6401")
            {
                s_name6.Text = "Human Resource Managements";
            }
            if (c_sc6.SelectedItem.ToString() == "PEEE5407")
            {
                s_name6.Text = "Industrial Automation & Control";
            }
            if (c_sc6.SelectedItem.ToString() == "PEEE5406")
            {
                s_name6.Text = "Soft Computing";
            }
            if (c_sc6.SelectedItem.ToString() == "HSSM3401")
            {
                s_name6.Text = "Entrepreneurship Development";
            }
            if (c_sc6.SelectedItem.ToString() == "PCME7405")
            {
                s_name6.Text = "Seminar - II";
            }
        }

        private void c_sc7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (c_sc7.SelectedItem.ToString() == "PCCS7402")
            {
                s_name7.Text = "Minor Project";
            }
            if (c_sc7.SelectedItem.ToString() == "MCL107")
            {
                s_name7.Text = "Communicative English Lab-I";
            }
            if (c_sc7.SelectedItem.ToString() == "MCL207")
            {
                s_name7.Text = "Communicative Practice Lab-II";
            }
            if (c_sc7.SelectedItem.ToString() == "MGT-107")
            {
                s_name7.Text = "English Communication Skills";
            }
            if (c_sc7.SelectedItem.ToString() == "MGT-207")
            {
                s_name7.Text = "Management Information Systems";
            }
            if (c_sc7.SelectedItem.ToString() == "MCL307")
            {
                s_name7.Text = "Lab – V (Operating System & Network Lab.)";
            }
            if (c_sc7.SelectedItem.ToString() == "MCL407")
            {
                s_name7.Text = "Lab – VII (Programming with Java Lab.) ";
            }
            if (c_sc7.SelectedItem.ToString() == "MCA513")
            {
                s_name7.Text = "Assignment";
            }
            if (c_sc7.SelectedItem.ToString() == "PCCS7404")
            {
                s_name7.Text = "Comprehensive Viva voce";
            }
            if (c_sc7.SelectedItem.ToString() == "PCCS7301")
            {
                s_name7.Text = "Computer Organization Lab";
            }
            if (c_sc7.SelectedItem.ToString() == "PCEL7303")
            {
                s_name7.Text = "Microprocessor & Microcontroller Lab";
            }
            if (c_sc7.SelectedItem.ToString() == "HSSM7203")
            {
                s_name7.Text = "COMMUNICATION AND INTERPERSONAL SKILLS FOR CORPORATE READINESS LAB";
            }
            if (c_sc7.SelectedItem.ToString() == "PCEC7202")
            {
                s_name7.Text = "Digital Electronics Circuit Lab";
            }
            if (c_sc7.SelectedItem.ToString() == "BECS7212")
            {
                s_name7.Text = "C++ & Object Oriented Programming Lab";
            }
            if (c_sc7.SelectedItem.ToString() == "PCCE7209")
            {
                s_name7.Text = "Material Testing Lab";
            }
            if (c_sc7.SelectedItem.ToString() == "PCCI7301")
            {
                s_name7.Text = "Concrete & Structural Engg Lab.";
            }
            if (c_sc7.SelectedItem.ToString() == "PCCI7305")
            {
                s_name7.Text = "Environmental Engineering Lab.";
            }
            if (c_sc7.SelectedItem.ToString() == "PECS5401")
            {
                s_name7.Text = "Design of Irrigation Structures.";
            }
            if (c_sc7.SelectedItem.ToString() == "PCCI7405")
            {
                s_name7.Text = "Seminar";
            }
            if (c_sc7.SelectedItem.ToString() == "BEES7211")
            {
                s_name7.Text = "Network & Devices Lab.";
            }
            if (c_sc7.SelectedItem.ToString() == "PCEE7203")
            {
                s_name7.Text = "Electrical Machines Lab-I";
            }
            if (c_sc7.SelectedItem.ToString() == "PCEC7303")
            {
                s_name7.Text = "Control & Instrumentation Lab.";
            }
            if (c_sc7.SelectedItem.ToString() == "PCEL7303")
            {
                s_name7.Text = "Microprocessor & Microcontroller Lab";
            }
            if (c_sc7.SelectedItem.ToString() == "PCEE7402")
            {
                s_name7.Text = "Minor Project";
            }
            if (c_sc7.SelectedItem.ToString() == "PEEL7303")
            {
                s_name7.Text = "Electric Drives Lab";
            }
            if (c_sc7.SelectedItem.ToString() == "PCEE7304")
            {
                s_name7.Text = "Communication Engineering Labt";
            }
            if (c_sc7.SelectedItem.ToString() == "PCEC7304")
            {
                s_name7.Text = "Digital Signal Processing Lab";
            }
            if (c_sc7.SelectedItem.ToString() == "BEES7211")
            {
                s_name7.Text = "Network & Devices Laboratory";
            }
            if (c_sc7.SelectedItem.ToString() == "BEEC7214")
            {
                s_name7.Text = "Energy Conversion Devices Laboratory";
            }
            if (c_sc7.SelectedItem.ToString() == "PCEC7304")
            {
                s_name7.Text = "Digital Signal Processing Lab.";
            }
            if (c_sc7.SelectedItem.ToString() == "PCEC7402")
            {
                s_name7.Text = "Project";
            }
            if (c_sc7.SelectedItem.ToString() == "PCEI7301")
            {
                s_name7.Text = "Communication System Engineering Lab.";
            }
            if (c_sc7.SelectedItem.ToString() == "PCEI7402")
            {
                s_name7.Text = "Project";
            }
            if (c_sc7.SelectedItem.ToString() == "PCME7202")
            {
                s_name7.Text = "Mechanical Engg. Lab";
            }
            if (c_sc7.SelectedItem.ToString() == "PCME7203")
            {
                s_name7.Text = "Machine Shop and Fabrication Practice";
            }
            if (c_sc7.SelectedItem.ToString() == "PCME7302")
            {
                s_name7.Text = "Production Lab & IC Engines Lab.";
            }
            if (c_sc7.SelectedItem.ToString() == "PCME7305")
            {
                s_name7.Text = "Heat Transfer & Heat Power Lab.";
            }
            if (c_sc7.SelectedItem.ToString() == "PCME7402")
            {
                s_name7.Text = "Project.";
            }
            if (c_sc7.SelectedItem.ToString() == "PCME7406")
            {
                s_name7.Text = "Enterprenurship Project";
            }
        }

        private void s_code8_TextChanged(object sender, EventArgs e)
        {
            if (s_code8.Text == "PCCS7401")
            {
                s_name8.Text = "Software Engineering Lab";
            }
            if (s_code8.Text == "MCL108")
            {
                s_name8.Text = "Lab – I (C Programming Lab)";
            }
            if (s_code8.Text == "MCL308")
            {
                s_name8.Text = "Lab – VI (Data base Lab)";
            }
            if (s_code8.Text == "MGT-108")
            {
                s_name8.Text = "IT Practices for Managers (Lab)";
            }
            if (s_code8.Text == "MGT-208")
            {
                s_name8.Text = "Managerial Communication & Practices";
            }
            if (s_code8.Text == "MCL208")
            {
                s_name8.Text = "Lab – III (Data Structure in C Lab) ";
            }
            if (s_code8.Text == "MCL408")
            {
                s_name8.Text = "Lab – VIII (Comp. Graphics & Multimedia Lab.)";
            }
            if (s_code8.Text == "MCL514")
            {
                s_name8.Text = "Lab – X (Enterprise Web Computing Java Lab.)";
            }
            if (s_code8.Text == "PCCS7302")
            {
                s_name8.Text = "Computer Network Lab";
            }
            if (s_code8.Text == "PCCS7304")
            {
                s_name8.Text = "Operating System Lab";
            }
            if (s_code8.Text == "PCEC7201")
            {
                s_name8.Text = "Analog Electronics Lab";
            }
            if (s_code8.Text == "PCCS7204")
            {
                s_name8.Text = "Design and Analysis of Algorithm Lab";
            }
            if (s_code8.Text == "HSSM7203")
            {
                s_name8.Text = "Communication and Interpersonal Skills for Corporate Readiness";
            }
            if (s_code8.Text == "PCCE7210")
            {
                s_name8.Text = "Hydraulics Laboratory";
            }
            if (s_code8.Text == "PCCI7302")
            {
                s_name8.Text = "Geotechnical Engineering Lab.";
            }
            if (s_code8.Text == "PCCI7306")
            {
                s_name8.Text = "Transportation Engineering Lab- I.";
            }
            if (s_code8.Text == "PCCI7402")
            {
                s_name8.Text = "Design of Water Supply and Sanitary Engineering System";
            }
            if (s_code8.Text == "BECS7212")
            {
                s_name8.Text = "C++ & Object Oriented Programming Laboratory";
            }
            if (s_code8.Text == "PCEE7204")
            {
                s_name8.Text = "Electrical & Electronics Measurement Laboratory";
            }
            if (s_code8.Text == "PCEL7301")
            {
                s_name8.Text = "Power Electronics Lab.";
            }
            if (s_code8.Text == "PCEC7304")
            {
                s_name8.Text = "Digital Signal Processing Lab.";
            }
            if (s_code8.Text == "PCEE7403")
            {
                s_name8.Text = "Seminar / Training Seminar";
            }
            if (s_code8.Text == "PCEL7303")
            {
                s_name8.Text = "Microprocessor & Microcontroller Lab.";
            }
            if (s_code8.Text == "PCEC7201")
            {
                s_name8.Text = "Analog Electronics Circuit Laboratory";
            }
            if (s_code8.Text == "PCEC7202")
            {
                s_name8.Text = "Digital Electronics Circuit Laboratory";
            }
            if (s_code8.Text == "PCEC7306")
            {
                s_name8.Text = "Communication Engineering Lab.";
            }
            if (s_code8.Text == "PCEC7403")
            {
                s_name8.Text = "Seminar";
            }
            if (s_code8.Text == "PCEI7303")
            {
                s_name8.Text = "Control Systems Lab.";
            }
            if (s_code8.Text == "PCEI7403")
            {
                s_name8.Text = "Seminar";
            }
            if (s_code8.Text == "PCME7201")
            {
                s_name8.Text = "Machine Drawing";
            }
            if (s_code8.Text == "PCME7204")
            {
                s_name8.Text = "Material Testing & Hydraulic Machines Lab";
            }
            if (s_code8.Text == "PCME7301")
            {
                s_name8.Text = "Machine Dynamics & Heat Power Lab";
            }
            if (s_code8.Text == "PCME7307")
            {
                s_name8.Text = "Numerical Computation & Solids Modeling Lab";
            }
            if (s_code8.Text == "PCME7403")
            {
                s_name8.Text = "Seminar - I";
            }
            if (s_code8.Text == "PCME7407")
            {
                s_name8.Text = "Comprehensive Viva-Voce";
            }
        }
        private void s_code9_TextChanged(object sender, EventArgs e)
        {
            if (s_code9.Text == "PCCS7303")
            {
                s_name9.Text = "JAVA Programming Lab";
            }
            if (s_code9.Text == "MCL109")
            {
                s_name9.Text = "Lab – II (Assembly Language Programming Lab)";
            }
            if (s_code9.Text == "MCL209")
            {
                s_name9.Text = "Lab – IV (C++ Programming Lab.)";
            }
            if (s_code9.Text == "MCL309")
            {
                s_name9.Text = "Communication and Interpersonal Skills for Corporate Readiness ";
            }
            if (s_code8.Text == "MGT-109")
            {
                s_name8.Text = "English Communication Skills (Lab)";
            }
            if (s_code8.Text == "MGT-209")
            {
                s_name8.Text = "Business Awareness and Presentation";
            }
            if (s_code9.Text == "MCS309")
            {
                s_name9.Text = "Seminar";
            }
            if (s_code9.Text == "MCV515")
            {
                s_name9.Text = "Comprehensive Viva-voce";
            }
            if (s_code9.Text == "PCCS7307")
            {
                s_name9.Text = "Seminar";
            }
            if (s_code9.Text == "BECS7207")
            {
                s_name9.Text = "Object Oriented Programming Lab.";
            }
            if (s_code9.Text == "PCCS7205")
            {
                s_name9.Text = "Database Engg. Lab.";
            }
            if (s_code9.Text == "PCCE7207")
            {
                s_name9.Text = "Civil Engineering Drawing";
            }
            if (s_code9.Text == "PCCE7205")
            {
                s_name9.Text = "Survey Field Work-I";
            }
            if (s_code9.Text == "PCCI7303")
            {
                s_name9.Text = "Design & Detailing of Concrete StructureLab";
            }
            if (s_code9.Text == "PCCI7304")
            {
                s_name9.Text = "Design & Detailing of Steel Structure Lab";
            }
            if (s_code9.Text == "PCCI7403")
            {
                s_name9.Text = "Minor Project";
            }
            if (s_code9.Text == "PCEC7201")
            {
                s_name9.Text = "Analog Electronics Circuit Lab.";
            }
            if (s_code9.Text == "PCEC7202")
            {
                s_name9.Text = "Digital Electronics Circuit Lab.";
            }
            if (s_code9.Text == "PCEL7302")
            {
                s_name9.Text = "Electrical Machines Lab-II";
            }
            if (s_code9.Text == "PCEE7304")
            {
                s_name9.Text = "Communication Engineering Lab.";
            }
            if (s_code9.Text == "PCEL7304")
            {
                s_name9.Text = "Machine Design & Simulation Lab.";
            }
            if (s_code9.Text == "PCEE7204")
            {
                s_name9.Text = "Electrical & Electronic Measurement Laboratory";
            }
            if (s_code9.Text == "BECS7212")
            {
                s_name9.Text = "C++ & Object Oriented Programming Laboratory";
            }
            if (s_code9.Text == "PCEC7305")
            {
                s_name9.Text = "Digital Communication Lab.";
            }
            if (s_code9.Text == "PCEI7302")
            {
                s_name9.Text = "Instrumentation Devices and Systems Laboratory";
            }
            if (s_code9.Text == "PCEI7305")
            {
                s_name9.Text = "Instrumentation Systems Design Lab";
            }
            if (s_code9.Text == "BECS7208")
            {
                s_name9.Text = "Data Base Management System Lab.";
            }
            if (s_code9.Text == "HSSM7203")
            {
                s_name9.Text = "Communication & Interpersonal skills for Corporate Readiness Laboratory";
            }
            if (s_code9.Text == "PCME7303")
            {
                s_name9.Text = "Machine Design Project - I";
            }
            if (s_code9.Text == "PCME7306")
            {
                s_name9.Text = "Machine Design Project - II";
            }
            if (s_code9.Text == "PCME7401")
            {
                s_name9.Text = "Refrigeration & Air Conditioning & Mechanical Measurement Lab";
            }
        }
        private void s_code10_TextChanged(object sender, EventArgs e)
        {
            if (s_code10.Text == "HSSM7203")
            {
                s_name10.Text = "Communication & Interpersonal skills for Corporate Readiness Laboratory";
            }
            if (s_code10.Text == "MCS210")
            {
                s_name10.Text = "Seminar";
            }

        }
        private void c_Sem_SelectedIndexChanged(object sender, EventArgs e)
        {
            c_sc1.Items.Clear(); c_sc1.Text = "";
            c_sc2.Items.Clear(); c_sc2.Text = "";
            c_sc3.Items.Clear(); c_sc3.Text = "";
            c_sc4.Items.Clear(); c_sc4.Text = "";
            c_sc5.Items.Clear(); c_sc5.Text = "";
            c_sc6.Items.Clear(); c_sc6.Text = "";
            c_sc7.Items.Clear(); c_sc7.Text = "";
            s_code8.Text = "";
            s_code9.Text = "";
            s_code10.Text = "";
            s_code11.Text = "";
            s_name1.Text = "";
            s_name2.Text = "";
            s_name3.Text = "";
            s_name4.Text = "";
            s_name5.Text = "";
            s_name6.Text = "";
            s_name7.Text = "";
            s_name8.Text = "";
            s_name9.Text = "";
            s_name10.Text = "";
            s_name11.Text = "";

            
            if ((c_branch.SelectedItem.ToString() == "Computer Science & Engg." || c_branch.SelectedItem.ToString() == "Information Technology") && c_Sem.SelectedItem.ToString() == "Semester 7")
            {
                c_sc1.Items.Add("HSSM3401");

                c_sc2.Items.Add("PCCS4401");

                c_sc3.Items.Add("PCCS4402");

                c_sc4.Items.Add("PECS5401");
                c_sc4.Items.Add("PECS5402");
                c_sc4.Items.Add("PECS5403");

                c_sc5.Items.Add("PCIT4401");
                c_sc5.Items.Add("PCIT4402");
                c_sc5.Items.Add("PECS5404");

                c_sc6.Items.Add("PCEC4401");
                c_sc6.Items.Add("PEEC5416");
                c_sc6.Items.Add("PEEC5417");
                c_sc6.Items.Add("FECS6401");

                c_sc7.Items.Add("PCCS7402");

                s_code8.Text = "PCCS7401"; s_code10.Text = ""; s_code9.Text = "";
            }

            if ((c_branch.SelectedItem.ToString() == "Computer Science & Engg." || c_branch.SelectedItem.ToString() == "Information Technology") && c_Sem.SelectedItem.ToString() == "Semester 8")
            {
                c_sc1.Items.Add("HSSM3402");

                c_sc2.Items.Add("PECS5406");
                c_sc2.Items.Add("PECS5407");
                c_sc2.Items.Add("PECS5408");

                c_sc3.Items.Add("PECS5409");
                c_sc3.Items.Add("PECS5410");
                c_sc3.Items.Add("PECS5411");

                c_sc4.Items.Add("PEEC5418");
                c_sc4.Items.Add("PEEI5405");
                c_sc4.Items.Add("PCBM4402");

                c_sc5.Items.Add("PEEI5404");
                c_sc5.Items.Add("PEME5407");
                c_sc5.Items.Add("PEEI5403");

                c_sc6.Items.Add("PCCS7403");

                c_sc7.Items.Add("PCCS7404");

                s_code8.Text = ""; s_code10.Text = ""; s_code9.Text = "";
            }
            if ((c_branch.SelectedItem.ToString() == "Computer Science & Engg." || c_branch.SelectedItem.ToString() == "Information Technology") && c_Sem.SelectedItem.ToString() == "Semester 5")
            {
                c_sc1.Items.Add("HSSM3301");
                c_sc1.Items.Add("HSSM3302");

                c_sc2.Items.Add("PCCS4301");

                c_sc3.Items.Add("PCCS4302");

                c_sc4.Items.Add("PCIT4303");


                c_sc5.Items.Add("PECS5301");
                c_sc5.Items.Add("PECS5302");
                c_sc5.Items.Add("PECS5304");

                c_sc6.Items.Add("PCBM4302");
                c_sc6.Items.Add("PCEC4302");
                c_sc6.Items.Add("PCEC4303");


                c_sc7.Items.Add("PCCS7301");

                s_code8.Text = "PCCS7302";

                s_code9.Text = "PCCS7303"; s_code10.Text = "";
            }
            if ((c_branch.SelectedItem.ToString() == "Computer Science & Engg." || c_branch.SelectedItem.ToString() == "Information Technology") && c_Sem.SelectedItem.ToString() == "Semester 6")
            {
                c_sc1.Items.Add("HSSM3301");
                c_sc1.Items.Add("HSSM3302");

                c_sc2.Items.Add("PCEL4303");

                c_sc3.Items.Add("PCCS4304");

                c_sc4.Items.Add("PCCS4305");


                c_sc5.Items.Add("PCIT4301");
                c_sc5.Items.Add("PECS5303");
                c_sc5.Items.Add("PCEC4304");

                c_sc6.Items.Add("PCEC4305");
                c_sc6.Items.Add("PCEE4304");
                c_sc6.Items.Add("PEME5305");
                c_sc6.Items.Add("PEEE5301");


                c_sc7.Items.Add("PCEL7303");

                s_code8.Text = "PCCS7304";
                s_code10.Text = "";
                s_code9.Text = "PCCS7307";
            }
            if ((c_branch.SelectedItem.ToString() == "Computer Science & Engg." || c_branch.SelectedItem.ToString() == "Information Technology") && c_Sem.SelectedItem.ToString() == "Semester 3")
            {
                c_sc1.Items.Add("BSCM1205");


                c_sc2.Items.Add("BEES2211");

                c_sc3.Items.Add("BSCP1207");

                c_sc4.Items.Add("BECS2207");


                c_sc5.Items.Add("PCEC4201");


                c_sc6.Items.Add("HSSM3204");
                c_sc6.Items.Add("HSSM3205");



                c_sc7.Items.Add("HSSM7203");

                s_code8.Text = "PCEC7201";

                s_code9.Text = "BECS7207"; s_code10.Text = "";
            }
            if ((c_branch.SelectedItem.ToString() == "Computer Science & Engg." || c_branch.SelectedItem.ToString() == "Information Technology") && c_Sem.SelectedItem.ToString() == "Semester 4")
            {
                c_sc1.Items.Add("BSCM1211");


                c_sc2.Items.Add("PCCS4203");

                c_sc3.Items.Add("PCCS4204");

                c_sc4.Items.Add("PCCS4205");


                c_sc5.Items.Add("PCEC4202");


                c_sc6.Items.Add("HSSM3204");
                c_sc6.Items.Add("HSSM3205");



                c_sc7.Items.Add("PCEC7202");

                s_code8.Text = "PCCS7204";

                s_code9.Text = "PCCS7205"; s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "Civil Engg." && c_Sem.SelectedItem.ToString() == "Semester 3")
            {
                c_sc1.Items.Add("BSCM1205");

                c_sc2.Items.Add("HSSM3204");
                c_sc2.Items.Add("HSSM3205");


                c_sc3.Items.Add("BECS2212");

                c_sc4.Items.Add("PCME4202");


                c_sc5.Items.Add("PCCE4203");


                c_sc6.Items.Add("PCME4201");




                c_sc7.Items.Add("BECS7212");

                s_code8.Text = "HSSM7203";

                s_code9.Text = "PCCE7207"; s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "Civil Engg." && c_Sem.SelectedItem.ToString() == "Semester 4")
            {
                c_sc1.Items.Add("BSCM1210");

                c_sc2.Items.Add("HSSM3204");
                c_sc2.Items.Add("HSSM3205");


                c_sc3.Items.Add("PCCE4204");

                c_sc4.Items.Add("PCCE4205");


                c_sc5.Items.Add("PCCE4206");


                c_sc6.Items.Add("FEEC2216");
                c_sc6.Items.Add("FECS2208");
                c_sc6.Items.Add("FEEE2215");




                c_sc7.Items.Add("PCCE7209");

                s_code8.Text = "PCCE7210";

                s_code9.Text = "PCCE7205"; s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "Civil Engg." && c_Sem.SelectedItem.ToString() == "Semester 5")
            {
                c_sc1.Items.Add("HSSM3303");
                c_sc1.Items.Add("HSSM3301");

                c_sc2.Items.Add("PCCI4303");


                c_sc3.Items.Add("PCCI4302");

                c_sc4.Items.Add("PCCI4301");


                c_sc5.Items.Add("PECI5303");
                c_sc5.Items.Add("PECI5302");

                c_sc6.Items.Add("PCCS4301");
                c_sc6.Items.Add("PCIT4303");
                c_sc6.Items.Add("FESM6302");




                c_sc7.Items.Add("PCCI7301");

                s_code8.Text = "PCCI7302";

                s_code9.Text = "PCCI7303"; s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "Civil Engg." && c_Sem.SelectedItem.ToString() == "Semester 6")
            {
                c_sc1.Items.Add("HSSM3303");
                c_sc1.Items.Add("HSSM3301");

                c_sc2.Items.Add("PCCI4304");


                c_sc3.Items.Add("PCCI4305");

                c_sc4.Items.Add("PECI5301");


                c_sc5.Items.Add("PECI5304");
                c_sc5.Items.Add("PECI5305");

                c_sc6.Items.Add("HSSM3302");
                c_sc6.Items.Add("PEME5308");
                c_sc6.Items.Add("PEIT5301");




                c_sc7.Items.Add("PCCI7305");

                s_code8.Text = "PCCI7306";

                s_code9.Text = "PCCI7304"; s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "Civil Engg." && c_Sem.SelectedItem.ToString() == "Semester 7")
            {
                c_sc1.Items.Add("PCCI4401");


                c_sc2.Items.Add("PCCI4402");


                c_sc3.Items.Add("PECI5401");
                c_sc3.Items.Add("PECI5402");

                c_sc4.Items.Add("PECI5403");
                c_sc4.Items.Add("PECI5404");

                c_sc5.Items.Add("PECI5405");
                c_sc5.Items.Add("PECI5406");

                c_sc6.Items.Add("HSSM3401");
                c_sc6.Items.Add("PEME5408");
                c_sc6.Items.Add("PCCS4401");
                c_sc6.Items.Add("PECS5401");




                c_sc7.Items.Add("PECS5401");

                s_code8.Text = "PCCI7402";

                s_code9.Text = "PCCI7403"; s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "Civil Engg." && c_Sem.SelectedItem.ToString() == "Semester 8")
            {
                c_sc1.Items.Add("PECI5407");
                c_sc1.Items.Add("PECI5408");
                c_sc1.Items.Add("PECI5409");
                c_sc1.Items.Add("PECI5410");

                c_sc2.Items.Add("PECI5411");
                c_sc2.Items.Add("PECI5412");
                c_sc2.Items.Add("PECI5413");
                c_sc2.Items.Add("PECI5414");


                c_sc3.Items.Add("PECI5415");
                c_sc3.Items.Add("PECI5416");
                c_sc3.Items.Add("PECI5417");
                c_sc3.Items.Add("PECI5418");

                c_sc4.Items.Add("HSSM3403");
                c_sc4.Items.Add("PCME4404");
                c_sc4.Items.Add("PETX5412");
                c_sc4.Items.Add("FECE6405");

                c_sc5.Items.Add("PCCI7404");

                c_sc6.Items.Add("PCCI7406");

                c_sc7.Items.Add("PCCI7405");


                s_code9.Text = ""; s_code10.Text = "";
            }
            if ((c_branch.SelectedItem.ToString() == "Electrical  & Electronics Engg." || c_branch.SelectedItem.ToString() == "Electrical Engg.") && c_Sem.SelectedItem.ToString() == "Semester 3")
            {
                c_sc1.Items.Add("BSCM1205");

                c_sc2.Items.Add("BSMS1213");
                c_sc2.Items.Add("BSCP1207");


                c_sc3.Items.Add("HSSM3204");
                c_sc3.Items.Add("HSSM3205");

                c_sc4.Items.Add("BEES2211");


                c_sc5.Items.Add("BECS2212");


                c_sc6.Items.Add("PCEC4201");

                c_sc7.Items.Add("BEES7211");

                s_code8.Text = "BECS7212";

                s_code9.Text = "PCEC7201"; s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "Electrical  & Electronics Engg." && c_Sem.SelectedItem.ToString() == "Semester 4")
            {
                c_sc1.Items.Add("PCEC4205");

                c_sc2.Items.Add("BSMS1213");
                c_sc2.Items.Add("BSCP1207");


                c_sc3.Items.Add("HSSM3204");
                c_sc3.Items.Add("HSSM3205");

                c_sc4.Items.Add("PCEE4203");


                c_sc5.Items.Add("PCEE4204");


                c_sc6.Items.Add("PCEC4202");

                c_sc7.Items.Add("PCEE7203");

                s_code8.Text = "PCEE7204";

                s_code9.Text = "PCEC7202";

                s_code10.Text = "HSSM7203";
            }
            if (c_branch.SelectedItem.ToString() == "Electrical  & Electronics Engg." && c_Sem.SelectedItem.ToString() == "Semester 5")
            {
                c_sc1.Items.Add("HSSM3303");
                c_sc1.Items.Add("HSSM3302");

                c_sc2.Items.Add("PCEC4303");


                c_sc3.Items.Add("PCEL4301");

                c_sc4.Items.Add("PCEL4302");


                c_sc5.Items.Add("PEEC4301");
                c_sc5.Items.Add("PEEL5302");
                c_sc5.Items.Add("PEEL5301");

                c_sc6.Items.Add("FESM6301");
                c_sc6.Items.Add("FEEC6301");
                c_sc6.Items.Add("PCBM4301");
                c_sc6.Items.Add("PCIT4303");

                c_sc7.Items.Add("PCEC7303");

                s_code8.Text = "PCEL7301";

                s_code9.Text = "PCEL7302"; s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "Electrical  & Electronics Engg." && c_Sem.SelectedItem.ToString() == "Semester 6")
            {
                c_sc1.Items.Add("HSSM3303");
                c_sc1.Items.Add("HSSM3302");

                c_sc2.Items.Add("PCEL4303");


                c_sc3.Items.Add("PCEC4304");

                c_sc4.Items.Add("PCEE4304");


                c_sc5.Items.Add("PEME5305");
                c_sc5.Items.Add("PEEE5301");
                c_sc5.Items.Add("PEEL5303");

                c_sc6.Items.Add("PEEC4304");
                c_sc6.Items.Add("PCCS4304");
                c_sc6.Items.Add("FEEE6301");

                c_sc7.Items.Add("PCEL7303");

                s_code8.Text = "PCEC7304";

                s_code9.Text = "PCEE7304"; s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "Electrical  & Electronics Engg." && c_Sem.SelectedItem.ToString() == "Semester 7")
            {
                c_sc1.Items.Add("HSSM3401");

                c_sc2.Items.Add("PCEE4401");


                c_sc3.Items.Add("PEEE5406");
                c_sc3.Items.Add("PEEE5407");
                c_sc3.Items.Add("PCEC4401");
                c_sc3.Items.Add("PEEE5408");
                c_sc3.Items.Add("PEEE5409");

                c_sc4.Items.Add("PEEC5414");
                c_sc4.Items.Add("PEEC5402");
                c_sc4.Items.Add("PCEL4401");


                c_sc5.Items.Add("PEEC5416");
                c_sc5.Items.Add("PEEL5401");
                c_sc5.Items.Add("PEME5407");

                c_sc6.Items.Add("PCEE7401");

                c_sc7.Items.Add("PCEE7402");

                s_code8.Text = "PCEE7403";

                s_code9.Text = "";
                s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "Electrical  & Electronics Engg." && c_Sem.SelectedItem.ToString() == "Semester 8")
            {
                c_sc1.Items.Add("PCEE4402");

                c_sc2.Items.Add("PEEE5410");
                c_sc2.Items.Add("PEEL5403");
                c_sc2.Items.Add("PEEI5402");

                c_sc3.Items.Add("PEEC5418");
                c_sc3.Items.Add("PECS5406");
                c_sc3.Items.Add("PEEI5403");
                c_sc3.Items.Add("PEEC5405");

                c_sc4.Items.Add("FEEE6401");
                c_sc4.Items.Add("HSSM3403");
                c_sc4.Items.Add("PCME4404");


                c_sc5.Items.Add("PCEE7404");

                c_sc6.Items.Add("PCEE7405");

                c_sc7.Items.Add("--Select--"); c_sc7.SelectedIndex = 0;
                

                s_code8.Text = "";

                s_code9.Text = "";
                s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "Electrical Engg." && c_Sem.SelectedItem.ToString() == "Semester 4")
            {
                c_sc1.Items.Add("BEME2209");

                c_sc2.Items.Add("BSMS1213");
                c_sc2.Items.Add("BSCP1207");


                c_sc3.Items.Add("HSSM3204");
                c_sc3.Items.Add("HSSM3205");

                c_sc4.Items.Add("PCEE4203");


                c_sc5.Items.Add("PCEE4204");


                c_sc6.Items.Add("PCEC4202");

                c_sc7.Items.Add("PCEE7203");

                s_code8.Text = "PCEE7204";

                s_code9.Text = "PCEC7202";

                s_code10.Text = "HSSM7203";
            }
            if (c_branch.SelectedItem.ToString() == "Electrical Engg." && c_Sem.SelectedItem.ToString() == "Semester 5")
            {
                c_sc1.Items.Add("HSSM3303");
                c_sc1.Items.Add("HSSM3302");

                c_sc2.Items.Add("PCEC4303");


                c_sc3.Items.Add("PCEL4301");

                c_sc4.Items.Add("PCEL4302");


                c_sc5.Items.Add("PEEC4302");
                c_sc5.Items.Add("PEEL5302");
                c_sc5.Items.Add("PEEL5301");

                c_sc6.Items.Add("FESM6301");
                c_sc6.Items.Add("FEEC6301");
                c_sc6.Items.Add("PCBM4301");
                c_sc6.Items.Add("PCIT4303");

                c_sc7.Items.Add("PCEC7303");

                s_code8.Text = "PCEL7301";

                s_code9.Text = "PCEL7302"; s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "Electrical Engg." && c_Sem.SelectedItem.ToString() == "Semester 6")
            {
                c_sc1.Items.Add("HSSM3303");
                c_sc1.Items.Add("HSSM3302");

                c_sc2.Items.Add("PCEL4303");


                c_sc3.Items.Add("PCEE4301");

                c_sc4.Items.Add("PCEE4302");


                c_sc5.Items.Add("PEEL5303");
                c_sc5.Items.Add("PCEE4304");
                c_sc5.Items.Add("PCEC4304");

                c_sc6.Items.Add("PEEC4304");
                c_sc6.Items.Add("PCCS4304");
                c_sc6.Items.Add("FEEE6301");
                c_sc6.Items.Add("PEME5305");

                c_sc7.Items.Add("PEEL7303");
                c_sc7.Items.Add("PCEE7304");
                c_sc7.Items.Add("PCEC7304");

                s_code8.Text = "PCEL7303";

                s_code9.Text = "PCEL7304"; s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "Electrical Engg." && c_Sem.SelectedItem.ToString() == "Semester 7")
            {
                c_sc1.Items.Add("HSSM3401");

                c_sc2.Items.Add("PCEL4401");


                c_sc3.Items.Add("PEEE5406");//
                c_sc3.Items.Add("PEEL5402");
                c_sc3.Items.Add("PCEC4401");//
                c_sc3.Items.Add("PEEE5408");//
                c_sc3.Items.Add("PEEE5409");//

                c_sc4.Items.Add("PEEE5407");
                c_sc4.Items.Add("PEEL5401");
                c_sc4.Items.Add("PEEC5414");


                c_sc5.Items.Add("PEEC5416");//
                c_sc5.Items.Add("FEEE6402");
                c_sc5.Items.Add("PEME5407");//

                c_sc6.Items.Add("PCEE7401");

                c_sc7.Items.Add("PCEE7402");

                s_code8.Text = "PCEE7403";

                s_code9.Text = "";
                s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "Electrical Engg." && c_Sem.SelectedItem.ToString() == "Semester 8")
            {
                c_sc1.Items.Add("PCEE4402");

                c_sc2.Items.Add("PEEE5410");
                c_sc2.Items.Add("PEEL5403");
                c_sc2.Items.Add("PEEI5402");
                c_sc2.Items.Add("PEEI5403");

                c_sc3.Items.Add("PEEC5418");//
                c_sc3.Items.Add("PECS5406");//
                c_sc3.Items.Add("PEEI5406");
                c_sc3.Items.Add("PEEC5405");//

                c_sc4.Items.Add("FEEE6401");
                c_sc4.Items.Add("HSSM3403");
                c_sc4.Items.Add("PCME4404");


                c_sc5.Items.Add("PCEL7405");

                c_sc6.Items.Add("PCEL7404");

                c_sc7.Items.Add("--Select--"); c_sc7.SelectedIndex = 0;


                s_code8.Text = "";

                s_code9.Text = "";
                s_code10.Text = "";
            }
            if ((c_branch.SelectedItem.ToString() == "Electronics & Telecommunication Engg."||c_branch.SelectedItem.ToString() == "Electonics & Instrumentation Engg.") && c_Sem.SelectedItem.ToString() == "Semester 3")
            {
                c_sc1.Items.Add("BSCM1205");

                c_sc3.Items.Add("BSMS1213");
                c_sc3.Items.Add("BSCP1207");


                c_sc2.Items.Add("HSSM3204");
                c_sc2.Items.Add("HSSM3205");

                c_sc4.Items.Add("BEES2211");


                c_sc5.Items.Add("PCEE4204");


                c_sc6.Items.Add("PCEC4201");

                c_sc7.Items.Add("BEES7211");

                s_code8.Text = "PCEC7201";

                s_code9.Text = "PCEE7204"; s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "Electronics & Telecommunication Engg." && c_Sem.SelectedItem.ToString() == "Semester 4")
            {
                c_sc1.Items.Add("PCEC4205");

                c_sc3.Items.Add("BSMS1213");
                c_sc3.Items.Add("BSCP1207");


                c_sc2.Items.Add("HSSM3204");
                c_sc2.Items.Add("HSSM3205");

                c_sc4.Items.Add("BEEC2214");


                c_sc5.Items.Add("BECS2212");


                c_sc6.Items.Add("PCEC4202");

                c_sc7.Items.Add("BEEC7214");

                s_code8.Text = "PCEC7202";

                s_code9.Text = "BECS7212";

                s_code10.Text = "HSSM7203";
            }
            if (c_branch.SelectedItem.ToString() == "Electronics & Telecommunication Engg." && c_Sem.SelectedItem.ToString() == "Semester 5")
            {
                c_sc1.Items.Add("HSSM3303");
                c_sc1.Items.Add("HSSM3302");

                c_sc2.Items.Add("PCEC4303");


                c_sc3.Items.Add("PCEC4301");

                c_sc4.Items.Add("PCEC4302");

                c_sc5.Items.Add("PEEC4302");
                c_sc5.Items.Add("PEEC4301");//
                c_sc5.Items.Add("PEEC4303");
                c_sc5.Items.Add("PCBM4302");

                c_sc6.Items.Add("HSSM3302");
                c_sc6.Items.Add("FEEC6301");//
                c_sc6.Items.Add("PCBM4301");//
                c_sc6.Items.Add("PCIT4303");//
                c_sc6.Items.Add("FEEC6302");

                c_sc7.Items.Add("PCEC7303");

                s_code8.Text = "PCEL7301";

                s_code9.Text = "PCEL7302"; s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "Electronics & Telecommunication Engg." && c_Sem.SelectedItem.ToString() == "Semester 6")
            {
                c_sc1.Items.Add("HSSM3301");
                c_sc1.Items.Add("HSSM3302");

                c_sc2.Items.Add("PCEC4304");


                c_sc3.Items.Add("PCEC4305");

                c_sc4.Items.Add("PEEC5304");
                c_sc4.Items.Add("PEEC5303");

                c_sc5.Items.Add("PEEC5302");
                c_sc5.Items.Add("PEEC5301");
                c_sc5.Items.Add("PEEC4304");

                c_sc6.Items.Add("PCCS4304");
                c_sc6.Items.Add("FESM6301");
                c_sc6.Items.Add("PEEI5302");
                c_sc6.Items.Add("PCBM4304");
                c_sc6.Items.Add("PEME5305");

                c_sc7.Items.Add("PCEC7304");

                s_code8.Text = "PCEC7306";

                s_code9.Text = "PCEC7305"; s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "Electronics & Telecommunication Engg." && c_Sem.SelectedItem.ToString() == "Semester 7")
            {
                c_sc1.Items.Add("HSSM3401");

                c_sc2.Items.Add("PCEC4401");


                c_sc3.Items.Add("PEEC5416");
                c_sc3.Items.Add("PEEC5417");
                c_sc3.Items.Add("PEEC5414");
                c_sc3.Items.Add("PEEL5401");

                c_sc4.Items.Add("FECE6401");
                c_sc4.Items.Add("PECS5403");
                c_sc4.Items.Add("PEEI5401");
                c_sc4.Items.Add("PCCS4401");

                c_sc5.Items.Add("FECE6402");
                c_sc5.Items.Add("PEEE5407");
                c_sc5.Items.Add("FECE6403");
                c_sc5.Items.Add("PECS5401");

                c_sc6.Items.Add("PCEC7401");

                c_sc7.Items.Add("PCEC7402");

                s_code8.Text = "PCEC7403";

                s_code9.Text = "";
                s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "Electronics & Telecommunication Engg." && c_Sem.SelectedItem.ToString() == "Semester 8")
            {
                c_sc1.Items.Add("PCEC4402");

                c_sc2.Items.Add("PEEI5404");
                c_sc2.Items.Add("PEEC5405");
                c_sc2.Items.Add("PECS5406");
                c_sc2.Items.Add("PEEC5418");


                c_sc3.Items.Add("FECE6404");
                c_sc3.Items.Add("FECE6405");
                c_sc3.Items.Add("PEEI5405");
                c_sc3.Items.Add("PEEI5403");
                c_sc3.Items.Add("PECS5407");

                c_sc4.Items.Add("PCCS7402");
                
                c_sc5.Items.Add("PCEC7404");
               
                c_sc6.Items.Add("PCEC7405");

                c_sc7.Items.Add("--Select--");
                c_sc7.SelectedIndex = 0;
                s_code8.Text = "";

                s_code9.Text = "";
                s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "Electonics & Instrumentation Engg." && c_Sem.SelectedItem.ToString() == "Semester 4")
            {
                c_sc1.Items.Add("BEME2209");

                c_sc3.Items.Add("BSMS1213");
                c_sc3.Items.Add("BSCP1207");


                c_sc2.Items.Add("HSSM3204");
                c_sc2.Items.Add("HSSM3205");

                c_sc4.Items.Add("BEEC2214");


                c_sc5.Items.Add("BECS2212");


                c_sc6.Items.Add("PCEC4202");

                c_sc7.Items.Add("BEEC7214");

                s_code8.Text = "PCEC7202";

                s_code9.Text = "BECS7212";

                s_code10.Text = "HSSM7203";
            }
            if (c_branch.SelectedItem.ToString() == "Electonics & Instrumentation Engg." && c_Sem.SelectedItem.ToString() == "Semester 5")
            {
                c_sc1.Items.Add("HSSM3303");
                c_sc1.Items.Add("HSSM3301");

                c_sc2.Items.Add("PCEI4301");


                c_sc3.Items.Add("PCEC4301");

                c_sc4.Items.Add("PCEI4302");

                c_sc5.Items.Add("PEEI5303");
                c_sc5.Items.Add("PEEC4301");//
                c_sc5.Items.Add("PCEL4301");
                c_sc5.Items.Add("PCBM4302");//

                c_sc6.Items.Add("HSSM3302");
                c_sc6.Items.Add("FEEC6301");
                c_sc6.Items.Add("PCBM4301");
                c_sc6.Items.Add("PCIT4303");
                c_sc6.Items.Add("FEEC6302");

                c_sc7.Items.Add("PCEI7301");

                s_code8.Text = "PCEL7301";

                s_code9.Text = "PCEI7302"; s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "Electonics & Instrumentation Engg." && c_Sem.SelectedItem.ToString() == "Semester 6")
            {
                c_sc1.Items.Add("HSSM3301");
                c_sc1.Items.Add("HSSM3303");

                c_sc2.Items.Add("PCEI4303");


                c_sc3.Items.Add("PCEC4304");

                c_sc4.Items.Add("PCEI4305");

                c_sc5.Items.Add("PEEI5302");
                c_sc5.Items.Add("PEEI5301");
                c_sc5.Items.Add("PEEE5301");
                c_sc5.Items.Add("PEEI5304");

                c_sc6.Items.Add("PCCS4304");
                c_sc6.Items.Add("FESM6301");
                c_sc6.Items.Add("PEEI5302");
                c_sc6.Items.Add("PCBM4304");
                c_sc6.Items.Add("PEME5305");

                c_sc7.Items.Add("PCEC7304");

                s_code8.Text = "PCEI7303";

                s_code9.Text = "PCEI7305"; s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "Electonics & Instrumentation Engg." && c_Sem.SelectedItem.ToString() == "Semester 7")
            {
                c_sc1.Items.Add("HSSM3401");

                c_sc2.Items.Add("PCEC4401");


                c_sc3.Items.Add("PEEC5416");//
                c_sc3.Items.Add("PEEI5401");
                c_sc3.Items.Add("PEEC5414");
                c_sc3.Items.Add("PEEL5401");//

                c_sc4.Items.Add("FECE6401");//
                c_sc4.Items.Add("PECS5403");//
                c_sc4.Items.Add("FEEI6401");
                c_sc4.Items.Add("PCCS4401");//
                c_sc4.Items.Add("FEEI6402");

                c_sc5.Items.Add("FECE6402");
                c_sc5.Items.Add("PEEE5407");
                c_sc5.Items.Add("FECE6403");
                c_sc5.Items.Add("PECS5401");

                c_sc6.Items.Add("PCEC7401");

                c_sc7.Items.Add("PCEI7402");

                s_code8.Text = "PCEI7403";

                s_code9.Text = "";
                s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "Electonics & Instrumentation Engg." && c_Sem.SelectedItem.ToString() == "Semester 8")
            {
                c_sc1.Items.Add("PEEI5404");
                c_sc1.Items.Add("PECS5406");
                c_sc1.Items.Add("PEEI5405");
                c_sc1.Items.Add("PEEI5406");

                c_sc2.Items.Add("PEEC5405");
                c_sc2.Items.Add("PEEI5402");
                c_sc2.Items.Add("PEEI5403");
                

                c_sc3.Items.Add("FECE6404");//
                c_sc3.Items.Add("FECE6405");//
                c_sc3.Items.Add("PEEC5418");
                c_sc3.Items.Add("PEEI5403");
                c_sc3.Items.Add("PECS5407");//

                c_sc4.Items.Add("PCEI7401");

                c_sc5.Items.Add("PCEI7404");

                c_sc6.Items.Add("PCEI7405");

                c_sc7.Items.Add("--Select--");
                c_sc7.SelectedIndex = 0;
                s_code8.Text = "";

                s_code9.Text = "";
                s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "Mechanical Engg." && c_Sem.SelectedItem.ToString() == "Semester 3")
            {
                c_sc1.Items.Add("BSCM1205");

                c_sc2.Items.Add("HSSM3204");
                c_sc2.Items.Add("HSSM3205");


                c_sc3.Items.Add("PCME4201");

                c_sc4.Items.Add("PCME4202");


                c_sc5.Items.Add("PCME4203");


                c_sc6.Items.Add("BECS2208");




                c_sc7.Items.Add("PCME7202");
                c_sc7.Items.Add("PCME7203");

                s_code8.Text = "PCME7201";

                s_code9.Text = "BECS7208"; s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "Mechanical Engg." && c_Sem.SelectedItem.ToString() == "Semester 4")
            {
                c_sc1.Items.Add("BSCM1210");

                c_sc2.Items.Add("HSSM3204");
                c_sc2.Items.Add("HSSM3205");


                c_sc3.Items.Add("PCME4204");

                c_sc4.Items.Add("PCME4205");


                c_sc5.Items.Add("PCME4206");


                c_sc6.Items.Add("BEEE2215");
                c_sc6.Items.Add("PCCE4205");
                c_sc6.Items.Add("BECS2212");
                c_sc6.Items.Add("BEEC2216");



                c_sc7.Items.Add("PCME7203");
                c_sc7.Items.Add("PCME7202");

                s_code8.Text = "PCME7204";

                s_code9.Text = "HSSM7203"; s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "Mechanical Engg." && c_Sem.SelectedItem.ToString() == "Semester 5")
            {
                c_sc1.Items.Add("PCME4301");

                c_sc2.Items.Add("PCME4303");
                
                c_sc3.Items.Add("PCME4304");

                c_sc4.Items.Add("PCME4302");


                c_sc5.Items.Add("PEME5301");
                c_sc5.Items.Add("PEME5302");
                c_sc5.Items.Add("PEME5303");
                c_sc5.Items.Add("PEME5304");


                c_sc6.Items.Add("FESM6302");
                c_sc6.Items.Add("PCEC4301");
                c_sc6.Items.Add("FEME6302");
                c_sc6.Items.Add("PCBM4301");
                c_sc6.Items.Add("PCIT4303");


                c_sc7.Items.Add("PCME7302");

                s_code8.Text = "PCME7301";

                s_code9.Text = "PCME7303"; s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "Mechanical Engg." && c_Sem.SelectedItem.ToString() == "Semester 6")
            {
                c_sc1.Items.Add("HSSM3302");

                c_sc2.Items.Add("PCME4307");

                c_sc3.Items.Add("PCME4306");

                c_sc4.Items.Add("PCME4305");


                c_sc5.Items.Add("PEME5305");
                c_sc5.Items.Add("PEME5306");
                c_sc5.Items.Add("PEME5307");
                c_sc5.Items.Add("PEME5308");


                c_sc6.Items.Add("FEME6301");
                c_sc6.Items.Add("PCEC4304");
                c_sc6.Items.Add("PCIT4301");
                c_sc6.Items.Add("PECS5303");
                c_sc6.Items.Add("PEIT5301");


                c_sc7.Items.Add("PCME7305");

                s_code8.Text = "PCME7307";

                s_code9.Text = "PCME7306"; s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "Mechanical Engg." && c_Sem.SelectedItem.ToString() == "Semester 7")
            {
                c_sc1.Items.Add("PCME4401");

                c_sc2.Items.Add("PCME4402");

                c_sc3.Items.Add("PCME4403");

                c_sc4.Items.Add("PEME5401");
                c_sc4.Items.Add("PEME5402");
                c_sc4.Items.Add("PEME5403");
                c_sc4.Items.Add("PEME5404");


                c_sc5.Items.Add("PEME5405");
                c_sc5.Items.Add("PEME5406");
                c_sc5.Items.Add("PEME5407");
                c_sc5.Items.Add("PEME5408");


                c_sc6.Items.Add("FEME6401");
                c_sc6.Items.Add("PEEE5407");
                c_sc6.Items.Add("PEEE5406");
                c_sc6.Items.Add("HSSM3401");

                c_sc7.Items.Add("PCME7402");

                s_code8.Text = "PCME7403";

                s_code9.Text = "PCME7401"; s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "Mechanical Engg." && c_Sem.SelectedItem.ToString() == "Semester 8")
            {
                c_sc1.Items.Add("HSSM3402");

                c_sc2.Items.Add("PCME4404");

                c_sc3.Items.Add("PEME5409");
                c_sc3.Items.Add("PEME5410");
                c_sc3.Items.Add("PEME5411");
                c_sc3.Items.Add("PEME5412");
                c_sc3.Items.Add("PEME5413");

                c_sc4.Items.Add("PETX5412");
                c_sc4.Items.Add("HSSM3403");
                c_sc4.Items.Add("PECS5407");
                c_sc4.Items.Add("PEEI5405");


                c_sc5.Items.Add("PCME7404");

                c_sc6.Items.Add("PCME7405");

                c_sc7.Items.Add("PCME7406");

                s_code8.Text = "PCME7407";

                s_code9.Text = ""; s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "MCA" && c_Sem.SelectedItem.ToString() == "Semester 1")
            {
                c_sc1.Items.Add("MCC101");

                c_sc2.Items.Add("MCC102");

                c_sc3.Items.Add("MCC103");

                c_sc4.Items.Add("MCC104");

                c_sc5.Items.Add("MCC105");

                c_sc6.Items.Add("MCC106");

                c_sc7.Items.Add("MCC107");

                s_code8.Text = "MCL108";

                s_code9.Text = "MCL109"; s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "MCA" && c_Sem.SelectedItem.ToString() == "Semester 2")
            {
                c_sc1.Items.Add("MCC201");

                c_sc2.Items.Add("MCC202");

                c_sc3.Items.Add("MCC203");

                c_sc4.Items.Add("MCC204");

                c_sc5.Items.Add("MCC205");

                c_sc6.Items.Add("MCC206");

                c_sc7.Items.Add("MCL207");

                s_code8.Text = "MCL208";

                s_code9.Text = "MCL209"; s_code10.Text = "MCS210";
            }
            if (c_branch.SelectedItem.ToString() == "MCA" && c_Sem.SelectedItem.ToString() == "Semester 3")
            {
                c_sc1.Items.Add("MCC301");

                c_sc2.Items.Add("MCC302");

                c_sc3.Items.Add("MCC303");

                c_sc4.Items.Add("MCC304");

                c_sc5.Items.Add("MCC305");

                c_sc6.Items.Add("MCC306");

                c_sc7.Items.Add("MCL307");

                s_code8.Text = "MCL308";

                s_code9.Text = "MCL309"; s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "MCA" && c_Sem.SelectedItem.ToString() == "Semester 4")
            {
                c_sc1.Items.Add("MCC401");

                c_sc2.Items.Add("MCC402");

                c_sc3.Items.Add("MCC403");

                c_sc4.Items.Add("MCC404");

                c_sc5.Items.Add("MCC405");

                c_sc6.Items.Add("MCC406");

                c_sc7.Items.Add("MCL407");

                s_code8.Text = "MCL408";

                s_code9.Text = "MCS409"; s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "MCA" && c_Sem.SelectedItem.ToString() == "Semester 5")
            {
                c_sc1.Items.Add("MCC501");

                c_sc2.Items.Add("MCC502");

                c_sc3.Items.Add("MCC503");

                c_sc4.Items.Add("MCC504");

                c_sc5.Items.Add("MCE505");
                c_sc5.Items.Add("MCE506");
                c_sc5.Items.Add("MCE507");
                c_sc5.Items.Add("MCE508");

                c_sc6.Items.Add("MCE509");
                c_sc6.Items.Add("MCE510");
                c_sc6.Items.Add("MCE511");
                c_sc6.Items.Add("MCE512");

                c_sc7.Items.Add("MCA513");

                s_code8.Text = "MCL514";

                s_code9.Text = "MCV515"; s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "MCA" && c_Sem.SelectedItem.ToString() == "Semester 6")
            {
                c_sc1.Items.Add("MCC501");

                c_sc2.Items.Add("--Select--");

                c_sc3.Items.Add("--Select--");

                c_sc4.Items.Add("--Select--");

                c_sc5.Items.Add("--Select--");

                c_sc6.Items.Add("--Select--");

                c_sc7.Items.Add("--Select--");

                s_code8.Text = "";

                s_code9.Text = ""; s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "MBA" && c_Sem.SelectedItem.ToString() == "Semester 1")
            {
                c_sc1.Items.Add("MGT-101");

                c_sc2.Items.Add("MGT-102");

                c_sc3.Items.Add("MGT-103");

                c_sc4.Items.Add("MGT-104");

                c_sc5.Items.Add("MGT-105");

                c_sc6.Items.Add("MGT-106");

                c_sc7.Items.Add("MGT-107");

                s_code8.Text = "MGT-108";

                s_code9.Text = "MGT-109"; s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "MBA" && c_Sem.SelectedItem.ToString() == "Semester 2")
            {
                c_sc1.Items.Add("MGT-201");

                c_sc2.Items.Add("MGT-202");

                c_sc3.Items.Add("MGT-203");

                c_sc4.Items.Add("MGT-204");

                c_sc5.Items.Add("MGT-205");

                c_sc6.Items.Add("MGT-206");

                c_sc7.Items.Add("MGT-207");

                s_code8.Text = "MGT-208";

                s_code9.Text = "MGT-209"; s_code10.Text = "";
            }
            if (c_branch.SelectedItem.ToString() == "MBA" && c_Sem.SelectedItem.ToString() == "Semester 3")
            {
                c_sc1.Items.Add("MGT-301");

                c_sc2.Items.Add("MGT-302");

                c_sc3.Items.Add("MGT-303-Consumer Behavior (CB)");
                c_sc3.Items.Add("MGT-303-Sales and Distribution Management (SDM)");
                c_sc3.Items.Add("MGT-303-Services Marketing (SM)");
                c_sc3.Items.Add("MGT-303-Retail Management (RM)");

                c_sc4.Items.Add("MGT-304");

                c_sc5.Items.Add("MGT-305");

                c_sc6.Items.Add("MGT-306");

                c_sc7.Items.Add("MGT-307");

                s_code8.Text = "MGT-308";

                s_code9.Text = ""; s_code10.Text = "";
            }
        }

        private void c_branch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void assign_subject_Load(object sender, EventArgs e)
        {

        }

        private void assign_subject_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are You Sure", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Application.Exit();
               assign_subject a = new assign_subject();
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
