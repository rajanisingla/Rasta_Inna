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
using Rasta.Data;

namespace Rasta
{
    public partial class TreasuryReport : Form
    {
        string con = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        MySqlDataAdapter sda1;
        public TreasuryReport()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                string Cmdyear = "SELECT distinct year(InvoiceDate) as year from tbl_accountpayable";
                sda1 = new MySqlDataAdapter(Cmdyear, con);
                DataTable dtYear = new DataTable();
                sda1.Fill(dtYear);

                this.cmbYear.DataSource = dtYear;
                this.cmbYear.DisplayMember = "year";
                this.cmbYear.ValueMember = "year";
                cmbYear.SelectedIndex = 0;
                string CmdCurrencyType = "SELECT distinct CurrencyName,CurrencyID FROM tbl_Currency";
                sda1 = new MySqlDataAdapter(CmdCurrencyType, con);
                DataTable dtCurrencyType = new DataTable();
                sda1.Fill(dtCurrencyType);

                this.cmbCurrency.DataSource = dtCurrencyType;
                this.cmbCurrency.DisplayMember = "CurrencyName";
                this.cmbCurrency.ValueMember = "CurrencyID";
                cmbCurrency.SelectedIndex = -1;
                dgvRevenue.Visible = false;
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                string Cmdyear = "SELECT distinct year(InvoiceDate) as year from tbl_accountpayable";
                sda1 = new MySqlDataAdapter(Cmdyear, con);
                DataTable dtYear = new DataTable();
                sda1.Fill(dtYear);

                this.cmbExpenseYear.DataSource = dtYear;
                this.cmbExpenseYear.DisplayMember = "year";
                this.cmbExpenseYear.ValueMember = "year";
                cmbExpenseYear.SelectedIndex = 0;

                string CmdCurrencyType = "SELECT distinct CurrencyName,CurrencyID FROM tbl_Currency";
                sda1 = new MySqlDataAdapter(CmdCurrencyType, con);
                DataTable dtCurrencyType = new DataTable();
                sda1.Fill(dtCurrencyType);

