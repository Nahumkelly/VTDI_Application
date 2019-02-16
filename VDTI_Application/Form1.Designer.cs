namespace VDTI_Application
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schedulingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gateLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gateInOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gateReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.gateLogsToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.userManagementToolStripMenuItem,
            this.schedulingToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // schedulingToolStripMenuItem
            // 
            this.schedulingToolStripMenuItem.Name = "schedulingToolStripMenuItem";
            this.schedulingToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.schedulingToolStripMenuItem.Text = "Scheduling";
            // 
            // gateLogsToolStripMenuItem
            // 
            this.gateLogsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guestListToolStripMenuItem,
            this.gateInOutToolStripMenuItem});
            this.gateLogsToolStripMenuItem.Name = "gateLogsToolStripMenuItem";
            this.gateLogsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.gateLogsToolStripMenuItem.Text = "Gate Logs";
            // 
            // guestListToolStripMenuItem
            // 
            this.guestListToolStripMenuItem.Name = "guestListToolStripMenuItem";
            this.guestListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guestListToolStripMenuItem.Text = "Guest List";
            // 
            // gateInOutToolStripMenuItem
            // 
            this.gateInOutToolStripMenuItem.Name = "gateInOutToolStripMenuItem";
            this.gateInOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gateInOutToolStripMenuItem.Text = "Gate In / Out";
            this.gateInOutToolStripMenuItem.Click += new System.EventHandler(this.gateInOutToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gateReportToolStripMenuItem,
            this.userLogsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // gateReportToolStripMenuItem
            // 
            this.gateReportToolStripMenuItem.Name = "gateReportToolStripMenuItem";
            this.gateReportToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.gateReportToolStripMenuItem.Text = "Gate Report";
            // 
            // userLogsToolStripMenuItem
            // 
            this.userLogsToolStripMenuItem.Name = "userLogsToolStripMenuItem";
            this.userLogsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.userLogsToolStripMenuItem.Text = "User Logs";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Image = global::VDTI_Application.Properties.Resources.Login_16x_24;
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.logInToolStripMenuItem.Text = "Log In";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Image = global::VDTI_Application.Properties.Resources.UserProfile_16x;
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.userManagementToolStripMenuItem.Text = "User Management";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schedulingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gateLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gateInOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gateReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userLogsToolStripMenuItem;
    }
}

