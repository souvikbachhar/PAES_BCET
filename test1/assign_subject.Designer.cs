namespace test1
{
    partial class assign_subject
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(assign_subject));
            this.button2 = new System.Windows.Forms.Button();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.c_Sem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.c_branch = new System.Windows.Forms.ComboBox();
            this.c_sc1 = new System.Windows.Forms.ComboBox();
            this.s_code8 = new System.Windows.Forms.TextBox();
            this.s_code9 = new System.Windows.Forms.TextBox();
            this.s_code10 = new System.Windows.Forms.TextBox();
            this.s_code11 = new System.Windows.Forms.TextBox();
            this.s_name1 = new System.Windows.Forms.TextBox();
            this.s_name11 = new System.Windows.Forms.TextBox();
            this.s_name10 = new System.Windows.Forms.TextBox();
            this.s_name9 = new System.Windows.Forms.TextBox();
            this.s_name8 = new System.Windows.Forms.TextBox();
            this.s_name7 = new System.Windows.Forms.TextBox();
            this.s_name6 = new System.Windows.Forms.TextBox();
            this.s_name5 = new System.Windows.Forms.TextBox();
            this.s_name2 = new System.Windows.Forms.TextBox();
            this.s_name3 = new System.Windows.Forms.TextBox();
            this.s_name4 = new System.Windows.Forms.TextBox();
            this.c_sc2 = new System.Windows.Forms.ComboBox();
            this.c_sc3 = new System.Windows.Forms.ComboBox();
            this.c_sc4 = new System.Windows.Forms.ComboBox();
            this.c_sc5 = new System.Windows.Forms.ComboBox();
            this.c_sc6 = new System.Windows.Forms.ComboBox();
            this.c_sc7 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.b_assign = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.b_print = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1102, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1165, 566);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(938, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "&Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Semester";
            // 
            // c_Sem
            // 
            this.c_Sem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.c_Sem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_Sem.FormattingEnabled = true;
            this.c_Sem.Items.AddRange(new object[] {
            "--Select--",
            "Semester 1",
            "Semester 2",
            "Semester 3",
            "Semester 4",
            "Semester 5",
            "Semester 6",
            "Semester 7",
            "Semester 8"});
            this.c_Sem.Location = new System.Drawing.Point(614, 139);
            this.c_Sem.Name = "c_Sem";
            this.c_Sem.Size = new System.Drawing.Size(240, 21);
            this.c_Sem.TabIndex = 14;
            this.c_Sem.Text = "--Select--";
            this.c_Sem.SelectedIndexChanged += new System.EventHandler(this.c_Sem_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(446, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Branch";
            // 
            // c_branch
            // 
            this.c_branch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.c_branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_branch.FormattingEnabled = true;
            this.c_branch.Items.AddRange(new object[] {
            "--Select--",
            "Computer Science & Engg.",
            "Electrical Engg.",
            "Electronics & Telecommunication Engg.",
            "Information Technology",
            "Mechanical Engg.",
            "Civil Engg.",
            "Electonics & Instrumentation Engg.",
            "Electrical  & Electronics Engg.",
            "MBA",
            "MCA"});
            this.c_branch.Location = new System.Drawing.Point(614, 102);
            this.c_branch.Name = "c_branch";
            this.c_branch.Size = new System.Drawing.Size(240, 21);
            this.c_branch.TabIndex = 19;
            this.c_branch.Text = "--Select--";
            this.c_branch.SelectedIndexChanged += new System.EventHandler(this.c_branch_SelectedIndexChanged);
            // 
            // c_sc1
            // 
            this.c_sc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.c_sc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_sc1.FormattingEnabled = true;
            this.c_sc1.Location = new System.Drawing.Point(3, 3);
            this.c_sc1.Name = "c_sc1";
            this.c_sc1.Size = new System.Drawing.Size(255, 21);
            this.c_sc1.TabIndex = 38;
            this.c_sc1.Text = "--Select--";
            this.c_sc1.SelectedIndexChanged += new System.EventHandler(this.c_sc1_SelectedIndexChanged);
            // 
            // s_code8
            // 
            this.s_code8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.s_code8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_code8.Location = new System.Drawing.Point(3, 143);
            this.s_code8.Name = "s_code8";
            this.s_code8.Size = new System.Drawing.Size(255, 20);
            this.s_code8.TabIndex = 24;
            this.s_code8.TextChanged += new System.EventHandler(this.s_code8_TextChanged);
            // 
            // s_code9
            // 
            this.s_code9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.s_code9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_code9.Location = new System.Drawing.Point(3, 163);
            this.s_code9.Name = "s_code9";
            this.s_code9.Size = new System.Drawing.Size(255, 20);
            this.s_code9.TabIndex = 25;
            this.s_code9.TextChanged += new System.EventHandler(this.s_code9_TextChanged);
            // 
            // s_code10
            // 
            this.s_code10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.s_code10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_code10.Location = new System.Drawing.Point(3, 183);
            this.s_code10.Name = "s_code10";
            this.s_code10.Size = new System.Drawing.Size(255, 20);
            this.s_code10.TabIndex = 29;
            this.s_code10.TextChanged += new System.EventHandler(this.s_code10_TextChanged);
            // 
            // s_code11
            // 
            this.s_code11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.s_code11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_code11.Location = new System.Drawing.Point(3, 203);
            this.s_code11.Name = "s_code11";
            this.s_code11.Size = new System.Drawing.Size(255, 20);
            this.s_code11.TabIndex = 28;
            // 
            // s_name1
            // 
            this.s_name1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.s_name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_name1.Location = new System.Drawing.Point(264, 3);
            this.s_name1.Name = "s_name1";
            this.s_name1.Size = new System.Drawing.Size(421, 20);
            this.s_name1.TabIndex = 27;
            // 
            // s_name11
            // 
            this.s_name11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.s_name11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_name11.Location = new System.Drawing.Point(264, 203);
            this.s_name11.Name = "s_name11";
            this.s_name11.Size = new System.Drawing.Size(421, 20);
            this.s_name11.TabIndex = 37;
            // 
            // s_name10
            // 
            this.s_name10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.s_name10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_name10.Location = new System.Drawing.Point(264, 183);
            this.s_name10.Name = "s_name10";
            this.s_name10.Size = new System.Drawing.Size(421, 20);
            this.s_name10.TabIndex = 36;
            // 
            // s_name9
            // 
            this.s_name9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.s_name9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_name9.Location = new System.Drawing.Point(264, 163);
            this.s_name9.Name = "s_name9";
            this.s_name9.Size = new System.Drawing.Size(421, 20);
            this.s_name9.TabIndex = 35;
            // 
            // s_name8
            // 
            this.s_name8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.s_name8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_name8.Location = new System.Drawing.Point(264, 143);
            this.s_name8.Name = "s_name8";
            this.s_name8.Size = new System.Drawing.Size(421, 20);
            this.s_name8.TabIndex = 34;
            // 
            // s_name7
            // 
            this.s_name7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.s_name7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_name7.Location = new System.Drawing.Point(264, 123);
            this.s_name7.Name = "s_name7";
            this.s_name7.Size = new System.Drawing.Size(421, 20);
            this.s_name7.TabIndex = 33;
            // 
            // s_name6
            // 
            this.s_name6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.s_name6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_name6.Location = new System.Drawing.Point(264, 103);
            this.s_name6.Name = "s_name6";
            this.s_name6.Size = new System.Drawing.Size(421, 20);
            this.s_name6.TabIndex = 32;
            // 
            // s_name5
            // 
            this.s_name5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.s_name5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_name5.Location = new System.Drawing.Point(264, 83);
            this.s_name5.Name = "s_name5";
            this.s_name5.Size = new System.Drawing.Size(421, 20);
            this.s_name5.TabIndex = 31;
            // 
            // s_name2
            // 
            this.s_name2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.s_name2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_name2.Location = new System.Drawing.Point(264, 23);
            this.s_name2.Name = "s_name2";
            this.s_name2.Size = new System.Drawing.Size(421, 20);
            this.s_name2.TabIndex = 30;
            // 
            // s_name3
            // 
            this.s_name3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.s_name3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_name3.Location = new System.Drawing.Point(264, 43);
            this.s_name3.Name = "s_name3";
            this.s_name3.Size = new System.Drawing.Size(421, 20);
            this.s_name3.TabIndex = 29;
            // 
            // s_name4
            // 
            this.s_name4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.s_name4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_name4.Location = new System.Drawing.Point(264, 63);
            this.s_name4.Name = "s_name4";
            this.s_name4.Size = new System.Drawing.Size(421, 20);
            this.s_name4.TabIndex = 28;
            // 
            // c_sc2
            // 
            this.c_sc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.c_sc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_sc2.FormattingEnabled = true;
            this.c_sc2.Location = new System.Drawing.Point(3, 23);
            this.c_sc2.Name = "c_sc2";
            this.c_sc2.Size = new System.Drawing.Size(255, 21);
            this.c_sc2.TabIndex = 39;
            this.c_sc2.Text = "--Select--";
            this.c_sc2.SelectedIndexChanged += new System.EventHandler(this.c_sc2_SelectedIndexChanged);
            // 
            // c_sc3
            // 
            this.c_sc3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.c_sc3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_sc3.FormattingEnabled = true;
            this.c_sc3.Location = new System.Drawing.Point(3, 43);
            this.c_sc3.Name = "c_sc3";
            this.c_sc3.Size = new System.Drawing.Size(255, 21);
            this.c_sc3.TabIndex = 40;
            this.c_sc3.Text = "--Select--";
            this.c_sc3.SelectedIndexChanged += new System.EventHandler(this.c_sc3_SelectedIndexChanged);
            // 
            // c_sc4
            // 
            this.c_sc4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.c_sc4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_sc4.FormattingEnabled = true;
            this.c_sc4.Location = new System.Drawing.Point(3, 63);
            this.c_sc4.Name = "c_sc4";
            this.c_sc4.Size = new System.Drawing.Size(255, 21);
            this.c_sc4.TabIndex = 41;
            this.c_sc4.Text = "--Select--";
            this.c_sc4.SelectedIndexChanged += new System.EventHandler(this.c_sc4_SelectedIndexChanged);
            // 
            // c_sc5
            // 
            this.c_sc5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.c_sc5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_sc5.FormattingEnabled = true;
            this.c_sc5.Location = new System.Drawing.Point(3, 83);
            this.c_sc5.Name = "c_sc5";
            this.c_sc5.Size = new System.Drawing.Size(255, 21);
            this.c_sc5.TabIndex = 42;
            this.c_sc5.Text = "--Select--";
            this.c_sc5.SelectedIndexChanged += new System.EventHandler(this.c_sc5_SelectedIndexChanged);
            // 
            // c_sc6
            // 
            this.c_sc6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.c_sc6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_sc6.FormattingEnabled = true;
            this.c_sc6.Location = new System.Drawing.Point(3, 103);
            this.c_sc6.Name = "c_sc6";
            this.c_sc6.Size = new System.Drawing.Size(255, 21);
            this.c_sc6.TabIndex = 43;
            this.c_sc6.Text = "--Select--";
            this.c_sc6.SelectedIndexChanged += new System.EventHandler(this.c_sc6_SelectedIndexChanged);
            // 
            // c_sc7
            // 
            this.c_sc7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.c_sc7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_sc7.FormattingEnabled = true;
            this.c_sc7.Location = new System.Drawing.Point(3, 123);
            this.c_sc7.Name = "c_sc7";
            this.c_sc7.Size = new System.Drawing.Size(255, 21);
            this.c_sc7.TabIndex = 44;
            this.c_sc7.Text = "--Select--";
            this.c_sc7.SelectedIndexChanged += new System.EventHandler(this.c_sc7_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.49909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 427F));
            this.tableLayoutPanel1.Controls.Add(this.c_sc7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.c_sc6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.c_sc5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.c_sc4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.c_sc3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.c_sc2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.s_name4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.s_name3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.s_name2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.s_name5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.s_name6, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.s_name7, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.s_name8, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.s_name9, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.s_name10, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.s_name11, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.s_name1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.s_code11, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.s_code10, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.s_code9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.s_code8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.c_sc1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(339, 232);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(688, 224);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(431, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Subject Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(795, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Subject Name";
            // 
            // b_assign
            // 
            this.b_assign.Location = new System.Drawing.Point(741, 499);
            this.b_assign.Name = "b_assign";
            this.b_assign.Size = new System.Drawing.Size(89, 24);
            this.b_assign.TabIndex = 20;
            this.b_assign.Text = "Assign";
            this.b_assign.UseVisualStyleBackColor = true;
            this.b_assign.Click += new System.EventHandler(this.b_assign_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(836, 499);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 24);
            this.b_cancel.TabIndex = 21;
            this.b_cancel.Text = "Clear";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // b_print
            // 
            this.b_print.Location = new System.Drawing.Point(917, 499);
            this.b_print.Name = "b_print";
            this.b_print.Size = new System.Drawing.Size(75, 23);
            this.b_print.TabIndex = 27;
            this.b_print.Text = "Print";
            this.b_print.UseVisualStyleBackColor = true;
            this.b_print.Click += new System.EventHandler(this.b_print_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(413, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(441, 39);
            this.label13.TabIndex = 56;
            this.label13.Text = "Assign Subjects for this session";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::test1.Properties.Resources.bcet;
            this.pictureBox1.Location = new System.Drawing.Point(38, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(363, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 135);
            this.panel1.TabIndex = 57;
            // 
            // assign_subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 601);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.b_print);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_assign);
            this.Controls.Add(this.c_branch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.c_Sem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "assign_subject";
            this.Text = "Assign Subjects";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.assign_subject_FormClosing);
            this.Load += new System.EventHandler(this.assign_subject_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox c_branch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox c_Sem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox c_sc7;
        private System.Windows.Forms.ComboBox c_sc6;
        private System.Windows.Forms.ComboBox c_sc5;
        private System.Windows.Forms.ComboBox c_sc4;
        private System.Windows.Forms.ComboBox c_sc3;
        private System.Windows.Forms.ComboBox c_sc2;
        private System.Windows.Forms.TextBox s_name4;
        private System.Windows.Forms.TextBox s_name3;
        private System.Windows.Forms.TextBox s_name2;
        private System.Windows.Forms.TextBox s_name5;
        private System.Windows.Forms.TextBox s_name6;
        private System.Windows.Forms.TextBox s_name7;
        private System.Windows.Forms.TextBox s_name8;
        private System.Windows.Forms.TextBox s_name9;
        private System.Windows.Forms.TextBox s_name10;
        private System.Windows.Forms.TextBox s_name11;
        private System.Windows.Forms.TextBox s_name1;
        private System.Windows.Forms.TextBox s_code11;
        private System.Windows.Forms.TextBox s_code10;
        private System.Windows.Forms.TextBox s_code9;
        private System.Windows.Forms.TextBox s_code8;
        private System.Windows.Forms.ComboBox c_sc1;
        private System.Windows.Forms.Button b_print;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.Button b_assign;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;

    }
}