﻿namespace PrintQueues
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbSite = new System.Windows.Forms.Label();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.siteList = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.prtSearch = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.depList = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.remButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPrinter = new System.Windows.Forms.Label();
            this.prtList = new System.Windows.Forms.CheckedListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(147, 808);
            this.button1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Get Printers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbSite
            // 
            this.lbSite.AutoSize = true;
            this.lbSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSite.Location = new System.Drawing.Point(196, 49);
            this.lbSite.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbSite.Name = "lbSite";
            this.lbSite.Size = new System.Drawing.Size(79, 40);
            this.lbSite.TabIndex = 2;
            this.lbSite.Text = "Site";
            this.lbSite.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartment.Location = new System.Drawing.Point(128, 379);
            this.lbDepartment.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(205, 40);
            this.lbDepartment.TabIndex = 3;
            this.lbDepartment.Text = "Department";
            this.lbDepartment.Visible = false;
            this.lbDepartment.Click += new System.EventHandler(this.label2_Click);
            // 
            // siteList
            // 
            this.siteList.FormattingEnabled = true;
            this.siteList.ItemHeight = 29;
            this.siteList.Location = new System.Drawing.Point(94, 96);
            this.siteList.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.siteList.Name = "siteList";
            this.siteList.Size = new System.Drawing.Size(275, 207);
            this.siteList.TabIndex = 7;
            this.siteList.SelectedIndexChanged += new System.EventHandler(this.listSite_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(28, 27);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(492, 1033);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.prtSearch);
            this.tabPage2.Location = new System.Drawing.Point(10, 47);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabPage2.Size = new System.Drawing.Size(472, 976);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "All";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by queue name \r\nor IP address:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // prtSearch
            // 
            this.prtSearch.AllowDrop = true;
            this.prtSearch.Location = new System.Drawing.Point(59, 136);
            this.prtSearch.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.prtSearch.Name = "prtSearch";
            this.prtSearch.Size = new System.Drawing.Size(333, 35);
            this.prtSearch.TabIndex = 0;
            this.prtSearch.TextChanged += new System.EventHandler(this.prtSearch_TextChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.depList);
            this.tabPage1.Controls.Add(this.lbDepartment);
            this.tabPage1.Controls.Add(this.siteList);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.lbSite);
            this.tabPage1.Location = new System.Drawing.Point(10, 47);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabPage1.Size = new System.Drawing.Size(472, 976);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filter";
            // 
            // depList
            // 
            this.depList.FormattingEnabled = true;
            this.depList.ItemHeight = 29;
            this.depList.Location = new System.Drawing.Point(94, 426);
            this.depList.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.depList.Name = "depList";
            this.depList.Size = new System.Drawing.Size(275, 207);
            this.depList.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.remButton);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(10, 47);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(472, 976);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Remove";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // remButton
            // 
            this.remButton.Location = new System.Drawing.Point(133, 147);
            this.remButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.remButton.Name = "remButton";
            this.remButton.Size = new System.Drawing.Size(175, 51);
            this.remButton.TabIndex = 1;
            this.remButton.Text = "Remove";
            this.remButton.UseVisualStyleBackColor = true;
            this.remButton.Click += new System.EventHandler(this.remButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 72);
            this.label2.TabIndex = 0;
            this.label2.Text = "Check printer(s) to remove\r\nthen click remove";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbPrinter
            // 
            this.lbPrinter.AutoSize = true;
            this.lbPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrinter.Location = new System.Drawing.Point(525, 76);
            this.lbPrinter.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbPrinter.Name = "lbPrinter";
            this.lbPrinter.Size = new System.Drawing.Size(141, 40);
            this.lbPrinter.TabIndex = 9;
            this.lbPrinter.Text = "Printers";
            this.lbPrinter.Visible = false;
            // 
            // prtList
            // 
            this.prtList.CheckOnClick = true;
            this.prtList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prtList.FormattingEnabled = true;
            this.prtList.Location = new System.Drawing.Point(534, 170);
            this.prtList.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.prtList.Name = "prtList";
            this.prtList.Size = new System.Drawing.Size(1500, 804);
            this.prtList.TabIndex = 10;
            // 
            // addButton
            // 
            this.addButton.AllowDrop = true;
            this.addButton.Location = new System.Drawing.Point(1146, 999);
            this.addButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(175, 51);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2077, 1115);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.prtList);
            this.Controls.Add(this.lbPrinter);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbSite;
        private System.Windows.Forms.Label lbDepartment;
        private System.Windows.Forms.ListBox siteList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox depList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prtSearch;
        private System.Windows.Forms.Label lbPrinter;
        private System.Windows.Forms.CheckedListBox prtList;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button remButton;
        private System.Windows.Forms.Label label2;
    }
}

