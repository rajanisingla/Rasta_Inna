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
    public partial class WEETRE : Form
    {
        string con = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        MySqlDataAdapter sda1;

        public WEETRE()
        {
            InitializeComponent();
        }

        private void cmbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCurrency.SelectedIndex == -1)
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = false;
                textBox1.Visible = false;
                label5.Visible = false;

            }
            else
            {
                double amountRevenue = 0;
                string CmdBank = "select concat(c.currencyname) as Currency,e.ExpenseTypeName as RevenueType,"+
                    //"select concat(b.bankname,' (',c.currencyname,')') as Bank,e.ExpenseTypeName," +
                                "sum(a.amount/ce.exchangerateinusd) as Total from rasta.vw_AccountReceivable a left join rasta.tbl_expensetype e on e.ExpenseTypeID=a.ExpenseTypeID "+
                                //"left join rasta.tbl_bank b on b.bankid=a.BankID  "+
                                "left join rasta.tbl_currencyexchange ce on ce.currencyid='" + cmbCurrency.SelectedValue.ToString() + "' " +  
                                "left join rasta.tbl_currency c on c.currencyid=ce.currencyid "+
                                "group by  e.ExpenseTypeName";
                sda1 = new MySqlDataAdapter(CmdBank, con);
                DataTable dtExpenseType = new DataTable();
                sda1.Fill(dtExpenseType);
                if (dtExpenseType.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dtExpenseType;
                    dataGridView1.Visible = true;
                    amountRevenue = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Total")));

                }
                string cmdTD = "select concat(c.currencyname) as Currency,p.projctname," +
                                "sum(a.amount/ce.exchangerateinusd) as Total from rasta.vw_AccountReceivable a left join rasta.tbl_project p on p.projectid=a.projectid "+
                               // "left join rasta.tbl_bank b on b.bankid=a.BankID  "+
                                "left join rasta.tbl_currencyexchange ce on ce.currencyid='" + cmbCurrency.SelectedValue.ToString() + "' " + 
                                "left join rasta.tbl_currency c on c.currencyid=ce.currencyid "+
                                "group by  p.projectid";
                sda1 = new MySqlDataAdapter(cmdTD, con);
                DataTable dtProject = new DataTable();
                sda1.Fill(dtProject);
                if (dtProject.Rows.Count > 0)
                {
                    dataGridView2.DataSource = dtProject;
                    dataGridView2.Visible = true;
                    amountRevenue = amountRevenue+ Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Total")));

                }
                textBox1.Text = amountRevenue.ToString();
                label5.Visible = true;
                textBox1.Visible = true;
            }
        }

        private void WEETRE_Load(object sender, EventArgs e)
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
            dataGridView2.Visible = false;
            label5.Visible = false;
            label4.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                string CmdCurrencyType = "SELECT distinct CurrencyName,CurrencyID FROM tbl_Currency";
                sda1 = new MySqlDataAdapter(CmdCurrencyType, con);
                DataTable dtCurrency = new DataTable();
                sda1.Fill(dtCurrency);

                this.cmbExpenseCurrency.DataSource = dtCurrency;
                this.cmbExpenseCurrency.DisplayMember = "CurrencyName";
                this.cmbExpenseCurrency.ValueMember = "CurrencyID";
                cmbExpenseCurrency.SelectedIndex = -1;
                dataGridView3.Visible = false;
                dataGridView4.Visible = false;
                dataGridView5.Visible = false;
                label4.Visible = false;
                textBox2.Visible = false;
            }
        }
        private void cmbExpenseCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbExpenseCurrency.SelectedIndex == -1)
            {
                dataGridView3.Visible = false;
                dataGridView4.Visible = false;
                dataGridView5.Visible = false;
                label4.Visible = false;
                textBox2.Visible = false;
            }
            else
            {
                double amount = 0;
                string CmdBank = "select concat(c.currencyname) as Currency,d.DepartmentName," +
                                "sum(a.amount/ce.exchangerateinusd) as Total from rasta.vw_AccountPayable a "+
                                "left join rasta.tbl_APDepartmentExpense ad on ad.apid=a.apid "+
                                "left join rasta.tbl_Department d on d.DepartmentID=ad.DepartmentID "+
                                "left join rasta.tbl_currencyexchange ce on ce.currencyid='" + cmbExpenseCurrency.SelectedValue.ToString() + "' " + 
                                "left join rasta.tbl_currency c on c.currencyid=ce.currencyid "+
                                "where a.costcodeid=2 and  ad.icpid is  null "+
                                "group by  d.DepartmentName";
                sda1 = new MySqlDataAdapter(CmdBank, con);
                DataTable dtExpenseType = new DataTable();
                sda1.Fill(dtExpenseType);
                if (dtExpenseType.Rows.Count > 0)
                {
                    dataGridView3.DataSource = dtExpenseType;
                    dataGridView3.Visible = true;
                    amount = Convert.ToDouble(dtExpenseType.AsEnumerable().Sum(x => x.Field<Double?>("Total")));
                }
   
                string cmdTD = "select concat(c.currencyname) as Currency,i.icpname," +
                                "sum(a.amount/ce.exchangerateinusd) as Total from rasta.vw_AccountPayable a "+
                                "left join rasta.tbl_APDepartmentExpense ad on ad.apid=a.apid "+
                                "left join rasta.tbl_ICP i on i.icpid=ad.icpid "+
                                "left join rasta.tbl_currencyexchange ce on ce.currencyid='" + cmbExpenseCurrency.SelectedValue.ToString() + "' " +
                                "left join rasta.tbl_currency c on c.currencyid=ce.currencyid "+
                                "where a.costcodeid=2 and  ad.icpid is not null "+
                                "group by  i.icpname";
                sda1 = new MySqlDataAdapter(cmdTD, con);
                DataTable dtICP = new DataTable();
                sda1.Fill(dtICP);
                if (dtICP.Rows.Count > 0)
                {
                    dataGridView4.DataSource = dtICP;
                    dataGridView4.Visible = true;
                    amount = amount + Convert.ToDouble(dtICP.AsEnumerable().Sum(x => x.Field<Double?>("Total")));
                }
                string cmdProject = "select concat(c.currencyname) as Currency,p.projctname," +
                                "sum(a.amount/ce.exchangerateinusd) as Total from rasta.vw_AccountPayable a " +
                                "left join rasta.tbl_APProjectExpense ap on ap.apid=a.apid " +
                                "left join rasta.tbl_project p on p.ProjectId=ap.ProjectId " +
                                "left join rasta.tbl_currencyexchange ce on ce.currencyid='" + cmbExpenseCurrency.SelectedValue.ToString() + "' " +
                                "left join rasta.tbl_currency c on c.currencyid=ce.currencyid " +
                                "where a.costcodeid=1  " +
                                "group by  p.projctname";
                sda1 = new MySqlDataAdapter(cmdProject, con);
                DataTable dtProject = new DataTable();
                sda1.Fill(dtProject);
                if (dtProject.Rows.Count > 0)
                {
                    dataGridView5.DataSource = dtProject;
                    dataGridView5.Visible = true;
                    amount = amount + Convert.ToDouble(dtProject.AsEnumerable().Sum(x => x.Field<Double?>("Total")));
                }
                textBox2.Text = amount.ToString();
                label4.Visible = true;
                textBox2.Visible = true;
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
