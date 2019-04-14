namespace App
{
    partial class ViewReportFrm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PerformaInvoice = new App.PerformaInvoice();
            this.Table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customInvoice = new App.CustomInvoice();
            this.customInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PerformaInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customInvoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Table1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "App.Report.CustomInvoic1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(40, 23);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
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
            // customInvoice
            // 
            this.customInvoice.DataSetName = "CustomInvoice";
            this.customInvoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customInvoiceBindingSource
            // 
            this.customInvoiceBindingSource.DataSource = this.customInvoice;
            this.customInvoiceBindingSource.Position = 0;
            // 
            // ViewReportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ViewReportFrm";
            this.Text = "ViewReportFrm";
            this.Load += new System.EventHandler(this.ViewReportFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PerformaInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customInvoiceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Table1BindingSource;
        private PerformaInvoice PerformaInvoice;
        private CustomInvoice customInvoice;
        private System.Windows.Forms.BindingSource customInvoiceBindingSource;
    }
}