using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PowerTower
{
    public class CSVWriter
    {
        StreamWriter sw;

        public CSVWriter(string path)
        {
            FileInfo fInfo = new FileInfo(path);
            if (!fInfo.Exists)
                sw = null;

            sw = new System.IO.StreamWriter(fInfo.FullName, false);
        }

        public CSVWriter(string path, bool append)
        {
            FileInfo fInfo = new FileInfo(path);
            if (!fInfo.Exists)
                sw = null;

            sw = new System.IO.StreamWriter(fInfo.FullName, append);
        }


        public void WriteSensorList(List<Sensor2> list)
        {
            if (sw == null) return;

            foreach (Sensor2 s in list)
            {
                sw.WriteLine(s.SaveCSV());
            }

            sw.Close();
        }

        public void WriteResult(Unknown un)
        {
            if (sw == null) return;


            sw.WriteLine(string.Format("심형 해석결과"));
            sw.WriteLine(string.Format("깊이, {0}", un.D));
            sw.WriteLine(string.Format("두께, {0}", un.T));

            sw.WriteLine(string.Format(" "));

            sw.WriteLine(string.Format("역T형 해석결과"));
            sw.WriteLine(string.Format("깊이 {0}", un.d1TypeT));
            sw.WriteLine(string.Format("저판길이 {0}", un.tTypeT));
            sw.WriteLine(string.Format("저판두께 {0}", un.d2TypeT));

            sw.Close();
        }

    }

}
