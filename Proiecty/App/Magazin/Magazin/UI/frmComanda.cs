using Magazin.BLL;
using Magazin.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

using System.Web.UI;
using System.Web;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Kernel.Colors;
using iText.Layout.Borders;

namespace Magazin.UI
{
    public partial class frmComanda : Form
    {
        string pathFactura;
        frmAdminDashboard frm;
        public frmComanda()
        {
            InitializeComponent();
            frm = new frmAdminDashboard();
        }
        ComandaDAL dal = new ComandaDAL();
        ComandaBLL c = new ComandaBLL();
        public void Clear()
        {
            txtAdresaID.Text = "";
            txtComandaID.Text = "";
            txtNume.Text = "";
            txtPrenume.Text = "";
            txtSearch.Text = "";
            txtDataComanda.Text = "";
            txtDataExpediere.Text = "";
            txtStare.Text = "";
            txtSuma.Text = "";
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmComanda_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvComanda.DataSource = dt;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvComanda.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvComanda.DataSource = dt;
            }
        }

        private void dgvComanda_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtAdresaID.Text = dgvComanda.Rows[RowIndex].Cells[1].Value.ToString(); 
            txtComandaID.Text = dgvComanda.Rows[RowIndex].Cells[0].Value.ToString();
            txtNume.Text = dgvComanda.Rows[RowIndex].Cells[2].Value.ToString();
            txtPrenume.Text = dgvComanda.Rows[RowIndex].Cells[3].Value.ToString();
            txtDataComanda.Text = dgvComanda.Rows[RowIndex].Cells[4].Value.ToString();
            txtDataExpediere.Text = dgvComanda.Rows[RowIndex].Cells[5].Value.ToString();
            txtStare.Text = dgvComanda.Rows[RowIndex].Cells[6].Value.ToString();
            txtSuma.Text = dgvComanda.Rows[RowIndex].Cells[7].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            c.adresa_id=Convert.ToInt32(txtAdresaID.Text);
            c.data_comanda = Convert.ToDateTime(txtDataComanda.Text);
            c.data_expediere=Convert.ToDateTime(txtDataExpediere.Text);
            c.stare=txtStare.Text;
            bool succes = dal.Insert(c);

