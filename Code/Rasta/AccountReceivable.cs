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

            string CmdDetails = "SELECT * from tbl_AccountReceivable";
            sda1 = new MySqlDataAdapter(CmdDetails, con);
            DataTable dtDetails = new DataTable();
            sda1.Fill(dtDetails);
            dgvAccountReceivable.AutoGenerateColumns = false;
            dgvAccountReceivable.DataSource = dtDetails;
            dgvAccountReceivable.Columns["InvoiceID"].Visible = false;

            this.ARDueDate.DataPropertyName = "Duedate";
            this.ARInvoiceDate.DataPropertyName = "InvoiceDate";
            this.ARAmount.DataPropertyName = "Amount";
            this.InvoiceID.DataPropertyName = "InvoiceID";

            this.ARSupplierName.DataSource = dtSuuplier;
            this.ARSupplierName.DisplayMember = "SupplierName";
            this.ARSupplierName.ValueMember = "SupplierName";
            this.ARSupplierName.DataPropertyName = "SupplierName";

            this.ARSupplierCode.DataSource = dtSuuplier;
            this.ARSupplierCode.DisplayMember = "SupplierCode";
            this.ARSupplierCode.ValueMember = "SupplierCode";
            this.ARSupplierCode.DataPropertyName = "SupplierCode";

            this.ARBank.DataSource = dtBank;
            this.ARBank.DisplayMember = "BankName";
            this.ARBank.ValueMember = "BankID";
            this.ARBank.DataPropertyName = "BankID";

            this.ARCurrency.DataSource = dtCurrencyType;
            this.ARCurrency.DisplayMember = "CurrencyName";
            this.ARCurrency.ValueMember = "CurrencyID";
            this.ARCurrency.DataPropertyName = "CurrencyID";

            this.ARProject.DataSource = dtProject;
            this.ARProject.DisplayMember = "ProjectID";
            this.ARProject.ValueMember = "ProjectID";
            this.ARProject.DataPropertyName = "ProjectID";

            this.ARExtensionType.DataSource = dtExpenseType;
            this.ARExtensionType.DisplayMember = "ExpenseTypeName";
            this.ARExtensionType.ValueMember = "ExpenseTypeID";
            this.ARExtensionType.DataPropertyName = "ExpenseTypeID";

            dgvAccountReceivable.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvAccountReceivable.CellClick += new DataGridViewCellEventHandler(dgvAccountReceivable_CellClick);

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
                string spname = "sp_UpdateAccountReceivable";
                string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                MySqlConnection con = new MySqlConnection(ConString);
                MySqlCommand cmd = new MySqlCommand(spname, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("sname", dgvAccountReceivable.Rows[e.RowIndex].Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("sCODE", dgvAccountReceivable.Rows[e.RowIndex].Cells[2].Value.ToString());
                cmd.Parameters.AddWithValue("iEXPENSETYPEID", dgvAccountReceivable.Rows[e.RowIndex].Cells[3].Value.ToString());
                cmd.Parameters.AddWithValue("iPROJECTID", dgvAccountReceivable.Rows[e.RowIndex].Cells[4].Value.ToString());
                cmd.Parameters.AddWithValue("iBANKID", dgvAccountReceivable.Rows[e.RowIndex].Cells[5].Value.ToString());
                cmd.Parameters.AddWithValue("dAMOUNT", dgvAccountReceivable.Rows[e.RowIndex].Cells[6].Value);
                cmd.Parameters.AddWithValue("cINVOICEDATE", Convert.ToDateTime(dgvAccountReceivable.Rows[e.RowIndex].Cells[7].Value).ToString("yyyy-MM-dd H:mm:ss"));
                cmd.Parameters.AddWithValue("cDUEDATE", Convert.ToDateTime(dgvAccountReceivable.Rows[e.RowIndex].Cells[8].Value).ToString("yyyy-MM-dd H:mm:ss"));
                cmd.Parameters.AddWithValue("iCURRENCYID",dgvAccountReceivable.Rows[e.RowIndex].Cells[9].Value.ToString());
                cmd.Parameters.AddWithValue("iInvoiceID", dgvAccountReceivable.Rows[e.RowIndex].Cells[0].Value.ToString());

                con.Open();
                cmd.ExecuteReader();
                con.Close();

            }
            else
            {
                dgv.EditMode = DataGridViewEditMode.EditOnEnter;
                dgv.BeginEdit(false);
            }

        }

        private void AccountReceivable_Load(object sender, EventArgs e)
        {

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
            cmd.Parameters.AddWithValue("AMOUNT",  txtAmount.Text );
            cmd.Parameters.AddWithValue("INVOICEDTE", Convert.ToDateTime(calInvoiceDate.Text).ToString("yyyy-MM-dd H:mm:ss"));
            cmd.Parameters.AddWithValue("DUEDATE", Convert.ToDateTime(calDueDate.Text).ToString("yyyy-MM-dd H:mm:ss"));
            cmd.Parameters.AddWithValue("CURRENCYID", cmbCurrency.SelectedValue);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


        }

        private void lblSupplierCode_Click(object sender, EventArgs e)
        {

        }

       
    }
}