                this.cmbExpenseCurrency.DataSource = dtCurrencyType;
                this.cmbExpenseCurrency.DisplayMember = "CurrencyName";
                this.cmbExpenseCurrency.ValueMember = "CurrencyID";
                cmbExpenseCurrency.SelectedIndex = -1;
                dataGridView1.Visible = false;

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCurrency.SelectedIndex == -1 || cmbYear.SelectedIndex == -1)
            {
                dgvRevenue.Visible = false;

            }
            else
            {
                string CmdBank = "select concat(b.bankname,' (',c.currencyname,')') as Bank,p.projctname," +
                                  "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 1 THEN a.amount/ce.exchangerateinusd END),0) AS Jan," +
                                  "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 2 THEN a.amount/ce.exchangerateinusd END),0) AS Feb," +
                                  "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 3 THEN a.amount/ce.exchangerateinusd END),0) AS Mar," +
                                  "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 4 THEN a.amount/ce.exchangerateinusd END),0) AS Apr," +
                                  "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 5 THEN a.amount/ce.exchangerateinusd END),0) AS May," +
                                  "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 6 THEN a.amount/ce.exchangerateinusd END),0) AS Jun," +
                                  "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 7 THEN a.amount/ce.exchangerateinusd END),0) AS Jul," +
                                  "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 8 THEN a.amount/ce.exchangerateinusd END),0) AS Aug," +
                                  "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 9 THEN a.amount/ce.exchangerateinusd END),0) AS Sep," +
                                  "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 10 THEN a.amount/ce.exchangerateinusd END),0) AS Oct," +
                                  "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 11 THEN a.amount/ce.exchangerateinusd END),0) AS Nov," +
                                  "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 12 THEN a.amount/ce.exchangerateinusd END),0) AS Decm " +
                                  "from rasta.vw_AccountReceivable a left join rasta.tbl_project p on p.projectid=a.projectid " +
                                  "left join rasta.tbl_bank b on b.bankid=a.BankID  " +
                                  "left join rasta.tbl_currencyexchange ce on ce.currencyid='" + cmbCurrency.SelectedValue.ToString() + "' " +
                                  "left join rasta.tbl_currency c on c.currencyid=ce.currencyid " +
                                  "group by  p.projectid";
                sda1 = new MySqlDataAdapter(CmdBank, con);
                DataTable dtExpenseType = new DataTable();
                sda1.Fill(dtExpenseType);
                if (dtExpenseType.Rows.Count > 0)
                {
                    DataRow dr = dtExpenseType.NewRow();
                    dr[0] = "Total";
                    dr[1] = "";
                    dr[2] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Jan")));
                    dr[3] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Feb")));
                    dr[4] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Mar")));
                    dr[5] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Apr")));
                    dr[6] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("May")));
                    dr[7] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Jun")));
                    dr[8] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Jul")));
                    dr[9] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Aug")));
                    dr[10] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Sep")));
                    dr[11] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Oct")));
                    dr[12] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Nov")));
                    dr[13] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Decm")));
                    dtExpenseType.Rows.Add(dr);
                    dtExpenseType.Columns.Add("Subtotal", typeof(Double));
                    dtExpenseType.Columns["Subtotal"].Expression = "Jan+Feb+Mar+Apr+May+Jun+Jul+Aug+Sep+Oct+Nov+Decm";
                    dgvRevenue.DataSource = dtExpenseType;
                    dgvRevenue.Visible = true;

                }
            }
        }

        private void TreasuryReport_Load(object sender, EventArgs e)
        {
            string Cmdyear = "SELECT distinct year(InvoiceDate) as year from tbl_accountpayable";
            sda1 = new MySqlDataAdapter(Cmdyear, con);
            DataTable dtYear = new DataTable();
            sda1.Fill(dtYear);

            this.cmbDetailYear.DataSource = dtYear;
            this.cmbDetailYear.DisplayMember = "year";
            this.cmbDetailYear.ValueMember = "year";
            cmbDetailYear.SelectedIndex = 0;

            string CmdCurrencyType = "SELECT distinct CurrencyName,CurrencyID FROM tbl_Currency";
            sda1 = new MySqlDataAdapter(CmdCurrencyType, con);
            DataTable dtCurrencyType = new DataTable();
            sda1.Fill(dtCurrencyType);

            this.cmbDetailCurrency.DataSource = dtCurrencyType;
            this.cmbDetailCurrency.DisplayMember = "CurrencyName";
            this.cmbDetailCurrency.ValueMember = "CurrencyID";
            cmbDetailCurrency.SelectedIndex = 0;
            dgvRevenue.Visible = false;
        }

        private void cmbExpenseCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbExpenseCurrency.SelectedIndex == -1)
            {
                dataGridView1.Visible = false;

            }
            else
            {
                string CmdBank = "select concat(c.currencyname) as Currency,p.projctname," +
"IFNULL(sum(case when year(a.invoicedate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and month(a.invoicedate) = 1 then a.amount/ce.exchangerateinusd END),0) as jan," +
  "IFNULL(sum(case when year(a.invoicedate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and month(a.invoicedate) = 2 then a.amount/ce.exchangerateinusd END),0) as feb," +
  "IFNULL(sum(case when year(a.invoicedate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and month(a.invoicedate) = 3 then a.amount/ce.exchangerateinusd END),0) as mar," +
  "IFNULL(sum(case when year(a.invoicedate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and month(a.invoicedate) = 4 then a.amount/ce.exchangerateinusd END),0) as apr," +
  "IFNULL(sum(case when year(a.invoicedate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and month(a.invoicedate) = 5 then a.amount/ce.exchangerateinusd END),0) as may," +
  "IFNULL(sum(case when year(a.invoicedate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and month(a.invoicedate) = 6 then a.amount/ce.exchangerateinusd END),0) as jun," +
  "IFNULL(sum(case when year(a.invoicedate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and month(a.invoicedate) = 7 then a.amount/ce.exchangerateinusd END),0) as jul," +
  "IFNULL(sum(case when year(a.invoicedate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and month(a.invoicedate) = 8 then a.amount/ce.exchangerateinusd END),0) as aug," +
  "IFNULL(sum(case when year(a.invoicedate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and month(a.invoicedate) = 9 then a.amount/ce.exchangerateinusd END),0) as sep," +
  "IFNULL(sum(case when year(a.invoicedate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and month(a.invoicedate) = 10 then a.amount/ce.exchangerateinusd END),0) as oct," +
  "IFNULL(sum(case when year(a.invoicedate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and month(a.invoicedate) = 11 then a.amount/ce.exchangerateinusd END),0) as nov," +
  "IFNULL(sum(case when year(a.invoicedate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and month(a.invoicedate) = 12 then a.amount/ce.exchangerateinusd END),0) as decm " +
"from rasta.vw_accountpayable a " +
"left join rasta.tbl_approjectexpense ad on ad.apid=a.apid " +
"left join rasta.tbl_project p on p.projectid = ad.projectid " +
                        "left join rasta.tbl_currencyexchange ce on ce.currencyid='" + cmbExpenseCurrency.SelectedValue.ToString() + "' " +
                        "left join rasta.tbl_currency c on c.currencyid=ce.currencyid " +
"where a.costcodeid=1 " +
"group by  p.projctname";

                sda1 = new MySqlDataAdapter(CmdBank, con);
                DataTable dtExpenseType = new DataTable();
                sda1.Fill(dtExpenseType);
                if (dtExpenseType.Rows.Count > 0)
                {
                    DataRow dr = dtExpenseType.NewRow();
                    dr[0] = "Total";
                    dr[1] = "";
                    dr[2] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Jan")));
                    dr[3] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Feb")));
                    dr[4] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Mar")));
                    dr[5] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Apr")));
                    dr[6] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("May")));
                    dr[7] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Jun")));
                    dr[8] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Jul")));
                    dr[9] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Aug")));
                    dr[10] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Sep")));
                    dr[11] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Oct")));
                    dr[12] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Nov")));
                    dr[13] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Decm")));
                    dtExpenseType.Rows.Add(dr);
                    dtExpenseType.Columns.Add("Subtotal", typeof(Double));
                    dtExpenseType.Columns["Subtotal"].Expression = "Jan+Feb+Mar+Apr+May+Jun+Jul+Aug+Sep+Oct+Nov+Decm";
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
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cmbDetailCurrency.SelectedIndex != -1 && cmbDetailYear.SelectedIndex != -1)

                using (var context = new rastaEntities())
                {
                    DataTable datatable = new DataTable();
                    datatable.Columns.Add("Projects");
                    datatable.Columns.Add("Jan");
                    datatable.Columns.Add("Feb");
                    datatable.Columns.Add("Mar");
                    datatable.Columns.Add("Apr");
                    datatable.Columns.Add("May");
                    datatable.Columns.Add("Jun");
                    datatable.Columns.Add("Jul");
                    datatable.Columns.Add("Aug");
                    datatable.Columns.Add("Sep");
                    datatable.Columns.Add("Oct");
                    datatable.Columns.Add("Nov");
                    datatable.Columns.Add("Dec");
                    datatable.Columns.Add("Total");

                    int selectedYear = Convert.ToInt32(cmbDetailYear.SelectedValue);
                    int selectedCurrency = Convert.ToInt32(cmbDetailCurrency.SelectedValue);

                    GetRevenueData(context, datatable, selectedYear, selectedCurrency);
                    GetExpenseData(context, datatable, selectedYear, selectedCurrency);

                   

                    IList<tbl_accountreceivable> ars = context.tbl_accountreceivable.Where(a => a.InvoiceDate.Value.Year == selectedYear && a.CurrencyID == selectedCurrency).ToList();
                    IList<tbl_accountpayable> aps = context.tbl_accountpayable.Where(a => a.InvoiceDate.Value.Year == selectedYear && a.CurrencyID == selectedCurrency).ToList();

                    GetInhandCashflow(datatable, ars, aps);
                    GetForecastCashflow(datatable, ars, aps);
                    GetTotalCashflow(datatable, ars, aps);

                    dgvDetail.AutoGenerateColumns = true;
                    dgvDetail.DataSource = datatable;
                }
        }

        private static void GetInhandCashflow(DataTable datatable, IList<tbl_accountreceivable> ars, IList<tbl_accountpayable> aps)
        {
            DataRow dtNetInhand = datatable.NewRow();
            datatable.Rows.Add(dtNetInhand);
            dtNetInhand["Projects"] = "Net Cashflow Inhand";

            IList<tbl_accountpayable> inhandsExpense = aps.Where(a => (a.IsForecast.Value == 0) && (a.IsPaid.Value == 1) && (a.IsApproved.Value == 1)).ToList();
            List<tbl_accountreceivable> inhandsRevenue = ars.Where(a => (a.IsForecast.Value == 0) && (a.CreditToBank.Value == 1)).ToList();

            dtNetInhand["Jan"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(1)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(1)).Sum(s => s.Amount);

            dtNetInhand["Feb"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(2)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(2)).Sum(s => s.Amount);
            dtNetInhand["Mar"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(3)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(3)).Sum(s => s.Amount);
            dtNetInhand["Apr"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(4)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(4)).Sum(s => s.Amount);
            dtNetInhand["May"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(5)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(5)).Sum(s => s.Amount);
            dtNetInhand["Jun"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(6)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(6)).Sum(s => s.Amount);
            dtNetInhand["Jul"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(7)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(7)).Sum(s => s.Amount);
            dtNetInhand["Aug"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(8)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(8)).Sum(s => s.Amount);
            dtNetInhand["Sep"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(9)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(9)).Sum(s => s.Amount);
            dtNetInhand["Oct"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(10)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(10)).Sum(s => s.Amount);
            dtNetInhand["Nov"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(11)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(11)).Sum(s => s.Amount);
            dtNetInhand["Dec"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(12)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(12)).Sum(s => s.Amount);
            dtNetInhand["Total"] = inhandsRevenue.Sum(s => s.Amount) - inhandsExpense.Sum(s => s.Amount);
        }

        private static void GetForecastCashflow(DataTable datatable, IList<tbl_accountreceivable> ars, IList<tbl_accountpayable> aps)
        {
            DataRow dtNetInhand = datatable.NewRow();
            datatable.Rows.Add(dtNetInhand);
            dtNetInhand["Projects"] = "Net Cashflow Forecast";

            IList<tbl_accountpayable> inhandsExpense = aps.Where(a => (a.IsForecast.Value == 1) || ((a.IsPaid.Value == 0) || (a.IsApproved.Value == 0))).ToList();
            List<tbl_accountreceivable> inhandsRevenue = ars.Where(a => (a.IsForecast.Value == 1) || (a.CreditToBank.Value == 0)).ToList();

            dtNetInhand["Jan"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(1)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(1)).Sum(s => s.Amount);

            dtNetInhand["Feb"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(2)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(2)).Sum(s => s.Amount);
            dtNetInhand["Mar"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(3)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(3)).Sum(s => s.Amount);
            dtNetInhand["Apr"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(4)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(4)).Sum(s => s.Amount);
            dtNetInhand["May"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(5)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(5)).Sum(s => s.Amount);
            dtNetInhand["Jun"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(6)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(6)).Sum(s => s.Amount);
            dtNetInhand["Jul"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(7)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(7)).Sum(s => s.Amount);
            dtNetInhand["Aug"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(8)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(8)).Sum(s => s.Amount);
            dtNetInhand["Sep"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(9)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(9)).Sum(s => s.Amount);
            dtNetInhand["Oct"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(10)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(10)).Sum(s => s.Amount);
            dtNetInhand["Nov"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(11)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(11)).Sum(s => s.Amount);
            dtNetInhand["Dec"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(12)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(12)).Sum(s => s.Amount);
            dtNetInhand["Total"] = inhandsRevenue.Sum(s => s.Amount) - inhandsExpense.Sum(s => s.Amount);
        }

        private static void GetTotalCashflow(DataTable datatable, IList<tbl_accountreceivable> ars, IList<tbl_accountpayable> aps)
        {
            DataRow dtNetInhand = datatable.NewRow();
            datatable.Rows.Add(dtNetInhand);
            dtNetInhand["Projects"] = "Net Cashflow (Forecast & Inhand)";

            IList<tbl_accountpayable> inhandsExpense = aps.ToList();
            List<tbl_accountreceivable> inhandsRevenue = ars.ToList();

            dtNetInhand["Jan"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(1)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(1)).Sum(s => s.Amount);

            dtNetInhand["Feb"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(2)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(2)).Sum(s => s.Amount);
            dtNetInhand["Mar"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(3)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(3)).Sum(s => s.Amount);
            dtNetInhand["Apr"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(4)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(4)).Sum(s => s.Amount);
            dtNetInhand["May"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(5)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(5)).Sum(s => s.Amount);
            dtNetInhand["Jun"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(6)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(6)).Sum(s => s.Amount);
            dtNetInhand["Jul"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(7)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(7)).Sum(s => s.Amount);
            dtNetInhand["Aug"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(8)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(8)).Sum(s => s.Amount);
            dtNetInhand["Sep"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(9)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(9)).Sum(s => s.Amount);
            dtNetInhand["Oct"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(10)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(10)).Sum(s => s.Amount);
            dtNetInhand["Nov"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(11)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(11)).Sum(s => s.Amount);
            dtNetInhand["Dec"] = inhandsRevenue.Where(a => a.InvoiceDate.Value.Month.Equals(12)).Sum(s => s.Amount)
            - inhandsExpense.Where(a => a.InvoiceDate.Value.Month.Equals(12)).Sum(s => s.Amount);
            dtNetInhand["Total"] = inhandsRevenue.Sum(s => s.Amount) - inhandsExpense.Sum(s => s.Amount);
        }

        private static void GetExpenseData(rastaEntities context, DataTable datatable, int selectedYear, int selectedCurrency)
        {
            IList<tbl_accountpayable> aps = context.tbl_accountpayable.Where(a => a.InvoiceDate.Value.Year == selectedYear && a.CurrencyID == selectedCurrency).ToList();

            //Project Expense = Cost Code = 1
            var projectsData = context.tbl_approjectexpense.Join(
                aps.Where(a => a.CostCodeID.Equals(1) && (a.IsForecast.Value == 0) && (a.IsPaid.Value == 1) && (a.IsApproved.Value == 1)), 
                a => a.APID, 
                p => p.APID, 
                (a, p) => new { a, p }).ToList();

            projectsData.ForEach(prj =>
            {
                DataRow dr = datatable.NewRow();
                datatable.Rows.Add(dr);

                var projectData = projectsData.Where(p => p.a.ProjectID.Equals(prj.a.ProjectID)).ToList();

                if (projectData.Count > 0)
                {
                    dr["Projects"] = context.tbl_project.Single(p2 => p2.ProjectID.Equals(prj.a.ProjectID)).ProjctName;
                    dr["Jan"] = projectData.Where(a => a.p.InvoiceDate.Value.Month.Equals(1)).Sum(s => s.p.Amount);
                    dr["Feb"] = projectData.Where(a => a.p.InvoiceDate.Value.Month.Equals(2)).Sum(s => s.p.Amount);
                    dr["Mar"] = projectData.Where(a => a.p.InvoiceDate.Value.Month.Equals(3)).Sum(s => s.p.Amount);
                    dr["Apr"] = projectData.Where(a => a.p.InvoiceDate.Value.Month.Equals(4)).Sum(s => s.p.Amount);
                    dr["May"] = projectData.Where(a => a.p.InvoiceDate.Value.Month.Equals(5)).Sum(s => s.p.Amount);
                    dr["Jun"] = projectData.Where(a => a.p.InvoiceDate.Value.Month.Equals(6)).Sum(s => s.p.Amount);
                    dr["Jul"] = projectData.Where(a => a.p.InvoiceDate.Value.Month.Equals(7)).Sum(s => s.p.Amount);
                    dr["Aug"] = projectData.Where(a => a.p.InvoiceDate.Value.Month.Equals(8)).Sum(s => s.p.Amount);
                    dr["Sep"] = projectData.Where(a => a.p.InvoiceDate.Value.Month.Equals(9)).Sum(s => s.p.Amount);
                    dr["Oct"] = projectData.Where(a => a.p.InvoiceDate.Value.Month.Equals(10)).Sum(s => s.p.Amount);
                    dr["Nov"] = projectData.Where(a => a.p.InvoiceDate.Value.Month.Equals(11)).Sum(s => s.p.Amount);
                    dr["Dec"] = projectData.Where(a => a.p.InvoiceDate.Value.Month.Equals(12)).Sum(s => s.p.Amount);
                    dr["Total"] = projectData.Sum(s => s.p.Amount);
                }
            });

            DataRow drAll = datatable.NewRow();
            datatable.Rows.Add(drAll);
            drAll["Projects"] = "Total Project Expenses";
            drAll["Jan"] = projectsData.Where(a => a.p.InvoiceDate.Value.Month.Equals(1)).Sum(s => s.p.Amount);
            drAll["Feb"] = projectsData.Where(a => a.p.InvoiceDate.Value.Month.Equals(2)).Sum(s => s.p.Amount);
            drAll["Mar"] = projectsData.Where(a => a.p.InvoiceDate.Value.Month.Equals(3)).Sum(s => s.p.Amount);
            drAll["Apr"] = projectsData.Where(a => a.p.InvoiceDate.Value.Month.Equals(4)).Sum(s => s.p.Amount);
            drAll["May"] = projectsData.Where(a => a.p.InvoiceDate.Value.Month.Equals(5)).Sum(s => s.p.Amount);
            drAll["Jun"] = projectsData.Where(a => a.p.InvoiceDate.Value.Month.Equals(6)).Sum(s => s.p.Amount);
            drAll["Jul"] = projectsData.Where(a => a.p.InvoiceDate.Value.Month.Equals(7)).Sum(s => s.p.Amount);
            drAll["Aug"] = projectsData.Where(a => a.p.InvoiceDate.Value.Month.Equals(8)).Sum(s => s.p.Amount);
            drAll["Sep"] = projectsData.Where(a => a.p.InvoiceDate.Value.Month.Equals(9)).Sum(s => s.p.Amount);
            drAll["Oct"] = projectsData.Where(a => a.p.InvoiceDate.Value.Month.Equals(10)).Sum(s => s.p.Amount);
            drAll["Nov"] = projectsData.Where(a => a.p.InvoiceDate.Value.Month.Equals(11)).Sum(s => s.p.Amount);
            drAll["Dec"] = projectsData.Where(a => a.p.InvoiceDate.Value.Month.Equals(12)).Sum(s => s.p.Amount);
            drAll["Total"] = projectsData.Sum(s => s.p.Amount);

            var departmentsData = context.tbl_apdepartmentexpense.Join(
    aps.Where(a => a.CostCodeID.Equals(2) && (a.IsForecast.Value == 0) && (a.IsPaid.Value == 1) && (a.IsApproved.Value == 1)),
    a => a.APID,
    p => p.APID,
    (a, p) => new { a, p }).ToList();

            departmentsData.ForEach(prj =>
            {
                DataRow dr = datatable.NewRow();
                datatable.Rows.Add(dr);

                var departmentData = departmentsData.Where(p => p.a.DepartmentID.Equals(prj.a.DepartmentID)).ToList();

                if (departmentData.Count > 0)
                {
                    dr["Projects"] = context.tbl_department.Single(p2 => p2.DepartmentID.Equals(prj.a.DepartmentID)).DepartmentName;
                    dr["Jan"] = departmentData.Where(a => a.p.InvoiceDate.Value.Month.Equals(1)).Sum(s => s.p.Amount);
                    dr["Feb"] = departmentData.Where(a => a.p.InvoiceDate.Value.Month.Equals(2)).Sum(s => s.p.Amount);
                    dr["Mar"] = departmentData.Where(a => a.p.InvoiceDate.Value.Month.Equals(3)).Sum(s => s.p.Amount);
                    dr["Apr"] = departmentData.Where(a => a.p.InvoiceDate.Value.Month.Equals(4)).Sum(s => s.p.Amount);
                    dr["May"] = departmentData.Where(a => a.p.InvoiceDate.Value.Month.Equals(5)).Sum(s => s.p.Amount);
                    dr["Jun"] = departmentData.Where(a => a.p.InvoiceDate.Value.Month.Equals(6)).Sum(s => s.p.Amount);
                    dr["Jul"] = departmentData.Where(a => a.p.InvoiceDate.Value.Month.Equals(7)).Sum(s => s.p.Amount);
                    dr["Aug"] = departmentData.Where(a => a.p.InvoiceDate.Value.Month.Equals(8)).Sum(s => s.p.Amount);
                    dr["Sep"] = departmentData.Where(a => a.p.InvoiceDate.Value.Month.Equals(9)).Sum(s => s.p.Amount);
                    dr["Oct"] = departmentData.Where(a => a.p.InvoiceDate.Value.Month.Equals(10)).Sum(s => s.p.Amount);
                    dr["Nov"] = departmentData.Where(a => a.p.InvoiceDate.Value.Month.Equals(11)).Sum(s => s.p.Amount);
                    dr["Dec"] = departmentData.Where(a => a.p.InvoiceDate.Value.Month.Equals(12)).Sum(s => s.p.Amount);
                    dr["Total"] = departmentData.Sum(s => s.p.Amount);
                }
            });

            DataRow drDepartmentAll = datatable.NewRow();
            datatable.Rows.Add(drDepartmentAll);
            drDepartmentAll["Projects"] = "Total Other Expenses";
            drDepartmentAll["Jan"] = departmentsData.Where(a => a.p.InvoiceDate.Value.Month.Equals(1)).Sum(s => s.p.Amount);
            drDepartmentAll["Feb"] = departmentsData.Where(a => a.p.InvoiceDate.Value.Month.Equals(2)).Sum(s => s.p.Amount);
            drDepartmentAll["Mar"] = departmentsData.Where(a => a.p.InvoiceDate.Value.Month.Equals(3)).Sum(s => s.p.Amount);
            drDepartmentAll["Apr"] = departmentsData.Where(a => a.p.InvoiceDate.Value.Month.Equals(4)).Sum(s => s.p.Amount);
            drDepartmentAll["May"] = departmentsData.Where(a => a.p.InvoiceDate.Value.Month.Equals(5)).Sum(s => s.p.Amount);
            drDepartmentAll["Jun"] = departmentsData.Where(a => a.p.InvoiceDate.Value.Month.Equals(6)).Sum(s => s.p.Amount);
            drDepartmentAll["Jul"] = departmentsData.Where(a => a.p.InvoiceDate.Value.Month.Equals(7)).Sum(s => s.p.Amount);
            drDepartmentAll["Aug"] = departmentsData.Where(a => a.p.InvoiceDate.Value.Month.Equals(8)).Sum(s => s.p.Amount);
            drDepartmentAll["Sep"] = departmentsData.Where(a => a.p.InvoiceDate.Value.Month.Equals(9)).Sum(s => s.p.Amount);
            drDepartmentAll["Oct"] = departmentsData.Where(a => a.p.InvoiceDate.Value.Month.Equals(10)).Sum(s => s.p.Amount);
            drDepartmentAll["Nov"] = departmentsData.Where(a => a.p.InvoiceDate.Value.Month.Equals(11)).Sum(s => s.p.Amount);
            drDepartmentAll["Dec"] = departmentsData.Where(a => a.p.InvoiceDate.Value.Month.Equals(12)).Sum(s => s.p.Amount);
            drDepartmentAll["Total"] = departmentsData.Sum(s => s.p.Amount);


            var inhandsData = aps.Where(a => (a.IsForecast.Value == 0) && (a.IsPaid.Value == 1) && (a.IsApproved.Value == 1)).ToList();

            DataRow drinhand = datatable.NewRow();
            datatable.Rows.Add(drinhand);
            drinhand["Projects"] = "Total Inhand Expenses";
            drinhand["Jan"] = inhandsData.Where(a => a.InvoiceDate.Value.Month.Equals(1)).Sum(s => s.Amount);
            drinhand["Feb"] = inhandsData.Where(a => a.InvoiceDate.Value.Month.Equals(2)).Sum(s => s.Amount);
            drinhand["Mar"] = inhandsData.Where(a => a.InvoiceDate.Value.Month.Equals(3)).Sum(s => s.Amount);
            drinhand["Apr"] = inhandsData.Where(a => a.InvoiceDate.Value.Month.Equals(4)).Sum(s => s.Amount);
            drinhand["May"] = inhandsData.Where(a => a.InvoiceDate.Value.Month.Equals(5)).Sum(s => s.Amount);
            drinhand["Jun"] = inhandsData.Where(a => a.InvoiceDate.Value.Month.Equals(6)).Sum(s => s.Amount);
            drinhand["Jul"] = inhandsData.Where(a => a.InvoiceDate.Value.Month.Equals(7)).Sum(s => s.Amount);
            drinhand["Aug"] = inhandsData.Where(a => a.InvoiceDate.Value.Month.Equals(8)).Sum(s => s.Amount);
            drinhand["Sep"] = inhandsData.Where(a => a.InvoiceDate.Value.Month.Equals(9)).Sum(s => s.Amount);
            drinhand["Oct"] = inhandsData.Where(a => a.InvoiceDate.Value.Month.Equals(10)).Sum(s => s.Amount);
            drinhand["Nov"] = inhandsData.Where(a => a.InvoiceDate.Value.Month.Equals(11)).Sum(s => s.Amount);
            drinhand["Dec"] = inhandsData.Where(a => a.InvoiceDate.Value.Month.Equals(12)).Sum(s => s.Amount);
            drinhand["Total"] = inhandsData.Sum(s => s.Amount);

            var forecastsData = aps.Where(a => (a.IsForecast.Value == 1) || ((a.IsPaid.Value == 0) || (a.IsApproved.Value == 0))).ToList();

            DataRow drforecast = datatable.NewRow();
            datatable.Rows.Add(drforecast);
            drforecast["Projects"] = "Total Forecast Expenses";
            drforecast["Jan"] = forecastsData.Where(a => a.InvoiceDate.Value.Month.Equals(1)).Sum(s => s.Amount);
            drforecast["Feb"] = forecastsData.Where(a => a.InvoiceDate.Value.Month.Equals(2)).Sum(s => s.Amount);
            drforecast["Mar"] = forecastsData.Where(a => a.InvoiceDate.Value.Month.Equals(3)).Sum(s => s.Amount);
            drforecast["Apr"] = forecastsData.Where(a => a.InvoiceDate.Value.Month.Equals(4)).Sum(s => s.Amount);
            drforecast["May"] = forecastsData.Where(a => a.InvoiceDate.Value.Month.Equals(5)).Sum(s => s.Amount);
            drforecast["Jun"] = forecastsData.Where(a => a.InvoiceDate.Value.Month.Equals(6)).Sum(s => s.Amount);
            drforecast["Jul"] = forecastsData.Where(a => a.InvoiceDate.Value.Month.Equals(7)).Sum(s => s.Amount);
            drforecast["Aug"] = forecastsData.Where(a => a.InvoiceDate.Value.Month.Equals(8)).Sum(s => s.Amount);
            drforecast["Sep"] = forecastsData.Where(a => a.InvoiceDate.Value.Month.Equals(9)).Sum(s => s.Amount);
            drforecast["Oct"] = forecastsData.Where(a => a.InvoiceDate.Value.Month.Equals(10)).Sum(s => s.Amount);
            drforecast["Nov"] = forecastsData.Where(a => a.InvoiceDate.Value.Month.Equals(11)).Sum(s => s.Amount);
            drforecast["Dec"] = forecastsData.Where(a => a.InvoiceDate.Value.Month.Equals(12)).Sum(s => s.Amount);
            drforecast["Total"] = forecastsData.Sum(s => s.Amount);

            DataRow drcompleteExpense = datatable.NewRow();
            datatable.Rows.Add(drcompleteExpense);
            drcompleteExpense["Projects"] = "Total (Inhand + Forecast) Expenses";
            drcompleteExpense["Jan"] = aps.Where(a => a.InvoiceDate.Value.Month.Equals(1)).Sum(s => s.Amount);
            drcompleteExpense["Feb"] = aps.Where(a => a.InvoiceDate.Value.Month.Equals(2)).Sum(s => s.Amount);
            drcompleteExpense["Mar"] = aps.Where(a => a.InvoiceDate.Value.Month.Equals(3)).Sum(s => s.Amount);
            drcompleteExpense["Apr"] = aps.Where(a => a.InvoiceDate.Value.Month.Equals(4)).Sum(s => s.Amount);
            drcompleteExpense["May"] = aps.Where(a => a.InvoiceDate.Value.Month.Equals(5)).Sum(s => s.Amount);
            drcompleteExpense["Jun"] = aps.Where(a => a.InvoiceDate.Value.Month.Equals(6)).Sum(s => s.Amount);
            drcompleteExpense["Jul"] = aps.Where(a => a.InvoiceDate.Value.Month.Equals(7)).Sum(s => s.Amount);
            drcompleteExpense["Aug"] = aps.Where(a => a.InvoiceDate.Value.Month.Equals(8)).Sum(s => s.Amount);
            drcompleteExpense["Sep"] = aps.Where(a => a.InvoiceDate.Value.Month.Equals(9)).Sum(s => s.Amount);
            drcompleteExpense["Oct"] = aps.Where(a => a.InvoiceDate.Value.Month.Equals(10)).Sum(s => s.Amount);
            drcompleteExpense["Nov"] = aps.Where(a => a.InvoiceDate.Value.Month.Equals(11)).Sum(s => s.Amount);
            drcompleteExpense["Dec"] = aps.Where(a => a.InvoiceDate.Value.Month.Equals(12)).Sum(s => s.Amount);
            drcompleteExpense["Total"] = aps.Sum(s => s.Amount);
        }

        private static void GetRevenueData(rastaEntities context, DataTable datatable, int selectedYear, int selectedCurrency)
        {
            IList<tbl_accountreceivable> ars = context.tbl_accountreceivable.Where(a => a.InvoiceDate.Value.Year == selectedYear && a.CurrencyID == selectedCurrency).ToList();

            List<tbl_accountreceivable> projectsData = ars.Where(a => a.ProjectID.HasValue && (a.IsForecast.Value == 0) && (a.CreditToBank.Value == 1)).ToList();

            projectsData.ForEach(p =>
            {
                DataRow dr = datatable.NewRow();
                datatable.Rows.Add(dr);

                IList<tbl_accountreceivable> projectData = projectsData.Where(p1 => p1.ProjectID.Value.Equals(p.ProjectID.Value)).ToList();

                if (projectData.Count > 0)
                {
                    dr["Projects"] = context.tbl_project.Single(p2 => p2.ProjectID.Equals(p.ProjectID.Value)).ProjctName;
                    dr["Jan"] = projectData.Where(a => a.InvoiceDate.Value.Month.Equals(1)).Sum(s => s.Amount);
                    dr["Feb"] = projectData.Where(a => a.InvoiceDate.Value.Month.Equals(2)).Sum(s => s.Amount);
                    dr["Mar"] = projectData.Where(a => a.InvoiceDate.Value.Month.Equals(3)).Sum(s => s.Amount);
                    dr["Apr"] = projectData.Where(a => a.InvoiceDate.Value.Month.Equals(4)).Sum(s => s.Amount);
                    dr["May"] = projectData.Where(a => a.InvoiceDate.Value.Month.Equals(5)).Sum(s => s.Amount);
                    dr["Jun"] = projectData.Where(a => a.InvoiceDate.Value.Month.Equals(6)).Sum(s => s.Amount);
                    dr["Jul"] = projectData.Where(a => a.InvoiceDate.Value.Month.Equals(7)).Sum(s => s.Amount);
                    dr["Aug"] = projectData.Where(a => a.InvoiceDate.Value.Month.Equals(8)).Sum(s => s.Amount);
                    dr["Sep"] = projectData.Where(a => a.InvoiceDate.Value.Month.Equals(9)).Sum(s => s.Amount);
                    dr["Oct"] = projectData.Where(a => a.InvoiceDate.Value.Month.Equals(10)).Sum(s => s.Amount);
                    dr["Nov"] = projectData.Where(a => a.InvoiceDate.Value.Month.Equals(11)).Sum(s => s.Amount);
                    dr["Dec"] = projectData.Where(a => a.InvoiceDate.Value.Month.Equals(12)).Sum(s => s.Amount);
                    dr["Total"] = projectData.Sum(s => s.Amount);
                }
            });

            DataRow drAll = datatable.NewRow();
            datatable.Rows.Add(drAll);
            drAll["Projects"] = "Total Project Revenues";
            drAll["Jan"] = projectsData.Where(a => a.InvoiceDate.Value.Month.Equals(1)).Sum(s => s.Amount);
            drAll["Feb"] = projectsData.Where(a => a.InvoiceDate.Value.Month.Equals(2)).Sum(s => s.Amount);
            drAll["Mar"] = projectsData.Where(a => a.InvoiceDate.Value.Month.Equals(3)).Sum(s => s.Amount);
            drAll["Apr"] = projectsData.Where(a => a.InvoiceDate.Value.Month.Equals(4)).Sum(s => s.Amount);
            drAll["May"] = projectsData.Where(a => a.InvoiceDate.Value.Month.Equals(5)).Sum(s => s.Amount);
            drAll["Jun"] = projectsData.Where(a => a.InvoiceDate.Value.Month.Equals(6)).Sum(s => s.Amount);
            drAll["Jul"] = projectsData.Where(a => a.InvoiceDate.Value.Month.Equals(7)).Sum(s => s.Amount);
            drAll["Aug"] = projectsData.Where(a => a.InvoiceDate.Value.Month.Equals(8)).Sum(s => s.Amount);
            drAll["Sep"] = projectsData.Where(a => a.InvoiceDate.Value.Month.Equals(9)).Sum(s => s.Amount);
            drAll["Oct"] = projectsData.Where(a => a.InvoiceDate.Value.Month.Equals(10)).Sum(s => s.Amount);
            drAll["Nov"] = projectsData.Where(a => a.InvoiceDate.Value.Month.Equals(11)).Sum(s => s.Amount);
            drAll["Dec"] = projectsData.Where(a => a.InvoiceDate.Value.Month.Equals(12)).Sum(s => s.Amount);
            drAll["Total"] = projectsData.Sum(s => s.Amount);



            List<tbl_accountreceivable> othersData = ars.Where(a => !a.ProjectID.HasValue && (a.IsForecast.Value == 0) && (a.CreditToBank.Value == 1)).ToList();

            othersData.ForEach(o =>
            {
                DataRow dr = datatable.NewRow();
                datatable.Rows.Add(dr);

                IList<tbl_accountreceivable> otherData = othersData.Where(o1 => o1.ExpenseTypeID.Value.Equals(o.ExpenseTypeID.Value)).ToList();

                if (otherData.Count > 0)
                {
                    dr["others"] = context.tbl_expensetype.Single(ex => ex.ExpenseTypeID.Equals(o.ExpenseTypeID.Value)).ExpenseTypeName;
                    dr["Jan"] = otherData.Where(a => a.InvoiceDate.Value.Month.Equals(1)).Sum(s => s.Amount);
                    dr["Feb"] = otherData.Where(a => a.InvoiceDate.Value.Month.Equals(2)).Sum(s => s.Amount);
                    dr["Mar"] = otherData.Where(a => a.InvoiceDate.Value.Month.Equals(3)).Sum(s => s.Amount);
                    dr["Apr"] = otherData.Where(a => a.InvoiceDate.Value.Month.Equals(4)).Sum(s => s.Amount);
                    dr["May"] = otherData.Where(a => a.InvoiceDate.Value.Month.Equals(5)).Sum(s => s.Amount);
                    dr["Jun"] = otherData.Where(a => a.InvoiceDate.Value.Month.Equals(6)).Sum(s => s.Amount);
                    dr["Jul"] = otherData.Where(a => a.InvoiceDate.Value.Month.Equals(7)).Sum(s => s.Amount);
                    dr["Aug"] = otherData.Where(a => a.InvoiceDate.Value.Month.Equals(8)).Sum(s => s.Amount);
                    dr["Sep"] = otherData.Where(a => a.InvoiceDate.Value.Month.Equals(9)).Sum(s => s.Amount);
                    dr["Oct"] = otherData.Where(a => a.InvoiceDate.Value.Month.Equals(10)).Sum(s => s.Amount);
                    dr["Nov"] = otherData.Where(a => a.InvoiceDate.Value.Month.Equals(11)).Sum(s => s.Amount);
                    dr["Dec"] = otherData.Where(a => a.InvoiceDate.Value.Month.Equals(12)).Sum(s => s.Amount);
                    dr["Total"] = otherData.Sum(s => s.Amount);
                }
            });


            DataRow drAllOther = datatable.NewRow();
            datatable.Rows.Add(drAllOther);
            drAllOther["Projects"] = "Total Other Revenues";
            drAllOther["Jan"] = othersData.Where(a => a.InvoiceDate.Value.Month.Equals(1)).Sum(s => s.Amount);
            drAllOther["Feb"] = othersData.Where(a => a.InvoiceDate.Value.Month.Equals(2)).Sum(s => s.Amount);
            drAllOther["Mar"] = othersData.Where(a => a.InvoiceDate.Value.Month.Equals(3)).Sum(s => s.Amount);
            drAllOther["Apr"] = othersData.Where(a => a.InvoiceDate.Value.Month.Equals(4)).Sum(s => s.Amount);
            drAllOther["May"] = othersData.Where(a => a.InvoiceDate.Value.Month.Equals(5)).Sum(s => s.Amount);
            drAllOther["Jun"] = othersData.Where(a => a.InvoiceDate.Value.Month.Equals(6)).Sum(s => s.Amount);
            drAllOther["Jul"] = othersData.Where(a => a.InvoiceDate.Value.Month.Equals(7)).Sum(s => s.Amount);
            drAllOther["Aug"] = othersData.Where(a => a.InvoiceDate.Value.Month.Equals(8)).Sum(s => s.Amount);
            drAllOther["Sep"] = othersData.Where(a => a.InvoiceDate.Value.Month.Equals(9)).Sum(s => s.Amount);
            drAllOther["Oct"] = othersData.Where(a => a.InvoiceDate.Value.Month.Equals(10)).Sum(s => s.Amount);
            drAllOther["Nov"] = othersData.Where(a => a.InvoiceDate.Value.Month.Equals(11)).Sum(s => s.Amount);
            drAllOther["Dec"] = othersData.Where(a => a.InvoiceDate.Value.Month.Equals(12)).Sum(s => s.Amount);
            drAllOther["Total"] = othersData.Sum(s => s.Amount);


            List<tbl_accountreceivable> forecastsData = ars.Where(a => (a.IsForecast.Value == 1) || (a.CreditToBank.Value == 0)).ToList();

            DataRow drForecast = datatable.NewRow();
            datatable.Rows.Add(drForecast);
            drForecast["Projects"] = "Total Forecast Revenues";
            drForecast["Jan"] = forecastsData.Where(a => a.InvoiceDate.Value.Month.Equals(1)).Sum(s => s.Amount);
            drForecast["Feb"] = forecastsData.Where(a => a.InvoiceDate.Value.Month.Equals(2)).Sum(s => s.Amount);
            drForecast["Mar"] = forecastsData.Where(a => a.InvoiceDate.Value.Month.Equals(3)).Sum(s => s.Amount);
            drForecast["Apr"] = forecastsData.Where(a => a.InvoiceDate.Value.Month.Equals(4)).Sum(s => s.Amount);
            drForecast["May"] = forecastsData.Where(a => a.InvoiceDate.Value.Month.Equals(5)).Sum(s => s.Amount);
            drForecast["Jun"] = forecastsData.Where(a => a.InvoiceDate.Value.Month.Equals(6)).Sum(s => s.Amount);
            drForecast["Jul"] = forecastsData.Where(a => a.InvoiceDate.Value.Month.Equals(7)).Sum(s => s.Amount);
            drForecast["Aug"] = forecastsData.Where(a => a.InvoiceDate.Value.Month.Equals(8)).Sum(s => s.Amount);
            drForecast["Sep"] = forecastsData.Where(a => a.InvoiceDate.Value.Month.Equals(9)).Sum(s => s.Amount);
            drForecast["Oct"] = forecastsData.Where(a => a.InvoiceDate.Value.Month.Equals(10)).Sum(s => s.Amount);
            drForecast["Nov"] = forecastsData.Where(a => a.InvoiceDate.Value.Month.Equals(11)).Sum(s => s.Amount);
            drForecast["Dec"] = forecastsData.Where(a => a.InvoiceDate.Value.Month.Equals(12)).Sum(s => s.Amount);
            drForecast["Total"] = forecastsData.Sum(s => s.Amount);

            List<tbl_accountreceivable> inhandsData = ars.Where(a => (a.IsForecast.Value == 0) && (a.CreditToBank.Value == 1)).ToList();

            DataRow drinhand = datatable.NewRow();
            datatable.Rows.Add(drinhand);
            drinhand["Projects"] = "Total Inhand Revenues";
            drinhand["Jan"] = inhandsData.Where(a => a.InvoiceDate.Value.Month.Equals(1)).Sum(s => s.Amount);
            drinhand["Feb"] = inhandsData.Where(a => a.InvoiceDate.Value.Month.Equals(2)).Sum(s => s.Amount);
            drinhand["Mar"] = inhandsData.Where(a => a.InvoiceDate.Value.Month.Equals(3)).Sum(s => s.Amount);
            drinhand["Apr"] = inhandsData.Where(a => a.InvoiceDate.Value.Month.Equals(4)).Sum(s => s.Amount);
            drinhand["May"] = inhandsData.Where(a => a.InvoiceDate.Value.Month.Equals(5)).Sum(s => s.Amount);
            drinhand["Jun"] = inhandsData.Where(a => a.InvoiceDate.Value.Month.Equals(6)).Sum(s => s.Amount);
            drinhand["Jul"] = inhandsData.Where(a => a.InvoiceDate.Value.Month.Equals(7)).Sum(s => s.Amount);
            drinhand["Aug"] = inhandsData.Where(a => a.InvoiceDate.Value.Month.Equals(8)).Sum(s => s.Amount);
            drinhand["Sep"] = inhandsData.Where(a => a.InvoiceDate.Value.Month.Equals(9)).Sum(s => s.Amount);
            drinhand["Oct"] = inhandsData.Where(a => a.InvoiceDate.Value.Month.Equals(10)).Sum(s => s.Amount);
            drinhand["Nov"] = inhandsData.Where(a => a.InvoiceDate.Value.Month.Equals(11)).Sum(s => s.Amount);
            drinhand["Dec"] = inhandsData.Where(a => a.InvoiceDate.Value.Month.Equals(12)).Sum(s => s.Amount);
            drinhand["Total"] = inhandsData.Sum(s => s.Amount);


            DataRow drcompleteRevenue = datatable.NewRow();
            datatable.Rows.Add(drcompleteRevenue);
            drcompleteRevenue["Projects"] = "Total (Inhand + Forecast) Revenues";
            drcompleteRevenue["Jan"] = ars.Where(a => a.InvoiceDate.Value.Month.Equals(1)).Sum(s => s.Amount);
            drcompleteRevenue["Feb"] = ars.Where(a => a.InvoiceDate.Value.Month.Equals(2)).Sum(s => s.Amount);
            drcompleteRevenue["Mar"] = ars.Where(a => a.InvoiceDate.Value.Month.Equals(3)).Sum(s => s.Amount);
            drcompleteRevenue["Apr"] = ars.Where(a => a.InvoiceDate.Value.Month.Equals(4)).Sum(s => s.Amount);
            drcompleteRevenue["May"] = ars.Where(a => a.InvoiceDate.Value.Month.Equals(5)).Sum(s => s.Amount);
            drcompleteRevenue["Jun"] = ars.Where(a => a.InvoiceDate.Value.Month.Equals(6)).Sum(s => s.Amount);
            drcompleteRevenue["Jul"] = ars.Where(a => a.InvoiceDate.Value.Month.Equals(7)).Sum(s => s.Amount);
            drcompleteRevenue["Aug"] = ars.Where(a => a.InvoiceDate.Value.Month.Equals(8)).Sum(s => s.Amount);
            drcompleteRevenue["Sep"] = ars.Where(a => a.InvoiceDate.Value.Month.Equals(9)).Sum(s => s.Amount);
            drcompleteRevenue["Oct"] = ars.Where(a => a.InvoiceDate.Value.Month.Equals(10)).Sum(s => s.Amount);
            drcompleteRevenue["Nov"] = ars.Where(a => a.InvoiceDate.Value.Month.Equals(11)).Sum(s => s.Amount);
            drcompleteRevenue["Dec"] = ars.Where(a => a.InvoiceDate.Value.Month.Equals(12)).Sum(s => s.Amount);
            drcompleteRevenue["Total"] = ars.Sum(s => s.Amount);
        }
    }
}
