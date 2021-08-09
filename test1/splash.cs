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
    public partial class splash : Form
    {
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        public splash()
        {
            InitializeComponent();
            t.Interval = 5000;
            t.Tick+=new EventHandler(t_Tick);
            t.Start();
        }
       public  void t_Tick(object sender, EventArgs e)
        {

            this.Close();

        }  
        private void splash_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
