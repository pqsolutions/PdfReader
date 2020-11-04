using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace PDFReader
{
    public partial class frmPdfReader : Form
    {
        public string _fileName = "";
        public frmPdfReader()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadPdfFile(txtFileName.Text);
        }

        private void btnBlowse_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() {Filter="PDF files|*.pdf",ValidateNames=true,Multiselect = false })
            { 
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        txtFileName.Text = ofd.FileName;
                        ReadPdfFile(ofd.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        throw;
                    }
                }
            }
        }
        /// <summary>
        /// Method to read content from pdf file
        /// </summary>
        /// <param name="fileName"></param>
        private void ReadPdfFile(string fileName)
        {
            var sb = new StringBuilder();
            using (PdfReader reader = new PdfReader(fileName))
            {
                for (var pgNo = 1; pgNo <= reader.NumberOfPages; pgNo++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    var text = PdfTextExtractor.GetTextFromPage(reader, pgNo, strategy);
                    text = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(text)));
                    sb.Append(text);
                }
            }
            rtbPdfContent.Text = sb.ToString();
        }

        private void frmPdfReader_Load(object sender, EventArgs e)
        {
        }
    }
}
