﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Rasta
{
    public partial class GeneralBudget : Form
    {
        string con = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        MySqlDataAdapter sda1;
        public GeneralBudget()
        {
            InitializeComponent();
        }

        private void GeneralBudget_Load(object sender, EventArgs e)
        {
            string CmdCurrencyType = "SELECT distinct CurrencyName,CurrencyID FROM tbl_Currency";
            sda1 = new MySqlDataAdapter(CmdCurrencyType, con);
            DataTable dtCurrencyType = new DataTable();
            sda1.Fill(dtCurrencyType);
            
            this.cmbCurrency.DataSource = dtCurrencyType;
            this.cmbCurrency.DisplayMember = "CurrencyName";
            this.cmbCurrency.ValueMember = "CurrencyID";
            cmbCurrency.SelectedIndex = -1;
            dataGridView1.Visible = false;
        }

        private void cmbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCurrency.SelectedIndex == -1)
            {
                dataGridView1.Visible = false;

            }
            else
            {
                string CmdBank = "select c.currencyname as Currency,d.Departmentname as ExpenseType," +
                                "IFNULL(max(CASE WHEN (b.budgetMonth) = 1 THEN b.amount/ce.exchangerateinusd END),0) AS JanForecast," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 1 THEN a.amount/ce.exchangerateinusd END),0) AS JanActual," +
                                "IFNULL(max(CASE WHEN (b.budgetMonth) = 1 THEN b.amount/ce.exchangerateinusd END),0) - " +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 1 THEN a.amount/ce.exchangerateinusd END),0) AS JanDifference," +

                                "IFNULL(max(CASE WHEN (b.budgetMonth) =2 THEN b.amount/ce.exchangerateinusd END),0) AS FebForecast," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) =2 THEN a.amount/ce.exchangerateinusd END),0) AS FebActual," +
                                "IFNULL(sum(CASE WHEN (b.budgetYear)='" + DateTime.Now.Year.ToString() + "'  and (b.budgetMonth) = 2 THEN b.amount/ce.exchangerateinusd END),0) - " +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 2 THEN a.amount/ce.exchangerateinusd END),0) AS FebDifference," +

                                "IFNULL(max(CASE WHEN (b.budgetMonth) = 3 THEN b.amount/ce.exchangerateinusd END),0) AS MarForecast," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 3 THEN a.amount/ce.exchangerateinusd END),0) AS MarActual," +
                                "IFNULL(max(CASE WHEN (b.budgetMonth) = 3 THEN b.amount/ce.exchangerateinusd END),0) - " +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 3 THEN a.amount/ce.exchangerateinusd END),0) AS MarDifference," +

                                "IFNULL(max(CASE WHEN (b.budgetMonth) = 4 THEN b.amount/ce.exchangerateinusd END),0) AS AprForecast," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 4 THEN a.amount/ce.exchangerateinusd END),0) AS AprActual," +
                                "IFNULL(max(CASE WHEN (b.budgetMonth) = 4 THEN b .amount/ce.exchangerateinusd END),0) - " +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 4 THEN a.amount/ce.exchangerateinusd END),0) AS AprDifference," +

                                "IFNULL(max(CASE WHEN (b.budgetMonth) = 5 THEN b.amount/ce.exchangerateinusd END),0) AS MayForecast," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 5 THEN a.amount/ce.exchangerateinusd END),0) AS MayActual," +
                                "IFNULL(max(CASE WHEN (b.budgetMonth) = 5 THEN b.amount/ce.exchangerateinusd END),0) - " +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=1 and MONTH(a.InvoiceDate) = 5 THEN a.amount/ce.exchangerateinusd END),0) AS MayDifference," +

                                "IFNULL(max(CASE WHEN (b.budgetMonth) = 6 THEN b.amount/ce.exchangerateinusd END),0) AS JunForecast," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 6 THEN a.amount/ce.exchangerateinusd END),0) AS JunActual," +
                                "IFNULL(max(CASE WHEN  (b.budgetMonth) = 6 THEN b.amount/ce.exchangerateinusd END),0) - " +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 6 THEN a.amount/ce.exchangerateinusd END),0) AS JunDifference," +

                                "IFNULL(max(CASE WHEN (b.budgetMonth) = 7 THEN b.amount/ce.exchangerateinusd END),0) AS JulForecast," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 7 THEN a.amount/ce.exchangerateinusd END),0) AS JulActual," +
                                "IFNULL(max(CASE WHEN (b.budgetMonth) = 7 THEN b.amount/ce.exchangerateinusd END),0) - " +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 7 THEN a.amount/ce.exchangerateinusd END),0) AS JulDifference," +

                                "IFNULL(max(CASE WHEN (b.budgetMonth) = 8 THEN b.amount/ce.exchangerateinusd END),0) AS AugForecast," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 8 THEN a.amount/ce.exchangerateinusd END),0) AS AugActual," +
                                "IFNULL(max(CASE WHEN (b.budgetMonth) = 8 THEN b.amount/ce.exchangerateinusd END),0) - " +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 8 THEN a.amount/ce.exchangerateinusd END),0) AS AugDifference," +

                                "IFNULL(max(CASE WHEN (b.budgetMonth) = 9 THEN b.amount/ce.exchangerateinusd END),0) AS SepForecast," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 9 THEN a.amount/ce.exchangerateinusd END),0) AS SepActual," +
                                "IFNULL(max(CASE WHEN (b.budgetMonth) = 9 THEN b.amount/ce.exchangerateinusd END),0) - " +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 9 THEN a.amount/ce.exchangerateinusd END),0) AS SepDifference," +

                                "IFNULL(max(CASE WHEN (b.budgetMonth) = 10 THEN b.amount/ce.exchangerateinusd END),0) AS OctForecast," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 10 THEN a.amount/ce.exchangerateinusd END),0) AS OctActual," +
                                "IFNULL(max(CASE WHEN (b.budgetMonth) = 10 THEN b.amount/ce.exchangerateinusd END),0) - " +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 10 THEN a.amount/ce.exchangerateinusd END),0) AS OctDifference," +

                                "IFNULL(max(CASE WHEN (b.budgetMonth) = 11 THEN b.amount/ce.exchangerateinusd END),0) AS NovForecast," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 11 THEN a.amount/ce.exchangerateinusd END),0) AS NovActual," +
                                "IFNULL(sum(CASE WHEN (b.budgetYear)='" + DateTime.Now.Year.ToString() + "'  and (b.budgetMonth) = 11 THEN b.amount/ce.exchangerateinusd END),0) - " +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 11 THEN a.amount/ce.exchangerateinusd END),0) AS NovDifference," +

                                "IFNULL(max(CASE WHEN (b.budgetMonth) = 12 THEN b.amount/ce.exchangerateinusd END),0) AS DecForecast," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 12 THEN a.amount/ce.exchangerateinusd END),0) AS DecActual," +
                                "IFNULL(sum(CASE WHEN (b.budgetYear)='" + DateTime.Now.Year.ToString() + "'  and (b.budgetMonth) = 12 THEN b.amount/ce.exchangerateinusd END),0) - " +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 12 THEN a.amount/ce.exchangerateinusd END),0) AS DecDifference " +

                                " from rasta.tbl_department d  "+
                                "left join rasta.tbl_apdepartmentexpense ad on d.departmentid=ad.departmentid  "+
                                "left join rasta.vw_AccountPayable a on ad.apid=a.apid and a.isforecast=0 and a.costcodeid=2  " +
                                "left join rasta.tbl_budget b on b.departmentid=d.departmentid and b.costcodeid=2 and b.budgetYear= '" + DateTime.Now.Year.ToString() + "' " +
                               "left join rasta.tbl_currencyexchange ce on ce.currencyid='" + cmbCurrency.SelectedValue.ToString() + "' " +
                               "left join rasta.tbl_currency c on c.currencyid=ce.currencyid " +
                               "group by  d.Departmentname";
                sda1 = new MySqlDataAdapter(CmdBank, con);
                DataTable dtExpenseType = new DataTable();
                sda1.Fill(dtExpenseType);
                if (dtExpenseType.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dtExpenseType;
                    dataGridView1.Visible = true;

                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                
                    string spname = "sp_InsertBudget";
                    string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                    MySqlConnection con = new MySqlConnection(ConString);
                    MySqlCommand cmd = new MySqlCommand(spname, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("iBudgetYear", DateTime.Now.Year);
                    cmd.Parameters.AddWithValue("iCostCodeID", 2);
                    cmd.Parameters.AddWithValue("iDepartmentname", dr.Cells[1].Value.ToString());
                   cmd.Parameters.AddWithValue("dAMOUNT1", dr.Cells[2].Value.ToString());
                   cmd.Parameters.AddWithValue("dAMOUNT2", dr.Cells[5].Value.ToString());
                   cmd.Parameters.AddWithValue("dAMOUNT3", dr.Cells[8].Value.ToString());
                   cmd.Parameters.AddWithValue("dAMOUNT4", dr.Cells[11].Value.ToString());
                   cmd.Parameters.AddWithValue("dAMOUNT5", dr.Cells[14].Value.ToString());
                   cmd.Parameters.AddWithValue("dAMOUNT6", dr.Cells[17].Value.ToString());
                   cmd.Parameters.AddWithValue("dAMOUNT7", dr.Cells[20].Value.ToString());
                   cmd.Parameters.AddWithValue("dAMOUNT8", dr.Cells[23].Value.ToString());
                   cmd.Parameters.AddWithValue("dAMOUNT9", dr.Cells[26].Value.ToString());
                   cmd.Parameters.AddWithValue("dAMOUNT10", dr.Cells[29].Value.ToString());
                   cmd.Parameters.AddWithValue("dAMOUNT11", dr.Cells[32].Value.ToString());
                   cmd.Parameters.AddWithValue("dAMOUNT12", dr.Cells[35].Value.ToString());
                
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = ((DataGridView)sender);
            if (e.ColumnIndex < 0)
            {
                dgv.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                dgv.Focus();
                dgv.EndEdit();
            }
            else
            {
                dgv.EditMode = DataGridViewEditMode.EditOnEnter;
                dgv.BeginEdit(false);
            }

        }
    }
}

