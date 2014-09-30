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
            this.lblProject = new System.Windows.Forms.Label();
            this.lblPONumber = new System.Windows.Forms.Label();
            this.lblPOAmount = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtPONumber = new System.Windows.Forms.TextBox();
            this.txtPOAmount = new System.Windows.Forms.TextBox();
            this.lnkNewSupplier = new System.Windows.Forms.LinkLabel();
            this.cmbSupplierName = new System.Windows.Forms.ComboBox();
            this.calDate = new System.Windows.Forms.DateTimePicker();
            this.calRecievedDate = new System.Windows.Forms.DateTimePicker();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.lblPaymentDueDate = new System.Windows.Forms.Label();
            this.lblSite = new System.Windows.Forms.Label();
            this.lblPaymentPurpose = new System.Windows.Forms.Label();
            this.cmbSite = new System.Windows.Forms.ComboBox();
            this.txtPaymentPurpose = new System.Windows.Forms.TextBox();
            this.calPaymentDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExportToPDF = new System.Windows.Forms.Button();
            this.dgvApproverManagement = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApproverManagement)).BeginInit();
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
            this.tblMain.Controls.Add(this.lblProject, 2, 8);
            this.tblMain.Controls.Add(this.lblPONumber, 0, 6);
            this.tblMain.Controls.Add(this.lblPOAmount, 2, 6);
            this.tblMain.Controls.Add(this.lblDate, 0, 3);
            this.tblMain.Controls.Add(this.txtPONumber, 1, 6);
            this.tblMain.Controls.Add(this.txtPOAmount, 3, 6);
            this.tblMain.Controls.Add(this.lnkNewSupplier, 0, 1);
            this.tblMain.Controls.Add(this.cmbSupplierName, 1, 2);
            this.tblMain.Controls.Add(this.calDate, 1, 3);
            this.tblMain.Controls.Add(this.calRecievedDate, 3, 7);
            this.tblMain.Controls.Add(this.cmbType, 1, 8);
            this.tblMain.Controls.Add(this.cmbProject, 3, 8);
            this.tblMain.Controls.Add(this.lblPaymentDueDate, 2, 3);
            this.tblMain.Controls.Add(this.lblSite, 0, 5);
            this.tblMain.Controls.Add(this.lblPaymentPurpose, 2, 5);
            this.tblMain.Controls.Add(this.cmbSite, 1, 5);
            this.tblMain.Controls.Add(this.txtPaymentPurpose, 3, 5);
            this.tblMain.Controls.Add(this.calPaymentDueDate, 3, 3);
            this.tblMain.Controls.Add(this.btnSave, 1, 10);
            this.tblMain.Controls.Add(this.btnExportToPDF, 2, 10);
            this.tblMain.Controls.Add(this.dgvApproverManagement, 0, 9);
            this.tblMain.Controls.Add(this.calInvoiceDate, 1, 7);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 11;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tblMain.Size = new System.Drawing.Size(799, 514);
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
            this.lbl.Size = new System.Drawing.Size(795, 41);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Account Payable";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSupplierName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierName.Location = new System.Drawing.Point(2, 82);
            this.lblSupplierName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblSupplierName.Size = new System.Drawing.Size(195, 41);
            this.lblSupplierName.TabIndex = 1;
            this.lblSupplierName.Text = "SupplierName";
            this.lblSupplierName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSupplierCode
            // 
            this.lblSupplierCode.AutoSize = true;
            this.lblSupplierCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSupplierCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierCode.Location = new System.Drawing.Point(400, 82);
            this.lblSupplierCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierCode.Name = "lblSupplierCode";
            this.lblSupplierCode.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblSupplierCode.Size = new System.Drawing.Size(195, 41);
            this.lblSupplierCode.TabIndex = 9;
            this.lblSupplierCode.Text = "SupplierCode";
            this.lblSupplierCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInvoiceDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceDate.Location = new System.Drawing.Point(2, 287);
            this.lblInvoiceDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblInvoiceDate.Size = new System.Drawing.Size(195, 41);
            this.lblInvoiceDate.TabIndex = 7;
            this.lblInvoiceDate.Text = "InvoiceDate";
            this.lblInvoiceDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRecievedDate
            // 
            this.lblRecievedDate.AutoSize = true;
            this.lblRecievedDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecievedDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecievedDate.Location = new System.Drawing.Point(400, 287);
            this.lblRecievedDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecievedDate.Name = "lblRecievedDate";
            this.lblRecievedDate.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblRecievedDate.Size = new System.Drawing.Size(195, 41);
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
            this.cmbSupplierCode.Location = new System.Drawing.Point(599, 102);
            this.cmbSupplierCode.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
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
            this.lblAmount.Location = new System.Drawing.Point(2, 164);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblAmount.Size = new System.Drawing.Size(195, 41);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Amount";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrency.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.Location = new System.Drawing.Point(400, 164);
            this.lblCurrency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblCurrency.Size = new System.Drawing.Size(195, 41);
            this.lblCurrency.TabIndex = 6;
            this.lblCurrency.Text = "Currency";
            this.lblCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(201, 184);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
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
            this.cmbCurrency.Location = new System.Drawing.Point(599, 184);
            this.cmbCurrency.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
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
            this.lblType.Location = new System.Drawing.Point(2, 328);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblType.Size = new System.Drawing.Size(195, 41);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "CostCode";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(400, 328);
            this.lblProject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProject.Name = "lblProject";
            this.lblProject.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblProject.Size = new System.Drawing.Size(195, 41);
            this.lblProject.TabIndex = 3;
            this.lblProject.Text = "Project";
            this.lblProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPONumber
            // 
            this.lblPONumber.AutoSize = true;
            this.lblPONumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPONumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPONumber.Location = new System.Drawing.Point(2, 246);
            this.lblPONumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPONumber.Name = "lblPONumber";
            this.lblPONumber.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblPONumber.Size = new System.Drawing.Size(195, 41);
            this.lblPONumber.TabIndex = 3;
            this.lblPONumber.Text = "PO Number";
            this.lblPONumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPOAmount
            // 
            this.lblPOAmount.AutoSize = true;
            this.lblPOAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPOAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOAmount.Location = new System.Drawing.Point(400, 246);
            this.lblPOAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPOAmount.Name = "lblPOAmount";
            this.lblPOAmount.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblPOAmount.Size = new System.Drawing.Size(195, 41);
            this.lblPOAmount.TabIndex = 3;
            this.lblPOAmount.Text = "PO Amount";
            this.lblPOAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(2, 123);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblDate.Size = new System.Drawing.Size(195, 41);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPONumber
            // 
            this.txtPONumber.Location = new System.Drawing.Point(201, 266);
            this.txtPONumber.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.txtPONumber.Name = "txtPONumber";
            this.txtPONumber.Size = new System.Drawing.Size(120, 20);
            this.txtPONumber.TabIndex = 19;
            // 
            // txtPOAmount
            // 
            this.txtPOAmount.Location = new System.Drawing.Point(599, 266);
            this.txtPOAmount.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.txtPOAmount.Name = "txtPOAmount";
            this.txtPOAmount.Size = new System.Drawing.Size(120, 20);
            this.txtPOAmount.TabIndex = 28;
            // 
            // lnkNewSupplier
            // 
            this.lnkNewSupplier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lnkNewSupplier.AutoSize = true;
            this.lnkNewSupplier.Location = new System.Drawing.Point(30, 65);
            this.lnkNewSupplier.Margin = new System.Windows.Forms.Padding(30, 20, 3, 0);
            this.lnkNewSupplier.Name = "lnkNewSupplier";
            this.lnkNewSupplier.Size = new System.Drawing.Size(90, 13);
            this.lnkNewSupplier.TabIndex = 30;
            this.lnkNewSupplier.TabStop = true;
            this.lnkNewSupplier.Text = "Add New supplier";
            // 
            // cmbSupplierName
            // 
            this.cmbSupplierName.FormattingEnabled = true;
            this.cmbSupplierName.Location = new System.Drawing.Point(201, 102);
            this.cmbSupplierName.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.cmbSupplierName.Name = "cmbSupplierName";
            this.cmbSupplierName.Size = new System.Drawing.Size(120, 21);
            this.cmbSupplierName.TabIndex = 14;
            this.cmbSupplierName.Text = "--Select--";
            // 
            // calDate
            // 
            this.calDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calDate.Location = new System.Drawing.Point(201, 143);
            this.calDate.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.calDate.Name = "calDate";
            this.calDate.Size = new System.Drawing.Size(120, 20);
            this.calDate.TabIndex = 29;
            this.calDate.ValueChanged += new System.EventHandler(this.calDate_ValueChanged);
            // 
            // calRecievedDate
            // 
            this.calRecievedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calRecievedDate.Location = new System.Drawing.Point(599, 307);
            this.calRecievedDate.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.calRecievedDate.Name = "calRecievedDate";
            this.calRecievedDate.Size = new System.Drawing.Size(120, 20);
            this.calRecievedDate.TabIndex = 22;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "General activities Expenses",
            "Management fees Expenses",
            "Capex Expenses",
            "Other Expenses",
            "Overhead Expenses"});
            this.cmbType.Location = new System.Drawing.Point(201, 348);
            this.cmbType.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(120, 21);
            this.cmbType.TabIndex = 16;
            this.cmbType.Text = "--Select--";
            // 
            // cmbProject
            // 
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Items.AddRange(new object[] {
            "Project_1",
            "Project_2",
            "Project_3",
            "Project_4",
            "Project_5"});
            this.cmbProject.Location = new System.Drawing.Point(599, 348);
            this.cmbProject.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(120, 21);
            this.cmbProject.TabIndex = 17;
            this.cmbProject.Text = "--Select--";
            this.cmbProject.SelectedIndexChanged += new System.EventHandler(this.cmbProject_SelectedIndexChanged);
            // 
            // lblPaymentDueDate
            // 
            this.lblPaymentDueDate.AutoSize = true;
            this.lblPaymentDueDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaymentDueDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDueDate.Location = new System.Drawing.Point(400, 123);
            this.lblPaymentDueDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymentDueDate.Name = "lblPaymentDueDate";
            this.lblPaymentDueDate.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblPaymentDueDate.Size = new System.Drawing.Size(195, 41);
            this.lblPaymentDueDate.TabIndex = 3;
            this.lblPaymentDueDate.Text = "Payment Due Date";
            this.lblPaymentDueDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSite.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSite.Location = new System.Drawing.Point(2, 205);
            this.lblSite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSite.Name = "lblSite";
            this.lblSite.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblSite.Size = new System.Drawing.Size(195, 41);
            this.lblSite.TabIndex = 3;
            this.lblSite.Text = "Site";
            this.lblSite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPaymentPurpose
            // 
            this.lblPaymentPurpose.AutoSize = true;
            this.lblPaymentPurpose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaymentPurpose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentPurpose.Location = new System.Drawing.Point(400, 205);
            this.lblPaymentPurpose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymentPurpose.Name = "lblPaymentPurpose";
            this.lblPaymentPurpose.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblPaymentPurpose.Size = new System.Drawing.Size(195, 41);
            this.lblPaymentPurpose.TabIndex = 3;
            this.lblPaymentPurpose.Text = "Payment Purpose";
            this.lblPaymentPurpose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSite
            // 
            this.cmbSite.FormattingEnabled = true;
            this.cmbSite.Location = new System.Drawing.Point(201, 225);
            this.cmbSite.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.cmbSite.Name = "cmbSite";
            this.cmbSite.Size = new System.Drawing.Size(120, 21);
            this.cmbSite.TabIndex = 14;
            this.cmbSite.Text = "--Select--";
            // 
            // txtPaymentPurpose
            // 
            this.txtPaymentPurpose.Location = new System.Drawing.Point(599, 225);
            this.txtPaymentPurpose.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.txtPaymentPurpose.Name = "txtPaymentPurpose";
            this.txtPaymentPurpose.Size = new System.Drawing.Size(120, 20);
            this.txtPaymentPurpose.TabIndex = 19;
            // 
            // calPaymentDueDate
            // 
            this.calPaymentDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calPaymentDueDate.Location = new System.Drawing.Point(599, 143);
            this.calPaymentDueDate.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.calPaymentDueDate.Name = "calPaymentDueDate";
            this.calPaymentDueDate.Size = new System.Drawing.Size(120, 20);
            this.calPaymentDueDate.TabIndex = 22;
            this.calPaymentDueDate.Value = new System.DateTime(2014, 10, 19, 15, 49, 20, 770);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(229, 474);
            this.btnSave.Margin = new System.Windows.Forms.Padding(30, 3, 2, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 30);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnExportToPDF
            // 
            this.btnExportToPDF.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportToPDF.Location = new System.Drawing.Point(428, 474);
            this.btnExportToPDF.Margin = new System.Windows.Forms.Padding(30, 3, 2, 10);
            this.btnExportToPDF.Name = "btnExportToPDF";
            this.btnExportToPDF.Size = new System.Drawing.Size(167, 30);
            this.btnExportToPDF.TabIndex = 32;
            this.btnExportToPDF.Text = "Generate Excel/PDF";
            this.btnExportToPDF.UseVisualStyleBackColor = true;
            // 
            // dgvApproverManagement
            // 
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
            this.Comment});
            this.tblMain.SetColumnSpan(this.dgvApproverManagement, 4);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvApproverManagement.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvApproverManagement.Location = new System.Drawing.Point(30, 372);
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
            this.dgvApproverManagement.Size = new System.Drawing.Size(739, 40);
            this.dgvApproverManagement.TabIndex = 33;
            this.dgvApproverManagement.Visible = false;
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
            this.UserName.ReadOnly = true;
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            // 
            // calInvoiceDate
            // 
            this.calInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calInvoiceDate.Location = new System.Drawing.Point(201, 307);
            this.calInvoiceDate.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.calInvoiceDate.Name = "calInvoiceDate";
            this.calInvoiceDate.Size = new System.Drawing.Size(120, 20);
            this.calInvoiceDate.TabIndex = 21;
            // 
            // AccountPayable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 514);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AccountPayable";
            this.Text = "AccountPayable";
            this.Load += new System.EventHandler(this.AccountPayable_Load);
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApproverManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbProject;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
    }

}