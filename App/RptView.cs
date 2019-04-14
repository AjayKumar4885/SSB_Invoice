using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Reporting.WinForms;
using ConvertNumberToWord;
//using System.Web.UI.WebControls;
//using App.Report;

namespace App
{
    public partial class RptView : Form
    {
        public RptView()
        {
            InitializeComponent();
        }
        private void RptView_Load(object sender, EventArgs e)
        {
            LoadreportoneDs();
        }

        // bkp as on 08042019
        //private void RptView_Load(object sender, EventArgs e)
        //{
        //    //  DataRow drow = new DataRow();
        //    DataColumn dcol = new DataColumn();
        //    DataSet dsCustomers = new DataSet();
        //    DataTable dtInvoice = new DataTable();
        //    dtInvoice = GetDataItem().Tables[0].Copy();
        //    dtInvoice.TableName = "table1";
        //    dsCustomers.Tables.Add(dtInvoice);

        //    DataTable dtInvoiceDetails = new DataTable();
        //    dtInvoiceDetails = GetDataItemDetails().Tables[0].Copy();
        //    dtInvoiceDetails.TableName = "table2";
        //    dsCustomers.Tables.Add(dtInvoiceDetails);

        //    //dcol = dsCustomers.Tables[0].Columns[8];
        //    //string numinword;
        //    //decimal totalamt;
        //    //numinword = dsCustomers.Tables[0].Compute("Sum(Amount)", "").ToString();
        //    //totalamt = Convert.ToDecimal(numinword);
        //    //double result = Convert.ToDouble(Math.Round(totalamt, 2));
        //    //   string NuminWords = ConvertNumbertoWords(Convert.ToString(dsCustomers.Tables[0].Rows[0]["InvoiceGrandAmt"]));

        //    //foreach () ;
        //    dsCustomers.Tables[0].Columns.Add(new DataColumn("TotWordAmount", typeof(string)));
        //    DataColumn newCol = new DataColumn("TotWordAmount", typeof(string));
        //    newCol.AllowDBNull = true;
        //    foreach (DataRow row in dsCustomers.Tables[0].Rows)
        //    {
        //        row["TotWordAmount"] = ConvertNumberToWord.NumberToWord.Num2Word(Convert.ToString(dsCustomers.Tables[0].Rows[0]["InvoiceGrandAmt"]));
        //    }

        //    this.reportViewer1.LocalReport.DataSources.Clear();
        //    //if (dsCustomers.Tables.Count > 1)
        //    //{
        //    ReportDataSource datasource = new ReportDataSource("DataSet1", dtInvoice);
        //    ReportDataSource datasource1 = new ReportDataSource("DataSet2", dtInvoiceDetails);

        //    //  ReportDataSource datasource = new ReportDataSource("DataSet1", dsCustomers.Tables[1]);

        //    // ReportDataSource datasource1 = new ReportDataSource("DataSet2", dsCustomers.Tables[1]);
        //    //}

        //    this.reportViewer1.LocalReport.DataSources.Add(datasource);
        //    this.reportViewer1.LocalReport.DataSources.Add(datasource1);

        //    //this.reportViewer1.LocalReport.DataSources.Clear();
        //    //this.reportViewer1.LocalReport.DataSources.Add(datasource1);
        //    //this.reportViewer1.LocalReport.Refresh();


        //    //  this.bindingSource1.DataSource = rds;
        //    // this.reportViewer1.RefreshReport();
        //    // this.reportViewer1.LocalReport.DataSources.Add(datasource1);
        //    // 


        //    this.reportViewer1.RefreshReport();
        //}

        //for single dataset 

