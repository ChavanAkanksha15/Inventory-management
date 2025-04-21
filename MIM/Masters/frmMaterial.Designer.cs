namespace MIM.Masters
{
    partial class frmMaterial
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
            this.txtLoad = new System.Windows.Forms.GroupBox();
            this.MaterialGrid = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.GroupBox();
            this.txtSearchKey = new System.Windows.Forms.TextBox();
            this.MaterialForm = new System.Windows.Forms.GroupBox();
            this.txtUOM = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtHSNCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialGrid)).BeginInit();
            this.txtSearch.SuspendLayout();
            this.MaterialForm.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLoad
            // 
            this.txtLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoad.Controls.Add(this.MaterialGrid);
            this.txtLoad.Location = new System.Drawing.Point(480, 107);
            this.txtLoad.Name = "txtLoad";
            this.txtLoad.Size = new System.Drawing.Size(801, 394);
            this.txtLoad.TabIndex = 5;
            this.txtLoad.TabStop = false;
            this.txtLoad.Text = "Material List";
            // 
            // MaterialGrid
            // 
            this.MaterialGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaterialGrid.ContextMenuStrip = this.contextMenuStrip1;
            this.MaterialGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaterialGrid.Location = new System.Drawing.Point(3, 18);
            this.MaterialGrid.Name = "MaterialGrid";
            this.MaterialGrid.RowHeadersWidth = 51;
            this.MaterialGrid.RowTemplate.Height = 24;
            this.MaterialGrid.Size = new System.Drawing.Size(795, 373);
            this.MaterialGrid.TabIndex = 0;
            this.MaterialGrid.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.MaterialGrid_CellContextMenuStripNeeded);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtSearch.Controls.Add(this.txtSearchKey);
            this.txtSearch.Location = new System.Drawing.Point(480, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(798, 129);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TabStop = false;
            this.txtSearch.Text = "Filter";
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchKey.Location = new System.Drawing.Point(56, 40);
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(238, 22);
            this.txtSearchKey.TabIndex = 0;
            this.txtSearchKey.TextChanged += new System.EventHandler(this.txtSearchKey_TextChanged);
            // 
            // MaterialForm
            // 
            this.MaterialForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MaterialForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MaterialForm.Controls.Add(this.btnFind);
            this.MaterialForm.Controls.Add(this.txtUOM);
            this.MaterialForm.Controls.Add(this.txtId);
            this.MaterialForm.Controls.Add(this.label1);
            this.MaterialForm.Controls.Add(this.SaveButton);
            this.MaterialForm.Controls.Add(this.txtPrice);
            this.MaterialForm.Controls.Add(this.txtHSNCode);
            this.MaterialForm.Controls.Add(this.txtName);
            this.MaterialForm.Controls.Add(this.label5);
            this.MaterialForm.Controls.Add(this.label4);
            this.MaterialForm.Controls.Add(this.label3);
            this.MaterialForm.Controls.Add(this.label2);
            this.MaterialForm.Location = new System.Drawing.Point(12, 12);
            this.MaterialForm.Name = "MaterialForm";
            this.MaterialForm.Size = new System.Drawing.Size(435, 489);
            this.MaterialForm.TabIndex = 3;
            this.MaterialForm.TabStop = false;
            this.MaterialForm.Text = "Material information";
            // 
            // txtUOM
            // 
            this.txtUOM.FormattingEnabled = true;
            this.txtUOM.Location = new System.Drawing.Point(183, 270);
            this.txtUOM.Name = "txtUOM";
            this.txtUOM.Size = new System.Drawing.Size(202, 24);
            this.txtUOM.TabIndex = 13;
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Location = new System.Drawing.Point(183, 78);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Gray;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveButton.Location = new System.Drawing.Point(310, 328);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Location = new System.Drawing.Point(183, 224);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(202, 22);
            this.txtPrice.TabIndex = 4;
            // 
            // txtHSNCode
            // 
            this.txtHSNCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHSNCode.Location = new System.Drawing.Point(183, 178);
            this.txtHSNCode.Name = "txtHSNCode";
            this.txtHSNCode.Size = new System.Drawing.Size(202, 22);
            this.txtHSNCode.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(183, 122);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(202, 22);
            this.txtName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "UOM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "HSNCode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 52);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
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
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.White;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFind.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnFind.Location = new System.Drawing.Point(298, 77);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(87, 23);
            this.btnFind.TabIndex = 14;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // frmMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 513);
            this.Controls.Add(this.txtLoad);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.MaterialForm);
            this.Name = "frmMaterial";
            this.Text = "frmMaterial";
            this.Load += new System.EventHandler(this.frmMaterial_Load);
            this.txtLoad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MaterialGrid)).EndInit();
            this.txtSearch.ResumeLayout(false);
            this.txtSearch.PerformLayout();
            this.MaterialForm.ResumeLayout(false);
            this.MaterialForm.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox txtLoad;
        private System.Windows.Forms.DataGridView MaterialGrid;
        private System.Windows.Forms.GroupBox txtSearch;
        private System.Windows.Forms.TextBox txtSearchKey;
        private System.Windows.Forms.GroupBox MaterialForm;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtHSNCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtUOM;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button btnFind;
    }
}