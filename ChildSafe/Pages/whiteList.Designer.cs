﻿
namespace ChildSafe
{
    partial class whiteList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(whiteList));
            this.btApply = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnControlWhitelist = new System.Windows.Forms.Panel();
            this.btRemove = new System.Windows.Forms.Button();
            this.btAdd2Table = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txUrl2AddWhiteList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btDisable = new System.Windows.Forms.Button();
            this.tbWhitelist = new System.Windows.Forms.DataGridView();
            this.urlAdded2Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.pnControlWhitelist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbWhitelist)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btApply
            // 
            resources.ApplyResources(this.btApply, "btApply");
            this.btApply.Name = "btApply";
            this.btApply.UseVisualStyleBackColor = true;
            this.btApply.Click += new System.EventHandler(this.btApply_Click);
            // 
            // btCancel
            // 
            resources.ApplyResources(this.btCancel, "btCancel");
            this.btCancel.Name = "btCancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click_1);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnControlWhitelist);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btDisable);
            this.panel2.Controls.Add(this.tbWhitelist);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // pnControlWhitelist
            // 
            this.pnControlWhitelist.Controls.Add(this.btRemove);
            this.pnControlWhitelist.Controls.Add(this.btAdd2Table);
            this.pnControlWhitelist.Controls.Add(this.label1);
            this.pnControlWhitelist.Controls.Add(this.txUrl2AddWhiteList);
            resources.ApplyResources(this.pnControlWhitelist, "pnControlWhitelist");
            this.pnControlWhitelist.Name = "pnControlWhitelist";
            // 
            // btRemove
            // 
            resources.ApplyResources(this.btRemove, "btRemove");
            this.btRemove.Name = "btRemove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btAdd2Table
            // 
            resources.ApplyResources(this.btAdd2Table, "btAdd2Table");
            this.btAdd2Table.Name = "btAdd2Table";
            this.btAdd2Table.UseVisualStyleBackColor = true;
            this.btAdd2Table.Click += new System.EventHandler(this.btAdd2Table_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txUrl2AddWhiteList
            // 
            this.txUrl2AddWhiteList.FormattingEnabled = true;
            resources.ApplyResources(this.txUrl2AddWhiteList, "txUrl2AddWhiteList");
            this.txUrl2AddWhiteList.Name = "txUrl2AddWhiteList";
            this.txUrl2AddWhiteList.SelectedIndexChanged += new System.EventHandler(this.txUrl2AddWhiteList_SelectedIndexChanged);
            this.txUrl2AddWhiteList.TextChanged += new System.EventHandler(this.txUrl2AddWhiteList_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Name = "label3";
            // 
            // btDisable
            // 
            resources.ApplyResources(this.btDisable, "btDisable");
            this.btDisable.Name = "btDisable";
            this.btDisable.UseVisualStyleBackColor = true;
            this.btDisable.Click += new System.EventHandler(this.btDisable_Click);
            // 
            // tbWhitelist
            // 
            this.tbWhitelist.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tbWhitelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbWhitelist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urlAdded2Table});
            resources.ApplyResources(this.tbWhitelist, "tbWhitelist");
            this.tbWhitelist.Name = "tbWhitelist";
            // 
            // urlAdded2Table
            // 
            resources.ApplyResources(this.urlAdded2Table, "urlAdded2Table");
            this.urlAdded2Table.Name = "urlAdded2Table";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btApply);
            this.panel3.Controls.Add(this.btCancel);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // whiteList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "whiteList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.whiteList_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnControlWhitelist.ResumeLayout(false);
            this.pnControlWhitelist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbWhitelist)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btApply;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnControlWhitelist;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btAdd2Table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txUrl2AddWhiteList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btDisable;
        private System.Windows.Forms.DataGridView tbWhitelist;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlAdded2Table;
        private System.Windows.Forms.Panel panel3;
    }
}