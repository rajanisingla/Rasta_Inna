using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rasta
{
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AccountReceivable accountReceivableForm = new AccountReceivable();
            accountReceivableForm.MdiParent = this;
            accountReceivableForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //set form without maximize,minimize and close button
            accountReceivableForm.Dock = DockStyle.Fill; //set form's dock property to fill
            accountReceivableForm.Show();
            accountReceivableForm.BringToFront();
            

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AccountPayable accountPayableForm = new AccountPayable();
            accountPayableForm.MdiParent = this;
            accountPayableForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //set form without maximize,minimize and close button
            accountPayableForm.Dock = DockStyle.Fill;
            accountPayableForm.Show();
            accountPayableForm.BringToFront();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
           
        }

        private void treasuryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Treasury TreasuryForm = new Treasury();
            TreasuryForm.MdiParent = this;
            TreasuryForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //set form without maximize,minimize and close button
            TreasuryForm.Dock = DockStyle.Fill;
            TreasuryForm.Show();
            TreasuryForm.BringToFront();
        }

        private void bankReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BankReport bankReportForm = new BankReport();
            bankReportForm.MdiParent = this;
            bankReportForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //set form without maximize,minimize and close button
            bankReportForm.Dock = DockStyle.Fill;
            bankReportForm.Show();
            bankReportForm.BringToFront();
        }

        private void wEETREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WEETRE weetreForm = new WEETRE();
            weetreForm.MdiParent = this;
            weetreForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //set form without maximize,minimize and close button
            weetreForm.Dock = DockStyle.Fill;
            weetreForm.Show();
            weetreForm.BringToFront();
        }

        private void treasuryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreasuryReport treasuryForm = new TreasuryReport();
            treasuryForm.MdiParent = this;
            treasuryForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //set form without maximize,minimize and close button
            treasuryForm.Dock = DockStyle.Fill;
            treasuryForm.Show();
            treasuryForm.BringToFront();
        }

        private void iTReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ITReport itReportForm = new ITReport();
            itReportForm.MdiParent = this;
            itReportForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //set form without maximize,minimize and close button
            itReportForm.Dock = DockStyle.Fill;
            itReportForm.Show();
            itReportForm.BringToFront();
        }

        private void managementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin adminform = new Admin();
            adminform.MdiParent = this;
            adminform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //set form without maximize,minimize and close button
            adminform.Dock = DockStyle.Fill; //set form's dock property to fill
            adminform.Show();
            adminform.BringToFront();
        }

        private void forecastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forecast Forecastform = new Forecast();
            Forecastform.MdiParent = this;
            Forecastform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //set form without maximize,minimize and close button
            Forecastform.Dock = DockStyle.Fill; //set form's dock property to fill
            Forecastform.Show();
            Forecastform.BringToFront();
        }

        private void forecastReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ForecastReport Forecastform = new ForecastReport();
            Forecastform.MdiParent = this;
            Forecastform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //set form without maximize,minimize and close button
            Forecastform.Dock = DockStyle.Fill; //set form's dock property to fill
            Forecastform.Show();
            Forecastform.BringToFront();
        }

        private void Master_Load(object sender, EventArgs e)
        {

        }

        private void generalBudgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneralBudget Budgetform = new GeneralBudget();
            Budgetform.MdiParent = this;
            Budgetform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //set form without maximize,minimize and close button
            Budgetform.Dock = DockStyle.Fill; //set form's dock property to fill
            Budgetform.Show();
            Budgetform.BringToFront();
        }
        

      

        
    }
}
