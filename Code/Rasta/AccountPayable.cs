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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Web;
namespace Rasta
{
    public partial class AccountPayable : Form
    {
        string con = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        MySqlDataAdapter sda1;
        public AccountPayable()
        {
            InitializeComponent();
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedIndex == 0)
            {
                btnUpdate.Visible = false;
            }
            if (this.tabControl1.SelectedIndex == 1)
            {
                string cmdView = "select ap.apid, s.suppliername,ap.paymentduedate,ap.amount,c.currencyname,st.sitename,s.SupplierCode,ap.CurrentDate,ap.CostCodeID,ap.PaymentPurpose,ap.PONumber,ap.POAmount,ap.InvoiceDate,ap.RecievedDate,ap.currencyID,ap.siteid  " +
                              " from rasta.tbl_AccountPayable ap " +
                              "left join rasta.tbl_supplier S on s.SupplierID=ap.SupplierID  " +
                              "left join rasta.tbl_currency c on c.currencyid=ap.currencyid " +
                              "left join rasta.tbl_site st on st.siteid=ap.siteid " +
                              "where ap.paymentduedate>=curdate() and ap.paymentduedate <date_add(NOW(), INTERVAL 7 day) and ap.isforecast=0";
                sda1 = new MySqlDataAdapter(cmdView, con);
                DataTable dtView = new DataTable();
                sda1.Fill(dtView);
                dgvAccountPayable.AutoGenerateColumns = false;
                dgvAccountPayable.DataSource = dtView;

                SupplierName.DataPropertyName = "suppliername";
                DueDate.DataPropertyName = "paymentduedate";
                Amount.DataPropertyName = "amount";
                Currency.DataPropertyName = "currencyname";
                Site.DataPropertyName = "sitename";
                APID.DataPropertyName = "apid";
                Suppliercode.DataPropertyName = "SupplierCode";
                CurrentDate.DataPropertyName = "CurrentDate";
                CostCode.DataPropertyName = "CostCodeID";
                PaymentPurpose.DataPropertyName = "PaymentPurpose";
                PONumber.DataPropertyName = "PONumber";
                POAmount.DataPropertyName = "POAmount";
                InvoiceDate.DataPropertyName = "InvoiceDate";
                ReceivedDate.DataPropertyName = "RecievedDate";
                CurrencyID.DataPropertyName = "currencyid";
                SiteID.DataPropertyName = "siteid";


                dgvAccountPayable.Columns["apid"].Visible = false;
            }
        }

        private void AccountPayable_Load(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;

            string CmdSupplier = "SELECT distinct SupplierName,SupplierCode FROM tbl_Supplier";
            sda1 = new MySqlDataAdapter(CmdSupplier, con);
            DataTable dtSuuplier = new DataTable();
            sda1.Fill(dtSuuplier);

            this.cmbSupplierName.DataSource = dtSuuplier;
            this.cmbSupplierName.DisplayMember = "SupplierName";
            this.cmbSupplierName.ValueMember = "SupplierCode";
            this.cmbSupplierName.SelectedIndex = -1;
            this.cmbSupplierCode.DataSource = dtSuuplier;
            this.cmbSupplierCode.DisplayMember = "SupplierCode";
            this.cmbSupplierCode.ValueMember = "SupplierName";
            this.cmbSupplierCode.SelectedIndex = -1;

            string CmdCurrencyType = "SELECT distinct CurrencyName,CurrencyID FROM tbl_Currency";
            sda1 = new MySqlDataAdapter(CmdCurrencyType, con);
            DataTable dtCurrencyType = new DataTable();
            sda1.Fill(dtCurrencyType);

            this.cmbCurrency.DataSource = dtCurrencyType;
            this.cmbCurrency.DisplayMember = "CurrencyName";
            this.cmbCurrency.ValueMember = "CurrencyID";

            string CmdSite = "SELECT distinct SiteName,SiteID FROM tbl_Site";
            sda1 = new MySqlDataAdapter(CmdSite, con);
            DataTable dtSite = new DataTable();
            sda1.Fill(dtSite);

            this.cmbSite.DataSource = dtSite;
            this.cmbSite.DisplayMember = "SiteName";
            this.cmbSite.ValueMember = "SiteID";

            string CmdType = "SELECT distinct CostCodeID,CostCodeName FROM tbl_CostCode";
            sda1 = new MySqlDataAdapter(CmdType, con);
            DataTable dtType = new DataTable();
            sda1.Fill(dtType);
            DataRow dr = dtType.NewRow();
            dr["CostCodeName"] = "--Select--";
            dr["CostCodeID"] = "0";
            dtType.Rows.Add(dr);
            this.cmbType.DataSource = dtType;
            this.cmbType.DisplayMember = "CostCodeName";
            this.cmbType.ValueMember = "CostCodeID";
            this.cmbType.SelectedValue = "0";

            


        }

