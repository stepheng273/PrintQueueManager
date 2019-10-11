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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.addTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.prtSearch = new System.Windows.Forms.TextBox();
            this.removeTab = new System.Windows.Forms.TabPage();
            this.remButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPrinter = new System.Windows.Forms.Label();
            this.prtList = new System.Windows.Forms.CheckedListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.addTab.SuspendLayout();
            this.removeTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.addTab);
            this.tabControl1.Controls.Add(this.removeTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(211, 463);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // addTab
            // 
            this.addTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addTab.Controls.Add(this.addButton);
            this.addTab.Controls.Add(this.label1);
            this.addTab.Controls.Add(this.prtSearch);
            this.addTab.Location = new System.Drawing.Point(4, 22);
            this.addTab.Name = "addTab";
            this.addTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.addTab.Size = new System.Drawing.Size(203, 437);
            this.addTab.TabIndex = 1;
            this.addTab.Text = "Add";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by queue name \r\nor IP address:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // prtSearch
            // 
            this.prtSearch.AllowDrop = true;
            this.prtSearch.Location = new System.Drawing.Point(25, 61);
            this.prtSearch.Name = "prtSearch";
            this.prtSearch.Size = new System.Drawing.Size(145, 20);
            this.prtSearch.TabIndex = 0;
            this.prtSearch.TextChanged += new System.EventHandler(this.prtSearch_TextChanged);
            // 
            // removeTab
            // 
            this.removeTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.removeTab.Controls.Add(this.remButton);
            this.removeTab.Controls.Add(this.label2);
            this.removeTab.Location = new System.Drawing.Point(4, 22);
            this.removeTab.Name = "removeTab";
            this.removeTab.Size = new System.Drawing.Size(203, 437);
            this.removeTab.TabIndex = 2;
            this.removeTab.Text = "Remove";
            // 
            // remButton
            // 
            this.remButton.Location = new System.Drawing.Point(57, 66);
            this.remButton.Name = "remButton";
            this.remButton.Size = new System.Drawing.Size(75, 23);
            this.remButton.TabIndex = 1;
            this.remButton.Text = "Remove";
            this.remButton.UseVisualStyleBackColor = true;
            this.remButton.Click += new System.EventHandler(this.remButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Check printer(s) to remove\r\nthen click remove";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbPrinter
            // 
            this.lbPrinter.AutoSize = true;
            this.lbPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrinter.Location = new System.Drawing.Point(225, 34);
            this.lbPrinter.Name = "lbPrinter";
            this.lbPrinter.Size = new System.Drawing.Size(63, 20);
            this.lbPrinter.TabIndex = 9;
            this.lbPrinter.Text = "Printers";
            // 
            // prtList
            // 
            this.prtList.CheckOnClick = true;
            this.prtList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prtList.FormattingEnabled = true;
            this.prtList.Location = new System.Drawing.Point(229, 76);
            this.prtList.Name = "prtList";
            this.prtList.Size = new System.Drawing.Size(645, 346);
            this.prtList.TabIndex = 10;
            // 
            // addButton
            // 
            this.addButton.AllowDrop = true;
            this.addButton.Location = new System.Drawing.Point(52, 111);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 476);
            this.Controls.Add(this.prtList);
            this.Controls.Add(this.lbPrinter);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.addTab.ResumeLayout(false);
            this.addTab.PerformLayout();
            this.removeTab.ResumeLayout(false);
            this.removeTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prtSearch;
        private System.Windows.Forms.Label lbPrinter;
        private System.Windows.Forms.CheckedListBox prtList;
        private System.Windows.Forms.TabPage removeTab;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button remButton;
        private System.Windows.Forms.Label label2;
    }
}

