using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Rasta
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            MySqlConnection con = new MySqlConnection(ConString);
            string CmdString = "SELECT * FROM tbl_Users";
            MySqlDataAdapter sda = new MySqlDataAdapter(CmdString, con);
            DataTable dtUserDetails = new DataTable();
            sda.Fill(dtUserDetails);

            string userName = txtUserName.Text;
            string password = txtPassWord.Text;
            var results = dtUserDetails.AsEnumerable().FirstOrDefault(entity => string.Equals(entity.Field<string>("UserName"), userName));

            if (results != null)
            {
                if (string.Equals(password, results.Field<string>("PassWord")))
                {
                    Master master = new Master();
                    master.Show();
                    master.BringToFront();
                    this.Hide();
                }
                else
                {
                    this.lblError.Visible = true;
                }
            }
            else
            {
                this.lblError.Visible = true;
            }
        }
      
    }
}