        private void calDate_ValueChanged(object sender, EventArgs e)
        {
            this.calPaymentDueDate.Value = calDate.Value.AddDays(30);
        }



        private void dgvApproverManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private void btnExportToPDF_Click(object sender, EventArgs e)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dgvApproverManagement.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.TotalWidth = 300f;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            PdfPCell cell1 = new PdfPCell(new Phrase("APPROVALS"));
            cell1.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            cell1.Colspan = dgvApproverManagement.Columns.Count;
            pdfTable.AddCell(cell1);


            //Adding Header row
            foreach (DataGridViewColumn column in dgvApproverManagement.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dgvApproverManagement.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(Convert.ToString(cell.EditedFormattedValue));
                }
            }

            PdfPTable pdfTable1 = new PdfPTable(2);
            pdfTable1.DefaultCell.Padding = 3;
            pdfTable1.TotalWidth =300f;
            pdfTable1.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable1.DefaultCell.BorderWidth = 1;
            
            //Adding Header row
            
                PdfPCell cellheader = new PdfPCell(new Phrase("AFP INFORMATION"));
                cellheader.BackgroundColor = new iTextSharp.text.BaseColor(Color.Yellow);
                cellheader.Colspan = 2;
                pdfTable1.AddCell(cellheader);
            

            //Adding DataRow
           
                    pdfTable1.AddCell("SupplierName");
                    pdfTable1.AddCell(cmbSupplierName.Text);
                    pdfTable1.AddCell("Invoice Number:");
                    pdfTable1.AddCell("");
                    pdfTable1.AddCell("Invoice Date (+ Receipt Date):");
                    pdfTable1.AddCell(calInvoiceDate.Value.ToString());
                    pdfTable1.AddCell("Due Date of Payment:");
                    pdfTable1.AddCell(calPaymentDueDate.Value.ToString());
                    pdfTable1.AddCell("Amount invoiced incl. WHT:");
                    pdfTable1.AddCell(txtAmount.Text);
                    pdfTable1.AddCell("Total PO/SC Value: ");
                    pdfTable1.AddCell(txtPOAmount.Text);
                    pdfTable1.AddCell("Total invoiced (without this AFP):");
                    pdfTable1.AddCell("");
                    pdfTable1.AddCell("Site (DSB / Luanda / Lobito) :");
                    pdfTable1.AddCell(cmbSite.Text);
                    pdfTable1.AddCell("PO / SC Reference:");
                    pdfTable1.AddCell(txtPONumber.Text);
                    pdfTable1.AddCell("Payment purpose");
                    pdfTable1.AddCell(txtPaymentPurpose.Text);
                    pdfTable1.AddCell("Cost Code:");
                    pdfTable1.AddCell(cmbType.Text);
                    pdfTable1.AddCell("Project / Section:");
                    pdfTable1.AddCell(combobox1.Text);


            ////Exporting to PDF
            string folderPath = Path.GetDirectoryName(Application.ExecutablePath)+"\\PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "AFP-" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable1);
                pdfDoc.Add(new Phrase("\n"));
                pdfDoc.Add(pdfTable);

                pdfDoc.Close();
                stream.Close();
            }

            //if (dgvApproverManagement.Rows.Count > 0)
            //{
            //    Microsoft.Office.Interop.Excel.ApplicationClass XcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
            //    XcelApp.Application.Workbooks.Add(Type.Missing);

            //    for (int i = 1; i < dgvApproverManagement.Columns.Count + 1; i++)
            //    {
            //        XcelApp.Cells[1, i] = dgvApproverManagement.Columns[i - 1].HeaderText;
            //    }

            //    for (int i = 0; i < dgvApproverManagement.Rows.Count; i++)
            //    {
            //        for (int j = 0; j < dgvApproverManagement.Columns.Count; j++)
            //        {
            //            XcelApp.Cells[i + 2, j + 1] = dgvApproverManagement.Rows[i].Cells[j].Value.ToString();
            //        }
            //    }
            //    XcelApp.Columns.AutoFit();
            //    XcelApp.Visible = true;
            //}
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label2.Visible = false;
            this.comboBox2.Visible = false;
            this.comboBox2.SelectedIndex = -1;
            this.label3.Visible = false;
            this.comboBox3.Visible = false;
            this.comboBox3.SelectedIndex = -1;
            this.label4.Visible = false;
            this.comboBox4.Visible = false;
            this.comboBox4.SelectedIndex = -1;
            if (cmbType.SelectedValue.ToString() == "1")
            {
                this.label1.Text = "Project";
                this.label1.Visible = true;
                this.combobox1.Visible = true;
                string cmdProject = "SELECT distinct ProjectID,ProjctName FROM tbl_Project";
                sda1 = new MySqlDataAdapter(cmdProject, con);
                DataTable dtProject = new DataTable();
                sda1.Fill(dtProject);


                this.combobox1.DataSource = dtProject;
                this.combobox1.ValueMember = "ProjectID";
                this.combobox1.DisplayMember = "ProjctName";
            }
            else if (cmbType.SelectedValue.ToString() == "2")
            {
                this.label1.Text = "Department";
                this.label1.Visible = true;
                this.combobox1.Visible = true;
                string cmdProject = "SELECT distinct DepartmentID,DepartmentName FROM tbl_Department";
                sda1 = new MySqlDataAdapter(cmdProject, con);
                DataTable dtProject = new DataTable();
                sda1.Fill(dtProject);

                this.combobox1.DataSource = dtProject;
                this.combobox1.ValueMember = "DepartmentID";
                this.combobox1.DisplayMember = "DepartmentName";
            }
            else if (cmbType.SelectedValue.ToString() == "3")
            {
                          
                this.label1.Text = "Rebill";
                this.label1.Visible = true;
                this.combobox1.Visible = true;
                string cmd = "SELECT distinct RebillID,RebillName FROM tbl_Rebill";
                sda1 = new MySqlDataAdapter(cmd, con);
                DataTable dt = new DataTable();
                sda1.Fill(dt);

                this.combobox1.DataSource = dt;
                this.combobox1.ValueMember = "RebillID";
                this.combobox1.DisplayMember = "RebillName";
           
                this.label2.Text = "CBS ";
                this.label2.Visible = true;
                this.comboBox2.Visible = true;
                string cmd2 = "SELECT distinct CBSID,CBSName FROM tbl_CBS ";
                sda1 = new MySqlDataAdapter(cmd2, con);
                DataTable dt2 = new DataTable();
                sda1.Fill(dt2);

                this.comboBox2.DataSource = dt2;
                this.comboBox2.ValueMember = "CBSID";
                this.comboBox2.DisplayMember = "CBSName";
           
                this.label3.Text = "Reference ";
                this.label3.Visible = true;
                this.comboBox3.Visible = true;
                string cmd3 = "SELECT distinct ReferenceType FROM tbl_IPEXOPEX ";
                sda1 = new MySqlDataAdapter(cmd3, con);
                DataTable dt3 = new DataTable();
                sda1.Fill(dt3);

                this.comboBox3.DataSource = dt3;
                this.comboBox3.ValueMember = "ReferenceType";
                this.comboBox3.DisplayMember = "ReferenceType";
                this.comboBox3.SelectedIndex = -1;
            
            }
            else if (cmbType.SelectedValue.ToString() == "0")
            {
                this.label1.Visible = false;
                this.combobox1.Visible = false;
                this.combobox1.SelectedIndex = -1;
            }
        }

        private void cmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                
            if (combobox1.Text == "Other corporate expenses")
            {
                this.label2.Text = "Other corporate expenses";
                this.label2.Visible = true;
                this.comboBox2.Visible = true;
                string cmd = "SELECT distinct ICPID,ICPName FROM tbl_ICP";
                sda1 = new MySqlDataAdapter(cmd, con);
                DataTable dt = new DataTable();
                sda1.Fill(dt);

                this.comboBox2.DataSource = dt;
                this.comboBox2.ValueMember = "ICPID";
                this.comboBox2.DisplayMember = "ICPName";
            }

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSupplierName.SelectedIndex == -1)
            {
                dgvApproverManagement.DataSource = null;
                dgvApproverManagement.Visible = false;
            }
            else
            {
                string cmd = "select D.disciplineName as DisciplineName from rasta.tbl_supplier S " +
                "  left join rasta.tbl_suppliertypediscipline SD on S.SupplierTypeID=SD.SupplierTypeID " +
                " left join rasta.tbl_discipline D on D.DisciplineID=SD.DisciplineID " +
                " where S.SupplierName='" + cmbSupplierName.Text + "'";
                sda1 = new MySqlDataAdapter(cmd, con);
                DataTable dt = new DataTable();
                sda1.Fill(dt);
                dgvApproverManagement.AutoGenerateColumns = false;
                dgvApproverManagement.DataSource = dt;
                // this.UserName.DataPropertyName = "USERNAME";
                this.Title.DataPropertyName = "DisciplineName";
                if (dt.Rows != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string cmdRow = "select U.UserName as USERNAME,U.UserID from rasta.tbl_users U " +
                            " left join rasta.tbl_discipline D on D.disciplinename='" + dgvApproverManagement.Rows[i].Cells[0].Value.ToString() + "'" +
                            " left join rasta.tbl_userdiscipline UD on UD.DisciplineID=D.DisciplineID" +
                            " where U.UserID=UD.UserID";
                        sda1 = new MySqlDataAdapter(cmdRow, con);
                        DataTable dtRow = new DataTable();
                        sda1.Fill(dtRow);

                        DataGridViewComboBoxCell cbCell = (DataGridViewComboBoxCell)dgvApproverManagement.Rows[i].Cells[1];
                        cbCell.DataSource = dtRow;
                        cbCell.DisplayMember = "USERNAME";
                        cbCell.ValueMember = "UserID";
                        UserName.DataPropertyName = "UserID";
                    }

                }
                dgvApproverManagement.Visible = true;
            }

        }

        private void dgvApproverManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = ((DataGridView)sender);

            if (e.ColumnIndex < 0)
            {
                dgv.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                dgv.Focus();
                dgv.EndEdit();
            }

            else
            {
                dgv.EditMode = DataGridViewEditMode.EditOnEnter;
                dgv.BeginEdit(false);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string spname = "sp_InsertAFP";
            string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            MySqlConnection con = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(spname, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("supname", cmbSupplierName.Text);
            cmd.Parameters.AddWithValue("supCODE", cmbSupplierCode.Text);
            cmd.Parameters.AddWithValue("currentDate", Convert.ToDateTime(calDate.Text).ToString("yyyy-MM-dd H:mm:ss"));
            cmd.Parameters.AddWithValue("DUEDATE", Convert.ToDateTime(calPaymentDueDate.Text).ToString("yyyy-MM-dd H:mm:ss"));
            cmd.Parameters.AddWithValue("AMOUNT", txtAmount.Text);
            cmd.Parameters.AddWithValue("CURRENCYID", cmbCurrency.SelectedValue);
            cmd.Parameters.AddWithValue("SITEID", cmbSite.SelectedValue);
            cmd.Parameters.AddWithValue("PAYMENTPURPOSE", txtPaymentPurpose.Text);
            cmd.Parameters.AddWithValue("PONUMBER", txtPONumber.Text);
            cmd.Parameters.AddWithValue("POAMOUNT", txtPOAmount.Text);
            cmd.Parameters.AddWithValue("INVOICEDATE", Convert.ToDateTime(calInvoiceDate.Text).ToString("yyyy-MM-dd H:mm:ss"));
            cmd.Parameters.AddWithValue("RECEIVEDDATE", Convert.ToDateTime(calRecievedDate.Text).ToString("yyyy-MM-dd H:mm:ss"));
            cmd.Parameters.AddWithValue("COSTCODEID", cmbType.SelectedValue);
            cmd.Parameters.AddWithValue("CMB1", combobox1.SelectedValue);
            cmd.Parameters.AddWithValue("retAPID", MySqlDbType.Int16);
            cmd.Parameters["retAPID"].Direction = ParameterDirection.Output;
            
                cmd.Parameters.AddWithValue("CMB2", comboBox2.SelectedValue);
            cmd.Parameters.AddWithValue("CMB4", comboBox4.Text);
            cmd.Parameters.AddWithValue("isForecast",0);

            con.Open();
            cmd.ExecuteNonQuery();
            int iAPID = (int)cmd.Parameters["retAPID"].Value;
            con.Close();

            for (int i = 0; i < dgvApproverManagement.Rows.Count; i++)
            {
                string spname1 = "sp_APApprovers";
                MySqlCommand cmd1 = new MySqlCommand(spname1, con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("iAPID", iAPID);
                cmd1.Parameters.AddWithValue("discipline", dgvApproverManagement.Rows[i].Cells[0].Value.ToString());
                cmd1.Parameters.AddWithValue("user", dgvApproverManagement.Rows[i].Cells[1].Value.ToString());
                cmd1.Parameters.AddWithValue("comments", dgvApproverManagement.Rows[i].Cells[2].Value.ToString());
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();
            }


        }

        private void btnApprove_Click(object sender, EventArgs e)
        {

            string APIds = string.Empty;
            foreach (DataGridViewRow row in dgvAccountPayable.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    APIds = string.Concat(APIds + "," + row.Cells[1].Value.ToString());
                }
            }

            APIds = APIds.Remove(0, 1);
            if (!string.IsNullOrWhiteSpace(APIds))
            {
                string query = "uPDATE tbl_AccountPayable SET ISAPPROVED=1 WHERE APID IN (" + APIds + ")";
                string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                MySqlConnection con = new MySqlConnection(ConString);
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void dgvAccountPayable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = ((DataGridView)sender);

            if (e.ColumnIndex < 0)
            {
                dgv.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                dgv.Focus();
                dgv.EndEdit();
            }
            else if (e.ColumnIndex == 8)
            {
                string query = "DELETE FROM tbl_AccountPayable " +
                "WHERE APID =" + dgvAccountPayable.Rows[e.RowIndex].Cells[1].Value.ToString() + " ";
                MySqlConnection connection = new MySqlConnection(con);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.CommandType = CommandType.Text;
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();


                dgvAccountPayable.Rows.Remove(dgvAccountPayable.Rows[e.RowIndex]);
            }


            else if (e.ColumnIndex == 7)
            {
                this.tabControl1.SelectedIndex = 0;
                lblAPID.Text = dgvAccountPayable.Rows[e.RowIndex].Cells["APID"].Value.ToString();
                cmbSupplierName.SelectedValue = dgvAccountPayable.Rows[e.RowIndex].Cells["SupplierCode"].Value.ToString();
                cmbSupplierCode.SelectedValue = dgvAccountPayable.Rows[e.RowIndex].Cells["SupplierName"].Value.ToString();
                cmbCurrency.SelectedValue = dgvAccountPayable.Rows[e.RowIndex].Cells["CurrencyID"].Value.ToString();
                cmbSite.SelectedValue = dgvAccountPayable.Rows[e.RowIndex].Cells["SiteID"].Value.ToString();
                cmbType.SelectedValue = dgvAccountPayable.Rows[e.RowIndex].Cells["CostCode"].Value.ToString();
                calDate.Value = Convert.ToDateTime(dgvAccountPayable.Rows[e.RowIndex].Cells["CurrentDate"].Value);
                calInvoiceDate.Value = Convert.ToDateTime(dgvAccountPayable.Rows[e.RowIndex].Cells["InvoiceDate"].Value);
                calPaymentDueDate.Value = Convert.ToDateTime(dgvAccountPayable.Rows[e.RowIndex].Cells["DueDate"].Value);
                calRecievedDate.Value = Convert.ToDateTime(dgvAccountPayable.Rows[e.RowIndex].Cells["ReceivedDate"].Value);
                txtAmount.Text = dgvAccountPayable.Rows[e.RowIndex].Cells["Amount"].Value.ToString();
                txtPaymentPurpose.Text = dgvAccountPayable.Rows[e.RowIndex].Cells["PaymentPurpose"].Value.ToString();
                txtPONumber.Text = dgvAccountPayable.Rows[e.RowIndex].Cells["PONumber"].Value.ToString();
                txtPOAmount.Text = dgvAccountPayable.Rows[e.RowIndex].Cells["POAmount"].Value.ToString();

                string cmdView = "select d.DisciplineName,ap.userid,ap.comments from tbl_APApprovers AP left join rasta.tbl_discipline D on D.DisciplineID=AP.DisciplineID where ap.apid=" + dgvAccountPayable.Rows[e.RowIndex].Cells["APID"].Value + "";
                sda1 = new MySqlDataAdapter(cmdView, con);
                DataTable dtView = new DataTable();
                sda1.Fill(dtView);
                dgvApproverManagement.AutoGenerateColumns = false;
                dgvApproverManagement.DataSource = dtView;
                UserName.DataPropertyName = "UserId";
                Title.DataPropertyName = "DisciplineName";
                Comment.DataPropertyName = "Comments";

                foreach (DataGridViewRow row in dgvApproverManagement.Rows)
                {
                    string cmdRow = "select U.UserName as USERNAME,U.UserId from rasta.tbl_users U " +
                             " left join rasta.tbl_discipline D on D.disciplinename='" + row.Cells[0].Value.ToString() + "'" +
                             " left join rasta.tbl_userdiscipline UD on UD.DisciplineID=D.DisciplineID" +
                             " where U.UserID=UD.UserID";
                    sda1 = new MySqlDataAdapter(cmdRow, con);
                    DataTable dtRow = new DataTable();
                    sda1.Fill(dtRow);

                    DataGridViewComboBoxCell cbCell = (DataGridViewComboBoxCell)row.Cells[1];
                    cbCell.DataSource = dtRow;
                    cbCell.DisplayMember = "USERNAME";
                    cbCell.ValueMember = "UserId";
                    
                }

                if (cmbType.Text == "Project Expenses")
                {
                    string query = "select Projectid from tbl_APProjectExpense where apid=" + dgvAccountPayable.Rows[e.RowIndex].Cells["APID"].Value + "";
                    sda1 = new MySqlDataAdapter(query, con);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                   
                }
                else if (cmbType.Text == "Department Expenses")
                {
                    string query = "select DepartmentID,ICPID from tbl_APDepartmentExpense where apid=" + dgvAccountPayable.Rows[e.RowIndex].Cells["APID"].Value + "";
                    sda1 = new MySqlDataAdapter(query, con);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    combobox1.SelectedValue = dt1.Rows[0][0].ToString();
                    if (!string.IsNullOrWhiteSpace(dt1.Rows[0][1].ToString()))
                    {
                        this.label2.Text = "Other corporate expenses";
                        this.label2.Visible = true;
                        this.comboBox2.Visible = true;
                        comboBox2.SelectedValue = dt1.Rows[0][1].ToString();
                    }
                   
                }
                else if (cmbType.Text == "IT Expenses")
                {
                    string query = "select ap.RebillID,ap.CBSID,ap.IPEXOPEXID,i.IPEXOPEXName from tbl_APITExpense ap left join tbl_IPEXOPEX i on i.IPEXOPEXID=ap.IPEXOPEXID where apid=" + dgvAccountPayable.Rows[e.RowIndex].Cells["APID"].Value + "";
                    sda1 = new MySqlDataAdapter(query, con);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    if (!string.IsNullOrWhiteSpace(dt1.Rows[0][0].ToString()))
                    {
                        this.label2.Text = "Rebill";
                        this.label2.Visible = true;
                        this.comboBox2.Visible = true;
                        comboBox2.SelectedValue = dt1.Rows[0][0].ToString();
                        combobox1.SelectedValue = 1;
                    }
                    else if (!string.IsNullOrWhiteSpace(dt1.Rows[0][1].ToString()))
                    {
                         this.label2.Text = "CBS";
                        this.label2.Visible = true;
                        this.comboBox2.Visible = true;
                        comboBox2.SelectedValue = dt1.Rows[0][1].ToString();
                        combobox1.SelectedValue = 2;
                    }
                    else if (!string.IsNullOrWhiteSpace(dt1.Rows[0][2].ToString()))
                    {
                        combobox1.SelectedValue = 3;
                        this.label2.Text = "Reference";
                        this.label2.Visible = true;
                        this.comboBox2.Visible = true;
                        string value=dt1.Rows[0][3].ToString().Substring(2, 5);
                        value = value.Replace("-", "");
                        comboBox2.SelectedValue = value;
                        this.label3.Text = value;
                        this.label3.Visible = true;
                        this.comboBox3.Visible = true;
                        string cmd = "SELECT distinct IPEXOPEXID,IPEXOPEXNAME FROM tbl_IPEXOPEX where ReferenceType='"+value+"'";
                        sda1 = new MySqlDataAdapter(cmd, con);
                        DataTable dt = new DataTable();
                        sda1.Fill(dt);

                        this.comboBox3.DataSource = dt;
                        this.comboBox3.ValueMember = "IPEXOPEXID";
                        this.comboBox3.DisplayMember = "IPEXOPEXNAME";
                        comboBox3.SelectedValue = dt1.Rows[0][2].ToString();
                        
                    }
                }
                btnSave.Visible = false;
                btnUpdate.Visible = true;
            }
            else
            {
                dgv.EditMode = DataGridViewEditMode.EditOnEnter;
                dgv.BeginEdit(false);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string spname = "sp_UpdateAFP";
            string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            MySqlConnection con = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(spname, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("supname", cmbSupplierName.Text);
            cmd.Parameters.AddWithValue("supCODE", cmbSupplierCode.Text);
            cmd.Parameters.AddWithValue("cCurrentDate", Convert.ToDateTime(calDate.Text).ToString("yyyy-MM-dd H:mm:ss"));
            cmd.Parameters.AddWithValue("DUEDATE", Convert.ToDateTime(calPaymentDueDate.Text).ToString("yyyy-MM-dd H:mm:ss"));
            cmd.Parameters.AddWithValue("dAMOUNT", txtAmount.Text);
            cmd.Parameters.AddWithValue("iCURRENCYID", cmbCurrency.SelectedValue);
            cmd.Parameters.AddWithValue("iSITEID", cmbSite.SelectedValue);
            cmd.Parameters.AddWithValue("sPAYMENTPURPOSE", txtPaymentPurpose.Text);
            cmd.Parameters.AddWithValue("sPONUMBER", txtPONumber.Text);
            cmd.Parameters.AddWithValue("sPOAMOUNT", txtPOAmount.Text);
            cmd.Parameters.AddWithValue("cINVOICEDATE", Convert.ToDateTime(calInvoiceDate.Text).ToString("yyyy-MM-dd H:mm:ss"));
            cmd.Parameters.AddWithValue("cRECEIVEDDATE", Convert.ToDateTime(calRecievedDate.Text).ToString("yyyy-MM-dd H:mm:ss"));
            cmd.Parameters.AddWithValue("iCOSTCODEID", cmbType.SelectedValue);
            cmd.Parameters.AddWithValue("CMB1", combobox1.SelectedValue);
            cmd.Parameters.AddWithValue("iAPID",lblAPID.Text);
            
                cmd.Parameters.AddWithValue("CMB2", comboBox2.SelectedValue);
            cmd.Parameters.AddWithValue("CMB4", comboBox4.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            string query = "delete from rasta.tbl_APApprovers  where apid='" + lblAPID.Text + "'";
                MySqlCommand cmdQuery = new MySqlCommand(query, con);
                cmdQuery.CommandType = CommandType.Text;
                con.Open();
                cmdQuery.ExecuteNonQuery();
                con.Close();

            
            for (int i = 0; i < dgvApproverManagement.Rows.Count; i++)
            {
                string spname1 = "sp_APApprovers";
                MySqlCommand cmd1 = new MySqlCommand(spname1, con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("iAPID", lblAPID.Text);
                cmd1.Parameters.AddWithValue("discipline", dgvApproverManagement.Rows[i].Cells[0].Value.ToString());
                cmd1.Parameters.AddWithValue("user", dgvApproverManagement.Rows[i].Cells[1].Value.ToString());
                cmd1.Parameters.AddWithValue("comments", dgvApproverManagement.Rows[i].Cells[2].Value.ToString());
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox3.SelectedIndex == -1)
            {
                this.label4.Visible = false;
                this.comboBox4.Visible = false;
                this.comboBox4.SelectedIndex = -1;
            }
            else if (comboBox3.Text == "CAPEX")
            {
                this.label4.Text = "CAPEX ";
                this.label4.Visible = true;
                this.comboBox4.Visible = true;
                string cmd = "SELECT distinct IPEXOPEXID,IPEXOPEXNAME FROM tbl_IPEXOPEX where ReferenceType='CAPEX'";
                sda1 = new MySqlDataAdapter(cmd, con);
                DataTable dt = new DataTable();
                sda1.Fill(dt);

                this.comboBox4.DataSource = dt;
                this.comboBox4.ValueMember = "IPEXOPEXID";
                this.comboBox4.DisplayMember = "IPEXOPEXNAME";
            }
            else if (comboBox3.Text == "OPEX")
            {
                this.label4.Text = "OPEX ";
                this.label4.Visible = true;
                this.comboBox4.Visible = true;
                string cmd = "SELECT distinct IPEXOPEXID,IPEXOPEXNAME FROM tbl_IPEXOPEX where ReferenceType='OPEX'";
                sda1 = new MySqlDataAdapter(cmd, con);
                DataTable dt = new DataTable();
                sda1.Fill(dt);

                this.comboBox4.DataSource = dt;
                this.comboBox4.ValueMember = "IPEXOPEXID";
                this.comboBox4.DisplayMember = "IPEXOPEXNAME";
            }

        }

        private void lnkNewSupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin adminform = new Admin();
            adminform.Show();
            adminform.BringToFront();         
            adminform.selectIndexOfTabControl = 1;
           
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

    }
}
