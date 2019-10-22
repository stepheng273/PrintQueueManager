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
            this.addRemoteButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pcName = new System.Windows.Forms.TextBox();
            this.remoteRadio = new System.Windows.Forms.RadioButton();
            this.localRadio = new System.Windows.Forms.RadioButton();
            this.addLocalButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.prtSearch = new System.Windows.Forms.TextBox();
            this.removeTab = new System.Windows.Forms.TabPage();
            this.remButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPrinter = new System.Windows.Forms.Label();
            this.prtList = new System.Windows.Forms.CheckedListBox();
            this.remRemoveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.remPcText = new System.Windows.Forms.TextBox();
            this.remRemoteRadio = new System.Windows.Forms.RadioButton();
            this.remLocalRadio = new System.Windows.Forms.RadioButton();
            this.getPrtButton = new System.Windows.Forms.Button();
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
            this.addTab.Controls.Add(this.addRemoteButton);
            this.addTab.Controls.Add(this.label3);
            this.addTab.Controls.Add(this.pcName);
            this.addTab.Controls.Add(this.remoteRadio);
            this.addTab.Controls.Add(this.localRadio);
            this.addTab.Controls.Add(this.addLocalButton);
            this.addTab.Controls.Add(this.label1);
            this.addTab.Controls.Add(this.prtSearch);
            this.addTab.Location = new System.Drawing.Point(4, 22);
            this.addTab.Name = "addTab";
            this.addTab.Padding = new System.Windows.Forms.Padding(3);
            this.addTab.Size = new System.Drawing.Size(203, 437);
            this.addTab.TabIndex = 1;
            this.addTab.Text = "Add";
            // 
            // addRemoteButton
            // 
            this.addRemoteButton.Location = new System.Drawing.Point(63, 290);
            this.addRemoteButton.Name = "addRemoteButton";
            this.addRemoteButton.Size = new System.Drawing.Size(75, 23);
            this.addRemoteButton.TabIndex = 16;
            this.addRemoteButton.Text = "Add";
            this.addRemoteButton.UseVisualStyleBackColor = true;
            this.addRemoteButton.Click += new System.EventHandler(this.addRemoteButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "PC Name:";
            // 
            // pcName
            // 
            this.pcName.Location = new System.Drawing.Point(26, 250);
            this.pcName.Name = "pcName";
            this.pcName.Size = new System.Drawing.Size(145, 20);
            this.pcName.TabIndex = 14;
            // 
            // remoteRadio
            // 
            this.remoteRadio.AutoSize = true;
            this.remoteRadio.Location = new System.Drawing.Point(7, 196);
            this.remoteRadio.Name = "remoteRadio";
            this.remoteRadio.Size = new System.Drawing.Size(62, 17);
            this.remoteRadio.TabIndex = 13;
            this.remoteRadio.Text = "Remote";
            this.remoteRadio.UseVisualStyleBackColor = true;
            // 
            // localRadio
            // 
            this.localRadio.AutoSize = true;
            this.localRadio.Checked = true;
            this.localRadio.Location = new System.Drawing.Point(5, 101);
            this.localRadio.Name = "localRadio";
            this.localRadio.Size = new System.Drawing.Size(51, 17);
            this.localRadio.TabIndex = 12;
            this.localRadio.TabStop = true;
            this.localRadio.Text = "Local";
            this.localRadio.UseVisualStyleBackColor = true;
            this.localRadio.CheckedChanged += new System.EventHandler(this.localRadio_CheckedChanged);
            // 
            // addLocalButton
            // 
            this.addLocalButton.AllowDrop = true;
            this.addLocalButton.Location = new System.Drawing.Point(63, 140);
            this.addLocalButton.Name = "addLocalButton";
            this.addLocalButton.Size = new System.Drawing.Size(75, 23);
            this.addLocalButton.TabIndex = 11;
            this.addLocalButton.Text = "Add";
            this.addLocalButton.UseVisualStyleBackColor = true;
            this.addLocalButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by queue name \r\nor IP address:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // prtSearch
            // 
            this.prtSearch.AllowDrop = true;
            this.prtSearch.Location = new System.Drawing.Point(26, 54);
            this.prtSearch.Name = "prtSearch";
            this.prtSearch.Size = new System.Drawing.Size(145, 20);
            this.prtSearch.TabIndex = 0;
            this.prtSearch.TextChanged += new System.EventHandler(this.prtSearch_TextChanged);
            // 
            // removeTab
            // 
            this.removeTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.removeTab.Controls.Add(this.getPrtButton);
            this.removeTab.Controls.Add(this.remLocalRadio);
            this.removeTab.Controls.Add(this.remRemoveButton);
            this.removeTab.Controls.Add(this.label4);
            this.removeTab.Controls.Add(this.remPcText);
            this.removeTab.Controls.Add(this.remRemoteRadio);
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
            this.remButton.Location = new System.Drawing.Point(73, 123);
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
            // remRemoveButton
            // 
            this.remRemoveButton.Location = new System.Drawing.Point(73, 327);
            this.remRemoveButton.Name = "remRemoveButton";
            this.remRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.remRemoveButton.TabIndex = 20;
            this.remRemoveButton.Text = "Remove";
            this.remRemoveButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "PC Name:";
            // 
            // remPcText
            // 
            this.remPcText.Location = new System.Drawing.Point(39, 251);
            this.remPcText.Name = "remPcText";
            this.remPcText.Size = new System.Drawing.Size(145, 20);
            this.remPcText.TabIndex = 18;
            // 
            // remRemoteRadio
            // 
            this.remRemoteRadio.AutoSize = true;
            this.remRemoteRadio.Location = new System.Drawing.Point(20, 197);
            this.remRemoteRadio.Name = "remRemoteRadio";
            this.remRemoteRadio.Size = new System.Drawing.Size(62, 17);
            this.remRemoteRadio.TabIndex = 17;
            this.remRemoteRadio.Text = "Remote";
            this.remRemoteRadio.UseVisualStyleBackColor = true;
            // 
            // remLocalRadio
            // 
            this.remLocalRadio.AutoSize = true;
            this.remLocalRadio.Checked = true;
            this.remLocalRadio.Location = new System.Drawing.Point(20, 78);
            this.remLocalRadio.Name = "remLocalRadio";
            this.remLocalRadio.Size = new System.Drawing.Size(51, 17);
            this.remLocalRadio.TabIndex = 21;
            this.remLocalRadio.TabStop = true;
            this.remLocalRadio.Text = "Local";
            this.remLocalRadio.UseVisualStyleBackColor = true;
            // 
            // getPrtButton
            // 
            this.getPrtButton.Location = new System.Drawing.Point(49, 277);
            this.getPrtButton.Name = "getPrtButton";
            this.getPrtButton.Size = new System.Drawing.Size(126, 23);
            this.getPrtButton.TabIndex = 22;
            this.getPrtButton.Text = "Get Installed Printers";
            this.getPrtButton.UseVisualStyleBackColor = true;
            this.getPrtButton.Click += new System.EventHandler(this.getPrtButton_Click);
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
        private System.Windows.Forms.Button addLocalButton;
        private System.Windows.Forms.Button remButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pcName;
        private System.Windows.Forms.RadioButton remoteRadio;
        private System.Windows.Forms.RadioButton localRadio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addRemoteButton;
        private System.Windows.Forms.Button getPrtButton;
        private System.Windows.Forms.RadioButton remLocalRadio;
        private System.Windows.Forms.Button remRemoveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox remPcText;
        private System.Windows.Forms.RadioButton remRemoteRadio;
    }
}

