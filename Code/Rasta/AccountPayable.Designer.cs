namespace Rasta
{
    partial class AccountPayable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountPayable));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.lbl = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblSupplierCode = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblRecievedDate = new System.Windows.Forms.Label();
            this.cmbSupplierCode = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPONumber = new System.Windows.Forms.Label();
            this.lblPOAmount = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtPONumber = new System.Windows.Forms.TextBox();
            this.txtPOAmount = new System.Windows.Forms.TextBox();
            this.lnkNewSupplier = new System.Windows.Forms.LinkLabel();
            this.calDate = new System.Windows.Forms.DateTimePicker();
            this.calRecievedDate = new System.Windows.Forms.DateTimePicker();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.combobox1 = new System.Windows.Forms.ComboBox();
            this.lblPaymentDueDate = new System.Windows.Forms.Label();
            this.lblSite = new System.Windows.Forms.Label();
            this.lblPaymentPurpose = new System.Windows.Forms.Label();
            this.cmbSite = new System.Windows.Forms.ComboBox();
            this.txtPaymentPurpose = new System.Windows.Forms.TextBox();
            this.calPaymentDueDate = new System.Windows.Forms.DateTimePicker();
            this.calInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.cmbSupplierName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblAPID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExportToPDF = new System.Windows.Forms.Button();
            this.dgvApproverManagement = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnApprove = new System.Windows.Forms.Button();
            this.dgvAccountPayable = new System.Windows.Forms.DataGridView();
            this.Approved = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.APID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modify = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Suppliercode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentPurpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PONumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceivedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrencyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApproverManagement)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountPayable)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.AutoSize = true;
            this.tblMain.ColumnCount = 4;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.Controls.Add(this.lbl, 0, 0);
            this.tblMain.Controls.Add(this.lblSupplierName, 0, 2);
            this.tblMain.Controls.Add(this.lblSupplierCode, 2, 2);
            this.tblMain.Controls.Add(this.lblInvoiceDate, 0, 7);
            this.tblMain.Controls.Add(this.lblRecievedDate, 2, 7);
            this.tblMain.Controls.Add(this.cmbSupplierCode, 3, 2);
            this.tblMain.Controls.Add(this.lblAmount, 0, 4);
            this.tblMain.Controls.Add(this.lblCurrency, 2, 4);
            this.tblMain.Controls.Add(this.txtAmount, 1, 4);
            this.tblMain.Controls.Add(this.cmbCurrency, 3, 4);
            this.tblMain.Controls.Add(this.lblType, 0, 8);
            this.tblMain.Controls.Add(this.label1, 2, 8);
            this.tblMain.Controls.Add(this.lblPONumber, 0, 6);
            this.tblMain.Controls.Add(this.lblPOAmount, 2, 6);
            this.tblMain.Controls.Add(this.lblDate, 0, 3);
            this.tblMain.Controls.Add(this.txtPONumber, 1, 6);
            this.tblMain.Controls.Add(this.txtPOAmount, 3, 6);
            this.tblMain.Controls.Add(this.lnkNewSupplier, 0, 1);
            this.tblMain.Controls.Add(this.calDate, 1, 3);
            this.tblMain.Controls.Add(this.calRecievedDate, 3, 7);
            this.tblMain.Controls.Add(this.cmbType, 1, 8);
            this.tblMain.Controls.Add(this.combobox1, 3, 8);
            this.tblMain.Controls.Add(this.lblPaymentDueDate, 2, 3);
            this.tblMain.Controls.Add(this.lblSite, 0, 5);
            this.tblMain.Controls.Add(this.lblPaymentPurpose, 2, 5);
            this.tblMain.Controls.Add(this.cmbSite, 1, 5);
            this.tblMain.Controls.Add(this.txtPaymentPurpose, 3, 5);
            this.tblMain.Controls.Add(this.calPaymentDueDate, 3, 3);
            this.tblMain.Controls.Add(this.calInvoiceDate, 1, 7);
            this.tblMain.Controls.Add(this.cmbSupplierName, 1, 2);
            this.tblMain.Controls.Add(this.label2, 0, 9);
            this.tblMain.Controls.Add(this.label3, 2, 9);
            this.tblMain.Controls.Add(this.comboBox2, 1, 9);
            this.tblMain.Controls.Add(this.comboBox3, 3, 9);
            this.tblMain.Controls.Add(this.lblAPID, 3, 1);
            this.tblMain.Controls.Add(this.btnUpdate, 0, 12);
            this.tblMain.Controls.Add(this.btnSave, 1, 12);
            this.tblMain.Controls.Add(this.btnExportToPDF, 2, 12);
            this.tblMain.Controls.Add(this.dgvApproverManagement, 0, 11);
            this.tblMain.Controls.Add(this.label4, 0, 10);
            this.tblMain.Controls.Add(this.comboBox4, 1, 10);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(3, 3);
            this.tblMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 13;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.817467F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.817467F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.817467F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.817467F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.817467F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.817467F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.817467F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.817467F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.817467F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.817467F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.820137F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75038F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.254815F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(1260, 633);
            this.tblMain.TabIndex = 0;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.tblMain.SetColumnSpan(this.lbl, 4);
            this.lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(2, 0);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(1256, 43);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Account Payable";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSupplierName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierName.Location = new System.Drawing.Point(2, 86);
            this.lblSupplierName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblSupplierName.Size = new System.Drawing.Size(311, 43);
            this.lblSupplierName.TabIndex = 1;
            this.lblSupplierName.Text = "SupplierName";
            this.lblSupplierName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSupplierCode
            // 
            this.lblSupplierCode.AutoSize = true;
            this.lblSupplierCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSupplierCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierCode.Location = new System.Drawing.Point(632, 86);
            this.lblSupplierCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierCode.Name = "lblSupplierCode";
            this.lblSupplierCode.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblSupplierCode.Size = new System.Drawing.Size(311, 43);
            this.lblSupplierCode.TabIndex = 9;
            this.lblSupplierCode.Text = "SupplierCode";
            this.lblSupplierCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInvoiceDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceDate.Location = new System.Drawing.Point(2, 301);
            this.lblInvoiceDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblInvoiceDate.Size = new System.Drawing.Size(311, 43);
            this.lblInvoiceDate.TabIndex = 7;
            this.lblInvoiceDate.Text = "InvoiceDate";
            this.lblInvoiceDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRecievedDate
            // 
            this.lblRecievedDate.AutoSize = true;
            this.lblRecievedDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecievedDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecievedDate.Location = new System.Drawing.Point(632, 301);
            this.lblRecievedDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecievedDate.Name = "lblRecievedDate";
            this.lblRecievedDate.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblRecievedDate.Size = new System.Drawing.Size(311, 43);
            this.lblRecievedDate.TabIndex = 8;
            this.lblRecievedDate.Text = "Recieved Date";
            this.lblRecievedDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSupplierCode
            // 
            this.cmbSupplierCode.FormattingEnabled = true;
            this.cmbSupplierCode.Items.AddRange(new object[] {
            "Sp0001",
            "Sp0002",
            "Sp0003",
            "Sp0004",
            "Sp0005"});
            this.cmbSupplierCode.Location = new System.Drawing.Point(947, 91);
            this.cmbSupplierCode.Margin = new System.Windows.Forms.Padding(2, 5, 2, 3);
            this.cmbSupplierCode.Name = "cmbSupplierCode";
            this.cmbSupplierCode.Size = new System.Drawing.Size(120, 21);
            this.cmbSupplierCode.TabIndex = 15;
            this.cmbSupplierCode.Text = "--Select--";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(2, 172);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblAmount.Size = new System.Drawing.Size(311, 43);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Amount";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrency.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.Location = new System.Drawing.Point(632, 172);
            this.lblCurrency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblCurrency.Size = new System.Drawing.Size(311, 43);
            this.lblCurrency.TabIndex = 6;
            this.lblCurrency.Text = "Currency";
            this.lblCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(317, 177);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2, 5, 2, 3);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(120, 20);
            this.txtAmount.TabIndex = 19;
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Items.AddRange(new object[] {
            "AOA",
            "USD",
            "EUR"});
            this.cmbCurrency.Location = new System.Drawing.Point(947, 177);
            this.cmbCurrency.Margin = new System.Windows.Forms.Padding(2, 5, 2, 3);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(120, 21);
            this.cmbCurrency.TabIndex = 23;
            this.cmbCurrency.Text = "--Select--";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(2, 344);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblType.Size = new System.Drawing.Size(311, 43);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "CostCode";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(632, 344);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(311, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Visible = false;
            // 
            // lblPONumber
            // 
            this.lblPONumber.AutoSize = true;
            this.lblPONumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPONumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPONumber.Location = new System.Drawing.Point(2, 258);
            this.lblPONumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPONumber.Name = "lblPONumber";
            this.lblPONumber.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblPONumber.Size = new System.Drawing.Size(311, 43);
            this.lblPONumber.TabIndex = 3;
            this.lblPONumber.Text = "PO Number";
            this.lblPONumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPOAmount
            // 
            this.lblPOAmount.AutoSize = true;
            this.lblPOAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPOAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOAmount.Location = new System.Drawing.Point(632, 258);
            this.lblPOAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPOAmount.Name = "lblPOAmount";
            this.lblPOAmount.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblPOAmount.Size = new System.Drawing.Size(311, 43);
            this.lblPOAmount.TabIndex = 3;
            this.lblPOAmount.Text = "PO Amount";
            this.lblPOAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(2, 129);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblDate.Size = new System.Drawing.Size(311, 43);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPONumber
            // 
            this.txtPONumber.Location = new System.Drawing.Point(317, 263);
            this.txtPONumber.Margin = new System.Windows.Forms.Padding(2, 5, 2, 3);
            this.txtPONumber.Name = "txtPONumber";
            this.txtPONumber.Size = new System.Drawing.Size(120, 20);
            this.txtPONumber.TabIndex = 19;
            // 
            // txtPOAmount
            // 
            this.txtPOAmount.Location = new System.Drawing.Point(947, 263);
            this.txtPOAmount.Margin = new System.Windows.Forms.Padding(2, 5, 2, 3);
            this.txtPOAmount.Name = "txtPOAmount";
            this.txtPOAmount.Size = new System.Drawing.Size(120, 20);
            this.txtPOAmount.TabIndex = 28;
            // 
            // lnkNewSupplier
            // 
            this.lnkNewSupplier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lnkNewSupplier.AutoSize = true;
            this.lnkNewSupplier.Location = new System.Drawing.Point(30, 68);
            this.lnkNewSupplier.Margin = new System.Windows.Forms.Padding(30, 20, 3, 0);
            this.lnkNewSupplier.Name = "lnkNewSupplier";
            this.lnkNewSupplier.Size = new System.Drawing.Size(90, 13);
            this.lnkNewSupplier.TabIndex = 30;
            this.lnkNewSupplier.TabStop = true;
            this.lnkNewSupplier.Text = "Add New supplier";
            // 
            // calDate
            // 
            this.calDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calDate.Location = new System.Drawing.Point(317, 134);
            this.calDate.Margin = new System.Windows.Forms.Padding(2, 5, 2, 3);
            this.calDate.Name = "calDate";
            this.calDate.Size = new System.Drawing.Size(120, 20);
            this.calDate.TabIndex = 29;
            this.calDate.ValueChanged += new System.EventHandler(this.calDate_ValueChanged);
            // 
            // calRecievedDate
            // 
            this.calRecievedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calRecievedDate.Location = new System.Drawing.Point(947, 306);
            this.calRecievedDate.Margin = new System.Windows.Forms.Padding(2, 5, 2, 3);
            this.calRecievedDate.Name = "calRecievedDate";
            this.calRecievedDate.Size = new System.Drawing.Size(120, 20);
            this.calRecievedDate.TabIndex = 22;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(317, 349);
            this.cmbType.Margin = new System.Windows.Forms.Padding(2, 5, 2, 3);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(120, 21);
            this.cmbType.TabIndex = 16;
            this.cmbType.Text = "--Select--";
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // combobox1
            // 
            this.combobox1.FormattingEnabled = true;
            this.combobox1.Location = new System.Drawing.Point(947, 349);
            this.combobox1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 3);
            this.combobox1.Name = "combobox1";
            this.combobox1.Size = new System.Drawing.Size(120, 21);
            this.combobox1.TabIndex = 17;
            this.combobox1.Visible = false;
            this.combobox1.SelectedIndexChanged += new System.EventHandler(this.cmbProject_SelectedIndexChanged);
            // 
            // lblPaymentDueDate
            // 
            this.lblPaymentDueDate.AutoSize = true;
            this.lblPaymentDueDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaymentDueDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDueDate.Location = new System.Drawing.Point(632, 129);
            this.lblPaymentDueDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymentDueDate.Name = "lblPaymentDueDate";
            this.lblPaymentDueDate.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblPaymentDueDate.Size = new System.Drawing.Size(311, 43);
            this.lblPaymentDueDate.TabIndex = 3;
            this.lblPaymentDueDate.Text = "Payment Due Date";
            this.lblPaymentDueDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSite.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSite.Location = new System.Drawing.Point(2, 215);
            this.lblSite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSite.Name = "lblSite";
            this.lblSite.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblSite.Size = new System.Drawing.Size(311, 43);
            this.lblSite.TabIndex = 3;
            this.lblSite.Text = "Site";
            this.lblSite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPaymentPurpose
            // 
            this.lblPaymentPurpose.AutoSize = true;
            this.lblPaymentPurpose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaymentPurpose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentPurpose.Location = new System.Drawing.Point(632, 215);
            this.lblPaymentPurpose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymentPurpose.Name = "lblPaymentPurpose";
            this.lblPaymentPurpose.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblPaymentPurpose.Size = new System.Drawing.Size(311, 43);
            this.lblPaymentPurpose.TabIndex = 3;
            this.lblPaymentPurpose.Text = "Payment Purpose";
            this.lblPaymentPurpose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSite
            // 
            this.cmbSite.FormattingEnabled = true;
            this.cmbSite.Location = new System.Drawing.Point(317, 220);
            this.cmbSite.Margin = new System.Windows.Forms.Padding(2, 5, 2, 3);
            this.cmbSite.Name = "cmbSite";
            this.cmbSite.Size = new System.Drawing.Size(120, 21);
            this.cmbSite.TabIndex = 14;
            this.cmbSite.Text = "--Select--";
            // 
            // txtPaymentPurpose
            // 
            this.txtPaymentPurpose.Location = new System.Drawing.Point(947, 220);
            this.txtPaymentPurpose.Margin = new System.Windows.Forms.Padding(2, 5, 2, 3);
            this.txtPaymentPurpose.Name = "txtPaymentPurpose";
            this.txtPaymentPurpose.Size = new System.Drawing.Size(120, 20);
            this.txtPaymentPurpose.TabIndex = 19;
            // 
            // calPaymentDueDate
            // 
            this.calPaymentDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calPaymentDueDate.Location = new System.Drawing.Point(947, 134);
            this.calPaymentDueDate.Margin = new System.Windows.Forms.Padding(2, 5, 2, 3);
            this.calPaymentDueDate.Name = "calPaymentDueDate";
            this.calPaymentDueDate.Size = new System.Drawing.Size(120, 20);
            this.calPaymentDueDate.TabIndex = 22;
            this.calPaymentDueDate.Value = new System.DateTime(2014, 10, 19, 15, 49, 20, 770);
            // 
            // calInvoiceDate
            // 
            this.calInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calInvoiceDate.Location = new System.Drawing.Point(317, 306);
            this.calInvoiceDate.Margin = new System.Windows.Forms.Padding(2, 5, 2, 3);
            this.calInvoiceDate.Name = "calInvoiceDate";
            this.calInvoiceDate.Size = new System.Drawing.Size(120, 20);
            this.calInvoiceDate.TabIndex = 21;
            // 
            // cmbSupplierName
            // 
            this.cmbSupplierName.FormattingEnabled = true;
            this.cmbSupplierName.Location = new System.Drawing.Point(317, 91);
            this.cmbSupplierName.Margin = new System.Windows.Forms.Padding(2, 5, 2, 3);
            this.cmbSupplierName.Name = "cmbSupplierName";
            this.cmbSupplierName.Size = new System.Drawing.Size(120, 21);
            this.cmbSupplierName.TabIndex = 14;
            this.cmbSupplierName.Text = "--Select--";
            this.cmbSupplierName.SelectedIndexChanged += new System.EventHandler(this.cmbSupplierName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 387);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(311, 43);
            this.label2.TabIndex = 34;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(632, 387);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(311, 43);
            this.label3.TabIndex = 35;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(318, 390);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 36;
            this.comboBox2.Visible = false;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(948, 390);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 37;
            this.comboBox3.Visible = false;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // lblAPID
            // 
            this.lblAPID.AutoSize = true;
            this.lblAPID.Location = new System.Drawing.Point(948, 43);
            this.lblAPID.Name = "lblAPID";
            this.lblAPID.Size = new System.Drawing.Size(0, 13);
            this.lblAPID.TabIndex = 39;
            this.lblAPID.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(230, 594);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(230, 3, 3, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUpdate.Size = new System.Drawing.Size(75, 29);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(345, 594);
            this.btnSave.Margin = new System.Windows.Forms.Padding(30, 3, 2, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 29);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExportToPDF
            // 
            this.btnExportToPDF.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportToPDF.Location = new System.Drawing.Point(660, 594);
            this.btnExportToPDF.Margin = new System.Windows.Forms.Padding(30, 3, 2, 10);
            this.btnExportToPDF.Name = "btnExportToPDF";
            this.btnExportToPDF.Size = new System.Drawing.Size(167, 29);
            this.btnExportToPDF.TabIndex = 32;
            this.btnExportToPDF.Text = "Generate PDF";
            this.btnExportToPDF.UseVisualStyleBackColor = true;
            this.btnExportToPDF.Click += new System.EventHandler(this.btnExportToPDF_Click);
            // 
            // dgvApproverManagement
            // 
            this.dgvApproverManagement.AllowUserToAddRows = false;
            this.dgvApproverManagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvApproverManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApproverManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApproverManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApproverManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.UserName,
            this.Comment,
            this.Visa,
            this.Date});
            this.tblMain.SetColumnSpan(this.dgvApproverManagement, 4);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvApproverManagement.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvApproverManagement.Location = new System.Drawing.Point(30, 476);
            this.dgvApproverManagement.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.dgvApproverManagement.Name = "dgvApproverManagement";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApproverManagement.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvApproverManagement.Size = new System.Drawing.Size(1200, 86);
            this.dgvApproverManagement.TabIndex = 33;
            this.dgvApproverManagement.Visible = false;
            this.dgvApproverManagement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApproverManagement_CellClick);
            this.dgvApproverManagement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApproverManagement_CellContentClick);
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UserName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            // 
            // Visa
            // 
            this.Visa.HeaderText = "Visa";
            this.Visa.Name = "Visa";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 430);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(311, 43);
            this.label4.TabIndex = 40;
            this.label4.Text = "label4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Visible = false;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(318, 433);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 41;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1274, 665);
            this.tabControl1.TabIndex = 38;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tblMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1266, 639);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add/Edit Account Payable";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnApprove);
            this.tabPage2.Controls.Add(this.dgvAccountPayable);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1266, 639);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Account Payable";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(41, 238);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(75, 23);
            this.btnApprove.TabIndex = 1;
            this.btnApprove.Text = "Update";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // dgvAccountPayable
            // 
            this.dgvAccountPayable.AllowUserToAddRows = false;
            this.dgvAccountPayable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccountPayable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAccountPayable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountPayable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Approved,
            this.APID,
            this.SupplierName,
            this.DueDate,
            this.Amount,
            this.Currency,
            this.Site,
            this.Modify,
            this.Delete,
            this.Suppliercode,
            this.CurrentDate,
            this.CostCode,
            this.PaymentPurpose,
            this.PONumber,
            this.POAmount,
            this.InvoiceDate,
            this.ReceivedDate,
            this.CurrencyID,
            this.SiteID});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccountPayable.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAccountPayable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvAccountPayable.Location = new System.Drawing.Point(3, 3);
            this.dgvAccountPayable.Name = "dgvAccountPayable";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccountPayable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAccountPayable.Size = new System.Drawing.Size(1260, 200);
            this.dgvAccountPayable.TabIndex = 0;
            this.dgvAccountPayable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccountPayable_CellClick);
            // 
            // Approved
            // 
            this.Approved.HeaderText = "Approved";
            this.Approved.Name = "Approved";
            // 
            // APID
            // 
            this.APID.HeaderText = "APID";
            this.APID.Name = "APID";
            this.APID.ReadOnly = true;
            // 
            // SupplierName
            // 
            this.SupplierName.HeaderText = "SupplierName";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            // 
            // DueDate
            // 
            this.DueDate.HeaderText = "DueDate";
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Currency
            // 
            this.Currency.HeaderText = "Currency";
            this.Currency.Name = "Currency";
            this.Currency.ReadOnly = true;
            // 
            // Site
            // 
            this.Site.HeaderText = "Site";
            this.Site.Name = "Site";
            this.Site.ReadOnly = true;
            // 
            // Modify
            // 
            this.Modify.HeaderText = "";
            this.Modify.Image = ((System.Drawing.Image)(resources.GetObject("Modify.Image")));
            this.Modify.Name = "Modify";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            // 
            // Suppliercode
            // 
            this.Suppliercode.HeaderText = "Suppliercode";
            this.Suppliercode.Name = "Suppliercode";
            this.Suppliercode.ReadOnly = true;
            this.Suppliercode.Visible = false;
            // 
            // CurrentDate
            // 
            this.CurrentDate.HeaderText = "CurrentDate";
            this.CurrentDate.Name = "CurrentDate";
            this.CurrentDate.ReadOnly = true;
            this.CurrentDate.Visible = false;
            // 
            // CostCode
            // 
            this.CostCode.HeaderText = "CostCode";
            this.CostCode.Name = "CostCode";
            this.CostCode.ReadOnly = true;
            this.CostCode.Visible = false;
            // 
            // PaymentPurpose
            // 
            this.PaymentPurpose.HeaderText = "PaymentPurpose";
            this.PaymentPurpose.Name = "PaymentPurpose";
            this.PaymentPurpose.ReadOnly = true;
            this.PaymentPurpose.Visible = false;
            // 
            // PONumber
            // 
            this.PONumber.HeaderText = "PONumber";
            this.PONumber.Name = "PONumber";
            this.PONumber.ReadOnly = true;
            this.PONumber.Visible = false;
            // 
            // POAmount
            // 
            this.POAmount.HeaderText = "POAmount";
            this.POAmount.Name = "POAmount";
            this.POAmount.ReadOnly = true;
            this.POAmount.Visible = false;
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.HeaderText = "InvoiceDate";
            this.InvoiceDate.Name = "InvoiceDate";
            this.InvoiceDate.ReadOnly = true;
            this.InvoiceDate.Visible = false;
            // 
            // ReceivedDate
            // 
            this.ReceivedDate.HeaderText = "ReceivedDate";
            this.ReceivedDate.Name = "ReceivedDate";
            this.ReceivedDate.ReadOnly = true;
            this.ReceivedDate.Visible = false;
            // 
            // CurrencyID
            // 
            this.CurrencyID.HeaderText = "CurrencyID";
            this.CurrencyID.Name = "CurrencyID";
            this.CurrencyID.ReadOnly = true;
            this.CurrencyID.Visible = false;
            // 
            // SiteID
            // 
            this.SiteID.HeaderText = "CurrencyID";
            this.SiteID.Name = "SiteID";
            this.SiteID.ReadOnly = true;
            this.SiteID.Visible = false;
            // 
            // AccountPayable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 666);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AccountPayable";
            this.Text = "AccountPayable";
            this.Load += new System.EventHandler(this.AccountPayable_Load);
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApproverManagement)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountPayable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblSupplierCode;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label lblRecievedDate;
        private System.Windows.Forms.ComboBox cmbSupplierName;
        private System.Windows.Forms.ComboBox cmbSupplierCode;
        private System.Windows.Forms.DateTimePicker calInvoiceDate;
        private System.Windows.Forms.DateTimePicker calRecievedDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox combobox1;
        private System.Windows.Forms.Label lblPONumber;
        private System.Windows.Forms.Label lblPOAmount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtPONumber;
        private System.Windows.Forms.TextBox txtPOAmount;
        private System.Windows.Forms.DateTimePicker calDate;
        private System.Windows.Forms.LinkLabel lnkNewSupplier;
        private System.Windows.Forms.Label lblPaymentDueDate;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.Label lblPaymentPurpose;
        private System.Windows.Forms.DateTimePicker calPaymentDueDate;
        private System.Windows.Forms.ComboBox cmbSite;
        private System.Windows.Forms.TextBox txtPaymentPurpose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExportToPDF;
        private System.Windows.Forms.DataGridView dgvApproverManagement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvAccountPayable;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Approved;
        private System.Windows.Forms.DataGridViewTextBoxColumn APID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Site;
        private System.Windows.Forms.DataGridViewImageColumn Modify;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suppliercode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentPurpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn PONumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn POAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceivedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrencyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiteID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblAPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewComboBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
    }

}