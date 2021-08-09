using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test1
{
    public partial class addstud_details : Form
    {
        public addstud_details()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 fr = new Form1();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
           home fr = new home();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_stud_singl fr = new add_stud_singl();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are You Sure", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (MessageBox.Show("Are You Sure", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addstud_details_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            addstud_bulk fr = new addstud_bulk();
            fr.Show();
        }

        private void addstud_details_Load(object sender, EventArgs e)
        {

        }

        private void addstud_details_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are You Sure", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
             //   Application.Exit();
                addstud_details a = new addstud_details();
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
