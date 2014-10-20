using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Rasta
{
    public partial class AccountReceivable : Form
    {
        string con = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        MySqlDataAdapter sda1;

        public AccountReceivable()
        {
            InitializeComponent();
        
                    }

        private void dgvAccountReceivable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = ((DataGridView)sender);

            if (e.ColumnIndex < 0)
            {
                dgv.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                dgv.Focus();
                dgv.EndEdit();
            }
             else if (e.ColumnIndex ==11)
            {
                string query = "DELETE FROM tbl_AccountReceivable " +
                "WHERE InvoiceID =" + dgvAccountReceivable.Rows[e.RowIndex].Cells[0].Value.ToString() + " ";
                MySqlConnection connection = new MySqlConnection(con);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.CommandType = CommandType.Text;
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                string queryUpdate = "Update Tbl_Bank SET Cash= Cash-" +Convert.ToDouble(dgvAccountReceivable.Rows[e.RowIndex].Cells[6].Value)+" where bankid="+dgvAccountReceivable.Rows[e.RowIndex].Cells[5].Value.ToString()+"";
                MySqlCommand cmdUpdate = new MySqlCommand(queryUpdate, connection);
                cmdUpdate.CommandType = CommandType.Text;
                connection.Open();
                cmdUpdate.ExecuteNonQuery();
                connection.Close();

                dgvAccountReceivable.Rows.Remove(dgvAccountReceivable.Rows[e.RowIndex]);
            }


            else if (e.ColumnIndex == 10)
            {
                this.tabControl1.SelectedIndex = 0;
                this.lblAddOrEdit.Text = "InvoiceID ";
                this.lblInvoiceID.Text = dgvAccountReceivable.Rows[e.RowIndex].Cells[0].Value.ToString();
                //string CmdDetails = "SELECT A.SupplierID as SupplierID,S.SupplierName as SupplierName,S.SupplierCode as SupplierCode,A.ExpenseTypeID as ExpenseTypeID,A.ProjectID as ProjectID," +
                //"A.BankID as BankID,A.Amount as Amount,A.InvoiceDate as InvoiceDate,A.DueDate as DueDate,A.CurrencyID as CurrencyID,A.InvoiceID as InvoiceID from tbl_AccountReceivable A " +
                //"LEFT JOIN TBL_Supplier S ON S.SupplierID=A.SupplierID WHERE A.INVOICEID=" + dgvAccountReceivable.Rows[e.RowIndex].Cells[0].Value + "";
                //sda1 = new MySqlDataAdapter(CmdDetails, con);
                //DataTable dtDetails = new DataTable();
                //sda1.Fill(dtDetails);
                this.cmbSupplierName.SelectedValue = dgvAccountReceivable.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.cmbSupplierCode.SelectedValue = dgvAccountReceivable.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.cmbType.SelectedValue = dgvAccountReceivable.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.cmbProject.SelectedValue = dgvAccountReceivable.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.cmbBank.SelectedValue = dgvAccountReceivable.Rows[e.RowIndex].Cells[5].Value.ToString();
                this.cmbCurrency.SelectedValue = dgvAccountReceivable.Rows[e.RowIndex].Cells[9].Value.ToString();
                this.txtAmount.Text = dgvAccountReceivable.Rows[e.RowIndex].Cells[6].Value.ToString();
                this.calInvoiceDate.Value =Convert.ToDateTime(dgvAccountReceivable.Rows[e.RowIndex].Cells[7].Value);
                if(Convert.ToInt32(dgvAccountReceivable.Rows[e.RowIndex].Cells[12].Value)==1)
                {
                this.chkCreditToBank.Checked = true;
                this.chkCreditToBank.Enabled = false;
                }
                //this.cmbSupplierName.SelectedValue = Convert.ToString(dtDetails.Rows[0]["SupplierCode"]);
                //this.cmbSupplierCode.SelectedValue = Convert.ToString(dtDetails.Rows[0]["SupplierName"]);
                //this.cmbType.SelectedValue = Convert.ToString(dtDetails.Rows[0]["ExpenseTypeID"]);
                //this.cmbProject.SelectedValue = Convert.ToString(dtDetails.Rows[0]["ProjectID"]);
                //this.cmbBank.SelectedValue = Convert.ToString(dtDetails.Rows[0]["BankID"]);
                //this.cmbCurrency.SelectedValue = Convert.ToString(dtDetails.Rows[0]["CurrencyID"]);
                //this.txtAmount.Text = Convert.ToString(dtDetails.Rows[0]["Amount"]);
                //this.calInvoiceDate.Value = Convert.ToDateTime(dtDetails.Rows[0]["InvoiceDate"]);
                //cmd.Parameters.AddWithValue("sname", dgvAccountReceivable.Rows[e.RowIndex].Cells[1].Value.ToString());
                //cmd.Parameters.AddWithValue("sCODE", dgvAccountReceivable.Rows[e.RowIndex].Cells[2].Value.ToString());
                //cmd.Parameters.AddWithValue("iEXPENSETYPEID", dgvAccountReceivable.Rows[e.RowIndex].Cells[3].Value.ToString());
                //cmd.Parameters.AddWithValue("iPROJECTID", dgvAccountReceivable.Rows[e.RowIndex].Cells[4].Value.ToString());
                //cmd.Parameters.AddWithValue("iBANKID", dgvAccountReceivable.Rows[e.RowIndex].Cells[5].Value.ToString());
                //cmd.Parameters.AddWithValue("dAMOUNT", dgvAccountReceivable.Rows[e.RowIndex].Cells[6].Value);
                //cmd.Parameters.AddWithValue("cINVOICEDATE", Convert.ToDateTime(dgvAccountReceivable.Rows[e.RowIndex].Cells[7].Value).ToString("yyyy-MM-dd H:mm:ss"));
                //cmd.Parameters.AddWithValue("cDUEDATE", Convert.ToDateTime(dgvAccountReceivable.Rows[e.RowIndex].Cells[8].Value).ToString("yyyy-MM-dd H:mm:ss"));
                //cmd.Parameters.AddWithValue("iCURRENCYID", dgvAccountReceivable.Rows[e.RowIndex].Cells[9].Value.ToString());

                

            }
            else
            {
                dgv.EditMode = DataGridViewEditMode.EditOnEnter;
                dgv.BeginEdit(false);
            }

        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
{
    if (this.tabControl1.SelectedIndex==1)
    {
        string CmdDetails = "SELECT A.SupplierID as SupplierID,S.SupplierName as SupplierName,S.SupplierCode as SupplierCode,A.ExpenseTypeID as ExpenseTypeID,A.ProjectID as ProjectID," +
               "A.BankID as BankID,A.Amount as Amount,A.InvoiceDate as InvoiceDate,A.DueDate as DueDate,A.CurrencyID as CurrencyID,A.credittobank as credittobank,A.InvoiceID as InvoiceID from tbl_AccountReceivable A " +
               "LEFT JOIN TBL_Supplier S ON S.SupplierID=A.SupplierID";
        sda1 = new MySqlDataAdapter(CmdDetails, con);
        DataTable dtDetails = new DataTable();
        sda1.Fill(dtDetails);
        dgvAccountReceivable.AutoGenerateColumns = false;
        dgvAccountReceivable.DataSource = dtDetails;
        dgvAccountReceivable.Columns["InvoiceID"].Visible = false;
        dgvAccountReceivable.Columns["credittobank"].Visible = false;

        this.ARDueDate.DataPropertyName = "Duedate";
        this.ARInvoiceDate.DataPropertyName = "InvoiceDate";
        this.ARAmount.DataPropertyName = "Amount";
        this.InvoiceID.DataPropertyName = "InvoiceID";
        this.credittobank.DataPropertyName = "credittobank";
        //this.ARSupplierName.DataSource = dtSuuplier;
        //this.ARSupplierName.DisplayMember = "SupplierName";
        //this.ARSupplierName.ValueMember = "SupplierName";
        this.ARSupplierName.DataPropertyName = "SupplierName";

        //this.ARSupplierCode.DataSource = dtSuuplier;
        //this.ARSupplierCode.DisplayMember = "SupplierCode";
        //this.ARSupplierCode.ValueMember = "SupplierCode";
        this.ARSupplierCode.DataPropertyName = "SupplierCode";

        //this.ARBank.DataSource = dtBank;
        //this.ARBank.DisplayMember = "BankName";
        //this.ARBank.ValueMember = "BankID";
        this.ARBank.DataPropertyName = "BankID";

        //this.ARCurrency.DataSource = dtCurrencyType;
        //this.ARCurrency.DisplayMember = "CurrencyName";
        //this.ARCurrency.ValueMember = "CurrencyID";
        this.ARCurrency.DataPropertyName = "CurrencyID";

        //this.ARProject.DataSource = dtProject;
        //this.ARProject.DisplayMember = "ProjectID";
        //this.ARProject.ValueMember = "ProjectID";
        this.ARProject.DataPropertyName = "ProjectID";

        //this.ARExtensionType.DataSource = dtExpenseType;
        //this.ARExtensionType.DisplayMember = "ExpenseTypeName";
        //this.ARExtensionType.ValueMember = "ExpenseTypeID";
        this.ARExtensionType.DataPropertyName = "ExpenseTypeID";

        lblAddOrEdit.Text = "New Invoice";
        lblInvoiceID.Text = "";
        txtAmount.Text = "";
        cmbSupplierCode.SelectedIndex = 0;
        cmbSupplierName.SelectedIndex = 0;
        cmbProject.SelectedIndex = 0;
        cmbBank.SelectedIndex = 0;
        cmbCurrency.SelectedIndex = 0;
        cmbType.SelectedIndex = 0;
        calInvoiceDate.Value = DateTime.Now;
        chkCreditToBank.Enabled = true;
        chkCreditToBank.Checked = false;
    }
}
        private void AccountReceivable_Load(object sender, EventArgs e)
        {
            string CmdSupplier = "SELECT distinct SupplierName,SupplierCode FROM tbl_Supplier";
            sda1 = new MySqlDataAdapter(CmdSupplier, con);
            DataTable dtSuuplier = new DataTable();
            sda1.Fill(dtSuuplier);
            
            this.cmbSupplierName.DataSource = dtSuuplier;
            this.cmbSupplierName.DisplayMember = "SupplierName";
            this.cmbSupplierName.ValueMember = "SupplierCode";
            this.cmbSupplierName.SelectedIndex = 0;
            this.cmbSupplierCode.DataSource = dtSuuplier;
            this.cmbSupplierCode.DisplayMember = "SupplierCode";
            this.cmbSupplierCode.ValueMember = "SupplierName";
            this.cmbSupplierCode.SelectedIndex = 0;

            string CmdBank = "SELECT distinct BankID,BankName FROM tbl_Bank";
            sda1 = new MySqlDataAdapter(CmdBank, con);
            DataTable dtBank = new DataTable();
            sda1.Fill(dtBank);

            this.cmbBank.DataSource = dtBank;
            this.cmbBank.DisplayMember = "BankName";
            this.cmbBank.ValueMember = "BankID";

            string CmdProject = "SELECT distinct ProjectID FROM tbl_Project";
            sda1 = new MySqlDataAdapter(CmdProject, con);
            DataTable dtProject = new DataTable();
            sda1.Fill(dtProject);

            this.cmbProject.DataSource = dtProject;
            this.cmbProject.DisplayMember = "ProjectID";
            this.cmbProject.ValueMember = "ProjectID";

            string CmdExpenseType = "SELECT distinct ExpenseTypeID,ExpenseTypeName FROM tbl_ExpenseType";
            sda1 = new MySqlDataAdapter(CmdExpenseType, con);
            DataTable dtExpenseType = new DataTable();
            sda1.Fill(dtExpenseType);

            this.cmbType.DataSource = dtExpenseType;
            this.cmbType.DisplayMember = "ExpenseTypeName";
            this.cmbType.ValueMember = "ExpenseTypeID";

            string CmdCurrencyType = "SELECT distinct CurrencyName,CurrencyID FROM tbl_Currency";
            sda1 = new MySqlDataAdapter(CmdCurrencyType, con);
            DataTable dtCurrencyType = new DataTable();
            sda1.Fill(dtCurrencyType);

            this.cmbCurrency.DataSource = dtCurrencyType;
            this.cmbCurrency.DisplayMember = "CurrencyName";
            this.cmbCurrency.ValueMember = "CurrencyID";

           



            dgvAccountReceivable.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvAccountReceivable.CellClick += new DataGridViewCellEventHandler(dgvAccountReceivable_CellClick);
        }

        private void lblType_Click(object sender, EventArgs e)
        {

        }

        private void calInvoiceDate_ValueChanged(object sender, EventArgs e)
        {
            this.calDueDate.Value = calInvoiceDate.Value.AddDays(30);
        }

        private void cmbSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbSupplierName.SelectedText!= string.Empty)
                cmbSupplierCode.SelectedValue = cmbSupplierName.SelectedText;

        }

        private void cmbSupplierCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSupplierCode.SelectedText != string.Empty)
            cmbSupplierName.SelectedValue = cmbSupplierCode.SelectedText;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int i=0;
                if(chkCreditToBank.Checked)
                    i=1;
                if (string.IsNullOrWhiteSpace(lblInvoiceID.Text))
                {
                    string spname = "sp_InsertAccountReceivable";
                    string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                    MySqlConnection con = new MySqlConnection(ConString);
                    MySqlCommand cmd = new MySqlCommand(spname, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("name", cmbSupplierName.Text);
                    cmd.Parameters.AddWithValue("CODE", cmbSupplierCode.Text);
                    cmd.Parameters.AddWithValue("EXPENSETYPEID", cmbType.SelectedValue);
                    cmd.Parameters.AddWithValue("PROJECTID", cmbProject.SelectedValue);
                    cmd.Parameters.AddWithValue("BANKID", cmbBank.SelectedValue);
                    cmd.Parameters.AddWithValue("AMOUNT", txtAmount.Text);
                    cmd.Parameters.AddWithValue("INVOICEDTE", Convert.ToDateTime(calInvoiceDate.Text).ToString("yyyy-MM-dd H:mm:ss"));
                    cmd.Parameters.AddWithValue("DUEDATE", Convert.ToDateTime(calDueDate.Text).ToString("yyyy-MM-dd H:mm:ss"));
                    cmd.Parameters.AddWithValue("CURRENCYID", cmbCurrency.SelectedValue);
                    cmd.Parameters.AddWithValue("CreditToBank", i);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    string spname = "sp_UpdateAccountReceivable";
                    string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                    MySqlConnection con = new MySqlConnection(ConString);
                    MySqlCommand cmd = new MySqlCommand(spname, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("sname", cmbSupplierName.Text);
                    cmd.Parameters.AddWithValue("sCODE", cmbSupplierCode.Text);
                    cmd.Parameters.AddWithValue("iEXPENSETYPEID", cmbType.SelectedValue);
                    cmd.Parameters.AddWithValue("iPROJECTID", cmbProject.SelectedValue);
                    cmd.Parameters.AddWithValue("iBANKID", cmbBank.SelectedValue);
                    cmd.Parameters.AddWithValue("dAMOUNT", txtAmount.Text);
                    cmd.Parameters.AddWithValue("cINVOICEDATE", Convert.ToDateTime(calInvoiceDate.Text).ToString("yyyy-MM-dd H:mm:ss"));
                    cmd.Parameters.AddWithValue("cDUEDATE", Convert.ToDateTime(calDueDate.Text).ToString("yyyy-MM-dd H:mm:ss"));
                    cmd.Parameters.AddWithValue("iCURRENCYID", cmbCurrency.SelectedValue);
                    cmd.Parameters.AddWithValue("iInvoiceID", lblInvoiceID.Text.ToString());
                    cmd.Parameters.AddWithValue("iCreditToBank", i);

                    //cmd.Parameters.AddWithValue("sname", dgvAccountReceivable.Rows[e.RowIndex].Cells[1].Value.ToString());
                    //cmd.Parameters.AddWithValue("sCODE", dgvAccountReceivable.Rows[e.RowIndex].Cells[2].Value.ToString());
                    //cmd.Parameters.AddWithValue("iEXPENSETYPEID", dgvAccountReceivable.Rows[e.RowIndex].Cells[3].Value.ToString());
                    //cmd.Parameters.AddWithValue("iPROJECTID", dgvAccountReceivable.Rows[e.RowIndex].Cells[4].Value.ToString());
                    //cmd.Parameters.AddWithValue("iBANKID", dgvAccountReceivable.Rows[e.RowIndex].Cells[5].Value.ToString());
                    //cmd.Parameters.AddWithValue("dAMOUNT", dgvAccountReceivable.Rows[e.RowIndex].Cells[6].Value);
                    //cmd.Parameters.AddWithValue("cINVOICEDATE", Convert.ToDateTime(dgvAccountReceivable.Rows[e.RowIndex].Cells[7].Value).ToString("yyyy-MM-dd H:mm:ss"));
                    //cmd.Parameters.AddWithValue("cDUEDATE", Convert.ToDateTime(dgvAccountReceivable.Rows[e.RowIndex].Cells[8].Value).ToString("yyyy-MM-dd H:mm:ss"));
                    //cmd.Parameters.AddWithValue("iCURRENCYID", dgvAccountReceivable.Rows[e.RowIndex].Cells[9].Value.ToString());


                    con.Open();
                    cmd.ExecuteReader();
                    con.Close();
                }
                MessageBox.Show("Invoice saved successfully!!", "Sucess");
                lblAddOrEdit.Text = "New Invoice";
                lblInvoiceID.Text = "";
                txtAmount.Text = "";
                cmbSupplierCode.SelectedIndex = 0;
                cmbSupplierName.SelectedIndex = 0;
                cmbProject.SelectedIndex = 0;
                cmbBank.SelectedIndex = 0;
                cmbCurrency.SelectedIndex = 0;
                cmbType.SelectedIndex = 0;
                calInvoiceDate.Value = DateTime.Now;
                this.chkCreditToBank.Checked = false;
                this.chkCreditToBank.Enabled = true;

            }
            catch(Exception ex)
            {
                 MessageBox.Show("Some error has occured!!", "Error");
            }


        }

        private void lblSupplierCode_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblAddOrEdit.Text = "New Invoice";
            lblInvoiceID.Text = "";
            txtAmount.Text = "";
            cmbSupplierCode.SelectedIndex = 0;
            cmbSupplierName.SelectedIndex = 0;
            cmbProject.SelectedIndex = 0;
            cmbBank.SelectedIndex = 0;
            cmbCurrency.SelectedIndex = 0;
            cmbType.SelectedIndex = 0;
            calInvoiceDate.Value = DateTime.Now;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tblMain_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
