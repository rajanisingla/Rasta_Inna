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
                    Master master= new Master();
                    string CmdString1 = "select privilegename from rasta.tbl_privilege P left join rasta.tbl_userprivilege UP "+
                                        "on up.privilegeid=P.privilegeid where UP.userid="+results[0]+"";
                    MySqlDataAdapter cmd1 = new MySqlDataAdapter(CmdString1, con);
                    DataTable dtUserPrivilege = new DataTable();
                    cmd1.Fill(dtUserPrivilege);
                    var privilegeAR = dtUserPrivilege.AsEnumerable().FirstOrDefault(entity => string.Equals(entity.Field<string>("privilegename"), "AR"));
                    var privilegeAP = dtUserPrivilege.AsEnumerable().FirstOrDefault(entity => string.Equals(entity.Field<string>("privilegename"), "AP"));
                    if (privilegeAP != null && privilegeAR != null)
                    {
                        master.enableAdminMenu = false;
                        master.enableBudgetMenu = false;
                        master.enableTreasuryMenu = false;
                    }
                    else if(privilegeAP != null && privilegeAR == null)
                    {
                        master.enableAdminMenu = false;
                        master.enableBudgetMenu = false;
                        master.enableTreasuryMenu = false;
                        master.enableARMenu = false;
                    }
                    else if (privilegeAP == null && privilegeAR != null)
                    {
                        master.enableAdminMenu = false;
                        master.enableBudgetMenu = false;
                        master.enableTreasuryMenu = false;
                        master.enableAPMenu = false;
                    }
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
