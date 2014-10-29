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
    public partial class Admin : Form
    {
        string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

        public Admin()
        {
            InitializeComponent();


        }

        private void DGVCurrency_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = ((DataGridView)sender);
            if (e.ColumnIndex < 0)
            {
                dgv.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                dgv.Focus();
                dgv.EndEdit();
            }
            else if (e.ColumnIndex == 4)
            {
                string query = "DELETE FROM tbl_Currency " +
                "WHERE CurrencyID =" + dgvCurrency.Rows[e.RowIndex].Cells[1].Value.ToString() + " ";
                string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                MySqlConnection con = new MySqlConnection(ConString);

                MySqlDataAdapter sda = new MySqlDataAdapter(query, con);
                DataTable dtCurrency = new DataTable();
                sda.Fill(dtCurrency);

                dgvCurrency.Rows.Remove(dgvCurrency.Rows[e.RowIndex]);
            }
            else if (e.ColumnIndex == 3)
            {
                try
                {
                    string query = "UPDATE tbl_Currency SET " +
                   "CurrencyName = '" + dgvCurrency.Rows[e.RowIndex].Cells[0].Value.ToString() + "'  " +
                   "WHERE CurrencyID =" + dgvCurrency.Rows[e.RowIndex].Cells[1].Value.ToString() + "";
                    string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                    MySqlConnection con = new MySqlConnection(ConString);

                    MySqlDataAdapter sda = new MySqlDataAdapter(query, con);
                    DataTable dtCurrency = new DataTable();
                    sda.Fill(dtCurrency);
                    query = "UPDATE tbl_CurrencyExchange SET " +
                   "ExchangeRateinUSD = '" + dgvCurrency.Rows[e.RowIndex].Cells[2].Value.ToString() + "'  " +
                   "WHERE CurrencyID =" + dgvCurrency.Rows[e.RowIndex].Cells[1].Value.ToString() + "";
                     sda = new MySqlDataAdapter(query, con);
                    DataTable dtCurrency1 = new DataTable();
                    sda.Fill(dtCurrency1);
                    MessageBox.Show("Information saved successfully!!", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Some Error has occured!!", "Error");

                }

            }
            else
            {
                dgv.EditMode = DataGridViewEditMode.EditOnEnter;
                dgv.BeginEdit(false);
            }

        }

        private void DGVSite_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = ((DataGridView)sender);
            if (e.ColumnIndex < 0)
            {
                dgv.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                dgv.Focus();
                dgv.EndEdit();
            }
            else if (e.ColumnIndex == 3)
            {
                string query = "DELETE FROM tbl_Site " +
                "WHERE SiteID =" + dgvSite.Rows[e.RowIndex].Cells[1].Value.ToString() + " ";
                MySqlConnection con = new MySqlConnection(ConString);
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                dgvSite.Rows.Remove(dgvSite.Rows[e.RowIndex]);
            }
            else if (e.ColumnIndex == 2)
            {
                try
                {
                    string query = "UPDATE tbl_Site SET " +
                   "SiteName = '" + dgvSite.Rows[e.RowIndex].Cells[0].Value.ToString() + "'  " +
                   "WHERE SiteID =" + dgvSite.Rows[e.RowIndex].Cells[1].Value.ToString() + "";
                    MySqlConnection con = new MySqlConnection(ConString);
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Information saved successfully!!", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Some Error has occured!!", "Error");

                }

            }
            else
            {
                dgv.EditMode = DataGridViewEditMode.EditOnEnter;
                dgv.BeginEdit(false);
            }

        }

        private void DGVExpenseType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = ((DataGridView)sender);
            if (e.ColumnIndex < 0)
            {
                dgv.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                dgv.Focus();
                dgv.EndEdit();
            }
            else if (e.ColumnIndex == 3)
            {
                string query = "DELETE FROM tbl_ExpenseType " +
                "WHERE ExpenseTypeID =" + dgvExpenseType.Rows[e.RowIndex].Cells[1].Value.ToString() + " ";
                MySqlConnection con = new MySqlConnection(ConString);
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                dgvExpenseType.Rows.Remove(dgvExpenseType.Rows[e.RowIndex]);
            }
            else if (e.ColumnIndex == 2)
            {
                try
                {
                string query = "UPDATE tbl_ExpenseType SET " +
               "ExpenseTypeName = '" + dgvExpenseType.Rows[e.RowIndex].Cells[0].Value.ToString() + "'  " +
               "WHERE ExpenseTypeID =" + dgvExpenseType.Rows[e.RowIndex].Cells[1].Value.ToString() + "";
                MySqlConnection con = new MySqlConnection(ConString);
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Information saved successfully!!", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Some Error has occured!!", "Error");

                }

            }
            else
            {
                dgv.EditMode = DataGridViewEditMode.EditOnEnter;
                dgv.BeginEdit(false);
            }

        }

        private void DGVProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = ((DataGridView)sender);
            if (e.ColumnIndex < 0)
            {
                dgv.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                dgv.Focus();
                dgv.EndEdit();
            }
            else if (e.ColumnIndex == 7)
            {
                string query = "DELETE FROM tbl_Project " +
                "WHERE ProjectID =" + dgvProject.Rows[e.RowIndex].Cells[2].Value.ToString() + " ";
                MySqlConnection con = new MySqlConnection(ConString);
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                dgvProject.Rows.Remove(dgvProject.Rows[e.RowIndex]);
            }
            else if (e.ColumnIndex == 6)
            {
                try
                {
                    string query = "UPDATE tbl_Project SET " +
                   "ProjectTypeID = '" + dgvProject.Rows[e.RowIndex].Cells[1].Value.ToString() + "' , " +
                   "AmountTillDate = '" + dgvProject.Rows[e.RowIndex].Cells[3].Value.ToString() + "' , " +
                   "RemainingAmount = '" + dgvProject.Rows[e.RowIndex].Cells[4].Value.ToString() + "' , " +
                   "TotalAmount = '" + dgvProject.Rows[e.RowIndex].Cells[5].Value.ToString() + "'  " +
                   "WHERE ProjectID =" + dgvProject.Rows[e.RowIndex].Cells[2].Value.ToString() + "";
                    MySqlConnection con = new MySqlConnection(ConString);
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Information saved successfully!!", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Some Error has occured!!", "Error");

                }
            }
            else
            {
                dgv.EditMode = DataGridViewEditMode.EditOnEnter;
                dgv.BeginEdit(false);
            }

        }

        private void DGVBank_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = ((DataGridView)sender);
            if (e.ColumnIndex < 0)
            {
                dgv.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                dgv.Focus();
                dgv.EndEdit();
            }
            else if (e.ColumnIndex == 11)
            {
                string query = "DELETE FROM tbl_Bank " +
                "WHERE BankID =" + dgvBank.Rows[e.RowIndex].Cells[1].Value.ToString() + " ";
                MySqlConnection con = new MySqlConnection(ConString);
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                dgvBank.Rows.Remove(dgvBank.Rows[e.RowIndex]);
            }
            else if (e.ColumnIndex == 10)
            {
              try
              {string query = "UPDATE tbl_Bank SET " +
               "BankName = '" + dgvBank.Rows[e.RowIndex].Cells[0].Value.ToString() + "' , " +
               "BankCode = '" + dgvBank.Rows[e.RowIndex].Cells[2].Value.ToString() + "' , " +
               "SwiftCode = '" + dgvBank.Rows[e.RowIndex].Cells[4].Value.ToString() + "' , " +
               "IBAN = '" + dgvBank.Rows[e.RowIndex].Cells[5].Value.ToString() + "' , " +
               "accountnumber = '" + dgvBank.Rows[e.RowIndex].Cells[8].Value.ToString() + "' , " +
               "Disciplineid = '" + dgvBank.Rows[e.RowIndex].Cells[7].Value.ToString() + "' , " +
               "Country = '" + dgvBank.Rows[e.RowIndex].Cells[6].Value.ToString() + "'  ," +
               "cash = '" + dgvBank.Rows[e.RowIndex].Cells[9].Value.ToString() + "'  " +
               "WHERE BankID =" + dgvBank.Rows[e.RowIndex].Cells[1].Value.ToString() + "";
                MySqlConnection con = new MySqlConnection(ConString);
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Information saved successfully!!", "Success");
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Some Error has occured!!", "Error");

              }
            }
            else
            {
                dgv.EditMode = DataGridViewEditMode.EditOnEnter;
                dgv.BeginEdit(false);
            }

        }

        private void DGVSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = ((DataGridView)sender);
            if (e.ColumnIndex < 0)
            {
                dgv.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                dgv.Focus();
                dgv.EndEdit();
            }
            else if (e.ColumnIndex == 8)
            {
                string query = "DELETE FROM tbl_Supplier " +
                "WHERE SupplierID =" + dgvSupplier.Rows[e.RowIndex].Cells[1].Value.ToString() + " ";
                MySqlConnection con = new MySqlConnection(ConString);
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                dgvSupplier.Rows.Remove(dgvSupplier.Rows[e.RowIndex]);
            }
            else if (e.ColumnIndex == 7)
            {
                try
                {
                string query = "UPDATE tbl_Supplier SET " +
               "SupplierName = '" + dgvSupplier.Rows[e.RowIndex].Cells[0].Value.ToString() + "' , " +
               "SupplierCode = '" + dgvSupplier.Rows[e.RowIndex].Cells[2].Value.ToString() + "' , " +
               "BankID = '" + dgvSupplier.Rows[e.RowIndex].Cells[3].Value.ToString() + "' , " +
               "SupplierTypeID = '" + dgvSupplier.Rows[e.RowIndex].Cells[4].Value.ToString() + "' , " +
               "Address = '" + dgvSupplier.Rows[e.RowIndex].Cells[5].Value.ToString() + "',  " +
               "Country = '" + dgvSupplier.Rows[e.RowIndex].Cells[6].Value.ToString() + "'  " +
               "WHERE SupplierID =" + dgvSupplier.Rows[e.RowIndex].Cells[1].Value.ToString() + "";
                MySqlConnection con = new MySqlConnection(ConString);
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Information saved successfully!!", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Some Error has occured!!", "Error");

                }
            }
            else
            {
                dgv.EditMode = DataGridViewEditMode.EditOnEnter;
                dgv.BeginEdit(false);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.splitContainer1.Panel2Collapsed = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.splitContainer2.Panel2Collapsed = false;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.splitContainer3.Panel2Collapsed = false;

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.splitContainer4.Panel2Collapsed = false;

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.splitContainer5.Panel2Collapsed = false;
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.splitContainer8.Panel2Collapsed = false;
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.splitContainer6.Panel2Collapsed = false;
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.splitContainer7.Panel2Collapsed = false;
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            MySqlConnection con = new MySqlConnection(ConString);
            this.splitContainer9.Panel2Collapsed = false;
            string cmdbank1 = "SELECT bankID ,	bankName FROM Tbl_bank";
            MySqlDataAdapter sda1 = new MySqlDataAdapter(cmdbank1, con);
            DataTable dtBankEditcash = new DataTable();
            sda1.Fill(dtBankEditcash);
            cmbEditBankName.DataSource = dtBankEditcash;
            cmbEditBankName.DisplayMember = "BankName";
            cmbEditBankName.ValueMember = "BankID";
            cmbEditBankName.SelectedIndex = -1;

        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            try
            {
            List<string> selectedFields = new List<string>();
            foreach (DataRowView selecteditem in lstPrivilege.SelectedItems)
            {
                selectedFields.Add(selecteditem["PrivilegeID"].ToString());
            }
            string privileges = string.Join(",", selectedFields.ToArray());
            string spname = "sp_insertusers";
            string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            MySqlConnection con = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(spname, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("name", txtName.Text);
            cmd.Parameters.AddWithValue("password", txtPassWord.Text);
            cmd.Parameters.AddWithValue("privileges", privileges);
            cmd.Parameters.AddWithValue("companyRole", txtCompanyRole.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("User saved successfully!!", "Sucess Message");
            txtCompanyRole.Text = "";
            txtPassWord.Text = "";
            txtName.Text = "";
            lstPrivilege.ClearSelected();
            string CmdString = "SELECT U.USERID as UserID,U.USERNAME as UserName,U.PASSWORD as Password,P.PRIVILEGEID as Privilege,P.PRIVILEGEID as PrivilegeID,U.companyRole FROM RASTA.tbl_userprivilege UP " +
                                "LEFT JOIN RASTA.tbl_users U ON U.USERID=UP.UserID " +
                                "LEFT JOIN RASTA.tbl_privilege P ON P.PRIVILEGEID=UP.PRIVILEGEID order by U.USERNAME";
            MySqlDataAdapter sda1 = new MySqlDataAdapter(CmdString, con);
            DataTable dtUserDetails = new DataTable();
            sda1.Fill(dtUserDetails);
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = dtUserDetails;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error has occured!!", "Error");
            }



        }

        private void btnCurrencySave_Click(object sender, EventArgs e)
        {
            try
            {
            string spname = "insert into rasta.tbl_currency(CurrencyName) values('" + txtCurrency.Text + "')";
            MySqlConnection con = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(spname, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            spname = "insert into rasta.tbl_CurrencyExchange(currencyid,ExchangeRateinUSD) values((select max(currencyid) from tbl_currency),'" + txtExchangeRate.Text + "')";
            MySqlCommand cmd1 = new MySqlCommand(spname, con);
            cmd1.CommandType = CommandType.Text;
            con.Open();
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Currency saved successfully!!", "Sucess Message");
            txtCurrency.Text = "";
            txtExchangeRate.Text = "";
            string CmdString2 = "SELECT c.CurrencyName,c.CurrencyID, ce.ExchangeRateinUSD FROM tbl_Currency c left join rasta.tbl_CurrencyExchange ce on ce.currencyid=c.currencyid";
            MySqlDataAdapter sda1 = new MySqlDataAdapter(CmdString2, con);
            DataTable dtCurrency = new DataTable();
            sda1.Fill(dtCurrency);
            dgvCurrency.AutoGenerateColumns = false;
            dgvCurrency.DataSource = dtCurrency;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error has occured!!", "Error");
            }

        }

        private void btnSaveSite_Click(object sender, EventArgs e)
        {
            try
            {
            string spname = "insert into rasta.tbl_Site(SiteName) values('" + txtSite.Text + "')";
            MySqlConnection con = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(spname, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Site saved successfully!!", "Sucess Message");
            txtSite.Text = "";
            string cmdSite = "SELECT SiteName,SiteID FROM tbl_Site";
            MySqlDataAdapter sda1 = new MySqlDataAdapter(cmdSite, con);
            DataTable dtSite = new DataTable();
            sda1.Fill(dtSite);
            dgvSite.AutoGenerateColumns = false;
            dgvSite.DataSource = dtSite;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error has occured!!", "Error");
            }

        }

        private void btnExpenseTypeSave_Click(object sender, EventArgs e)
        {
            try
            {
            string spname = "insert into rasta.tbl_ExpenseType(ExpenseTypeName) values('" + txtExpenseType.Text + "')";
            MySqlConnection con = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(spname, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Expense Type saved successfully!!", "Sucess Message");
            txtExpenseType.Text = "";
            string cmdExpenseType = "SELECT ExpenseTypeName,ExpenseTypeID FROM tbl_ExpenseType";
            MySqlDataAdapter sda1 = new MySqlDataAdapter(cmdExpenseType, con);
            DataTable dtExpenseType = new DataTable();
            sda1.Fill(dtExpenseType);
            dgvExpenseType.AutoGenerateColumns = false;
            dgvExpenseType.DataSource = dtExpenseType;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error has occured!!", "Error");
            }

        }

        private void btnProjectSave_Click(object sender, EventArgs e)
        {
            try
            {
            string spname = "insert into rasta.tbl_Project(ProjectTypeID,AmountTillDate,RemainingAmount,TotalAmount,projctname) values(" +
                "'" + cmbProjectType.SelectedValue + "'," + txtAmountTillDate.Text + "," + txtAmountDue.Text + "," + txtTotalAmount.Text + ",'" + txtProjectName.Text + "')";
            MySqlConnection con = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(spname, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Project saved successfully!!", "Sucess Message");
            txtAmountTillDate.Text = "";
            txtAmountDue.Text = "";
            txtTotalAmount.Text = "";
            cmbProjectType.SelectedIndex = 0;
            string cmdProject = "SELECT PT.ProjectTypeID as ProjectType,P.ProjectID as ProjectID,P.AmountTillDate as AmountTillDate,RemainingAmount as RemainingAmount,TotalAmount as TotalAmount,p.projctname " +
            "FROM tbl_Project P LEFT JOIN tbl_ProjectTYpe PT on P.ProjectTYpeID=PT.ProjectTypeID";
            MySqlDataAdapter sda1 = new MySqlDataAdapter(cmdProject, con);
            DataTable dtProject = new DataTable();
            sda1.Fill(dtProject);
            dgvProject.AutoGenerateColumns = false;
            dgvProject.DataSource = dtProject;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error has occured!!", "Error");
            }

        }

        private void btnBankSave_Click(object sender, EventArgs e)
        {
            try
            {
            string spname = "insert into rasta.tbl_Bank(BankName,BankCode,CurrencyID,IBAN,SwiftCode,Country,accountNumber,Disciplineid,cash) values(" +
                "'" + txtBankName.Text + "','" + txtBankCode.Text + "'," + cmbCurrencyAccepted.SelectedValue + ",'" + txtIBAN.Text + "','" + txtSwiftCode.Text + "','" + txtCountry.Text + "','" + txtAccountNumber.Text + "','" + cmbDiscipline.SelectedValue + "','" + txtCash.Text + "')";
            MySqlConnection con = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(spname, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Bank saved successfully!!", "Sucess Message");
            txtBankName.Text = "";
            txtBankCode.Text = "";
            txtIBAN.Text = "";
            cmbCurrencyAccepted.SelectedIndex = 0;
            txtSwiftCode.Text = "";
            txtCountry.Text = "";
            txtAccountNumber.Text = "";
            cmbDiscipline.SelectedIndex = 0;
            txtCash.Text = "";
            string cmdBank = "SELECT BankID,BankName, BankCode,IBAN,SwiftCode,Country,CurrencyID,accountNumber,Disciplineid,cash FROM Tbl_Bank";
            MySqlDataAdapter sda1 = new MySqlDataAdapter(cmdBank, con);
            DataTable dtBank = new DataTable();
            sda1.Fill(dtBank);
            dgvBank.AutoGenerateColumns = false;
            dgvBank.DataSource = dtBank;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error has occured!!", "Error");
            }

        }

        private void btnSupplierSave_Click(object sender, EventArgs e)
        {
            try
            {
            string spname = "insert into rasta.tbl_Supplier(SupplierName,SupplierCode,BankID,SupplierTypeID,Address,Country) values(" +
                            "'" + txtSupplierName.Text + "','" + txtSupplierCode.Text + "'," + cmbSupplierBank.SelectedValue + ",'" + cmbSupplierType.SelectedValue + "','" + txtSupplierAddress.Text + "','" + txtSupplerCountry.Text + "')";
            MySqlConnection con = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(spname, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Supplier saved successfully!!", "Sucess Message");
            txtSupplierName.Text = "";
            txtSupplierCode.Text = "";
            cmbSupplierType.SelectedIndex = 0;
            cmbSupplierBank.SelectedIndex = 0;
            txtSupplierAddress.Text = "";
            txtSupplerCountry.Text = "";
            string cmdSupplier = "SELECT SupplierID ,	SupplierName ,	SupplierCode,	BankID ,SupplierTypeID,	Address,Country FROM Tbl_Supplier";
            MySqlDataAdapter sda1 = new MySqlDataAdapter(cmdSupplier, con);
            DataTable dtSupplier = new DataTable();
            sda1.Fill(dtSupplier);
            dgvSupplier.AutoGenerateColumns = false;
            dgvSupplier.DataSource = dtSupplier;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error has occured!!", "Error");
            }

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            MySqlConnection con = new MySqlConnection(ConString);
            string CmdString = "SELECT U.USERID as UserID,U.USERNAME as UserName,U.PASSWORD as Password,P.PRIVILEGEID as Privilege,P.PRIVILEGEID as PrivilegeID,U.companyRole FROM RASTA.tbl_userprivilege UP " +
                                "LEFT JOIN RASTA.tbl_users U ON U.USERID=UP.UserID " +
                                "LEFT JOIN RASTA.tbl_privilege P ON P.PRIVILEGEID=UP.PRIVILEGEID order by U.USERNAME";
            MySqlDataAdapter sda1 = new MySqlDataAdapter(CmdString, con);
            DataTable dtUserDetails = new DataTable();
            sda1.Fill(dtUserDetails);
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = dtUserDetails;

            string CmdString1 = "SELECT distinct PrivilegeName,PrivilegeID FROM tbl_Privilege";
            sda1 = new MySqlDataAdapter(CmdString1, con);
            DataTable dtUserDetails1 = new DataTable();
            sda1.Fill(dtUserDetails1);

            this.Privilege.DataSource = dtUserDetails1;
            this.Privilege.DisplayMember = "PrivilegeName";
            this.Privilege.ValueMember = "PrivilegeID";
            this.Privilege.DataPropertyName = "Privilege";



            this.PrivilegeOld.DataPropertyName = "PrivilegeID";

            this.UserID.DataPropertyName = "UserID";
            this.UserName.DataPropertyName = "UserName";
            this.PassWord.DataPropertyName = "PassWord";

            this.lstPrivilege.DataSource = dtUserDetails1;
            this.lstPrivilege.DisplayMember = "PrivilegeName";
            this.lstPrivilege.ValueMember = "PrivilegeID";
            this.CompanyRole.DataPropertyName = "companyRole";
            dataGridView1.Columns["UserID"].Visible = false;
            dataGridView1.Columns["PrivilegeOld"].Visible = false;

            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView1.CellClick += new DataGridViewCellEventHandler(DGV_CellClick);


            //currency
            string CmdString2 = "SELECT c.CurrencyName,c.currencyid,ce.ExchangeRateinUSD FROM tbl_Currency c left join rasta.tbl_CurrencyExchange ce on ce.currencyid=c.currencyid";
            sda1 = new MySqlDataAdapter(CmdString2, con);
            DataTable dtCurrency = new DataTable();
            sda1.Fill(dtCurrency);
            dgvCurrency.AutoGenerateColumns = false;
            dgvCurrency.DataSource = dtCurrency;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CurrencyName";
            this.ExchangeRateinUSD.DataPropertyName = "ExchangeRateinUSD";
            this.currencyID.DataPropertyName = "currencyid";
            dgvCurrency.Columns["currencyID"].Visible = false;

            dgvCurrency.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvCurrency.CellClick += new DataGridViewCellEventHandler(DGVCurrency_CellClick);

            //Site
            string cmdSite = "SELECT SiteName,SiteID FROM tbl_Site";
            sda1 = new MySqlDataAdapter(cmdSite, con);
            DataTable dtSite = new DataTable();
            sda1.Fill(dtSite);
            dgvSite.AutoGenerateColumns = false;
            dgvSite.DataSource = dtSite;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SiteName";
            this.SiteID.DataPropertyName = "SiteID";

            dgvSite.Columns["SiteID"].Visible = false;
            dgvSite.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvSite.CellClick += new DataGridViewCellEventHandler(DGVSite_CellClick);

            //ExpenseType
            string cmdExpenseType = "SELECT ExpenseTypeName,ExpenseTypeID FROM tbl_ExpenseType";
            sda1 = new MySqlDataAdapter(cmdExpenseType, con);
            DataTable dtExpenseType = new DataTable();
            sda1.Fill(dtExpenseType);
            dgvExpenseType.AutoGenerateColumns = false;
            dgvExpenseType.DataSource = dtExpenseType;
            this.ExpenseType.DataPropertyName = "ExpenseTypeName";
            this.ExpenseTypeID.DataPropertyName = "ExpenseTypeID";
            dgvExpenseType.Columns["ExpenseTypeID"].Visible = false;
            dgvExpenseType.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvExpenseType.CellClick += new DataGridViewCellEventHandler(DGVExpenseType_CellClick);

            //Approval
            string cmdApprovers = "SELECT disciplineid,userid,siteid,disciplineid as disciplineOld,userid as useridOld,siteid as siteidOld FROM tbl_UserDiscipline";
            sda1 = new MySqlDataAdapter(cmdApprovers, con);
            DataTable dtApprover = new DataTable();
            sda1.Fill(dtApprover);
            dgvApprover.AutoGenerateColumns = false;
            dgvApprover.DataSource = dtApprover;
            dgvApprover.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvApprover.CellClick += new DataGridViewCellEventHandler(DGVApprover_CellClick);

            string cmddisciplines = "SELECT disciplineid,disciplinename FROM tbl_Discipline";
            sda1 = new MySqlDataAdapter(cmddisciplines, con);
            DataTable dtdisciplines = new DataTable();
            sda1.Fill(dtdisciplines);
            department.DataSource = dtdisciplines;
            department.ValueMember = "disciplineid";
            department.DisplayMember = "disciplinename";
            department.DataPropertyName = "disciplineid";
            cmbDepartment.DataSource = dtdisciplines;
            cmbDepartment.ValueMember = "disciplineid";
            cmbDepartment.DisplayMember = "disciplinename";
            DataTable dtdisciplinesOld = new DataTable();
            sda1.Fill(dtdisciplinesOld);
            disciplineOld.DataSource = dtdisciplinesOld;
            disciplineOld.ValueMember = "disciplineid";
            disciplineOld.DisplayMember = "disciplinename";
            disciplineOld.DataPropertyName = "disciplineOld";

            string cmduser = "SELECT username,userid FROM tbl_Users";
            sda1 = new MySqlDataAdapter(cmduser, con);
            DataTable dtuser = new DataTable();
            sda1.Fill(dtuser);
            approver.DataSource = dtuser;
            approver.ValueMember = "userid";
            approver.DisplayMember = "username";
            approver.DataPropertyName = "userid";
            cmbApprover.DataSource = dtuser;
            cmbApprover.ValueMember = "userid";
            cmbApprover.DisplayMember = "username";
            DataTable dtuserOld = new DataTable();
            sda1.Fill(dtuserOld);
            approverold.DataSource = dtuserOld;
            approverold.ValueMember = "userid";
            approverold.DisplayMember = "username";
            approverold.DataPropertyName = "useridold";
            string cmdlocation = "SELECT sitename,siteid FROM tbl_site";
            sda1 = new MySqlDataAdapter(cmdlocation, con);
            DataTable dtlocation = new DataTable();
            sda1.Fill(dtlocation);
            location.DataSource = dtlocation;
            location.ValueMember = "siteid";
            location.DisplayMember = "sitename";
            location.DataPropertyName = "siteid";
            cmbLocation2.DataSource = dtlocation;
            cmbLocation2.ValueMember = "siteid";
            cmbLocation2.DisplayMember = "sitename";
            DataTable dtlocationold = new DataTable();
            sda1.Fill(dtlocationold);
            locationold.DataSource = dtlocationold;
            locationold.ValueMember = "siteid";
            locationold.DisplayMember = "sitename";
            locationold.DataPropertyName = "siteidold";
            dgvApprover.Columns["disciplineold"].Visible = false;
            dgvApprover.Columns["locationold"].Visible = false;
            dgvApprover.Columns["approverold"].Visible = false;

            //Project
            string cmdProject = "SELECT PT.ProjectTypeID as ProjectType,P.ProjectID as ProjectID,p.projctname,P.AmountTillDate as AmountTillDate,RemainingAmount as RemainingAmount,TotalAmount as TotalAmount " +
                "FROM tbl_Project P LEFT JOIN tbl_ProjectTYpe PT on P.ProjectTYpeID=PT.ProjectTypeID";
            sda1 = new MySqlDataAdapter(cmdProject, con);
            DataTable dtProject = new DataTable();
            sda1.Fill(dtProject);
            dgvProject.AutoGenerateColumns = false;
            dgvProject.DataSource = dtProject;
            this.ProjectID.DataPropertyName = "ProjectID";
            this.AmountTillDate.DataPropertyName = "AmountTillDate";
            this.RemainingAmount.DataPropertyName = "RemainingAmount";
            this.TotalAmount.DataPropertyName = "TotalAmount";
            this.ProjectName.DataPropertyName = "projctname";
            dgvProject.Columns["ProjectID"].Visible = false;

            string CmdProjectType = "SELECT distinct ProjectTypeName,ProjectTypeID FROM tbl_ProjectType";
            sda1 = new MySqlDataAdapter(CmdProjectType, con);
            DataTable dtProjectTYpe = new DataTable();
            sda1.Fill(dtProjectTYpe);

            this.ProjectType.DataSource = dtProjectTYpe;
            this.ProjectType.DisplayMember = "ProjectTypeName";
            this.ProjectType.ValueMember = "ProjectTypeID";
            this.ProjectType.DataPropertyName = "ProjectType";
            dgvProject.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvProject.CellClick += new DataGridViewCellEventHandler(DGVProject_CellClick);

            cmbProjectType.DataSource = dtProjectTYpe;
            cmbProjectType.DisplayMember = "ProjectTypeName";
            cmbProjectType.ValueMember = "ProjectTypeID";

            //Bank
            string cmdBank = "SELECT BankID,BankName, BankCode,IBAN,SwiftCode,Country,CurrencyID,accountnumber,Disciplineid,cash FROM Tbl_Bank";
            sda1 = new MySqlDataAdapter(cmdBank, con);
            DataTable dtBank = new DataTable();
            sda1.Fill(dtBank);
            dgvBank.AutoGenerateColumns = false;
            dgvBank.DataSource = dtBank;
            this.BankID.DataPropertyName = "BankID";
            this.BankName.DataPropertyName = "BankName";
            this.BankCode.DataPropertyName = "BankCode";
            this.IBAN.DataPropertyName = "IBAN";
            this.SwiftCode.DataPropertyName = "SwiftCode";
            this.BankCountry.DataPropertyName = "Country";
            this.AccountNumber.DataPropertyName = "accountnumber";
            this.Cash.DataPropertyName = "cash";
            dgvBank.Columns["BankID"].Visible = false;



            dgvBank.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvBank.CellClick += new DataGridViewCellEventHandler(DGVBank_CellClick);

            string CmdCurrencyType = "SELECT distinct CurrencyName,CurrencyID FROM tbl_Currency";
            sda1 = new MySqlDataAdapter(CmdCurrencyType, con);
            DataTable dtCurrencyType = new DataTable();
            sda1.Fill(dtCurrencyType);

            cmbCurrencyAccepted.DataSource = dtCurrencyType;
            cmbCurrencyAccepted.DisplayMember = "CurrencyName";
            cmbCurrencyAccepted.ValueMember = "CurrencyID";

            this.CurrencyAccepted.DataSource = dtCurrencyType;
            this.CurrencyAccepted.DisplayMember = "CurrencyName";
            this.CurrencyAccepted.ValueMember = "CurrencyID";
            this.CurrencyAccepted.DataPropertyName= "CurrencyID";

            string CmdDisciplineType = "SELECT distinct DisciplineName,DisciplineID FROM tbl_Discipline";
            sda1 = new MySqlDataAdapter(CmdDisciplineType, con);
            DataTable dtDisciplineType = new DataTable();
            sda1.Fill(dtDisciplineType);

            cmbDiscipline.DataSource = dtDisciplineType;
            cmbDiscipline.DisplayMember = "DisciplineName";
            cmbDiscipline.ValueMember = "DisciplineID";

            this.Discipline.DataSource = dtDisciplineType;
            this.Discipline.DisplayMember = "DisciplineName";
            this.Discipline.ValueMember = "DisciplineID";
            this.Discipline.DataPropertyName = "Disciplineid";

            
            //Supplier
            string cmdSupplier = "SELECT SupplierID ,	SupplierName ,	SupplierCode,	BankID ,SupplierTypeid,	Address,Country FROM Tbl_Supplier";
            sda1 = new MySqlDataAdapter(cmdSupplier, con);
            DataTable dtSupplier = new DataTable();
            sda1.Fill(dtSupplier);
            dgvSupplier.AutoGenerateColumns = false;
            dgvSupplier.DataSource = dtSupplier;
            this.SupplierID.DataPropertyName = "SupplierID";
            this.Code.DataPropertyName = "SupplierCode";
            this.SupplierName.DataPropertyName = "SupplierName";
            this.SupplierType.DataPropertyName = "SupplierTypeid";
            this.Address.DataPropertyName = "Address";
            this.SupplierCountry.DataPropertyName = "Country";
            dgvSupplier.Columns["SupplierID"].Visible = false;

            string CmdSupplierBank = "SELECT distinct BankName,BankID FROM tbl_Bank";
            sda1 = new MySqlDataAdapter(CmdSupplierBank, con);
            DataTable dtSupplierBank = new DataTable();
            sda1.Fill(dtSupplierBank);

            this.SupplierBank.DataSource = dtSupplierBank;
            this.SupplierBank.DisplayMember = "BankName";
            this.SupplierBank.ValueMember = "BankID";
            this.SupplierBank.DataPropertyName = "BankID";

            string CmdSupplierType = "SELECT distinct SupplierTypeName,SupplierTypeID FROM tbl_SupplierType";
            sda1 = new MySqlDataAdapter(CmdSupplierType, con);
            DataTable dtSupplierType = new DataTable();
            sda1.Fill(dtSupplierType);

            this.SupplierType.DataSource = dtSupplierType;
            this.SupplierType.DisplayMember = "SupplierTypeName";
            this.SupplierType.ValueMember = "SupplierTypeID";
            this.SupplierType.DataPropertyName = "SupplierTypeID";
            dgvSupplier.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvSupplier.CellClick += new DataGridViewCellEventHandler(DGVSupplier_CellClick);

            cmbSupplierBank.DataSource = dtSupplierBank;
            cmbSupplierBank.DisplayMember = "BankName";
            cmbSupplierBank.ValueMember = "BankID";
            cmbSupplierType.DataSource = dtSupplierType;
            cmbSupplierType.DisplayMember = "SupplierTypeName";
            cmbSupplierType.ValueMember = "SupplierTypeID";


        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            MySqlConnection con = new MySqlConnection(ConString);

            try
            {
                DataGridView dgv = ((DataGridView)sender);
                if (e.ColumnIndex < 0)
                {
                    dgv.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                    dgv.Focus();
                    dgv.EndEdit();
                }
                else if (e.ColumnIndex == 7)
                {
                    int id = e.RowIndex + 1;
                    string query = "DELETE FROM tbl_Userprivilege " +
                    "WHERE UserID =" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + " AND " +
                    " PrivilegeID=" + dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() + "";
                   
                    MySqlDataAdapter sda = new MySqlDataAdapter(query, con);
                    DataTable dtUserDetails = new DataTable();
                    sda.Fill(dtUserDetails);
                    string query1 = "DELETE FROM tbl_Users " +
                    "WHERE UserID =" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "" +
                    " AND NOT EXISTS (select * from tbl_userPrivilege where " +
                    "UserID =" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + " )";

                    sda = new MySqlDataAdapter(query1, con);
                    sda.Fill(dtUserDetails);
                    dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
                }
                else if (e.ColumnIndex == 6)
                {
                    string query = "UPDATE tbl_Users SET " +
                   "UserName = '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "' , " +
                   "PassWord = '" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "' ," +
                   "CompanyRole = '" + dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString() + "' " +
                   "WHERE UserID =" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "";
                   
                    MySqlDataAdapter sda = new MySqlDataAdapter(query, con);
                    DataTable dtUserDetails = new DataTable();
                    sda.Fill(dtUserDetails);
                    string query1 = "UPDATE tbl_Userprivilege SET " +
                   "PrivilegeID = " + dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() + " " +
                   "WHERE UserID =" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + " AND " +
                   "PrivilegeID = " + dataGridView1.Rows[e.RowIndex].Cells["PrivilegeOld"].Value.ToString() + "";

                    sda = new MySqlDataAdapter(query1, con);
                    sda.Fill(dtUserDetails);
                    MessageBox.Show("Information saved successfully!!", "Sucess");

                    string CmdString = "SELECT U.USERID as UserID,U.USERNAME as UserName,U.PASSWORD as Password,P.PRIVILEGEID as Privilege,P.PRIVILEGEID as PrivilegeID,U.companyRole FROM RASTA.tbl_userprivilege UP " +
                                        "LEFT JOIN RASTA.tbl_users U ON U.USERID=UP.UserID " +
                                        "LEFT JOIN RASTA.tbl_privilege P ON P.PRIVILEGEID=UP.PRIVILEGEID order by U.USERNAME";
                    MySqlDataAdapter sda1 = new MySqlDataAdapter(CmdString, con);
                    DataTable dtUserDetails1 = new DataTable();
                    sda1.Fill(dtUserDetails1);
                    this.dataGridView1.AutoGenerateColumns = false;
                    this.dataGridView1.DataSource = dtUserDetails1;

                }
                else
                {
                    dgv.EditMode = DataGridViewEditMode.EditOnEnter;
                    dgv.BeginEdit(false);
                }
              

            }
            catch
            {
                MessageBox.Show("Some Error has occured!!", "Error");

            }
        }

        private void DGVApprover_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = ((DataGridView)sender);
            if (e.ColumnIndex < 0)
            {
                dgv.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                dgv.Focus();
                dgv.EndEdit();
            }
            else if (e.ColumnIndex ==7)
            {
                string query = "DELETE FROM tbl_UserDiscipline " +
                "WHERE disciplineid =" + dgvApprover.Rows[e.RowIndex].Cells[0].Value.ToString() + " and " +
                "userid =" + dgvApprover.Rows[e.RowIndex].Cells[2].Value.ToString() + " and " +
                "siteid =" + dgvApprover.Rows[e.RowIndex].Cells[1].Value.ToString() + " ";
                MySqlConnection con = new MySqlConnection(ConString);
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                dgvApprover.Rows.Remove(dgvApprover.Rows[e.RowIndex]);
            }
            else if (e.ColumnIndex == 6)
            {
                try
                {
                    string query = "UPDATE tbl_UserDiscipline  " +
                   "SET disciplineid =" + dgvApprover.Rows[e.RowIndex].Cells[0].Value.ToString() + " , " +
                "userid =" + dgvApprover.Rows[e.RowIndex].Cells[2].Value.ToString() + " , " +
                "siteid =" + dgvApprover.Rows[e.RowIndex].Cells[1].Value.ToString() + " "+
                    "WHERE disciplineid =" + dgvApprover.Rows[e.RowIndex].Cells[3].Value.ToString() + " and " +
                "userid =" + dgvApprover.Rows[e.RowIndex].Cells[5].Value.ToString() + " and " +
                "siteid =" + dgvApprover.Rows[e.RowIndex].Cells[4].Value.ToString() + " ";
                    MySqlConnection con = new MySqlConnection(ConString);
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Information saved successfully!!", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Some Error has occured!!", "Error");

                }
            }
            else
            {
                dgv.EditMode = DataGridViewEditMode.EditOnEnter;
                dgv.BeginEdit(false);
            }

        }

        private void btnEditCash_Click(object sender, EventArgs e)
        {
            try{
                string spname = "insert into rasta.tbl_termdeposit(BankID,TotalTime,Amount,DepositDate,DepositType) VALUES(" +
               "'" + cmbEditBankName.SelectedValue + "','" + txtTDDuration.Text + "'," + txtNegativeCash.Text + ",'" + Convert.ToDateTime(calTDStartDate.Text).ToString("yyyy-MM-dd H:mm:ss") + "','" + txtNegativeCashType.Text + "')";
                MySqlConnection con = new MySqlConnection(ConString);
                MySqlCommand cmd = new MySqlCommand(spname, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                spname = "update rasta.tbl_bank set negativecash=IFNULL(negativecash,0)+" +txtNegativeCash.Text + " where bankid="+cmbEditBankName.SelectedValue+"";
             
                MySqlCommand cmd1 = new MySqlCommand(spname, con);
                cmd1.CommandType = CommandType.Text;
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Information saved successfully!!", "Sucess Message");
                txtTDDuration.Text = "";
                txtNegativeCash.Text = "";
                txtNegativeCashType.Text = "";
                cmbEditBankName.SelectedIndex = 0;
               
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error has occured!!", "Error");
            }


        }

        private void cmbEditBankName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEditBankName.SelectedIndex != -1 && !string.IsNullOrEmpty(Convert.ToString(cmbEditBankName.SelectedValue)))
            {
                string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                MySqlConnection con = new MySqlConnection(ConString);
                this.splitContainer9.Panel2Collapsed = false;
                string cmdbank1 = "SELECT cash FROM Tbl_bank where bankid='" + cmbEditBankName.SelectedValue + "'";
                MySqlDataAdapter sda1 = new MySqlDataAdapter(cmdbank1, con);
                DataTable dtBankEditcash = new DataTable();
                sda1.Fill(dtBankEditcash);
                if(dtBankEditcash.Rows.Count>0)
                txtTotalCash.Text = dtBankEditcash.Rows[0][0].ToString();
            }
        }

        private void btnApproverSave_Click(object sender, EventArgs e)
        {
            try{
                string spname = "insert into rasta.tbl_UserDiscipline(disciplineid,userid,siteid) VALUES(" +
              "'" + cmbDepartment.SelectedValue + "','" + cmbApprover.SelectedValue + "'," + cmbLocation2.SelectedValue + ")";
                MySqlConnection con = new MySqlConnection(ConString);
                MySqlCommand cmd = new MySqlCommand(spname, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Information saved successfully!!", "Sucess Message");
                string cmdApprovers = "SELECT disciplineid,userid,siteid,disciplineid as disciplineOld,userid as useridOld,siteid as siteidOld FROM tbl_UserDiscipline";
                MySqlDataAdapter sda1 = new MySqlDataAdapter(cmdApprovers, con);
                DataTable dtApprover = new DataTable();
                sda1.Fill(dtApprover);
                dgvApprover.AutoGenerateColumns = false;
                dgvApprover.DataSource = dtApprover;
                cmbDepartment.SelectedIndex = 0;
                cmbLocation2.SelectedIndex = 0;
                cmbApprover.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error has occured!!", "Error");
            }
        }
    }
}
