namespace test1
{
    partial class enable_new_session
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.b_ok = new System.Windows.Forms.Button();
            this.t_pwd = new System.Windows.Forms.TextBox();
            this.t_uid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.b_check = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_sess = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.b_allow = new System.Windows.Forms.Button();
            this.b_assign = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.b_ok);
            this.panel1.Controls.Add(this.t_pwd);
            this.panel1.Controls.Add(this.t_uid);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(70, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 300);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 57);
            this.label5.TabIndex = 6;
            this.label5.Text = "Welcome";
            this.label5.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "User Login";
            // 
            // b_ok
            // 
            this.b_ok.Location = new System.Drawing.Point(151, 195);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(75, 23);
            this.b_ok.TabIndex = 4;
            this.b_ok.Text = "OK";
            this.b_ok.UseVisualStyleBackColor = true;
            this.b_ok.Click += new System.EventHandler(this.b_ok_Click);
            // 
            // t_pwd
            // 
            this.t_pwd.Location = new System.Drawing.Point(151, 149);
            this.t_pwd.Name = "t_pwd";
            this.t_pwd.PasswordChar = '*';
            this.t_pwd.Size = new System.Drawing.Size(100, 20);
            this.t_pwd.TabIndex = 3;
            // 
            // t_uid
            // 
            this.t_uid.Location = new System.Drawing.Point(151, 95);
            this.t_uid.Name = "t_uid";
            this.t_uid.Size = new System.Drawing.Size(100, 20);
            this.t_uid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1044, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "&Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(434, 301);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 300);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(706, 298);
            this.dataGridView1.TabIndex = 0;
            // 
            // b_check
            // 
            this.b_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_check.Location = new System.Drawing.Point(435, 171);
            this.b_check.Name = "b_check";
            this.b_check.Size = new System.Drawing.Size(152, 54);
            this.b_check.TabIndex = 0;
            this.b_check.Text = "Check list of eligible students";
            this.b_check.UseVisualStyleBackColor = true;
            this.b_check.Visible = false;
            this.b_check.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(919, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(449, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(285, 39);
            this.label13.TabIndex = 55;
            this.label13.Text = "Enable new Session";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::test1.Properties.Resources.bcet;
            this.pictureBox1.Location = new System.Drawing.Point(70, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txt_sess
            // 
            this.txt_sess.Location = new System.Drawing.Point(795, 205);
            this.txt_sess.Name = "txt_sess";
            this.txt_sess.Size = new System.Drawing.Size(125, 20);
            this.txt_sess.TabIndex = 56;
            this.txt_sess.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(702, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Session";
            this.label4.Visible = false;
            // 
            // b_allow
            // 
            this.b_allow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_allow.Location = new System.Drawing.Point(966, 171);
            this.b_allow.Name = "b_allow";
            this.b_allow.Size = new System.Drawing.Size(134, 54);
            this.b_allow.TabIndex = 58;
            this.b_allow.Text = "Allow them for registration";
            this.b_allow.UseVisualStyleBackColor = true;
            this.b_allow.Visible = false;
            this.b_allow.Click += new System.EventHandler(this.b_allow_Click);
            // 
            // b_assign
            // 
            this.b_assign.Location = new System.Drawing.Point(967, 622);
            this.b_assign.Name = "b_assign";
            this.b_assign.Size = new System.Drawing.Size(175, 59);
            this.b_assign.TabIndex = 59;
            this.b_assign.Text = "Assign subjects";
            this.b_assign.UseVisualStyleBackColor = true;
            this.b_assign.Visible = false;
            this.b_assign.Click += new System.EventHandler(this.b_assign_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(669, 259);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(173, 23);
            this.progressBar1.TabIndex = 60;
            this.progressBar1.Visible = false;
            // 
            // enable_new_session
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 741);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.b_assign);
            this.Controls.Add(this.b_allow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_sess);
            this.Controls.Add(this.b_check);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "enable_new_session";
            this.Text = "Enable new Session";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.enable_new_session_FormClosing);
            this.Load += new System.EventHandler(this.enable_new_session_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_ok;
        private System.Windows.Forms.TextBox t_pwd;
        private System.Windows.Forms.TextBox t_uid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button b_check;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_sess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b_allow;
        private System.Windows.Forms.Button b_assign;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}