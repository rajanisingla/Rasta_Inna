namespace Rasta
{
    partial class Forecast
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
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblBank = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblSupplierCode = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.calInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbSupplierName = new System.Windows.Forms.ComboBox();
            this.calDueDate = new System.Windows.Forms.DateTimePicker();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.cmbSupplierCode = new System.Windows.Forms.ComboBox();
            this.lblInvoiceID = new System.Windows.Forms.Label();
            this.lblCreditToBank = new System.Windows.Forms.Label();
            this.chkCreditToBank = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRecievedDate = new System.Windows.Forms.Label();
            this.cmbExpenseSupplierCode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExpenseAmount = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPONumber = new System.Windows.Forms.Label();
            this.lblPOAmount = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtPONumber = new System.Windows.Forms.TextBox();
            this.txtPOAmount = new System.Windows.Forms.TextBox();
            this.lnkNewSupplier = new System.Windows.Forms.LinkLabel();
            this.calDate = new System.Windows.Forms.DateTimePicker();
            this.calRecievedDate = new System.Windows.Forms.DateTimePicker();
            this.cmbCostCode = new System.Windows.Forms.ComboBox();
            this.cmbExpense = new System.Windows.Forms.ComboBox();
            this.lblPaymentDueDate = new System.Windows.Forms.Label();
            this.lblSite = new System.Windows.Forms.Label();
            this.lblPaymentPurpose = new System.Windows.Forms.Label();
            this.cmbSite = new System.Windows.Forms.ComboBox();
            this.txtPaymentPurpose = new System.Windows.Forms.TextBox();
            this.calPaymentDueDate = new System.Windows.Forms.DateTimePicker();
            this.calExpenseInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.cmbExpenseSuppliername = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.combobox1 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.lblAPID = new System.Windows.Forms.Label();
            this.btnExpenseSave = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tblMain.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1274, 665);
            this.tabControl1.TabIndex = 2;
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
            this.tabPage1.Text = "Revenue Forecast";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tblMain
            // 
            this.tblMain.AutoSize = true;
            this.tblMain.ColumnCount = 4;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.Controls.Add(this.lblDueDate, 2, 5);
            this.tblMain.Controls.Add(this.lbl, 0, 0);
            this.tblMain.Controls.Add(this.lblSupplierName, 0, 2);
            this.tblMain.Controls.Add(this.lblType, 0, 3);
            this.tblMain.Controls.Add(this.lblProject, 2, 3);
            this.tblMain.Controls.Add(this.lblBank, 0, 4);
            this.tblMain.Controls.Add(this.lblAmount, 2, 4);
            this.tblMain.Controls.Add(this.lblCurrency, 0, 6);
            this.tblMain.Controls.Add(this.lblInvoiceDate, 0, 5);
            this.tblMain.Controls.Add(this.lblSupplierCode, 2, 2);
            this.tblMain.Controls.Add(this.btnSave, 1, 7);
            this.tblMain.Controls.Add(this.btnReset, 2, 7);
            this.tblMain.Controls.Add(this.btnCancel, 3, 7);
            this.tblMain.Controls.Add(this.cmbCurrency, 1, 6);
            this.tblMain.Controls.Add(this.calInvoiceDate, 1, 5);
            this.tblMain.Controls.Add(this.cmbBank, 1, 4);
            this.tblMain.Controls.Add(this.cmbType, 1, 3);
            this.tblMain.Controls.Add(this.cmbSupplierName, 1, 2);
            this.tblMain.Controls.Add(this.calDueDate, 3, 5);
            this.tblMain.Controls.Add(this.txtAmount, 3, 4);
            this.tblMain.Controls.Add(this.cmbProject, 3, 3);
            this.tblMain.Controls.Add(this.cmbSupplierCode, 3, 2);
            this.tblMain.Controls.Add(this.lblInvoiceID, 2, 1);
            this.tblMain.Controls.Add(this.lblCreditToBank, 2, 6);
            this.tblMain.Controls.Add(this.chkCreditToBank, 3, 6);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(3, 3);
            this.tblMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 8;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.5F));
            this.tblMain.Size = new System.Drawing.Size(1260, 633);
            this.tblMain.TabIndex = 0;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDueDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(632, 373);
            this.lblDueDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblDueDate.Size = new System.Drawing.Size(311, 79);
            this.lblDueDate.TabIndex = 8;
            this.lblDueDate.Text = "Due Date";
            this.lblDueDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lbl.Size = new System.Drawing.Size(1256, 79);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Revenue Forecast";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSupplierName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierName.Location = new System.Drawing.Point(2, 136);
            this.lblSupplierName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblSupplierName.Size = new System.Drawing.Size(311, 79);
            this.lblSupplierName.TabIndex = 1;
            this.lblSupplierName.Text = "Supplier  Name";
            this.lblSupplierName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(2, 215);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblType.Size = new System.Drawing.Size(311, 79);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(632, 215);
            this.lblProject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProject.Name = "lblProject";
            this.lblProject.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblProject.Size = new System.Drawing.Size(311, 79);
            this.lblProject.TabIndex = 3;
            this.lblProject.Text = "Project";
            this.lblProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBank.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBank.Location = new System.Drawing.Point(2, 294);
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
            this.lblAmount.Location = new System.Drawing.Point(632, 294);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblAmount.Size = new System.Drawing.Size(311, 79);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Amount";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrency.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.Location = new System.Drawing.Point(2, 452);
            this.lblCurrency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblCurrency.Size = new System.Drawing.Size(311, 79);
            this.lblCurrency.TabIndex = 6;
            this.lblCurrency.Text = "Currency";
            this.lblCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInvoiceDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceDate.Location = new System.Drawing.Point(2, 373);
            this.lblInvoiceDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblInvoiceDate.Size = new System.Drawing.Size(311, 79);
            this.lblInvoiceDate.TabIndex = 7;
            this.lblInvoiceDate.Text = "Invoice Date";
            this.lblInvoiceDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSupplierCode
            // 
            this.lblSupplierCode.AutoSize = true;
            this.lblSupplierCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSupplierCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierCode.Location = new System.Drawing.Point(632, 136);
            this.lblSupplierCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierCode.Name = "lblSupplierCode";
            this.lblSupplierCode.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblSupplierCode.Size = new System.Drawing.Size(311, 79);
            this.lblSupplierCode.TabIndex = 9;
            this.lblSupplierCode.Text = "Supplier Code";
            this.lblSupplierCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(345, 541);
            this.btnSave.Margin = new System.Windows.Forms.Padding(30, 10, 2, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 32);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(660, 541);
            this.btnReset.Margin = new System.Windows.Forms.Padding(30, 10, 2, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 32);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(975, 541);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(30, 10, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 32);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Items.AddRange(new object[] {
            "--Select--"});
            this.cmbCurrency.Location = new System.Drawing.Point(317, 472);
            this.cmbCurrency.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(120, 21);
            this.cmbCurrency.TabIndex = 23;
            // 
            // calInvoiceDate
            // 
            this.calInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calInvoiceDate.Location = new System.Drawing.Point(317, 393);
            this.calInvoiceDate.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.calInvoiceDate.Name = "calInvoiceDate";
            this.calInvoiceDate.Size = new System.Drawing.Size(120, 20);
            this.calInvoiceDate.TabIndex = 21;
            this.calInvoiceDate.ValueChanged += new System.EventHandler(this.calInvoiceDate_ValueChanged);
            // 
            // cmbBank
            // 
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Items.AddRange(new object[] {
            "--Select--"});
            this.cmbBank.Location = new System.Drawing.Point(317, 314);
            this.cmbBank.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(120, 21);
            this.cmbBank.TabIndex = 18;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "--Select--"});
            this.cmbType.Location = new System.Drawing.Point(317, 235);
            this.cmbType.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(120, 21);
            this.cmbType.TabIndex = 16;
            // 
            // cmbSupplierName
            // 
            this.cmbSupplierName.FormattingEnabled = true;
            this.cmbSupplierName.Location = new System.Drawing.Point(317, 156);
            this.cmbSupplierName.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.cmbSupplierName.Name = "cmbSupplierName";
            this.cmbSupplierName.Size = new System.Drawing.Size(120, 21);
            this.cmbSupplierName.TabIndex = 14;
            this.cmbSupplierName.SelectedIndexChanged += new System.EventHandler(this.cmbSupplierName_SelectedIndexChanged);
            // 
            // calDueDate
            // 
            this.calDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calDueDate.Location = new System.Drawing.Point(947, 393);
            this.calDueDate.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.calDueDate.Name = "calDueDate";
            this.calDueDate.Size = new System.Drawing.Size(120, 20);
            this.calDueDate.TabIndex = 22;
            this.calDueDate.Value = new System.DateTime(2014, 10, 19, 13, 46, 4, 544);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(947, 314);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(120, 20);
            this.txtAmount.TabIndex = 19;
            // 
            // cmbProject
            // 
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Items.AddRange(new object[] {
            "--Select--"});
            this.cmbProject.Location = new System.Drawing.Point(947, 235);
            this.cmbProject.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(120, 21);
            this.cmbProject.TabIndex = 17;
            // 
            // cmbSupplierCode
            // 
            this.cmbSupplierCode.FormattingEnabled = true;
            this.cmbSupplierCode.Location = new System.Drawing.Point(947, 156);
            this.cmbSupplierCode.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.cmbSupplierCode.Name = "cmbSupplierCode";
            this.cmbSupplierCode.Size = new System.Drawing.Size(120, 21);
            this.cmbSupplierCode.TabIndex = 15;
            this.cmbSupplierCode.SelectedIndexChanged += new System.EventHandler(this.cmbSupplierCode_SelectedIndexChanged);
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
            // lblCreditToBank
            // 
            this.lblCreditToBank.AutoSize = true;
            this.lblCreditToBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCreditToBank.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditToBank.Location = new System.Drawing.Point(632, 452);
            this.lblCreditToBank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreditToBank.Name = "lblCreditToBank";
            this.lblCreditToBank.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblCreditToBank.Size = new System.Drawing.Size(311, 79);
            this.lblCreditToBank.TabIndex = 26;
            this.lblCreditToBank.Text = "Credit to Bank";
            this.lblCreditToBank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkCreditToBank
            // 
            this.chkCreditToBank.AutoSize = true;
            this.chkCreditToBank.Location = new System.Drawing.Point(947, 452);
            this.chkCreditToBank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chkCreditToBank.Name = "chkCreditToBank";
            this.chkCreditToBank.Padding = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.chkCreditToBank.Size = new System.Drawing.Size(45, 44);
            this.chkCreditToBank.TabIndex = 27;
            this.chkCreditToBank.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1266, 639);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Expense Forecast";
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
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblRecievedDate, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.cmbExpenseSupplierCode, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtExpenseAmount, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBox2, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblPONumber, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblPOAmount, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblDate, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtPONumber, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtPOAmount, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.lnkNewSupplier, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.calDate, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.calRecievedDate, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.cmbCostCode, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.cmbExpense, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblPaymentDueDate, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblSite, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblPaymentPurpose, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbSite, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtPaymentPurpose, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.calPaymentDueDate, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.calExpenseInvoiceDate, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.cmbExpenseSuppliername, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.combobox1, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.comboBox7, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblAPID, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnExpenseSave, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.comboBox3, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 12);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.817467F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.817467F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.817467F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.817467F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.817467F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.817467F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.817467F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.817467F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.817467F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.817467F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.820137F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.254815F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1260, 633);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 4);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1256, 49);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(311, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "SupplierName";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(632, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(311, 49);
            this.label3.TabIndex = 9;
            this.label3.Text = "SupplierCode";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 343);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(311, 49);
            this.label4.TabIndex = 7;
            this.label4.Text = "InvoiceDate";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRecievedDate
            // 
            this.lblRecievedDate.AutoSize = true;
            this.lblRecievedDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecievedDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecievedDate.Location = new System.Drawing.Point(632, 343);
            this.lblRecievedDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecievedDate.Name = "lblRecievedDate";
            this.lblRecievedDate.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblRecievedDate.Size = new System.Drawing.Size(311, 49);
            this.lblRecievedDate.TabIndex = 8;
            this.lblRecievedDate.Text = "Recieved Date";
            this.lblRecievedDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbExpenseSupplierCode
            // 
            this.cmbExpenseSupplierCode.FormattingEnabled = true;
            this.cmbExpenseSupplierCode.Items.AddRange(new object[] {
            "Sp0001",
            "Sp0002",
            "Sp0003",
            "Sp0004",
            "Sp0005"});
            this.cmbExpenseSupplierCode.Location = new System.Drawing.Point(947, 103);
            this.cmbExpenseSupplierCode.Margin = new System.Windows.Forms.Padding(2, 5, 2, 3);
            this.cmbExpenseSupplierCode.Name = "cmbExpenseSupplierCode";
            this.cmbExpenseSupplierCode.Size = new System.Drawing.Size(120, 21);
            this.cmbExpenseSupplierCode.TabIndex = 15;
            this.cmbExpenseSupplierCode.Text = "--Select--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(311, 49);
            this.label5.TabIndex = 5;
            this.label5.Text = "Amount";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(632, 196);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(311, 49);
            this.label6.TabIndex = 6;
            this.label6.Text = "Currency";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtExpenseAmount
            // 
            this.txtExpenseAmount.Location = new System.Drawing.Point(317, 201);
            this.txtExpenseAmount.Margin = new System.Windows.Forms.Padding(2, 5, 2, 3);
            this.txtExpenseAmount.Name = "txtExpenseAmount";
            this.txtExpenseAmount.Size = new System.Drawing.Size(120, 20);
            this.txtExpenseAmount.TabIndex = 19;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "AOA",
            "USD",
            "EUR"});
            this.comboBox2.Location = new System.Drawing.Point(947, 201);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 5, 2, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(120, 21);
            this.comboBox2.TabIndex = 23;
            this.comboBox2.Text = "--Select--";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 392);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(311, 49);
            this.label7.TabIndex = 2;
            this.label7.Text = "CostCode";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(632, 392);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(311, 49);
            this.label8.TabIndex = 3;
            this.label8.Text = "label8";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Visible = false;
            // 
            // lblPONumber
            // 
            this.lblPONumber.AutoSize = true;
            this.lblPONumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPONumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPONumber.Location = new System.Drawing.Point(2, 294);
            this.lblPONumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPONumber.Name = "lblPONumber";
            this.lblPONumber.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblPONumber.Size = new System.Drawing.Size(311, 49);
            this.lblPONumber.TabIndex = 3;
            this.lblPONumber.Text = "PO Number";
            this.lblPONumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPOAmount
            // 
            this.lblPOAmount.AutoSize = true;
            this.lblPOAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPOAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOAmount.Location = new System.Drawing.Point(632, 294);
            this.lblPOAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPOAmount.Name = "lblPOAmount";
            this.lblPOAmount.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblPOAmount.Size = new System.Drawing.Size(311, 49);
            this.lblPOAmount.TabIndex = 3;
            this.lblPOAmount.Text = "PO Amount";
            this.lblPOAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(2, 147);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblDate.Size = new System.Drawing.Size(311, 49);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPONumber
            // 
            this.txtPONumber.Location = new System.Drawing.Point(317, 299);
            this.txtPONumber.Margin = new System.Windows.Forms.Padding(2, 5, 2, 3);
            this.txtPONumber.Name = "txtPONumber";
            this.txtPONumber.Size = new System.Drawing.Size(120, 20);
            this.txtPONumber.TabIndex = 19;
            // 
            // txtPOAmount
            // 
            this.txtPOAmount.Location = new System.Drawing.Point(947, 299);
            this.txtPOAmount.Margin = new System.Windows.Forms.Padding(2, 5, 2, 3);
            this.txtPOAmount.Name = "txtPOAmount";
            this.txtPOAmount.Size = new System.Drawing.Size(120, 20);
            this.txtPOAmount.TabIndex = 28;
            // 
            // lnkNewSupplier
            // 
            this.lnkNewSupplier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lnkNewSupplier.AutoSize = true;
            this.lnkNewSupplier.Location = new System.Drawing.Point(30, 77);
            this.lnkNewSupplier.Margin = new System.Windows.Forms.Padding(30, 20, 3, 0);
            this.lnkNewSupplier.Name = "lnkNewSupplier";
            this.lnkNewSupplier.Size = new System.Drawing.Size(90, 13);
            this.lnkNewSupplier.TabIndex = 30;
            this.lnkNewSupplier.TabStop = true;
            this.lnkNewSupplier.Text = "Add New supplier";
            this.lnkNewSupplier.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNewSupplier_LinkClicked);
            // 
            // calDate
            // 
            this.calDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calDate.Location = new System.Drawing.Point(317, 152);
            this.calDate.Margin = new System.Windows.Forms.Padding(2, 5, 2, 3);
            this.calDate.Name = "calDate";
            this.calDate.Size = new System.Drawing.Size(120, 20);
            this.calDate.TabIndex = 29;
            // 
            // calRecievedDate
            // 
            this.calRecievedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calRecievedDate.Location = new System.Drawing.Point(947, 348);
            this.calRecievedDate.Margin = new System.Windows.Forms.Padding(2, 5, 2, 3);
            this.calRecievedDate.Name = "calRecievedDate";
            this.calRecievedDate.Size = new System.Drawing.Size(120, 20);
            this.calRecievedDate.TabIndex = 22;
            // 
            // cmbCostCode
            // 
            this.cmbCostCode.FormattingEnabled = true;
            this.cmbCostCode.Location = new System.Drawing.Point(317, 397);
            this.cmbCostCode.Margin = new System.Windows.Forms.Padding(2, 5, 2, 3);
            this.cmbCostCode.Name = "cmbCostCode";
            this.cmbCostCode.Size = new System.Drawing.Size(120, 21);
            this.cmbCostCode.TabIndex = 16;
            this.cmbCostCode.Text = "--Select--";
            this.cmbCostCode.SelectedIndexChanged += new System.EventHandler(this.cmbCostCode_SelectedIndexChanged);
            // 
            // cmbExpense
            // 
            this.cmbExpense.FormattingEnabled = true;
            this.cmbExpense.Location = new System.Drawing.Point(947, 397);
            this.cmbExpense.Margin = new System.Windows.Forms.Padding(2, 5, 2, 3);
            this.cmbExpense.Name = "cmbExpense";
            this.cmbExpense.Size = new System.Drawing.Size(120, 21);
            this.cmbExpense.TabIndex = 17;
            this.cmbExpense.Visible = false;
            this.cmbExpense.SelectedIndexChanged += new System.EventHandler(this.cmbExpense_SelectedIndexChanged);
            // 
            // lblPaymentDueDate
            // 
            this.lblPaymentDueDate.AutoSize = true;
            this.lblPaymentDueDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaymentDueDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDueDate.Location = new System.Drawing.Point(632, 147);
            this.lblPaymentDueDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymentDueDate.Name = "lblPaymentDueDate";
            this.lblPaymentDueDate.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblPaymentDueDate.Size = new System.Drawing.Size(311, 49);
            this.lblPaymentDueDate.TabIndex = 3;
            this.lblPaymentDueDate.Text = "Payment Due Date";
            this.lblPaymentDueDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSite.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSite.Location = new System.Drawing.Point(2, 245);
            this.lblSite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSite.Name = "lblSite";
            this.lblSite.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblSite.Size = new System.Drawing.Size(311, 49);
            this.lblSite.TabIndex = 3;
            this.lblSite.Text = "Site";
            this.lblSite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPaymentPurpose
            // 
            this.lblPaymentPurpose.AutoSize = true;
            this.lblPaymentPurpose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaymentPurpose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentPurpose.Location = new System.Drawing.Point(632, 245);
            this.lblPaymentPurpose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymentPurpose.Name = "lblPaymentPurpose";
            this.lblPaymentPurpose.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblPaymentPurpose.Size = new System.Drawing.Size(311, 49);
            this.lblPaymentPurpose.TabIndex = 3;
            this.lblPaymentPurpose.Text = "Payment Purpose";
            this.lblPaymentPurpose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSite
            // 
            this.cmbSite.FormattingEnabled = true;
            this.cmbSite.Location = new System.Drawing.Point(317, 250);
            this.cmbSite.Margin = new System.Windows.Forms.Padding(2, 5, 2, 3);
            this.cmbSite.Name = "cmbSite";
            this.cmbSite.Size = new System.Drawing.Size(120, 21);
            this.cmbSite.TabIndex = 14;
            this.cmbSite.Text = "--Select--";
            // 
            // txtPaymentPurpose
            // 
            this.txtPaymentPurpose.Location = new System.Drawing.Point(947, 250);
            this.txtPaymentPurpose.Margin = new System.Windows.Forms.Padding(2, 5, 2, 3);
            this.txtPaymentPurpose.Name = "txtPaymentPurpose";
            this.txtPaymentPurpose.Size = new System.Drawing.Size(120, 20);
            this.txtPaymentPurpose.TabIndex = 19;
            // 
            // calPaymentDueDate
            // 
            this.calPaymentDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calPaymentDueDate.Location = new System.Drawing.Point(947, 152);
            this.calPaymentDueDate.Margin = new System.Windows.Forms.Padding(2, 5, 2, 3);
            this.calPaymentDueDate.Name = "calPaymentDueDate";
            this.calPaymentDueDate.Size = new System.Drawing.Size(120, 20);
            this.calPaymentDueDate.TabIndex = 22;
            this.calPaymentDueDate.Value = new System.DateTime(2014, 10, 19, 15, 49, 20, 770);
            // 
            // calExpenseInvoiceDate
            // 
            this.calExpenseInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calExpenseInvoiceDate.Location = new System.Drawing.Point(317, 348);
            this.calExpenseInvoiceDate.Margin = new System.Windows.Forms.Padding(2, 5, 2, 3);
            this.calExpenseInvoiceDate.Name = "calExpenseInvoiceDate";
            this.calExpenseInvoiceDate.Size = new System.Drawing.Size(120, 20);
            this.calExpenseInvoiceDate.TabIndex = 21;
            // 
            // cmbExpenseSuppliername
            // 
            this.cmbExpenseSuppliername.FormattingEnabled = true;
            this.cmbExpenseSuppliername.Location = new System.Drawing.Point(317, 103);
            this.cmbExpenseSuppliername.Margin = new System.Windows.Forms.Padding(2, 5, 2, 3);
            this.cmbExpenseSuppliername.Name = "cmbExpenseSuppliername";
            this.cmbExpenseSuppliername.Size = new System.Drawing.Size(120, 21);
            this.cmbExpenseSuppliername.TabIndex = 14;
            this.cmbExpenseSuppliername.Text = "--Select--";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 441);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label9.Size = new System.Drawing.Size(311, 49);
            this.label9.TabIndex = 34;
            this.label9.Text = "label9";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(632, 441);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(311, 49);
            this.label10.TabIndex = 35;
            this.label10.Text = "label10";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Visible = false;
            // 
            // combobox1
            // 
            this.combobox1.FormattingEnabled = true;
            this.combobox1.Location = new System.Drawing.Point(318, 444);
            this.combobox1.Name = "combobox1";
            this.combobox1.Size = new System.Drawing.Size(121, 21);
            this.combobox1.TabIndex = 36;
            this.combobox1.Visible = false;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(948, 444);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 21);
            this.comboBox7.TabIndex = 37;
            this.comboBox7.Visible = false;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // lblAPID
            // 
            this.lblAPID.AutoSize = true;
            this.lblAPID.Location = new System.Drawing.Point(948, 49);
            this.lblAPID.Name = "lblAPID";
            this.lblAPID.Size = new System.Drawing.Size(0, 13);
            this.lblAPID.TabIndex = 39;
            this.lblAPID.Visible = false;
            // 
            // btnExpenseSave
            // 
            this.btnExpenseSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenseSave.Location = new System.Drawing.Point(345, 587);
            this.btnExpenseSave.Margin = new System.Windows.Forms.Padding(30, 3, 2, 10);
            this.btnExpenseSave.Name = "btnExpenseSave";
            this.btnExpenseSave.Size = new System.Drawing.Size(78, 30);
            this.btnExpenseSave.TabIndex = 11;
            this.btnExpenseSave.Text = "Save";
            this.btnExpenseSave.UseVisualStyleBackColor = true;
            this.btnExpenseSave.Click += new System.EventHandler(this.btnExpenseSave_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(2, 490);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label11.Size = new System.Drawing.Size(311, 49);
            this.label11.TabIndex = 40;
            this.label11.Text = "label11";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(318, 493);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(632, 586);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 32);
            this.button1.TabIndex = 42;
            this.button1.Text = "Cancel";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Forecast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 641);
            this.Controls.Add(this.tabControl1);
            this.Name = "Forecast";
            this.Text = "Forecast";
            this.Load += new System.EventHandler(this.Forecast_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label lblSupplierCode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.DateTimePicker calInvoiceDate;
        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbSupplierName;
        private System.Windows.Forms.DateTimePicker calDueDate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.ComboBox cmbSupplierCode;
        private System.Windows.Forms.Label lblInvoiceID;
        private System.Windows.Forms.Label lblCreditToBank;
        private System.Windows.Forms.CheckBox chkCreditToBank;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRecievedDate;
        private System.Windows.Forms.ComboBox cmbExpenseSupplierCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExpenseAmount;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPONumber;
        private System.Windows.Forms.Label lblPOAmount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtPONumber;
        private System.Windows.Forms.TextBox txtPOAmount;
        private System.Windows.Forms.LinkLabel lnkNewSupplier;
        private System.Windows.Forms.DateTimePicker calDate;
        private System.Windows.Forms.DateTimePicker calRecievedDate;
        private System.Windows.Forms.ComboBox cmbCostCode;
        private System.Windows.Forms.ComboBox cmbExpense;
        private System.Windows.Forms.Label lblPaymentDueDate;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.Label lblPaymentPurpose;
        private System.Windows.Forms.ComboBox cmbSite;
        private System.Windows.Forms.TextBox txtPaymentPurpose;
        private System.Windows.Forms.DateTimePicker calPaymentDueDate;
        private System.Windows.Forms.DateTimePicker calExpenseInvoiceDate;
        private System.Windows.Forms.ComboBox cmbExpenseSuppliername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox combobox1;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label lblAPID;
        private System.Windows.Forms.Button btnExpenseSave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;

    }
}