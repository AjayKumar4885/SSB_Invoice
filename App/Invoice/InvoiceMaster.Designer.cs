namespace App.Invoice
{
    partial class InvoiceMaster
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
            this.grdvwPartyNameForInvoice = new System.Windows.Forms.DataGridView();
            this.cmbPartyName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgInvoiceList = new System.Windows.Forms.DataGridView();
            this.dgvOrderItem = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdvwPartyNameForInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoiceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).BeginInit();
            this.SuspendLayout();
            // 
            // grdvwPartyNameForInvoice
            // 
            this.grdvwPartyNameForInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grdvwPartyNameForInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdvwPartyNameForInvoice.Location = new System.Drawing.Point(31, 107);
            this.grdvwPartyNameForInvoice.Name = "grdvwPartyNameForInvoice";
            this.grdvwPartyNameForInvoice.Size = new System.Drawing.Size(317, 354);
            this.grdvwPartyNameForInvoice.TabIndex = 1;
            this.grdvwPartyNameForInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdvwPartyNameForInvoice_CellContentClick);
            // 
            // cmbPartyName
            // 
            this.cmbPartyName.FormattingEnabled = true;
            this.cmbPartyName.Location = new System.Drawing.Point(113, 57);
            this.cmbPartyName.Name = "cmbPartyName";
            this.cmbPartyName.Size = new System.Drawing.Size(158, 21);
            this.cmbPartyName.TabIndex = 2;
            this.cmbPartyName.SelectionChangeCommitted += new System.EventHandler(this.cmbPartyName_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Party Name:";
            // 
            // dgInvoiceList
            // 
            this.dgInvoiceList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgInvoiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInvoiceList.Location = new System.Drawing.Point(379, 109);
            this.dgInvoiceList.Name = "dgInvoiceList";
            this.dgInvoiceList.Size = new System.Drawing.Size(907, 163);
            this.dgInvoiceList.TabIndex = 4;
            this.dgInvoiceList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInvoiceList_CellContentClick);
            // 
            // dgvOrderItem
            // 
            this.dgvOrderItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItem.Location = new System.Drawing.Point(379, 307);
            this.dgvOrderItem.Name = "dgvOrderItem";
            this.dgvOrderItem.Size = new System.Drawing.Size(907, 150);
            this.dgvOrderItem.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Invoice Master";
            // 
            // InvoiceMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1313, 483);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvOrderItem);
            this.Controls.Add(this.dgInvoiceList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPartyName);
            this.Controls.Add(this.grdvwPartyNameForInvoice);
            this.Name = "InvoiceMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceMaster";
            this.Load += new System.EventHandler(this.InvoiceMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdvwPartyNameForInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoiceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdvwPartyNameForInvoice;
        private System.Windows.Forms.ComboBox cmbPartyName;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgInvoiceList;
        private System.Windows.Forms.DataGridView dgvOrderItem;
        private System.Windows.Forms.Label label2;
    }
}