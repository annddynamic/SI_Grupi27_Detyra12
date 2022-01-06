using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Forms;

namespace Projekti3
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private string pdfFilePath;
        private string certificatePath;
        private string verifyPdfPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfileDialog = new OpenFileDialog();
            if (openfileDialog.ShowDialog() == DialogResult.OK)
            {
                this.pdfFilePath = openfileDialog.FileName;
                //MessageBox.Show("Shtegu " + path +" Passwordi " + password);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfileDialog = new OpenFileDialog();
            if (openfileDialog.ShowDialog() == DialogResult.OK)
            {
                this.certificatePath = openfileDialog.FileName;
                //MessageBox.Show("Shtegu " + path +" Passwordi " + password);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            using (Document pdfDocument = new Document(this.pdfFilePath))
            {
                using (PdfFileSignature signature = new PdfFileSignature(pdfDocument))
                {
                    PKCS7 pkcs = new PKCS7(this.certificatePath, Password.Text); // Use PKCS7/PKCS7Detached objects
                    DocMDPSignature docMdpSignature = new DocMDPSignature(pkcs, DocMDPAccessPermissions.FillingInForms);
                    System.Drawing.Rectangle rect = new System.Drawing.Rectangle(100, 100, 300, 100);
                    // Set signature appearance
                    signature.SignatureAppearance = @"C:/Users/BUTON/source/repos/test/Nenskhirmi-PDF/Untitled-1.jpg";
                    // Create any of the three signature types
                    signature.Certify(1, "Signature Reason", "andidika2001@gmail.com", "Ilir Durmishi", true, rect, docMdpSignature);
                    // Save digitally signed PDF file
                    signature.Save("C:/Users/BUTON/source/repos/PDFSignature/Projekti3/Digitally Signed PDF.pdf");
                }
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfileDialog = new OpenFileDialog();
            if (openfileDialog.ShowDialog() == DialogResult.OK)
            {
                this.verifyPdfPath = openfileDialog.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Document pdfDocument = new Document(this.verifyPdfPath))
            {
                using (PdfFileSignature signature = new PdfFileSignature(pdfDocument))
                {
                    IList<string> sigNames = signature.GetSignNames();
                    if (sigNames.Count > 0) // Any signatures?
                    {
                        if (signature.VerifySigned(sigNames[0] as string)) // Verify first one
                        {
                            if (signature.IsCertified) // Certified?
                            {
                                if (signature.GetAccessPermissions() == DocMDPAccessPermissions.FillingInForms) // Get access permission
                                {
                                    // Do something
                                    verifiedText.Text = "Nenshkrimi eshte valid!";
                                }
                                else
                                {
                                    verifiedText.Text = "Nenshkrimi nuk eshte valid";
                                }
                            }
                            else
                            {
                                verifiedText.Text = "Nuk eshte i Certifikuar";
                            }
                        }
                    }
                    else
                    {
                        verifiedText.Text = "Dokumenti nuk ka nenshkrim";

                    }
                }
            }
        }
    }
}
