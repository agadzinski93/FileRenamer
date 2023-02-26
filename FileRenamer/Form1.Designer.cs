namespace FileRenamer
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewText = new System.Windows.Forms.TextBox();
            this.chkAddIncrement = new System.Windows.Forms.CheckBox();
            this.txtIncrementLength = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIncrementStart = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIncrementSteps = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFileStart = new System.Windows.Forms.TextBox();
            this.txtFileEnd = new System.Windows.Forms.TextBox();
            this.txtSearchDirOne = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSearchDirTwo = new System.Windows.Forms.TextBox();
            this.btnSearchDuplicates = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnRadioStart = new System.Windows.Forms.RadioButton();
            this.btnRadioEnd = new System.Windows.Forms.RadioButton();
            this.btnRadioCustomize = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUndoRename = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory";
            // 
            // txtDirectory
            // 
            this.txtDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.txtDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectory.ForeColor = System.Drawing.Color.White;
            this.txtDirectory.Location = new System.Drawing.Point(43, 99);
            this.txtDirectory.MaxLength = 200;
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(621, 34);
            this.txtDirectory.TabIndex = 1;
            this.txtDirectory.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Starting Position";
            this.toolTip1.SetToolTip(this.label2, "Integer representing first character to replace");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtStart
            // 
            this.txtStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.txtStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStart.Enabled = false;
            this.txtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStart.ForeColor = System.Drawing.Color.White;
            this.txtStart.Location = new System.Drawing.Point(206, 93);
            this.txtStart.MaxLength = 4;
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(62, 34);
            this.txtStart.TabIndex = 3;
            this.txtStart.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnStart.Location = new System.Drawing.Point(43, 718);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(621, 49);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Length";
            this.toolTip1.SetToolTip(this.label3, "Number of characters to delete during replacement, starting with \'Starting Positi" +
        "on\'");
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtLength
            // 
            this.txtLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.txtLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLength.Enabled = false;
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.ForeColor = System.Drawing.Color.White;
            this.txtLength.Location = new System.Drawing.Point(104, 133);
            this.txtLength.MaxLength = 4;
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(62, 34);
            this.txtLength.TabIndex = 6;
            this.txtLength.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "New Text";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNewText
            // 
            this.txtNewText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.txtNewText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewText.ForeColor = System.Drawing.Color.White;
            this.txtNewText.Location = new System.Drawing.Point(43, 376);
            this.txtNewText.MaxLength = 50;
            this.txtNewText.Name = "txtNewText";
            this.txtNewText.Size = new System.Drawing.Size(621, 34);
            this.txtNewText.TabIndex = 8;
            this.txtNewText.TextChanged += new System.EventHandler(this.txtNewText_TextChanged);
            // 
            // chkAddIncrement
            // 
            this.chkAddIncrement.AutoSize = true;
            this.chkAddIncrement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.chkAddIncrement.ForeColor = System.Drawing.Color.White;
            this.chkAddIncrement.Location = new System.Drawing.Point(6, 43);
            this.chkAddIncrement.Name = "chkAddIncrement";
            this.chkAddIncrement.Size = new System.Drawing.Size(194, 33);
            this.chkAddIncrement.TabIndex = 10;
            this.chkAddIncrement.Text = "Add Increment";
            this.chkAddIncrement.UseVisualStyleBackColor = false;
            this.chkAddIncrement.CheckedChanged += new System.EventHandler(this.chkAddIncrement_CheckedChanged);
            // 
            // txtIncrementLength
            // 
            this.txtIncrementLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.txtIncrementLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIncrementLength.Enabled = false;
            this.txtIncrementLength.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtIncrementLength.Location = new System.Drawing.Point(27, 160);
            this.txtIncrementLength.MaxLength = 1;
            this.txtIncrementLength.Name = "txtIncrementLength";
            this.txtIncrementLength.Size = new System.Drawing.Size(49, 34);
            this.txtIncrementLength.TabIndex = 11;
            this.toolTip1.SetToolTip(this.txtIncrementLength, "Default will not add leading zeros");
            this.txtIncrementLength.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(525, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Increment Length (e.g. 3 results in \'001\',\'002\',etc)";
            this.toolTip1.SetToolTip(this.label5, "Default will not add leading zeros");
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtIncrementStart);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtIncrementSteps);
            this.groupBox1.Controls.Add(this.chkAddIncrement);
            this.groupBox1.Controls.Add(this.txtIncrementLength);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(43, 416);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 270);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Incremenets";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(356, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "Starting Number for Incrementer";
            this.toolTip1.SetToolTip(this.label8, "Default = 1");
            // 
            // txtIncrementStart
            // 
            this.txtIncrementStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.txtIncrementStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIncrementStart.Enabled = false;
            this.txtIncrementStart.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtIncrementStart.Location = new System.Drawing.Point(27, 110);
            this.txtIncrementStart.MaxLength = 4;
            this.txtIncrementStart.Name = "txtIncrementStart";
            this.txtIncrementStart.Size = new System.Drawing.Size(49, 34);
            this.txtIncrementStart.TabIndex = 16;
            this.toolTip1.SetToolTip(this.txtIncrementStart, "Default = 1");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(310, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Optional (hover for defaults)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(489, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Increment Steps (e.g. 2 results in \'1\',\'3\',\'5\',etc)";
            this.toolTip1.SetToolTip(this.label6, "Default = 1");
            // 
            // txtIncrementSteps
            // 
            this.txtIncrementSteps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.txtIncrementSteps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIncrementSteps.Enabled = false;
            this.txtIncrementSteps.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtIncrementSteps.Location = new System.Drawing.Point(27, 212);
            this.txtIncrementSteps.MaxLength = 4;
            this.txtIncrementSteps.Name = "txtIncrementSteps";
            this.txtIncrementSteps.Size = new System.Drawing.Size(49, 34);
            this.txtIncrementSteps.TabIndex = 13;
            this.toolTip1.SetToolTip(this.txtIncrementSteps, "Default = 1");
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(290, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 29);
            this.label9.TabIndex = 14;
            this.label9.Text = "Start File";
            this.toolTip1.SetToolTip(this.label9, "Default = first file in directory");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(295, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 29);
            this.label10.TabIndex = 15;
            this.label10.Text = "Last File";
            this.toolTip1.SetToolTip(this.label10, "Default = last file in directory");
            // 
            // txtFileStart
            // 
            this.txtFileStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.txtFileStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFileStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileStart.ForeColor = System.Drawing.Color.White;
            this.txtFileStart.Location = new System.Drawing.Point(405, 90);
            this.txtFileStart.MaxLength = 5;
            this.txtFileStart.Name = "txtFileStart";
            this.txtFileStart.Size = new System.Drawing.Size(74, 34);
            this.txtFileStart.TabIndex = 16;
            this.toolTip1.SetToolTip(this.txtFileStart, "Default = 1, first file in directory");
            // 
            // txtFileEnd
            // 
            this.txtFileEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.txtFileEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFileEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileEnd.ForeColor = System.Drawing.Color.White;
            this.txtFileEnd.Location = new System.Drawing.Point(405, 130);
            this.txtFileEnd.MaxLength = 5;
            this.txtFileEnd.Name = "txtFileEnd";
            this.txtFileEnd.Size = new System.Drawing.Size(74, 34);
            this.txtFileEnd.TabIndex = 17;
            this.toolTip1.SetToolTip(this.txtFileEnd, "Default = last file in directory");
            // 
            // txtSearchDirOne
            // 
            this.txtSearchDirOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.txtSearchDirOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchDirOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDirOne.ForeColor = System.Drawing.Color.White;
            this.txtSearchDirOne.Location = new System.Drawing.Point(726, 99);
            this.txtSearchDirOne.MaxLength = 200;
            this.txtSearchDirOne.Name = "txtSearchDirOne";
            this.txtSearchDirOne.Size = new System.Drawing.Size(621, 34);
            this.txtSearchDirOne.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(269, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 25);
            this.label11.TabIndex = 19;
            this.label11.Text = "File Renamer";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(721, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 29);
            this.label12.TabIndex = 20;
            this.label12.Text = "Directory 1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(721, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 29);
            this.label13.TabIndex = 21;
            this.label13.Text = "Directory 2";
            // 
            // txtSearchDirTwo
            // 
            this.txtSearchDirTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.txtSearchDirTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchDirTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDirTwo.ForeColor = System.Drawing.Color.White;
            this.txtSearchDirTwo.Location = new System.Drawing.Point(726, 178);
            this.txtSearchDirTwo.MaxLength = 200;
            this.txtSearchDirTwo.Name = "txtSearchDirTwo";
            this.txtSearchDirTwo.Size = new System.Drawing.Size(621, 34);
            this.txtSearchDirTwo.TabIndex = 22;
            // 
            // btnSearchDuplicates
            // 
            this.btnSearchDuplicates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearchDuplicates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDuplicates.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearchDuplicates.Location = new System.Drawing.Point(726, 220);
            this.btnSearchDuplicates.Name = "btnSearchDuplicates";
            this.btnSearchDuplicates.Size = new System.Drawing.Size(621, 49);
            this.btnSearchDuplicates.TabIndex = 23;
            this.btnSearchDuplicates.Text = "Search";
            this.btnSearchDuplicates.UseVisualStyleBackColor = false;
            this.btnSearchDuplicates.Click += new System.EventHandler(this.btnSearchDuplicates_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(936, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(198, 25);
            this.label14.TabIndex = 24;
            this.label14.Text = "Search for Duplicates";
            // 
            // btnRadioStart
            // 
            this.btnRadioStart.AutoSize = true;
            this.btnRadioStart.Checked = true;
            this.btnRadioStart.ForeColor = System.Drawing.Color.White;
            this.btnRadioStart.Location = new System.Drawing.Point(21, 45);
            this.btnRadioStart.Name = "btnRadioStart";
            this.btnRadioStart.Size = new System.Drawing.Size(196, 29);
            this.btnRadioStart.TabIndex = 25;
            this.btnRadioStart.TabStop = true;
            this.btnRadioStart.Text = "Insert Text at Start";
            this.btnRadioStart.UseVisualStyleBackColor = true;
            // 
            // btnRadioEnd
            // 
            this.btnRadioEnd.AutoSize = true;
            this.btnRadioEnd.ForeColor = System.Drawing.Color.White;
            this.btnRadioEnd.Location = new System.Drawing.Point(223, 45);
            this.btnRadioEnd.Name = "btnRadioEnd";
            this.btnRadioEnd.Size = new System.Drawing.Size(190, 29);
            this.btnRadioEnd.TabIndex = 26;
            this.btnRadioEnd.Text = "Insert Text at End";
            this.btnRadioEnd.UseVisualStyleBackColor = true;
            // 
            // btnRadioCustomize
            // 
            this.btnRadioCustomize.AutoSize = true;
            this.btnRadioCustomize.ForeColor = System.Drawing.Color.White;
            this.btnRadioCustomize.Location = new System.Drawing.Point(419, 45);
            this.btnRadioCustomize.Name = "btnRadioCustomize";
            this.btnRadioCustomize.Size = new System.Drawing.Size(130, 29);
            this.btnRadioCustomize.TabIndex = 27;
            this.btnRadioCustomize.Text = "Customize";
            this.btnRadioCustomize.UseVisualStyleBackColor = true;
            this.btnRadioCustomize.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRadioStart);
            this.groupBox2.Controls.Add(this.btnRadioCustomize);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnRadioEnd);
            this.groupBox2.Controls.Add(this.txtStart);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtLength);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtFileStart);
            this.groupBox2.Controls.Add(this.txtFileEnd);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(43, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 184);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text Insertion Options";
            // 
            // btnUndoRename
            // 
            this.btnUndoRename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUndoRename.Enabled = false;
            this.btnUndoRename.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnUndoRename.Location = new System.Drawing.Point(508, 35);
            this.btnUndoRename.Name = "btnUndoRename";
            this.btnUndoRename.Size = new System.Drawing.Size(156, 48);
            this.btnUndoRename.TabIndex = 29;
            this.btnUndoRename.Text = "Undo";
            this.btnUndoRename.UseVisualStyleBackColor = false;
            this.btnUndoRename.Visible = false;
            this.btnUndoRename.Click += new System.EventHandler(this.btnUndoRename_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1400, 792);
            this.Controls.Add(this.btnUndoRename);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnSearchDuplicates);
            this.Controls.Add(this.txtSearchDirTwo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSearchDirOne);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNewText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "File Renamer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewText;
        private System.Windows.Forms.CheckBox chkAddIncrement;
        private System.Windows.Forms.TextBox txtIncrementLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIncrementSteps;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIncrementStart;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFileStart;
        private System.Windows.Forms.TextBox txtFileEnd;
        private System.Windows.Forms.TextBox txtSearchDirOne;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSearchDirTwo;
        private System.Windows.Forms.Button btnSearchDuplicates;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton btnRadioStart;
        private System.Windows.Forms.RadioButton btnRadioEnd;
        private System.Windows.Forms.RadioButton btnRadioCustomize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUndoRename;
    }
}

