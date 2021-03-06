﻿using System;
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
    public partial class BankReport : Form
    {
        string con = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        MySqlDataAdapter sda1;
        public BankReport()
        {
            InitializeComponent();
        }

        private void BankReport_Load(object sender, EventArgs e)
        {
            string CmdCurrencyType = "SELECT distinct CurrencyName,CurrencyID FROM tbl_Currency";
            sda1 = new MySqlDataAdapter(CmdCurrencyType, con);
            DataTable dtCurrencyType = new DataTable();
            sda1.Fill(dtCurrencyType);
            this.cmbCurrency.SelectedIndexChanged -= new System.EventHandler(this.cmbCurrency_SelectedIndexChanged);

            this.cmbCurrency.DataSource = dtCurrencyType;
            this.cmbCurrency.DisplayMember = "CurrencyName";
            this.cmbCurrency.ValueMember = "CurrencyID";
            cmbCurrency.SelectedIndex = -1;
            this.cmbCurrency.SelectedIndexChanged += new System.EventHandler(this.cmbCurrency_SelectedIndexChanged);

            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;


        }
        private DataTable GenerateTransposedTable(DataTable inputTable)
        {
            DataTable outputTable = new DataTable();

            // Add columns by looping rows

            // Header row's first column is same as in inputTable
            outputTable.Columns.Add(inputTable.Columns[0].ColumnName.ToString());

            // Header row's second column onwards, 'inputTable's first column taken
            foreach (DataRow inRow in inputTable.Rows)
            {
                outputTable.Columns.Add(new DataColumn(inRow[0].ToString(), typeof(double)));
            }
           
            // Add rows by looping columns        
            for (int rCount = 1; rCount <= inputTable.Columns.Count - 1; rCount++)
            {
                DataRow newRow = outputTable.NewRow();

                // First column is inputTable's Header row's second column
                newRow[0] = inputTable.Columns[rCount].ColumnName.ToString();
                for (int cCount = 0; cCount <= inputTable.Rows.Count - 1; cCount++)
                {
                    newRow[cCount + 1] = inputTable.Rows[cCount][rCount].ToString();
                   
                }
                outputTable.Rows.Add(newRow);
            }

            return outputTable;
        }

        private void cmbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCurrency.SelectedIndex == -1)
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = false;
                dataGridView3.Visible = false;

            }
            else
            {
                
                string CmdBank = "select concat(b.bankname,' (',c.currencyname,')') as Bank,"+
               " b.cash/ce.ExchangeRateinUSD as total,b.negativecash/ce.ExchangeRateinUSD as  totalnegative  from rasta.vw_bank b " +
                    "left join rasta.tbl_CurrencyExchange ce on ce.currencyid='" + cmbCurrency.SelectedValue.ToString() + "' left join rasta.tbl_currency c on ce.currencyid=c.currencyid order by Bank";
                sda1 = new MySqlDataAdapter(CmdBank, con);
                DataTable dtBank = new DataTable();
                sda1.Fill(dtBank);
                if (dtBank.Rows.Count > 0)
                {

                    DataTable dtReport = GenerateTransposedTable(dtBank);
                    DataRow dr = dtReport.NewRow();
                    dr[0] = "total";

                    var columns = dtReport.Columns.Cast<DataColumn>();
                    int i = 1;
                    foreach (var col in columns)
                    {
                        DataColumn colm = (DataColumn)col;
                        if (!colm.ColumnName.Equals("Bank"))
                        {
                            dr[i] = Convert.ToDouble(dtReport.AsEnumerable().Sum(x => x.Field<Double>(colm.ColumnName)));
                            i++;
                        }
                    }
                    dtReport.Rows.Add(dr);
                    dataGridView1.DataSource = dtReport;
                    dataGridView1.Visible = true;

                }
                string cmdTD = "select concat(b.bankname,' (',c.currencyname,')') as Bank," +
                        "sum(case when td.totaltime=0 then  td.amount/ce.exchangerateinusd  else 0 end)  as termdeposit0," +
                        "sum(case when td.totaltime>0 and td.totaltime<=3 then   td.amount/ce.exchangerateinusd  else 0 end)  as termdeposit3," +
                        "sum(case when td.totaltime>3 and td.totaltime<=6 then  td.amount/ce.exchangerateinusd  else 0 end)  as termdeposit6," +
                        "sum(case when td.totaltime>6 then  td.amount/ce.exchangerateinusd else  0 end)  as termdepositMore " +
                        "from  rasta.tbl_termdeposit td " +
                        "left join rasta.vw_bank b on b.bankid=td.BankID " +
                        "left join rasta.tbl_currencyexchange ce on ce.currencyid='" + cmbCurrency.SelectedValue.ToString() + "' " +
                        "left join rasta.tbl_currency c on c.currencyid=ce.currencyid " +
                        "where td.depositType='TD' group by b.bankname";
                sda1 = new MySqlDataAdapter(cmdTD, con);
                DataTable dtTD = new DataTable();
                sda1.Fill(dtTD);
                if (dtTD.Rows.Count > 0)
                {

                    DataTable dtReportTD = GenerateTransposedTable(dtTD);
                    DataRow dr= dtReportTD.NewRow();
                    dr[0] = "total";
                   
                    var columns = dtReportTD.Columns.Cast<DataColumn>();
                    int i = 1;
                    foreach (var col in columns)
                    {
                        DataColumn colm = (DataColumn)col;
                        if (!colm.ColumnName.Equals("Bank"))
                        {
                            dr[i] = Convert.ToDouble(dtReportTD.AsEnumerable().Sum(x => x.Field<Double>(colm.ColumnName)));
                            i++;
                        }
                    }
                    dtReportTD.Rows.Add(dr);
                   
                    dataGridView2.DataSource = dtReportTD;
                    dataGridView2.Visible = true;

                }
                string cmdother = "select concat(b.bankname,' (',c.currencyname,')') as Bank," +
                        "sum(case when td.totaltime=0 then td.amount/ce.exchangerateinusd  else  0 end)  as termdeposit0," +
                        "sum(case when td.totaltime>0 and td.totaltime<=3 then td.amount/ce.exchangerateinusd   else 0 end)  as termdeposit3," +
                        "sum(case when td.totaltime>3 and td.totaltime<=6 then td.amount/ce.exchangerateinusd  else 0 end)  as termdeposit6," +
                        "sum(case when td.totaltime>6 then td.amount/ce.exchangerateinusd  else 0 end)  as termdepositMore " +
                        "from  rasta.tbl_termdeposit td " +
                        "left join rasta.vw_bank b on b.bankid=td.BankID " +
                        "left join rasta.tbl_currencyexchange ce on ce.currencyid='" + cmbCurrency.SelectedValue.ToString() + "' " +
                        "left join rasta.tbl_currency c on c.currencyid=ce.currencyid " +
                        "where td.depositType<>'TD' group by b.bankname";
                sda1 = new MySqlDataAdapter(cmdother, con);
                DataTable dtOther = new DataTable();
                sda1.Fill(dtOther);
                if (dtOther.Rows.Count > 0)
                {
                    DataTable dtReportOther = GenerateTransposedTable(dtOther);
                    DataRow dr = dtReportOther.NewRow();
                    dr[0] = "total";

                    var columns = dtReportOther.Columns.Cast<DataColumn>();
                    int i = 1;
                    foreach (var col in columns)
                    {
                        DataColumn colm = (DataColumn)col;
                        if (!colm.ColumnName.Equals("Bank"))
                        {
                            dr[i] = Convert.ToDouble(dtReportOther.AsEnumerable().Sum(x => x.Field<Double>(colm.ColumnName)));
                            i++;
                        }
                    }
                    dtReportOther.Rows.Add(dr);
                    dataGridView3.DataSource = dtReportOther;
                    dataGridView3.Visible = true;

                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
