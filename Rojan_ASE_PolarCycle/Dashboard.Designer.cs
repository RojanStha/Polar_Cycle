namespace Rojan_ASE_PolarCycle
{
    partial class Dashboard
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.time_interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heart_rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speeds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadences = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altitudes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Power_watt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.power_balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pending_index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.left_right_balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_load = new System.Windows.Forms.ListBox();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblsmode = new System.Windows.Forms.Label();
            this.file1 = new System.Windows.Forms.Label();
            this.lblinterval = new System.Windows.Forms.Label();
            this.lblversion = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblmonitor = new System.Windows.Forms.Label();
            this.startdate = new System.Windows.Forms.Label();
            this.lbllength = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.avgaltitude = new System.Windows.Forms.Label();
            this.minaltitude = new System.Windows.Forms.Label();
            this.maxaltitude = new System.Windows.Forms.Label();
            this.avgpower = new System.Windows.Forms.Label();
            this.minpower = new System.Windows.Forms.Label();
            this.maxpower = new System.Windows.Forms.Label();
            this.avgspeed = new System.Windows.Forms.Label();
            this.minspeed = new System.Windows.Forms.Label();
            this.maxspeed = new System.Windows.Forms.Label();
            this.avgheartrate = new System.Windows.Forms.Label();
            this.minheartrate = new System.Windows.Forms.Label();
            this.maxheartrate = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.time_interval,
            this.heart_rate,
            this.speeds,
            this.cadences,
            this.altitudes,
            this.Power_watt,
            this.power_balance,
            this.pending_index,
            this.left_right_balance});
            this.dataGridView1.Location = new System.Drawing.Point(12, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(868, 393);
            this.dataGridView1.TabIndex = 79;
            // 
            // time_interval
            // 
            this.time_interval.HeaderText = "TIme Interval";
            this.time_interval.Name = "time_interval";
            this.time_interval.ReadOnly = true;
            // 
            // heart_rate
            // 
            this.heart_rate.HeaderText = "Heart Rate";
            this.heart_rate.Name = "heart_rate";
            this.heart_rate.ReadOnly = true;
            // 
            // speeds
            // 
            this.speeds.HeaderText = "Speed";
            this.speeds.Name = "speeds";
            this.speeds.ReadOnly = true;
            // 
            // cadences
            // 
            this.cadences.HeaderText = "Cadence";
            this.cadences.Name = "cadences";
            this.cadences.ReadOnly = true;
            // 
            // altitudes
            // 
            this.altitudes.HeaderText = "Altitude";
            this.altitudes.Name = "altitudes";
            this.altitudes.ReadOnly = true;
            // 
            // Power_watt
            // 
            this.Power_watt.HeaderText = "Power(Watt)";
            this.Power_watt.Name = "Power_watt";
            this.Power_watt.ReadOnly = true;
            // 
            // power_balance
            // 
            this.power_balance.HeaderText = "Power Balance";
            this.power_balance.Name = "power_balance";
            this.power_balance.ReadOnly = true;
            // 
            // pending_index
            // 
            this.pending_index.HeaderText = "Pending Index";
            this.pending_index.Name = "pending_index";
            this.pending_index.ReadOnly = true;
            // 
            // left_right_balance
            // 
            this.left_right_balance.HeaderText = "Left Right Balance";
            this.left_right_balance.Name = "left_right_balance";
            this.left_right_balance.ReadOnly = true;
            // 
            // data_load
            // 
            this.data_load.FormattingEnabled = true;
            this.data_load.Location = new System.Drawing.Point(12, 39);
            this.data_load.Name = "data_load";
            this.data_load.Size = new System.Drawing.Size(342, 212);
            this.data_load.TabIndex = 80;
            this.data_load.SelectedIndexChanged += new System.EventHandler(this.data_load_SelectedIndexChanged);
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(366, 39);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 81;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblsmode);
            this.groupBox1.Controls.Add(this.file1);
            this.groupBox1.Controls.Add(this.lblinterval);
            this.groupBox1.Controls.Add(this.lblversion);
            this.groupBox1.Controls.Add(this.lbldate);
            this.groupBox1.Controls.Add(this.lblmonitor);
            this.groupBox1.Controls.Add(this.startdate);
            this.groupBox1.Controls.Add(this.lbllength);
            this.groupBox1.Location = new System.Drawing.Point(886, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 216);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Header";
            // 
            // lblsmode
            // 
            this.lblsmode.AutoSize = true;
            this.lblsmode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsmode.Location = new System.Drawing.Point(6, 144);
            this.lblsmode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsmode.Name = "lblsmode";
            this.lblsmode.Size = new System.Drawing.Size(50, 16);
            this.lblsmode.TabIndex = 70;
            this.lblsmode.Text = "smode";
            // 
            // file1
            // 
            this.file1.AutoSize = true;
            this.file1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file1.Location = new System.Drawing.Point(7, 191);
            this.file1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.file1.Name = "file1";
            this.file1.Size = new System.Drawing.Size(59, 16);
            this.file1.TabIndex = 69;
            this.file1.Text = "filename";
            // 
            // lblinterval
            // 
            this.lblinterval.AutoSize = true;
            this.lblinterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinterval.Location = new System.Drawing.Point(7, 167);
            this.lblinterval.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinterval.Name = "lblinterval";
            this.lblinterval.Size = new System.Drawing.Size(51, 16);
            this.lblinterval.TabIndex = 68;
            this.lblinterval.Text = "interval";
            // 
            // lblversion
            // 
            this.lblversion.AutoSize = true;
            this.lblversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblversion.Location = new System.Drawing.Point(5, 20);
            this.lblversion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(52, 16);
            this.lblversion.TabIndex = 62;
            this.lblversion.Text = "version";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(5, 120);
            this.lbldate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(35, 16);
            this.lbldate.TabIndex = 67;
            this.lbldate.Text = "date";
            // 
            // lblmonitor
            // 
            this.lblmonitor.AutoSize = true;
            this.lblmonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonitor.Location = new System.Drawing.Point(5, 44);
            this.lblmonitor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmonitor.Name = "lblmonitor";
            this.lblmonitor.Size = new System.Drawing.Size(52, 16);
            this.lblmonitor.TabIndex = 63;
            this.lblmonitor.Text = "monitor";
            // 
            // startdate
            // 
            this.startdate.AutoSize = true;
            this.startdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startdate.Location = new System.Drawing.Point(5, 70);
            this.startdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(63, 16);
            this.startdate.TabIndex = 64;
            this.startdate.Text = "start date";
            // 
            // lbllength
            // 
            this.lbllength.AutoSize = true;
            this.lbllength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllength.Location = new System.Drawing.Point(5, 95);
            this.lbllength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbllength.Name = "lbllength";
            this.lbllength.Size = new System.Drawing.Size(44, 16);
            this.lbllength.TabIndex = 65;
            this.lbllength.Text = "length";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.avgaltitude);
            this.groupBox2.Controls.Add(this.minaltitude);
            this.groupBox2.Controls.Add(this.maxaltitude);
            this.groupBox2.Controls.Add(this.avgpower);
            this.groupBox2.Controls.Add(this.minpower);
            this.groupBox2.Controls.Add(this.maxpower);
            this.groupBox2.Controls.Add(this.avgspeed);
            this.groupBox2.Controls.Add(this.minspeed);
            this.groupBox2.Controls.Add(this.maxspeed);
            this.groupBox2.Controls.Add(this.avgheartrate);
            this.groupBox2.Controls.Add(this.minheartrate);
            this.groupBox2.Controls.Add(this.maxheartrate);
            this.groupBox2.Location = new System.Drawing.Point(886, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 360);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Summary";
            // 
            // avgaltitude
            // 
            this.avgaltitude.AutoSize = true;
            this.avgaltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgaltitude.Location = new System.Drawing.Point(5, 334);
            this.avgaltitude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgaltitude.Name = "avgaltitude";
            this.avgaltitude.Size = new System.Drawing.Size(107, 16);
            this.avgaltitude.TabIndex = 73;
            this.avgaltitude.Text = "Average Altitude";
            // 
            // minaltitude
            // 
            this.minaltitude.AutoSize = true;
            this.minaltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minaltitude.Location = new System.Drawing.Point(5, 304);
            this.minaltitude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minaltitude.Name = "minaltitude";
            this.minaltitude.Size = new System.Drawing.Size(76, 16);
            this.minaltitude.TabIndex = 72;
            this.minaltitude.Text = "Min Altitude";
            // 
            // maxaltitude
            // 
            this.maxaltitude.AutoSize = true;
            this.maxaltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxaltitude.Location = new System.Drawing.Point(5, 275);
            this.maxaltitude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxaltitude.Name = "maxaltitude";
            this.maxaltitude.Size = new System.Drawing.Size(80, 16);
            this.maxaltitude.TabIndex = 71;
            this.maxaltitude.Text = "Max Altitude";
            // 
            // avgpower
            // 
            this.avgpower.AutoSize = true;
            this.avgpower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgpower.Location = new System.Drawing.Point(5, 245);
            this.avgpower.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgpower.Name = "avgpower";
            this.avgpower.Size = new System.Drawing.Size(101, 16);
            this.avgpower.TabIndex = 70;
            this.avgpower.Text = "Average Power";
            // 
            // minpower
            // 
            this.minpower.AutoSize = true;
            this.minpower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minpower.Location = new System.Drawing.Point(5, 216);
            this.minpower.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minpower.Name = "minpower";
            this.minpower.Size = new System.Drawing.Size(70, 16);
            this.minpower.TabIndex = 69;
            this.minpower.Text = "Min Power";
            // 
            // maxpower
            // 
            this.maxpower.AutoSize = true;
            this.maxpower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxpower.Location = new System.Drawing.Point(5, 187);
            this.maxpower.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxpower.Name = "maxpower";
            this.maxpower.Size = new System.Drawing.Size(74, 16);
            this.maxpower.TabIndex = 68;
            this.maxpower.Text = "Max Power";
            // 
            // avgspeed
            // 
            this.avgspeed.AutoSize = true;
            this.avgspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgspeed.Location = new System.Drawing.Point(5, 157);
            this.avgspeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgspeed.Name = "avgspeed";
            this.avgspeed.Size = new System.Drawing.Size(104, 16);
            this.avgspeed.TabIndex = 67;
            this.avgspeed.Text = "Average Speed";
            // 
            // minspeed
            // 
            this.minspeed.AutoSize = true;
            this.minspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minspeed.Location = new System.Drawing.Point(5, 130);
            this.minspeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minspeed.Name = "minspeed";
            this.minspeed.Size = new System.Drawing.Size(73, 16);
            this.minspeed.TabIndex = 66;
            this.minspeed.Text = "Min Speed";
            // 
            // maxspeed
            // 
            this.maxspeed.AutoSize = true;
            this.maxspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxspeed.Location = new System.Drawing.Point(5, 103);
            this.maxspeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxspeed.Name = "maxspeed";
            this.maxspeed.Size = new System.Drawing.Size(77, 16);
            this.maxspeed.TabIndex = 65;
            this.maxspeed.Text = "Max Speed";
            // 
            // avgheartrate
            // 
            this.avgheartrate.AutoSize = true;
            this.avgheartrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgheartrate.Location = new System.Drawing.Point(5, 75);
            this.avgheartrate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgheartrate.Name = "avgheartrate";
            this.avgheartrate.Size = new System.Drawing.Size(128, 16);
            this.avgheartrate.TabIndex = 64;
            this.avgheartrate.Text = "Average Heart Rate";
            // 
            // minheartrate
            // 
            this.minheartrate.AutoSize = true;
            this.minheartrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minheartrate.Location = new System.Drawing.Point(5, 47);
            this.minheartrate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minheartrate.Name = "minheartrate";
            this.minheartrate.Size = new System.Drawing.Size(97, 16);
            this.minheartrate.TabIndex = 63;
            this.minheartrate.Text = "Min Heart Rate";
            // 
            // maxheartrate
            // 
            this.maxheartrate.AutoSize = true;
            this.maxheartrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxheartrate.Location = new System.Drawing.Point(5, 20);
            this.maxheartrate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxheartrate.Name = "maxheartrate";
            this.maxheartrate.Size = new System.Drawing.Size(101, 16);
            this.maxheartrate.TabIndex = 62;
            this.maxheartrate.Text = "Max Heart Rate";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1128, 24);
            this.menuStrip1.TabIndex = 84;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eXITToolStripMenuItem.Text = "EXIT";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // graphToolStripMenuItem
            // 
            this.graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            this.graphToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.graphToolStripMenuItem.Text = "Graph";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 650);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.data_load);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_interval;
        private System.Windows.Forms.DataGridViewTextBoxColumn heart_rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn speeds;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadences;
        private System.Windows.Forms.DataGridViewTextBoxColumn altitudes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Power_watt;
        private System.Windows.Forms.DataGridViewTextBoxColumn power_balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn pending_index;
        private System.Windows.Forms.DataGridViewTextBoxColumn left_right_balance;
        private System.Windows.Forms.ListBox data_load;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblsmode;
        private System.Windows.Forms.Label file1;
        private System.Windows.Forms.Label lblinterval;
        private System.Windows.Forms.Label lblversion;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblmonitor;
        private System.Windows.Forms.Label startdate;
        private System.Windows.Forms.Label lbllength;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label avgaltitude;
        private System.Windows.Forms.Label minaltitude;
        private System.Windows.Forms.Label maxaltitude;
        private System.Windows.Forms.Label avgpower;
        private System.Windows.Forms.Label minpower;
        private System.Windows.Forms.Label maxpower;
        private System.Windows.Forms.Label avgspeed;
        private System.Windows.Forms.Label minspeed;
        private System.Windows.Forms.Label maxspeed;
        private System.Windows.Forms.Label avgheartrate;
        private System.Windows.Forms.Label minheartrate;
        private System.Windows.Forms.Label maxheartrate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}