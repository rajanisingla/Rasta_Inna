namespace Rasta
{
    partial class AccountReceivable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountReceivable));
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
            this.btnUrgent = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbSupplierName = new System.Windows.Forms.ComboBox();
            this.cmbSupplierCode = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.calInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.calDueDate = new System.Windows.Forms.DateTimePicker();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvAccountReceivable = new System.Windows.Forms.DataGridView();
            this.InvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARSupplierName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ARSupplierCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ARExtensionType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ARProject = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ARBank = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ARAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARInvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARCurrency = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ARModify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ARDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tblMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountReceivable)).BeginInit();
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
            this.tblMain.Controls.Add(this.lblDueDate, 2, 4);
            this.tblMain.Controls.Add(this.lbl, 0, 0);
            this.tblMain.Controls.Add(this.lblSupplierName, 0, 1);
            this.tblMain.Controls.Add(this.lblType, 0, 2);
            this.tblMain.Controls.Add(this.lblProject, 2, 2);
            this.tblMain.Controls.Add(this.lblBank, 0, 3);
            this.tblMain.Controls.Add(this.lblAmount, 2, 3);
            this.tblMain.Controls.Add(this.lblCurrency, 0, 5);
            this.tblMain.Controls.Add(this.lblInvoiceDate, 0, 4);
            this.tblMain.Controls.Add(this.lblSupplierCode, 2, 1);
            this.tblMain.Controls.Add(this.btnUrgent, 0, 6);
            this.tblMain.Controls.Add(this.btnSave, 1, 6);
            this.tblMain.Controls.Add(this.btnReset, 2, 6);
            this.tblMain.Controls.Add(this.btnCancel, 3, 6);
            this.tblMain.Controls.Add(this.cmbSupplierName, 1, 1);
            this.tblMain.Controls.Add(this.cmbSupplierCode, 3, 1);
            this.tblMain.Controls.Add(this.cmbType, 1, 2);
            this.tblMain.Controls.Add(this.cmbProject, 3, 2);
            this.tblMain.Controls.Add(this.cmbBank, 1, 3);
            this.tblMain.Controls.Add(this.txtAmount, 3, 3);
            this.tblMain.Controls.Add(this.calInvoiceDate, 1, 4);
            this.tblMain.Controls.Add(this.calDueDate, 3, 4);
            this.tblMain.Controls.Add(this.cmbCurrency, 1, 5);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(3, 3);
            this.tblMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 7;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblMain.Size = new System.Drawing.Size(1284, 545);
            this.tblMain.TabIndex = 0;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDueDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(644, 308);
            this.lblDueDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblDueDate.Size = new System.Drawing.Size(317, 77);
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
            this.lbl.Size = new System.Drawing.Size(1280, 77);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Account Receivable";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSupplierName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierName.Location = new System.Drawing.Point(2, 77);
            this.lblSupplierName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblSupplierName.Size = new System.Drawing.Size(317, 77);
            this.lblSupplierName.TabIndex = 1;
            this.lblSupplierName.Text = "Supplier  Name";
            this.lblSupplierName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(2, 154);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblType.Size = new System.Drawing.Size(317, 77);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblType.Click += new System.EventHandler(this.lblType_Click);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(644, 154);
            this.lblProject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProject.Name = "lblProject";
            this.lblProject.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblProject.Size = new System.Drawing.Size(317, 77);
            this.lblProject.TabIndex = 3;
            this.lblProject.Text = "Project";
            this.lblProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBank.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBank.Location = new System.Drawing.Point(2, 231);
            this.lblBank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBank.Name = "lblBank";
            this.lblBank.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblBank.Size = new System.Drawing.Size(317, 77);
            this.lblBank.TabIndex = 4;
            this.lblBank.Text = "Bank";
            this.lblBank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(644, 231);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblAmount.Size = new System.Drawing.Size(317, 77);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Amount";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrency.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.Location = new System.Drawing.Point(2, 385);
            this.lblCurrency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblCurrency.Size = new System.Drawing.Size(317, 77);
            this.lblCurrency.TabIndex = 6;
            this.lblCurrency.Text = "Currency";
            this.lblCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInvoiceDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceDate.Location = new System.Drawing.Point(2, 308);
            this.lblInvoiceDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblInvoiceDate.Size = new System.Drawing.Size(317, 77);
            this.lblInvoiceDate.TabIndex = 7;
            this.lblInvoiceDate.Text = "Invoice Date";
            this.lblInvoiceDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSupplierCode
            // 
            this.lblSupplierCode.AutoSize = true;
            this.lblSupplierCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSupplierCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierCode.Location = new System.Drawing.Point(644, 77);
            this.lblSupplierCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierCode.Name = "lblSupplierCode";
            this.lblSupplierCode.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblSupplierCode.Size = new System.Drawing.Size(317, 77);
            this.lblSupplierCode.TabIndex = 9;
            this.lblSupplierCode.Text = "Supplier Code";
            this.lblSupplierCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSupplierCode.Click += new System.EventHandler(this.lblSupplierCode_Click);
            // 
            // btnUrgent
            // 
            this.btnUrgent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrgent.Location = new System.Drawing.Point(30, 472);
            this.btnUrgent.Margin = new System.Windows.Forms.Padding(30, 10, 2, 3);
            this.btnUrgent.Name = "btnUrgent";
            this.btnUrgent.Size = new System.Drawing.Size(78, 32);
            this.btnUrgent.TabIndex = 10;
            this.btnUrgent.Text = "Urgent";
            this.btnUrgent.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(351, 472);
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
            this.btnReset.Location = new System.Drawing.Point(672, 472);
            this.btnReset.Margin = new System.Windows.Forms.Padding(30, 10, 2, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 32);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(993, 472);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(30, 10, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 32);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            // 
            // cmbSupplierName
            // 
            this.cmbSupplierName.FormattingEnabled = true;
            this.cmbSupplierName.Location = new System.Drawing.Point(323, 97);
            this.cmbSupplierName.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.cmbSupplierName.Name = "cmbSupplierName";
            this.cmbSupplierName.Size = new System.Drawing.Size(120, 21);
            this.cmbSupplierName.TabIndex = 14;
            this.cmbSupplierName.SelectedIndexChanged += new System.EventHandler(this.cmbSupplierName_SelectedIndexChanged);
            // 
            // cmbSupplierCode
            // 
            this.cmbSupplierCode.FormattingEnabled = true;
            this.cmbSupplierCode.Location = new System.Drawing.Point(965, 97);
            this.cmbSupplierCode.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.cmbSupplierCode.Name = "cmbSupplierCode";
            this.cmbSupplierCode.Size = new System.Drawing.Size(120, 21);
            this.cmbSupplierCode.TabIndex = 15;
            this.cmbSupplierCode.SelectedIndexChanged += new System.EventHandler(this.cmbSupplierCode_SelectedIndexChanged);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "--Select--"});
            this.cmbType.Location = new System.Drawing.Point(323, 174);
            this.cmbType.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(120, 21);
            this.cmbType.TabIndex = 16;
            // 
            // cmbProject
            // 
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Items.AddRange(new object[] {
            "--Select--"});
            this.cmbProject.Location = new System.Drawing.Point(965, 174);
            this.cmbProject.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(120, 21);
            this.cmbProject.TabIndex = 17;
            // 
            // cmbBank
            // 
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Items.AddRange(new object[] {
            "--Select--"});
            this.cmbBank.Location = new System.Drawing.Point(323, 251);
            this.cmbBank.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(120, 21);
            this.cmbBank.TabIndex = 18;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(965, 251);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(120, 20);
            this.txtAmount.TabIndex = 19;
            // 
            // calInvoiceDate
            // 
            this.calInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calInvoiceDate.Location = new System.Drawing.Point(323, 328);
            this.calInvoiceDate.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.calInvoiceDate.Name = "calInvoiceDate";
            this.calInvoiceDate.Size = new System.Drawing.Size(120, 20);
            this.calInvoiceDate.TabIndex = 21;
            this.calInvoiceDate.ValueChanged += new System.EventHandler(this.calInvoiceDate_ValueChanged);
            // 
            // calDueDate
            // 
            this.calDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calDueDate.Location = new System.Drawing.Point(965, 328);
            this.calDueDate.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.calDueDate.Name = "calDueDate";
            this.calDueDate.Size = new System.Drawing.Size(120, 20);
            this.calDueDate.TabIndex = 22;
            this.calDueDate.Value = new System.DateTime(2014, 10, 19, 13, 46, 4, 544);
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Items.AddRange(new object[] {
            "--Select--"});
            this.cmbCurrency.Location = new System.Drawing.Point(323, 405);
            this.cmbCurrency.Margin = new System.Windows.Forms.Padding(2, 20, 2, 3);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(120, 21);
            this.cmbCurrency.TabIndex = 23;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1298, 577);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tblMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1290, 551);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Invoice";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvAccountReceivable);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1290, 551);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Edit Invoice";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvAccountReceivable
            // 
            this.dgvAccountReceivable.AllowUserToAddRows = false;
            this.dgvAccountReceivable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccountReceivable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAccountReceivable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountReceivable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceID,
            this.ARSupplierName,
            this.ARSupplierCode,
            this.ARExtensionType,
            this.ARProject,
            this.ARBank,
            this.ARAmount,
            this.ARInvoiceDate,
            this.ARDueDate,
            this.ARCurrency,
            this.ARModify,
            this.ARDelete});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccountReceivable.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAccountReceivable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccountReceivable.Location = new System.Drawing.Point(3, 3);
            this.dgvAccountReceivable.Name = "dgvAccountReceivable";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccountReceivable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAccountReceivable.Size = new System.Drawing.Size(1284, 545);
            this.dgvAccountReceivable.TabIndex = 0;
            // 
            // InvoiceID
            // 
            this.InvoiceID.HeaderText = "InvoiceID";
            this.InvoiceID.Name = "InvoiceID";
            // 
            // ARSupplierName
            // 
            this.ARSupplierName.HeaderText = "SupplierName";
            this.ARSupplierName.Name = "ARSupplierName";
            this.ARSupplierName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ARSupplierName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ARSupplierCode
            // 
            this.ARSupplierCode.HeaderText = "SupplierCode";
            this.ARSupplierCode.Name = "ARSupplierCode";
            this.ARSupplierCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ARSupplierCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ARExtensionType
            // 
            this.ARExtensionType.HeaderText = "ExtensionType";
            this.ARExtensionType.Name = "ARExtensionType";
            this.ARExtensionType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ARExtensionType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ARProject
            // 
            this.ARProject.HeaderText = "Project";
            this.ARProject.Name = "ARProject";
            this.ARProject.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ARProject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ARBank
            // 
            this.ARBank.HeaderText = "Bank";
            this.ARBank.Name = "ARBank";
            this.ARBank.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ARBank.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ARAmount
            // 
            this.ARAmount.HeaderText = "ARAmount";
            this.ARAmount.Name = "ARAmount";
            // 
            // ARInvoiceDate
            // 
            this.ARInvoiceDate.HeaderText = "Invoice Date";
            this.ARInvoiceDate.Name = "ARInvoiceDate";
            // 
            // ARDueDate
            // 
            this.ARDueDate.HeaderText = "DueDate";
            this.ARDueDate.Name = "ARDueDate";
            // 
            // ARCurrency
            // 
            this.ARCurrency.HeaderText = "Currency";
            this.ARCurrency.Name = "ARCurrency";
            this.ARCurrency.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ARCurrency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ARModify
            // 
            this.ARModify.HeaderText = "Modify";
            this.ARModify.Name = "ARModify";
            // 
            // ARDelete
            // 
            this.ARDelete.HeaderText = "Delete";
            this.ARDelete.Name = "ARDelete";
            // 
            // AccountReceivable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 582);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountReceivable";
            this.Text = "AccountReceivable";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AccountReceivable_Load);
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountReceivable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblSupplierCode;
        private System.Windows.Forms.Button btnUrgent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbSupplierName;
        private System.Windows.Forms.ComboBox cmbSupplierCode;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DateTimePicker calInvoiceDate;
        private System.Windows.Forms.DateTimePicker calDueDate;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvAccountReceivable;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceID;
        private System.Windows.Forms.DataGridViewComboBoxColumn ARSupplierName;
        private System.Windows.Forms.DataGridViewComboBoxColumn ARSupplierCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn ARExtensionType;
        private System.Windows.Forms.DataGridViewComboBoxColumn ARProject;
        private System.Windows.Forms.DataGridViewComboBoxColumn ARBank;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARInvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARDueDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn ARCurrency;
        private System.Windows.Forms.DataGridViewButtonColumn ARModify;
        private System.Windows.Forms.DataGridViewButtonColumn ARDelete;

    }
}

