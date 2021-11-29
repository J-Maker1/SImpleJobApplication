
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
            this.title.Location = new System.Drawing.Point(11, 12);
            this.title.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(79, 13);
            this.title.TabIndex = 0;
            this.title.Text = "Job Information";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // jobTitle
            // 
            this.jobTitle.AutoSize = true;
            this.jobTitle.Location = new System.Drawing.Point(97, 60);
            this.jobTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.jobTitle.Name = "jobTitle";
            this.jobTitle.Size = new System.Drawing.Size(30, 13);
            this.jobTitle.TabIndex = 1;
            this.jobTitle.Text = "Title:";
            this.jobTitle.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // avgSalary
            // 
            this.avgSalary.AutoSize = true;
            this.avgSalary.Location = new System.Drawing.Point(55, 88);
            this.avgSalary.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.avgSalary.Name = "avgSalary";
            this.avgSalary.Size = new System.Drawing.Size(82, 13);
            this.avgSalary.TabIndex = 2;
            this.avgSalary.Text = "Average Salary:";
            this.avgSalary.Click += new System.EventHandler(this.label2_Click);
            // 
            // maxSalary
            // 
            this.maxSalary.AutoSize = true;
            this.maxSalary.Location = new System.Drawing.Point(50, 116);
            this.maxSalary.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.maxSalary.Name = "maxSalary";
            this.maxSalary.Size = new System.Drawing.Size(86, 13);
            this.maxSalary.TabIndex = 3;
            this.maxSalary.Text = "Maximum Salary:";
            this.maxSalary.Click += new System.EventHandler(this.label3_Click);
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(100, 142);
            this.state.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(35, 13);
            this.state.TabIndex = 4;
            this.state.Text = "State:";
            // 
            // region
            // 
            this.region.AutoSize = true;
            this.region.Location = new System.Drawing.Point(92, 166);
            this.region.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.region.Name = "region";
            this.region.Size = new System.Drawing.Size(44, 13);
            this.region.TabIndex = 5;
            this.region.Text = "Region:";
            // 
            // growth
            // 
            this.growth.AutoSize = true;
            this.growth.Location = new System.Drawing.Point(45, 191);
            this.growth.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.growth.Name = "growth";
            this.growth.Size = new System.Drawing.Size(92, 13);
            this.growth.TabIndex = 6;
            this.growth.Text = "Projected Growth:";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(135, 60);
            this.titleBox.Margin = new System.Windows.Forms.Padding(1);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(136, 20);
            this.titleBox.TabIndex = 7;
            this.titleBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // avgBox
            // 
            this.avgBox.Location = new System.Drawing.Point(135, 88);
            this.avgBox.Margin = new System.Windows.Forms.Padding(1);
            this.avgBox.Name = "avgBox";
            this.avgBox.Size = new System.Drawing.Size(71, 20);
            this.avgBox.TabIndex = 8;
            // 
            // maxBox
            // 
            this.maxBox.Location = new System.Drawing.Point(135, 116);
            this.maxBox.Margin = new System.Windows.Forms.Padding(1);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(71, 20);
            this.maxBox.TabIndex = 9;
            // 
            // stateBox
            // 
            this.stateBox.Location = new System.Drawing.Point(135, 142);
            this.stateBox.Margin = new System.Windows.Forms.Padding(1);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(28, 20);
            this.stateBox.TabIndex = 10;
            // 
            // regionBox
            // 
            this.regionBox.Location = new System.Drawing.Point(135, 166);
            this.regionBox.Margin = new System.Windows.Forms.Padding(1);
            this.regionBox.Name = "regionBox";
            this.regionBox.Size = new System.Drawing.Size(66, 20);
            this.regionBox.TabIndex = 11;
            // 
            // growthBox
            // 
            this.growthBox.Location = new System.Drawing.Point(135, 191);
            this.growthBox.Margin = new System.Windows.Forms.Padding(1);
            this.growthBox.Name = "growthBox";
            this.growthBox.Size = new System.Drawing.Size(40, 20);
            this.growthBox.TabIndex = 12;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(102, 231);
            this.backButton.Margin = new System.Windows.Forms.Padding(1);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(99, 30);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Back to Search";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // PopupUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 445);
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
            this.Name = "PopupUser";
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PopupUser_FormClosed);
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