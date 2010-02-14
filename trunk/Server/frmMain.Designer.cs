﻿using AQWE.Core;

namespace AQWE
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            Data.Database.runQuery("UPDATE servers SET count = '0' WHERE name = '" + Settings.server_name + "'");
            Data.Database.runQuery("UPDATE servers SET online = '0' WHERE name = '" + Settings.server_name + "'");
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
            this.mnuMain = new System.Windows.Forms.MainMenu();
            this.mnuServer = new System.Windows.Forms.MenuItem();
            this.mnuItemStart = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.mnuItemStop = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.mnuItemExit = new System.Windows.Forms.MenuItem();
            this.mnuManagement = new System.Windows.Forms.MenuItem();
            this.mnuItemConnections = new System.Windows.Forms.MenuItem();
            this.mnuLogging = new System.Windows.Forms.MenuItem();
            this.mnuItemLogInfoMessages = new System.Windows.Forms.MenuItem();
            this.mnuItemLogWarnings = new System.Windows.Forms.MenuItem();
            this.mnuItemLogErrors = new System.Windows.Forms.MenuItem();
            this.menuItem21 = new System.Windows.Forms.MenuItem();
            this.mnuItemWriteLogsToFile = new System.Windows.Forms.MenuItem();
            this.menuItem22 = new System.Windows.Forms.MenuItem();
            this.mnuItemLogClientMessages = new System.Windows.Forms.MenuItem();
            this.mnuItemLogServerMessages = new System.Windows.Forms.MenuItem();
            this.menuItem23 = new System.Windows.Forms.MenuItem();
            this.mnuItemClearLog = new System.Windows.Forms.MenuItem();
            this.mnuHelp = new System.Windows.Forms.MenuItem();
            this.mnuItemHelp = new System.Windows.Forms.MenuItem();
            this.mnuItemTutorials = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.mnuItemAbout = new System.Windows.Forms.MenuItem();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.statusOnlineUsers = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsOnlineUsers = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSplit = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusWarnings = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsWarnings = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSplit2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusErrors = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsErrors = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuServer,
            this.mnuManagement,
            this.mnuLogging,
            this.mnuHelp});
            // 
            // mnuServer
            // 
            this.mnuServer.Index = 0;
            this.mnuServer.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuItemStart,
            this.mnuItemStop,
            this.menuItem5,
            this.mnuItemExit});
            this.mnuServer.Text = "Server";
            // 
            // mnuItemStart
            // 
            this.mnuItemStart.Index = 0;
            this.mnuItemStart.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3,
            this.menuItem7});
            this.mnuItemStart.Text = "Start";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.Text = "Default Port";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 1;
            this.menuItem7.Text = "Custom Port";
            // 
            // mnuItemStop
            // 
            this.mnuItemStop.Index = 1;
            this.mnuItemStop.Text = "Stop";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 2;
            this.menuItem5.Text = "-";
            // 
            // mnuItemExit
            // 
            this.mnuItemExit.Index = 3;
            this.mnuItemExit.Text = "Exit";
            this.mnuItemExit.Click += new System.EventHandler(this.mnuItemExit_Click);
            // 
            // mnuManagement
            // 
            this.mnuManagement.Index = 1;
            this.mnuManagement.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuItemConnections});
            this.mnuManagement.Text = "Management";
            // 
            // mnuItemConnections
            // 
            this.mnuItemConnections.Index = 0;
            this.mnuItemConnections.Text = "Connections";
            // 
            // mnuLogging
            // 
            this.mnuLogging.Index = 2;
            this.mnuLogging.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuItemLogInfoMessages,
            this.mnuItemLogWarnings,
            this.mnuItemLogErrors,
            this.menuItem21,
            this.mnuItemWriteLogsToFile,
            this.menuItem22,
            this.mnuItemLogClientMessages,
            this.mnuItemLogServerMessages,
            this.menuItem23,
            this.mnuItemClearLog});
            this.mnuLogging.Text = "Logging";
            // 
            // mnuItemLogInfoMessages
            // 
            this.mnuItemLogInfoMessages.Checked = true;
            this.mnuItemLogInfoMessages.Index = 0;
            this.mnuItemLogInfoMessages.Text = "Log info messages";
            this.mnuItemLogInfoMessages.Click += new System.EventHandler(this.mnuItemLogInfoMessages_Click);
            // 
            // mnuItemLogWarnings
            // 
            this.mnuItemLogWarnings.Checked = true;
            this.mnuItemLogWarnings.Index = 1;
            this.mnuItemLogWarnings.Text = "Log warnings";
            this.mnuItemLogWarnings.Click += new System.EventHandler(this.mnuItemLogWarnings_Click);
            // 
            // mnuItemLogErrors
            // 
            this.mnuItemLogErrors.Checked = true;
            this.mnuItemLogErrors.Index = 2;
            this.mnuItemLogErrors.Text = "Log errors";
            this.mnuItemLogErrors.Click += new System.EventHandler(this.mnuItemLogErrors_Click);
            // 
            // menuItem21
            // 
            this.menuItem21.Index = 3;
            this.menuItem21.Text = "-";
            // 
            // mnuItemWriteLogsToFile
            // 
            this.mnuItemWriteLogsToFile.Checked = true;
            this.mnuItemWriteLogsToFile.Index = 4;
            this.mnuItemWriteLogsToFile.Text = "Write logs to file";
            this.mnuItemWriteLogsToFile.Click += new System.EventHandler(this.mnuItemWriteLogsToFile_Click);
            // 
            // menuItem22
            // 
            this.menuItem22.Index = 5;
            this.menuItem22.Text = "-";
            // 
            // mnuItemLogClientMessages
            // 
            this.mnuItemLogClientMessages.Checked = true;
            this.mnuItemLogClientMessages.Index = 6;
            this.mnuItemLogClientMessages.Text = "Log client messages";
            this.mnuItemLogClientMessages.Click += new System.EventHandler(this.mnuItemLogClientMessages_Click);
            // 
            // mnuItemLogServerMessages
            // 
            this.mnuItemLogServerMessages.Checked = true;
            this.mnuItemLogServerMessages.Index = 7;
            this.mnuItemLogServerMessages.Text = "Log server messages";
            this.mnuItemLogServerMessages.Click += new System.EventHandler(this.mnuItemLogServerMessages_Click);
            // 
            // menuItem23
            // 
            this.menuItem23.Index = 8;
            this.menuItem23.Text = "-";
            // 
            // mnuItemClearLog
            // 
            this.mnuItemClearLog.Index = 9;
            this.mnuItemClearLog.Text = "Clear log";
            this.mnuItemClearLog.Click += new System.EventHandler(this.mnuItemClearLog_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Index = 3;
            this.mnuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuItemHelp,
            this.mnuItemTutorials,
            this.menuItem12,
            this.mnuItemAbout});
            this.mnuHelp.Text = "Help";
            // 
            // mnuItemHelp
            // 
            this.mnuItemHelp.Index = 0;
            this.mnuItemHelp.Text = "Help";
            // 
            // mnuItemTutorials
            // 
            this.mnuItemTutorials.Index = 1;
            this.mnuItemTutorials.Text = "Tutorials";
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 2;
            this.menuItem12.Text = "-";
            // 
            // mnuItemAbout
            // 
            this.mnuItemAbout.Index = 3;
            this.mnuItemAbout.Text = "About";
            this.mnuItemAbout.Click += new System.EventHandler(this.mnuItemAbout_Click);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.BackColor = System.Drawing.Color.Black;
            this.txtLog.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.ForeColor = System.Drawing.Color.White;
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Margin = new System.Windows.Forms.Padding(0);
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.txtLog.Size = new System.Drawing.Size(571, 230);
            this.txtLog.TabIndex = 0;
            this.txtLog.Text = "";
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusOnlineUsers,
            this.tsOnlineUsers,
            this.tsSplit,
            this.statusWarnings,
            this.tsWarnings,
            this.tsSplit2,
            this.statusErrors,
            this.tsErrors});
            this.statusMain.Location = new System.Drawing.Point(0, 230);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(571, 22);
            this.statusMain.TabIndex = 1;
            this.statusMain.Text = "statusStrip1";
            // 
            // statusOnlineUsers
            // 
            this.statusOnlineUsers.Image = global::AQWE.Properties.Resources.onlineusers;
            this.statusOnlineUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusOnlineUsers.Name = "statusOnlineUsers";
            this.statusOnlineUsers.Size = new System.Drawing.Size(29, 17);
            this.statusOnlineUsers.Text = "0";
            // 
            // tsOnlineUsers
            // 
            this.tsOnlineUsers.Name = "tsOnlineUsers";
            this.tsOnlineUsers.Size = new System.Drawing.Size(73, 17);
            this.tsOnlineUsers.Text = "Online Users";
            // 
            // tsSplit
            // 
            this.tsSplit.Name = "tsSplit";
            this.tsSplit.Size = new System.Drawing.Size(10, 17);
            this.tsSplit.Text = "|";
            // 
            // statusWarnings
            // 
            this.statusWarnings.Image = global::AQWE.Properties.Resources.modicon;
            this.statusWarnings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusWarnings.Name = "statusWarnings";
            this.statusWarnings.Size = new System.Drawing.Size(29, 17);
            this.statusWarnings.Text = "0";
            // 
            // tsWarnings
            // 
            this.tsWarnings.Name = "tsWarnings";
            this.tsWarnings.Size = new System.Drawing.Size(57, 17);
            this.tsWarnings.Text = "Warnings";
            // 
            // tsSplit2
            // 
            this.tsSplit2.Name = "tsSplit2";
            this.tsSplit2.Size = new System.Drawing.Size(10, 17);
            this.tsSplit2.Text = "|";
            // 
            // statusErrors
            // 
            this.statusErrors.Image = global::AQWE.Properties.Resources.erroricon;
            this.statusErrors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusErrors.Name = "statusErrors";
            this.statusErrors.Size = new System.Drawing.Size(29, 17);
            this.statusErrors.Text = "0";
            // 
            // tsErrors
            // 
            this.tsErrors.Name = "tsErrors";
            this.tsErrors.Size = new System.Drawing.Size(37, 17);
            this.tsErrors.Text = "Errors";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 252);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.txtLog);
            this.Menu = this.mnuMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AQW Emulator [HARDCORE] - Build 1.0.1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MainMenu mnuMain;
        private System.Windows.Forms.MenuItem mnuServer;
        private System.Windows.Forms.MenuItem mnuItemStart;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem mnuItemStop;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem mnuItemExit;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem mnuManagement;
        private System.Windows.Forms.MenuItem mnuItemConnections;
        private System.Windows.Forms.MenuItem mnuHelp;
        private System.Windows.Forms.MenuItem mnuItemHelp;
        private System.Windows.Forms.MenuItem mnuItemTutorials;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.MenuItem mnuItemAbout;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.MenuItem mnuLogging;
        private System.Windows.Forms.MenuItem mnuItemLogInfoMessages;
        private System.Windows.Forms.MenuItem mnuItemLogWarnings;
        private System.Windows.Forms.MenuItem mnuItemLogErrors;
        private System.Windows.Forms.MenuItem menuItem21;
        private System.Windows.Forms.MenuItem mnuItemWriteLogsToFile;
        private System.Windows.Forms.MenuItem menuItem22;
        private System.Windows.Forms.MenuItem mnuItemLogClientMessages;
        private System.Windows.Forms.MenuItem mnuItemLogServerMessages;
        private System.Windows.Forms.MenuItem menuItem23;
        private System.Windows.Forms.MenuItem mnuItemClearLog;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripStatusLabel statusOnlineUsers;
        private System.Windows.Forms.ToolStripStatusLabel tsOnlineUsers;
        private System.Windows.Forms.ToolStripStatusLabel tsSplit;
        private System.Windows.Forms.ToolStripStatusLabel statusWarnings;
        private System.Windows.Forms.ToolStripStatusLabel tsWarnings;
        private System.Windows.Forms.ToolStripStatusLabel tsSplit2;
        private System.Windows.Forms.ToolStripStatusLabel statusErrors;
        private System.Windows.Forms.ToolStripStatusLabel tsErrors;

    }
}

