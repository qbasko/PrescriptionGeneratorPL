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
   public partial class Prescription:Form
    {
       private void EmptySpaceValidator(TextBox txtBox, CancelEventArgs e, ErrorProvider ep, string errorString)
       {
           if (String.IsNullOrWhiteSpace(txtBox.Text))
           {
               e.Cancel = true;
               NameErrorProvider.SetError(txtBox, Resources.NameError);
           }
           else
               NameErrorProvider.SetError(txtBox, "");
       }

       private void Name_Validating(object sender, CancelEventArgs e)
       {
           EmptySpaceValidator((TextBox)sender, e, NameErrorProvider, Resources.NameError);
       }

       private void LastName_Validating(object sender, CancelEventArgs e)
       {
           EmptySpaceValidator((TextBox)sender, e, NameErrorProvider, Resources.LastNameError);
       }

       private void Pesel_Validating(object sender, CancelEventArgs e)
       {

       }

       private void BirthDate_Validating(object sender, CancelEventArgs e)
       {

       }

       private void Location_Validating(object sender, CancelEventArgs e)
       {
           EmptySpaceValidator((TextBox)sender, e, NameErrorProvider, Resources.NameError);
       }

       private void NFZBranch_Validating(object sender, CancelEventArgs e)
       {
           EmptySpaceValidator((TextBox)sender, e, NameErrorProvider, Resources.NameError);
           //jeszcze sprawdzic czy jest intem
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
