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
    public partial class Forecast : Form
    {
        string con = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        MySqlDataAdapter sda1;

        public Forecast()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
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

        private void cmbSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSupplierName.SelectedText != string.Empty)
                cmbSupplierCode.SelectedValue = cmbSupplierName.SelectedText;

        }

        private void cmbSupplierCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSupplierCode.SelectedText != string.Empty)
                cmbSupplierName.SelectedValue = cmbSupplierCode.SelectedText;
        }

        private void calInvoiceDate_ValueChanged(object sender, EventArgs e)
        {
            this.calDueDate.Value = calInvoiceDate.Value.AddDays(30);
        }

        private void Forecast_Load(object sender, EventArgs e)
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

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
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
                    cmd.Parameters.AddWithValue("CreditToBank", 0);
                    cmd.Parameters.AddWithValue("isForecast", 1);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                
               
                MessageBox.Show("Invoice saved successfully!!", "Sucess");
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
            catch (Exception ex)
            {
                MessageBox.Show("Some error has occured!!", "Error");
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                combobox1.Visible = false;
                cmbExpense.Visible = false;
                comboBox3.Visible = false;

                string CmdSupplier = "SELECT distinct SupplierName,SupplierCode FROM tbl_Supplier";
                sda1 = new MySqlDataAdapter(CmdSupplier, con);
                DataTable dtSuuplier = new DataTable();
                sda1.Fill(dtSuuplier);

                this.cmbExpenseSuppliername.DataSource = dtSuuplier;
                this.cmbExpenseSuppliername.DisplayMember = "SupplierName";
                this.cmbExpenseSuppliername.ValueMember = "SupplierCode";
                this.cmbExpenseSuppliername.SelectedIndex = -1;
                this.cmbExpenseSupplierCode.DataSource = dtSuuplier;
                this.cmbExpenseSupplierCode.DisplayMember = "SupplierCode";
                this.cmbExpenseSupplierCode.ValueMember = "SupplierName";
                this.cmbExpenseSupplierCode.SelectedIndex = -1;

                string CmdCurrencyType = "SELECT distinct CurrencyName,CurrencyID FROM tbl_Currency";
                sda1 = new MySqlDataAdapter(CmdCurrencyType, con);
                DataTable dtCurrencyType = new DataTable();
                sda1.Fill(dtCurrencyType);

                this.comboBox2.DataSource = dtCurrencyType;
                this.comboBox2.DisplayMember = "CurrencyName";
                this.comboBox2.ValueMember = "CurrencyID";

                string CmdSite = "SELECT distinct SiteName,SiteID FROM tbl_Site";
                sda1 = new MySqlDataAdapter(CmdSite, con);
                DataTable dtSite = new DataTable();
                sda1.Fill(dtSite);

                this.cmbSite.DataSource = dtSite;
                this.cmbSite.DisplayMember = "SiteName";
                this.cmbSite.ValueMember = "SiteID";

                string CmdType = "SELECT distinct CostCodeID,CostCodeName FROM tbl_CostCode";
                sda1 = new MySqlDataAdapter(CmdType, con);
                DataTable dtType = new DataTable();
                sda1.Fill(dtType);
                DataRow dr = dtType.NewRow();
                dr["CostCodeName"] = "--Select--";
                dr["CostCodeID"] = "0";
                dtType.Rows.Add(dr);
                this.cmbCostCode.DataSource = dtType;
                this.cmbCostCode.DisplayMember = "CostCodeName";
                this.cmbCostCode.ValueMember = "CostCodeID";
                this.cmbCostCode.SelectedValue = "0";
            }
        }

        private void cmbCostCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label8.Visible = false;
            this.comboBox3.Visible = false;
            this.comboBox3.SelectedIndex = -1;
            this.label9.Visible = false;
            this.comboBox7.Visible = false;
            this.comboBox7.SelectedIndex = -1;
            this.label10.Visible = false;
            this.label11.Visible = false;
            this.combobox1.Visible = false;
            this.combobox1.SelectedIndex = -1;
            this.cmbExpense.Visible = false;
            this.cmbExpense.SelectedIndex = -1;
            if (cmbCostCode.SelectedValue.ToString() == "1")
            {
                this.label8.Text = "Project";
                this.label8.Visible = true;
                this.cmbExpense.Visible = true;
                string cmdProject = "SELECT distinct ProjectID,ProjctName FROM tbl_Project";
                sda1 = new MySqlDataAdapter(cmdProject, con);
                DataTable dtProject = new DataTable();
                sda1.Fill(dtProject);


                this.cmbExpense.DataSource = dtProject;
                this.cmbExpense.ValueMember = "ProjectID";
                this.cmbExpense.DisplayMember = "ProjctName";
            }
            else if (cmbCostCode.SelectedValue.ToString() == "2")
            {
                this.label8.Text = "Department";
                this.label8.Visible = true;
                this.cmbExpense.Visible = true;
                string cmdProject = "SELECT distinct DepartmentID,DepartmentName FROM tbl_Department";
                sda1 = new MySqlDataAdapter(cmdProject, con);
                DataTable dtProject = new DataTable();
                sda1.Fill(dtProject);

                this.cmbExpense.DataSource = dtProject;
                this.cmbExpense.ValueMember = "DepartmentID";
                this.cmbExpense.DisplayMember = "DepartmentName";
            }
            else if (cmbCostCode.SelectedValue.ToString() == "3")
            {

                this.label8.Text = "Rebill";
                this.label8.Visible = true;
                this.cmbExpense.Visible = true;
                string cmd = "SELECT distinct RebillID,RebillName FROM tbl_Rebill";
                sda1 = new MySqlDataAdapter(cmd, con);
                DataTable dt = new DataTable();
                sda1.Fill(dt);

                this.cmbExpense.DataSource = dt;
                this.cmbExpense.ValueMember = "RebillID";
                this.cmbExpense.DisplayMember = "RebillName";

                this.label9.Text = "CBS ";
                this.label9.Visible = true;
                this.combobox1.Visible = true;
                string cmd2 = "SELECT distinct CBSID,CBSName FROM tbl_CBS ";
                sda1 = new MySqlDataAdapter(cmd2, con);
                DataTable dt2 = new DataTable();
                sda1.Fill(dt2);

                this.combobox1.DataSource = dt2;
                this.combobox1.ValueMember = "CBSID";
                this.combobox1.DisplayMember = "CBSName";

                this.label10.Text = "Reference ";
                this.label10.Visible = true;
                this.comboBox7.Visible = true;
                string cmd3 = "SELECT distinct ReferenceType FROM tbl_IPEXOPEX ";
                sda1 = new MySqlDataAdapter(cmd3, con);
                DataTable dt3 = new DataTable();
                sda1.Fill(dt3);

                this.comboBox7.DataSource = dt3;
                this.comboBox7.ValueMember = "ReferenceType";
                this.comboBox7.DisplayMember = "ReferenceType";
                this.comboBox7.SelectedIndex = -1;

            }
            
        }
        private void cmbExpense_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCostCode.SelectedValue.ToString() == "2")
            {
                this.label9.Visible = false;
                combobox1.SelectedIndex = -1;
                combobox1.Visible = false;
                if (cmbExpense.Text == "Other corporate expenses")
                {
                    this.label9.Text = "Other corporate expenses";
                    this.label9.Visible = true;
                    this.combobox1.Visible = true;
                    string cmd = "SELECT distinct ICPID,ICPName FROM tbl_ICP";
                    sda1 = new MySqlDataAdapter(cmd, con);
                    DataTable dt = new DataTable();
                    sda1.Fill(dt);

                    this.combobox1.DataSource = dt;
                    this.combobox1.ValueMember = "ICPID";
                    this.combobox1.DisplayMember = "ICPName";
                }
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox7.SelectedIndex == -1)
            {
                this.label11.Visible = false;
                this.comboBox3.Visible = false;
                this.comboBox3.SelectedIndex = -1;
            }
            else if (comboBox7.Text == "CAPEX")
            {
                this.label11.Text = "CAPEX ";
                this.label11.Visible = true;
                this.comboBox3.Visible = true;
                string cmd = "SELECT distinct IPEXOPEXID,IPEXOPEXNAME FROM tbl_IPEXOPEX where ReferenceType='CAPEX'";
                sda1 = new MySqlDataAdapter(cmd, con);
                DataTable dt = new DataTable();
                sda1.Fill(dt);

                this.comboBox3.DataSource = dt;
                this.comboBox3.ValueMember = "IPEXOPEXID";
                this.comboBox3.DisplayMember = "IPEXOPEXNAME";
            }
            else if (comboBox7.Text == "OPEX")
            {
                this.label11.Text = "OPEX ";
                this.label11.Visible = true;
                this.comboBox3.Visible = true;
                string cmd = "SELECT distinct IPEXOPEXID,IPEXOPEXNAME FROM tbl_IPEXOPEX where ReferenceType='OPEX'";
                sda1 = new MySqlDataAdapter(cmd, con);
                DataTable dt = new DataTable();
                sda1.Fill(dt);

                this.comboBox3.DataSource = dt;
                this.comboBox3.ValueMember = "IPEXOPEXID";
                this.comboBox3.DisplayMember = "IPEXOPEXNAME";
            }

        }

        private void btnExpenseSave_Click(object sender, EventArgs e)
        {
            string spname = "sp_InsertAFP";
            string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            MySqlConnection con = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(spname, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("supname", cmbExpenseSuppliername.Text);
            cmd.Parameters.AddWithValue("supCODE", cmbExpenseSupplierCode.Text);
            cmd.Parameters.AddWithValue("currentDate", Convert.ToDateTime(calDate.Text).ToString("yyyy-MM-dd H:mm:ss"));
            cmd.Parameters.AddWithValue("DUEDATE", Convert.ToDateTime(calPaymentDueDate.Text).ToString("yyyy-MM-dd H:mm:ss"));
            cmd.Parameters.AddWithValue("AMOUNT", txtExpenseAmount.Text);
            cmd.Parameters.AddWithValue("CURRENCYID", cmbCurrency.SelectedValue);
            cmd.Parameters.AddWithValue("SITEID", cmbSite.SelectedValue);
            cmd.Parameters.AddWithValue("PAYMENTPURPOSE", txtPaymentPurpose.Text);
            cmd.Parameters.AddWithValue("PONUMBER", txtPONumber.Text);
            cmd.Parameters.AddWithValue("POAMOUNT", txtPOAmount.Text);
            cmd.Parameters.AddWithValue("INVOICEDATE", Convert.ToDateTime(calExpenseInvoiceDate.Text).ToString("yyyy-MM-dd H:mm:ss"));
            cmd.Parameters.AddWithValue("RECEIVEDDATE", Convert.ToDateTime(calRecievedDate.Text).ToString("yyyy-MM-dd H:mm:ss"));
            cmd.Parameters.AddWithValue("COSTCODEID", cmbCostCode.SelectedValue);
            cmd.Parameters.AddWithValue("CMB1", cmbExpense.SelectedValue);
            cmd.Parameters.AddWithValue("retAPID", MySqlDbType.Int16);
            cmd.Parameters["retAPID"].Direction = ParameterDirection.Output;

            cmd.Parameters.AddWithValue("CMB2", combobox1.SelectedValue);
            cmd.Parameters.AddWithValue("CMB4", comboBox3.Text);
            cmd.Parameters.AddWithValue("isForecast", 1);

            con.Open();
            cmd.ExecuteNonQuery();
            int iAPID = (int)cmd.Parameters["retAPID"].Value;
            con.Close();

        }
    }
}
