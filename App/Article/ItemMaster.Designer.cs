namespace App.Article
{
    partial class ItemMaster
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
            this.grdvwArticle = new System.Windows.Forms.DataGridView();
            this.artIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleRSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchArt = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblArtNo = new System.Windows.Forms.Label();
            this.lblWorkDesc = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtArtNo = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtWorkOrderDesc = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chckStatus = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdvwArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleRSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grdvwArticle
            // 
            this.grdvwArticle.AutoGenerateColumns = false;
            this.grdvwArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdvwArticle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artIdDataGridViewTextBoxColumn,
            this.artNoDataGridViewTextBoxColumn,
            this.descDataGridViewTextBoxColumn});
            this.grdvwArticle.DataSource = this.articleRSBindingSource;
            this.grdvwArticle.Location = new System.Drawing.Point(48, 101);
            this.grdvwArticle.Name = "grdvwArticle";
            this.grdvwArticle.Size = new System.Drawing.Size(240, 297);
            this.grdvwArticle.TabIndex = 0;
            this.grdvwArticle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdvwArticle_CellContentClick);
            // 
            // artIdDataGridViewTextBoxColumn
            // 
            this.artIdDataGridViewTextBoxColumn.DataPropertyName = "ArtId";
            this.artIdDataGridViewTextBoxColumn.HeaderText = "ArtId";
            this.artIdDataGridViewTextBoxColumn.Name = "artIdDataGridViewTextBoxColumn";
            this.artIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // artNoDataGridViewTextBoxColumn
            // 
            this.artNoDataGridViewTextBoxColumn.DataPropertyName = "ArtNo";
            this.artNoDataGridViewTextBoxColumn.HeaderText = "ArtNo";
            this.artNoDataGridViewTextBoxColumn.Name = "artNoDataGridViewTextBoxColumn";
            // 
            // descDataGridViewTextBoxColumn
            // 
            this.descDataGridViewTextBoxColumn.DataPropertyName = "Desc";
            this.descDataGridViewTextBoxColumn.HeaderText = "Desc";
            this.descDataGridViewTextBoxColumn.Name = "descDataGridViewTextBoxColumn";
            // 
            // articleRSBindingSource
            // 
            this.articleRSBindingSource.DataSource = typeof(Models.ArticleRS);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Art Description";
            // 
            // txtSearchArt
            // 
            this.txtSearchArt.Location = new System.Drawing.Point(51, 61);
            this.txtSearchArt.Name = "txtSearchArt";
            this.txtSearchArt.Size = new System.Drawing.Size(149, 20);
            this.txtSearchArt.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(213, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblArtNo
            // 
            this.lblArtNo.AutoSize = true;
            this.lblArtNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtNo.Location = new System.Drawing.Point(345, 32);
            this.lblArtNo.Name = "lblArtNo";
            this.lblArtNo.Size = new System.Drawing.Size(59, 13);
            this.lblArtNo.TabIndex = 4;
            this.lblArtNo.Text = "Art. No. :";
            // 
            // lblWorkDesc
            // 
            this.lblWorkDesc.AutoSize = true;
            this.lblWorkDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkDesc.Location = new System.Drawing.Point(345, 148);
            this.lblWorkDesc.Name = "lblWorkDesc";
            this.lblWorkDesc.Size = new System.Drawing.Size(76, 39);
            this.lblWorkDesc.TabIndex = 5;
            this.lblWorkDesc.Text = "Work Order \r\nDescription\r\n:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(345, 68);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 13);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description :";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(345, 199);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(42, 13);
            this.lblRate.TabIndex = 7;
            this.lblRate.Text = "Rate :";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(574, 202);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(38, 13);
            this.lblUnit.TabIndex = 8;
            this.lblUnit.Text = "Unit :";
            // 
            // txtArtNo
            // 
            this.txtArtNo.Location = new System.Drawing.Point(430, 32);
            this.txtArtNo.Name = "txtArtNo";
            this.txtArtNo.Size = new System.Drawing.Size(182, 20);
            this.txtArtNo.TabIndex = 9;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(430, 64);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(343, 47);
            this.txtDesc.TabIndex = 10;
            // 
            // txtWorkOrderDesc
            // 
            this.txtWorkOrderDesc.Location = new System.Drawing.Point(430, 140);
            this.txtWorkOrderDesc.Multiline = true;
            this.txtWorkOrderDesc.Name = "txtWorkOrderDesc";
            this.txtWorkOrderDesc.Size = new System.Drawing.Size(343, 47);
            this.txtWorkOrderDesc.TabIndex = 11;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(430, 199);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(132, 20);
            this.txtRate.TabIndex = 12;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(641, 199);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(132, 20);
            this.txtUnit.TabIndex = 13;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(417, 294);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(509, 294);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(602, 294);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(698, 294);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(430, 1);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 13);
            this.lblID.TabIndex = 18;
            this.lblID.Text = "lblD";
            this.lblID.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(427, 255);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 13);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "label2";
            this.lblStatus.Visible = false;
            // 
            // chckStatus
            // 
            this.chckStatus.AutoSize = true;
            this.chckStatus.Checked = true;
            this.chckStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckStatus.Location = new System.Drawing.Point(693, 34);
            this.chckStatus.Name = "chckStatus";
            this.chckStatus.Size = new System.Drawing.Size(56, 17);
            this.chckStatus.TabIndex = 20;
            this.chckStatus.Text = "Status";
            this.chckStatus.UseVisualStyleBackColor = true;
            // 
            // ItemMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chckStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtWorkOrderDesc);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtArtNo);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblWorkDesc);
            this.Controls.Add(this.lblArtNo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchArt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdvwArticle);
            this.Name = "ItemMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemMaster";
            ((System.ComponentModel.ISupportInitialize)(this.grdvwArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleRSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdvwArticle;
        private System.Windows.Forms.BindingSource articleRSBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchArt;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblArtNo;
        private System.Windows.Forms.Label lblWorkDesc;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtArtNo;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtWorkOrderDesc;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chckStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn artIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descDataGridViewTextBoxColumn;
    }
}