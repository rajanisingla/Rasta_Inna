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
            adminform.Show();
            adminform.BringToFront();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AccountReceivable accountReceivableForm = new AccountReceivable();
            accountReceivableForm.MdiParent = this;
            accountReceivableForm.Show();
            accountReceivableForm.BringToFront();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AccountPayable accountPayableForm = new AccountPayable();
            accountPayableForm.MdiParent = this;
            accountPayableForm.Show();
            accountPayableForm.BringToFront();
        }

      

        
    }
}
