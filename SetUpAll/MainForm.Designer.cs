namespace SetUpAll
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
            this.buttonTower = new System.Windows.Forms.Button();
            this.buttonLibrary = new System.Windows.Forms.Button();
            this.buttonPython = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTower
            // 
            this.buttonTower.Location = new System.Drawing.Point(24, 149);
            this.buttonTower.Name = "buttonTower";
            this.buttonTower.Size = new System.Drawing.Size(137, 53);
            this.buttonTower.TabIndex = 7;
            this.buttonTower.Text = "철탑기초해석 설치";
            this.buttonTower.UseVisualStyleBackColor = true;
            this.buttonTower.Click += new System.EventHandler(this.buttonTower_Click);
            // 
            // buttonLibrary
            // 
            this.buttonLibrary.Location = new System.Drawing.Point(24, 81);
            this.buttonLibrary.Name = "buttonLibrary";
            this.buttonLibrary.Size = new System.Drawing.Size(137, 53);
            this.buttonLibrary.TabIndex = 6;
            this.buttonLibrary.Text = "라이브러리 업데이트";
            this.buttonLibrary.UseVisualStyleBackColor = true;
            this.buttonLibrary.Click += new System.EventHandler(this.buttonLibrary_Click);
            // 
            // buttonPython
            // 
            this.buttonPython.Location = new System.Drawing.Point(24, 12);
            this.buttonPython.Name = "buttonPython";
            this.buttonPython.Size = new System.Drawing.Size(137, 53);
            this.buttonPython.TabIndex = 5;
            this.buttonPython.Text = "Python 설치";
            this.buttonPython.UseVisualStyleBackColor = true;
            this.buttonPython.Click += new System.EventHandler(this.buttonPython_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 223);
            this.Controls.Add(this.buttonTower);
            this.Controls.Add(this.buttonLibrary);
            this.Controls.Add(this.buttonPython);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTower;
        private System.Windows.Forms.Button buttonLibrary;
        private System.Windows.Forms.Button buttonPython;
    }
}

