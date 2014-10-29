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
    public partial class ForecastReport : Form
    {
        string con = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        MySqlDataAdapter sda1;
        public ForecastReport()
        {
            InitializeComponent();
        }

        private void ForecastReport_Load(object sender, EventArgs e)
        {
            string Cmdyear = "SELECT distinct year(InvoiceDate) as year from tbl_AccountPayable";
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
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {

                string Cmdyear = "SELECT distinct year(InvoiceDate) as year from tbl_AccountPayable";
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

        private void cmbCurrency_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbCurrency.SelectedIndex == -1 || cmbYear.SelectedIndex == -1)
            {
                dgvRevenue.Visible = false;

            }
            else
            {
                string CmdBank = "select concat(b.bankname,' (',c.currencyname,')') as title,p.projctname," +
                                 "sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 1 THEN a.amount/ce.exchangerateinusd END) AS Jan," +
                                 "sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 2 THEN a.amount/ce.exchangerateinusd END) AS Feb," +
                                 "sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 3 THEN a.amount/ce.exchangerateinusd END) AS Mar," +
                                 "sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 4 THEN a.amount/ce.exchangerateinusd END) AS Apr," +
                                 "sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 5 THEN a.amount/ce.exchangerateinusd END) AS May," +
                                 "sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 6 THEN a.amount/ce.exchangerateinusd END) AS Jun," +
                                 "sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 7 THEN a.amount/ce.exchangerateinusd END) AS Jul," +
                                 "sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 8 THEN a.amount/ce.exchangerateinusd END) AS Aug," +
                                 "sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 9 THEN a.amount/ce.exchangerateinusd END) AS Sep," +
                                 "sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 10 THEN a.amount/ce.exchangerateinusd END) AS Oct," +
                                 "sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 11 THEN a.amount/ce.exchangerateinusd END) AS Nov," +
                                 "sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 12 THEN a.amount/ce.exchangerateinusd END) AS Decm " +
                                 "from rasta.vw_AccountReceivable a left join rasta.tbl_project p on p.projectid=a.projectid " +
                                 "left join rasta.tbl_bank b on b.bankid=a.BankID  " +
                                 "left join rasta.tbl_currencyexchange ce on ce.currencyid='" + cmbCurrency.SelectedValue.ToString() + "' " +
                                 "left join rasta.tbl_currency c on c.currencyid=ce.currencyid " +
                                 "where  (case when a.isforecast=0 then a.CreditTobank=0  else a.CreditTobank in(0,1)  end) " +
                                 "group by  p.projectid";
                sda1 = new MySqlDataAdapter(CmdBank, con);
                DataTable dtExpenseType = new DataTable();
                sda1.Fill(dtExpenseType);
                if (dtExpenseType.Rows.Count > 0)
                {
                    dgvRevenue.DataSource = dtExpenseType;
                    dgvRevenue.Visible = true;

                }
            }
        }

        private void cmbExpenseCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbExpenseCurrency.SelectedIndex == -1)
            {
                dataGridView1.Visible = false;

            }
            else
            {
                string CmdBank = "select concat(c.currencyname) as title,p.projctname," +
                                  "sum(case when year(a.invoicedate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and month(a.invoicedate) = 1 then a.amount/ce.exchangerateinusd end) as jan," +
                                  "sum(case when year(a.invoicedate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and month(a.invoicedate) = 2 then a.amount/ce.exchangerateinusd end) as feb," +
                                  "sum(case when year(a.invoicedate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and month(a.invoicedate) = 3 then a.amount/ce.exchangerateinusd end) as mar," +
                                  "sum(case when year(a.invoicedate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and month(a.invoicedate) = 4 then a.amount/ce.exchangerateinusd end) as apr," +
                                  "sum(case when year(a.invoicedate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and month(a.invoicedate) = 5 then a.amount/ce.exchangerateinusd end) as may," +
                                  "sum(case when year(a.invoicedate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and month(a.invoicedate) = 6 then a.amount/ce.exchangerateinusd end) as jun," +
                                  "sum(case when year(a.invoicedate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and month(a.invoicedate) = 7 then a.amount/ce.exchangerateinusd end) as jul," +
                                  "sum(case when year(a.invoicedate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and month(a.invoicedate) = 8 then a.amount/ce.exchangerateinusd end) as aug," +
                                  "sum(case when year(a.invoicedate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and month(a.invoicedate) = 9 then a.amount/ce.exchangerateinusd end) as sep," +
                                  "sum(case when year(a.invoicedate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and month(a.invoicedate) = 10 then a.amount/ce.exchangerateinusd end) as oct," +
                                  "sum(case when year(a.invoicedate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and month(a.invoicedate) = 11 then a.amount/ce.exchangerateinusd end) as nov," +
                                  "sum(case when year(a.invoicedate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and month(a.invoicedate) = 12 then a.amount/ce.exchangerateinusd end) as decm " +
                                  "from rasta.vw_accountpayable a " +
                                  "left join rasta.tbl_approjectexpense ad on ad.apid=a.apid " +
                                  "left join rasta.tbl_project p on p.projectid = ad.projectid " +
                                  "left join rasta.tbl_currencyexchange ce on ce.currencyid='" + cmbExpenseCurrency.SelectedValue.ToString() + "' " +
                                  "left join rasta.tbl_currency c on c.currencyid=ce.currencyid " +
                                  "where a.costcodeid=1 and (case when a.isforecast=0 then a.IsApproved=1 and a.IsPaid=0 else a.IsApproved in(0,1) and a.IsPaid in(0,1) end) " +
                                  "group by  p.projctname";

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
    }
}
