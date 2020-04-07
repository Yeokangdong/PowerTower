using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaruData;
using System.Xml.Serialization;
using System.IO;

namespace PowerTower
{


    public class DataContainerTower
    {
        static DataContainerTower instance = null;

        public static DataContainerTower Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataContainerTower();
                }
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        public DataContainerTower()
        {
            NewData();
        }


        public string runPath;
        public List<Sensor2> sensorList;


        public double sensorRadius;

        public bool isCheckTypeT;
        public bool isCheckTypeRod;

        public Setting setting;


        public List<double> graphX;
        public List<double> graphY;



        public void NewData()
        {
            graphX = new List<double>();
            graphY = new List<double>();

            sensorList = new List<Sensor2>();

            sensorList.Add(new Sensor2(new Point3D(1, 1), 107.427));
            sensorList.Add(new Sensor2(new Point3D(1, 3), 107.188));
            sensorList.Add(new Sensor2(new Point3D(1, 5), 107.407));
            sensorList.Add(new Sensor2(new Point3D(1, 7), 107.974));
            sensorList.Add(new Sensor2(new Point3D(1, 9), 106.618));
            sensorList.Add(new Sensor2(new Point3D(1, 11), 107.769));
            sensorList.Add(new Sensor2(new Point3D(1, 13), 107.054));

            runPath = "";
            
        }

        public void LoadSetting()
        {
            string filePath = runPath + "\\setting.ini";

            if (new FileInfo(filePath).Exists)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Setting));

                FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate);
                TextReader reader = new StreamReader(fs);

                object o = serializer.Deserialize(reader);

                reader.Close();
                fs.Close();

                setting = o as Setting;
            }
            else
                setting = new Setting(runPath);
        }

        public void SaveSetting()
        {
            if (setting != null)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Setting));

                FileStream fs = new FileStream(runPath + "\\setting.ini", FileMode.Create);
                TextWriter writer = new StreamWriter(fs, new UTF8Encoding());

                serializer.Serialize(writer, setting);
                writer.Close();

                fs.Close();
            }
        }

        public bool CheckValidRange()
        {
            return true;
        }



    }
}