        private void LoadreportoneDs()
        {
            //  DataRow drow = new DataRow();
            DataColumn dcol = new DataColumn();
            DataSet dsCustomers = GetDataOne();
          //  dcol = dsCustomers.Tables[0].Columns[8];
            dcol = dsCustomers.Tables[0].Columns[6];
            string numinword;
            decimal totalamt;
            numinword = dsCustomers.Tables[0].Compute("Sum(Amount)", "").ToString();
            totalamt = Convert.ToDecimal(numinword);
            double result = Convert.ToDouble(Math.Round(totalamt, 2));
            string NuminWords = ConvertNumbertoWords1(Convert.ToInt32(result));
            //foreach () ;
            dsCustomers.Tables[0].Columns.Add(new DataColumn("TotWordAmount", typeof(string)));
            DataColumn newCol = new DataColumn("TotWordAmount", typeof(string));
            newCol.AllowDBNull = true;
            foreach (DataRow row in dsCustomers.Tables[0].Rows)
            {
                row["TotWordAmount"] = NuminWords;
            }

            this.reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource datasource = new ReportDataSource("DataSet1", dsCustomers.Tables[0]);

            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            //  this.bindingSource1.DataSource = rds;
            this.reportViewer1.RefreshReport();
        }

        private DataSet GetDataOne()
        {
            String constr = Convert.ToString(ConfigurationManager.AppSettings["RptConnection"]);

            //string constr = @"Data Source=.\Sql2005;Initial Catalog=Northwind;Integrated Security = true";
            using (SqlConnection con = new SqlConnection(constr))
            {
              //  using (SqlCommand cmd = new SqlCommand("SELECT [InvoiceItemID] ,[InvoiceNo],[ArtNo],[ArtDesc],[WorkOrderDesc],[RefileInk],[Rate],[Quantity],[Amount] from tbl_InvoiceItemDetails where InvoiceNo= 'SSB-" + txthiddenInvoiceNum.Text + "'"))
               // {
                    using (SqlCommand cmd = new SqlCommand(@"select invdtl.InvoiceNo,UPPER(invdtl.ArtNo) As ArtNo,UPPER( invdtl.ArtDesc) As ArtDesc, UPPER('REFILL INK : ' +   invdtl.RefileInk) as RefileInk, invdtl.Rate, invdtl.Quantity, invdtl.Amount ,
                                                              Ptm.PartyName, ptm.Address, invc.CreatedOn, invc.InvoiceGrandAmt, invc.DeliveryTerms, invc.InvoiceCurrency, invc.PaymentTerms, invc.TransShipment,
                                                            invc.PartialShip, invc.Port, UPPER(invc.DeliveryType) As DeliveryType, invc.Unit from tblInvoice invc
                                                            join tblPartyMaster ptm on invc.PartyNo = ptm.PartyCode
                                                                join tbl_InvoiceItemDetails invdtl on invdtl.InvoiceNo = invc.InvoiceNo
                                                            where invc.InvoiceNo = '" + txthiddenInvoiceNum.Text + "'"))
                    {

                        using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        DataSet ds = new DataSet();

                        //using (PerformaInvoice dsCustomers = new PerformaInvoice())
                        //{
                        //    sda.Fill(ds);
                        //    return ds;
                        //}

                        using (CustomInvoiceds dsCustomers = new CustomInvoiceds())
                        {
                            sda.Fill(ds);
                            return ds;
                        }
                    }
                }
            }
        }

        public string ConvertNumbertoWords1(long number)
        {
            if (number == 0) return "ZERO";
            if (number < 0) return "minus " + ConvertNumbertoWords(Math.Abs(number));
            string words = "";
            if ((number / 1000000) > 0)
            {
                words += ConvertNumbertoWords(number / 100000) + " LAKES ";
                number %= 1000000;
            }
            if ((number / 1000) > 0)
            {
                words += ConvertNumbertoWords(number / 1000) + " THOUSAND ";
                number %= 1000;
            }
            if ((number / 100) > 0)
            {
                words += ConvertNumbertoWords(number / 100) + " HUNDRED ";
                number %= 100;
            }
            //if ((number / 10) > 0)  
            //{  
            // words += ConvertNumbertoWords(number / 10) + " RUPEES ";  
            // number %= 10;  
            //}  
            if (number > 0)
            {
                if (words != "") words += "AND ";
                var unitsMap = new[]
                {
            "ZERO", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE", "TEN", "ELEVEN", "TWELVE", "THIRTEEN", "FOURTEEN", "FIFTEEN", "SIXTEEN", "SEVENTEEN", "EIGHTEEN", "NINETEEN"
        };
                var tensMap = new[]
                {
            "ZERO", "TEN", "TWENTY", "THIRTY", "FORTY", "FIFTY", "SIXTY", "SEVENTY", "EIGHTY", "NINETY"
        };
                if (number < 20) words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0) words += " " + unitsMap[number % 10];
                }
            }
            return words;
        }

