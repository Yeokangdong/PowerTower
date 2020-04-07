namespace PowerTower
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonDELSensor = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonADDSensor = new System.Windows.Forms.Button();
            this.buttonLoadCSV = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxKeyInSourceY = new Maru.Control.TextBoxwLabelUnit();
            this.textBoxKeyInSourceX = new Maru.Control.TextBoxwLabelUnit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxA = new Maru.Control.TextBoxwLabelUnit();
            this.textBoxKeyInResisty = new Maru.Control.TextBoxwLabelUnit();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.canvasTtype = new MaruGDI.Canvas();
            this.canvasRod = new MaruGDI.Canvas();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxThickT = new Maru.Control.TextBoxwLabelUnit();
            this.textBoxLengthT = new Maru.Control.TextBoxwLabelUnit();
            this.textBoxDepthT = new Maru.Control.TextBoxwLabelUnit();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxErrorRod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxThickRod = new Maru.Control.TextBoxwLabelUnit();
            this.textBoxDepthRod = new Maru.Control.TextBoxwLabelUnit();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxRod = new System.Windows.Forms.PictureBox();
            this.pictureBoxT = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkBoxTypeT = new System.Windows.Forms.CheckBox();
            this.checkBoxRod = new System.Windows.Forms.CheckBox();
            this.buttonSaveResult = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxT)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonDELSensor);
            this.groupBox4.Controls.Add(this.dataGridView);
            this.groupBox4.Controls.Add(this.buttonADDSensor);
            this.groupBox4.Controls.Add(this.buttonLoadCSV);
            this.groupBox4.Location = new System.Drawing.Point(12, 61);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(324, 457);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "소스위치와 저항값";
            // 
            // buttonDELSensor
            // 
            this.buttonDELSensor.Location = new System.Drawing.Point(274, 37);
            this.buttonDELSensor.Name = "buttonDELSensor";
            this.buttonDELSensor.Size = new System.Drawing.Size(44, 31);
            this.buttonDELSensor.TabIndex = 47;
            this.buttonDELSensor.Text = "삭제";
            this.buttonDELSensor.UseVisualStyleBackColor = true;
            this.buttonDELSensor.Click += new System.EventHandler(this.buttonDELSensor_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(8, 82);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(310, 351);
            this.dataGridView.TabIndex = 9;
            this.dataGridView.TabStop = false;
            this.dataGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyUp);
            // 
            // buttonADDSensor
            // 
            this.buttonADDSensor.Location = new System.Drawing.Point(186, 37);
            this.buttonADDSensor.Name = "buttonADDSensor";
            this.buttonADDSensor.Size = new System.Drawing.Size(82, 31);
            this.buttonADDSensor.TabIndex = 46;
            this.buttonADDSensor.Text = "측정값추가";
            this.buttonADDSensor.UseVisualStyleBackColor = true;
            this.buttonADDSensor.Click += new System.EventHandler(this.buttonADDSensor_Click);
            // 
            // buttonLoadCSV
            // 
            this.buttonLoadCSV.Location = new System.Drawing.Point(14, 37);
            this.buttonLoadCSV.Name = "buttonLoadCSV";
            this.buttonLoadCSV.Size = new System.Drawing.Size(108, 31);
            this.buttonLoadCSV.TabIndex = 45;
            this.buttonLoadCSV.Text = "측정값 열기";
            this.buttonLoadCSV.UseVisualStyleBackColor = true;
            this.buttonLoadCSV.Click += new System.EventHandler(this.buttonLoadCSV_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelTitle.Controls.Add(this.label3);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(874, 45);
            this.panelTitle.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(874, 45);
            this.label3.TabIndex = 19;
            this.label3.Text = "철탑 기초 제원 예측 프로그램";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxKeyInSourceY);
            this.groupBox6.Controls.Add(this.textBoxKeyInSourceX);
            this.groupBox6.Location = new System.Drawing.Point(342, 61);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(170, 85);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "소스정보";
            // 
            // textBoxKeyInSourceY
            // 
            this.textBoxKeyInSourceY.IsLabelAutoWidth = false;
            this.textBoxKeyInSourceY.KeyIn = Maru.Control.KeyDownType.NumberDot;
            this.textBoxKeyInSourceY.LabelTitle = "위치 y";
            this.textBoxKeyInSourceY.Location = new System.Drawing.Point(16, 50);
            this.textBoxKeyInSourceY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxKeyInSourceY.Name = "textBoxKeyInSourceY";
            this.textBoxKeyInSourceY.Size = new System.Drawing.Size(140, 22);
            this.textBoxKeyInSourceY.TabIndex = 85;
            this.textBoxKeyInSourceY.TextBoxOffsetLabel = 0;
            this.textBoxKeyInSourceY.TextboxWidth = 60;
            this.textBoxKeyInSourceY.TextTextBox = "0.5";
            this.textBoxKeyInSourceY.TitleLabelWidth = 80;
            this.textBoxKeyInSourceY.UnitText = "";
            // 
            // textBoxKeyInSourceX
            // 
            this.textBoxKeyInSourceX.IsLabelAutoWidth = false;
            this.textBoxKeyInSourceX.KeyIn = Maru.Control.KeyDownType.NumberDot;
            this.textBoxKeyInSourceX.LabelTitle = "위치 x";
            this.textBoxKeyInSourceX.Location = new System.Drawing.Point(16, 21);
            this.textBoxKeyInSourceX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxKeyInSourceX.Name = "textBoxKeyInSourceX";
            this.textBoxKeyInSourceX.Size = new System.Drawing.Size(140, 22);
            this.textBoxKeyInSourceX.TabIndex = 84;
            this.textBoxKeyInSourceX.TextBoxOffsetLabel = 0;
            this.textBoxKeyInSourceX.TextboxWidth = 60;
            this.textBoxKeyInSourceX.TextTextBox = "0.5";
            this.textBoxKeyInSourceX.TitleLabelWidth = 80;
            this.textBoxKeyInSourceX.UnitText = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxA);
            this.groupBox1.Controls.Add(this.textBoxKeyInResisty);
            this.groupBox1.Location = new System.Drawing.Point(342, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 74);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "현장정보";
            // 
            // textBoxA
            // 
            this.textBoxA.IsLabelAutoWidth = false;
            this.textBoxA.KeyIn = Maru.Control.KeyDownType.NumberDot;
            this.textBoxA.LabelTitle = "a";
            this.textBoxA.Location = new System.Drawing.Point(16, 45);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(140, 22);
            this.textBoxA.TabIndex = 85;
            this.textBoxA.TextBoxOffsetLabel = 0;
            this.textBoxA.TextboxWidth = 60;
            this.textBoxA.TextTextBox = "0.0";
            this.textBoxA.TitleLabelWidth = 80;
            this.textBoxA.UnitText = "";
            // 
            // textBoxKeyInResisty
            // 
            this.textBoxKeyInResisty.IsLabelAutoWidth = false;
            this.textBoxKeyInResisty.KeyIn = Maru.Control.KeyDownType.NumberDot;
            this.textBoxKeyInResisty.LabelTitle = "저항(R)";
            this.textBoxKeyInResisty.Location = new System.Drawing.Point(16, 21);
            this.textBoxKeyInResisty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxKeyInResisty.Name = "textBoxKeyInResisty";
            this.textBoxKeyInResisty.Size = new System.Drawing.Size(140, 22);
            this.textBoxKeyInResisty.TabIndex = 84;
            this.textBoxKeyInResisty.TextBoxOffsetLabel = 0;
            this.textBoxKeyInResisty.TextboxWidth = 60;
            this.textBoxKeyInResisty.TextTextBox = "0.5";
            this.textBoxKeyInResisty.TitleLabelWidth = 80;
            this.textBoxKeyInResisty.UnitText = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.canvasTtype);
            this.groupBox3.Controls.Add(this.canvasRod);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxErrorRod);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(518, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(348, 582);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "해석 결과";
            // 
            // canvasTtype
            // 
            this.canvasTtype.Action = MaruGDI.ActionMode.Pan;
            this.canvasTtype.BackColor = System.Drawing.Color.White;
            this.canvasTtype.Location = new System.Drawing.Point(18, 376);
            this.canvasTtype.Name = "canvasTtype";
            this.canvasTtype.Size = new System.Drawing.Size(312, 150);
            this.canvasTtype.TabIndex = 49;
            // 
            // canvasRod
            // 
            this.canvasRod.Action = MaruGDI.ActionMode.Pan;
            this.canvasRod.BackColor = System.Drawing.Color.White;
            this.canvasRod.Location = new System.Drawing.Point(18, 89);
            this.canvasRod.Name = "canvasRod";
            this.canvasRod.Size = new System.Drawing.Size(312, 150);
            this.canvasRod.TabIndex = 48;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox2.Location = new System.Drawing.Point(252, 540);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 21);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "0.05";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 545);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "오차율, 정확도, 신뢰도";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.textBoxThickT);
            this.panel2.Controls.Add(this.textBoxLengthT);
            this.panel2.Controls.Add(this.textBoxDepthT);
            this.panel2.Location = new System.Drawing.Point(18, 309);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 56);
            this.panel2.TabIndex = 6;
            // 
            // textBoxThickT
            // 
            this.textBoxThickT.IsLabelAutoWidth = false;
            this.textBoxThickT.KeyIn = Maru.Control.KeyDownType.NumberDot;
            this.textBoxThickT.LabelTitle = "저판두께(t)";
            this.textBoxThickT.Location = new System.Drawing.Point(161, 30);
            this.textBoxThickT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxThickT.Name = "textBoxThickT";
            this.textBoxThickT.Size = new System.Drawing.Size(148, 22);
            this.textBoxThickT.TabIndex = 87;
            this.textBoxThickT.TextBoxOffsetLabel = 0;
            this.textBoxThickT.TextboxWidth = 50;
            this.textBoxThickT.TextTextBox = "0.5";
            this.textBoxThickT.TitleLabelWidth = 80;
            this.textBoxThickT.UnitText = "m";
            // 
            // textBoxLengthT
            // 
            this.textBoxLengthT.IsLabelAutoWidth = false;
            this.textBoxLengthT.KeyIn = Maru.Control.KeyDownType.NumberDot;
            this.textBoxLengthT.LabelTitle = "저판길이(B)";
            this.textBoxLengthT.Location = new System.Drawing.Point(161, 6);
            this.textBoxLengthT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLengthT.Name = "textBoxLengthT";
            this.textBoxLengthT.Size = new System.Drawing.Size(148, 22);
            this.textBoxLengthT.TabIndex = 86;
            this.textBoxLengthT.TextBoxOffsetLabel = 0;
            this.textBoxLengthT.TextboxWidth = 50;
            this.textBoxLengthT.TextTextBox = "0.5";
            this.textBoxLengthT.TitleLabelWidth = 80;
            this.textBoxLengthT.UnitText = "m";
            // 
            // textBoxDepthT
            // 
            this.textBoxDepthT.IsLabelAutoWidth = false;
            this.textBoxDepthT.KeyIn = Maru.Control.KeyDownType.NumberDot;
            this.textBoxDepthT.LabelTitle = "깊이(L)";
            this.textBoxDepthT.Location = new System.Drawing.Point(11, 6);
            this.textBoxDepthT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDepthT.Name = "textBoxDepthT";
            this.textBoxDepthT.Size = new System.Drawing.Size(128, 22);
            this.textBoxDepthT.TabIndex = 85;
            this.textBoxDepthT.TextBoxOffsetLabel = 0;
            this.textBoxDepthT.TextboxWidth = 50;
            this.textBoxDepthT.TextTextBox = "0.5";
            this.textBoxDepthT.TitleLabelWidth = 60;
            this.textBoxDepthT.UnitText = "m";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "역T형 기초";
            // 
            // textBoxErrorRod
            // 
            this.textBoxErrorRod.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxErrorRod.Location = new System.Drawing.Point(252, 251);
            this.textBoxErrorRod.Name = "textBoxErrorRod";
            this.textBoxErrorRod.Size = new System.Drawing.Size(78, 21);
            this.textBoxErrorRod.TabIndex = 4;
            this.textBoxErrorRod.Text = "0.05";
            this.textBoxErrorRod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "오차율, 정확도, 신뢰도";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.textBoxThickRod);
            this.panel1.Controls.Add(this.textBoxDepthRod);
            this.panel1.Location = new System.Drawing.Point(18, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 35);
            this.panel1.TabIndex = 1;
            // 
            // textBoxThickRod
            // 
            this.textBoxThickRod.IsLabelAutoWidth = false;
            this.textBoxThickRod.KeyIn = Maru.Control.KeyDownType.NumberDot;
            this.textBoxThickRod.LabelTitle = "두께(t)";
            this.textBoxThickRod.Location = new System.Drawing.Point(175, 6);
            this.textBoxThickRod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxThickRod.Name = "textBoxThickRod";
            this.textBoxThickRod.Size = new System.Drawing.Size(128, 22);
            this.textBoxThickRod.TabIndex = 86;
            this.textBoxThickRod.TextBoxOffsetLabel = 0;
            this.textBoxThickRod.TextboxWidth = 50;
            this.textBoxThickRod.TextTextBox = "0.5";
            this.textBoxThickRod.TitleLabelWidth = 60;
            this.textBoxThickRod.UnitText = "m";
            this.textBoxThickRod.Visible = false;
            // 
            // textBoxDepthRod
            // 
            this.textBoxDepthRod.IsLabelAutoWidth = false;
            this.textBoxDepthRod.KeyIn = Maru.Control.KeyDownType.NumberDot;
            this.textBoxDepthRod.LabelTitle = "깊이(D)";
            this.textBoxDepthRod.Location = new System.Drawing.Point(11, 6);
            this.textBoxDepthRod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDepthRod.Name = "textBoxDepthRod";
            this.textBoxDepthRod.Size = new System.Drawing.Size(128, 22);
            this.textBoxDepthRod.TabIndex = 85;
            this.textBoxDepthRod.TextBoxOffsetLabel = 0;
            this.textBoxDepthRod.TextboxWidth = 50;
            this.textBoxDepthRod.TextTextBox = "0.5";
            this.textBoxDepthRod.TitleLabelWidth = 60;
            this.textBoxDepthRod.UnitText = "m";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "심형 기초";
            // 
            // pictureBoxRod
            // 
            this.pictureBoxRod.BackColor = System.Drawing.Color.White;
            this.pictureBoxRod.Image = global::PowerTower.Properties.Resources.result1;
            this.pictureBoxRod.Location = new System.Drawing.Point(917, 162);
            this.pictureBoxRod.Name = "pictureBoxRod";
            this.pictureBoxRod.Size = new System.Drawing.Size(312, 116);
            this.pictureBoxRod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRod.TabIndex = 50;
            this.pictureBoxRod.TabStop = false;
            this.pictureBoxRod.Visible = false;
            // 
            // pictureBoxT
            // 
            this.pictureBoxT.BackColor = System.Drawing.Color.White;
            this.pictureBoxT.Image = global::PowerTower.Properties.Resources.result2;
            this.pictureBoxT.Location = new System.Drawing.Point(917, 437);
            this.pictureBoxT.Name = "pictureBoxT";
            this.pictureBoxT.Size = new System.Drawing.Size(312, 116);
            this.pictureBoxT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxT.TabIndex = 51;
            this.pictureBoxT.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "csv";
            this.saveFileDialog.Filter = "CSV files|*.csv";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(917, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkBoxTypeT);
            this.groupBox7.Controls.Add(this.checkBoxRod);
            this.groupBox7.Location = new System.Drawing.Point(12, 543);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(324, 100);
            this.groupBox7.TabIndex = 35;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "해석 옵션";
            // 
            // checkBoxTypeT
            // 
            this.checkBoxTypeT.AutoSize = true;
            this.checkBoxTypeT.Location = new System.Drawing.Point(14, 67);
            this.checkBoxTypeT.Name = "checkBoxTypeT";
            this.checkBoxTypeT.Size = new System.Drawing.Size(112, 16);
            this.checkBoxTypeT.TabIndex = 30;
            this.checkBoxTypeT.Text = "역T형 기초 해석";
            this.checkBoxTypeT.UseVisualStyleBackColor = true;
            this.checkBoxTypeT.CheckedChanged += new System.EventHandler(this.checkBoxTypeT_CheckedChanged);
            // 
            // checkBoxRod
            // 
            this.checkBoxRod.AutoSize = true;
            this.checkBoxRod.Location = new System.Drawing.Point(14, 30);
            this.checkBoxRod.Name = "checkBoxRod";
            this.checkBoxRod.Size = new System.Drawing.Size(104, 16);
            this.checkBoxRod.TabIndex = 29;
            this.checkBoxRod.Text = "심형 기초 해석";
            this.checkBoxRod.UseVisualStyleBackColor = true;
            // 
            // buttonSaveResult
            // 
            this.buttonSaveResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSaveResult.Image = global::PowerTower.Properties.Resources._1;
            this.buttonSaveResult.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSaveResult.Location = new System.Drawing.Point(433, 311);
            this.buttonSaveResult.Name = "buttonSaveResult";
            this.buttonSaveResult.Size = new System.Drawing.Size(79, 54);
            this.buttonSaveResult.TabIndex = 34;
            this.buttonSaveResult.Text = "결과저장";
            this.buttonSaveResult.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSaveResult.UseVisualStyleBackColor = true;
            this.buttonSaveResult.Click += new System.EventHandler(this.buttonSaveResult_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonExit.Image = global::PowerTower.Properties.Resources.Exit_game_32;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExit.Location = new System.Drawing.Point(342, 374);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(170, 54);
            this.buttonExit.TabIndex = 26;
            this.buttonExit.Text = "나가기";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRun.Image = global::PowerTower.Properties.Resources._3_32;
            this.buttonRun.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRun.Location = new System.Drawing.Point(342, 311);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(85, 54);
            this.buttonRun.TabIndex = 25;
            this.buttonRun.Text = "해석시작";
            this.buttonRun.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(929, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 655);
            this.Controls.Add(this.pictureBoxT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.buttonSaveResult);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.pictureBoxRod);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxT)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonADDSensor;
        private System.Windows.Forms.Button buttonLoadCSV;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox6;
        private Maru.Control.TextBoxwLabelUnit textBoxKeyInSourceY;
        private Maru.Control.TextBoxwLabelUnit textBoxKeyInSourceX;
        private System.Windows.Forms.GroupBox groupBox1;
        private Maru.Control.TextBoxwLabelUnit textBoxKeyInResisty;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private Maru.Control.TextBoxwLabelUnit textBoxThickT;
        private Maru.Control.TextBoxwLabelUnit textBoxLengthT;
        private Maru.Control.TextBoxwLabelUnit textBoxDepthT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxErrorRod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Maru.Control.TextBoxwLabelUnit textBoxThickRod;
        private Maru.Control.TextBoxwLabelUnit textBoxDepthRod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonDELSensor;
        private System.Windows.Forms.Button buttonSaveResult;
        private Maru.Control.TextBoxwLabelUnit textBoxA;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox checkBoxTypeT;
        private System.Windows.Forms.CheckBox checkBoxRod;
        private MaruGDI.Canvas canvasTtype;
        private MaruGDI.Canvas canvasRod;
        private System.Windows.Forms.PictureBox pictureBoxRod;
        private System.Windows.Forms.PictureBox pictureBoxT;
        private System.Windows.Forms.Button button1;
    }
}

