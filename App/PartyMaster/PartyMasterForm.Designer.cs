namespace App.PartyMaster
{
    partial class PartyMasterForm
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
            this.grdvwPartyMaster = new System.Windows.Forms.DataGridView();
            this.partyIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyMasterRSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.lblPartyCode = new System.Windows.Forms.Label();
            this.lblPerson = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFax = new System.Windows.Forms.Label();
            this.lblPager = new System.Windows.Forms.Label();
            this.txtPartyName = new System.Windows.Forms.TextBox();
            this.txtPartyCode = new System.Windows.Forms.TextBox();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtPager = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chckStatus = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblPartyId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxSearhPartyName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdvwPartyMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyMasterRSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grdvwPartyMaster
            // 
            this.grdvwPartyMaster.AutoGenerateColumns = false;
            this.grdvwPartyMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdvwPartyMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partyIdDataGridViewTextBoxColumn,
            this.partyCodeDataGridViewTextBoxColumn,
            this.partyNameDataGridViewTextBoxColumn});
            this.grdvwPartyMaster.DataSource = this.partyMasterRSBindingSource;
            this.grdvwPartyMaster.Location = new System.Drawing.Point(61, 103);
            this.grdvwPartyMaster.MultiSelect = false;
            this.grdvwPartyMaster.Name = "grdvwPartyMaster";
            this.grdvwPartyMaster.Size = new System.Drawing.Size(259, 267);
            this.grdvwPartyMaster.TabIndex = 0;
            this.grdvwPartyMaster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdvwPartyMaster_CellContentClick);
            // 
            // partyIdDataGridViewTextBoxColumn
            // 
            this.partyIdDataGridViewTextBoxColumn.DataPropertyName = "PartyId";
            this.partyIdDataGridViewTextBoxColumn.HeaderText = "PartyId";
            this.partyIdDataGridViewTextBoxColumn.Name = "partyIdDataGridViewTextBoxColumn";
            this.partyIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // partyCodeDataGridViewTextBoxColumn
            // 
            this.partyCodeDataGridViewTextBoxColumn.DataPropertyName = "PartyCode";
            this.partyCodeDataGridViewTextBoxColumn.HeaderText = "PartyCode";
            this.partyCodeDataGridViewTextBoxColumn.Name = "partyCodeDataGridViewTextBoxColumn";
            // 
            // partyNameDataGridViewTextBoxColumn
            // 
            this.partyNameDataGridViewTextBoxColumn.DataPropertyName = "PartyName";
            this.partyNameDataGridViewTextBoxColumn.HeaderText = "PartyName";
            this.partyNameDataGridViewTextBoxColumn.Name = "partyNameDataGridViewTextBoxColumn";
            // 
            // partyMasterRSBindingSource
            // 
            this.partyMasterRSBindingSource.DataSource = typeof(Models.PartyMasterRS);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(398, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name :";
            // 
            // lblPartyCode
            // 
            this.lblPartyCode.AutoSize = true;
            this.lblPartyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartyCode.Location = new System.Drawing.Point(394, 70);
            this.lblPartyCode.Name = "lblPartyCode";
            this.lblPartyCode.Size = new System.Drawing.Size(81, 13);
            this.lblPartyCode.TabIndex = 2;
            this.lblPartyCode.Text = " Party Code :";
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerson.Location = new System.Drawing.Point(398, 103);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(54, 13);
            this.lblPerson.TabIndex = 3;
            this.lblPerson.Text = "Person :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(398, 139);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 13);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address :";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(398, 200);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(51, 13);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone :";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.Location = new System.Drawing.Point(398, 240);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(52, 13);
            this.lblMobile.TabIndex = 6;
            this.lblMobile.Text = "Mobile :";
            this.lblMobile.Click += new System.EventHandler(this.lblMobile_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(398, 281);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email :";
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFax.Location = new System.Drawing.Point(658, 200);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(35, 13);
            this.lblFax.TabIndex = 9;
            this.lblFax.Text = "Fax :";
            // 
            // lblPager
            // 
            this.lblPager.AutoSize = true;
            this.lblPager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPager.Location = new System.Drawing.Point(658, 240);
            this.lblPager.Name = "lblPager";
            this.lblPager.Size = new System.Drawing.Size(48, 13);
            this.lblPager.TabIndex = 10;
            this.lblPager.Text = "Pager :";
            // 
            // txtPartyName
            // 
            this.txtPartyName.Location = new System.Drawing.Point(487, 36);
            this.txtPartyName.Name = "txtPartyName";
            this.txtPartyName.Size = new System.Drawing.Size(390, 20);
            this.txtPartyName.TabIndex = 11;
            // 
            // txtPartyCode
            // 
            this.txtPartyCode.Enabled = false;
            this.txtPartyCode.Location = new System.Drawing.Point(487, 67);
            this.txtPartyCode.Name = "txtPartyCode";
            this.txtPartyCode.Size = new System.Drawing.Size(150, 20);
            this.txtPartyCode.TabIndex = 12;
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Location = new System.Drawing.Point(487, 100);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(390, 20);
            this.txtContactPerson.TabIndex = 13;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(487, 136);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(390, 46);
            this.txtAddress.TabIndex = 14;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(487, 200);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(165, 20);
            this.txtPhone.TabIndex = 15;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(487, 240);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(165, 20);
            this.txtMobile.TabIndex = 16;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(712, 200);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(165, 20);
            this.txtFax.TabIndex = 17;
            // 
            // txtPager
            // 
            this.txtPager.Location = new System.Drawing.Point(712, 240);
            this.txtPager.Name = "txtPager";
            this.txtPager.Size = new System.Drawing.Size(165, 20);
            this.txtPager.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(487, 274);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(390, 20);
            this.txtEmail.TabIndex = 19;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(487, 347);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 20;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(596, 347);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(699, 347);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblStatus.Location = new System.Drawing.Point(487, 313);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 13);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "label1";
            this.lblStatus.Visible = false;
            // 
            // chckStatus
            // 
            this.chckStatus.AutoSize = true;
            this.chckStatus.Location = new System.Drawing.Point(694, 67);
            this.chckStatus.Name = "chckStatus";
            this.chckStatus.Size = new System.Drawing.Size(56, 17);
            this.chckStatus.TabIndex = 25;
            this.chckStatus.Text = "Status";
            this.chckStatus.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(802, 347);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 26;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblPartyId
            // 
            this.lblPartyId.AutoSize = true;
            this.lblPartyId.Location = new System.Drawing.Point(487, 17);
            this.lblPartyId.Name = "lblPartyId";
            this.lblPartyId.Size = new System.Drawing.Size(16, 13);
            this.lblPartyId.TabIndex = 27;
            this.lblPartyId.Text = "Id";
            this.lblPartyId.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Party Name:";
            // 
            // txtBxSearhPartyName
            // 
            this.txtBxSearhPartyName.Location = new System.Drawing.Point(61, 54);
            this.txtBxSearhPartyName.Name = "txtBxSearhPartyName";
            this.txtBxSearhPartyName.Size = new System.Drawing.Size(157, 20);
            this.txtBxSearhPartyName.TabIndex = 29;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(245, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // PartyMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 497);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBxSearhPartyName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPartyId);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.chckStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPager);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtContactPerson);
            this.Controls.Add(this.txtPartyCode);
            this.Controls.Add(this.txtPartyName);
            this.Controls.Add(this.lblPager);
            this.Controls.Add(this.lblFax);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPerson);
            this.Controls.Add(this.lblPartyCode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.grdvwPartyMaster);
            this.Name = "PartyMasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PartyMaster";
            ((System.ComponentModel.ISupportInitialize)(this.grdvwPartyMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyMasterRSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdvwPartyMaster;
        private System.Windows.Forms.BindingSource partyMasterRSBindingSource;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPartyCode;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.Label lblPager;
        private System.Windows.Forms.TextBox txtPartyName;
        private System.Windows.Forms.TextBox txtPartyCode;
        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtPager;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chckStatus;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblPartyId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxSearhPartyName;
        private System.Windows.Forms.Button btnSearch;
    }
}