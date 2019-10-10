namespace PrintQueues
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.depList = new System.Windows.Forms.ListBox();
            this.prtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPrinter = new System.Windows.Forms.Label();
            this.prtList = new System.Windows.Forms.CheckedListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(24, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Get Printers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbSite
            // 
            this.lbSite.AutoSize = true;
            this.lbSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSite.Location = new System.Drawing.Point(46, 18);
            this.lbSite.Name = "lbSite";
            this.lbSite.Size = new System.Drawing.Size(37, 20);
            this.lbSite.TabIndex = 2;
            this.lbSite.Text = "Site";
            this.lbSite.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartment.Location = new System.Drawing.Point(20, 168);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(94, 20);
            this.lbDepartment.TabIndex = 3;
            this.lbDepartment.Text = "Department";
            this.lbDepartment.Visible = false;
            this.lbDepartment.Click += new System.EventHandler(this.label2_Click);
            // 
            // siteList
            // 
            this.siteList.FormattingEnabled = true;
            this.siteList.Location = new System.Drawing.Point(10, 41);
            this.siteList.Name = "siteList";
            this.siteList.Size = new System.Drawing.Size(120, 95);
            this.siteList.TabIndex = 7;
            this.siteList.SelectedIndexChanged += new System.EventHandler(this.listSite_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(190, 463);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.depList);
            this.tabPage1.Controls.Add(this.lbDepartment);
            this.tabPage1.Controls.Add(this.siteList);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.lbSite);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(182, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.prtSearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(182, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // depList
            // 
            this.depList.FormattingEnabled = true;
            this.depList.Location = new System.Drawing.Point(11, 191);
            this.depList.Name = "depList";
            this.depList.Size = new System.Drawing.Size(120, 95);
            this.depList.TabIndex = 8;
            // 
            // prtSearch
            // 
            this.prtSearch.AllowDrop = true;
            this.prtSearch.Location = new System.Drawing.Point(7, 27);
            this.prtSearch.Name = "prtSearch";
            this.prtSearch.Size = new System.Drawing.Size(145, 20);
            this.prtSearch.TabIndex = 0;
            this.prtSearch.TextChanged += new System.EventHandler(this.prtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search:";
            // 
            // lbPrinter
            // 
            this.lbPrinter.AutoSize = true;
            this.lbPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrinter.Location = new System.Drawing.Point(204, 34);
            this.lbPrinter.Name = "lbPrinter";
            this.lbPrinter.Size = new System.Drawing.Size(63, 20);
            this.lbPrinter.TabIndex = 9;
            this.lbPrinter.Text = "Printers";
            this.lbPrinter.Visible = false;
            // 
            // prtList
            // 
            this.prtList.CheckOnClick = true;
            this.prtList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prtList.FormattingEnabled = true;
            this.prtList.Location = new System.Drawing.Point(208, 76);
            this.prtList.Name = "prtList";
            this.prtList.Size = new System.Drawing.Size(666, 364);
            this.prtList.TabIndex = 10;
            // 
            // addButton
            // 
            this.addButton.AllowDrop = true;
            this.addButton.Location = new System.Drawing.Point(491, 448);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(182, 437);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 498);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.prtList);
            this.Controls.Add(this.lbPrinter);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
    }
}

