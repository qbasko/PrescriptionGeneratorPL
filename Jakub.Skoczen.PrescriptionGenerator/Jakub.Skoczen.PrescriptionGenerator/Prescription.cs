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
using Zen.Barcode;

namespace Jakub.Skoczen.PrescriptionGenerator
{
    public partial class PrescriptionForm : Form
    {
        public PrescriptionForm()
        {
            InitializeComponent();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NameTxtBox.Text = String.Empty;
            LastName.Text = String.Empty;
            Pesel.Text = String.Empty;
            BirthDate.Value = DateTime.Today;
            Location.Text = String.Empty;
            NFZBranch.Text = String.Empty;
            Permissions.Text = String.Empty;
            ChronicDiseases.Text = String.Empty;
            PrescriptionInfo.Text = String.Empty;
            DoctorsId.Text = String.Empty;
            RealizationFromDate.Value = DateTime.Today;
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Pesel.ValidateText();
                printPreviewDialog1.Document = printDocument1;
                printDocument1.DefaultPageSettings.PaperSize = new PaperSize("prescription", 535, 1200);
                var res = printPreviewDialog1.ShowDialog();
                if (res == DialogResult.OK)
                    printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            PrescriptionData prescriptionData = new PrescriptionData();
            prescriptionData.Name = NameTxtBox.Text;
            prescriptionData.LastName = LastName.Text;
            prescriptionData.Pesel = Pesel.Text;
            prescriptionData.Age = (byte)Math.Floor((double)(DateTime.Today - BirthDate.Value).Days / 365.0f);
            prescriptionData.Location = Location.Text;
            prescriptionData.NFZBranch = int.Parse(NFZBranch.Text);
            prescriptionData.Permissions = Permissions.Text;
            prescriptionData.ChronicDiseases = ChronicDiseases.Text;
            prescriptionData.PresrciptionInfo = PrescriptionInfo.Text;
            prescriptionData.DoctorsId = DoctorsId.Text;
            prescriptionData.RealizationFromDate = RealizationFromDate.Value;

            //prescriptionData.Name = "Jan";
            //prescriptionData.LastName = "Kowalski";
            //prescriptionData.Pesel = "90041603375";
            //prescriptionData.Age = 5;
            //prescriptionData.Location = "Poznań";
            //prescriptionData.NFZBranch = 15;
            //prescriptionData.Permissions = "X";
            //prescriptionData.ChronicDiseases = "X";
            //prescriptionData.PresrciptionInfo = "AAAAAAAAAAAAAAAAAAAAAAAAA";
            //prescriptionData.DoctorsId = "DoctorX";
            //prescriptionData.RealizationFromDate = DateTime.Now.Date;

            PrescriptionGenerator prescriptionGenerator = new PrescriptionGenerator(prescriptionData);
            prescriptionGenerator.Generate(e.Graphics);

        }
    }
}

