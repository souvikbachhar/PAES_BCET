using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks.Printing;

namespace test1
{
    public partial class re_reg_print : Form
    {
        public re_reg_print(string rno, string nm, string br, string sem, string sc1, string s1, string sc2, string s2, string sc3, string s3, string sc4, string s4, string sc5, string s5, string sc6, string s6, string sc7, string s7, string sc8, string s8, string sc9, string s9, string sc10, string s10, string tot, string sc11, string s11, string roll, string dt,string ree)
        {
            InitializeComponent();
            l_regno.Text = rno;
            label1.Text = nm;
            label4.Text = br;
            if (sem[9] == '3')
            {
                label5.Text = sem[9] + "RD";
                label6.Text = "( THIRD";
            }
            else if (sem[9] == '2')
            {
                label5.Text = sem[9] + "ND"; label6.Text = "( SECOND";
            }
            
            else if (sem[9] == '4')
            {
                label5.Text = sem[9] + "TH"; label6.Text = "( FOURTH";
            }
            else if (sem[9] == '5')
            {
                label5.Text = sem[9] + "TH"; label6.Text = "( FIFTH";
            }
            else if (sem[9] == '6')
            {
                label5.Text = sem[9] + "TH"; label6.Text = "( SIXTH";
            }
            else if (sem[9] == '7')
            {
                label5.Text = sem[9] + "TH"; label6.Text = "( SEVENTH";
            }
            else if (sem[9] == '8')
            {
                label5.Text = sem[9] + "TH"; label6.Text = "( EIGHTH";
            }

            label7.Text = sc1; label8.Text = s1;
            label9.Text = sc2; label10.Text = s2;
            label11.Text = sc3; label12.Text = s3;
            label13.Text = sc4; label14.Text = s4;
            label15.Text = sc5; label16.Text = s5;
            label17.Text = sc6; label18.Text = s6;
            label19.Text = sc7; label20.Text = s7;
            label21.Text = sc8; label22.Text = s8;
            label23.Text = sc9; label24.Text = s9;
            label25.Text = sc10; label26.Text = s10;
            label27.Text = sc11; label29.Text = s11;
            label28.Text = tot;
            //DateTime d = DateTime.Now;
            label30.Text = dt;
            label31.Text = dt;
            label44.Text = dt;
            label32.Text = nm;
            label33.Text = roll;
            label45.Text = roll;
            label34.Text = br;
            label35.Text = rno; label41.Text = ree;
            label43.Text = ree;

            label36.Text = sem;
            label37.Text = label5.Text;
            if (tot == "1500")
            {
                label39.Text = "";
                label40.Text = "";
                label38.Text = "One Thousand Five Hundred Only";
                label42.Text = "Cash :1500/-(in Rupees)One thousand five Hundred Rupees";
            }
            else if (tot == "2000")
            {
                label39.Text = "Fine";
                label40.Text = "500";
                label38.Text = "Two Thousand Hundred Only";
                label42.Text = "Cash :2000/-(in Rupees)Two Thousand Rupees";
                }
            else if (tot == "2500")
            {
                label39.Text = "Fine";
                label40.Text = "1000";
                label38.Text = "Two Thousand Five Hundred Only";
                label42.Text = "Cash :2500/-(in Rupees)Two thousand five Hundred Rupees";
            }
            if (br == "MBA")
            {
                label3.Text = "MBA";
            }
            else if (br == "MCA")
            {
                label3.Text = "MCA";
            }
            else
            {
                label3.Text = "B.Tech";
            }
           
        }

        private void re_reg_print_Load(object sender, EventArgs e)
        {

        }

        private void b_print_Click(object sender, EventArgs e)
        {

            b_print.Visible = false;
            b_back.Visible = false;
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
            b_print.Visible = true;
            b_back.Visible = true;
            this.Hide();
            re_print r = new re_print();
            r.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void b_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            re_print r = new re_print();
            r.Show();

        }

        private void re_reg_print_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            re_print r = new re_print();
            r.Show();
        }
    }
}