            if (succes)
            {
                MessageBox.Show("Comanda a fost creata cu succes.");
                Clear();
                DataTable dt = dal.Select();
                dgvComanda.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Nu s-a putut crea noua comanda.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            c.adresa_id = Convert.ToInt32(txtAdresaID.Text);
            c.comanda_id = Convert.ToInt32(txtComandaID.Text);
            c.data_comanda = Convert.ToDateTime(txtDataComanda.Text);
            c.data_expediere = Convert.ToDateTime(txtDataExpediere.Text);
            c.stare = txtStare.Text;
            bool succes = dal.Update(c);

            if (succes)
            {
                MessageBox.Show("Comanda a fost actualizata cu succes.");
                Clear();
                DataTable dt = dal.Select();
                dgvComanda.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Nu s-a putut actualiza comanda.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            c.comanda_id = Convert.ToInt32(txtComandaID.Text);
            bool succes = dal.Delete(c);

            if (succes)
            {
                MessageBox.Show("Comanda stearsa cu succes.");
                Clear();
                DataTable dt = dal.Select();
                dgvComanda.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Comanda nu a fost stearsa.");
            }
        }

        private void btnComenziMari_Click(object sender, EventArgs e)
        {
            DataTable dt = dal.Select_having();
            dgvComanda.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvComanda.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm.Show();
        }

        [Obsolete]
        protected void GenerateInvoicePDF()
        {
            DataTable dt = dal.InvoiceBill(txtComandaID.Text);
            dgvComanda.DataSource = dt;

            String comandaID = dgvComanda.Rows[0].Cells[0].Value.ToString();
            String adresa = dgvComanda.Rows[0].Cells[1].Value.ToString();
            String nume = dgvComanda.Rows[0].Cells[2].Value.ToString();
            String prenume = dgvComanda.Rows[0].Cells[3].Value.ToString();
            String data_comanda = dgvComanda.Rows[0].Cells[4].Value.ToString();

            String[] nume_produs = new String[dgvComanda.Rows.Count];
            String[] cod_produs = new String[dgvComanda.Rows.Count];
            String[] pret = new String[dgvComanda.Rows.Count];
            String[] cantitate = new String[dgvComanda.Rows.Count];
            String[] suma_per_cantitate = new String[dgvComanda.Rows.Count];
            double[] suma_per_cantitate_int = new double[dgvComanda.Rows.Count];

            for (int row = 0; row < dt.Rows.Count; row++)
            {
                nume_produs[row] = dgvComanda.Rows[row].Cells[5].Value.ToString();
                cod_produs[row] = dgvComanda.Rows[row].Cells[6].Value.ToString();
                pret[row] = dgvComanda.Rows[row].Cells[7].Value.ToString();
                cantitate[row] = dgvComanda.Rows[row].Cells[8].Value.ToString();
                suma_per_cantitate[row] = dgvComanda.Rows[row].Cells[9].Value.ToString();

                suma_per_cantitate_int[row] = Convert.ToDouble(dgvComanda.Rows[row].Cells[9].Value.ToString());
            }
            pathFactura = "Facturi\\Factura_" + comandaID + "_" + nume + "_" + prenume + ".pdf";
            PdfWriter writer = new PdfWriter(@pathFactura);
            PdfDocument pdf = new PdfDocument(writer);
            Document pdfDoc = new Document(pdf);
            Paragraph titlu = new Paragraph("FACTURA")
                                .SetTextAlignment(TextAlignment.CENTER)
                                .SetFontSize(20);
            Paragraph nrComanda = new Paragraph("NUMAR FACTURA: "+comandaID)
                                    .SetTextAlignment(TextAlignment.RIGHT)
                                    .SetFontSize(15);
            Paragraph numeClient = new Paragraph(nume+ " " + prenume)
                                    .SetTextAlignment(TextAlignment.LEFT)
                                    .SetFontSize(12);
            Paragraph adresaParagraph = new Paragraph("Adresa: "+adresa)
                                    .SetTextAlignment(TextAlignment.LEFT)
                                    .SetFontSize(10);
            Paragraph dataComanda = new Paragraph("Data comanda: "+data_comanda)
                                    .SetTextAlignment(TextAlignment.LEFT)
                                    .SetFontSize(10);
            LineSeparator ls = new LineSeparator(new SolidLine());
            pdfDoc.Add(titlu);
            pdfDoc.Add(nrComanda);
            pdfDoc.Add(numeClient);
            pdfDoc.Add(adresaParagraph);
            pdfDoc.Add(dataComanda);

            //pdfDoc.Add(ls);


            Table table = new Table(dt.Columns.Count-5, true);
            Cell[] cells=new Cell[dt.Columns.Count];

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                cells[i] = new Cell(1, 1)
                          .SetBackgroundColor(ColorConstants.GRAY)
                          .SetTextAlignment(TextAlignment.CENTER)
                          .Add(new Paragraph(dt.Columns[i].ColumnName)
                                    .SetTextAlignment(TextAlignment.CENTER)
                                    .SetFontSize(12));
                
            }
            for (int i = 5; i < dt.Columns.Count; i++)
                table.AddCell(cells[i]);

            for (int row = 0; row < dt.Rows.Count; row++)
            {
                table.AddCell(new Cell(1, 1)
                          .SetTextAlignment(TextAlignment.CENTER)
                          .Add(new Paragraph(nume_produs[row])
                                    .SetFontSize(8)));
                table.AddCell(new Cell(1, 1)
                          .SetTextAlignment(TextAlignment.CENTER)
                          .Add(new Paragraph(cod_produs[row])
                                    .SetFontSize(8)));
                table.AddCell(new Cell(1, 1)
                          .SetTextAlignment(TextAlignment.CENTER)
                          .Add(new Paragraph(pret[row])
                                    .SetFontSize(8)));
                table.AddCell(new Cell(1, 1)
                          .SetTextAlignment(TextAlignment.CENTER)
                          .Add(new Paragraph(cantitate[row])
                                    .SetFontSize(8)));
                table.AddCell(new Cell(1, 1)
                          .SetTextAlignment(TextAlignment.CENTER)
                          .Add(new Paragraph(suma_per_cantitate[row])
                                    .SetFontSize(8)));

            }
            table.AddCell(new Cell(1, 5)
                          .SetTextAlignment(TextAlignment.CENTER)
                          .Add(new Paragraph("TOTAL: "+suma_per_cantitate_int.Sum().ToString())
                                    .SetFontSize(12)));
            
            pdfDoc.Add(table);
            pdfDoc.Close();

        }
            
        

        private void button2_Click(object sender, EventArgs e)
        {
            GenerateInvoicePDF();
            MessageBox.Show("Factura a fost generata cu succes.");
            Clear();
            System.Diagnostics.Process.Start(pathFactura);
            DataTable dt = dal.Select();
            dgvComanda.DataSource = dt;
            
        }

        private void txtSuma_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
