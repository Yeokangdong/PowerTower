using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Maru.Control;

namespace SetUpAll
{
    public partial class MainForm : Form

    {
        public MainForm()
        {
            InitializeComponent();
        }   

        private void buttonPython_Click(object sender, EventArgs e)
        {

            FileInfo fiData = new FileInfo(Application.StartupPath + @"\\python-3.6.5.exe");

            if (fiData.Exists)
            {
                System.Diagnostics.Process.Start(fiData.FullName);
            }
        }

        private void buttonLibrary_Click(object sender, EventArgs e)
        {

            try
            {
                string targetPath = @"C:\python\Lib";
                if (new DirectoryInfo(targetPath).Exists)
                {
                    DirectoryUtilities.Copy(Application.StartupPath + "\\library", targetPath, true);
                    MessageBox.Show("업데이트가 완료되었습니다.", "inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("파이썬이 정상적인 위치에 설치되지 않았습니다.", "inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("라이브러리 업데이트 도중\n\r오류가 발생했습니다.", "inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
              }

            return;
        }

        private void buttonTower_Click(object sender, EventArgs e)
        {
            try
            {
                string targetPath = @"C:\python";
                if (new DirectoryInfo(targetPath).Exists)
                {
                    DirectoryUtilities.Copy(Application.StartupPath + "\\python", targetPath, true);
                }
                else
                {
                    DirectoryInfo di = new DirectoryInfo(targetPath);
                    di.Create();
                    DirectoryUtilities.Copy(Application.StartupPath + "\\python", targetPath, true);
                }
            }
            catch (Exception ex)
            {
                
            }

            FileInfo fiData = new FileInfo(Application.StartupPath + @"\\setup.exe");

            if (fiData.Exists)
            {
                System.Diagnostics.Process.Start(fiData.FullName);
            }
        }
    }

}
