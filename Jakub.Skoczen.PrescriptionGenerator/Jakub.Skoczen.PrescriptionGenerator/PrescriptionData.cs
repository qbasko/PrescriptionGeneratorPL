using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jakub.Skoczen.PrescriptionGenerator
{
    public class PrescriptionData
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Pesel { get; set; }
        public byte Age { get; set; }
        public string Location { get; set; }
        public int NFZBranch { get; set; }
        public string Permissions { get; set; }
        public string ChronicDiseases { get; set; }
        public string PresrciptionInfo { get; set; }
        public string DoctorsId { get; set; }
        public DateTime RealizationFromDate { get; set; }
    }
}
