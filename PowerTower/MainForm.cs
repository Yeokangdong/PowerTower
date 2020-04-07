
using MaruData;
using MaruData.GLS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerTower
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            SetDefaultViewStyle(dataGridView);

            LoadDataGrid();

            canvasRod.db = new DrawMaruObejctList();
            canvasTtype.db = new DrawMaruObejctList();

            DataContainerTower.Instance.runPath = Application.StartupPath;
            DataContainerTower.Instance.LoadSetting();

            openFileDialog.InitialDirectory = DataContainerTower.Instance.setting.path;
            saveFileDialog.InitialDirectory = DataContainerTower.Instance.setting.path;

            DrawRod(un.D, un.T);
              DrawT(un.d1TypeT, un.d2TypeT, un.tTypeT);


            textBoxDepthRod.textBox.Text = string.Format("{0:F3}", un.D);
            textBoxThickRod.textBox.Text = string.Format("{0:F3}", un.T);


            textBoxDepthT.textBox.Text = string.Format("{0:F3}", un.d1TypeT);
            textBoxLengthT.textBox.Text = string.Format("{0:F3}", un.tTypeT);
            textBoxThickT.textBox.Text = string.Format("{0:F3}", un.d2TypeT);


            analysisResult = new AnalysisResult();

           

          //  Draw3dBox();

        }

        AnalysisResult analysisResult;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void LoadDataGrid()
        {
            LoadDataGrid(dataGridView, DataContainerTower.Instance.sensorList);


        }

        private void MakeTable(DataGridView view)
        {
            string[] titles = new string[] { "No.", "a", "위치(x)", "위치(y)", "저항(R)", "XML" };

            DataTable table = new DataTable();
            foreach (string s in titles)
            {
                table.Columns.Add(s, typeof(string));
            }


            view.DataSource = table;

            foreach (DataGridViewColumn c in dataGridView.Columns)
            {
                DataGridViewCellStyle cs = new DataGridViewCellStyle();
                cs.Alignment = DataGridViewContentAlignment.MiddleCenter;

                c.HeaderCell.Style = cs;

                if (c.HeaderText == "XML")
                    c.Visible = false;

                if (c.HeaderText == "a")
                    c.Visible = checkBoxTypeT.Checked;
            }
        }

        public void LoadDataGrid(DataGridView view, List<Sensor2> sensorList)
        {
            DataTable table = view.DataSource as DataTable;

            if (table == null)
                MakeTable(view);

            table = view.DataSource as DataTable;

            //string[] titles = new string[] { "No.", "소스", "리시버", "전기저항", "XML" };

            //DataTable table = new DataTable();
            //foreach (string s in titles)
            //{
            //    table.Columns.Add(s, typeof(string));
            //}
            //table = dataGridView.DataSource as DataTable;

            if (table.Rows.Count > 0)
                table.Rows.Clear();


            Random rd = new Random();
            //for (int i = 0; i < 4; i++)
            //{
            //    DataRow row = table.NewRow();

            //    row[0] = (i + 1).ToString();
            //    row[1] = Math.Round(rd.NextDouble() * 100, 2).ToString();
            //    row[2] = Math.Round(rd.NextDouble() * 100, 2).ToString();
            //    row[3] = Math.Round(rd.NextDouble() * 100, 2).ToString();
            //    row[4] = "";//ss.GetXML();

            //    table.Rows.Add(row);
            //}

            int i = 0;

            foreach (Sensor2 ss in sensorList)
            {
                DataRow row = table.NewRow();

                row[0] = (++i).ToString();
                row[1] = string.Format("{0:F2}", ss.a);
                row[2] = string.Format("{0:F2}", ss.ptSource.x);
                row[3] = string.Format("{0:F2}", ss.ptSource.y);
                row[4] = ss.resistance.ToString();
                row[5] = ss.GetXML();

                table.Rows.Add(row);
            }



        }

        private void SaveDataGrid(DataGridView view, List<Sensor2> sensorList)
        {
            DataTable table = view.DataSource as DataTable;

            if (table == null || table.Rows.Count == 0)
                return;


            sensorList.Clear();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];

                string xml = row[5].ToString();
                System.Xml.XmlDocument xdoc = new System.Xml.XmlDocument();
                xdoc.InnerXml = xml;

                Sensor2 slocal = (Sensor2)Sensor2.DeSerializeObject(xdoc, typeof(Sensor2));

                sensorList.Add(slocal);

            }

            int s = sensorList.Count;
        }


        public void SetDefaultViewStyle(DataGridView view)
        {
            view.AllowUserToAddRows = false;
            view.AllowUserToDeleteRows = false;

            view.AllowUserToResizeRows = false;

            view.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            DataGridViewCellStyle cs = new DataGridViewCellStyle();
            cs.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cs.WrapMode = DataGridViewTriState.True;
            view.ColumnHeadersDefaultCellStyle = cs;

            view.MultiSelect = false;
            view.ReadOnly = true;
            view.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            view.RowHeadersVisible = false;
            view.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            view.RowTemplate.Height = 23;
            view.RowTemplate.ReadOnly = true;
            // view.FirstDisplayedScrollingRowIndex = 1;
            // view.ColumnAdded += dataGridView_ColumnAdded;
        }

        private void buttonLoadCSV_Click(object sender, EventArgs e)
        {
            if (new DirectoryInfo(DataContainerTower.Instance.setting.path).Exists)
            openFileDialog.InitialDirectory = DataContainerTower.Instance.setting.path;



            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DataContainerTower.Instance.setting.path = new FileInfo(openFileDialog.FileName).DirectoryName;

                CSVReader reader = new CSVReader(openFileDialog.FileName);

                DataContainerTower.Instance.sensorList.Clear();
                reader.ReadSensorList(DataContainerTower.Instance.sensorList, true);// radioButtonTypeT2.Checked);

                LoadDataGrid(dataGridView, DataContainerTower.Instance.sensorList);
            }
        }

        private void buttonSaveCSV_Click(object sender, EventArgs e)
        {
            if (new DirectoryInfo(DataContainerTower.Instance.setting.path).Exists)
                saveFileDialog.InitialDirectory = DataContainerTower.Instance.setting.path;

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DataContainerTower.Instance.setting.path = new FileInfo(saveFileDialog.FileName).DirectoryName;

                SaveDataGrid(dataGridView, DataContainerTower.Instance.sensorList);

                CSVWriter writer = new CSVWriter(saveFileDialog.FileName);

                List<Sensor2> sensorlist = DataContainerTower.Instance.sensorList;
                writer.WriteSensorList(sensorlist);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonSaveCSV_Click(sender, e);
        }

        private void buttonADDSensor_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBoxKeyInSourceX.textBox.Text);
            double y = double.Parse(textBoxKeyInSourceY.textBox.Text);
            double r = double.Parse(textBoxKeyInResisty.textBox.Text);
            double a = double.Parse(textBoxA.textBox.Text);

            AddSensor(x, y, r, a);
        }

        private void AddSensor(double x, double y, double r, double a)
        {
            Sensor2 ss = new Sensor2();
            ss.ptSource = new Point3D(x, y, 0.0);
            ss.resistance = r;
            ss.a = a;

            DataContainerTower.Instance.sensorList.Add(ss);

            DataGridView view = dataGridView;
            DataTable dt = view.DataSource as DataTable;

            if (dt == null)
            {
                MakeTable(view);
                dt = view.DataSource as DataTable;
            }

            if (dt != null)
            {
                DataRow row = dt.NewRow();

                row[0] = (dt.Rows.Count + 1).ToString();
                row[1] = string.Format("{0:F2}", ss.a);
                row[2] = string.Format("{0:F2}", ss.ptSource.x);
                row[3] = string.Format("{0:F2}", ss.ptSource.y);
                row[4] = ss.resistance.ToString();
                row[5] = ss.GetXML();

                dt.Rows.Add(row);
            }
        }

        private void buttonDELSensor_Click(object sender, EventArgs e)
        {
            DataGridView view = dataGridView;


            if (view.SelectedRows.Count == 0)
                return;

            int seletedIndexDeleted = view.SelectedRows[0].Index;

            DataGridViewRow row = view.Rows[seletedIndexDeleted];
            view.Rows.Remove(row);

            ReNumberingIndex(view);

            if (seletedIndexDeleted < DataContainerTower.Instance.sensorList.Count)
                DataContainerTower.Instance.sensorList.RemoveAt(seletedIndexDeleted);
        }

        internal void ReNumberingIndex(DataGridView view)
        {
            DataTable dt = view.DataSource as DataTable;

            // tableKHTN.table.Columns[0].ColumnName = "No.";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i][0] = string.Format("{0}", i + 1);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DrawRod(double d, double t)
        {
            Draw3dBox(d, t);
            return;


            try
            {
                double tol = 1.0e-2;
                if ((d < tol) || (t < tol))
                    return;

                int height = (int)(d * 140);

                Bitmap bm = new Bitmap(height, height);
                Graphics g = Graphics.FromImage(bm);

                g.FillRectangle(Brushes.White, 0, 0, bm.Width, bm.Height);

                Pen p1 = new Pen(Color.Black, 4.0f);
                g.DrawLine(p1, 0, 10, bm.Width, 10);

                int centX = (int)(bm.Width / 2.0 - (t * 100) / 2.0);
                g.DrawRectangle(p1, centX, 10, (int)(t * 100), (int)(d * 100));

                g.DrawString("D", new Font("Arial", (float)(d * 10)), Brushes.Black, new PointF((float)(centX + t * 140), (float)(d * 50)));
                //  g.DrawString("t", new Font("Arial", (float)(d * 10)), Brushes.Black, new PointF((float)(centX ), (float)(d * 110)));

                pictureBoxRod.Image = bm;
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
        }

        //d1 depth, d2 bottom thickn t length
        private void DrawT(double d1, double d2, double t)
        {

            Draw3dBox(d1, d2, t);
            return;

            try
            {
                double tol = 1.0e-2;
                if ((d1 < tol) || (d2 < tol) || (t < tol))
                    return;

                int height = (int)((d1 + d2) * 140);

                Bitmap bm = new Bitmap(height, height);
                Graphics g = Graphics.FromImage(bm);

                g.FillRectangle(Brushes.White, 0, 0, bm.Width, bm.Height);

                Pen p1 = new Pen(Color.Black, 4.0f);
                g.DrawLine(p1, 0, 10, bm.Width, 10);

                int centX = (int)(bm.Width / 2.0 - (t * 100) / 2.0);
                int centX2 = (int)(bm.Width / 2.0 - (t / 3.0 * 100) / 2.0);

                g.DrawRectangle(p1, centX2, 10, (int)(t * 100 / 3.0), (int)(100 * (d1)));
                g.DrawRectangle(p1, centX, 10 + (int)(100 * (d1)), (int)(t * 100), (int)(d2 * 100));

                g.DrawString("L", new Font("Arial", (float)((d1 + d2) * 10)), Brushes.Black, new PointF((float)(centX), (float)((d1) * 50)));
                g.DrawString("B", new Font("Arial", (float)((d1 + d2) * 10)), Brushes.Black, new PointF((float)(centX2 + 10), (float)((d1 + d2) * 110)));
                g.DrawString("t", new Font("Arial", (float)((d1 + d2) * 10)), Brushes.Black, new PointF((float)(centX + t * 110), (float)((d1) * 105)));

                Pen pw = new Pen(Color.White, 0.1f);
                // g.DrawLine(pw,  51, 20, 59, 20);

                pictureBoxT.Image = bm;
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
        }

        System.Diagnostics.Process process;

        private void KillProcess()
        {
            if (process != null && !process.HasExited)
                process.Kill();
        }

        public bool CheckDir(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            return dir.Exists;
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            string pathTemp = System.IO.Directory.GetCurrentDirectory();

            if (!CheckDir("C:\\python"))
            {
                MessageBox.Show("해석모듈이 설치되지 않았습니다.");
                return;
            }

            if (dataGridView.Rows.Count < 2)
            {
                MessageBox.Show("소스위치와 저항값이 입력되지 않았습니다.");
                return;
            }

            System.IO.Directory.SetCurrentDirectory("C:\\python");

            

            if (checkBoxRod.Checked)
            {
                MakeAppoxCSV();
                FileInfo fiData1 = new FileInfo("C:\\python\\rod2.bat");  //approximation
                System.Diagnostics.ProcessStartInfo si = new System.Diagnostics.ProcessStartInfo(fiData1.FullName);

                //     si.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process = System.Diagnostics.Process.Start(si);

                ReadResultTypeCylinder();
            }

           
            if (checkBoxTypeT.Checked)
            {
                System.IO.Directory.SetCurrentDirectory("C:\\python\\MLP2");
                MakeCSV(false);

                FileInfo fiData1 = new FileInfo("C:\\python\\MLP2\\t2.bat");  //1.bat
                System.Diagnostics.ProcessStartInfo si = new System.Diagnostics.ProcessStartInfo(fiData1.FullName);

                //     si.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process = System.Diagnostics.Process.Start(si);

                ReadResultTypeT(false);
            }

            System.IO.Directory.SetCurrentDirectory(pathTemp);

            this.buttonExit.Focus();
        }

        private void MakeAppoxCSV()
        {
            SaveDataGrid(dataGridView, DataContainerTower.Instance.sensorList);

            StreamWriter sw = new StreamWriter("C:\\python\\1.csv");

            //  sw.WriteLine("sinv,d1,d2,t1,t2,x,y,R");

            foreach (Sensor2 ss in DataContainerTower.Instance.sensorList)
            {
                sw.WriteLine(string.Format("{0:F3}, {1:F3}, {2:F3}", ss.ptSource.x, ss.ptSource.y, ss.resistance));
            }

            sw.Close();
        }

        private void MakeCSV(bool isVersionOld = true)
        {
            SaveDataGrid(dataGridView, DataContainerTower.Instance.sensorList);

            StreamWriter sw;

            if (isVersionOld)
                sw = new StreamWriter("C:\\python\\real0.csv");
            else
                sw = new StreamWriter("C:\\python\\MLP2\\real2.csv");

            if (isVersionOld)
         //       sw.WriteLine("sinv,d1,d2,t1,t2,x,y,R");
            sw.WriteLine("t1,t2,d1,d2,x,y,R");
            else
                sw.WriteLine("t1,t2,d1,d2,x,y,R");

            foreach (Sensor2 ss in DataContainerTower.Instance.sensorList)
            {
                if (isVersionOld)
         //           sw.WriteLine(string.Format("0,0,0,0,0,{0:F3},{1:F3},{2:F3}", ss.ptSource.x, ss.ptSource.y, ss.resistance));
                sw.WriteLine(string.Format("{3:F3},0,0,0,{0:F3},{1:F3},{2:F3}", ss.ptSource.x, ss.ptSource.y, ss.resistance, ss.a));

                else
                    sw.WriteLine(string.Format("{3:F3},0,0,0,{0:F3},{1:F3},{2:F3}", ss.ptSource.x, ss.ptSource.y, ss.resistance, ss.a));

            }

            sw.Close();
        }

        Unknown un = new Unknown();

        private void ReadResultTypeCylinder(bool isVersionOld = true)
        {
            FileInfo fiData1;

            if (isVersionOld)
                fiData1 = new FileInfo("C:\\python\\result\\output1.txt");
            else
                fiData1 = new FileInfo("C:\\python\\result\\output2.txt");


            if (!fiData1.Exists)
                return;

            StreamReader sr = new StreamReader(fiData1.FullName);
            double err = double.Parse(sr.ReadLine());
            double depth = double.Parse(sr.ReadLine());

            textBoxErrorRod.Text = string.Format("{0:F3}", err);
            textBoxDepthRod.textBox.Text = string.Format("{0:F3}", depth);
            textBoxThickRod.textBox.Text = string.Format("{0:F3}", 440 / 100);


            un.D = depth * 1000;
            un.T = 440 / 100;

            DrawRod(un.D, un.T);

            sr.Close();
        }

        private void ReadResultTypeT(bool isVersionOld = true)
        {
            FileInfo fiData1;

            if (isVersionOld)
                fiData1 = new FileInfo("C:\\python\\result\\result.csv");
            else
                fiData1 = new FileInfo("C:\\python\\MLP2\\result\\result.csv");

            if (!fiData1.Exists)
                return;

            StreamReader sr = new StreamReader(fiData1.FullName);

            string line = sr.ReadLine();
            double d1 = 0, d2 = 0, t = 0;

            for (int i = 0; i < 3; i++)
            {
                line = sr.ReadLine();
                string[] texts = line.Split(',');

                if (isVersionOld)
                {
                    //d1,d2,t2
                    t += Math.Abs(double.Parse(texts[texts.Length - 1]));  
                    d2 += Math.Abs(double.Parse(texts[texts.Length - 2]));
                    d1 += Math.Abs(double.Parse(texts[texts.Length - 3]));
                }
                else
                {
                    //t2,d1,d2
                    d2 += Math.Abs(double.Parse(texts[texts.Length - 1]));
                    d1 += Math.Abs(double.Parse(texts[texts.Length - 2]));
                    t += Math.Abs(double.Parse(texts[texts.Length - 3]));
                }
            }
            un.tTypeT = t / 3.0;
            un.d2TypeT = d2 / 3.0;
            un.d1TypeT = d1 / 3.0;

            textBoxDepthT.textBox.Text = string.Format("{0:F3}", un.d1TypeT);
            textBoxLengthT.textBox.Text = string.Format("{0:F3}", un.tTypeT);
            textBoxThickT.textBox.Text = string.Format("{0:F3}", un.d2TypeT);

            DrawT(un.d1TypeT, un.d2TypeT, un.tTypeT);

            sr.Close();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (new DirectoryInfo(DataContainerTower.Instance.setting.path).Exists)
                DataContainerTower.Instance.SaveSetting();
        }

        private void checkBoxTypeRod_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonSaveResult_Click(object sender, EventArgs e)
        {
            if (new DirectoryInfo(DataContainerTower.Instance.setting.path).Exists)
                saveFileDialog.InitialDirectory = DataContainerTower.Instance.setting.path;

                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DataContainerTower.Instance.setting.path = new FileInfo(saveFileDialog.FileName).DirectoryName;

                CSVWriter writer = new CSVWriter(saveFileDialog.FileName);

                List<Sensor2> sensorlist = DataContainerTower.Instance.sensorList;
                writer.WriteResult(un);
            }
        }

        private void dataGridView_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control && e.KeyCode == Keys.V)
                {
                    //clipboard
                    string cText = //"4\t5\t6\r\n8\t7\t8\r\n5\t6\t7\r\n";
                    Clipboard.GetText();

                    string[] lines = cText.Split('\n');

                    foreach (string line in lines)
                    {
                        string[] items = line.Split('\t');

                        if (items.Length != 4)
                            continue;

                        AddSensor(double.Parse(items[0]), double.Parse(items[1]), double.Parse(items[2]), double.Parse(items[3]));
                    }
                }

                if (e.KeyCode == Keys.Delete)
                {
                    buttonDELSensor_Click(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("데이터 형식이 맞지 않습니다.");
            }
        }

     

        private void checkBoxTypeT_CheckedChanged(object sender, EventArgs e)
        {
            textBoxA.Enabled = checkBoxTypeT.Checked;


            foreach (DataGridViewColumn c in dataGridView.Columns)
            {
                DataGridViewCellStyle cs = new DataGridViewCellStyle();
                cs.Alignment = DataGridViewContentAlignment.MiddleCenter;

                c.HeaderCell.Style = cs;

                if (c.HeaderText == "a")
                    c.Visible = checkBoxTypeT.Checked;
            }
        }

        private void Draw3dBox(double d, double t)
        {
            DrawRodGDI(canvasRod.db, d, t);

            canvasRod.db.GetBound();
            canvasRod.m_camera.View = MaruGDI.ViewTypes.Iso;
            canvasRod.m_camera.scale = 2; // canvasRod.CalcScale() * 50;
            canvasRod.Draw();
        }

        private void DrawRodGDI(DrawMaruObejctList db, double d, double t)
        {
            db.dataList.Clear();

       
            Point3D pt1 = new Point3D(0, 0, 0);
         

            //실린더
            Point3D cenPt1 = new Point3D(0f, 20f, 0f);
            Point3D cenPt2 = new Point3D(0f, (float)(-1 * 20), 0f);


            //if (t * 5 < d)
            //    t = 0.2 * d;

            float rad = (float)(20 * (t/2) / d);
            Cylinder cy = new Cylinder(cenPt1, cenPt2, rad, rad, Color.Blue, 1.0f);
            db.dataList.Add(cy);

            Line indLine1 = new Line(cenPt1.OffsetX(rad * 1.1), cenPt1.OffsetX(rad * 1.1 + 16), Color.Black, 1.0f);
            db.dataList.Add(indLine1);
            Line indLine2 = new Line(cenPt2.OffsetX(rad * 1.1), cenPt2.OffsetX(rad * 1.1 + 16), Color.Black, 1.0f);
            db.dataList.Add(indLine2);
            Line indLine3 = new Line((cenPt1.OffsetX(rad * 1.1)+ cenPt1.OffsetX(rad * 1.1 + 16))/2, (cenPt2.OffsetX(rad * 1.1) + cenPt2.OffsetX(rad * 1.1 + 16)) /2, Color.Black, 1.0f);
            db.dataList.Add(indLine3);

            Point3D textPt = ((cenPt1 + cenPt2) / 2.0).Offset(rad * 1.1 + 8, 4, 0);
            MaruData.GLS.Text pt = new MaruData.GLS.Text(textPt, Color.Black, 5.0f);
            pt.text = "D";
            pt.textSize = 15;
            db.dataList.Add(pt);
        

            //plane
            Triangle tr1 = new Triangle(pt1, pt1.OffsetX(50), pt1.Offset(50, 0, 50), Color.FromArgb(100, Color.SaddleBrown), 0.1f);
            tr1.PolyMode = PLMode.Fill;
          //  db.dataList.Add(tr1);

            Triangle tr2 = new Triangle(pt1, pt1.Offset(50, 0, 50), pt1.OffsetZ(50), Color.FromArgb(100, Color.SaddleBrown), 0.1f);
            tr2.PolyMode = PLMode.Fill;
           // db.dataList.Add(tr2);



        


        }


        private void Draw3dBox(double d1, double d2, double t)
        {
            DrawTtypeGDI(canvasTtype.db, d1, d2, t);

            canvasTtype.db.GetBound();
            canvasTtype.m_camera.View = MaruGDI.ViewTypes.Iso;
            canvasTtype.m_camera.scale = 2; // canvasRod.CalcScale() * 50;
            canvasTtype.Draw();
        }

        private void DrawTtypeGDI(DrawMaruObejctList db, double d1, double d2, double t)
        {
            db.dataList.Clear();


            Point3D pt1 = new Point3D(0, 0, 0);

            //L + t >>  50
            double depthTotal = d1 + d2;
            double scale = 50 / depthTotal;

            //실린더
            Point3D cenPt1 = new Point3D(0f, 25, 0f);
            Point3D cenPt2 = cenPt1.OffsetY( -d1 * scale);

          
            float rad = (float)(scale *(t/3) );
            Cylinder cy = new Cylinder(cenPt1, cenPt2, rad, rad, Color.Blue, 1.0f);
            db.dataList.Add(cy);


            Line indLine1 = new Line(cenPt1.OffsetX(rad * 1.1), cenPt1.OffsetX(rad * 1.1 + 16), Color.Black, 1.0f);
            db.dataList.Add(indLine1);
            Line indLine2 = new Line(cenPt2.OffsetX(rad * 1.1), cenPt2.OffsetX(rad * 1.1 + 16), Color.Black, 1.0f);
            db.dataList.Add(indLine2);
            Line indLine3 = new Line((cenPt1.OffsetX(rad * 1.1) + cenPt1.OffsetX(rad * 1.1 + 16)) / 2, (cenPt2.OffsetX(rad * 1.1) + cenPt2.OffsetX(rad * 1.1 + 16)) / 2, Color.Black, 1.0f);
            db.dataList.Add(indLine3);

            Point3D textPt = ((cenPt1 + cenPt2) / 2.0).Offset(rad * 1.1+8, 10, 0);
            MaruData.GLS.Text pt = new MaruData.GLS.Text(textPt, Color.Black, 5.0f);
            pt.text = "L";
            pt.textSize = 15;
            db.dataList.Add(pt);



            Point3D boxBeg = new Point3D(scale * (-t / 2), -25, scale * (-t / 2));
            RectBox3D box = new RectBox3D(boxBeg, boxBeg.Offset(scale * t, scale * d2, scale * t), Color.Blue, 1.0f);
            db.dataList.Add(box);

            Point3D tLineBasePt = boxBeg.OffsetX(1.1 * scale * t);
            Line indLine4 = new Line(tLineBasePt, tLineBasePt.OffsetX(6), Color.Black, 1.0f);
            db.dataList.Add(indLine4);
            Line indLine5 = new Line(tLineBasePt.OffsetY(scale * d2), tLineBasePt.Offset(6,scale * d2,0), Color.Black, 1.0f);
            db.dataList.Add(indLine5);
            Line indLine6 = new Line((tLineBasePt + tLineBasePt.OffsetX(6)) / 2, (tLineBasePt.OffsetY(scale * d2)+tLineBasePt.Offset(6, scale * d2, 0)) / 2, Color.Black, 1.0f);
            db.dataList.Add(indLine6);


            Point3D textPt2 = boxBeg.Offset(1.1 * scale * t + 4 , scale * d2 /2.0 + 4 , 0);
            MaruData.GLS.Text pt2 = new MaruData.GLS.Text(textPt2, Color.Black, 5.0f);
            pt2.text = "t";
            pt2.textSize = 15;
            db.dataList.Add(pt2);


            Point3D bLineBasePt = boxBeg.Offset(0, 0, scale * t);
            Line indLine7 = new Line(bLineBasePt, bLineBasePt.OffsetZ(6), Color.Black, 1.0f);
            db.dataList.Add(indLine7);

            Line indLine8 = new Line(bLineBasePt.OffsetX(scale * t), bLineBasePt.Offset(scale * t, 0, 6), Color.Black, 1.0f);
            db.dataList.Add(indLine8);

            Line indLine9 = new Line((bLineBasePt+ bLineBasePt.OffsetZ(6)) / 2, (bLineBasePt.OffsetX(scale * t)+ bLineBasePt.Offset(scale * t, 0, 6)) / 2, Color.Black, 1.0f);
            db.dataList.Add(indLine9);


            Point3D textPt3 = boxBeg.Offset(scale * t /2.0, scale * d2 / 2.0 + 4, 1.2 * scale * t);
            MaruData.GLS.Text pt3 = new MaruData.GLS.Text(textPt3, Color.Black, 5.0f);
            pt3.text = "B";
            pt3.textSize = 15;
            db.dataList.Add(pt3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawT(5, 5, 10);
        }
    }
}
