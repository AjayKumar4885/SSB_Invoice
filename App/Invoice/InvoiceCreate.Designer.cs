using System.Windows.Forms;

namespace App.Invoice
{
    partial class CreateInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateInvoice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.jbtnFind = new FlatButton.JFlatButton();
            this.cmbBoxUnit = new System.Windows.Forms.ComboBox();
            this.cmbBoxCurrency = new System.Windows.Forms.ComboBox();
            this.cmbboxBanks = new System.Windows.Forms.ComboBox();
            this.cmbPartyName = new System.Windows.Forms.ComboBox();
            this.txtboxAddress = new System.Windows.Forms.TextBox();
            this.InvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.txtBoxInvoiceNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPartyName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblArtId = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbboxToAddRefileInk = new System.Windows.Forms.ComboBox();
            this.lblAmout = new System.Windows.Forms.Label();
            this.txtboxQty = new System.Windows.Forms.TextBox();
            this.txtboxRate = new System.Windows.Forms.TextBox();
            this.lblArtNoData = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblArtNo = new System.Windows.Forms.Label();
            this.txtArtDesc = new System.Windows.Forms.TextBox();
            this.jbtnAdd = new FlatButton.JFlatButton();
            this.cmbBoxArtNo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grdvOrderItem = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.lblGrandQty = new System.Windows.Forms.Label();
            this.lblGrandAmout = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblDeliveryTermsValue = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.cmbTransShipment = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cmbPartialShip = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtDeliveryPeriod = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtPaymentTerms = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbDeliveryBy = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.rdbtnFOB = new System.Windows.Forms.RadioButton();
            this.rdbtnCNF = new System.Windows.Forms.RadioButton();
            this.rdbtnCIF = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdvOrderItem)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.jbtnFind);
            this.groupBox1.Controls.Add(this.cmbBoxUnit);
            this.groupBox1.Controls.Add(this.cmbBoxCurrency);
            this.groupBox1.Controls.Add(this.cmbboxBanks);
            this.groupBox1.Controls.Add(this.cmbPartyName);
            this.groupBox1.Controls.Add(this.txtboxAddress);
            this.groupBox1.Controls.Add(this.InvoiceDate);
            this.groupBox1.Controls.Add(this.txtBoxInvoiceNo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblPartyName);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1300, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice Details";
            // 
            // jbtnFind
            // 
            this.jbtnFind.BackColor = System.Drawing.Color.DodgerBlue;
            this.jbtnFind.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.jbtnFind.ButtonText = "Find";
            this.jbtnFind.CausesValidation = false;
            this.jbtnFind.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("jbtnFind.ErrorImageLeft")));
            this.jbtnFind.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("jbtnFind.ErrorImageRight")));
            this.jbtnFind.FocusBackground = System.Drawing.Color.DodgerBlue;
            this.jbtnFind.FocusFontColor = System.Drawing.Color.White;
            this.jbtnFind.ForeColors = System.Drawing.Color.White;
            this.jbtnFind.HoverBackground = System.Drawing.Color.Empty;
            this.jbtnFind.HoverFontColor = System.Drawing.Color.Empty;
            this.jbtnFind.ImageLeft = ((System.Drawing.Image)(resources.GetObject("jbtnFind.ImageLeft")));
            this.jbtnFind.ImageRight = null;
            this.jbtnFind.LeftPictureColor = System.Drawing.Color.Transparent;
            this.jbtnFind.Location = new System.Drawing.Point(1194, 17);
            this.jbtnFind.Margin = new System.Windows.Forms.Padding(4);
            this.jbtnFind.Name = "jbtnFind";
            this.jbtnFind.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.jbtnFind.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.jbtnFind.RightPictureColor = System.Drawing.Color.Transparent;
            this.jbtnFind.Size = new System.Drawing.Size(74, 26);
            this.jbtnFind.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.jbtnFind.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.jbtnFind.TabIndex = 15;
            this.jbtnFind.Click += new System.EventHandler(this.jbtnFind_Click);
            // 
            // cmbBoxUnit
            // 
            this.cmbBoxUnit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxUnit.FormattingEnabled = true;
            this.cmbBoxUnit.Location = new System.Drawing.Point(603, 54);
            this.cmbBoxUnit.Name = "cmbBoxUnit";
            this.cmbBoxUnit.Size = new System.Drawing.Size(115, 24);
            this.cmbBoxUnit.TabIndex = 4;
            // 
            // cmbBoxCurrency
            // 
            this.cmbBoxCurrency.FormattingEnabled = true;
            this.cmbBoxCurrency.Location = new System.Drawing.Point(1055, 77);
            this.cmbBoxCurrency.Name = "cmbBoxCurrency";
            this.cmbBoxCurrency.Size = new System.Drawing.Size(122, 26);
            this.cmbBoxCurrency.TabIndex = 6;
            // 
            // cmbboxBanks
            // 
            this.cmbboxBanks.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbboxBanks.FormattingEnabled = true;
            this.cmbboxBanks.Location = new System.Drawing.Point(603, 22);
            this.cmbboxBanks.Name = "cmbboxBanks";
            this.cmbboxBanks.Size = new System.Drawing.Size(214, 24);
            this.cmbboxBanks.TabIndex = 3;
            // 
            // cmbPartyName
            // 
            this.cmbPartyName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPartyName.FormattingEnabled = true;
            this.cmbPartyName.Location = new System.Drawing.Point(128, 26);
            this.cmbPartyName.Name = "cmbPartyName";
            this.cmbPartyName.Size = new System.Drawing.Size(219, 24);
            this.cmbPartyName.TabIndex = 1;
            this.cmbPartyName.SelectedIndexChanged += new System.EventHandler(this.cmbPartyName_SelectedIndexChanged);
            this.cmbPartyName.SelectionChangeCommitted += new System.EventHandler(this.cmbPartyName_SelectionChangeCommitted);
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxAddress.Location = new System.Drawing.Point(127, 55);
            this.txtboxAddress.Multiline = true;
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.Size = new System.Drawing.Size(219, 42);
            this.txtboxAddress.TabIndex = 2;
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.CustomFormat = "dd-MM-yyyy";
            this.InvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.InvoiceDate.Location = new System.Drawing.Point(1055, 49);
            this.InvoiceDate.Name = "InvoiceDate";
            this.InvoiceDate.Size = new System.Drawing.Size(122, 27);
            this.InvoiceDate.TabIndex = 5;
            // 
            // txtBoxInvoiceNo
            // 
            this.txtBoxInvoiceNo.Location = new System.Drawing.Point(1055, 18);
            this.txtBoxInvoiceNo.Name = "txtBoxInvoiceNo";
            this.txtBoxInvoiceNo.Size = new System.Drawing.Size(121, 27);
            this.txtBoxInvoiceNo.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(971, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Currency:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(551, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Unit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(551, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Bank:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(973, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(970, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Bill No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Address:";
            // 
            // lblPartyName
            // 
            this.lblPartyName.AutoSize = true;
            this.lblPartyName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartyName.Location = new System.Drawing.Point(19, 29);
            this.lblPartyName.Name = "lblPartyName";
            this.lblPartyName.Size = new System.Drawing.Size(98, 16);
            this.lblPartyName.TabIndex = 32;
            this.lblPartyName.Text = "Party Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblArtId);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Controls.Add(this.cmbBoxArtNo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 156);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1300, 137);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Invoice Add Item ";
            // 
            // lblArtId
            // 
            this.lblArtId.AutoSize = true;
            this.lblArtId.Location = new System.Drawing.Point(338, 20);
            this.lblArtId.Name = "lblArtId";
            this.lblArtId.Size = new System.Drawing.Size(0, 18);
            this.lblArtId.TabIndex = 34;
            this.lblArtId.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.98058F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.01942F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tableLayoutPanel1.Controls.Add(this.cmbboxToAddRefileInk, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAmout, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtboxQty, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtboxRate, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblArtNoData, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label14, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label13, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblArtNo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtArtDesc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.jbtnAdd, 6, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1255, 67);
            this.tableLayoutPanel1.TabIndex = 35;
            // 
            // cmbboxToAddRefileInk
            // 
            this.cmbboxToAddRefileInk.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbboxToAddRefileInk.FormattingEnabled = true;
            this.cmbboxToAddRefileInk.Location = new System.Drawing.Point(524, 37);
            this.cmbboxToAddRefileInk.Name = "cmbboxToAddRefileInk";
            this.cmbboxToAddRefileInk.Size = new System.Drawing.Size(130, 26);
            this.cmbboxToAddRefileInk.TabIndex = 10;
            // 
            // lblAmout
            // 
            this.lblAmout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmout.AutoSize = true;
            this.lblAmout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmout.Location = new System.Drawing.Point(900, 34);
            this.lblAmout.Name = "lblAmout";
            this.lblAmout.Size = new System.Drawing.Size(151, 32);
            this.lblAmout.TabIndex = 36;
            this.lblAmout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxQty
            // 
            this.txtboxQty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxQty.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxQty.Location = new System.Drawing.Point(771, 37);
            this.txtboxQty.Name = "txtboxQty";
            this.txtboxQty.Size = new System.Drawing.Size(122, 27);
            this.txtboxQty.TabIndex = 12;
            this.txtboxQty.TextChanged += new System.EventHandler(this.txtboxQty_TextChanged);
            this.txtboxQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxQty_KeyPress);
            // 
            // txtboxRate
            // 
            this.txtboxRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxRate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxRate.Location = new System.Drawing.Point(661, 37);
            this.txtboxRate.Name = "txtboxRate";
            this.txtboxRate.Size = new System.Drawing.Size(103, 27);
            this.txtboxRate.TabIndex = 11;
            this.txtboxRate.TextChanged += new System.EventHandler(this.txtboxRate_TextChanged);
            this.txtboxRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxRate_KeyPress);
            // 
            // lblArtNoData
            // 
            this.lblArtNoData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArtNoData.AutoSize = true;
            this.lblArtNoData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtNoData.Location = new System.Drawing.Point(4, 34);
            this.lblArtNoData.Name = "lblArtNoData";
            this.lblArtNoData.Size = new System.Drawing.Size(170, 32);
            this.lblArtNoData.TabIndex = 37;
            this.lblArtNoData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1058, 1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(193, 16);
            this.label14.TabIndex = 38;
            this.label14.Text = "Action";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(900, 1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 16);
            this.label13.TabIndex = 39;
            this.label13.Text = "Amount";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(771, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 16);
            this.label12.TabIndex = 40;
            this.label12.Text = "Quantity";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(661, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 16);
            this.label11.TabIndex = 41;
            this.label11.Text = "Rate";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(524, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 16);
            this.label10.TabIndex = 42;
            this.label10.Text = "Refile Ink";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(181, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(336, 16);
            this.label8.TabIndex = 44;
            this.label8.Text = "Art Desc";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblArtNo
            // 
            this.lblArtNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArtNo.AutoSize = true;
            this.lblArtNo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtNo.Location = new System.Drawing.Point(4, 1);
            this.lblArtNo.Name = "lblArtNo";
            this.lblArtNo.Size = new System.Drawing.Size(170, 16);
            this.lblArtNo.TabIndex = 45;
            this.lblArtNo.Text = "Art No";
            this.lblArtNo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtArtDesc
            // 
            this.txtArtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArtDesc.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtDesc.Location = new System.Drawing.Point(181, 37);
            this.txtArtDesc.Name = "txtArtDesc";
            this.txtArtDesc.Size = new System.Drawing.Size(336, 27);
            this.txtArtDesc.TabIndex = 8;
            // 
            // jbtnAdd
            // 
            this.jbtnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.jbtnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.jbtnAdd.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.jbtnAdd.ButtonText = "Add";
            this.jbtnAdd.CausesValidation = false;
            this.jbtnAdd.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("jbtnAdd.ErrorImageLeft")));
            this.jbtnAdd.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("jbtnAdd.ErrorImageRight")));
            this.jbtnAdd.FocusBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.jbtnAdd.FocusFontColor = System.Drawing.Color.White;
            this.jbtnAdd.ForeColors = System.Drawing.Color.White;
            this.jbtnAdd.HoverBackground = System.Drawing.Color.DodgerBlue;
            this.jbtnAdd.HoverFontColor = System.Drawing.Color.White;
            this.jbtnAdd.ImageLeft = ((System.Drawing.Image)(resources.GetObject("jbtnAdd.ImageLeft")));
            this.jbtnAdd.ImageRight = null;
            this.jbtnAdd.LeftPictureColor = System.Drawing.Color.Transparent;
            this.jbtnAdd.Location = new System.Drawing.Point(1060, 38);
            this.jbtnAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.jbtnAdd.Name = "jbtnAdd";
            this.jbtnAdd.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.jbtnAdd.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.jbtnAdd.RightPictureColor = System.Drawing.Color.Transparent;
            this.jbtnAdd.Size = new System.Drawing.Size(107, 24);
            this.jbtnAdd.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.jbtnAdd.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.jbtnAdd.TabIndex = 13;
            this.jbtnAdd.Click += new System.EventHandler(this.jbtnAdd_Click);
            this.jbtnAdd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.jbtnAdd_Enter);
            // 
            // cmbBoxArtNo
            // 
            this.cmbBoxArtNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxArtNo.FormattingEnabled = true;
            this.cmbBoxArtNo.Location = new System.Drawing.Point(118, 20);
            this.cmbBoxArtNo.Name = "cmbBoxArtNo";
            this.cmbBoxArtNo.Size = new System.Drawing.Size(219, 26);
            this.cmbBoxArtNo.TabIndex = 7;
            this.cmbBoxArtNo.SelectedIndexChanged += new System.EventHandler(this.cmbBoxArtNo_SelectedIndexChanged);
            this.cmbBoxArtNo.SelectionChangeCommitted += new System.EventHandler(this.cmbBoxArtNo_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 46;
            this.label7.Text = "Art No :";
            // 
            // grdvOrderItem
            // 
            this.grdvOrderItem.AllowUserToAddRows = false;
            this.grdvOrderItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdvOrderItem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdvOrderItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdvOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdvOrderItem.Location = new System.Drawing.Point(18, 32);
            this.grdvOrderItem.Name = "grdvOrderItem";
            this.grdvOrderItem.Size = new System.Drawing.Size(1262, 107);
            this.grdvOrderItem.TabIndex = 47;
            this.grdvOrderItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdvOrderItem_CellContentClick);
            this.grdvOrderItem.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdvOrderItem_CellEditEnd);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 1);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 27);
            this.label15.TabIndex = 48;
            this.label15.Text = "Grand Total";
            // 
            // lblGrandQty
            // 
            this.lblGrandQty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrandQty.AutoSize = true;
            this.lblGrandQty.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandQty.Location = new System.Drawing.Point(77, 1);
            this.lblGrandQty.Name = "lblGrandQty";
            this.lblGrandQty.Size = new System.Drawing.Size(44, 27);
            this.lblGrandQty.TabIndex = 49;
            // 
            // lblGrandAmout
            // 
            this.lblGrandAmout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrandAmout.AutoSize = true;
            this.lblGrandAmout.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandAmout.Location = new System.Drawing.Point(128, 1);
            this.lblGrandAmout.Name = "lblGrandAmout";
            this.lblGrandAmout.Size = new System.Drawing.Size(243, 27);
            this.lblGrandAmout.TabIndex = 50;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.70445F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.29555F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248F));
            this.tableLayoutPanel2.Controls.Add(this.lblGrandQty, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblGrandAmout, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(825, 145);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(375, 29);
            this.tableLayoutPanel2.TabIndex = 51;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCreate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(1183, 95);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 26);
            this.btnCreate.TabIndex = 20;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grdvOrderItem);
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(20, 309);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1300, 189);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Added Item";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnReset);
            this.groupBox4.Controls.Add(this.btnPrint);
            this.groupBox4.Controls.Add(this.lblDeliveryTermsValue);
            this.groupBox4.Controls.Add(this.btnCancle);
            this.groupBox4.Controls.Add(this.cmbTransShipment);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.btnCreate);
            this.groupBox4.Controls.Add(this.cmbPartialShip);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.txtRemark);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.txtDeliveryPeriod);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.txtPaymentTerms);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.txtPort);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.cmbDeliveryBy);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.rdbtnFOB);
            this.groupBox4.Controls.Add(this.rdbtnCNF);
            this.groupBox4.Controls.Add(this.rdbtnCIF);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(22, 514);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1300, 128);
            this.groupBox4.TabIndex = 54;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Term & Conditions";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(999, 96);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 27);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPrint.Enabled = false;
            this.btnPrint.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(907, 96);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 27);
            this.btnPrint.TabIndex = 22;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblDeliveryTermsValue
            // 
            this.lblDeliveryTermsValue.AutoSize = true;
            this.lblDeliveryTermsValue.Location = new System.Drawing.Point(53, 20);
            this.lblDeliveryTermsValue.Name = "lblDeliveryTermsValue";
            this.lblDeliveryTermsValue.Size = new System.Drawing.Size(0, 18);
            this.lblDeliveryTermsValue.TabIndex = 59;
            this.lblDeliveryTermsValue.Visible = false;
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.ForeColor = System.Drawing.Color.White;
            this.btnCancle.Location = new System.Drawing.Point(1090, 96);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 26);
            this.btnCancle.TabIndex = 23;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // cmbTransShipment
            // 
            this.cmbTransShipment.FormattingEnabled = true;
            this.cmbTransShipment.Location = new System.Drawing.Point(684, 97);
            this.cmbTransShipment.Name = "cmbTransShipment";
            this.cmbTransShipment.Size = new System.Drawing.Size(151, 26);
            this.cmbTransShipment.TabIndex = 61;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(556, 100);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(126, 16);
            this.label23.TabIndex = 62;
            this.label23.Text = "Trans Shipment:";
            // 
            // cmbPartialShip
            // 
            this.cmbPartialShip.FormattingEnabled = true;
            this.cmbPartialShip.Location = new System.Drawing.Point(684, 66);
            this.cmbPartialShip.Name = "cmbPartialShip";
            this.cmbPartialShip.Size = new System.Drawing.Size(151, 26);
            this.cmbPartialShip.TabIndex = 63;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(556, 69);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(95, 16);
            this.label22.TabIndex = 64;
            this.label22.Text = "Partial Ship:";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(927, 28);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(331, 47);
            this.txtRemark.TabIndex = 19;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(858, 30);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 16);
            this.label21.TabIndex = 65;
            this.label21.Text = "Remark:";
            // 
            // txtDeliveryPeriod
            // 
            this.txtDeliveryPeriod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDeliveryPeriod.Location = new System.Drawing.Point(147, 93);
            this.txtDeliveryPeriod.Name = "txtDeliveryPeriod";
            this.txtDeliveryPeriod.Size = new System.Drawing.Size(332, 27);
            this.txtDeliveryPeriod.TabIndex = 17;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(15, 93);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(127, 16);
            this.label20.TabIndex = 10;
            this.label20.Text = " Delivery Period:";
            // 
            // txtPaymentTerms
            // 
            this.txtPaymentTerms.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPaymentTerms.Location = new System.Drawing.Point(149, 61);
            this.txtPaymentTerms.Name = "txtPaymentTerms";
            this.txtPaymentTerms.Size = new System.Drawing.Size(332, 27);
            this.txtPaymentTerms.TabIndex = 16;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(15, 62);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(119, 16);
            this.label19.TabIndex = 65;
            this.label19.Text = "Payment Term:";
            // 
            // txtPort
            // 
            this.txtPort.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPort.Location = new System.Drawing.Point(685, 34);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(150, 27);
            this.txtPort.TabIndex = 18;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(556, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 16);
            this.label18.TabIndex = 66;
            this.label18.Text = "Port:";
            // 
            // cmbDeliveryBy
            // 
            this.cmbDeliveryBy.FormattingEnabled = true;
            this.cmbDeliveryBy.Location = new System.Drawing.Point(413, 30);
            this.cmbDeliveryBy.Name = "cmbDeliveryBy";
            this.cmbDeliveryBy.Size = new System.Drawing.Size(105, 26);
            this.cmbDeliveryBy.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(315, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 16);
            this.label17.TabIndex = 4;
            this.label17.Text = "Delivery By:";
            // 
            // rdbtnFOB
            // 
            this.rdbtnFOB.AutoSize = true;
            this.rdbtnFOB.Location = new System.Drawing.Point(258, 30);
            this.rdbtnFOB.Name = "rdbtnFOB";
            this.rdbtnFOB.Size = new System.Drawing.Size(59, 22);
            this.rdbtnFOB.TabIndex = 16;
            this.rdbtnFOB.TabStop = true;
            this.rdbtnFOB.Text = "FOB";
            this.rdbtnFOB.UseVisualStyleBackColor = true;
            this.rdbtnFOB.CheckedChanged += new System.EventHandler(this.rdbtnFOB_CheckedChanged);
            // 
            // rdbtnCNF
            // 
            this.rdbtnCNF.AutoSize = true;
            this.rdbtnCNF.Location = new System.Drawing.Point(202, 29);
            this.rdbtnCNF.Name = "rdbtnCNF";
            this.rdbtnCNF.Size = new System.Drawing.Size(58, 22);
            this.rdbtnCNF.TabIndex = 15;
            this.rdbtnCNF.TabStop = true;
            this.rdbtnCNF.Text = "C&&F";
            this.rdbtnCNF.UseVisualStyleBackColor = true;
            this.rdbtnCNF.CheckedChanged += new System.EventHandler(this.rdbtnCNF_CheckedChanged);
            // 
            // rdbtnCIF
            // 
            this.rdbtnCIF.AutoSize = true;
            this.rdbtnCIF.Location = new System.Drawing.Point(152, 29);
            this.rdbtnCIF.Name = "rdbtnCIF";
            this.rdbtnCIF.Size = new System.Drawing.Size(53, 22);
            this.rdbtnCIF.TabIndex = 14;
            this.rdbtnCIF.TabStop = true;
            this.rdbtnCIF.Text = "CIF";
            this.rdbtnCIF.UseVisualStyleBackColor = true;
            this.rdbtnCIF.CheckedChanged += new System.EventHandler(this.rdbtnCIF_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(15, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 16);
            this.label16.TabIndex = 70;
            this.label16.Text = "Delivery Terms:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(19, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(175, 18);
            this.label24.TabIndex = 55;
            this.label24.Text = "Invoice Add\\Update";
            // 
            // CreateInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1341, 680);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceCreate";
            this.Load += new System.EventHandler(this.InvoiceCreate_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnCreate_Enter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdvOrderItem)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        #region Controls

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPartyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxInvoiceNo;
        private System.Windows.Forms.DateTimePicker InvoiceDate;
        private System.Windows.Forms.ComboBox cmbPartyName;
        private System.Windows.Forms.TextBox txtboxAddress;
        private System.Windows.Forms.ComboBox cmbBoxUnit;
        private System.Windows.Forms.ComboBox cmbBoxCurrency;
        private System.Windows.Forms.ComboBox cmbboxBanks;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBoxArtNo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblArtNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblArtNoData;
        private System.Windows.Forms.Label lblAmout;
        private System.Windows.Forms.TextBox txtboxQty;
        private System.Windows.Forms.TextBox txtboxRate;
        private System.Windows.Forms.TextBox txtArtDesc;
        private System.Windows.Forms.ComboBox cmbboxToAddRefileInk;
        private System.Windows.Forms.DataGridView grdvOrderItem;
        private System.Windows.Forms.Label lblArtId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblGrandQty;
        private System.Windows.Forms.Label lblGrandAmout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Button btnCreate;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label16;
        private RadioButton rdbtnFOB;
        private RadioButton rdbtnCNF;
        private RadioButton rdbtnCIF;
        private Label label17;
        private ComboBox cmbDeliveryBy;
        private Label label18;
        private TextBox txtPort;
        private Label label19;
        private TextBox txtPaymentTerms;
        private Label label20;
        private TextBox txtDeliveryPeriod;
        private Label label21;
        private TextBox txtRemark;
        private Label label22;
        private ComboBox cmbPartialShip;
        private Label label23;
        private ComboBox cmbTransShipment;
        private Button btnCancle;
        private Label lblDeliveryTermsValue;
        private Button btnReset;
        private Button btnPrint;
        private FlatButton.JFlatButton jbtnFind;
        private FlatButton.JFlatButton jbtnAdd;

        #endregion

        private Label label24;
    }
}