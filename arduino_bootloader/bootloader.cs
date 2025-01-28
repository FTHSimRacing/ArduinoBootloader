/* 
 * FTH Sim Racing
 * 
 * https://linktr.ee/fthsimracing
 *  
 * DSE Diy Sim Equipment
 * 
 * https://linktr.ee/dseracing
 * 
 * KAMY Engineering
 * 
 * https://linktr.ee/kamyengineering
 * 
 * Christophe Diericx
 * 
 * https://github.com/twinearthsoftware/ArduinoSketchUploader
*/

using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

using System.Diagnostics;
using System.IO;
using System.IO.Ports;

using ArduinoUploader;

namespace arduino_bootloader
{
    public partial class bootloader : Form
    {
        public string[] AvailablePorts = SerialPort.GetPortNames();

        OpenFileDialog file = new OpenFileDialog();

        string safeFileName = "";
        string fileName = "";

        string comPort, device;

        int baslikTikX, baslikTikY;

        string[] deviceName = { "Leonardo", "Mega1284", "Mega2560", "Micro", "NanoR2", "NanoR3", "UnoR3" };

        string deviceName2;
        string deviceNameP;
        string deviceNameC;
        string deviceNameB;

        int logoSize = 4;

        public bootloader()
        {
            InitializeComponent();
            CheckPorts();

            CheckForIllegalCrossThreadCalls = false;
        }

        private void bootloader_Load(object sender, EventArgs e)
        {
            comboBox_device.DataSource = deviceName;
            comboBox_device.SelectedIndex = 0;
        }

        private void CheckPorts()
        {
            string[] portNames = SerialPort.GetPortNames();
            comboBox_comPort.DataSource = portNames;
        }

        // BAŞLIK

