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

            string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            MySqlConnection con = new MySqlConnection(ConString);
            string CmdString = "SELECT U.USERID as UserID,U.USERNAME as UserName,U.PASSWORD as Password,P.PRIVILEGEID as Privilege,P.PRIVILEGEID as PrivilegeID FROM RASTA.tbl_userprivilege UP " +
                                "LEFT JOIN RASTA.tbl_users U ON U.USERID=UP.UserID " +
                                "LEFT JOIN RASTA.tbl_privilege P ON P.PRIVILEGEID=UP.PRIVILEGEID order by U.USERNAME";
            MySqlDataAdapter sda1 = new MySqlDataAdapter(CmdString, con);
            DataTable dtUserDetails = new DataTable();
            sda1.Fill(dtUserDetails);
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
            dataGridView1.Columns["UserID"].Visible = false;
            dataGridView1.Columns["PrivilegeOld"].Visible = false;

            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView1.CellClick += new DataGridViewCellEventHandler(DGV_CellClick);


            //currency
            string CmdString2 = "SELECT CurrencyName,CurrencyID FROM tbl_Currency";
            sda1 = new MySqlDataAdapter(CmdString2, con);
            DataTable dtCurrency = new DataTable();
            sda1.Fill(dtCurrency);
            dgvCurrency.AutoGenerateColumns = false;
            dgvCurrency.DataSource = dtCurrency;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CurrencyName";
            this.CurrencyID.DataPropertyName = "CurrencyID";

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

            //Project
            string cmdProject = "SELECT PT.ProjectTypeID as ProjectType,P.ProjectID as ProjectID,P.AmountTillDate as AmountTillDate,RemainingAmount as RemainingAmount,TotalAmount as TotalAmount "+
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

            //Project
            string cmdBank = "SELECT BankID,BankName, BankCode,IBAN,SwiftCode,Country,CurrencyID FROM Tbl_Bank";
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

            //Supplier
            string cmdSupplier = "SELECT SupplierID ,	SupplierName ,	SupplierCode,	BankID ,SupplierType,	Address,Country FROM Tbl_Supplier";
            sda1 = new MySqlDataAdapter(cmdSupplier, con);
            DataTable dtSupplier = new DataTable();
            sda1.Fill(dtSupplier);
            dgvSupplier.AutoGenerateColumns = false;
            dgvSupplier.DataSource = dtSupplier;
            this.SupplierID.DataPropertyName = "SupplierID";
            this.Code.DataPropertyName = "SupplierCode";
            this.SupplierName.DataPropertyName = "SupplierName";
            this.SupplierType.DataPropertyName = "SupplierType";
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
            dgvSupplier.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvSupplier.CellClick += new DataGridViewCellEventHandler(DGVSupplier_CellClick);

            cmbSupplierBank.DataSource = dtSupplierBank;
            cmbSupplierBank.DisplayMember = "BankName";
            cmbSupplierBank.ValueMember = "BankID";


        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = ((DataGridView)sender);
            if (e.ColumnIndex < 0)
            {
                dgv.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                dgv.Focus();
                dgv.EndEdit();
            }
            else if (e.ColumnIndex == 6)
            {
                int id = e.RowIndex + 1;
                string query = "DELETE FROM tbl_Userprivilege " +
                "WHERE UserID =" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + " AND " +
                " PrivilegeID=" + dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() + "";
                string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                MySqlConnection con = new MySqlConnection(ConString);

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
            else if (e.ColumnIndex == 5)
            {
                string query = "UPDATE tbl_Users SET " +
               "UserName = '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "' , " +
               "PassWord = '" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "' " +
               "WHERE UserID =" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "";
                string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                MySqlConnection con = new MySqlConnection(ConString);

                MySqlDataAdapter sda = new MySqlDataAdapter(query, con);
                DataTable dtUserDetails = new DataTable();
                sda.Fill(dtUserDetails);
                string query1 = "UPDATE tbl_Userprivilege SET " +
               "PrivilegeID = " + dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() + " " +
               "WHERE UserID =" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + " AND " +
               "PrivilegeID = " + dataGridView1.Rows[e.RowIndex].Cells["PrivilegeOld"].Value.ToString() + "";

                sda = new MySqlDataAdapter(query1, con);
                sda.Fill(dtUserDetails);
            }
            else
            {
                dgv.EditMode = DataGridViewEditMode.EditOnEnter;
                dgv.BeginEdit(false);
            }
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
            else if (e.ColumnIndex == 3)
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
            else if (e.ColumnIndex == 2)
            {
                string query = "UPDATE tbl_Currency SET " +
               "CurrencyName = '" + dgvCurrency.Rows[e.RowIndex].Cells[0].Value.ToString() + "'  " +
               "WHERE CurrencyID =" + dgvCurrency.Rows[e.RowIndex].Cells[1].Value.ToString() + "";
                string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                MySqlConnection con = new MySqlConnection(ConString);

                MySqlDataAdapter sda = new MySqlDataAdapter(query, con);
                DataTable dtCurrency = new DataTable();
                sda.Fill(dtCurrency);

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
                string query = "UPDATE tbl_Site SET " +
               "SiteName = '" + dgvSite.Rows[e.RowIndex].Cells[0].Value.ToString() + "'  " +
               "WHERE SiteID =" + dgvSite.Rows[e.RowIndex].Cells[1].Value.ToString() + "";
                MySqlConnection con = new MySqlConnection(ConString);
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

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
                string query = "UPDATE tbl_ExpenseType SET " +
               "ExpenseTypeName = '" + dgvExpenseType.Rows[e.RowIndex].Cells[0].Value.ToString() + "'  " +
               "WHERE ExpenseTypeID =" + dgvExpenseType.Rows[e.RowIndex].Cells[1].Value.ToString() + "";
                MySqlConnection con = new MySqlConnection(ConString);
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

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
            else if (e.ColumnIndex == 6)
            {
                string query = "DELETE FROM tbl_Project " +
                "WHERE ProjectID =" + dgvProject.Rows[e.RowIndex].Cells[1].Value.ToString() + " ";
                MySqlConnection con = new MySqlConnection(ConString);
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                dgvProject.Rows.Remove(dgvProject.Rows[e.RowIndex]);
            }
            else if (e.ColumnIndex == 5)
            {
                string query = "UPDATE tbl_Project SET " +
               "ProjectTypeID = '" + dgvProject.Rows[e.RowIndex].Cells[0].Value.ToString() + "' , " +
               "AmountTillDate = '" + dgvProject.Rows[e.RowIndex].Cells[2].Value.ToString() + "' , " +
               "RemainingAmount = '" + dgvProject.Rows[e.RowIndex].Cells[3].Value.ToString() + "' , " +
               "TotalAmount = '" + dgvProject.Rows[e.RowIndex].Cells[4].Value.ToString() + "'  " +
               "WHERE ProjectID =" + dgvProject.Rows[e.RowIndex].Cells[1].Value.ToString() + "";
                MySqlConnection con = new MySqlConnection(ConString);
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

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
            else if (e.ColumnIndex == 8)
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
            else if (e.ColumnIndex == 7)
            {
                string query = "UPDATE tbl_Bank SET " +
               "BankName = '" + dgvBank.Rows[e.RowIndex].Cells[0].Value.ToString() + "' , " +
               "BankCode = '" + dgvBank.Rows[e.RowIndex].Cells[2].Value.ToString() + "' , " +
               "SwiftCode = '" + dgvBank.Rows[e.RowIndex].Cells[4].Value.ToString() + "' , " +
               "IBAN = '" + dgvBank.Rows[e.RowIndex].Cells[5].Value.ToString() + "' , " +
               "Country = '" + dgvBank.Rows[e.RowIndex].Cells[6].Value.ToString() + "'  " +
               "WHERE BankID =" + dgvBank.Rows[e.RowIndex].Cells[1].Value.ToString() + "";
                MySqlConnection con = new MySqlConnection(ConString);
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

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
                string query = "UPDATE tbl_Supplier SET " +
               "SupplierName = '" + dgvSupplier.Rows[e.RowIndex].Cells[0].Value.ToString() + "' , " +
               "SupplierCode = '" + dgvSupplier.Rows[e.RowIndex].Cells[2].Value.ToString() + "' , " +
               "BankID = '" + dgvSupplier.Rows[e.RowIndex].Cells[3].Value.ToString() + "' , " +
               "SupplierType = '" + dgvSupplier.Rows[e.RowIndex].Cells[4].Value.ToString() + "' , " +
               "Address = '" + dgvSupplier.Rows[e.RowIndex].Cells[5].Value.ToString() + "',  " +
               "Country = '" + dgvSupplier.Rows[e.RowIndex].Cells[6].Value.ToString() + "'  " +
               "WHERE SupplierID =" + dgvSupplier.Rows[e.RowIndex].Cells[1].Value.ToString() + "";
                MySqlConnection con = new MySqlConnection(ConString);
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

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
            this.splitContainer9.Panel2Collapsed = false;
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
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
            cmd.Parameters.AddWithValue("name", txtUserName.Text);
            cmd.Parameters.AddWithValue("password", txtPassWord.Text);
            cmd.Parameters.AddWithValue("privileges", privileges);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();




        }

        private void btnCurrencySave_Click(object sender, EventArgs e)
        {
            string spname = "insert into rasta.tbl_currency(CurrencyName) values('" + txtCurrency.Text + "')";
            MySqlConnection con = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(spname, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnSaveSite_Click(object sender, EventArgs e)
        {
            string spname = "insert into rasta.tbl_Site(SiteName) values('" + txtSite.Text + "')";
            MySqlConnection con = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(spname, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnExpenseTypeSave_Click(object sender, EventArgs e)
        {
            string spname = "insert into rasta.tbl_ExpenseType(ExpenseTypeName) values('" + txtExpenseType.Text + "')";
            MySqlConnection con = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(spname, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnProjectSave_Click(object sender, EventArgs e)
        {
            string spname = "insert into rasta.tbl_Project(ProjectTypeID,AmountTillDate,RemainingAmount,TotalAmount) values("+
                "'"+ cmbProjectType.SelectedValue + "',"+txtAmountTillDate.Text+","+txtAmountTillDate.Text+","+txtTotalAmount.Text+")";
            MySqlConnection con = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(spname, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnBankSave_Click(object sender, EventArgs e)
        {
            string spname = "insert into rasta.tbl_Bank(BankName,BankCode,CurrencyID,IBAN,SwiftCode,Country) values(" +
                "'" + txtBankName.Text + "','" + txtBankCode.Text + "'," + cmbCurrencyAccepted.SelectedValue + ",'" + txtIBAN.Text + "','" + txtSwiftCode.Text + "','" + txtCountry.Text + "')";
            MySqlConnection con = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(spname, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnSupplierSave_Click(object sender, EventArgs e)
        {
            string spname = "insert into rasta.tbl_Supplier(SupplierName,SupplierCode,BankID,SupplierType,Address,Country) values(" +
                            "'" + txtSupplierName.Text + "','" + txtSupplierCode.Text + "'," + cmbSupplierBank.SelectedValue + ",'" +txtSupplierType.Text  + "','" + txtSupplierAddress.Text + "','" + txtCountry.Text + "')";
            MySqlConnection con = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(spname, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }






    }
}
