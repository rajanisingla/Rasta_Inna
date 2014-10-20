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

namespace Rasta
{
    public partial class Treasury : Form
    {
        string con = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        MySqlDataAdapter sda1;

        public Treasury()
        {
            InitializeComponent();
        }

        private void Treasury_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;

            string CmdBank = "SELECT distinct BankID,BankName FROM tbl_Bank";
            sda1 = new MySqlDataAdapter(CmdBank, con);
            DataTable dtBank = new DataTable();
            sda1.Fill(dtBank);

            this.cmbBank.DataSource = dtBank;
            this.cmbBank.DisplayMember = "BankName";
            this.cmbBank.ValueMember = "BankID";

            string CmdSite = "SELECT distinct SiteName,SiteID FROM tbl_Site";
            sda1 = new MySqlDataAdapter(CmdSite, con);
            DataTable dtSite = new DataTable();
            sda1.Fill(dtSite);

            this.cmbSite.DataSource = dtSite;
            this.cmbSite.DisplayMember = "SiteName";
            this.cmbSite.ValueMember = "SiteID";

            string cmdUser = "Select companyRole,UserID from rasta.tbl_users";
            sda1 = new MySqlDataAdapter(cmdUser, con);
            DataTable dtUser1 = new DataTable();
            sda1.Fill(dtUser1);

            this.cmbSign1.DataSource = dtUser1;
            this.cmbSign1.DisplayMember = "companyRole";
            this.cmbSign1.ValueMember = "UserID";

            DataTable dtUser2 = new DataTable();
            sda1.Fill(dtUser2);

