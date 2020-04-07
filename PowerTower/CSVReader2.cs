using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PowerTower
{
    public class CSVReader
    {
        StreamReader sr;

        public CSVReader(string path)
        {
            FileInfo fInfo = new FileInfo(path);
            if (!fInfo.Exists)
                sr = null;

            sr = new System.IO.StreamReader(fInfo.FullName);
        }


      
        public void ReadSensorList(List<Sensor2> list, bool type2)
        {
            if (sr == null) return;

            if (list != null && list.Count > 0)
                list.Clear();

            string[] lines = sr.ReadToEnd().Split('\r');
            sr.Close();

            foreach (string s in lines)
            {
                if (s.Trim().Length == 0) continue;

                Sensor2 ab = new Sensor2();

                if (type2)
                    ab.LoadCSV(s.Trim(), type2);
                else
                    ab.LoadCSV(s.Trim());

                list.Add(ab);
            }
        }

    }
}
