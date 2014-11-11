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
    public partial class ITReport : Form
    {
        string con = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        MySqlDataAdapter sda1;
        public ITReport()
        {
            InitializeComponent();
        }

        private void ITReport_Load(object sender, EventArgs e)
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

        private void cmbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCurrency.SelectedIndex == -1 || cmbYear.SelectedIndex == -1)
            {
                dgvRevenue.Visible = false;

            }
            else
            {
                string CmdBank = "select concat(c.currencyname) as Currency,i.IPEXOPEXname,cbs.cbsname," +
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
                                  "from rasta.vw_AccountPayable a " +
                                  "left join rasta.tbl_APITExpense ad on ad.apid=a.apid " +
                                  "left join rasta.tbl_CBS cbs on cbs.cbsid=ad.cbsid " +
                                  "left join rasta.tbl_IPEXOPEX i on i.IPEXOPEXID = ad.IPEXOPEXID " +
                                  "left join rasta.tbl_currencyexchange ce on ce.currencyid='" + cmbCurrency.SelectedValue.ToString() + "' " +
                                  "left join rasta.tbl_currency c on c.currencyid=ce.currencyid " +
                                  "where a.costcodeid=3 and i.referencetype='CAPEX'";
                sda1 = new MySqlDataAdapter(CmdBank, con);
                DataTable dtExpenseType = new DataTable();
                sda1.Fill(dtExpenseType);
                if (dtExpenseType.Rows.Count > 0)
                {
                    DataRow dr = dtExpenseType.NewRow();
                    dr[0] = "Total";
                    dr[1] = "";
                    dr[2] = "";
                    dr[3] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Jan")));
                    dr[4] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Feb")));
                    dr[5] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Mar")));
                    dr[6] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Apr")));
                    dr[7] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("May")));
                    dr[8] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Jun")));
                    dr[9] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Jul")));
                    dr[10] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Aug")));
                    dr[11] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Sep")));
                    dr[12] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Oct")));
                    dr[13] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Nov")));
                    dr[14] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Decm")));
                    dtExpenseType.Rows.Add(dr);
                    dtExpenseType.Columns.Add("Subtotal", typeof(Double));
                    dtExpenseType.Columns["Subtotal"].Expression = "Jan+Feb+Mar+Apr+May+Jun+Jul+Aug+Sep+Oct+Nov+Decm";
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
                string CmdBank = "select concat(c.currencyname) as Currency,i.IPEXOPEXname,cbs.cbsname," +
                                  "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 1 THEN a.amount/ce.exchangerateinusd END),0) AS Jan," +
                                  "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 2 THEN a.amount/ce.exchangerateinusd END),0) AS Feb," +
                                  "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 3 THEN a.amount/ce.exchangerateinusd END),0) AS Mar," +
                                  "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 4 THEN a.amount/ce.exchangerateinusd END),0) AS Apr," +
                                  "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 5 THEN a.amount/ce.exchangerateinusd END),0) AS May," +
                                  "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 6 THEN a.amount/ce.exchangerateinusd END),0) AS Jun," +
                                  "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 7 THEN a.amount/ce.exchangerateinusd END),0) AS Jul," +
                                  "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 8 THEN a.amount/ce.exchangerateinusd END),0) AS Aug," +
                                  "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 9 THEN a.amount/ce.exchangerateinusd END),0) AS Sep," +
                                  "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 10 THEN a.amount/ce.exchangerateinusd END),0) AS Oct," +
                                  "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 11 THEN a.amount/ce.exchangerateinusd END),0) AS Nov," +
                                  "IFNULL(sum(CASE WHEN YEAR(a.InvoiceDate)='" + cmbExpenseYear.SelectedValue.ToString() + "' and MONTH(a.InvoiceDate) = 12 THEN a.amount/ce.exchangerateinusd END),0) AS Decm " +
                                  "from rasta.vw_AccountPayable a " +
                                  "left join rasta.tbl_APITExpense ad on ad.apid=a.apid " +
                                  "left join rasta.tbl_CBS cbs on cbs.cbsid=ad.cbsid " +
                                  "left join rasta.tbl_IPEXOPEX i on i.IPEXOPEXID = ad.IPEXOPEXID " +
                                  "left join rasta.tbl_currencyexchange ce on ce.currencyid='" + cmbExpenseCurrency.SelectedValue.ToString() + "' " +
                                  "left join rasta.tbl_currency c on c.currencyid=ce.currencyid " +
                                  "where a.costcodeid=3 and i.referencetype='OPEX'";

                sda1 = new MySqlDataAdapter(CmdBank, con);
                DataTable dtExpenseType = new DataTable();
                sda1.Fill(dtExpenseType);
                if (dtExpenseType.Rows.Count > 0)
                {
                    DataRow dr = dtExpenseType.NewRow();
                    dr[0] = "Total";
                    dr[1] = "";
                    dr[2] = "";
                    dr[3] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Jan")));
                    dr[4] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Feb")));
                    dr[5] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Mar")));
                    dr[6] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Apr")));
                    dr[7] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("May")));
                    dr[8] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Jun")));
                    dr[9] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Jul")));
                    dr[10] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Aug")));
                    dr[11] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Sep")));
                    dr[12] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Oct")));
                    dr[13] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Nov")));
                    dr[14] = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Decm")));
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

     
    }
}
