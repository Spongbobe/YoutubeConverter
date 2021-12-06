namespace WindowsFormsApp1
{
    partial class GitHubProfile
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
            this.searchTb = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.containerPnl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // searchTb
            // 
            this.searchTb.Font = new System.Drawing.Font("DengXian", 12.25F);
            this.searchTb.Location = new System.Drawing.Point(229, 61);
            this.searchTb.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(388, 28);
            this.searchTb.TabIndex = 0;
            this.searchTb.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Github Profile";
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("DengXian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(623, 56);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(96, 33);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // containerPnl
            // 
            this.containerPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.containerPnl.Location = new System.Drawing.Point(153, 133);
            this.containerPnl.Name = "containerPnl";
            this.containerPnl.Size = new System.Drawing.Size(658, 397);
            this.containerPnl.TabIndex = 3;
            // 
            // GitHubProfile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(947, 561);
            this.Controls.Add(this.containerPnl);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTb);
            this.Font = new System.Drawing.Font("DengXian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GitHubProfile";
            this.Text = "GitHubProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox searchTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel containerPnl;
    }
}