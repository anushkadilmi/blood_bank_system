using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class StockDetails : Form
    {
        public StockDetails()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StockDetails_Load(object sender, EventArgs e)
        {
            string cs = "Data Source=LAPTOP-UL0VVV27;Initial Catalog=BloodBank;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string sql = "SELECT bloodgroup,quantity FROM stock";
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView6.DataSource = dataTable;
                    }
                }
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
                    ExportDataGridViewToPdf(dataGridView6, filePath);
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
