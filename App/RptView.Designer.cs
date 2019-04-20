namespace App
{
    partial class RptView
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Table2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PerformaInvoice = new App.PerformaInvoice();
            this.Table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnViewRpt = new System.Windows.Forms.Button();
            this.btn_pdfview = new System.Windows.Forms.Button();
            this.table1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.performaInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.performaInvoiceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.table1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.txthiddenInvoiceNum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Table2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PerformaInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performaInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performaInvoiceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // Table2BindingSource
            // 
            this.Table2BindingSource.DataMember = "Table2";
            this.Table2BindingSource.DataSource = this.PerformaInvoice;
            // 
            // PerformaInvoice
            // 
            this.PerformaInvoice.DataSetName = "PerformaInvoice";
            this.PerformaInvoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Table1BindingSource
            // 
            this.Table1BindingSource.DataMember = "Table1";
            this.Table1BindingSource.DataSource = this.PerformaInvoice;
            // 
            // reportViewer1
            // 
            reportDataSource5.Name = "DataSet2";
            reportDataSource5.Value = this.Table2BindingSource;
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.Table1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "App.Report.CustomInvoic.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(7, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(720, 652);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // btnViewRpt
            // 
            this.btnViewRpt.Location = new System.Drawing.Point(831, 217);
            this.btnViewRpt.Name = "btnViewRpt";
            this.btnViewRpt.Size = new System.Drawing.Size(75, 23);
            this.btnViewRpt.TabIndex = 1;
            this.btnViewRpt.Text = "ViewReport";
            this.btnViewRpt.UseVisualStyleBackColor = true;
            this.btnViewRpt.Visible = false;
            this.btnViewRpt.Click += new System.EventHandler(this.btnViewRpt_Click);
            // 
            // btn_pdfview
            // 
            this.btn_pdfview.Location = new System.Drawing.Point(831, 153);
            this.btn_pdfview.Name = "btn_pdfview";
            this.btn_pdfview.Size = new System.Drawing.Size(75, 23);
            this.btn_pdfview.TabIndex = 2;
            this.btn_pdfview.Text = "Pdfview";
            this.btn_pdfview.UseVisualStyleBackColor = true;
            this.btn_pdfview.Visible = false;
            this.btn_pdfview.Click += new System.EventHandler(this.btn_pdfview_Click);
            // 
            // table1BindingSource1
            // 
            this.table1BindingSource1.DataMember = "Table1";
            this.table1BindingSource1.DataSource = this.performaInvoiceBindingSource;
            // 
            // performaInvoiceBindingSource
            // 
            this.performaInvoiceBindingSource.DataSource = this.PerformaInvoice;
            this.performaInvoiceBindingSource.Position = 0;
            // 
            // table1BindingSource2
            // 
            this.table1BindingSource2.DataMember = "Table1";
            this.table1BindingSource2.DataSource = this.PerformaInvoice;
            // 
            // performaInvoiceBindingSource1
            // 
            this.performaInvoiceBindingSource1.DataSource = this.PerformaInvoice;
            this.performaInvoiceBindingSource1.Position = 0;
            // 
            // table1BindingSource3
            // 
            this.table1BindingSource3.DataMember = "Table1";
            this.table1BindingSource3.DataSource = this.PerformaInvoice;
            // 
            // txthiddenInvoiceNum
            // 
            this.txthiddenInvoiceNum.Location = new System.Drawing.Point(621, 56);
            this.txthiddenInvoiceNum.Name = "txthiddenInvoiceNum";
            this.txthiddenInvoiceNum.Size = new System.Drawing.Size(100, 20);
            this.txthiddenInvoiceNum.TabIndex = 3;
            this.txthiddenInvoiceNum.Visible = false;
            // 
            // RptView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 676);
            this.Controls.Add(this.txthiddenInvoiceNum);
            this.Controls.Add(this.btn_pdfview);
            this.Controls.Add(this.btnViewRpt);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RptView";
            this.Text = "RptView";
            this.Load += new System.EventHandler(this.RptView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PerformaInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performaInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performaInvoiceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Table1BindingSource;
        private PerformaInvoice PerformaInvoice;
        private System.Windows.Forms.Button btnViewRpt;
        private System.Windows.Forms.Button btn_pdfview;
        private System.Windows.Forms.BindingSource table1BindingSource1;
        private System.Windows.Forms.BindingSource performaInvoiceBindingSource;
        private System.Windows.Forms.BindingSource table1BindingSource2;
        private System.Windows.Forms.BindingSource performaInvoiceBindingSource1;
        private System.Windows.Forms.BindingSource table1BindingSource3;
        private System.Windows.Forms.BindingSource Table2BindingSource;
        public System.Windows.Forms.TextBox txthiddenInvoiceNum;
    }
}