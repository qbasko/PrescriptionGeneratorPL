using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jakub.Skoczen.PrescriptionGenerator.Properties;

namespace Jakub.Skoczen.PrescriptionGenerator
{
   public partial class PrescriptionForm:Form
    {
       private void EmptySpaceValidator(TextBox txtBox, CancelEventArgs e, ErrorProvider ep, string errorString)
       {
           if (String.IsNullOrWhiteSpace(txtBox.Text))
           {
               e.Cancel = true;
               ep.SetError(txtBox, errorString);
           }
           else
               ep.SetError(txtBox, String.Empty);
       }

       private void NameTxtBox_Validating(object sender, CancelEventArgs e)
       {
           EmptySpaceValidator((TextBox)sender, e, NameErrorProvider, Resources.NameError);
       }

       private void LastName_Validating(object sender, CancelEventArgs e)
       {
           EmptySpaceValidator((TextBox)sender, e, NameErrorProvider, Resources.LastNameError);
       }

       private void Pesel_Validating(object sender, CancelEventArgs e)
       {
           if (String.IsNullOrWhiteSpace(((MaskedTextBox)sender).Text))
           {
               e.Cancel = true;
               PeselErrorProvider.SetError((MaskedTextBox)sender, Resources.PeselError);
           }
           else
           {
               if (!String.IsNullOrWhiteSpace(((MaskedTextBox)sender).Text) && !CheckPesel(((MaskedTextBox)sender).Text))
               {
                   e.Cancel = true;
                   PeselErrorProvider.SetError((MaskedTextBox)sender, Resources.PeselError);
               }
               else
                   PeselErrorProvider.SetError((MaskedTextBox)sender, String.Empty);
           }
       }

       private void BirthDate_Validating(object sender, CancelEventArgs e)
       {
           if (!(((DateTimePicker)sender).Value < DateTime.Today))
           {
               e.Cancel = true;
               BirthdateErrorProvider.SetError((DateTimePicker)sender, Resources.BirthDateError);
           }
           else
               BirthdateErrorProvider.SetError((DateTimePicker)sender, String.Empty);
       }

       private void Location_Validating(object sender, CancelEventArgs e)
       {
           EmptySpaceValidator((TextBox)sender, e, NameErrorProvider, Resources.NameError);
       }

       private void NFZBranch_Validating(object sender, CancelEventArgs e)
       {
           EmptySpaceValidator((TextBox)sender, e, NameErrorProvider, Resources.NameError);
           int nfz;
           if (!int.TryParse(((TextBox)sender).Text, out nfz))
           {
               e.Cancel = true;
               NFZBranchErrorProvider.SetError((TextBox)sender, Resources.NFZBranchError);
           }
           else
               NFZBranchErrorProvider.SetError((TextBox)sender, String.Empty);           
       }

       private void Permissions_Validating(object sender, CancelEventArgs e)
       {
           EmptySpaceValidator((TextBox)sender, e, NameErrorProvider, Resources.NameError);
       }

       private void ChronicDiseases_Validating(object sender, CancelEventArgs e)
       {
           EmptySpaceValidator((TextBox)sender, e, NameErrorProvider, Resources.NameError);
       }

       private void PrescriptionInfo_Validating(object sender, CancelEventArgs e)
       {
           EmptySpaceValidator((TextBox)sender, e, NameErrorProvider, Resources.NameError);
       }

       private void DoctorsId_Validating(object sender, CancelEventArgs e)
       {
           EmptySpaceValidator((TextBox)sender, e, NameErrorProvider, Resources.NameError);
       }

       private void RealizationFromDate_Validating(object sender, CancelEventArgs e)
       {
           if (!(((DateTimePicker)sender).Value >= DateTime.Today))
           {
               e.Cancel = true;
               RealizationFromDateErrorProvider.SetError((DateTimePicker)sender, Resources.RealizationFromDateError);
           }
           else
               RealizationFromDateErrorProvider.SetError((DateTimePicker)sender, String.Empty);
       }

       private bool CheckPesel(string pesel)
       {
           int[] weights = new int[] { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
           double sum = 0;
           for (int i = 0; i < pesel.Length - 1; i++)
           {
               int num = int.Parse(pesel[i].ToString());
               sum += weights[i] * num;
           }
           sum %= 10;
           sum = 10 - sum;
           if (sum == double.Parse(pesel[pesel.Length - 1].ToString()))
               return true;
           return false;
       }      
       
    }
}
