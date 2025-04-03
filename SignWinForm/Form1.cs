using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf.Security;
using System.Security.Cryptography.X509Certificates;

namespace SignWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PdfLoadedDocument document = new PdfLoadedDocument("PDF.pdf");

            //Load digital ID with password.
            PdfCertificate certificate = new PdfCertificate(@"DigitalSignatureTest.pfx", "DigitalPass123");

            //Create a signature with loaded digital ID.
            PdfSignature signature = new PdfSignature(document, document.Pages[0], certificate, "DigitalSignature");
            //Set bounds to the signature.
            signature.Bounds = new System.Drawing.RectangleF(40, 40, 350, 100);

            //Load image from file.
            PdfImage image = PdfImage.FromFile("signature.png");
            //Create a font to draw text.
            PdfStandardFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 15);

            //Drawing text, shape, and image into the signature appearance.
            signature.Appearance.Normal.Graphics.DrawRectangle(PdfPens.Black, PdfBrushes.White, new System.Drawing.RectangleF(50, 0, 300, 100));
            signature.Appearance.Normal.Graphics.DrawImage(image, 0, 0, 100, 100);
            signature.Appearance.Normal.Graphics.DrawString("Digitally Signed by Syncfusion", font, PdfBrushes.Black, 120, 17);
            signature.Appearance.Normal.Graphics.DrawString("Reason: Testing signature", font, PdfBrushes.Black, 120, 39);
            signature.Appearance.Normal.Graphics.DrawString("Location: USA", font, PdfBrushes.Black, 120, 60);

            //Save the PDF document.
            document.Save("SignedAppearance.pdf");

            //Close the document.
            document.Close(true);
        }
    }
}
