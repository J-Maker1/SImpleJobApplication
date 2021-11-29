
namespace Job_App
{
    partial class PopupEmployer
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
            this.backButton = new System.Windows.Forms.Button();
            this.growthBox = new System.Windows.Forms.TextBox();
            this.regionBox = new System.Windows.Forms.TextBox();
            this.stateBox = new System.Windows.Forms.TextBox();
            this.maxBox = new System.Windows.Forms.TextBox();
            this.avgBox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.growth = new System.Windows.Forms.Label();
            this.region = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.maxSalary = new System.Windows.Forms.Label();
            this.avgSalary = new System.Windows.Forms.Label();
            this.jobTitle = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(342, 16);
            this.backButton.Margin = new System.Windows.Forms.Padding(1);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(118, 22);
            this.backButton.TabIndex = 27;
            this.backButton.Text = "Back to All Jobs";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // growthBox
            // 
            this.growthBox.Location = new System.Drawing.Point(135, 195);
            this.growthBox.Margin = new System.Windows.Forms.Padding(1);
            this.growthBox.Name = "growthBox";
            this.growthBox.Size = new System.Drawing.Size(40, 20);
            this.growthBox.TabIndex = 26;
            // 
            // regionBox
            // 
            this.regionBox.Location = new System.Drawing.Point(135, 169);
            this.regionBox.Margin = new System.Windows.Forms.Padding(1);
            this.regionBox.Name = "regionBox";
            this.regionBox.Size = new System.Drawing.Size(66, 20);
            this.regionBox.TabIndex = 25;
            // 
            // stateBox
            // 
            this.stateBox.Location = new System.Drawing.Point(135, 146);
            this.stateBox.Margin = new System.Windows.Forms.Padding(1);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(28, 20);
            this.stateBox.TabIndex = 24;
            // 
            // maxBox
            // 
            this.maxBox.Location = new System.Drawing.Point(135, 120);
            this.maxBox.Margin = new System.Windows.Forms.Padding(1);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(71, 20);
            this.maxBox.TabIndex = 23;
            // 
            // avgBox
            // 
            this.avgBox.Location = new System.Drawing.Point(135, 92);
            this.avgBox.Margin = new System.Windows.Forms.Padding(1);
            this.avgBox.Name = "avgBox";
            this.avgBox.Size = new System.Drawing.Size(71, 20);
            this.avgBox.TabIndex = 22;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(135, 64);
            this.titleBox.Margin = new System.Windows.Forms.Padding(1);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(136, 20);
            this.titleBox.TabIndex = 21;
            // 
            // growth
            // 
            this.growth.AutoSize = true;
            this.growth.Location = new System.Drawing.Point(46, 195);
            this.growth.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.growth.Name = "growth";
            this.growth.Size = new System.Drawing.Size(92, 13);
            this.growth.TabIndex = 20;
            this.growth.Text = "Projected Growth:";
            // 
            // region
            // 
            this.region.AutoSize = true;
            this.region.Location = new System.Drawing.Point(93, 169);
            this.region.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.region.Name = "region";
            this.region.Size = new System.Drawing.Size(44, 13);
            this.region.TabIndex = 19;
            this.region.Text = "Region:";
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(101, 146);
            this.state.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(35, 13);
            this.state.TabIndex = 18;
            this.state.Text = "State:";
            // 
            // maxSalary
            // 
            this.maxSalary.AutoSize = true;
            this.maxSalary.Location = new System.Drawing.Point(50, 120);
            this.maxSalary.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.maxSalary.Name = "maxSalary";
            this.maxSalary.Size = new System.Drawing.Size(86, 13);
            this.maxSalary.TabIndex = 17;
            this.maxSalary.Text = "Maximum Salary:";
            // 
            // avgSalary
            // 
            this.avgSalary.AutoSize = true;
            this.avgSalary.Location = new System.Drawing.Point(56, 92);
            this.avgSalary.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.avgSalary.Name = "avgSalary";
            this.avgSalary.Size = new System.Drawing.Size(82, 13);
            this.avgSalary.TabIndex = 16;
            this.avgSalary.Text = "Average Salary:";
            // 
            // jobTitle
            // 
            this.jobTitle.AutoSize = true;
            this.jobTitle.Location = new System.Drawing.Point(98, 64);
            this.jobTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.jobTitle.Name = "jobTitle";
            this.jobTitle.Size = new System.Drawing.Size(30, 13);
            this.jobTitle.TabIndex = 15;
            this.jobTitle.Text = "Title:";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(12, 16);
            this.title.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(97, 13);
            this.title.TabIndex = 14;
            this.title.Text = "Job Posting Details";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(80, 231);
            this.update.Margin = new System.Windows.Forms.Padding(1);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(80, 25);
            this.update.TabIndex = 28;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(163, 231);
            this.delete.Margin = new System.Windows.Forms.Padding(1);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(80, 25);
            this.delete.TabIndex = 29;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // PopupEmployer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 445);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
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
            this.Name = "PopupEmployer";
            this.Text = "PopupEmployer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PopupEmployer_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox growthBox;
        private System.Windows.Forms.TextBox regionBox;
        private System.Windows.Forms.TextBox stateBox;
        private System.Windows.Forms.TextBox maxBox;
        private System.Windows.Forms.TextBox avgBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label growth;
        private System.Windows.Forms.Label region;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label maxSalary;
        private System.Windows.Forms.Label avgSalary;
        private System.Windows.Forms.Label jobTitle;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
    }
}