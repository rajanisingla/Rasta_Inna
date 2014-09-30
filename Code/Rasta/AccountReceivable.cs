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
    public partial class AccountReceivable : Form
    {
        public AccountReceivable()
        {
            InitializeComponent();
        }

        private void AccountReceivable_Load(object sender, EventArgs e)
        {

        }

        private void lblType_Click(object sender, EventArgs e)
        {

        }

        private void calInvoiceDate_ValueChanged(object sender, EventArgs e)
        {
            this.calDueDate.Value = calInvoiceDate.Value.AddDays(30);
        }

       
    }
}
