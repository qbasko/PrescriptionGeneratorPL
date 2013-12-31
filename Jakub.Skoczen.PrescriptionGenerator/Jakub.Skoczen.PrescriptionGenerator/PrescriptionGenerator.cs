using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jakub.Skoczen.PrescriptionGenerator
{
    public class PrescriptionGenerator
    {
        private PrescriptionData _prescriptionData;

        public PrescriptionGenerator()
        {
            _prescriptionData = new PrescriptionData();
        }

        public PrescriptionGenerator(PrescriptionData prescriptionData)
        {
            _prescriptionData = prescriptionData;
        }

        public Graphics Generate()
        {
            Graphics g;

            return g;
        }
    }
}
