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

namespace App
{
    public partial class ViewReportFrm : Form
    {
        public ViewReportFrm()
        {
            InitializeComponent();
        }

        private void ViewReportFrm_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }


        private void LoadreportoneDs()
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


        private DataSet GetDataItem()
        {
            String constr = Convert.ToString(ConfigurationManager.AppSettings["RptConnection"]);

            using (SqlConnection con = new SqlConnection(constr))
            {
                //using (SqlCommand cmd = new SqlCommand(@"select Invc.InvoiceNo,Ptm.PartyName,ptm.Address,invc.CreatedOn,invc.InvoiceGrandAmt,invc.DeliveryTerms,invc.InvoiceCurrency,invc.PaymentTerms,invc.TransShipment,
                //                                            invc.PartialShip, invc.Port, invc.DeliveryType, invc.Unit from tblInvoice invc
                //                                            join tblPartyMaster ptm on invc.PartyNo = ptm.PartyCode
                //                                            where invc.InvoiceNo = '" + txthiddenInvoiceNum.Text + "'"))

                using (SqlCommand cmd = new SqlCommand(@"select Invc.InvoiceNo,Ptm.PartyName,ptm.Address,invc.CreatedOn,invc.InvoiceGrandAmt,invc.DeliveryTerms,invc.InvoiceCurrency,invc.PaymentTerms,invc.TransShipment,
                                                            invc.PartialShip, invc.Port, invc.DeliveryType, invc.Unit from tblInvoice invc
                                                            join tblPartyMaster ptm on invc.PartyNo = ptm.PartyCode
                                                            where invc.InvoiceNo = 'SSB-3'"))


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
               // using (SqlCommand cmd = new SqlCommand("select ArtNo,UPPER(ArtDesc) As ArtDesc, UPPER('REFILL INK : ' +  RefileInk) as RefileInk,Rate,Quantity,Amount from tbl_InvoiceItemDetails where InvoiceNo = '" + txthiddenInvoiceNum.Text + "'"))
                //{//


                    using (SqlCommand cmd = new SqlCommand("select ArtNo,UPPER(ArtDesc) As ArtDesc, UPPER('REFILL INK : ' +  RefileInk) as RefileInk,Rate,Quantity,Amount from tbl_InvoiceItemDetails where InvoiceNo = 'SSB-3'"))
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
    }
}