            this.cmbSign2.DataSource = dtUser2;
            this.cmbSign2.DisplayMember = "companyRole";
            this.cmbSign2.ValueMember = "UserID";

            

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                string APIds = string.Empty;
                foreach (DataGridViewRow row in dgvInvoices.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        APIds = string.Concat(APIds + "," + row.Cells["APID"].Value.ToString());
                        string query = "uPDATE tbl_bank SET cash=cash-" + row.Cells["Amount"].Value + "  WHERE bankid =" + row.Cells["Bank"].Value.ToString() + "";
                        string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                        MySqlConnection con = new MySqlConnection(ConString);
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.CommandType = CommandType.Text;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        dgvInvoices.Rows.Remove(row);
                    }
                }
                APIds = APIds.Remove(0, 1);
                string query1 = "uPDATE tbl_AccountPayable SET ispaid=1 WHERE APID IN (" + APIds + ")";
                string ConString1 = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                MySqlConnection con1 = new MySqlConnection(ConString1);
                MySqlCommand cmd1 = new MySqlCommand(query1, con1);
                cmd1.CommandType = CommandType.Text;
                con1.Open();
                cmd1.ExecuteNonQuery();
                con1.Close();
                MessageBox.Show("Payment done successfully!!", "Sucess");
            }
            catch
            {
                MessageBox.Show("Invoice saved successfully!!", "Sucess");
            }


        }

        private void Tabcontrol_SelectedIndexChange(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                string CmdAFP = "select s.suppliername,s.supplierid,ap.amount,c.currencyname,s.bankid,ap.apid from rasta.tbl_AccountPayable ap " +
               "left join tbl_currency c on c.currencyid=ap.currencyid " +
               "left join tbl_supplier s on s.supplierid=ap.supplierid " +
               "where ap.isApproved=1 and ap.isPaid=0";
                sda1 = new MySqlDataAdapter(CmdAFP, con);
                DataTable dtAFP = new DataTable();
                sda1.Fill(dtAFP);
                dgvInvoices.AutoGenerateColumns = false;
                dgvInvoices.DataSource = dtAFP;
                SupplierName.DataPropertyName = "suppliername";
                Amount.DataPropertyName = "amount";
                Currency.DataPropertyName = "currencyname";
                SupplierID.DataPropertyName = "supplierid";
                Bank.DataPropertyName = "bankid";
                APID.DataPropertyName = "APID";
                if (dtAFP.Rows != null && dtAFP.Rows.Count > 0)
                {
                    for (int i = 0; i < dtAFP.Rows.Count; i++)
                    {
                        string cmdRow = "select b.bankname as bankname,b.bankid as bankid from rasta.tbl_supplier s " +
        "left join rasta.tbl_SupplierTypeDiscipline sd on sd.suppliertypeid=s.suppliertypeid " +
        "left join rasta.tbl_discipline d on d.disciplineid=sd.disciplineid " +
        "left join  rasta.tbl_bank b on b.disciplineid=d.disciplineid " +
        "where s.supplierid=" + dgvInvoices.Rows[i].Cells["supplierid"].Value.ToString() + "";
                        sda1 = new MySqlDataAdapter(cmdRow, con);
                        DataTable dtRow = new DataTable();
                        sda1.Fill(dtRow);

                        DataGridViewComboBoxCell cbCell = (DataGridViewComboBoxCell)dgvInvoices.Rows[i].Cells["Bank"];
                        cbCell.DataSource = dtRow;
                        cbCell.DisplayMember = "bankname";
                        cbCell.ValueMember = "bankid";

                    }

                }
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            try
            {
                //Creating iTextSharp Table from the DataTable data
                PdfPTable pdfTable = new PdfPTable(4);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.TotalWidth = 300f;
                pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTable.DefaultCell.BorderWidth = 1;

                PdfPCell cell1 = new PdfPCell(new Phrase("Payment to Bank"));
                cell1.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                cell1.Colspan = 4;
                pdfTable.AddCell(cell1);


                //Adding Header row
                PdfPCell cell2 = new PdfPCell(new Phrase("Supplier Name"));
                cell2.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell2);

                PdfPCell cell3 = new PdfPCell(new Phrase("Amount"));
                cell3.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell3);
                PdfPCell cell4 = new PdfPCell(new Phrase("Currency"));
                cell4.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell4);
                PdfPCell cell5 = new PdfPCell(new Phrase("Bank"));
                cell5.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell5);
                //Adding DataRow
                foreach (DataGridViewRow row in dgvInvoices.Rows)
                {
                    if (!Convert.ToBoolean(row.Cells[0].Value))
                        continue;
                    else
                    {
                        pdfTable.AddCell(Convert.ToString(row.Cells[1].Value));
                        pdfTable.AddCell(Convert.ToString(row.Cells[2].Value));
                        pdfTable.AddCell(Convert.ToString(row.Cells[3].Value));
                        // DataGridViewComboBoxCell cbCell = (DataGridViewComboBoxCell)row.Cells[4];

                        pdfTable.AddCell(Convert.ToString(row.Cells[4].FormattedValue));
                    }
                }


                ////Exporting to PDF
                string folderPath = "C:\\PDFs\\";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                using (FileStream stream = new FileStream(folderPath + "DataGridViewExport-" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);

                    pdfDoc.Close();
                    stream.Close();
                }
                MessageBox.Show("PDF saved successfully!!", "Sucess");
            }
            catch
            {
                MessageBox.Show("Some error has occured!!", "Error");

            }

        }

        private void btnGenerateRefLetter_Click(object sender, EventArgs e)
        {
            string folderPath = "C:\\PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "DataGridViewExport5-" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(new Phrase("AO"));
                pdfDoc.Add(new Phrase("\n"));
                pdfDoc.Add(new Phrase(cmbBank.Text));
                pdfDoc.Add(new Phrase("\n"));
                pdfDoc.Add(new Phrase(string.Concat(cmbSite.Text,",",DateTime.Now.ToShortDateString())));
                pdfDoc.Add(new Phrase("\n"));
                pdfDoc.Add(new Phrase(string.Concat("Ref : ",txtRef.Text)));
                pdfDoc.Add(new Phrase("\n"));
                pdfDoc.Add(new Phrase("Exmos. Senhores,"));
                pdfDoc.Add(new Phrase("\n"));
                pdfDoc.Add(new Phrase("\n"));
                pdfDoc.Add(new Phrase(string.Concat("Queira por favor debitar a nossa conta nº 123/12345/12/001 e entregar ao Sr. Tesoreiro, portador do BI nº",txtID.Text," o valor de USD",txtAmount.Text," (Dólares Americanos).")));
                pdfDoc.Add(new Phrase("\n"));
                pdfDoc.Add(new Phrase("\n"));
                pdfDoc.Add(new Phrase("Sem outro assunto de momento somos,"));
                pdfDoc.Add(new Phrase("\n"));
                pdfDoc.Add(new Phrase("Atenciosamente,"));
                pdfDoc.Add(new Phrase("\n"));
                pdfDoc.Add(new Phrase("\n"));
                pdfDoc.Add(new Phrase("\n"));
                pdfDoc.Add(new Phrase("\n"));

                pdfDoc.Close();
                stream.Close();
            }
        }

       
       
    }
}
