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
    public partial class StockDicrease : Form
    {
        private Function fn = new Function();
        public StockDicrease()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void combounit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StockDicrease_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE stock SET quantity = quantity + @unit WHERE bloodgroup = @bloodgroup";
                var parameters = new Dictionary<string, object>
                {
                    { "@unit", combounit.Text },
                    { "@bloodgroup", comboblood.Text }
                };
                fn.SetData(query, parameters);
                Function_Load(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Function_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT bloodgroup, quantity FROM stock";
                DataSet ds = fn.getData(query);
                dataGridView5.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btninc_Click(object sender, EventArgs e)
        {

            try
            {
                string query = "UPDATE stock SET quantity = quantity + @unit WHERE bloodgroup = @bloodgroup";
                var parameters = new Dictionary<string, object>
                {
                    { "@unit", combounit.Text },
                    { "@bloodgroup", comboblood.Text }
                };
                fn.SetData(query, parameters);
                Function_Load(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    ExportDataGridViewToPdf(dataGridView5, filePath);
                    MessageBox.Show("PDF generated successfully!");
                }
            }
        }

        private void ExportDataGridViewToPdf(DataGridView dataGridView, string filePath)
        {
            using (Document document = new Document())
            {
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

                    MessageBox.Show("PDF generated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating PDF: " + ex.Message);
                }
            }
        }
    }
}