        private void LoadreporttwoDs()
        {



            //  DataRow drow = new DataRow();
            DataColumn dcol = new DataColumn();
            DataSet dsCustomers = new DataSet();
            DataTable dtInvoice = new DataTable();
            dtInvoice = GetDataItem().Tables[0].Copy();
            dtInvoice.TableName = "table1";
            dsCustomers.Tables.Add(dtInvoice);

            DataTable dtInvoiceDetails = new DataTable();
            dtInvoiceDetails = GetDataItemDetails().Tables[0].Copy();
            dtInvoiceDetails.TableName = "table2";
            dsCustomers.Tables.Add(dtInvoiceDetails);

            //dcol = dsCustomers.Tables[0].Columns[8];
            //string numinword;
            //decimal totalamt;
            //numinword = dsCustomers.Tables[0].Compute("Sum(Amount)", "").ToString();
            //totalamt = Convert.ToDecimal(numinword);
            //double result = Convert.ToDouble(Math.Round(totalamt, 2));
            //   string NuminWords = ConvertNumbertoWords(Convert.ToString(dsCustomers.Tables[0].Rows[0]["InvoiceGrandAmt"]));

            //foreach () ;
            dsCustomers.Tables[0].Columns.Add(new DataColumn("TotWordAmount", typeof(string)));
            DataColumn newCol = new DataColumn("TotWordAmount", typeof(string));
            newCol.AllowDBNull = true;
            foreach (DataRow row in dsCustomers.Tables[0].Rows)
            {
                row["TotWordAmount"] = ConvertNumberToWord.NumberToWord.Num2Word(Convert.ToString(dsCustomers.Tables[0].Rows[0]["InvoiceGrandAmt"]));
            }

            this.reportViewer1.LocalReport.DataSources.Clear();
            //if (dsCustomers.Tables.Count > 1)
            //{
            ReportDataSource datasource = new ReportDataSource("DataSet1", dtInvoice);
           ReportDataSource datasource1 = new ReportDataSource("DataSet2", dtInvoiceDetails);

        
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
           this.reportViewer1.LocalReport.DataSources.Add(datasource1);

                this.reportViewer1.RefreshReport();
        }

        private void btnViewRpt_Click(object sender, EventArgs e)
        {
            //  DataSet  dsCustomers = GetData();
            //  this.reportViewer1.LocalReport.DataSources.Clear();
            //  ReportDataSource datasource = new ReportDataSource("DataSet1", dsCustomers.Tables[0]);

            //  this.reportViewer1.LocalReport.DataSources.Add(datasource);
            ////  this.bindingSource1.DataSource = rds;
            //  this.reportViewer1.RefreshReport();

        }

