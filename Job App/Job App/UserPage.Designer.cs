
namespace Job_App
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.JobNameBox = new System.Windows.Forms.TextBox();
            this.AvgSalaryBox = new System.Windows.Forms.TextBox();
            this.MaxSalaryBox = new System.Windows.Forms.TextBox();
            this.AvgSalaryRange = new System.Windows.Forms.ComboBox();
            this.MaxSalaryRange = new System.Windows.Forms.ComboBox();
            this.JobGrowthRange = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StateChoice = new System.Windows.Forms.ComboBox();
            this.RegionChoice = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter Jobs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Job Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Avg Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Max Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Job Growth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "State";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Region";
            // 
            // JobNameBox
            // 
            this.JobNameBox.Location = new System.Drawing.Point(96, 57);
            this.JobNameBox.Name = "JobNameBox";
            this.JobNameBox.Size = new System.Drawing.Size(258, 20);
            this.JobNameBox.TabIndex = 8;
            // 
            // AvgSalaryBox
            // 
            this.AvgSalaryBox.Location = new System.Drawing.Point(190, 83);
            this.AvgSalaryBox.Name = "AvgSalaryBox";
            this.AvgSalaryBox.Size = new System.Drawing.Size(164, 20);
            this.AvgSalaryBox.TabIndex = 9;
            // 
            // MaxSalaryBox
            // 
            this.MaxSalaryBox.Location = new System.Drawing.Point(190, 109);
            this.MaxSalaryBox.Name = "MaxSalaryBox";
            this.MaxSalaryBox.Size = new System.Drawing.Size(164, 20);
            this.MaxSalaryBox.TabIndex = 10;
            // 
            // AvgSalaryRange
            // 
            this.AvgSalaryRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AvgSalaryRange.FormattingEnabled = true;
            this.AvgSalaryRange.Items.AddRange(new object[] {
            "Equal To",
            "Greater Than"});
            this.AvgSalaryRange.Location = new System.Drawing.Point(96, 82);
            this.AvgSalaryRange.Name = "AvgSalaryRange";
            this.AvgSalaryRange.Size = new System.Drawing.Size(88, 21);
            this.AvgSalaryRange.TabIndex = 11;
            // 
            // MaxSalaryRange
            // 
            this.MaxSalaryRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaxSalaryRange.FormattingEnabled = true;
            this.MaxSalaryRange.Items.AddRange(new object[] {
            "Equal To",
            "Greater Than"});
            this.MaxSalaryRange.Location = new System.Drawing.Point(96, 108);
            this.MaxSalaryRange.Name = "MaxSalaryRange";
            this.MaxSalaryRange.Size = new System.Drawing.Size(88, 21);
            this.MaxSalaryRange.TabIndex = 12;
            // 
            // JobGrowthRange
            // 
            this.JobGrowthRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JobGrowthRange.FormattingEnabled = true;
            this.JobGrowthRange.Items.AddRange(new object[] {
            "Equal To",
            "Greater Than"});
            this.JobGrowthRange.Location = new System.Drawing.Point(478, 56);
            this.JobGrowthRange.Name = "JobGrowthRange";
            this.JobGrowthRange.Size = new System.Drawing.Size(88, 21);
            this.JobGrowthRange.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(572, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 14;
            // 
            // StateChoice
            // 
            this.StateChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StateChoice.FormattingEnabled = true;
            this.StateChoice.Items.AddRange(new object[] {
            "N/A",
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.StateChoice.Location = new System.Drawing.Point(478, 83);
            this.StateChoice.Name = "StateChoice";
            this.StateChoice.Size = new System.Drawing.Size(88, 21);
            this.StateChoice.TabIndex = 15;
            // 
            // RegionChoice
            // 
            this.RegionChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RegionChoice.FormattingEnabled = true;
            this.RegionChoice.Items.AddRange(new object[] {
            "N/A",
            "NORTH",
            "WEST",
            "SOUTH",
            "EAST"});
            this.RegionChoice.Location = new System.Drawing.Point(478, 110);
            this.RegionChoice.Name = "RegionChoice";
            this.RegionChoice.Size = new System.Drawing.Size(88, 21);
            this.RegionChoice.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(12, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 301);
            this.panel1.TabIndex = 17;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(713, 109);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 18;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(713, 9);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 19;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RegionChoice);
            this.Controls.Add(this.StateChoice);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.JobGrowthRange);
            this.Controls.Add(this.MaxSalaryRange);
            this.Controls.Add(this.AvgSalaryRange);
            this.Controls.Add(this.MaxSalaryBox);
            this.Controls.Add(this.AvgSalaryBox);
            this.Controls.Add(this.JobNameBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox JobNameBox;
        private System.Windows.Forms.TextBox AvgSalaryBox;
        private System.Windows.Forms.TextBox MaxSalaryBox;
        private System.Windows.Forms.ComboBox AvgSalaryRange;
        private System.Windows.Forms.ComboBox MaxSalaryRange;
        private System.Windows.Forms.ComboBox JobGrowthRange;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox StateChoice;
        private System.Windows.Forms.ComboBox RegionChoice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button LogoutButton;
    }
}