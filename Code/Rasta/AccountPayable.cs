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
    public partial class AccountPayable : Form
    {
        public AccountPayable()
        {
            InitializeComponent();
        }

        private void AccountPayable_Load(object sender, EventArgs e)
        {

        }

        private void calDate_ValueChanged(object sender, EventArgs e)
        {
            this.calPaymentDueDate.Value = calDate.Value.AddDays(30);
        }

        private void cmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dgvApproverManagement.Visible = true;
        }

        
    }
}
