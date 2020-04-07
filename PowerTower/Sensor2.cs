using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using MaruData;
namespace PowerTower
{
    public class Sensor2 : BaseData
    {
        public Point3D ptSource;
        public Point3D ptReciever;

        public double a;
        public double resistance;

        public Sensor2()
        {
            SetDefaultValue();
        }

        public Sensor2(Point3D ptSource, double resist)
        {
          //  this.ptReciever = ptReciever;
            this.ptSource = ptSource;

            this.resistance = resist;
        }

        private void SetDefaultValue()
        {
            ptSource = new Point3D(0, 5, 0);
            ptReciever = new Point3D(0, 0, 0);

            resistance = 0;
            a = 0;
        }

        public override string GetXML()
        {
            XmlDocument xdoc = new XmlDocument();
            BaseData.SerializeXMLDocument(xdoc, this, typeof(Sensor2));
            this.DataAsXML = xdoc.InnerXml;

            return base.GetXML();
        }

        public override void LoadCSV(string line)
        {
            string[] data = line.Split(',');

            this.SetDefaultValue();

            if (data.Length == 3)
            {
                this.ptSource = Point3D.GetPont3D(data, 0);
              
                this.resistance = double.Parse(data[2]);
            }
        }

        public void LoadCSV(string line, bool type2)
        {
            string[] data = line.Split(',');

            this.SetDefaultValue();

            if (data.Length == 7)
            {
                this.a = double.Parse(data[0]);
                this.ptSource = Point3D.GetPont3D(data, 4);

                this.resistance = double.Parse(data[6]);
            }
        }

        public override string SaveCSV()
        {
            CSVText = string.Format("{0},{1}", this.ptSource.ToString(), this.resistance.ToString());
            return base.SaveCSV();
        }

        public string SaveCSVType2()
        {
            CSVText = string.Format("{0},{1},{2}",this.a, this.ptSource.ToString(), this.resistance.ToString());
            return base.SaveCSV();
        }
    }
}
