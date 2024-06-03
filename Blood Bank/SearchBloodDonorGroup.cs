using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Blood_Bank
{
    public partial class SearchBloodDonorGroup : Form
    {
        private Function fn = new Function();
        public SearchBloodDonorGroup()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchBloodDonorGroup_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tbladddonor";
            DataSet ds = fn.getData(query);
            dataGridView9.DataSource = ds.Tables[0];
        }

        private void comboblood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboblood.Text != "")
            {
                string query = "SELECT * FROM tbladddonor WHERE bloodgroup LIKE '" + comboblood.Text + "'";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    dataGridView9.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("No records found for the selected blood group.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string query = "SELECT * FROM tbladddonor";
                DataSet ds = fn.getData(query);
                dataGridView9.DataSource = ds.Tables[0];
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    ExportDataGridViewToPdf(dataGridView9, filePath);
                    MessageBox.Show("PDF generated successfully!");
                }
            }
        }

        private void ExportDataGridViewToPdf(DataGridView dataGridView, string filePath)
        {
            Document document = new Document(PageSize.A4);
            try
            {
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                PdfPTable table = new PdfPTable(dataGridView.Columns.Count);

                // Add column headers to the table
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    table.AddCell(cell);
                }

                // Add data rows to the table
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)  // Check if the cell value is null
                        {
                            table.AddCell(cell.Value.ToString());
                        }
                        else
                        {
                            table.AddCell(string.Empty);
                        }
                    }
                }

                document.Add(table);
                document.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating PDF: " + ex.Message);
            }
            finally
            {
                document.Close();
            }
        }
    }
}

