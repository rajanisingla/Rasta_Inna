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
            Admin adminform = new Admin();
            adminform.MdiParent = this;
            adminform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //set form without maximize,minimize and close button
            adminform.Dock = DockStyle.Fill; //set form's dock property to fill
            adminform.Show();
            adminform.BringToFront();
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
            Login loginForm = new Login();
            loginForm.MdiParent = this;
            loginForm.Show();
            loginForm.BringToFront();
        }

        private void treasuryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Treasury TreasuryForm = new Treasury();
            TreasuryForm.MdiParent = this;
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

      

        
    }
}
