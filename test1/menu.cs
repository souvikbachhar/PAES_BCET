﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test1
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration nnn = new Registration();
            nnn.MdiParent = this;
            nnn.Show();
        }
    }
}
