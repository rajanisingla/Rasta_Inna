using System;
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
                string CmdBank = "select concat(b.bankname,' (',c.currencyname,')') as title,p.projctname," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 1 THEN a.amount/ce.exchangerateinusd END),0) AS JanForecast," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=1 and MONTH(a.InvoiceDate) = 1 THEN a.amount/ce.exchangerateinusd END),0) AS JanActual," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 1 THEN a.amount/ce.exchangerateinusd END),0) - " +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=1 and MONTH(a.InvoiceDate) = 1 THEN a.amount/ce.exchangerateinusd END),0) AS JanDifference," +

                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) =2 THEN a.amount/ce.exchangerateinusd END),0) AS FebForecast," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=1 and MONTH(a.InvoiceDate) =2 THEN a.amount/ce.exchangerateinusd END),0) AS FebActual," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 2 THEN a.amount/ce.exchangerateinusd END),0) - " +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=1 and MONTH(a.InvoiceDate) = 2 THEN a.amount/ce.exchangerateinusd END),0) AS FebDifference," +

                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 3 THEN a.amount/ce.exchangerateinusd END),0) AS MarForecast," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=1 and MONTH(a.InvoiceDate) = 3 THEN a.amount/ce.exchangerateinusd END),0) AS MarActual," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 3 THEN a.amount/ce.exchangerateinusd END),0) - " +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=1 and MONTH(a.InvoiceDate) = 3 THEN a.amount/ce.exchangerateinusd END),0) AS MarDifference," +

                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 4 THEN a.amount/ce.exchangerateinusd END),0) AS AprForecast," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=1 and MONTH(a.InvoiceDate) = 4 THEN a.amount/ce.exchangerateinusd END),0) AS AprActual," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 4 THEN a.amount/ce.exchangerateinusd END),0) - " +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=1 and MONTH(a.InvoiceDate) = 4 THEN a.amount/ce.exchangerateinusd END),0) AS AprDifference," +

                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 5 THEN a.amount/ce.exchangerateinusd END),0) AS MayForecast," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=1 and MONTH(a.InvoiceDate) = 5 THEN a.amount/ce.exchangerateinusd END),0) AS MayActual," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 5 THEN a.amount/ce.exchangerateinusd END),0) - " +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=1 and MONTH(a.InvoiceDate) = 5 THEN a.amount/ce.exchangerateinusd END),0) AS MayDifference," +

                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 6 THEN a.amount/ce.exchangerateinusd END),0) AS JunForecast," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=1 and MONTH(a.InvoiceDate) = 6 THEN a.amount/ce.exchangerateinusd END),0) AS JunActual," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 6 THEN a.amount/ce.exchangerateinusd END),0) - " +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=1 and MONTH(a.InvoiceDate) = 6 THEN a.amount/ce.exchangerateinusd END),0) AS JunDifference," +

                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 7 THEN a.amount/ce.exchangerateinusd END),0) AS JulForecast," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=1 and MONTH(a.InvoiceDate) = 7 THEN a.amount/ce.exchangerateinusd END),0) AS JulActual," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 7 THEN a.amount/ce.exchangerateinusd END),0) - " +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=1 and MONTH(a.InvoiceDate) = 7 THEN a.amount/ce.exchangerateinusd END),0) AS JulDifference," +

                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 8 THEN a.amount/ce.exchangerateinusd END),0) AS AugForecast," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=1 and MONTH(a.InvoiceDate) = 8 THEN a.amount/ce.exchangerateinusd END),0) AS AugActual," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 8 THEN a.amount/ce.exchangerateinusd END),0) - " +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=1 and MONTH(a.InvoiceDate) = 8 THEN a.amount/ce.exchangerateinusd END),0) AS AugDifference," +

                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 9 THEN a.amount/ce.exchangerateinusd END),0) AS SepForecast," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=1 and MONTH(a.InvoiceDate) = 9 THEN a.amount/ce.exchangerateinusd END),0) AS SepActual," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 9 THEN a.amount/ce.exchangerateinusd END),0) - " +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=1 and MONTH(a.InvoiceDate) = 9 THEN a.amount/ce.exchangerateinusd END),0) AS SepDifference," +

                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 10 THEN a.amount/ce.exchangerateinusd END),0) AS OctForecast," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=1 and MONTH(a.InvoiceDate) = 10 THEN a.amount/ce.exchangerateinusd END),0) AS OctActual," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 10 THEN a.amount/ce.exchangerateinusd END),0) - " +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=1 and MONTH(a.InvoiceDate) = 10 THEN a.amount/ce.exchangerateinusd END),0) AS OctDifference," +

                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 11 THEN a.amount/ce.exchangerateinusd END),0) AS NovForecast," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=1 and MONTH(a.InvoiceDate) = 11 THEN a.amount/ce.exchangerateinusd END),0) AS NovActual," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 11 THEN a.amount/ce.exchangerateinusd END),0) - " +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=1 and MONTH(a.InvoiceDate) = 11 THEN a.amount/ce.exchangerateinusd END),0) AS NovDifference," +

                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 12 THEN a.amount/ce.exchangerateinusd END),0) AS DecForecast," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=1 and MONTH(a.InvoiceDate) = 12 THEN a.amount/ce.exchangerateinusd END),0) AS DecActual," +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=0 and MONTH(a.InvoiceDate) = 12 THEN a.amount/ce.exchangerateinusd END),0) - " +
                                "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + DateTime.Now.Year.ToString() + "' and a.IsForecast=1 and MONTH(a.InvoiceDate) = 12 THEN a.amount/ce.exchangerateinusd END),0) AS DecDifference " +

                                "from rasta.vw_AccountReceivable a left join rasta.tbl_project p on p.projectid=a.projectid " +
                                "left join rasta.tbl_bank b on b.bankid=a.BankID  " +
                               "left join rasta.tbl_currencyexchange ce on ce.currencyid='" + cmbCurrency.SelectedValue.ToString() + "' " +
                               "left join rasta.tbl_currency c on c.currencyid=ce.currencyid " +
                               "where  (case when a.isforecast=0 then a.CreditTobank=0  else a.CreditTobank in(0,1)  END) " +
                               "group by  p.projectid";
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

