namespace Rasta
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpUserMgt = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrivilege = new System.Windows.Forms.Label();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.lstPrivilege = new System.Windows.Forms.ListBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCompanyRole = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrivilegeOld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Privilege = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CompanyRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.tpSupplierMgt = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblSupplierCode = new System.Windows.Forms.Label();
            this.lblSupplierBank = new System.Windows.Forms.Label();
            this.lblSupplierType = new System.Windows.Forms.Label();
            this.lblSupplierAddress = new System.Windows.Forms.Label();
            this.lblSupplierCountry = new System.Windows.Forms.Label();
            this.btnSupplierSave = new System.Windows.Forms.Button();
            this.txtSupplierCode = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.txtSupplierAddress = new System.Windows.Forms.TextBox();
            this.txtSupplerCountry = new System.Windows.Forms.TextBox();
            this.cmbSupplierBank = new System.Windows.Forms.ComboBox();
            this.cmbSupplierType = new System.Windows.Forms.ComboBox();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierBank = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SupplierType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierModify = new System.Windows.Forms.DataGridViewImageColumn();
            this.SupplierDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.tpBankMgt = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvBank = new System.Windows.Forms.DataGridView();
            this.BankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrencyAccepted = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SwiftCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discipline = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifyBank = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteBank = new System.Windows.Forms.DataGridViewImageColumn();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBankName = new System.Windows.Forms.Label();
            this.lblBankCode = new System.Windows.Forms.Label();
            this.lblBankCurrency = new System.Windows.Forms.Label();
            this.lblSwiftCode = new System.Windows.Forms.Label();
            this.lblIBAN = new System.Windows.Forms.Label();
            this.lblBankCountry = new System.Windows.Forms.Label();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.txtBankCode = new System.Windows.Forms.TextBox();
            this.txtSwiftCode = new System.Windows.Forms.TextBox();
            this.txtIBAN = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.cmbCurrencyAccepted = new System.Windows.Forms.ComboBox();
            this.cmbDiscipline = new System.Windows.Forms.ComboBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.btnBankSave = new System.Windows.Forms.Button();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.splitContainer9 = new System.Windows.Forms.SplitContainer();
            this.linkLabel9 = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEditBankName = new System.Windows.Forms.Label();
            this.lblTotalCash = new System.Windows.Forms.Label();
            this.lblNegativeCash = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbEditBankName = new System.Windows.Forms.ComboBox();
            this.txtTotalCash = new System.Windows.Forms.TextBox();
            this.txtNegativeCash = new System.Windows.Forms.TextBox();
            this.txtNegativeCashType = new System.Windows.Forms.TextBox();
            this.btnEditCash = new System.Windows.Forms.Button();
            this.txtTDDuration = new System.Windows.Forms.TextBox();
            this.calTDStartDate = new System.Windows.Forms.DateTimePicker();
            this.tpProjectMgt = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvProject = new System.Windows.Forms.DataGridView();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountTillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectModify = new System.Windows.Forms.DataGridViewImageColumn();
            this.ProjectDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblProjectType = new System.Windows.Forms.Label();
            this.lblAmntTillDate = new System.Windows.Forms.Label();
            this.lblAmntDue = new System.Windows.Forms.Label();
            this.lblTotalAmnt = new System.Windows.Forms.Label();
            this.btnProjectSave = new System.Windows.Forms.Button();
            this.txtAmountTillDate = new System.Windows.Forms.TextBox();
            this.txtAmountDue = new System.Windows.Forms.TextBox();
            this.cmbProjectType = new System.Windows.Forms.ComboBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.tpExpenseTypeMgt = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvExpenseType = new System.Windows.Forms.DataGridView();
            this.ExpenseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpenseTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpenseTypeModify = new System.Windows.Forms.DataGridViewImageColumn();
            this.ExpenseTypeDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExpenseTypeSave = new System.Windows.Forms.Button();
            this.lblExpenseTypeName = new System.Windows.Forms.Label();
            this.txtExpenseType = new System.Windows.Forms.TextBox();
            this.tpSiteMgt = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvSite = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveSite = new System.Windows.Forms.Button();
            this.lblSite = new System.Windows.Forms.Label();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.tpPayementApprovalMgt = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvApprover = new System.Windows.Forms.DataGridView();
            this.department = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.approver = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.disciplineOld = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.locationold = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.approverold = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewButtonColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewButtonColumn6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblLocation1 = new System.Windows.Forms.Label();
            this.lblApprover1 = new System.Windows.Forms.Label();
            this.btnApproverSave = new System.Windows.Forms.Button();
            this.cmbLocation2 = new System.Windows.Forms.ComboBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbApprover = new System.Windows.Forms.ComboBox();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCurrency = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExchangeRateinUSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewButtonColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.lblExchangeRate = new System.Windows.Forms.Label();
            this.txtExchangeRate = new System.Windows.Forms.TextBox();
            this.btnCurrencySave = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tpUserMgt.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tpSupplierMgt.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.tpBankMgt.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).BeginInit();
            this.splitContainer9.Panel1.SuspendLayout();
            this.splitContainer9.Panel2.SuspendLayout();
            this.splitContainer9.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.tpProjectMgt.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tpExpenseTypeMgt.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tpSiteMgt.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tpPayementApprovalMgt.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApprover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.tpSettings.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpUserMgt);
            this.tabControl1.Controls.Add(this.tpSupplierMgt);
            this.tabControl1.Controls.Add(this.tpBankMgt);
            this.tabControl1.Controls.Add(this.tpProjectMgt);
            this.tabControl1.Controls.Add(this.tpExpenseTypeMgt);
            this.tabControl1.Controls.Add(this.tpSiteMgt);
            this.tabControl1.Controls.Add(this.tpPayementApprovalMgt);
            this.tabControl1.Controls.Add(this.tpSettings);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1274, 665);
            this.tabControl1.TabIndex = 0;
            // 
            // tpUserMgt
            // 
            this.tpUserMgt.Controls.Add(this.tableLayoutPanel1);
            this.tpUserMgt.Location = new System.Drawing.Point(4, 22);
            this.tpUserMgt.Name = "tpUserMgt";
            this.tpUserMgt.Padding = new System.Windows.Forms.Padding(3);
            this.tpUserMgt.Size = new System.Drawing.Size(1266, 639);
            this.tpUserMgt.TabIndex = 0;
            this.tpUserMgt.Text = "Users";
            this.tpUserMgt.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(851, 367);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 186);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.linkLabel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel4);
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Size = new System.Drawing.Size(628, 140);
            this.splitContainer1.SplitterDistance = 29;
            this.splitContainer1.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(14, 4);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(76, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add New User";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.lblUserName, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblPassWord, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblPrivilege, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnSaveUser, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.lstPrivilege, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtPassWord, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtCompanyRole, 1, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(17, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(589, 100);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(2, 33);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblUserName.Size = new System.Drawing.Size(143, 33);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Company Role";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassWord.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassWord.Location = new System.Drawing.Point(296, 0);
            this.lblPassWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblPassWord.Size = new System.Drawing.Size(143, 33);
            this.lblPassWord.TabIndex = 1;
            this.lblPassWord.Text = "PassWord";
            this.lblPassWord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(2, 0);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblName.Size = new System.Drawing.Size(143, 33);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrivilege
            // 
            this.lblPrivilege.AutoSize = true;
            this.lblPrivilege.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrivilege.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrivilege.Location = new System.Drawing.Point(296, 33);
            this.lblPrivilege.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrivilege.Name = "lblPrivilege";
            this.lblPrivilege.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblPrivilege.Size = new System.Drawing.Size(143, 33);
            this.lblPrivilege.TabIndex = 0;
            this.lblPrivilege.Text = "Privilege";
            this.lblPrivilege.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Location = new System.Drawing.Point(150, 69);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(75, 23);
            this.btnSaveUser.TabIndex = 4;
            this.btnSaveUser.Text = "Save";
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // lstPrivilege
            // 
            this.lstPrivilege.FormattingEnabled = true;
            this.lstPrivilege.Location = new System.Drawing.Point(444, 36);
            this.lstPrivilege.Name = "lstPrivilege";
            this.lstPrivilege.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstPrivilege.Size = new System.Drawing.Size(100, 17);
            this.lstPrivilege.TabIndex = 8;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(444, 3);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(100, 20);
            this.txtPassWord.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(150, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtCompanyRole
            // 
            this.txtCompanyRole.Location = new System.Drawing.Point(150, 36);
            this.txtCompanyRole.Name = "txtCompanyRole";
            this.txtCompanyRole.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyRole.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.UserName,
            this.PassWord,
            this.PrivilegeOld,
            this.Privilege,
            this.CompanyRole,
            this.Edit,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 110);
            this.dataGridView1.TabIndex = 0;
            // 
            // UserID
            // 
            this.UserID.HeaderText = "UserID";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Name";
            this.UserName.Name = "UserName";
            // 
            // PassWord
            // 
            this.PassWord.HeaderText = "PassWord";
            this.PassWord.Name = "PassWord";
            // 
            // PrivilegeOld
            // 
            this.PrivilegeOld.HeaderText = "PrivilegeOld";
            this.PrivilegeOld.Name = "PrivilegeOld";
            this.PrivilegeOld.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PrivilegeOld.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Privilege
            // 
            this.Privilege.HeaderText = "Privilege";
            this.Privilege.Name = "Privilege";
            // 
            // CompanyRole
            // 
            this.CompanyRole.HeaderText = "Company Role";
            this.CompanyRole.Name = "CompanyRole";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Modify";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tpSupplierMgt
            // 
            this.tpSupplierMgt.Controls.Add(this.tableLayoutPanel2);
            this.tpSupplierMgt.Location = new System.Drawing.Point(4, 22);
            this.tpSupplierMgt.Name = "tpSupplierMgt";
            this.tpSupplierMgt.Padding = new System.Windows.Forms.Padding(3);
            this.tpSupplierMgt.Size = new System.Drawing.Size(1266, 639);
            this.tpSupplierMgt.TabIndex = 1;
            this.tpSupplierMgt.Text = "Suppliers";
            this.tpSupplierMgt.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.splitContainer2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dgvSupplier, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(24, 53);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(851, 320);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 118);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.linkLabel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer2.Panel2Collapsed = true;
            this.splitContainer2.Size = new System.Drawing.Size(845, 199);
            this.splitContainer2.SplitterDistance = 28;
            this.splitContainer2.TabIndex = 0;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(25, 4);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(92, 13);
            this.linkLabel2.TabIndex = 0;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Add New Supplier";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.lblSupplierName, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblSupplierCode, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblSupplierBank, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblSupplierType, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblSupplierAddress, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblSupplierCountry, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnSupplierSave, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtSupplierCode, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtSupplierName, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtSupplierAddress, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtSupplerCountry, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.cmbSupplierBank, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.cmbSupplierType, 3, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(19, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(715, 142);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSupplierName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierName.Location = new System.Drawing.Point(358, 0);
            this.lblSupplierName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblSupplierName.Size = new System.Drawing.Size(174, 35);
            this.lblSupplierName.TabIndex = 0;
            this.lblSupplierName.Text = "Name";
            this.lblSupplierName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSupplierCode
            // 
            this.lblSupplierCode.AutoSize = true;
            this.lblSupplierCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSupplierCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierCode.Location = new System.Drawing.Point(2, 0);
            this.lblSupplierCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierCode.Name = "lblSupplierCode";
            this.lblSupplierCode.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblSupplierCode.Size = new System.Drawing.Size(174, 35);
            this.lblSupplierCode.TabIndex = 1;
            this.lblSupplierCode.Text = "Code";
            this.lblSupplierCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSupplierBank
            // 
            this.lblSupplierBank.AutoSize = true;
            this.lblSupplierBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSupplierBank.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierBank.Location = new System.Drawing.Point(2, 35);
            this.lblSupplierBank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierBank.Name = "lblSupplierBank";
            this.lblSupplierBank.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblSupplierBank.Size = new System.Drawing.Size(174, 35);
            this.lblSupplierBank.TabIndex = 2;
            this.lblSupplierBank.Text = "Bank";
            this.lblSupplierBank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSupplierType
            // 
            this.lblSupplierType.AutoSize = true;
            this.lblSupplierType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSupplierType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierType.Location = new System.Drawing.Point(358, 35);
            this.lblSupplierType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierType.Name = "lblSupplierType";
            this.lblSupplierType.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblSupplierType.Size = new System.Drawing.Size(174, 35);
            this.lblSupplierType.TabIndex = 2;
            this.lblSupplierType.Text = "Type";
            this.lblSupplierType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSupplierAddress
            // 
            this.lblSupplierAddress.AutoSize = true;
            this.lblSupplierAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSupplierAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierAddress.Location = new System.Drawing.Point(2, 70);
            this.lblSupplierAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierAddress.Name = "lblSupplierAddress";
            this.lblSupplierAddress.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblSupplierAddress.Size = new System.Drawing.Size(174, 35);
            this.lblSupplierAddress.TabIndex = 4;
            this.lblSupplierAddress.Text = "Address";
            this.lblSupplierAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSupplierCountry
            // 
            this.lblSupplierCountry.AutoSize = true;
            this.lblSupplierCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSupplierCountry.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierCountry.Location = new System.Drawing.Point(358, 70);
            this.lblSupplierCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierCountry.Name = "lblSupplierCountry";
            this.lblSupplierCountry.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblSupplierCountry.Size = new System.Drawing.Size(174, 35);
            this.lblSupplierCountry.TabIndex = 5;
            this.lblSupplierCountry.Text = "Country";
            this.lblSupplierCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSupplierSave
            // 
            this.btnSupplierSave.Location = new System.Drawing.Point(181, 108);
            this.btnSupplierSave.Name = "btnSupplierSave";
            this.btnSupplierSave.Size = new System.Drawing.Size(75, 23);
            this.btnSupplierSave.TabIndex = 6;
            this.btnSupplierSave.Text = "Save";
            this.btnSupplierSave.UseVisualStyleBackColor = true;
            this.btnSupplierSave.Click += new System.EventHandler(this.btnSupplierSave_Click);
            // 
            // txtSupplierCode
            // 
            this.txtSupplierCode.Location = new System.Drawing.Point(181, 3);
            this.txtSupplierCode.Name = "txtSupplierCode";
            this.txtSupplierCode.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierCode.TabIndex = 7;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(537, 3);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierName.TabIndex = 8;
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.Location = new System.Drawing.Point(181, 73);
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierAddress.TabIndex = 9;
            // 
            // txtSupplerCountry
            // 
            this.txtSupplerCountry.Location = new System.Drawing.Point(537, 73);
            this.txtSupplerCountry.Name = "txtSupplerCountry";
            this.txtSupplerCountry.Size = new System.Drawing.Size(100, 20);
            this.txtSupplerCountry.TabIndex = 10;
            // 
            // cmbSupplierBank
            // 
            this.cmbSupplierBank.FormattingEnabled = true;
            this.cmbSupplierBank.Location = new System.Drawing.Point(181, 38);
            this.cmbSupplierBank.Name = "cmbSupplierBank";
            this.cmbSupplierBank.Size = new System.Drawing.Size(100, 21);
            this.cmbSupplierBank.TabIndex = 11;
            // 
            // cmbSupplierType
            // 
            this.cmbSupplierType.FormattingEnabled = true;
            this.cmbSupplierType.Location = new System.Drawing.Point(537, 38);
            this.cmbSupplierType.Name = "cmbSupplierType";
            this.cmbSupplierType.Size = new System.Drawing.Size(100, 21);
            this.cmbSupplierType.TabIndex = 12;
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.AllowUserToAddRows = false;
            this.dgvSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.SupplierID,
            this.SupplierName,
            this.SupplierBank,
            this.SupplierType,
            this.Address,
            this.SupplierCountry,
            this.SupplierModify,
            this.SupplierDelete});
            this.dgvSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSupplier.Location = new System.Drawing.Point(3, 3);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.Size = new System.Drawing.Size(845, 109);
            this.dgvSupplier.TabIndex = 1;
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            // 
            // SupplierID
            // 
            this.SupplierID.HeaderText = "SupplierID";
            this.SupplierID.Name = "SupplierID";
            // 
            // SupplierName
            // 
            this.SupplierName.HeaderText = "Name";
            this.SupplierName.Name = "SupplierName";
            // 
            // SupplierBank
            // 
            this.SupplierBank.HeaderText = "Bank";
            this.SupplierBank.Name = "SupplierBank";
            this.SupplierBank.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SupplierBank.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SupplierType
            // 
            this.SupplierType.HeaderText = "Type";
            this.SupplierType.Name = "SupplierType";
            this.SupplierType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SupplierType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // SupplierCountry
            // 
            this.SupplierCountry.HeaderText = "Country";
            this.SupplierCountry.Name = "SupplierCountry";
            // 
            // SupplierModify
            // 
            this.SupplierModify.HeaderText = "Modify";
            this.SupplierModify.Image = ((System.Drawing.Image)(resources.GetObject("SupplierModify.Image")));
            this.SupplierModify.Name = "SupplierModify";
            this.SupplierModify.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SupplierDelete
            // 
            this.SupplierDelete.HeaderText = "";
            this.SupplierDelete.Image = ((System.Drawing.Image)(resources.GetObject("SupplierDelete.Image")));
            this.SupplierDelete.Name = "SupplierDelete";
            this.SupplierDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tpBankMgt
            // 
            this.tpBankMgt.Controls.Add(this.tableLayoutPanel5);
            this.tpBankMgt.Location = new System.Drawing.Point(4, 22);
            this.tpBankMgt.Name = "tpBankMgt";
            this.tpBankMgt.Padding = new System.Windows.Forms.Padding(3);
            this.tpBankMgt.Size = new System.Drawing.Size(1266, 639);
            this.tpBankMgt.TabIndex = 0;
            this.tpBankMgt.Text = "Banks";
            this.tpBankMgt.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.dgvBank, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.splitContainer3, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.splitContainer9, 0, 2);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(24, 53);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.42991F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.86916F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.70094F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(851, 535);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // dgvBank
            // 
            this.dgvBank.AllowUserToAddRows = false;
            this.dgvBank.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBank.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BankName,
            this.BankID,
            this.BankCode,
            this.CurrencyAccepted,
            this.SwiftCode,
            this.IBAN,
            this.BankCountry,
            this.Discipline,
            this.AccountNumber,
            this.Cash,
            this.ModifyBank,
            this.DeleteBank});
            this.dgvBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBank.Location = new System.Drawing.Point(3, 3);
            this.dgvBank.Name = "dgvBank";
            this.dgvBank.Size = new System.Drawing.Size(845, 114);
            this.dgvBank.TabIndex = 0;
            // 
            // BankName
            // 
            this.BankName.HeaderText = "BankName";
            this.BankName.Name = "BankName";
            // 
            // BankID
            // 
            this.BankID.HeaderText = "BankID";
            this.BankID.Name = "BankID";
            // 
            // BankCode
            // 
            this.BankCode.HeaderText = "BankCode";
            this.BankCode.Name = "BankCode";
            // 
            // CurrencyAccepted
            // 
            this.CurrencyAccepted.HeaderText = "Currency";
            this.CurrencyAccepted.Name = "CurrencyAccepted";
            this.CurrencyAccepted.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CurrencyAccepted.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SwiftCode
            // 
            this.SwiftCode.HeaderText = "SwiftCode";
            this.SwiftCode.Name = "SwiftCode";
            // 
            // IBAN
            // 
            this.IBAN.HeaderText = "IBAN";
            this.IBAN.Name = "IBAN";
            // 
            // BankCountry
            // 
            this.BankCountry.HeaderText = "Country ";
            this.BankCountry.Name = "BankCountry";
            // 
            // Discipline
            // 
            this.Discipline.HeaderText = "Disciplineid";
            this.Discipline.Name = "Discipline";
            // 
            // AccountNumber
            // 
            this.AccountNumber.HeaderText = "AccountNo";
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AccountNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cash
            // 
            this.Cash.HeaderText = "Cash";
            this.Cash.Name = "Cash";
            // 
            // ModifyBank
            // 
            this.ModifyBank.HeaderText = "Modify";
            this.ModifyBank.Image = ((System.Drawing.Image)(resources.GetObject("ModifyBank.Image")));
            this.ModifyBank.Name = "ModifyBank";
            this.ModifyBank.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DeleteBank
            // 
            this.DeleteBank.HeaderText = "";
            this.DeleteBank.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBank.Image")));
            this.DeleteBank.Name = "DeleteBank";
            this.DeleteBank.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 123);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.linkLabel3);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tableLayoutPanel6);
            this.splitContainer3.Panel2Collapsed = true;
            this.splitContainer3.Size = new System.Drawing.Size(845, 217);
            this.splitContainer3.SplitterDistance = 36;
            this.splitContainer3.TabIndex = 1;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(27, 10);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(79, 13);
            this.linkLabel3.TabIndex = 0;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Add New Bank";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.label2, 2, 3);
            this.tableLayoutPanel6.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.lblBankName, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblBankCode, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblBankCurrency, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblSwiftCode, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblIBAN, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.lblBankCountry, 2, 2);
            this.tableLayoutPanel6.Controls.Add(this.txtBankName, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.txtBankCode, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.txtSwiftCode, 3, 1);
            this.tableLayoutPanel6.Controls.Add(this.txtIBAN, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.txtCountry, 3, 2);
            this.tableLayoutPanel6.Controls.Add(this.cmbCurrencyAccepted, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.cmbDiscipline, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.txtAccountNumber, 3, 3);
            this.tableLayoutPanel6.Controls.Add(this.btnBankSave, 2, 5);
            this.tableLayoutPanel6.Controls.Add(this.txtCash, 1, 4);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 6;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(778, 154);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(190, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Cash";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(390, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Account Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Discipline";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBankName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankName.Location = new System.Drawing.Point(2, 0);
            this.lblBankName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblBankName.Size = new System.Drawing.Size(190, 25);
            this.lblBankName.TabIndex = 0;
            this.lblBankName.Text = "Bank Name";
            this.lblBankName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBankCode
            // 
            this.lblBankCode.AutoSize = true;
            this.lblBankCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBankCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankCode.Location = new System.Drawing.Point(390, 0);
            this.lblBankCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBankCode.Name = "lblBankCode";
            this.lblBankCode.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblBankCode.Size = new System.Drawing.Size(190, 25);
            this.lblBankCode.TabIndex = 1;
            this.lblBankCode.Text = "Bank Code";
            this.lblBankCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBankCurrency
            // 
            this.lblBankCurrency.AutoSize = true;
            this.lblBankCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBankCurrency.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankCurrency.Location = new System.Drawing.Point(2, 25);
            this.lblBankCurrency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBankCurrency.Name = "lblBankCurrency";
            this.lblBankCurrency.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblBankCurrency.Size = new System.Drawing.Size(190, 25);
            this.lblBankCurrency.TabIndex = 2;
            this.lblBankCurrency.Text = "Currency";
            this.lblBankCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSwiftCode
            // 
            this.lblSwiftCode.AutoSize = true;
            this.lblSwiftCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSwiftCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwiftCode.Location = new System.Drawing.Point(390, 25);
            this.lblSwiftCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSwiftCode.Name = "lblSwiftCode";
            this.lblSwiftCode.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblSwiftCode.Size = new System.Drawing.Size(190, 25);
            this.lblSwiftCode.TabIndex = 3;
            this.lblSwiftCode.Text = "Swift Code";
            this.lblSwiftCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIBAN
            // 
            this.lblIBAN.AutoSize = true;
            this.lblIBAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIBAN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIBAN.Location = new System.Drawing.Point(2, 50);
            this.lblIBAN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIBAN.Name = "lblIBAN";
            this.lblIBAN.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblIBAN.Size = new System.Drawing.Size(190, 25);
            this.lblIBAN.TabIndex = 4;
            this.lblIBAN.Text = "IBAN";
            this.lblIBAN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBankCountry
            // 
            this.lblBankCountry.AutoSize = true;
            this.lblBankCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBankCountry.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankCountry.Location = new System.Drawing.Point(390, 50);
            this.lblBankCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBankCountry.Name = "lblBankCountry";
            this.lblBankCountry.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblBankCountry.Size = new System.Drawing.Size(190, 25);
            this.lblBankCountry.TabIndex = 4;
            this.lblBankCountry.Text = "Country";
            this.lblBankCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(197, 3);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(100, 20);
            this.txtBankName.TabIndex = 6;
            // 
            // txtBankCode
            // 
            this.txtBankCode.Location = new System.Drawing.Point(585, 3);
            this.txtBankCode.Name = "txtBankCode";
            this.txtBankCode.Size = new System.Drawing.Size(100, 20);
            this.txtBankCode.TabIndex = 7;
            // 
            // txtSwiftCode
            // 
            this.txtSwiftCode.Location = new System.Drawing.Point(585, 28);
            this.txtSwiftCode.Name = "txtSwiftCode";
            this.txtSwiftCode.Size = new System.Drawing.Size(100, 20);
            this.txtSwiftCode.TabIndex = 9;
            // 
            // txtIBAN
            // 
            this.txtIBAN.Location = new System.Drawing.Point(197, 53);
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(100, 20);
            this.txtIBAN.TabIndex = 10;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(585, 53);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCountry.TabIndex = 11;
            // 
            // cmbCurrencyAccepted
            // 
            this.cmbCurrencyAccepted.FormattingEnabled = true;
            this.cmbCurrencyAccepted.Location = new System.Drawing.Point(197, 28);
            this.cmbCurrencyAccepted.Name = "cmbCurrencyAccepted";
            this.cmbCurrencyAccepted.Size = new System.Drawing.Size(100, 21);
            this.cmbCurrencyAccepted.TabIndex = 13;
            // 
            // cmbDiscipline
            // 
            this.cmbDiscipline.FormattingEnabled = true;
            this.cmbDiscipline.Location = new System.Drawing.Point(197, 78);
            this.cmbDiscipline.Name = "cmbDiscipline";
            this.cmbDiscipline.Size = new System.Drawing.Size(100, 21);
            this.cmbDiscipline.TabIndex = 16;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(585, 78);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(100, 20);
            this.txtAccountNumber.TabIndex = 17;
            // 
            // btnBankSave
            // 
            this.btnBankSave.Location = new System.Drawing.Point(391, 127);
            this.btnBankSave.Name = "btnBankSave";
            this.btnBankSave.Size = new System.Drawing.Size(75, 23);
            this.btnBankSave.TabIndex = 12;
            this.btnBankSave.Text = "Save";
            this.btnBankSave.UseVisualStyleBackColor = true;
            this.btnBankSave.Click += new System.EventHandler(this.btnBankSave_Click);
            // 
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(197, 103);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(100, 20);
            this.txtCash.TabIndex = 19;
            // 
            // splitContainer9
            // 
            this.splitContainer9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer9.Location = new System.Drawing.Point(3, 346);
            this.splitContainer9.Name = "splitContainer9";
            this.splitContainer9.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer9.Panel1
            // 
            this.splitContainer9.Panel1.Controls.Add(this.linkLabel9);
            // 
            // splitContainer9.Panel2
            // 
            this.splitContainer9.Panel2.Controls.Add(this.tableLayoutPanel17);
            this.splitContainer9.Panel2Collapsed = true;
            this.splitContainer9.Size = new System.Drawing.Size(845, 186);
            this.splitContainer9.SplitterDistance = 52;
            this.splitContainer9.TabIndex = 2;
            // 
            // linkLabel9
            // 
            this.linkLabel9.AutoSize = true;
            this.linkLabel9.Location = new System.Drawing.Point(27, 15);
            this.linkLabel9.Name = "linkLabel9";
            this.linkLabel9.Size = new System.Drawing.Size(80, 13);
            this.linkLabel9.TabIndex = 0;
            this.linkLabel9.TabStop = true;
            this.linkLabel9.Text = "Edit Bank Cash";
            this.linkLabel9.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel9_LinkClicked);
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.ColumnCount = 4;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel17.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel17.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel17.Controls.Add(this.lblEditBankName, 0, 0);
            this.tableLayoutPanel17.Controls.Add(this.lblTotalCash, 2, 0);
            this.tableLayoutPanel17.Controls.Add(this.lblNegativeCash, 0, 1);
            this.tableLayoutPanel17.Controls.Add(this.lblType, 2, 1);
            this.tableLayoutPanel17.Controls.Add(this.cmbEditBankName, 1, 0);
            this.tableLayoutPanel17.Controls.Add(this.txtTotalCash, 3, 0);
            this.tableLayoutPanel17.Controls.Add(this.txtNegativeCash, 1, 1);
            this.tableLayoutPanel17.Controls.Add(this.txtNegativeCashType, 3, 1);
            this.tableLayoutPanel17.Controls.Add(this.btnEditCash, 2, 3);
            this.tableLayoutPanel17.Controls.Add(this.txtTDDuration, 1, 2);
            this.tableLayoutPanel17.Controls.Add(this.calTDStartDate, 3, 2);
            this.tableLayoutPanel17.Location = new System.Drawing.Point(30, 3);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 4;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(737, 112);
            this.tableLayoutPanel17.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(370, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(180, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Deposit Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(180, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Duration(in Months)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEditBankName
            // 
            this.lblEditBankName.AutoSize = true;
            this.lblEditBankName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEditBankName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditBankName.Location = new System.Drawing.Point(2, 0);
            this.lblEditBankName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditBankName.Name = "lblEditBankName";
            this.lblEditBankName.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblEditBankName.Size = new System.Drawing.Size(180, 27);
            this.lblEditBankName.TabIndex = 0;
            this.lblEditBankName.Text = "Bank";
            this.lblEditBankName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalCash
            // 
            this.lblTotalCash.AutoSize = true;
            this.lblTotalCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalCash.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCash.Location = new System.Drawing.Point(370, 0);
            this.lblTotalCash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCash.Name = "lblTotalCash";
            this.lblTotalCash.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblTotalCash.Size = new System.Drawing.Size(180, 27);
            this.lblTotalCash.TabIndex = 1;
            this.lblTotalCash.Text = "Total Cash";
            this.lblTotalCash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNegativeCash
            // 
            this.lblNegativeCash.AutoSize = true;
            this.lblNegativeCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNegativeCash.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNegativeCash.Location = new System.Drawing.Point(2, 27);
            this.lblNegativeCash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNegativeCash.Name = "lblNegativeCash";
            this.lblNegativeCash.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblNegativeCash.Size = new System.Drawing.Size(180, 27);
            this.lblNegativeCash.TabIndex = 2;
            this.lblNegativeCash.Text = "Negative Cash";
            this.lblNegativeCash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(370, 27);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblType.Size = new System.Drawing.Size(180, 27);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbEditBankName
            // 
            this.cmbEditBankName.FormattingEnabled = true;
            this.cmbEditBankName.Location = new System.Drawing.Point(187, 3);
            this.cmbEditBankName.Name = "cmbEditBankName";
            this.cmbEditBankName.Size = new System.Drawing.Size(100, 21);
            this.cmbEditBankName.TabIndex = 4;
            this.cmbEditBankName.SelectedIndexChanged += new System.EventHandler(this.cmbEditBankName_SelectedIndexChanged);
            // 
            // txtTotalCash
            // 
            this.txtTotalCash.Location = new System.Drawing.Point(555, 3);
            this.txtTotalCash.Name = "txtTotalCash";
            this.txtTotalCash.ReadOnly = true;
            this.txtTotalCash.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCash.TabIndex = 5;
            // 
            // txtNegativeCash
            // 
            this.txtNegativeCash.Location = new System.Drawing.Point(187, 30);
            this.txtNegativeCash.Name = "txtNegativeCash";
            this.txtNegativeCash.Size = new System.Drawing.Size(100, 20);
            this.txtNegativeCash.TabIndex = 6;
            // 
            // txtNegativeCashType
            // 
            this.txtNegativeCashType.Location = new System.Drawing.Point(555, 30);
            this.txtNegativeCashType.Name = "txtNegativeCashType";
            this.txtNegativeCashType.Size = new System.Drawing.Size(100, 20);
            this.txtNegativeCashType.TabIndex = 7;
            // 
            // btnEditCash
            // 
            this.btnEditCash.Location = new System.Drawing.Point(371, 84);
            this.btnEditCash.Name = "btnEditCash";
            this.btnEditCash.Size = new System.Drawing.Size(75, 23);
            this.btnEditCash.TabIndex = 8;
            this.btnEditCash.Text = "Save";
            this.btnEditCash.UseVisualStyleBackColor = true;
            this.btnEditCash.Click += new System.EventHandler(this.btnEditCash_Click);
            // 
            // txtTDDuration
            // 
            this.txtTDDuration.Location = new System.Drawing.Point(187, 57);
            this.txtTDDuration.Name = "txtTDDuration";
            this.txtTDDuration.Size = new System.Drawing.Size(100, 20);
            this.txtTDDuration.TabIndex = 11;
            // 
            // calTDStartDate
            // 
            this.calTDStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calTDStartDate.Location = new System.Drawing.Point(555, 57);
            this.calTDStartDate.Name = "calTDStartDate";
            this.calTDStartDate.Size = new System.Drawing.Size(103, 20);
            this.calTDStartDate.TabIndex = 12;
            // 
            // tpProjectMgt
            // 
            this.tpProjectMgt.Controls.Add(this.tableLayoutPanel7);
            this.tpProjectMgt.Location = new System.Drawing.Point(4, 22);
            this.tpProjectMgt.Name = "tpProjectMgt";
            this.tpProjectMgt.Padding = new System.Windows.Forms.Padding(3);
            this.tpProjectMgt.Size = new System.Drawing.Size(1266, 639);
            this.tpProjectMgt.TabIndex = 1;
            this.tpProjectMgt.Text = "Projects";
            this.tpProjectMgt.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Controls.Add(this.dgvProject, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.splitContainer4, 0, 1);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(24, 53);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.6506F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.3494F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(851, 309);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // dgvProject
            // 
            this.dgvProject.AllowUserToAddRows = false;
            this.dgvProject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectName,
            this.ProjectType,
            this.ProjectID,
            this.AmountTillDate,
            this.RemainingAmount,
            this.TotalAmount,
            this.ProjectModify,
            this.ProjectDelete});
            this.dgvProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProject.Location = new System.Drawing.Point(3, 3);
            this.dgvProject.Name = "dgvProject";
            this.dgvProject.Size = new System.Drawing.Size(845, 110);
            this.dgvProject.TabIndex = 0;
            // 
            // ProjectName
            // 
            this.ProjectName.HeaderText = "Name";
            this.ProjectName.Name = "ProjectName";
            // 
            // ProjectType
            // 
            this.ProjectType.HeaderText = "ProjectType";
            this.ProjectType.Name = "ProjectType";
            // 
            // ProjectID
            // 
            this.ProjectID.HeaderText = "ProjectID";
            this.ProjectID.Name = "ProjectID";
            // 
            // AmountTillDate
            // 
            this.AmountTillDate.HeaderText = "AmountTillDate";
            this.AmountTillDate.Name = "AmountTillDate";
            // 
            // RemainingAmount
            // 
            this.RemainingAmount.HeaderText = "RemainingAmount";
            this.RemainingAmount.Name = "RemainingAmount";
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "TotalAmount";
            this.TotalAmount.Name = "TotalAmount";
            // 
            // ProjectModify
            // 
            this.ProjectModify.HeaderText = "Modify";
            this.ProjectModify.Image = ((System.Drawing.Image)(resources.GetObject("ProjectModify.Image")));
            this.ProjectModify.Name = "ProjectModify";
            this.ProjectModify.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ProjectDelete
            // 
            this.ProjectDelete.HeaderText = "";
            this.ProjectDelete.Image = ((System.Drawing.Image)(resources.GetObject("ProjectDelete.Image")));
            this.ProjectDelete.Name = "ProjectDelete";
            this.ProjectDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 119);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.linkLabel4);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.tableLayoutPanel8);
            this.splitContainer4.Panel2Collapsed = true;
            this.splitContainer4.Size = new System.Drawing.Size(845, 187);
            this.splitContainer4.SplitterDistance = 27;
            this.splitContainer4.TabIndex = 1;
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(35, 7);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(87, 13);
            this.linkLabel4.TabIndex = 0;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Add New Project";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.lblProjectType, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.lblAmntTillDate, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.lblAmntDue, 2, 1);
            this.tableLayoutPanel8.Controls.Add(this.lblTotalAmnt, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.btnProjectSave, 1, 3);
            this.tableLayoutPanel8.Controls.Add(this.txtAmountTillDate, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.txtAmountDue, 3, 1);
            this.tableLayoutPanel8.Controls.Add(this.cmbProjectType, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.txtTotalAmount, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.txtProjectName, 1, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(12, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 4;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(701, 126);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(171, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Project Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProjectType
            // 
            this.lblProjectType.AutoSize = true;
            this.lblProjectType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProjectType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectType.Location = new System.Drawing.Point(352, 0);
            this.lblProjectType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjectType.Name = "lblProjectType";
            this.lblProjectType.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblProjectType.Size = new System.Drawing.Size(171, 31);
            this.lblProjectType.TabIndex = 1;
            this.lblProjectType.Text = "Type";
            this.lblProjectType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAmntTillDate
            // 
            this.lblAmntTillDate.AutoSize = true;
            this.lblAmntTillDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAmntTillDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmntTillDate.Location = new System.Drawing.Point(2, 31);
            this.lblAmntTillDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmntTillDate.Name = "lblAmntTillDate";
            this.lblAmntTillDate.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblAmntTillDate.Size = new System.Drawing.Size(171, 31);
            this.lblAmntTillDate.TabIndex = 2;
            this.lblAmntTillDate.Text = "Amount Till Date";
            this.lblAmntTillDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAmntDue
            // 
            this.lblAmntDue.AutoSize = true;
            this.lblAmntDue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAmntDue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmntDue.Location = new System.Drawing.Point(352, 31);
            this.lblAmntDue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmntDue.Name = "lblAmntDue";
            this.lblAmntDue.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblAmntDue.Size = new System.Drawing.Size(171, 31);
            this.lblAmntDue.TabIndex = 3;
            this.lblAmntDue.Text = "Amount Due";
            this.lblAmntDue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalAmnt
            // 
            this.lblTotalAmnt.AutoSize = true;
            this.lblTotalAmnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalAmnt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmnt.Location = new System.Drawing.Point(2, 62);
            this.lblTotalAmnt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalAmnt.Name = "lblTotalAmnt";
            this.lblTotalAmnt.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblTotalAmnt.Size = new System.Drawing.Size(171, 31);
            this.lblTotalAmnt.TabIndex = 4;
            this.lblTotalAmnt.Text = "Total Amount";
            this.lblTotalAmnt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnProjectSave
            // 
            this.btnProjectSave.Location = new System.Drawing.Point(178, 96);
            this.btnProjectSave.Name = "btnProjectSave";
            this.btnProjectSave.Size = new System.Drawing.Size(75, 23);
            this.btnProjectSave.TabIndex = 5;
            this.btnProjectSave.Text = "Save";
            this.btnProjectSave.UseVisualStyleBackColor = true;
            this.btnProjectSave.Click += new System.EventHandler(this.btnProjectSave_Click);
            // 
            // txtAmountTillDate
            // 
            this.txtAmountTillDate.Location = new System.Drawing.Point(178, 34);
            this.txtAmountTillDate.Name = "txtAmountTillDate";
            this.txtAmountTillDate.Size = new System.Drawing.Size(100, 20);
            this.txtAmountTillDate.TabIndex = 7;
            // 
            // txtAmountDue
            // 
            this.txtAmountDue.Location = new System.Drawing.Point(528, 34);
            this.txtAmountDue.Name = "txtAmountDue";
            this.txtAmountDue.Size = new System.Drawing.Size(100, 20);
            this.txtAmountDue.TabIndex = 9;
            // 
            // cmbProjectType
            // 
            this.cmbProjectType.FormattingEnabled = true;
            this.cmbProjectType.Location = new System.Drawing.Point(528, 3);
            this.cmbProjectType.Name = "cmbProjectType";
            this.cmbProjectType.Size = new System.Drawing.Size(121, 21);
            this.cmbProjectType.TabIndex = 10;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(178, 65);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.txtTotalAmount.TabIndex = 8;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(178, 3);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(100, 20);
            this.txtProjectName.TabIndex = 12;
            // 
            // tpExpenseTypeMgt
            // 
            this.tpExpenseTypeMgt.Controls.Add(this.tableLayoutPanel9);
            this.tpExpenseTypeMgt.Location = new System.Drawing.Point(4, 22);
            this.tpExpenseTypeMgt.Name = "tpExpenseTypeMgt";
            this.tpExpenseTypeMgt.Padding = new System.Windows.Forms.Padding(3);
            this.tpExpenseTypeMgt.Size = new System.Drawing.Size(1266, 639);
            this.tpExpenseTypeMgt.TabIndex = 0;
            this.tpExpenseTypeMgt.Text = "Revenue Type";
            this.tpExpenseTypeMgt.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Controls.Add(this.dgvExpenseType, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.splitContainer5, 0, 1);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(24, 53);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.83607F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.16393F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(851, 335);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // dgvExpenseType
            // 
            this.dgvExpenseType.AllowUserToAddRows = false;
            this.dgvExpenseType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpenseType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenseType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExpenseType,
            this.ExpenseTypeID,
            this.ExpenseTypeModify,
            this.ExpenseTypeDelete});
            this.dgvExpenseType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExpenseType.Location = new System.Drawing.Point(3, 3);
            this.dgvExpenseType.Name = "dgvExpenseType";
            this.dgvExpenseType.Size = new System.Drawing.Size(845, 110);
            this.dgvExpenseType.TabIndex = 0;
            // 
            // ExpenseType
            // 
            this.ExpenseType.HeaderText = "ExpenseType";
            this.ExpenseType.Name = "ExpenseType";
            // 
            // ExpenseTypeID
            // 
            this.ExpenseTypeID.HeaderText = "ExpenseTypeID";
            this.ExpenseTypeID.Name = "ExpenseTypeID";
            // 
            // ExpenseTypeModify
            // 
            this.ExpenseTypeModify.HeaderText = "Modify";
            this.ExpenseTypeModify.Image = ((System.Drawing.Image)(resources.GetObject("ExpenseTypeModify.Image")));
            this.ExpenseTypeModify.Name = "ExpenseTypeModify";
            this.ExpenseTypeModify.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ExpenseTypeDelete
            // 
            this.ExpenseTypeDelete.HeaderText = "";
            this.ExpenseTypeDelete.Image = ((System.Drawing.Image)(resources.GetObject("ExpenseTypeDelete.Image")));
            this.ExpenseTypeDelete.Name = "ExpenseTypeDelete";
            this.ExpenseTypeDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(3, 119);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.linkLabel5);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.tableLayoutPanel10);
            this.splitContainer5.Panel2Collapsed = true;
            this.splitContainer5.Size = new System.Drawing.Size(845, 213);
            this.splitContainer5.SplitterDistance = 29;
            this.splitContainer5.TabIndex = 1;
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(25, 4);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(122, 13);
            this.linkLabel5.TabIndex = 0;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Add New Expense Type";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.btnExpenseTypeSave, 1, 1);
            this.tableLayoutPanel10.Controls.Add(this.lblExpenseTypeName, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.txtExpenseType, 1, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(24, 53);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(273, 80);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // btnExpenseTypeSave
            // 
            this.btnExpenseTypeSave.Location = new System.Drawing.Point(139, 43);
            this.btnExpenseTypeSave.Name = "btnExpenseTypeSave";
            this.btnExpenseTypeSave.Size = new System.Drawing.Size(75, 23);
            this.btnExpenseTypeSave.TabIndex = 2;
            this.btnExpenseTypeSave.Text = "Save";
            this.btnExpenseTypeSave.UseVisualStyleBackColor = true;
            this.btnExpenseTypeSave.Click += new System.EventHandler(this.btnExpenseTypeSave_Click);
            // 
            // lblExpenseTypeName
            // 
            this.lblExpenseTypeName.AutoSize = true;
            this.lblExpenseTypeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblExpenseTypeName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenseTypeName.Location = new System.Drawing.Point(2, 0);
            this.lblExpenseTypeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExpenseTypeName.Name = "lblExpenseTypeName";
            this.lblExpenseTypeName.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblExpenseTypeName.Size = new System.Drawing.Size(132, 40);
            this.lblExpenseTypeName.TabIndex = 0;
            this.lblExpenseTypeName.Text = "ExpenseType";
            this.lblExpenseTypeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtExpenseType
            // 
            this.txtExpenseType.Location = new System.Drawing.Point(139, 3);
            this.txtExpenseType.Name = "txtExpenseType";
            this.txtExpenseType.Size = new System.Drawing.Size(100, 20);
            this.txtExpenseType.TabIndex = 1;
            // 
            // tpSiteMgt
            // 
            this.tpSiteMgt.Controls.Add(this.tableLayoutPanel11);
            this.tpSiteMgt.Location = new System.Drawing.Point(4, 22);
            this.tpSiteMgt.Name = "tpSiteMgt";
            this.tpSiteMgt.Padding = new System.Windows.Forms.Padding(3);
            this.tpSiteMgt.Size = new System.Drawing.Size(1266, 639);
            this.tpSiteMgt.TabIndex = 1;
            this.tpSiteMgt.Text = "Sites";
            this.tpSiteMgt.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel11.Controls.Add(this.dgvSite, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.splitContainer6, 0, 1);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(24, 53);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.83607F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.16393F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(851, 334);
            this.tableLayoutPanel11.TabIndex = 1;
            // 
            // dgvSite
            // 
            this.dgvSite.AllowUserToAddRows = false;
            this.dgvSite.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.SiteID,
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2});
            this.dgvSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSite.Location = new System.Drawing.Point(3, 3);
            this.dgvSite.Name = "dgvSite";
            this.dgvSite.Size = new System.Drawing.Size(845, 110);
            this.dgvSite.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Site";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // SiteID
            // 
            this.SiteID.HeaderText = "SiteID";
            this.SiteID.Name = "SiteID";
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Modify";
            this.dataGridViewButtonColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewButtonColumn1.Image")));
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "";
            this.dataGridViewButtonColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewButtonColumn2.Image")));
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(3, 119);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.linkLabel6);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.tableLayoutPanel12);
            this.splitContainer6.Panel2Collapsed = true;
            this.splitContainer6.Size = new System.Drawing.Size(845, 212);
            this.splitContainer6.SplitterDistance = 29;
            this.splitContainer6.TabIndex = 1;
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(25, 4);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(72, 13);
            this.linkLabel6.TabIndex = 0;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Add New Site";
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Controls.Add(this.btnSaveSite, 1, 1);
            this.tableLayoutPanel12.Controls.Add(this.lblSite, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.txtSite, 1, 0);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(24, 53);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 2;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(241, 80);
            this.tableLayoutPanel12.TabIndex = 0;
            // 
            // btnSaveSite
            // 
            this.btnSaveSite.Location = new System.Drawing.Point(123, 43);
            this.btnSaveSite.Name = "btnSaveSite";
            this.btnSaveSite.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSite.TabIndex = 2;
            this.btnSaveSite.Text = "Save";
            this.btnSaveSite.UseVisualStyleBackColor = true;
            this.btnSaveSite.Click += new System.EventHandler(this.btnSaveSite_Click);
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSite.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSite.Location = new System.Drawing.Point(2, 0);
            this.lblSite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSite.Name = "lblSite";
            this.lblSite.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblSite.Size = new System.Drawing.Size(116, 40);
            this.lblSite.TabIndex = 0;
            this.lblSite.Text = "Site";
            this.lblSite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(123, 3);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(100, 20);
            this.txtSite.TabIndex = 1;
            // 
            // tpPayementApprovalMgt
            // 
            this.tpPayementApprovalMgt.Controls.Add(this.tableLayoutPanel15);
            this.tpPayementApprovalMgt.Location = new System.Drawing.Point(4, 22);
            this.tpPayementApprovalMgt.Name = "tpPayementApprovalMgt";
            this.tpPayementApprovalMgt.Padding = new System.Windows.Forms.Padding(3);
            this.tpPayementApprovalMgt.Size = new System.Drawing.Size(1266, 639);
            this.tpPayementApprovalMgt.TabIndex = 0;
            this.tpPayementApprovalMgt.Text = "Payment Approval";
            this.tpPayementApprovalMgt.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 1;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel15.Controls.Add(this.dgvApprover, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.splitContainer8, 0, 1);
            this.tableLayoutPanel15.Location = new System.Drawing.Point(24, 53);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 2;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.6506F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.3494F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(851, 309);
            this.tableLayoutPanel15.TabIndex = 1;
            // 
            // dgvApprover
            // 
            this.dgvApprover.AllowUserToAddRows = false;
            this.dgvApprover.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApprover.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApprover.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.department,
            this.location,
            this.approver,
            this.disciplineOld,
            this.locationold,
            this.approverold,
            this.dataGridViewButtonColumn5,
            this.dataGridViewButtonColumn6});
            this.dgvApprover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvApprover.Location = new System.Drawing.Point(3, 3);
            this.dgvApprover.Name = "dgvApprover";
            this.dgvApprover.Size = new System.Drawing.Size(845, 110);
            this.dgvApprover.TabIndex = 0;
            // 
            // department
            // 
            this.department.HeaderText = "Depatment";
            this.department.Name = "department";
            this.department.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.department.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // location
            // 
            this.location.HeaderText = "Location";
            this.location.Name = "location";
            // 
            // approver
            // 
            this.approver.HeaderText = "Approver";
            this.approver.Name = "approver";
            this.approver.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.approver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // disciplineOld
            // 
            this.disciplineOld.HeaderText = "disciplineOld";
            this.disciplineOld.Name = "disciplineOld";
            // 
            // locationold
            // 
            this.locationold.HeaderText = "locationold";
            this.locationold.Name = "locationold";
            // 
            // approverold
            // 
            this.approverold.HeaderText = "approverold";
            this.approverold.Name = "approverold";
            // 
            // dataGridViewButtonColumn5
            // 
            this.dataGridViewButtonColumn5.HeaderText = "Modify";
            this.dataGridViewButtonColumn5.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewButtonColumn5.Image")));
            this.dataGridViewButtonColumn5.Name = "dataGridViewButtonColumn5";
            this.dataGridViewButtonColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewButtonColumn6
            // 
            this.dataGridViewButtonColumn6.HeaderText = "";
            this.dataGridViewButtonColumn6.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewButtonColumn6.Image")));
            this.dataGridViewButtonColumn6.Name = "dataGridViewButtonColumn6";
            this.dataGridViewButtonColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.Location = new System.Drawing.Point(3, 119);
            this.splitContainer8.Name = "splitContainer8";
            this.splitContainer8.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.linkLabel8);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.tableLayoutPanel16);
            this.splitContainer8.Panel2Collapsed = true;
            this.splitContainer8.Size = new System.Drawing.Size(845, 187);
            this.splitContainer8.SplitterDistance = 27;
            this.splitContainer8.TabIndex = 1;
            // 
            // linkLabel8
            // 
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.Location = new System.Drawing.Point(35, 7);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(97, 13);
            this.linkLabel8.TabIndex = 0;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "Add New Approver";
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 4;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel16.Controls.Add(this.lblDepartment, 0, 0);
            this.tableLayoutPanel16.Controls.Add(this.lblLocation1, 0, 1);
            this.tableLayoutPanel16.Controls.Add(this.lblApprover1, 2, 0);
            this.tableLayoutPanel16.Controls.Add(this.btnApproverSave, 1, 3);
            this.tableLayoutPanel16.Controls.Add(this.cmbLocation2, 1, 1);
            this.tableLayoutPanel16.Controls.Add(this.cmbDepartment, 1, 0);
            this.tableLayoutPanel16.Controls.Add(this.cmbApprover, 3, 0);
            this.tableLayoutPanel16.Location = new System.Drawing.Point(3, 15);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 4;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(606, 126);
            this.tableLayoutPanel16.TabIndex = 0;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDepartment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(2, 0);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblDepartment.Size = new System.Drawing.Size(147, 31);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "Department";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLocation1
            // 
            this.lblLocation1.AutoSize = true;
            this.lblLocation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLocation1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation1.Location = new System.Drawing.Point(2, 31);
            this.lblLocation1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocation1.Name = "lblLocation1";
            this.lblLocation1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblLocation1.Size = new System.Drawing.Size(147, 31);
            this.lblLocation1.TabIndex = 1;
            this.lblLocation1.Text = "Location ";
            this.lblLocation1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblApprover1
            // 
            this.lblApprover1.AutoSize = true;
            this.lblApprover1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblApprover1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApprover1.Location = new System.Drawing.Point(304, 0);
            this.lblApprover1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApprover1.Name = "lblApprover1";
            this.lblApprover1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblApprover1.Size = new System.Drawing.Size(147, 31);
            this.lblApprover1.TabIndex = 2;
            this.lblApprover1.Text = "Approver ";
            this.lblApprover1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnApproverSave
            // 
            this.btnApproverSave.Location = new System.Drawing.Point(154, 96);
            this.btnApproverSave.Name = "btnApproverSave";
            this.btnApproverSave.Size = new System.Drawing.Size(75, 23);
            this.btnApproverSave.TabIndex = 5;
            this.btnApproverSave.Text = "Save";
            this.btnApproverSave.UseVisualStyleBackColor = true;
            this.btnApproverSave.Click += new System.EventHandler(this.btnApproverSave_Click);
            // 
            // cmbLocation2
            // 
            this.cmbLocation2.FormattingEnabled = true;
            this.cmbLocation2.Location = new System.Drawing.Point(154, 34);
            this.cmbLocation2.Name = "cmbLocation2";
            this.cmbLocation2.Size = new System.Drawing.Size(100, 21);
            this.cmbLocation2.TabIndex = 10;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(154, 3);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(100, 21);
            this.cmbDepartment.TabIndex = 11;
            // 
            // cmbApprover
            // 
            this.cmbApprover.FormattingEnabled = true;
            this.cmbApprover.Location = new System.Drawing.Point(456, 3);
            this.cmbApprover.Name = "cmbApprover";
            this.cmbApprover.Size = new System.Drawing.Size(100, 21);
            this.cmbApprover.TabIndex = 12;
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.tableLayoutPanel13);
            this.tpSettings.Location = new System.Drawing.Point(4, 22);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(1266, 639);
            this.tpSettings.TabIndex = 1;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel13.Controls.Add(this.dgvCurrency, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.splitContainer7, 0, 1);
            this.tableLayoutPanel13.Location = new System.Drawing.Point(24, 53);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 2;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.83607F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.16393F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(851, 333);
            this.tableLayoutPanel13.TabIndex = 1;
            // 
            // dgvCurrency
            // 
            this.dgvCurrency.AllowUserToAddRows = false;
            this.dgvCurrency.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCurrency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrency.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.currencyID,
            this.ExchangeRateinUSD,
            this.dataGridViewButtonColumn3,
            this.dataGridViewButtonColumn4});
            this.dgvCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCurrency.Location = new System.Drawing.Point(3, 3);
            this.dgvCurrency.Name = "dgvCurrency";
            this.dgvCurrency.Size = new System.Drawing.Size(845, 110);
            this.dgvCurrency.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Currency";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // currencyID
            // 
            this.currencyID.HeaderText = "currencyID";
            this.currencyID.Name = "currencyID";
            // 
            // ExchangeRateinUSD
            // 
            this.ExchangeRateinUSD.HeaderText = "Exchange Rate(in USD)";
            this.ExchangeRateinUSD.Name = "ExchangeRateinUSD";
            // 
            // dataGridViewButtonColumn3
            // 
            this.dataGridViewButtonColumn3.HeaderText = "Modify";
            this.dataGridViewButtonColumn3.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewButtonColumn3.Image")));
            this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            this.dataGridViewButtonColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewButtonColumn4
            // 
            this.dataGridViewButtonColumn4.HeaderText = "";
            this.dataGridViewButtonColumn4.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewButtonColumn4.Image")));
            this.dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
            this.dataGridViewButtonColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(3, 119);
            this.splitContainer7.Name = "splitContainer7";
            this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.linkLabel7);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.tableLayoutPanel14);
            this.splitContainer7.Panel2Collapsed = true;
            this.splitContainer7.Size = new System.Drawing.Size(845, 211);
            this.splitContainer7.SplitterDistance = 29;
            this.splitContainer7.TabIndex = 1;
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Location = new System.Drawing.Point(25, 4);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(96, 13);
            this.linkLabel7.TabIndex = 0;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Add New Currency";
            this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 4;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel14.Controls.Add(this.lblCurrency, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.txtCurrency, 1, 0);
            this.tableLayoutPanel14.Controls.Add(this.lblExchangeRate, 2, 0);
            this.tableLayoutPanel14.Controls.Add(this.txtExchangeRate, 3, 0);
            this.tableLayoutPanel14.Controls.Add(this.btnCurrencySave, 2, 1);
            this.tableLayoutPanel14.Location = new System.Drawing.Point(28, 3);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 2;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(590, 80);
            this.tableLayoutPanel14.TabIndex = 0;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrency.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.Location = new System.Drawing.Point(2, 0);
            this.lblCurrency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblCurrency.Size = new System.Drawing.Size(143, 40);
            this.lblCurrency.TabIndex = 0;
            this.lblCurrency.Text = "Currency";
            this.lblCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(150, 3);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(100, 20);
            this.txtCurrency.TabIndex = 1;
            // 
            // lblExchangeRate
            // 
            this.lblExchangeRate.AutoSize = true;
            this.lblExchangeRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblExchangeRate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExchangeRate.Location = new System.Drawing.Point(296, 0);
            this.lblExchangeRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExchangeRate.Name = "lblExchangeRate";
            this.lblExchangeRate.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblExchangeRate.Size = new System.Drawing.Size(143, 40);
            this.lblExchangeRate.TabIndex = 3;
            this.lblExchangeRate.Text = "Exchange Rate";
            this.lblExchangeRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtExchangeRate
            // 
            this.txtExchangeRate.Location = new System.Drawing.Point(444, 3);
            this.txtExchangeRate.Name = "txtExchangeRate";
            this.txtExchangeRate.Size = new System.Drawing.Size(100, 20);
            this.txtExchangeRate.TabIndex = 4;
            // 
            // btnCurrencySave
            // 
            this.btnCurrencySave.Location = new System.Drawing.Point(297, 43);
            this.btnCurrencySave.Name = "btnCurrencySave";
            this.btnCurrencySave.Size = new System.Drawing.Size(62, 23);
            this.btnCurrencySave.TabIndex = 2;
            this.btnCurrencySave.Text = "Save";
            this.btnCurrencySave.UseVisualStyleBackColor = true;
            this.btnCurrencySave.Click += new System.EventHandler(this.btnCurrencySave_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 622);
            this.Controls.Add(this.tabControl1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpUserMgt.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tpSupplierMgt.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.tpBankMgt.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBank)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.splitContainer9.Panel1.ResumeLayout(false);
            this.splitContainer9.Panel1.PerformLayout();
            this.splitContainer9.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).EndInit();
            this.splitContainer9.ResumeLayout(false);
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
            this.tpProjectMgt.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).EndInit();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tpExpenseTypeMgt.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseType)).EndInit();
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tpSiteMgt.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSite)).EndInit();
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel1.PerformLayout();
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.tpPayementApprovalMgt.ResumeLayout(false);
            this.tableLayoutPanel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApprover)).EndInit();
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel1.PerformLayout();
            this.splitContainer8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel16.PerformLayout();
            this.tpSettings.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrency)).EndInit();
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel1.PerformLayout();
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpUserMgt;
        private System.Windows.Forms.TabPage tpSupplierMgt;
        private System.Windows.Forms.TabPage tpBankMgt;
        private System.Windows.Forms.TabPage tpProjectMgt;
        private System.Windows.Forms.TabPage tpExpenseTypeMgt;
        private System.Windows.Forms.TabPage tpSiteMgt;
        private System.Windows.Forms.TabPage tpPayementApprovalMgt;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassWord;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrivilege;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.TextBox txtCompanyRole;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox lstPrivilege;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblSupplierCode;
        private System.Windows.Forms.Label lblSupplierBank;
        private System.Windows.Forms.Label lblSupplierType;
        private System.Windows.Forms.Label lblSupplierAddress;
        private System.Windows.Forms.Label lblSupplierCountry;
        private System.Windows.Forms.Button btnSupplierSave;
        private System.Windows.Forms.TextBox txtSupplierCode;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.TextBox txtSupplierAddress;
        private System.Windows.Forms.TextBox txtSupplerCountry;
        private System.Windows.Forms.ComboBox cmbSupplierBank;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridView dgvBank;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.Label lblBankCode;
        private System.Windows.Forms.Label lblBankCurrency;
        private System.Windows.Forms.Label lblSwiftCode;
        private System.Windows.Forms.Label lblIBAN;
        private System.Windows.Forms.Label lblBankCountry;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.TextBox txtBankCode;
        private System.Windows.Forms.TextBox txtSwiftCode;
        private System.Windows.Forms.TextBox txtIBAN;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnBankSave;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.DataGridView dgvProject;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label lblProjectType;
        private System.Windows.Forms.Label lblAmntTillDate;
        private System.Windows.Forms.Label lblAmntDue;
        private System.Windows.Forms.Label lblTotalAmnt;
        private System.Windows.Forms.Button btnProjectSave;
        private System.Windows.Forms.TextBox txtAmountTillDate;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtAmountDue;
        private System.Windows.Forms.ComboBox cmbProjectType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.DataGridView dgvExpenseType;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Button btnExpenseTypeSave;
        private System.Windows.Forms.Label lblExpenseTypeName;
        private System.Windows.Forms.TextBox txtExpenseType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.DataGridView dgvSite;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Button btnSaveSite;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.Button btnCurrencySave;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.Label lblExchangeRate;
        private System.Windows.Forms.TextBox txtExchangeRate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.DataGridView dgvApprover;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblLocation1;
        private System.Windows.Forms.Label lblApprover1;
        private System.Windows.Forms.Button btnApproverSave;
        private System.Windows.Forms.ComboBox cmbLocation2;
        private System.Windows.Forms.SplitContainer splitContainer9;
        private System.Windows.Forms.LinkLabel linkLabel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.Label lblEditBankName;
        private System.Windows.Forms.Label lblTotalCash;
        private System.Windows.Forms.Label lblNegativeCash;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbEditBankName;
        private System.Windows.Forms.TextBox txtTotalCash;
        private System.Windows.Forms.TextBox txtNegativeCash;
        private System.Windows.Forms.TextBox txtNegativeCashType;
        private System.Windows.Forms.Button btnEditCash;
        private System.Windows.Forms.DataGridView dgvCurrency;
        private System.Windows.Forms.ComboBox cmbCurrencyAccepted;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseTypeID;
        private System.Windows.Forms.DataGridViewImageColumn ExpenseTypeModify;
        private System.Windows.Forms.DataGridViewImageColumn ExpenseTypeDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiteID;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrivilegeOld;
        private System.Windows.Forms.DataGridViewComboBoxColumn Privilege;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyRole;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.ComboBox cmbSupplierType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewComboBoxColumn SupplierBank;
        private System.Windows.Forms.DataGridViewComboBoxColumn SupplierType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierCountry;
        private System.Windows.Forms.DataGridViewImageColumn SupplierModify;
        private System.Windows.Forms.DataGridViewImageColumn SupplierDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDiscipline;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn CurrencyAccepted;
        private System.Windows.Forms.DataGridViewTextBoxColumn SwiftCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn IBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankCountry;
        private System.Windows.Forms.DataGridViewComboBoxColumn Discipline;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cash;
        private System.Windows.Forms.DataGridViewImageColumn ModifyBank;
        private System.Windows.Forms.DataGridViewImageColumn DeleteBank;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTDDuration;
        private System.Windows.Forms.DateTimePicker calTDStartDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProjectType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountTillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewImageColumn ProjectModify;
        private System.Windows.Forms.DataGridViewImageColumn ProjectDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExchangeRateinUSD;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewButtonColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewButtonColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn department;
        private System.Windows.Forms.DataGridViewComboBoxColumn location;
        private System.Windows.Forms.DataGridViewComboBoxColumn approver;
        private System.Windows.Forms.DataGridViewComboBoxColumn disciplineOld;
        private System.Windows.Forms.DataGridViewComboBoxColumn locationold;
        private System.Windows.Forms.DataGridViewComboBoxColumn approverold;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewButtonColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewButtonColumn6;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbApprover;

        
        
    }
   

}