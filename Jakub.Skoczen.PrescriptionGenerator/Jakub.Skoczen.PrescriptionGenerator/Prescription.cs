using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                printPreviewDialog1.ShowDialog();
            }
            

        }
    }
}
