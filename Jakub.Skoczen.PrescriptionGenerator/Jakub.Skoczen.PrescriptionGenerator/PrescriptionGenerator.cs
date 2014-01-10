using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zen.Barcode;

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

        public void Generate(Graphics g)
        {

            Font font = new Font("Arial", 16);
            //e.Graphics.PageUnit = GraphicsUnit.World;
            DrawHeader(g, font);

            g.DrawString("Rp.", font, new SolidBrush(Color.Black), new PointF(90, 515));
            DrawMultiLineString(g, font, 545);

            DrawBarCode(g);

            g.DrawLine(new Pen(new SolidBrush(Color.Black), 2), new Point(85, 865), new Point(510, 865));

            Font smallerFont=new Font("Arial",12);
            g.DrawString("Data wystawienia", smallerFont, new SolidBrush(Color.Black), new PointF(100, 870));
            g.DrawString(DateTime.Today.ToShortDateString(), font , new SolidBrush(Color.Black), new PointF(90, 890));
            g.DrawLine(new Pen(new SolidBrush(Color.Black), 2), new Point(85, 925), new Point(245, 925));

            g.DrawString("dane id. i podpis lekarza", smallerFont, new SolidBrush(Color.Black), new PointF(300, 870));
            g.DrawString(_prescriptionData.DoctorsId, new Font("Arial", 14), new SolidBrush(Color.Black), new PointF(285, 890));            
            
            g.DrawString("Data realizacji od dnia", smallerFont, new SolidBrush(Color.Black), new PointF(100, 930));
            g.DrawString(DateTime.Today.ToShortDateString(), font, new SolidBrush(Color.Black), new PointF(90, 950));
            g.DrawLine(new Pen(new SolidBrush(Color.Black), 2), new Point(85, 985), new Point(245, 985));

            g.DrawString("Dane podmiotu drukującego", smallerFont, new SolidBrush(Color.Black), new PointF(300, 1040));
            g.DrawLine(new Pen(new SolidBrush(Color.Black), 2), new Point(85, 1065), new Point(510, 1065));
            g.DrawString("Wydruk własny", smallerFont, new SolidBrush(Color.Black), new PointF(320, 1075));            
        }

        private void DrawHeader(Graphics g, Font font)
        {
            g.DrawString("Recepta", new Font("Arial", 22), new SolidBrush(Color.Black), new PointF(95, 70));
            g.DrawString("Świadczeniodawca", font, new SolidBrush(Color.Black), new PointF(90, 258));
            g.DrawLine(new Pen(new SolidBrush(Color.Black), 2), new Point(85, 287), new Point(510, 287));
            g.DrawString("Pacjent", font, new SolidBrush(Color.Black), new PointF(90, 300));
            g.DrawString(String.Concat(_prescriptionData.Name, " ", _prescriptionData.LastName), font, new SolidBrush(Color.Black), new PointF(90, 325));
            g.DrawString(_prescriptionData.Location.ToUpper(), font, new SolidBrush(Color.Black), new PointF(90, 360));
            g.DrawString(String.Concat("wiek-", _prescriptionData.Age.ToString(), " lat"), font, new SolidBrush(Color.Black), new PointF(90, 385));
            g.DrawString("PESEL", font, new SolidBrush(Color.Black), new PointF(90, 445));
            g.DrawString(_prescriptionData.Pesel, font, new SolidBrush(Color.Black), new PointF(90, 470));
            g.DrawLine(new Pen(new SolidBrush(Color.Black), 2), new Point(85, 500), new Point(510, 500));
            g.DrawLine(new Pen(new SolidBrush(Color.Black), 2), new Point(350, 287), new Point(350, 500));

            g.DrawString(_prescriptionData.NFZBranch.ToString(), new Font("Arial", 18), new SolidBrush(Color.Black), new PointF(400, 300));
            g.DrawString("OddziałNFZ", font, new SolidBrush(Color.Black), new PointF(360, 330));
            g.DrawLine(new Pen(new SolidBrush(Color.Black), 2), new Point(350, 360), new Point(510, 360));

            g.DrawString(_prescriptionData.Permissions, new Font("Arial", 18), new SolidBrush(Color.Black), new PointF(400, 370));
            g.DrawString("Uprawnienia", font, new SolidBrush(Color.Black), new PointF(360, 400));
            g.DrawLine(new Pen(new SolidBrush(Color.Black), 2), new Point(350, 430), new Point(510, 430));

            g.DrawString(_prescriptionData.ChronicDiseases, new Font("Arial", 18), new SolidBrush(Color.Black), new PointF(400, 440f));
            g.DrawString("Ch. przewlekłe", font, new SolidBrush(Color.Black), new PointF(360, 470));
        }

        private static void DrawBarCode(Graphics g)
        {
            Code128BarcodeDraw barcode = BarcodeDrawFactory.Code128WithChecksum;
            StringBuilder number = new StringBuilder(DateTime.Now.Ticks.ToString());
            if (number.Length < 20)
            {
                int difference = 20 - number.Length;
                while (difference > 0)
                {
                    int rd = new Random().Next(0, 9);
                    number.Append(rd.ToString());
                    difference--;
                }
                Image img = barcode.Draw(number.ToString(), 43, 2);
                g.DrawImage(img, 120, 800);
            }
        }

        private void DrawMultiLineString(Graphics g, Font font, int y)
        {
            string[] lines = _prescriptionData.PresrciptionInfo.Split(new char[] { '\r', '\n' });
            foreach (string line in lines)
            {
                if (!String.IsNullOrWhiteSpace(line))
                {
                    DrawLine(g, font, ref y, line);
                    y += 20;
                }
            }
        }

        private void DrawLine(Graphics g, Font font, ref int y, string line)
        {
            if (line.Length > 20)
            {
                g.DrawString(line.Substring(0, 20), font, new SolidBrush(Color.Black), new PointF(105f, y));
                y += 20;
                DrawLine(g, font, ref y, line.Substring(20));
            }
            else if (line.Length <= 20)
            {
                g.DrawString(line.Substring(0), font, new SolidBrush(Color.Black), new PointF(105f, y));
                y += 20;
            }
        }
    }
}
