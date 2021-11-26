
namespace Job_App
{
    partial class PopupUser
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
            this.title = new System.Windows.Forms.Label();
            this.jobTitle = new System.Windows.Forms.Label();
            this.avgSalary = new System.Windows.Forms.Label();
            this.maxSalary = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.region = new System.Windows.Forms.Label();
            this.growth = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.avgBox = new System.Windows.Forms.TextBox();
            this.maxBox = new System.Windows.Forms.TextBox();
            this.stateBox = new System.Windows.Forms.TextBox();
            this.regionBox = new System.Windows.Forms.TextBox();
            this.growthBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(30, 28);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(201, 31);
            this.title.TabIndex = 0;
            this.title.Text = "Job Information";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // jobTitle
            // 
            this.jobTitle.AutoSize = true;
            this.jobTitle.Location = new System.Drawing.Point(259, 144);
            this.jobTitle.Name = "jobTitle";
            this.jobTitle.Size = new System.Drawing.Size(74, 31);
            this.jobTitle.TabIndex = 1;
            this.jobTitle.Text = "Title:";
            this.jobTitle.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // avgSalary
            // 
            this.avgSalary.AutoSize = true;
            this.avgSalary.Location = new System.Drawing.Point(146, 211);
            this.avgSalary.Name = "avgSalary";
            this.avgSalary.Size = new System.Drawing.Size(207, 31);
            this.avgSalary.TabIndex = 2;
            this.avgSalary.Text = "Average Salary:";
            this.avgSalary.Click += new System.EventHandler(this.label2_Click);
            // 
            // maxSalary
            // 
            this.maxSalary.AutoSize = true;
            this.maxSalary.Location = new System.Drawing.Point(132, 277);
            this.maxSalary.Name = "maxSalary";
            this.maxSalary.Size = new System.Drawing.Size(221, 31);
            this.maxSalary.TabIndex = 3;
            this.maxSalary.Text = "Maximum Salary:";
            this.maxSalary.Click += new System.EventHandler(this.label3_Click);
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(267, 338);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(86, 31);
            this.state.TabIndex = 4;
            this.state.Text = "State:";
            // 
            // region
            // 
            this.region.AutoSize = true;
            this.region.Location = new System.Drawing.Point(245, 395);
            this.region.Name = "region";
            this.region.Size = new System.Drawing.Size(108, 31);
            this.region.TabIndex = 5;
            this.region.Text = "Region:";
            // 
            // growth
            // 
            this.growth.AutoSize = true;
            this.growth.Location = new System.Drawing.Point(121, 455);
            this.growth.Name = "growth";
            this.growth.Size = new System.Drawing.Size(232, 31);
            this.growth.TabIndex = 6;
            this.growth.Text = "Projected Growth:";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(359, 144);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(356, 38);
            this.titleBox.TabIndex = 7;
            this.titleBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // avgBox
            // 
            this.avgBox.Location = new System.Drawing.Point(359, 211);
            this.avgBox.Name = "avgBox";
            this.avgBox.Size = new System.Drawing.Size(183, 38);
            this.avgBox.TabIndex = 8;
            // 
            // maxBox
            // 
            this.maxBox.Location = new System.Drawing.Point(359, 277);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(183, 38);
            this.maxBox.TabIndex = 9;
            // 
            // stateBox
            // 
            this.stateBox.Location = new System.Drawing.Point(359, 338);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(67, 38);
            this.stateBox.TabIndex = 10;
            // 
            // regionBox
            // 
            this.regionBox.Location = new System.Drawing.Point(359, 395);
            this.regionBox.Name = "regionBox";
            this.regionBox.Size = new System.Drawing.Size(170, 38);
            this.regionBox.TabIndex = 11;
            // 
            // growthBox
            // 
            this.growthBox.Location = new System.Drawing.Point(359, 455);
            this.growthBox.Name = "growthBox";
            this.growthBox.Size = new System.Drawing.Size(100, 38);
            this.growthBox.TabIndex = 12;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(273, 552);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(214, 41);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Back to Search";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // PopupUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.growthBox);
            this.Controls.Add(this.regionBox);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.maxBox);
            this.Controls.Add(this.avgBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.growth);
            this.Controls.Add(this.region);
            this.Controls.Add(this.state);
            this.Controls.Add(this.maxSalary);
            this.Controls.Add(this.avgSalary);
            this.Controls.Add(this.jobTitle);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "PopupUser";
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PopupUser_FormClosed);
            this.Load += new System.EventHandler(this.PopupUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label jobTitle;
        private System.Windows.Forms.Label avgSalary;
        private System.Windows.Forms.Label maxSalary;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label region;
        private System.Windows.Forms.Label growth;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox avgBox;
        private System.Windows.Forms.TextBox maxBox;
        private System.Windows.Forms.TextBox stateBox;
        private System.Windows.Forms.TextBox regionBox;
        private System.Windows.Forms.TextBox growthBox;
        private System.Windows.Forms.Button backButton;
    }
}