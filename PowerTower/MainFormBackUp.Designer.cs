namespace PowerTower
{
    partial class MainFormBackUp
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
            this.textBoxKeyInResisty = new Maru.Control.TextBoxwLabelUnit();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButtonTypeRod2 = new System.Windows.Forms.RadioButton();
            this.radioButtonTypeRod1 = new System.Windows.Forms.RadioButton();
            this.checkBoxtypeT1 = new System.Windows.Forms.CheckBox();
            this.checkBoxTypeRod1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxT = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxThickT = new Maru.Control.TextBoxwLabelUnit();
            this.textBoxLengthT = new Maru.Control.TextBoxwLabelUnit();
            this.textBoxDepthT = new Maru.Control.TextBoxwLabelUnit();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxErrorRod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxRod = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxThickRod = new Maru.Control.TextBoxwLabelUnit();
            this.textBoxDepthRod = new Maru.Control.TextBoxwLabelUnit();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBoxTypeRod2 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonTypeT2 = new System.Windows.Forms.RadioButton();
            this.radioButtonTypeT1 = new System.Windows.Forms.RadioButton();
            this.checkBoxtypeT2 = new System.Windows.Forms.CheckBox();
            this.buttonSaveResult = new System.Windows.Forms.Button();
            this.textBoxA = new Maru.Control.TextBoxwLabelUnit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxT)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRod)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox4.Size = new System.Drawing.Size(324, 300);
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
            this.dataGridView.Location = new System.Drawing.Point(8, 75);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(310, 213);
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
            this.panelTitle.Size = new System.Drawing.Size(877, 45);
            this.panelTitle.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(877, 45);
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
            this.groupBox1.Location = new System.Drawing.Point(342, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 74);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "현장정보";
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButtonTypeRod2);
            this.groupBox5.Controls.Add(this.radioButtonTypeRod1);
            this.groupBox5.Location = new System.Drawing.Point(12, 408);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(274, 46);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "심형 기초 해석";
            // 
            // radioButtonTypeRod2
            // 
            this.radioButtonTypeRod2.AutoSize = true;
            this.radioButtonTypeRod2.Location = new System.Drawing.Point(134, 20);
            this.radioButtonTypeRod2.Name = "radioButtonTypeRod2";
            this.radioButtonTypeRod2.Size = new System.Drawing.Size(81, 16);
            this.radioButtonTypeRod2.TabIndex = 36;
            this.radioButtonTypeRod2.Text = "해석방법 2";
            this.radioButtonTypeRod2.UseVisualStyleBackColor = true;
            // 
            // radioButtonTypeRod1
            // 
            this.radioButtonTypeRod1.AutoSize = true;
            this.radioButtonTypeRod1.Checked = true;
            this.radioButtonTypeRod1.Location = new System.Drawing.Point(17, 20);
            this.radioButtonTypeRod1.Name = "radioButtonTypeRod1";
            this.radioButtonTypeRod1.Size = new System.Drawing.Size(81, 16);
            this.radioButtonTypeRod1.TabIndex = 35;
            this.radioButtonTypeRod1.TabStop = true;
            this.radioButtonTypeRod1.Text = "해석방법 1";
            this.radioButtonTypeRod1.UseVisualStyleBackColor = true;
            // 
            // checkBoxtypeT1
            // 
            this.checkBoxtypeT1.AutoSize = true;
            this.checkBoxtypeT1.Location = new System.Drawing.Point(251, 532);
            this.checkBoxtypeT1.Name = "checkBoxtypeT1";
            this.checkBoxtypeT1.Size = new System.Drawing.Size(116, 16);
            this.checkBoxtypeT1.TabIndex = 29;
            this.checkBoxtypeT1.Text = "해석방법1 (선택)";
            this.checkBoxtypeT1.UseVisualStyleBackColor = true;
            this.checkBoxtypeT1.Visible = false;
            // 
            // checkBoxTypeRod1
            // 
            this.checkBoxTypeRod1.AutoSize = true;
            this.checkBoxTypeRod1.Location = new System.Drawing.Point(132, 380);
            this.checkBoxTypeRod1.Name = "checkBoxTypeRod1";
            this.checkBoxTypeRod1.Size = new System.Drawing.Size(120, 16);
            this.checkBoxTypeRod1.TabIndex = 28;
            this.checkBoxTypeRod1.Text = "해석방법 1 (선택)";
            this.checkBoxTypeRod1.UseVisualStyleBackColor = true;
            this.checkBoxTypeRod1.Visible = false;
            this.checkBoxTypeRod1.CheckedChanged += new System.EventHandler(this.checkBoxTypeRod_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.pictureBoxT);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxErrorRod);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.pictureBoxRod);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(518, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(348, 491);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "해석 결과";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox2.Location = new System.Drawing.Point(252, 454);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 21);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "0.05";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "오차율, 정확도, 신뢰도";
            // 
            // pictureBoxT
            // 
            this.pictureBoxT.BackColor = System.Drawing.Color.White;
            this.pictureBoxT.Image = global::PowerTower.Properties.Resources.result2;
            this.pictureBoxT.Location = new System.Drawing.Point(18, 332);
            this.pictureBoxT.Name = "pictureBoxT";
            this.pictureBoxT.Size = new System.Drawing.Size(312, 116);
            this.pictureBoxT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxT.TabIndex = 7;
            this.pictureBoxT.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.textBoxThickT);
            this.panel2.Controls.Add(this.textBoxLengthT);
            this.panel2.Controls.Add(this.textBoxDepthT);
            this.panel2.Location = new System.Drawing.Point(18, 262);
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
            this.label5.Location = new System.Drawing.Point(16, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "역T형 기초";
            // 
            // textBoxErrorRod
            // 
            this.textBoxErrorRod.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxErrorRod.Location = new System.Drawing.Point(252, 215);
            this.textBoxErrorRod.Name = "textBoxErrorRod";
            this.textBoxErrorRod.Size = new System.Drawing.Size(78, 21);
            this.textBoxErrorRod.TabIndex = 4;
            this.textBoxErrorRod.Text = "0.05";
            this.textBoxErrorRod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "오차율, 정확도, 신뢰도";
            // 
            // pictureBoxRod
            // 
            this.pictureBoxRod.BackColor = System.Drawing.Color.White;
            this.pictureBoxRod.Image = global::PowerTower.Properties.Resources.result1;
            this.pictureBoxRod.Location = new System.Drawing.Point(18, 93);
            this.pictureBoxRod.Name = "pictureBoxRod";
            this.pictureBoxRod.Size = new System.Drawing.Size(312, 116);
            this.pictureBoxRod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRod.TabIndex = 2;
            this.pictureBoxRod.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.textBoxThickRod);
            this.panel1.Controls.Add(this.textBoxDepthRod);
            this.panel1.Location = new System.Drawing.Point(18, 50);
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
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "심형 기초";
            // 
            // buttonExit
            // 
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonExit.Image = global::PowerTower.Properties.Resources.Exit_game_32;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExit.Location = new System.Drawing.Point(342, 295);
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
            this.buttonRun.Location = new System.Drawing.Point(342, 232);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(85, 54);
            this.buttonRun.TabIndex = 25;
            this.buttonRun.Text = "해석시작";
            this.buttonRun.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
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
            this.button3.Location = new System.Drawing.Point(337, 486);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBoxTypeRod2
            // 
            this.checkBoxTypeRod2.AutoSize = true;
            this.checkBoxTypeRod2.Location = new System.Drawing.Point(337, 438);
            this.checkBoxTypeRod2.Name = "checkBoxTypeRod2";
            this.checkBoxTypeRod2.Size = new System.Drawing.Size(120, 16);
            this.checkBoxTypeRod2.TabIndex = 29;
            this.checkBoxTypeRod2.Text = "해석방법 2 (선택)";
            this.checkBoxTypeRod2.UseVisualStyleBackColor = true;
            this.checkBoxTypeRod2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 32;
            this.label6.Text = "해석옵션";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonTypeT2);
            this.groupBox2.Controls.Add(this.radioButtonTypeT1);
            this.groupBox2.Location = new System.Drawing.Point(12, 473);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 46);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "역T형 기초해석";
            // 
            // radioButtonTypeT2
            // 
            this.radioButtonTypeT2.AutoSize = true;
            this.radioButtonTypeT2.Location = new System.Drawing.Point(134, 20);
            this.radioButtonTypeT2.Name = "radioButtonTypeT2";
            this.radioButtonTypeT2.Size = new System.Drawing.Size(81, 16);
            this.radioButtonTypeT2.TabIndex = 38;
            this.radioButtonTypeT2.Text = "해석방법 2";
            this.radioButtonTypeT2.UseVisualStyleBackColor = true;
            this.radioButtonTypeT2.CheckedChanged += new System.EventHandler(this.radioButtonTypeT1_CheckedChanged);
            // 
            // radioButtonTypeT1
            // 
            this.radioButtonTypeT1.AutoSize = true;
            this.radioButtonTypeT1.Checked = true;
            this.radioButtonTypeT1.Location = new System.Drawing.Point(17, 20);
            this.radioButtonTypeT1.Name = "radioButtonTypeT1";
            this.radioButtonTypeT1.Size = new System.Drawing.Size(81, 16);
            this.radioButtonTypeT1.TabIndex = 37;
            this.radioButtonTypeT1.TabStop = true;
            this.radioButtonTypeT1.Text = "해석방법 1";
            this.radioButtonTypeT1.UseVisualStyleBackColor = true;
            this.radioButtonTypeT1.CheckedChanged += new System.EventHandler(this.radioButtonTypeT1_CheckedChanged);
            // 
            // checkBoxtypeT2
            // 
            this.checkBoxtypeT2.AutoSize = true;
            this.checkBoxtypeT2.Location = new System.Drawing.Point(377, 532);
            this.checkBoxtypeT2.Name = "checkBoxtypeT2";
            this.checkBoxtypeT2.Size = new System.Drawing.Size(116, 16);
            this.checkBoxtypeT2.TabIndex = 30;
            this.checkBoxtypeT2.Text = "해석방법2 (선택)";
            this.checkBoxtypeT2.UseVisualStyleBackColor = true;
            this.checkBoxtypeT2.Visible = false;
            // 
            // buttonSaveResult
            // 
            this.buttonSaveResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSaveResult.Image = global::PowerTower.Properties.Resources._1;
            this.buttonSaveResult.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSaveResult.Location = new System.Drawing.Point(433, 232);
            this.buttonSaveResult.Name = "buttonSaveResult";
            this.buttonSaveResult.Size = new System.Drawing.Size(79, 54);
            this.buttonSaveResult.TabIndex = 34;
            this.buttonSaveResult.Text = "결과저장";
            this.buttonSaveResult.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSaveResult.UseVisualStyleBackColor = true;
            this.buttonSaveResult.Click += new System.EventHandler(this.buttonSaveResult_Click);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 560);
            this.Controls.Add(this.checkBoxtypeT2);
            this.Controls.Add(this.checkBoxtypeT1);
            this.Controls.Add(this.checkBoxTypeRod2);
            this.Controls.Add(this.buttonSaveResult);
            this.Controls.Add(this.checkBoxTypeRod1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox6);
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
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxT)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRod)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.CheckBox checkBoxtypeT1;
        private System.Windows.Forms.CheckBox checkBoxTypeRod1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxT;
        private System.Windows.Forms.Panel panel2;
        private Maru.Control.TextBoxwLabelUnit textBoxThickT;
        private Maru.Control.TextBoxwLabelUnit textBoxLengthT;
        private Maru.Control.TextBoxwLabelUnit textBoxDepthT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxErrorRod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxRod;
        private System.Windows.Forms.Panel panel1;
        private Maru.Control.TextBoxwLabelUnit textBoxThickRod;
        private Maru.Control.TextBoxwLabelUnit textBoxDepthRod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonDELSensor;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBoxTypeRod2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxtypeT2;
        private System.Windows.Forms.Button buttonSaveResult;
        private System.Windows.Forms.RadioButton radioButtonTypeRod2;
        private System.Windows.Forms.RadioButton radioButtonTypeRod1;
        private System.Windows.Forms.RadioButton radioButtonTypeT2;
        private System.Windows.Forms.RadioButton radioButtonTypeT1;
        private Maru.Control.TextBoxwLabelUnit textBoxA;
    }
}

