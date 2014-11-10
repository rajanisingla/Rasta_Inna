namespace Rasta
{
    partial class Treasury
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnPay = new System.Windows.Forms.Button();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bank = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPDF = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSite = new System.Windows.Forms.Label();
            this.lblSignature2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblRef = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblBank = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblSignature1 = new System.Windows.Forms.Label();
            this.btnGenerateRefLetter = new System.Windows.Forms.Button();
            this.lblInvoiceID = new System.Windows.Forms.Label();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbSite = new System.Windows.Forms.ComboBox();
            this.cmbSign1 = new System.Windows.Forms.ComboBox();
            this.cmbSign2 = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1274, 665);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.Tabcontrol_SelectedIndexChange);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tblMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1266, 639);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Make Payment";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tblMain
            // 
            this.tblMain.AutoSize = true;
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMain.Controls.Add(this.btnCancel, 2, 1);
            this.tblMain.Controls.Add(this.btnPay, 0, 1);
            this.tblMain.Controls.Add(this.dgvInvoices, 0, 0);
            this.tblMain.Controls.Add(this.btnPDF, 1, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(3, 3);
            this.tblMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.94995F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.05005F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(1260, 633);
            this.tblMain.TabIndex = 1;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(30, 516);
            this.btnPay.Margin = new System.Windows.Forms.Padding(30, 10, 2, 3);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(78, 32);
            this.btnPay.TabIndex = 11;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.SupplierName,
            this.Amount,
            this.Currency,
            this.Bank,
            this.SupplierID,
            this.APID});
            this.tblMain.SetColumnSpan(this.dgvInvoices, 3);
            this.dgvInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoices.Location = new System.Drawing.Point(3, 3);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.Size = new System.Drawing.Size(1254, 500);
            this.dgvInvoices.TabIndex = 12;
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            // 
            // SupplierName
            // 
            this.SupplierName.HeaderText = "SupplierName";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
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
            // Bank
            // 
            this.Bank.HeaderText = "Bank";
            this.Bank.Name = "Bank";
            // 
            // SupplierID
            // 
            this.SupplierID.HeaderText = "SupplierID";
            this.SupplierID.Name = "SupplierID";
            this.SupplierID.ReadOnly = true;
            this.SupplierID.Visible = false;
            // 
            // APID
            // 
            this.APID.HeaderText = "APID";
            this.APID.Name = "APID";
            this.APID.ReadOnly = true;
            this.APID.Visible = false;
            // 
            // btnPDF
            // 
            this.btnPDF.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.Location = new System.Drawing.Point(422, 516);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(3, 10, 10, 3);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(152, 32);
            this.btnPDF.TabIndex = 13;
            this.btnPDF.TabStop = false;
            this.btnPDF.Text = "Generate PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1266, 639);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Generate Reference Letter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblSite, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSignature2, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblRef, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblID, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblBank, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblAmount, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblSignature1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnGenerateRefLetter, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblInvoiceID, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbBank, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtAmount, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtRef, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbSite, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbSign1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbSign2, 3, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1260, 633);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSite.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSite.Location = new System.Drawing.Point(2, 294);
            this.lblSite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSite.Name = "lblSite";
            this.lblSite.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblSite.Size = new System.Drawing.Size(311, 79);
            this.lblSite.TabIndex = 28;
            this.lblSite.Text = "S‪ite";
            this.lblSite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSignature2
            // 
            this.lblSignature2.AutoSize = true;
            this.lblSignature2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSignature2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignature2.Location = new System.Drawing.Point(632, 373);
            this.lblSignature2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSignature2.Name = "lblSignature2";
            this.lblSignature2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblSignature2.Size = new System.Drawing.Size(311, 79);
            this.lblSignature2.TabIndex = 8;
            this.lblSignature2.Text = "Signature2";
            this.lblSignature2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl, 4);
            this.lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(2, 0);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(1256, 79);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Generate Reference Letter";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRef.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRef.Location = new System.Drawing.Point(2, 215);
            this.lblRef.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRef.Name = "lblRef";
            this.lblRef.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblRef.Size = new System.Drawing.Size(311, 79);
            this.lblRef.TabIndex = 2;
            this.lblRef.Text = "Reference Number";
            this.lblRef.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(632, 215);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblID.Size = new System.Drawing.Size(311, 79);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID Number";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBank.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBank.Location = new System.Drawing.Point(2, 136);
            this.lblBank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBank.Name = "lblBank";
            this.lblBank.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblBank.Size = new System.Drawing.Size(311, 79);
            this.lblBank.TabIndex = 4;
            this.lblBank.Text = "Bank";
            this.lblBank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(632, 136);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblAmount.Size = new System.Drawing.Size(311, 79);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Amount";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSignature1
            // 
            this.lblSignature1.AutoSize = true;
            this.lblSignature1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSignature1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignature1.Location = new System.Drawing.Point(2, 373);
            this.lblSignature1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSignature1.Name = "lblSignature1";
            this.lblSignature1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblSignature1.Size = new System.Drawing.Size(311, 79);
            this.lblSignature1.TabIndex = 7;
            this.lblSignature1.Text = "Signature1";
            this.lblSignature1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGenerateRefLetter
            // 
            this.btnGenerateRefLetter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateRefLetter.Location = new System.Drawing.Point(345, 541);
            this.btnGenerateRefLetter.Margin = new System.Windows.Forms.Padding(30, 10, 2, 3);
            this.btnGenerateRefLetter.Name = "btnGenerateRefLetter";
            this.btnGenerateRefLetter.Size = new System.Drawing.Size(156, 32);
            this.btnGenerateRefLetter.TabIndex = 11;
            this.btnGenerateRefLetter.Text = "Generate PDF";
            this.btnGenerateRefLetter.UseVisualStyleBackColor = true;
            this.btnGenerateRefLetter.Click += new System.EventHandler(this.btnGenerateRefLetter_Click);
            // 
            // lblInvoiceID
            // 
            this.lblInvoiceID.AutoSize = true;
            this.lblInvoiceID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceID.Location = new System.Drawing.Point(633, 79);
            this.lblInvoiceID.Name = "lblInvoiceID";
            this.lblInvoiceID.Size = new System.Drawing.Size(0, 19);
            this.lblInvoiceID.TabIndex = 25;
            // 
            // cmbBank
            // 
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Items.AddRange(new object[] {
            "--Select--"});
            this.cmbBank.Location = new System.Drawing.Point(317, 156);
            this.cmbBank.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(120, 21);
            this.cmbBank.TabIndex = 18;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(947, 156);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(120, 20);
            this.txtAmount.TabIndex = 19;
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(317, 235);
            this.txtRef.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(121, 20);
            this.txtRef.TabIndex = 26;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(947, 235);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 20);
            this.txtID.TabIndex = 27;
            // 
            // cmbSite
            // 
            this.cmbSite.FormattingEnabled = true;
            this.cmbSite.Location = new System.Drawing.Point(318, 314);
            this.cmbSite.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.cmbSite.Name = "cmbSite";
            this.cmbSite.Size = new System.Drawing.Size(121, 21);
            this.cmbSite.TabIndex = 31;
            // 
            // cmbSign1
            // 
            this.cmbSign1.FormattingEnabled = true;
            this.cmbSign1.Location = new System.Drawing.Point(318, 393);
            this.cmbSign1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.cmbSign1.Name = "cmbSign1";
            this.cmbSign1.Size = new System.Drawing.Size(121, 21);
            this.cmbSign1.TabIndex = 32;
            // 
            // cmbSign2
            // 
            this.cmbSign2.FormattingEnabled = true;
            this.cmbSign2.Location = new System.Drawing.Point(948, 393);
            this.cmbSign2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.cmbSign2.Name = "cmbSign2";
            this.cmbSign2.Size = new System.Drawing.Size(121, 21);
            this.cmbSign2.TabIndex = 33;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(868, 516);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(30, 10, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 32);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(660, 533);
            this.button1.Margin = new System.Windows.Forms.Padding(30, 2, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 32);
            this.button1.TabIndex = 44;
            this.button1.Text = "Cancel";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Treasury
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 571);
            this.Controls.Add(this.tabControl1);
            this.Name = "Treasury";
            this.Text = "Treasury";
            this.Load += new System.EventHandler(this.Treasury_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Currency;
        private System.Windows.Forms.DataGridViewComboBoxColumn Bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn APID;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.Label lblSignature2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblSignature1;
        private System.Windows.Forms.Button btnGenerateRefLetter;
        private System.Windows.Forms.Label lblInvoiceID;
        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cmbSite;
        private System.Windows.Forms.ComboBox cmbSign1;
        private System.Windows.Forms.ComboBox cmbSign2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button1;
    }
}