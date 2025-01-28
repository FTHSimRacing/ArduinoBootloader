namespace arduino_bootloader
{
    partial class bootloader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bootloader));
            this.lbl_device = new System.Windows.Forms.Label();
            this.lbl_comPort = new System.Windows.Forms.Label();
            this.comboBox_device = new System.Windows.Forms.ComboBox();
            this.comboBox_comPort = new System.Windows.Forms.ComboBox();
            this.lbl_hexFile = new System.Windows.Forms.Label();
            this.lbl_baslik = new System.Windows.Forms.Label();
            this.lbl_kapat = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.lbl_form_cizgi_2 = new System.Windows.Forms.Label();
            this.lbl_hex_file = new System.Windows.Forms.Label();
            this.lbl_device_manager = new System.Windows.Forms.Label();
            this.lbl_rst_upload = new System.Windows.Forms.Label();
            this.lbl_upload = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_com_yenile = new System.Windows.Forms.Label();
            this.pictureBox_kamy_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox_fth_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox_dse_logo = new System.Windows.Forms.PictureBox();
            this.lbl_logo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_kamy_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fth_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dse_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_device
            // 
            this.lbl_device.AutoSize = true;
            this.lbl_device.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_device.Location = new System.Drawing.Point(34, 143);
            this.lbl_device.Name = "lbl_device";
            this.lbl_device.Size = new System.Drawing.Size(55, 13);
            this.lbl_device.TabIndex = 13;
            this.lbl_device.Text = "Device :";
            // 
            // lbl_comPort
            // 
            this.lbl_comPort.AutoSize = true;
            this.lbl_comPort.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_comPort.Location = new System.Drawing.Point(22, 116);
            this.lbl_comPort.Name = "lbl_comPort";
            this.lbl_comPort.Size = new System.Drawing.Size(67, 13);
            this.lbl_comPort.TabIndex = 12;
            this.lbl_comPort.Text = "COM Port :";
            // 
            // comboBox_device
            // 
            this.comboBox_device.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_device.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_device.FormattingEnabled = true;
            this.comboBox_device.Location = new System.Drawing.Point(95, 140);
            this.comboBox_device.Name = "comboBox_device";
            this.comboBox_device.Size = new System.Drawing.Size(125, 21);
            this.comboBox_device.TabIndex = 11;
            this.comboBox_device.TabStop = false;
            this.comboBox_device.SelectedIndexChanged += new System.EventHandler(this.comboBox_device_SelectedIndexChanged);
            // 
            // comboBox_comPort
            // 
            this.comboBox_comPort.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_comPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_comPort.FormattingEnabled = true;
            this.comboBox_comPort.Location = new System.Drawing.Point(95, 113);
            this.comboBox_comPort.Name = "comboBox_comPort";
            this.comboBox_comPort.Size = new System.Drawing.Size(125, 21);
            this.comboBox_comPort.TabIndex = 10;
            this.comboBox_comPort.TabStop = false;
            this.comboBox_comPort.SelectedIndexChanged += new System.EventHandler(this.comboBox_comPort_SelectedIndexChanged);
            // 
            // lbl_hexFile
            // 
            this.lbl_hexFile.BackColor = System.Drawing.Color.White;
            this.lbl_hexFile.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hexFile.Location = new System.Drawing.Point(0, 81);
            this.lbl_hexFile.Name = "lbl_hexFile";
            this.lbl_hexFile.Size = new System.Drawing.Size(240, 25);
            this.lbl_hexFile.TabIndex = 8;
            this.lbl_hexFile.Text = "...";
            this.lbl_hexFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_baslik
            // 
            this.lbl_baslik.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_baslik.Location = new System.Drawing.Point(0, 0);
            this.lbl_baslik.Name = "lbl_baslik";
            this.lbl_baslik.Size = new System.Drawing.Size(240, 40);
            this.lbl_baslik.TabIndex = 17;
            this.lbl_baslik.Text = "Arduino Bootloader";
            this.lbl_baslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_baslik.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_baslik_MouseDown);
            this.lbl_baslik.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_baslik_MouseMove);
            // 
            // lbl_kapat
            // 
            this.lbl_kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_kapat.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kapat.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_kapat.Location = new System.Drawing.Point(200, 0);
            this.lbl_kapat.Name = "lbl_kapat";
            this.lbl_kapat.Size = new System.Drawing.Size(40, 40);
            this.lbl_kapat.TabIndex = 18;
            this.lbl_kapat.Text = "X";
            this.lbl_kapat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_kapat.Click += new System.EventHandler(this.lbl_kapat_Click);
            this.lbl_kapat.MouseLeave += new System.EventHandler(this.lbl_kapat_MouseLeave);
            this.lbl_kapat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_kapat_MouseMove);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // lbl_form_cizgi_2
            // 
            this.lbl_form_cizgi_2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_form_cizgi_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_form_cizgi_2.Location = new System.Drawing.Point(0, 40);
            this.lbl_form_cizgi_2.Name = "lbl_form_cizgi_2";
            this.lbl_form_cizgi_2.Size = new System.Drawing.Size(240, 1);
            this.lbl_form_cizgi_2.TabIndex = 144;
            // 
            // lbl_hex_file
            // 
            this.lbl_hex_file.Location = new System.Drawing.Point(0, 41);
            this.lbl_hex_file.Name = "lbl_hex_file";
            this.lbl_hex_file.Size = new System.Drawing.Size(240, 40);
            this.lbl_hex_file.TabIndex = 145;
            this.lbl_hex_file.Text = "Hex File";
            this.lbl_hex_file.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_hex_file.Click += new System.EventHandler(this.lbl_hex_file_Click);
            this.lbl_hex_file.MouseLeave += new System.EventHandler(this.lbl_hex_file_MouseLeave);
            this.lbl_hex_file.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_hex_file_MouseMove);
            // 
            // lbl_device_manager
            // 
            this.lbl_device_manager.Location = new System.Drawing.Point(0, 168);
            this.lbl_device_manager.Name = "lbl_device_manager";
            this.lbl_device_manager.Size = new System.Drawing.Size(240, 40);
            this.lbl_device_manager.TabIndex = 146;
            this.lbl_device_manager.Text = "Device Manager";
            this.lbl_device_manager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_device_manager.Click += new System.EventHandler(this.lbl_device_manager_Click);
            this.lbl_device_manager.MouseLeave += new System.EventHandler(this.lbl_device_manager_MouseLeave);
            this.lbl_device_manager.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_device_manager_MouseMove);
            // 
            // lbl_rst_upload
            // 
            this.lbl_rst_upload.Location = new System.Drawing.Point(140, 208);
            this.lbl_rst_upload.Name = "lbl_rst_upload";
            this.lbl_rst_upload.Size = new System.Drawing.Size(100, 40);
            this.lbl_rst_upload.TabIndex = 147;
            this.lbl_rst_upload.Text = "RST UPLOAD";
            this.lbl_rst_upload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_rst_upload.Click += new System.EventHandler(this.lbl_rst_upload_Click);
            this.lbl_rst_upload.MouseLeave += new System.EventHandler(this.lbl_rst_upload_MouseLeave);
            this.lbl_rst_upload.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_rst_upload_MouseMove);
            // 
            // lbl_upload
            // 
            this.lbl_upload.Location = new System.Drawing.Point(0, 208);
            this.lbl_upload.Name = "lbl_upload";
            this.lbl_upload.Size = new System.Drawing.Size(100, 40);
            this.lbl_upload.TabIndex = 148;
            this.lbl_upload.Text = "UPLOAD";
            this.lbl_upload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_upload.Click += new System.EventHandler(this.lbl_upload_Click);
            this.lbl_upload.MouseLeave += new System.EventHandler(this.lbl_upload_MouseLeave);
            this.lbl_upload.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_upload_MouseMove);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(0, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 2);
            this.label2.TabIndex = 151;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 2);
            this.label3.TabIndex = 152;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(0, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 1);
            this.label1.TabIndex = 153;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(0, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 1);
            this.label4.TabIndex = 154;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(0, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 1);
            this.label5.TabIndex = 155;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(0, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 1);
            this.label6.TabIndex = 156;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(0, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 1);
            this.label7.TabIndex = 157;
            // 
            // lbl_com_yenile
            // 
            this.lbl_com_yenile.Image = global::arduino_bootloader.Properties.Resources.refresh;
            this.lbl_com_yenile.Location = new System.Drawing.Point(100, 208);
            this.lbl_com_yenile.Name = "lbl_com_yenile";
            this.lbl_com_yenile.Size = new System.Drawing.Size(40, 40);
            this.lbl_com_yenile.TabIndex = 149;
            this.lbl_com_yenile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_com_yenile.Click += new System.EventHandler(this.lbl_com_yenile_Click);
            this.lbl_com_yenile.MouseLeave += new System.EventHandler(this.lbl_com_yenile_MouseLeave);
            this.lbl_com_yenile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_com_yenile_MouseMove);
            // 
            // pictureBox_kamy_logo
            // 
            this.pictureBox_kamy_logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_kamy_logo.Image = global::arduino_bootloader.Properties.Resources.KAMY_logo;
            this.pictureBox_kamy_logo.Location = new System.Drawing.Point(165, 265);
            this.pictureBox_kamy_logo.Name = "pictureBox_kamy_logo";
            this.pictureBox_kamy_logo.Size = new System.Drawing.Size(60, 60);
            this.pictureBox_kamy_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_kamy_logo.TabIndex = 23;
            this.pictureBox_kamy_logo.TabStop = false;
            this.pictureBox_kamy_logo.Click += new System.EventHandler(this.pictureBox_kamy_logo_Click);
            this.pictureBox_kamy_logo.MouseLeave += new System.EventHandler(this.pictureBox_kamy_logo_MouseLeave);
            this.pictureBox_kamy_logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_kamy_logo_MouseMove);
            // 
            // pictureBox_fth_logo
            // 
            this.pictureBox_fth_logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_fth_logo.Image = global::arduino_bootloader.Properties.Resources.FTH_logo_WhiteSmoke;
            this.pictureBox_fth_logo.Location = new System.Drawing.Point(15, 265);
            this.pictureBox_fth_logo.Name = "pictureBox_fth_logo";
            this.pictureBox_fth_logo.Size = new System.Drawing.Size(60, 60);
            this.pictureBox_fth_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_fth_logo.TabIndex = 22;
            this.pictureBox_fth_logo.TabStop = false;
            this.pictureBox_fth_logo.Click += new System.EventHandler(this.pictureBox_fth_logo_Click);
            this.pictureBox_fth_logo.MouseLeave += new System.EventHandler(this.pictureBox_fth_logo_MouseLeave);
            this.pictureBox_fth_logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_fth_logo_MouseMove);
            // 
            // pictureBox_dse_logo
            // 
            this.pictureBox_dse_logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_dse_logo.Image = global::arduino_bootloader.Properties.Resources.DSE_logo;
            this.pictureBox_dse_logo.Location = new System.Drawing.Point(90, 265);
            this.pictureBox_dse_logo.Name = "pictureBox_dse_logo";
            this.pictureBox_dse_logo.Size = new System.Drawing.Size(60, 60);
            this.pictureBox_dse_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_dse_logo.TabIndex = 21;
            this.pictureBox_dse_logo.TabStop = false;
            this.pictureBox_dse_logo.Click += new System.EventHandler(this.pictureBox_dse_logo_Click);
            this.pictureBox_dse_logo.MouseLeave += new System.EventHandler(this.pictureBox_dse_logo_MouseLeave);
            this.pictureBox_dse_logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_dse_logo_MouseMove);
            // 
            // lbl_logo
            // 
            this.lbl_logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_logo.Image = ((System.Drawing.Image)(resources.GetObject("lbl_logo.Image")));
            this.lbl_logo.Location = new System.Drawing.Point(0, 0);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(40, 40);
            this.lbl_logo.TabIndex = 16;
            this.lbl_logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_logo.Click += new System.EventHandler(this.lbl_logo_Click);
            // 
            // bootloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(240, 340);
            this.Controls.Add(this.lbl_form_cizgi_2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_com_yenile);
            this.Controls.Add(this.lbl_upload);
            this.Controls.Add(this.lbl_rst_upload);
            this.Controls.Add(this.lbl_device_manager);
            this.Controls.Add(this.lbl_hex_file);
            this.Controls.Add(this.pictureBox_kamy_logo);
            this.Controls.Add(this.pictureBox_fth_logo);
            this.Controls.Add(this.pictureBox_dse_logo);
            this.Controls.Add(this.lbl_kapat);
            this.Controls.Add(this.lbl_logo);
            this.Controls.Add(this.lbl_device);
            this.Controls.Add(this.lbl_comPort);
            this.Controls.Add(this.comboBox_device);
            this.Controls.Add(this.comboBox_comPort);
            this.Controls.Add(this.lbl_hexFile);
            this.Controls.Add(this.lbl_baslik);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bootloader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arduino Bootloader";
            this.Load += new System.EventHandler(this.bootloader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_kamy_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fth_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dse_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_device;
        private System.Windows.Forms.Label lbl_comPort;
        private System.Windows.Forms.ComboBox comboBox_device;
        private System.Windows.Forms.ComboBox comboBox_comPort;
        private System.Windows.Forms.Label lbl_hexFile;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.Label lbl_baslik;
        private System.Windows.Forms.Label lbl_kapat;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.PictureBox pictureBox_dse_logo;
        private System.Windows.Forms.PictureBox pictureBox_fth_logo;
        private System.Windows.Forms.PictureBox pictureBox_kamy_logo;
        private System.Windows.Forms.Label lbl_form_cizgi_2;
        private System.Windows.Forms.Label lbl_hex_file;
        private System.Windows.Forms.Label lbl_device_manager;
        private System.Windows.Forms.Label lbl_rst_upload;
        private System.Windows.Forms.Label lbl_upload;
        private System.Windows.Forms.Label lbl_com_yenile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}