        private DataSet GetDataItem()
        {
            String constr = Convert.ToString(ConfigurationManager.AppSettings["RptConnection"]);

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(@"select Invc.InvoiceNo,Ptm.PartyName,ptm.Address,invc.CreatedOn,invc.InvoiceGrandAmt,invc.DeliveryTerms,invc.InvoiceCurrency,invc.PaymentTerms,invc.TransShipment,
                                                            invc.PartialShip, invc.Port, invc.DeliveryType, invc.Unit from tblInvoice invc
                                                            join tblPartyMaster ptm on invc.PartyNo = ptm.PartyCode
                                                            where invc.InvoiceNo = '" + txthiddenInvoiceNum.Text + "'"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        DataSet ds = new DataSet();

                        using (PerformaInvoice dsCustomers = new PerformaInvoice())
                        {
                            sda.Fill(ds);
                            return ds;
                        }
                    }
                }
            }
        }
        private DataSet GetDataItemDetails()
        {
            String constr = Convert.ToString(ConfigurationManager.AppSettings["RptConnection"]);

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select ArtNo,UPPER(ArtDesc) As ArtDesc, UPPER('REFILL INK : ' +  RefileInk) as RefileInk,Rate,Quantity,Amount from tbl_InvoiceItemDetails where InvoiceNo = '" + txthiddenInvoiceNum.Text + "'"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        DataSet ds = new DataSet();

                        using (PerformaInvoice dsCustomers = new PerformaInvoice())
                        {
                            sda.Fill(ds);
                            return ds;
                        }
                    }
                }
            }
        }

        public string ConvertNumbertoWords(long number)
        {
            if (number == 0) return "ZERO";
            if (number < 0) return "minus " + ConvertNumbertoWords(Math.Abs(number));
            string words = "";
            if ((number / 1000000) > 0)
            {
                words += ConvertNumbertoWords(number / 100000) + " LAKES ";
                number %= 1000000;
            }
            if ((number / 1000) > 0)
            {
                words += ConvertNumbertoWords(number / 1000) + " THOUSAND ";
                number %= 1000;
            }
            if ((number / 100) > 0)
            {
                words += ConvertNumbertoWords(number / 100) + " HUNDRED ";
                number %= 100;
            }
            //if ((number / 10) > 0)  
            //{  
            // words += ConvertNumbertoWords(number / 10) + " RUPEES ";  
            // number %= 10;  
            //}  
            if (number > 0)
            {
                if (words != "") words += "AND ";
                var unitsMap = new[]
                {
            "ZERO", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE", "TEN", "ELEVEN", "TWELVE", "THIRTEEN", "FOURTEEN", "FIFTEEN", "SIXTEEN", "SEVENTEEN", "EIGHTEEN", "NINETEEN"
        };
                var tensMap = new[]
                {
            "ZERO", "TEN", "TWENTY", "THIRTY", "FORTY", "FIFTY", "SIXTY", "SEVENTY", "EIGHTY", "NINETY"
        };
                if (number < 20) words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0) words += " " + unitsMap[number % 10];
                }
            }
            return words;
        }

        private void btn_pdfview_Click(object sender, EventArgs e)
        {
            // ReportViewer viwer = new ReportViewer();
            // ObjectDataSource ob = new ObjectDataSource("dataset.YourTableAdapter", "GetData");
            // dataset.YourTableAdapter ds = new dataset.YourTableAdapter();


            // string PDF = "PDF";
            // string ReportType = "ReportType";
            // Warning[] warnings = null;
            // string[] streamIds = null;
            // string mimeType = string.Empty;
            // string encoding = string.Empty;
            // string extension = string.Empty;
            // string filetype = string.Empty;



            // viwer.SizeToReportContent = true;
            // viwer.LocalReport.ReportPath = "reports/report/report.rdlc";
            // viwer.ProcessingMode = ProcessingMode.Local;
            // ob.SelectParameters.Clear();
            //// ob.SelectParameters.Add(QueryStringEnum.CompanyID, CurrentCompanyID.ToString());

            // ReportDataSource rds = new ReportDataSource("Dataset1", (object)ds.GetData());

            // viwer.LocalReport.DataSources.Add(rds);
            // viwer.LocalReport.Refresh();

            // byte[] bytes = viwer.LocalReport.Render("PDF", null,
            //  out mimeType, out encoding, out extension, out streamIds, out warnings);



        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
