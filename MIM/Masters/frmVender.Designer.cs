namespace MIM.Masters
{
    partial class frmVender
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
            this.VenderList = new System.Windows.Forms.GroupBox();
            this.VenderDataGrid = new System.Windows.Forms.DataGridView();
            this.Filter = new System.Windows.Forms.GroupBox();
            this.Search = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.VenderData = new System.Windows.Forms.GroupBox();
            this.comboCity = new System.Windows.Forms.ComboBox();
            this.clear = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.save = new System.Windows.Forms.Button();
            this.ChkGrocery = new System.Windows.Forms.CheckBox();
            this.ChkCloths = new System.Windows.Forms.CheckBox();
            this.chkDairy = new System.Windows.Forms.CheckBox();
            this.ChkElectronics = new System.Windows.Forms.CheckBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGSTN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Categories = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VenderList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VenderDataGrid)).BeginInit();
            this.Filter.SuspendLayout();
            this.VenderData.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VenderList
            // 
            this.VenderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VenderList.Controls.Add(this.VenderDataGrid);
            this.VenderList.Location = new System.Drawing.Point(415, 99);
            this.VenderList.Name = "VenderList";
            this.VenderList.Size = new System.Drawing.Size(814, 586);
            this.VenderList.TabIndex = 31;
            this.VenderList.TabStop = false;
            this.VenderList.Text = "Vender";
            // 
            // VenderDataGrid
            // 
            this.VenderDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VenderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VenderDataGrid.ContextMenuStrip = this.contextMenuStrip1;
            this.VenderDataGrid.Location = new System.Drawing.Point(3, 18);
            this.VenderDataGrid.Name = "VenderDataGrid";
            this.VenderDataGrid.RowHeadersWidth = 51;
            this.VenderDataGrid.RowTemplate.Height = 24;
            this.VenderDataGrid.Size = new System.Drawing.Size(802, 561);
            this.VenderDataGrid.TabIndex = 0;
            this.VenderDataGrid.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.VenderDataGrid_CellContextMenuStripNeeded);
            // 
            // Filter
            // 
            this.Filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Filter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Filter.Controls.Add(this.Search);
            this.Filter.Controls.Add(this.label11);
            this.Filter.Location = new System.Drawing.Point(416, 12);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(813, 130);
            this.Filter.TabIndex = 30;
            this.Filter.TabStop = false;
            this.Filter.Text = "Filter";
            // 
            // Search
            // 
            this.Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Search.Location = new System.Drawing.Point(82, 41);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(232, 22);
            this.Search.TabIndex = 1;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(16, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Search";
            // 
            // VenderData
            // 
            this.VenderData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.VenderData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.VenderData.Controls.Add(this.comboCity);
            this.VenderData.Controls.Add(this.clear);
            this.VenderData.Controls.Add(this.btnFind);
            this.VenderData.Controls.Add(this.txtBirthDate);
            this.VenderData.Controls.Add(this.save);
            this.VenderData.Controls.Add(this.ChkGrocery);
            this.VenderData.Controls.Add(this.ChkCloths);
            this.VenderData.Controls.Add(this.chkDairy);
            this.VenderData.Controls.Add(this.ChkElectronics);
            this.VenderData.Controls.Add(this.txtAddress);
            this.VenderData.Controls.Add(this.txtId);
            this.VenderData.Controls.Add(this.txtEmail);
            this.VenderData.Controls.Add(this.label1);
            this.VenderData.Controls.Add(this.rdoFemale);
            this.VenderData.Controls.Add(this.label2);
            this.VenderData.Controls.Add(this.rdoMale);
            this.VenderData.Controls.Add(this.label3);
            this.VenderData.Controls.Add(this.label4);
            this.VenderData.Controls.Add(this.txtGSTN);
            this.VenderData.Controls.Add(this.label5);
            this.VenderData.Controls.Add(this.txtMobileNo);
            this.VenderData.Controls.Add(this.label6);
            this.VenderData.Controls.Add(this.txtName);
            this.VenderData.Controls.Add(this.label7);
            this.VenderData.Controls.Add(this.label10);
            this.VenderData.Controls.Add(this.Categories);
            this.VenderData.Controls.Add(this.label9);
            this.VenderData.Location = new System.Drawing.Point(12, 12);
            this.VenderData.Name = "VenderData";
            this.VenderData.Size = new System.Drawing.Size(394, 674);
            this.VenderData.TabIndex = 29;
            this.VenderData.TabStop = false;
            this.VenderData.Text = "Vender Information";
            // 
            // comboCity
            // 
            this.comboCity.FormattingEnabled = true;
            this.comboCity.Location = new System.Drawing.Point(118, 305);
            this.comboCity.Name = "comboCity";
            this.comboCity.Size = new System.Drawing.Size(230, 24);
            this.comboCity.TabIndex = 5;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Gray;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clear.Location = new System.Drawing.Point(161, 628);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 29;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(273, 52);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 27;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.find_Click);
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.CustomFormat = "dd-MM-yyyy";
            this.txtBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtBirthDate.Location = new System.Drawing.Point(118, 265);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(230, 22);
            this.txtBirthDate.TabIndex = 4;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Gray;
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save.Location = new System.Drawing.Point(273, 628);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 28;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // ChkGrocery
            // 
            this.ChkGrocery.AutoSize = true;
            this.ChkGrocery.Location = new System.Drawing.Point(231, 550);
            this.ChkGrocery.Name = "ChkGrocery";
            this.ChkGrocery.Size = new System.Drawing.Size(77, 20);
            this.ChkGrocery.TabIndex = 0;
            this.ChkGrocery.Text = "Grocery";
            this.ChkGrocery.UseVisualStyleBackColor = true;
            // 
            // ChkCloths
            // 
            this.ChkCloths.AutoSize = true;
            this.ChkCloths.Location = new System.Drawing.Point(119, 550);
            this.ChkCloths.Name = "ChkCloths";
            this.ChkCloths.Size = new System.Drawing.Size(66, 20);
            this.ChkCloths.TabIndex = 1;
            this.ChkCloths.Text = "Cloths";
            this.ChkCloths.UseVisualStyleBackColor = true;
            // 
            // chkDairy
            // 
            this.chkDairy.AutoSize = true;
            this.chkDairy.Location = new System.Drawing.Point(231, 576);
            this.chkDairy.Name = "chkDairy";
            this.chkDairy.Size = new System.Drawing.Size(110, 20);
            this.chkDairy.TabIndex = 2;
            this.chkDairy.Text = "Dairy Product";
            this.chkDairy.UseVisualStyleBackColor = true;
            // 
            // ChkElectronics
            // 
            this.ChkElectronics.AutoSize = true;
            this.ChkElectronics.Location = new System.Drawing.Point(118, 576);
            this.ChkElectronics.Name = "ChkElectronics";
            this.ChkElectronics.Size = new System.Drawing.Size(95, 20);
            this.ChkElectronics.TabIndex = 3;
            this.ChkElectronics.Text = "Electronics";
            this.ChkElectronics.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(118, 150);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(230, 84);
            this.txtAddress.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Location = new System.Drawing.Point(118, 53);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(132, 22);
            this.txtId.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(118, 450);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(230, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(202, 353);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(74, 20);
            this.rdoFemale.TabIndex = 7;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(119, 355);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(58, 20);
            this.rdoMale.TabIndex = 6;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "BirthDate";
            // 
            // txtGSTN
            // 
            this.txtGSTN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGSTN.Location = new System.Drawing.Point(119, 402);
            this.txtGSTN.Name = "txtGSTN";
            this.txtGSTN.Size = new System.Drawing.Size(230, 22);
            this.txtGSTN.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gender";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMobileNo.Location = new System.Drawing.Point(119, 496);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(230, 22);
            this.txtMobileNo.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "MobileNo";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(118, 86);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 22);
            this.txtName.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "City";
            // 
            // Categories
            // 
            this.Categories.AutoSize = true;
            this.Categories.Location = new System.Drawing.Point(22, 566);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(73, 16);
            this.Categories.TabIndex = 9;
            this.Categories.Text = "Categories";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "GSTN";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // frmVender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 698);
            this.Controls.Add(this.VenderList);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.VenderData);
            this.Name = "frmVender";
            this.Text = "frmVender";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVender_FormClosing);
            this.Load += new System.EventHandler(this.frmVender_Load);
            this.VenderList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VenderDataGrid)).EndInit();
            this.Filter.ResumeLayout(false);
            this.Filter.PerformLayout();
            this.VenderData.ResumeLayout(false);
            this.VenderData.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox VenderList;
        private System.Windows.Forms.DataGridView VenderDataGrid;
        private System.Windows.Forms.GroupBox Filter;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox VenderData;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.DateTimePicker txtBirthDate;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.CheckBox ChkGrocery;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.CheckBox ChkCloths;
        private System.Windows.Forms.CheckBox chkDairy;
        private System.Windows.Forms.CheckBox ChkElectronics;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGSTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Categories;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboCity;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}