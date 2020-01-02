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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.prtList = new System.Windows.Forms.DataGridView();
            this.addColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.queueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.addTab = new System.Windows.Forms.TabPage();
            this.prtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pcName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.remoteRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.localRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.removeTab = new System.Windows.Forms.TabPage();
            this.removePcName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.remRemoveButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.getPrtButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.remButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.remRemoteRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.remLocalRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.DarkMode = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.addLocalButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.addRemoteButton = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.prtList)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.addTab.SuspendLayout();
            this.removeTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // prtList
            // 
            this.prtList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prtList.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.prtList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prtList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prtList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.prtList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prtList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addColumn,
            this.queueName,
            this.ipAddress});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prtList.DefaultCellStyle = dataGridViewCellStyle2;
            this.prtList.Location = new System.Drawing.Point(233, 99);
            this.prtList.Name = "prtList";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prtList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.prtList.RowHeadersVisible = false;
            this.prtList.Size = new System.Drawing.Size(646, 436);
            this.prtList.TabIndex = 12;
            this.prtList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // addColumn
            // 
            this.addColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.addColumn.HeaderText = "√";
            this.addColumn.Name = "addColumn";
            this.addColumn.Width = 22;
            // 
            // queueName
            // 
            this.queueName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.queueName.HeaderText = "Queue";
            this.queueName.Name = "queueName";
            this.queueName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.queueName.Width = 73;
            // 
            // ipAddress
            // 
            this.ipAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ipAddress.HeaderText = "IP";
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Width = 45;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.addTab);
            this.tabControl1.Controls.Add(this.removeTab);
            this.tabControl1.Depth = 0;
            this.tabControl1.Location = new System.Drawing.Point(12, 106);
            this.tabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(215, 419);
            this.tabControl1.TabIndex = 13;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // addTab
            // 
            this.addTab.BackColor = System.Drawing.Color.White;
            this.addTab.Controls.Add(this.addRemoteButton);
            this.addTab.Controls.Add(this.addLocalButton);
            this.addTab.Controls.Add(this.prtSearch);
            this.addTab.Controls.Add(this.pcName);
            this.addTab.Controls.Add(this.materialLabel2);
            this.addTab.Controls.Add(this.remoteRadio);
            this.addTab.Controls.Add(this.localRadio);
            this.addTab.Controls.Add(this.materialLabel1);
            this.addTab.Location = new System.Drawing.Point(4, 22);
            this.addTab.Name = "addTab";
            this.addTab.Padding = new System.Windows.Forms.Padding(3);
            this.addTab.Size = new System.Drawing.Size(207, 393);
            this.addTab.TabIndex = 0;
            this.addTab.Text = "Add";
            // 
            // prtSearch
            // 
            this.prtSearch.Depth = 0;
            this.prtSearch.Hint = "";
            this.prtSearch.Location = new System.Drawing.Point(17, 53);
            this.prtSearch.MaxLength = 32767;
            this.prtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.prtSearch.Name = "prtSearch";
            this.prtSearch.PasswordChar = '\0';
            this.prtSearch.SelectedText = "";
            this.prtSearch.SelectionLength = 0;
            this.prtSearch.SelectionStart = 0;
            this.prtSearch.Size = new System.Drawing.Size(159, 23);
            this.prtSearch.TabIndex = 23;
            this.prtSearch.TabStop = false;
            this.prtSearch.UseSystemPasswordChar = false;
            this.prtSearch.TextChanged += new System.EventHandler(this.prtSearch_TextChanged);
            // 
            // pcName
            // 
            this.pcName.Depth = 0;
            this.pcName.Hint = "";
            this.pcName.Location = new System.Drawing.Point(17, 283);
            this.pcName.MaxLength = 32767;
            this.pcName.MouseState = MaterialSkin.MouseState.HOVER;
            this.pcName.Name = "pcName";
            this.pcName.PasswordChar = '\0';
            this.pcName.SelectedText = "";
            this.pcName.SelectionLength = 0;
            this.pcName.SelectionStart = 0;
            this.pcName.Size = new System.Drawing.Size(159, 23);
            this.pcName.TabIndex = 16;
            this.pcName.TabStop = false;
            this.pcName.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(22, 261);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(76, 19);
            this.materialLabel2.TabIndex = 22;
            this.materialLabel2.Text = "PC Name:";
            // 
            // remoteRadio
            // 
            this.remoteRadio.AutoSize = true;
            this.remoteRadio.Depth = 0;
            this.remoteRadio.Font = new System.Drawing.Font("Roboto", 10F);
            this.remoteRadio.Location = new System.Drawing.Point(7, 213);
            this.remoteRadio.Margin = new System.Windows.Forms.Padding(0);
            this.remoteRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.remoteRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.remoteRadio.Name = "remoteRadio";
            this.remoteRadio.Ripple = true;
            this.remoteRadio.Size = new System.Drawing.Size(77, 30);
            this.remoteRadio.TabIndex = 20;
            this.remoteRadio.Text = "Remote";
            this.remoteRadio.UseVisualStyleBackColor = true;
            this.remoteRadio.CheckedChanged += new System.EventHandler(this.localRadio_CheckedChanged);
            // 
            // localRadio
            // 
            this.localRadio.AutoSize = true;
            this.localRadio.Checked = true;
            this.localRadio.Depth = 0;
            this.localRadio.Font = new System.Drawing.Font("Roboto", 10F);
            this.localRadio.Location = new System.Drawing.Point(7, 112);
            this.localRadio.Margin = new System.Windows.Forms.Padding(0);
            this.localRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.localRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.localRadio.Name = "localRadio";
            this.localRadio.Ripple = true;
            this.localRadio.Size = new System.Drawing.Size(62, 30);
            this.localRadio.TabIndex = 19;
            this.localRadio.TabStop = true;
            this.localRadio.Text = "Local";
            this.localRadio.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(22, 12);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(164, 38);
            this.materialLabel1.TabIndex = 17;
            this.materialLabel1.Text = "Search by queue name \r\nor IP address:\r\n";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // removeTab
            // 
            this.removeTab.BackColor = System.Drawing.Color.White;
            this.removeTab.Controls.Add(this.removePcName);
            this.removeTab.Controls.Add(this.remRemoveButton);
            this.removeTab.Controls.Add(this.getPrtButton);
            this.removeTab.Controls.Add(this.remButton);
            this.removeTab.Controls.Add(this.materialLabel4);
            this.removeTab.Controls.Add(this.remRemoteRadio);
            this.removeTab.Controls.Add(this.remLocalRadio);
            this.removeTab.Controls.Add(this.materialLabel3);
            this.removeTab.Location = new System.Drawing.Point(4, 22);
            this.removeTab.Name = "removeTab";
            this.removeTab.Padding = new System.Windows.Forms.Padding(3);
            this.removeTab.Size = new System.Drawing.Size(207, 393);
            this.removeTab.TabIndex = 1;
            this.removeTab.Text = "Remove";
            // 
            // removePcName
            // 
            this.removePcName.Depth = 0;
            this.removePcName.Hint = "";
            this.removePcName.Location = new System.Drawing.Point(28, 248);
            this.removePcName.MaxLength = 32767;
            this.removePcName.MouseState = MaterialSkin.MouseState.HOVER;
            this.removePcName.Name = "removePcName";
            this.removePcName.PasswordChar = '\0';
            this.removePcName.SelectedText = "";
            this.removePcName.SelectionLength = 0;
            this.removePcName.SelectionStart = 0;
            this.removePcName.Size = new System.Drawing.Size(137, 23);
            this.removePcName.TabIndex = 30;
            this.removePcName.TabStop = false;
            this.removePcName.UseSystemPasswordChar = false;
            // 
            // remRemoveButton
            // 
            this.remRemoveButton.AutoSize = true;
            this.remRemoveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.remRemoveButton.Depth = 0;
            this.remRemoveButton.Icon = null;
            this.remRemoveButton.Location = new System.Drawing.Point(62, 319);
            this.remRemoveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.remRemoveButton.Name = "remRemoveButton";
            this.remRemoveButton.Primary = true;
            this.remRemoveButton.Size = new System.Drawing.Size(75, 36);
            this.remRemoveButton.TabIndex = 29;
            this.remRemoveButton.Text = "Remove";
            this.remRemoveButton.UseVisualStyleBackColor = true;
            this.remRemoveButton.Click += new System.EventHandler(this.remRemoveButton_Click);
            // 
            // getPrtButton
            // 
            this.getPrtButton.AutoSize = true;
            this.getPrtButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.getPrtButton.Depth = 0;
            this.getPrtButton.Icon = null;
            this.getPrtButton.Location = new System.Drawing.Point(9, 277);
            this.getPrtButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.getPrtButton.Name = "getPrtButton";
            this.getPrtButton.Primary = true;
            this.getPrtButton.Size = new System.Drawing.Size(188, 36);
            this.getPrtButton.TabIndex = 28;
            this.getPrtButton.Text = "Get Installed Printers";
            this.getPrtButton.UseVisualStyleBackColor = true;
            this.getPrtButton.Click += new System.EventHandler(this.getPrtButton_Click);
            // 
            // remButton
            // 
            this.remButton.AutoSize = true;
            this.remButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.remButton.Depth = 0;
            this.remButton.Icon = null;
            this.remButton.Location = new System.Drawing.Point(62, 116);
            this.remButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.remButton.Name = "remButton";
            this.remButton.Primary = true;
            this.remButton.Size = new System.Drawing.Size(75, 36);
            this.remButton.TabIndex = 27;
            this.remButton.Text = "Remove";
            this.remButton.UseVisualStyleBackColor = true;
            this.remButton.Click += new System.EventHandler(this.remButton_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(24, 229);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(76, 19);
            this.materialLabel4.TabIndex = 26;
            this.materialLabel4.Text = "PC Name:";
            // 
            // remRemoteRadio
            // 
            this.remRemoteRadio.AutoSize = true;
            this.remRemoteRadio.Depth = 0;
            this.remRemoteRadio.Font = new System.Drawing.Font("Roboto", 10F);
            this.remRemoteRadio.Location = new System.Drawing.Point(9, 183);
            this.remRemoteRadio.Margin = new System.Windows.Forms.Padding(0);
            this.remRemoteRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.remRemoteRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.remRemoteRadio.Name = "remRemoteRadio";
            this.remRemoteRadio.Ripple = true;
            this.remRemoteRadio.Size = new System.Drawing.Size(77, 30);
            this.remRemoteRadio.TabIndex = 25;
            this.remRemoteRadio.Text = "Remote";
            this.remRemoteRadio.UseVisualStyleBackColor = true;
            // 
            // remLocalRadio
            // 
            this.remLocalRadio.AutoSize = true;
            this.remLocalRadio.Checked = true;
            this.remLocalRadio.Depth = 0;
            this.remLocalRadio.Font = new System.Drawing.Font("Roboto", 10F);
            this.remLocalRadio.Location = new System.Drawing.Point(9, 69);
            this.remLocalRadio.Margin = new System.Windows.Forms.Padding(0);
            this.remLocalRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.remLocalRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.remLocalRadio.Name = "remLocalRadio";
            this.remLocalRadio.Ripple = true;
            this.remLocalRadio.Size = new System.Drawing.Size(62, 30);
            this.remLocalRadio.TabIndex = 24;
            this.remLocalRadio.TabStop = true;
            this.remLocalRadio.Text = "Local";
            this.remLocalRadio.UseVisualStyleBackColor = true;
            this.remLocalRadio.CheckedChanged += new System.EventHandler(this.remLocalRadio_CheckedChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(2, 3);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(188, 38);
            this.materialLabel3.TabIndex = 23;
            this.materialLabel3.Text = "Check printer(s) to remove\r\nthen click remove\r\n";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 58);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(233, 42);
            this.materialTabSelector1.TabIndex = 14;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // DarkMode
            // 
            this.DarkMode.AutoSize = true;
            this.DarkMode.Depth = 0;
            this.DarkMode.Font = new System.Drawing.Font("Roboto", 10F);
            this.DarkMode.Location = new System.Drawing.Point(821, 70);
            this.DarkMode.Margin = new System.Windows.Forms.Padding(0);
            this.DarkMode.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DarkMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.DarkMode.Name = "DarkMode";
            this.DarkMode.Ripple = true;
            this.DarkMode.Size = new System.Drawing.Size(58, 30);
            this.DarkMode.TabIndex = 16;
            this.DarkMode.Text = "Dark";
            this.DarkMode.UseVisualStyleBackColor = true;
            this.DarkMode.CheckedChanged += new System.EventHandler(this.DarkMode_CheckedChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(239, 74);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(61, 19);
            this.materialLabel5.TabIndex = 17;
            this.materialLabel5.Text = "Printers";
            // 
            // addLocalButton
            // 
            this.addLocalButton.AutoSize = true;
            this.addLocalButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addLocalButton.Depth = 0;
            this.addLocalButton.Icon = null;
            this.addLocalButton.Location = new System.Drawing.Point(72, 145);
            this.addLocalButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addLocalButton.Name = "addLocalButton";
            this.addLocalButton.Primary = true;
            this.addLocalButton.Size = new System.Drawing.Size(48, 36);
            this.addLocalButton.TabIndex = 24;
            this.addLocalButton.Text = "Add";
            this.addLocalButton.UseVisualStyleBackColor = true;
            this.addLocalButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addRemoteButton
            // 
            this.addRemoteButton.AutoSize = true;
            this.addRemoteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addRemoteButton.Depth = 0;
            this.addRemoteButton.Icon = null;
            this.addRemoteButton.Location = new System.Drawing.Point(72, 317);
            this.addRemoteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addRemoteButton.Name = "addRemoteButton";
            this.addRemoteButton.Primary = true;
            this.addRemoteButton.Size = new System.Drawing.Size(48, 36);
            this.addRemoteButton.TabIndex = 25;
            this.addRemoteButton.Text = "Add";
            this.addRemoteButton.UseVisualStyleBackColor = true;
            this.addRemoteButton.Click += new System.EventHandler(this.addRemoteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 541);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.DarkMode);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.prtList);
            this.Name = "Form1";
            this.Text = "Print Queue Utility";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prtList)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.addTab.ResumeLayout(false);
            this.addTab.PerformLayout();
            this.removeTab.ResumeLayout(false);
            this.removeTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView prtList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn addColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn queueName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipAddress;
        private MaterialSkin.Controls.MaterialTabControl tabControl1;
        private System.Windows.Forms.TabPage addTab;
        private System.Windows.Forms.TabPage removeTab;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRadioButton localRadio;
        private MaterialSkin.Controls.MaterialRadioButton remoteRadio;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialRadioButton remRemoteRadio;
        private MaterialSkin.Controls.MaterialRadioButton remLocalRadio;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField pcName;
        private MaterialSkin.Controls.MaterialRaisedButton remButton;
        private MaterialSkin.Controls.MaterialRaisedButton remRemoveButton;
        private MaterialSkin.Controls.MaterialRaisedButton getPrtButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField removePcName;
        private MaterialSkin.Controls.MaterialCheckBox DarkMode;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField prtSearch;
        private MaterialSkin.Controls.MaterialRaisedButton addRemoteButton;
        private MaterialSkin.Controls.MaterialRaisedButton addLocalButton;
    }
}

