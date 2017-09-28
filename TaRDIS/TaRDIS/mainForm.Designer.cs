namespace TaRDIS
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.cpuPercent = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cpuList = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cpuTempBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dsBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.usBox = new System.Windows.Forms.TextBox();
            this.bandwidthBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ramList = new System.Windows.Forms.ListView();
            this.pname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RAMvalue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.ramBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.osLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.refreshLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshIntervalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_1s = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_2s = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_5s = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_10s = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_30s = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_1m = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.hddPbx = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.hddWriteBox = new System.Windows.Forms.TextBox();
            this.hddSelect = new System.Windows.Forms.ComboBox();
            this.hddActiveBox = new System.Windows.Forms.TextBox();
            this.hddReadBox = new System.Windows.Forms.TextBox();
            this.stressBtn = new System.Windows.Forms.Button();
            this.grabTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hddPbx)).BeginInit();
            this.SuspendLayout();
            // 
            // cpuPercent
            // 
            this.cpuPercent.Location = new System.Drawing.Point(98, 19);
            this.cpuPercent.Name = "cpuPercent";
            this.cpuPercent.ReadOnly = true;
            this.cpuPercent.Size = new System.Drawing.Size(34, 20);
            this.cpuPercent.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cpuList);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cpuTempBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cpuPercent);
            this.groupBox1.Location = new System.Drawing.Point(13, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 151);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CPU";
            // 
            // cpuList
            // 
            this.cpuList.FormattingEnabled = true;
            this.cpuList.Location = new System.Drawing.Point(7, 76);
            this.cpuList.Name = "cpuList";
            this.cpuList.Size = new System.Drawing.Size(134, 69);
            this.cpuList.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "CPU temperature:";
            // 
            // cpuTempBox
            // 
            this.cpuTempBox.Location = new System.Drawing.Point(98, 43);
            this.cpuTempBox.Name = "cpuTempBox";
            this.cpuTempBox.ReadOnly = true;
            this.cpuTempBox.Size = new System.Drawing.Size(34, 20);
            this.cpuTempBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPU Usage:";
            // 
            // dsBox
            // 
            this.dsBox.Location = new System.Drawing.Point(103, 58);
            this.dsBox.Name = "dsBox";
            this.dsBox.ReadOnly = true;
            this.dsBox.Size = new System.Drawing.Size(60, 20);
            this.dsBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Download usage:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.usBox);
            this.groupBox2.Controls.Add(this.bandwidthBox);
            this.groupBox2.Controls.Add(this.dsBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 110);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Network";
            // 
            // usBox
            // 
            this.usBox.Location = new System.Drawing.Point(103, 83);
            this.usBox.Name = "usBox";
            this.usBox.ReadOnly = true;
            this.usBox.Size = new System.Drawing.Size(60, 20);
            this.usBox.TabIndex = 0;
            // 
            // bandwidthBox
            // 
            this.bandwidthBox.Location = new System.Drawing.Point(265, 58);
            this.bandwidthBox.Name = "bandwidthBox";
            this.bandwidthBox.ReadOnly = true;
            this.bandwidthBox.Size = new System.Drawing.Size(59, 20);
            this.bandwidthBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select NIC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Upload usage:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Internal bandwidth:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownWidth = 150;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 211);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ramList);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.ramBox);
            this.groupBox3.Location = new System.Drawing.Point(166, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 110);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RAM";
            this.groupBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox3_Paint);
            // 
            // ramList
            // 
            this.ramList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pname,
            this.RAMvalue});
            this.ramList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ramList.Location = new System.Drawing.Point(173, 19);
            this.ramList.Name = "ramList";
            this.ramList.Size = new System.Drawing.Size(253, 84);
            this.ramList.TabIndex = 3;
            this.ramList.UseCompatibleStateImageBehavior = false;
            this.ramList.View = System.Windows.Forms.View.Details;
            // 
            // pname
            // 
            this.pname.Text = "Process name";
            this.pname.Width = 174;
            // 
            // RAMvalue
            // 
            this.RAMvalue.Text = "RAM Usage";
            this.RAMvalue.Width = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "RAM available:";
            // 
            // ramBox
            // 
            this.ramBox.Location = new System.Drawing.Point(87, 19);
            this.ramBox.Name = "ramBox";
            this.ramBox.ReadOnly = true;
            this.ramBox.Size = new System.Drawing.Size(69, 20);
            this.ramBox.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 303);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Always on top";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(270, 299);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osLabel,
            this.refreshLabel,
            this.grabTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 334);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(610, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // osLabel
            // 
            this.osLabel.Name = "osLabel";
            this.osLabel.Size = new System.Drawing.Size(118, 17);
            this.osLabel.Text = "toolStripStatusLabel1";
            // 
            // refreshLabel
            // 
            this.refreshLabel.Name = "refreshLabel";
            this.refreshLabel.Size = new System.Drawing.Size(118, 17);
            this.refreshLabel.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshIntervalToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // refreshIntervalToolStripMenuItem
            // 
            this.refreshIntervalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_1s,
            this.menuItem_2s,
            this.menuItem_5s,
            this.menuItem_10s,
            this.menuItem_30s,
            this.menuItem_1m});
            this.refreshIntervalToolStripMenuItem.Name = "refreshIntervalToolStripMenuItem";
            this.refreshIntervalToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.refreshIntervalToolStripMenuItem.Text = "Refresh interval";
            // 
            // menuItem_1s
            // 
            this.menuItem_1s.Name = "menuItem_1s";
            this.menuItem_1s.Size = new System.Drawing.Size(91, 22);
            this.menuItem_1s.Text = "1s";
            this.menuItem_1s.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // menuItem_2s
            // 
            this.menuItem_2s.Name = "menuItem_2s";
            this.menuItem_2s.Size = new System.Drawing.Size(91, 22);
            this.menuItem_2s.Text = "2s";
            this.menuItem_2s.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // menuItem_5s
            // 
            this.menuItem_5s.Name = "menuItem_5s";
            this.menuItem_5s.Size = new System.Drawing.Size(91, 22);
            this.menuItem_5s.Text = "5s";
            this.menuItem_5s.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // menuItem_10s
            // 
            this.menuItem_10s.Name = "menuItem_10s";
            this.menuItem_10s.Size = new System.Drawing.Size(91, 22);
            this.menuItem_10s.Text = "10s";
            this.menuItem_10s.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // menuItem_30s
            // 
            this.menuItem_30s.Name = "menuItem_30s";
            this.menuItem_30s.Size = new System.Drawing.Size(91, 22);
            this.menuItem_30s.Text = "30s";
            this.menuItem_30s.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // menuItem_1m
            // 
            this.menuItem_1m.Name = "menuItem_1m";
            this.menuItem_1m.Size = new System.Drawing.Size(91, 22);
            this.menuItem_1m.Text = "1m";
            this.menuItem_1m.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // graphsToolStripMenuItem
            // 
            this.graphsToolStripMenuItem.Name = "graphsToolStripMenuItem";
            this.graphsToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.graphsToolStripMenuItem.Text = "Graphs";
            this.graphsToolStripMenuItem.Click += new System.EventHandler(this.graphsToolStripMenuItem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.hddPbx);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.hddWriteBox);
            this.groupBox4.Controls.Add(this.hddSelect);
            this.groupBox4.Controls.Add(this.hddActiveBox);
            this.groupBox4.Controls.Add(this.hddReadBox);
            this.groupBox4.Location = new System.Drawing.Point(352, 186);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(246, 136);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "HDD";
            // 
            // hddPbx
            // 
            this.hddPbx.Image = global::TaRDIS.Properties.Resources.hdd_idle;
            this.hddPbx.Location = new System.Drawing.Point(175, 43);
            this.hddPbx.Name = "hddPbx";
            this.hddPbx.Size = new System.Drawing.Size(66, 87);
            this.hddPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hddPbx.TabIndex = 3;
            this.hddPbx.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Write";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Disk active time:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Select HDD:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Read";
            // 
            // hddWriteBox
            // 
            this.hddWriteBox.Location = new System.Drawing.Point(98, 43);
            this.hddWriteBox.Name = "hddWriteBox";
            this.hddWriteBox.ReadOnly = true;
            this.hddWriteBox.Size = new System.Drawing.Size(71, 20);
            this.hddWriteBox.TabIndex = 0;
            // 
            // hddSelect
            // 
            this.hddSelect.DropDownWidth = 150;
            this.hddSelect.FormattingEnabled = true;
            this.hddSelect.Location = new System.Drawing.Point(80, 16);
            this.hddSelect.Name = "hddSelect";
            this.hddSelect.Size = new System.Drawing.Size(160, 21);
            this.hddSelect.TabIndex = 3;
            this.hddSelect.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // hddActiveBox
            // 
            this.hddActiveBox.Location = new System.Drawing.Point(98, 93);
            this.hddActiveBox.Name = "hddActiveBox";
            this.hddActiveBox.ReadOnly = true;
            this.hddActiveBox.Size = new System.Drawing.Size(71, 20);
            this.hddActiveBox.TabIndex = 0;
            // 
            // hddReadBox
            // 
            this.hddReadBox.Location = new System.Drawing.Point(98, 67);
            this.hddReadBox.Name = "hddReadBox";
            this.hddReadBox.ReadOnly = true;
            this.hddReadBox.Size = new System.Drawing.Size(71, 20);
            this.hddReadBox.TabIndex = 0;
            // 
            // stressBtn
            // 
            this.stressBtn.BackColor = System.Drawing.SystemColors.Control;
            this.stressBtn.Location = new System.Drawing.Point(166, 299);
            this.stressBtn.Name = "stressBtn";
            this.stressBtn.Size = new System.Drawing.Size(98, 23);
            this.stressBtn.TabIndex = 10;
            this.stressBtn.Text = "CPU Stress test";
            this.stressBtn.UseVisualStyleBackColor = false;
            this.stressBtn.Click += new System.EventHandler(this.stressBtn_Click);
            // 
            // grabTime
            // 
            this.grabTime.Name = "grabTime";
            this.grabTime.Size = new System.Drawing.Size(118, 17);
            this.grabTime.Text = "toolStripStatusLabel1";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 356);
            this.Controls.Add(this.stressBtn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "TaRDIS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hddPbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cpuPercent;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ramBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox usBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bandwidthBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox cpuList;
        private System.Windows.Forms.ListView ramList;
        private System.Windows.Forms.ColumnHeader pname;
        private System.Windows.Forms.ColumnHeader RAMvalue;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel osLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cpuTempBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshIntervalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem_1s;
        private System.Windows.Forms.ToolStripMenuItem menuItem_2s;
        private System.Windows.Forms.ToolStripMenuItem menuItem_5s;
        private System.Windows.Forms.ToolStripMenuItem menuItem_10s;
        private System.Windows.Forms.ToolStripMenuItem menuItem_30s;
        private System.Windows.Forms.ToolStripMenuItem menuItem_1m;
        private System.Windows.Forms.ToolStripStatusLabel refreshLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox hddPbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox hddWriteBox;
        private System.Windows.Forms.TextBox hddActiveBox;
        private System.Windows.Forms.TextBox hddReadBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox hddSelect;
        private System.Windows.Forms.Button stressBtn;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphsToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel grabTime;
    }
}

