﻿
namespace ChildSafe
{
    partial class mainHall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainHall));
            this.lbPromote = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whitelistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vietnamseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoupdateFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.checkForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbNotice = new System.Windows.Forms.Label();
            this.saparator = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.options = new System.Windows.Forms.LinkLabel();
            this.lbLoadingStatus = new System.Windows.Forms.Label();
            this.timerQuote = new System.Windows.Forms.Timer(this.components);
            this.panelLoading = new System.Windows.Forms.Panel();
            this.gbUpdate = new System.Windows.Forms.GroupBox();
            this.btIgnore = new System.Windows.Forms.Button();
            this.btDownload = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbUpdateDetail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureMainHall = new System.Windows.Forms.PictureBox();
            this.btMenu = new System.Windows.Forms.PictureBox();
            this.panelPagesSwitch = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.PictureBox();
            this.panelHomeWithControl = new System.Windows.Forms.Panel();
            this.contextMenu.SuspendLayout();
            this.panelLoading.SuspendLayout();
            this.gbUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMainHall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMenu)).BeginInit();
            this.panelPagesSwitch.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btBack)).BeginInit();
            this.panelHomeWithControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPromote
            // 
            resources.ApplyResources(this.lbPromote, "lbPromote");
            this.lbPromote.ForeColor = System.Drawing.Color.Navy;
            this.lbPromote.Name = "lbPromote";
            // 
            // btStart
            // 
            resources.ApplyResources(this.btStart, "btStart");
            this.btStart.Name = "btStart";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtersToolStripMenuItem,
            this.whitelistToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.checkForUpdateToolStripMenuItem,
            this.githubToolStripMenuItem,
            this.sendFeedbackToolStripMenuItem,
            this.toolStripMenuItem2,
            this.aboutToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            resources.ApplyResources(this.contextMenu, "contextMenu");
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            resources.ApplyResources(this.filtersToolStripMenuItem, "filtersToolStripMenuItem");
            this.filtersToolStripMenuItem.Click += new System.EventHandler(this.filtersToolStripMenuItem_Click);
            // 
            // whitelistToolStripMenuItem
            // 
            this.whitelistToolStripMenuItem.Name = "whitelistToolStripMenuItem";
            resources.ApplyResources(this.whitelistToolStripMenuItem, "whitelistToolStripMenuItem");
            this.whitelistToolStripMenuItem.Click += new System.EventHandler(this.whitelistToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.autoupdateFilterToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.vietnamseToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // vietnamseToolStripMenuItem
            // 
            this.vietnamseToolStripMenuItem.Name = "vietnamseToolStripMenuItem";
            resources.ApplyResources(this.vietnamseToolStripMenuItem, "vietnamseToolStripMenuItem");
            this.vietnamseToolStripMenuItem.Click += new System.EventHandler(this.vietnamseToolStripMenuItem_Click);
            // 
            // autoupdateFilterToolStripMenuItem
            // 
            this.autoupdateFilterToolStripMenuItem.Checked = true;
            this.autoupdateFilterToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoupdateFilterToolStripMenuItem.Name = "autoupdateFilterToolStripMenuItem";
            resources.ApplyResources(this.autoupdateFilterToolStripMenuItem, "autoupdateFilterToolStripMenuItem");
            this.autoupdateFilterToolStripMenuItem.Click += new System.EventHandler(this.autoupdateFilterToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            // 
            // checkForUpdateToolStripMenuItem
            // 
            this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            resources.ApplyResources(this.checkForUpdateToolStripMenuItem, "checkForUpdateToolStripMenuItem");
            this.checkForUpdateToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdateToolStripMenuItem_Click);
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.Image = global::ChildSafe.Properties.Resources.github_20;
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            resources.ApplyResources(this.githubToolStripMenuItem, "githubToolStripMenuItem");
            this.githubToolStripMenuItem.Click += new System.EventHandler(this.githubToolStripMenuItem_Click);
            // 
            // sendFeedbackToolStripMenuItem
            // 
            this.sendFeedbackToolStripMenuItem.Name = "sendFeedbackToolStripMenuItem";
            resources.ApplyResources(this.sendFeedbackToolStripMenuItem, "sendFeedbackToolStripMenuItem");
            this.sendFeedbackToolStripMenuItem.Click += new System.EventHandler(this.sendFeedbackToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::ChildSafe.Properties.Resources.info_20;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lbNotice
            // 
            this.lbNotice.ForeColor = System.Drawing.SystemColors.WindowFrame;
            resources.ApplyResources(this.lbNotice, "lbNotice");
            this.lbNotice.Name = "lbNotice";
            // 
            // saparator
            // 
            this.saparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.saparator, "saparator");
            this.saparator.Name = "saparator";
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // options
            // 
            resources.ApplyResources(this.options, "options");
            this.options.LinkColor = System.Drawing.Color.MediumBlue;
            this.options.Name = "options";
            this.options.TabStop = true;
            this.options.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.options_LinkClicked);
            // 
            // lbLoadingStatus
            // 
            resources.ApplyResources(this.lbLoadingStatus, "lbLoadingStatus");
            this.lbLoadingStatus.Name = "lbLoadingStatus";
            // 
            // timerQuote
            // 
            this.timerQuote.Enabled = true;
            this.timerQuote.Interval = 8000;
            this.timerQuote.Tick += new System.EventHandler(this.timerQuote_Tick);
            // 
            // panelLoading
            // 
            this.panelLoading.Controls.Add(this.lbLoadingStatus);
            this.panelLoading.Controls.Add(this.progressBar1);
            resources.ApplyResources(this.panelLoading, "panelLoading");
            this.panelLoading.Name = "panelLoading";
            // 
            // gbUpdate
            // 
            this.gbUpdate.Controls.Add(this.btIgnore);
            this.gbUpdate.Controls.Add(this.btDownload);
            this.gbUpdate.Controls.Add(this.pictureBox2);
            this.gbUpdate.Controls.Add(this.lbUpdateDetail);
            this.gbUpdate.Controls.Add(this.label1);
            resources.ApplyResources(this.gbUpdate, "gbUpdate");
            this.gbUpdate.Name = "gbUpdate";
            this.gbUpdate.TabStop = false;
            // 
            // btIgnore
            // 
            resources.ApplyResources(this.btIgnore, "btIgnore");
            this.btIgnore.Name = "btIgnore";
            this.btIgnore.UseVisualStyleBackColor = true;
            this.btIgnore.Click += new System.EventHandler(this.btIgnore_Click);
            // 
            // btDownload
            // 
            resources.ApplyResources(this.btDownload, "btDownload");
            this.btDownload.Name = "btDownload";
            this.btDownload.UseVisualStyleBackColor = true;
            this.btDownload.Click += new System.EventHandler(this.btDownload_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ChildSafe.Properties.Resources._5172958_security_communication_comment_talk_internet_chat_message;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // lbUpdateDetail
            // 
            resources.ApplyResources(this.lbUpdateDetail, "lbUpdateDetail");
            this.lbUpdateDetail.Name = "lbUpdateDetail";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // refresh
            // 
            this.refresh.Interval = 2000;
            this.refresh.Tick += new System.EventHandler(this.refresh_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChildSafe.Properties.Resources._5173004_mail_warning_internet_email_security_alert_attention1;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureMainHall
            // 
            this.pictureMainHall.Image = global::ChildSafe.Properties.Resources.check_blue_128;
            resources.ApplyResources(this.pictureMainHall, "pictureMainHall");
            this.pictureMainHall.Name = "pictureMainHall";
            this.pictureMainHall.TabStop = false;
            // 
            // btMenu
            // 
            this.btMenu.ContextMenuStrip = this.contextMenu;
            this.btMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMenu.Image = global::ChildSafe.Properties.Resources.more_24;
            resources.ApplyResources(this.btMenu, "btMenu");
            this.btMenu.Name = "btMenu";
            this.btMenu.TabStop = false;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // panelPagesSwitch
            // 
            this.panelPagesSwitch.Controls.Add(this.panelHomeWithControl);
            resources.ApplyResources(this.panelPagesSwitch, "panelPagesSwitch");
            this.panelPagesSwitch.Name = "panelPagesSwitch";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Controls.Add(this.btBack);
            this.panel1.Controls.Add(this.btMenu);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lbTitle
            // 
            resources.ApplyResources(this.lbTitle, "lbTitle");
            this.lbTitle.Name = "lbTitle";
            // 
            // btBack
            // 
            this.btBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBack.Image = global::ChildSafe.Properties.Resources.back_24;
            resources.ApplyResources(this.btBack, "btBack");
            this.btBack.Name = "btBack";
            this.btBack.TabStop = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // panelHomeWithControl
            // 
            this.panelHomeWithControl.Controls.Add(this.gbUpdate);
            this.panelHomeWithControl.Controls.Add(this.panelLoading);
            this.panelHomeWithControl.Controls.Add(this.pictureBox1);
            this.panelHomeWithControl.Controls.Add(this.options);
            this.panelHomeWithControl.Controls.Add(this.lbNotice);
            this.panelHomeWithControl.Controls.Add(this.btStart);
            this.panelHomeWithControl.Controls.Add(this.pictureMainHall);
            this.panelHomeWithControl.Controls.Add(this.lbPromote);
            resources.ApplyResources(this.panelHomeWithControl, "panelHomeWithControl");
            this.panelHomeWithControl.Name = "panelHomeWithControl";
            // 
            // mainHall
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPagesSwitch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saparator);
            this.MaximizeBox = false;
            this.Name = "mainHall";
            this.Load += new System.EventHandler(this.mainHall_Load);
            this.contextMenu.ResumeLayout(false);
            this.panelLoading.ResumeLayout(false);
            this.panelLoading.PerformLayout();
            this.gbUpdate.ResumeLayout(false);
            this.gbUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMainHall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMenu)).EndInit();
            this.panelPagesSwitch.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btBack)).EndInit();
            this.panelHomeWithControl.ResumeLayout(false);
            this.panelHomeWithControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btMenu;
        private System.Windows.Forms.PictureBox pictureMainHall;
        private System.Windows.Forms.Label lbPromote;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label lbNotice;
        private System.Windows.Forms.Label saparator;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.LinkLabel options;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendFeedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lbLoadingStatus;
        private System.Windows.Forms.Timer timerQuote;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whitelistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vietnamseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoupdateFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLoading;
        private System.Windows.Forms.GroupBox gbUpdate;
        private System.Windows.Forms.Label lbUpdateDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btIgnore;
        private System.Windows.Forms.Button btDownload;
        private System.Windows.Forms.Timer refresh;
        private System.Windows.Forms.Panel panelPagesSwitch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox btBack;
        private System.Windows.Forms.Panel panelHomeWithControl;
    }
}