        private void lbl_baslik_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - baslikTikX;
                this.Top += e.Y - baslikTikY;
            }
        }

        private void lbl_baslik_MouseDown(object sender, MouseEventArgs e)
        {
            baslikTikX = e.X;
            baslikTikY = e.Y;
        }

        // PROGRAM LOGO

        private void lbl_logo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/43_ybA2u3lM");
        }

        // KAPAT

        private void lbl_kapat_MouseLeave(object sender, EventArgs e)
        {
            lbl_kapat.ForeColor = System.Drawing.Color.LightGray;
        }

        private void lbl_kapat_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_kapat.ForeColor = System.Drawing.Color.LightSeaGreen;
        }

        private void lbl_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // HEX FILE

        private void lbl_hex_file_MouseLeave(object sender, EventArgs e)
        {
            lbl_hex_file.BackColor = System.Drawing.Color.White;
        }

        private void lbl_hex_file_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_hex_file.BackColor = System.Drawing.Color.WhiteSmoke;
        }

        private void lbl_hex_file_Click(object sender, EventArgs e)
        {

            file.Filter = "Hex files |*.hex";

            file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (file.ShowDialog() == DialogResult.OK)
            {
                safeFileName = file.SafeFileName;
                fileName = file.FileName;

                lbl_hexFile.Text = safeFileName;
            }
        }

        // COM PORT

        private void comboBox_comPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            comPort = comboBox_comPort.SelectedValue.ToString();
        }

        // DEVICE

        private void comboBox_device_SelectedIndexChanged(object sender, EventArgs e)
        {
            device = comboBox_device.SelectedValue.ToString();
        }

        // DEVICE MANAGER

        private void lbl_device_manager_MouseLeave(object sender, EventArgs e)
        {
            lbl_device_manager.BackColor = System.Drawing.Color.White;
        }

        private void lbl_device_manager_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_device_manager.BackColor = System.Drawing.Color.WhiteSmoke;
        }

        private void lbl_device_manager_Click(object sender, EventArgs e)
        {
            ProcessStartInfo procStartInfo = new ProcessStartInfo("devmgmt.msc");
            Process proc = new Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
        }

        // UPLOAD

        private void lbl_upload_MouseLeave(object sender, EventArgs e)
        {
            lbl_upload.BackColor = System.Drawing.Color.White;
        }

        private void lbl_upload_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_upload.BackColor = System.Drawing.Color.WhiteSmoke;
        }

        private void upload()
        {
            Process update = new Process();
            update.StartInfo.UseShellExecute = false;
            update.StartInfo.RedirectStandardError = false;
            update.StartInfo.FileName = "upload/ArduinoSketchUploader.exe";
            update.StartInfo.Arguments = string.Concat(new string[]
            {
                " --file=",
                fileName,
                " --port=",
                comPort,
                " --model=",
                device
            });
            update.StartInfo.CreateNoWindow = false;
            update.StartInfo.RedirectStandardOutput = false;
            update.Start();
            //update.BeginErrorReadLine();
            update.WaitForExit();
        }

        private void lbl_upload_Click(object sender, EventArgs e)
        {
            if (safeFileName.Contains(".hex") != true)
            {
                lbl_hexFile.Text = "HEX file not found.";

                try
                {
                    backgroundWorker1.RunWorkerAsync();
                }
                catch (Exception)
                {

                }
            }
            else
            {
                upload();
            }

            //MessageBox.Show(fileName + " " + comPort + " " + device); 
        }

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Thread.Sleep(1500);
            lbl_hexFile.Text = "...";
        }

        // RST UPLOAD

        private void lbl_rst_upload_MouseLeave(object sender, EventArgs e)
        {
            lbl_rst_upload.BackColor = System.Drawing.Color.White;
        }

        private void lbl_rst_upload_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_rst_upload.BackColor = System.Drawing.Color.WhiteSmoke;
        }

        private void rst_upload()
        {           
            Process update = new Process();
            update.StartInfo.UseShellExecute = false;
            update.StartInfo.RedirectStandardError = false;
            update.StartInfo.FileName = "rst_upload/avrdude.exe";
            update.StartInfo.Arguments = string.Concat(new string[]
		    {
			    "-p ",
			    deviceNameP,
			    " -c ",
			    deviceNameC,
			    " -P \\\\.\\",
			    comPort,
			    " -b ",
			    deviceNameB,
			    " -U flash:w:\"",
			    fileName,
			    "\":i"
		    });
            update.StartInfo.CreateNoWindow = false;
            update.StartInfo.RedirectStandardOutput = false;
            update.Start();
            //update.BeginErrorReadLine();
            update.WaitForExit();
        }

        private void lbl_rst_upload_Click(object sender, EventArgs e)
        {
            if (device == "Leonardo" || device == "Micro")
            {
                deviceName2 = "Leonardo(32U4)";
                deviceNameP = "atmega32U4";
                deviceNameC = "avr109";
                deviceNameB = "57600";
            }
            else if (device == "Mega1284")
            {
                deviceName2 = "Mega(ATMEGA1280)";
                deviceNameP = "m1280";
                deviceNameC = "stk500";
                deviceNameB = "57600";
            }
            else if (device == "Mega2560")
            {
                deviceName2 = "Mega(ATMEGA2560)";
                deviceNameP = "atmega2560";
                deviceNameC = "stk500v2";
                deviceNameB = "115200";
            }
            else if (device == "NanoR2")
            {
                deviceName2 = "Duemilanove/Nano(ATmega168)";
                deviceNameP = "m168";
                deviceNameC = "stk500";
                deviceNameB = "19200";
            }
            else if (device == "NanoR3")
            {
                deviceName2 = "Duemilanove/Nano(ATmega328)";
                deviceNameP = "m328p";
                deviceNameC = "stk500";
                deviceNameB = "57600";
            }
            else if (device == "UnoR3")
            {
                deviceName2 = "Uno(ATmega328)";
                deviceNameP = "m328p";
                deviceNameC = "stk500";
                deviceNameB = "115200";
            }

            if (safeFileName.Contains(".hex") != true)
            {
                lbl_hexFile.Text = "HEX file not found.";

                try
                {
                    backgroundWorker2.RunWorkerAsync();
                }
                catch (Exception)
                {

                }
            }
            else
            {
                rst_upload();
            }

            //MessageBox.Show(deviceNameP + " " + deviceNameC + " " + comPort + " " + deviceNameB + " " + fileName);
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Thread.Sleep(1500);
            lbl_hexFile.Text = "...";
        }

        // YENİLE

        private void lbl_com_yenile_MouseLeave(object sender, EventArgs e)
        {
            lbl_com_yenile.BackColor = System.Drawing.Color.White;
        }

        private void lbl_com_yenile_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_com_yenile.BackColor = System.Drawing.Color.WhiteSmoke;
        }

        private void lbl_com_yenile_Click(object sender, EventArgs e)
        {
            CheckPorts();
        }

        // FTH LOGO

        private void pictureBox_fth_logo_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_fth_logo.Size = new Size(60, 60);
            pictureBox_fth_logo.Location = new Point(15, 265);
        }

        private void pictureBox_fth_logo_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox_fth_logo.Size = new Size(60 + logoSize, 60 + logoSize);
            pictureBox_fth_logo.Location = new Point(15 - (logoSize / 2), 265 - (logoSize / 2));
        }

        private void pictureBox_fth_logo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://linktr.ee/fthsimracing");
        }

        // DSE LOGO

        private void pictureBox_dse_logo_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_dse_logo.Size = new Size(60, 60);
            pictureBox_dse_logo.Location = new Point(90, 265);
        }

        private void pictureBox_dse_logo_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox_dse_logo.Size = new Size(60 + logoSize, 60 + logoSize);
            pictureBox_dse_logo.Location = new Point(90 - (logoSize / 2), 265 - (logoSize / 2));
        }

        private void pictureBox_dse_logo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://linktr.ee/dseracing");
        }

        // KAMY LOGO

        private void pictureBox_kamy_logo_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_kamy_logo.Size = new Size(60, 60);
            pictureBox_kamy_logo.Location = new Point(165, 265);
        }

        private void pictureBox_kamy_logo_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox_kamy_logo.Size = new Size(60 + logoSize, 60 + logoSize);
            pictureBox_kamy_logo.Location = new Point(165 - (logoSize / 2), 265 - (logoSize / 2));
        }

        private void pictureBox_kamy_logo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://linktr.ee/kamyengineering");
        }
    }
}

/* 
 * FTH Sim Racing
 * 
 * https://linktr.ee/fthsimracing
 *  
 * DSE Diy Sim Equipment
 * 
 * https://linktr.ee/dseracing
 * 
 * KAMY Engineering
 * 
 * https://linktr.ee/kamyengineering
 * 
 * Christophe Diericx
 * 
 * https://github.com/twinearthsoftware/ArduinoSketchUploader
*/
