namespace MACtest
{
    partial class Form_mactest
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gb_serial = new System.Windows.Forms.GroupBox();
            this.lbx_bda = new System.Windows.Forms.ListBox();
            this.lb_bda = new System.Windows.Forms.Label();
            this.label_serialstatus = new System.Windows.Forms.Label();
            this.btn_closeserial = new System.Windows.Forms.Button();
            this.btn_openserial = new System.Windows.Forms.Button();
            this.lb_bandrate = new System.Windows.Forms.Label();
            this.lb_serialport = new System.Windows.Forms.Label();
            this.cb_bandrate = new System.Windows.Forms.ComboBox();
            this.cb_port = new System.Windows.Forms.ComboBox();
            this.comm = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbx_scanner = new System.Windows.Forms.ListBox();
            this.txt_scanner = new System.Windows.Forms.TextBox();
            this.lb_scanner = new System.Windows.Forms.Label();
            this.lb_result = new System.Windows.Forms.Label();
            this.gb_serial.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_serial
            // 
            this.gb_serial.Controls.Add(this.lbx_bda);
            this.gb_serial.Controls.Add(this.lb_bda);
            this.gb_serial.Controls.Add(this.label_serialstatus);
            this.gb_serial.Controls.Add(this.btn_closeserial);
            this.gb_serial.Controls.Add(this.btn_openserial);
            this.gb_serial.Controls.Add(this.lb_bandrate);
            this.gb_serial.Controls.Add(this.lb_serialport);
            this.gb_serial.Controls.Add(this.cb_bandrate);
            this.gb_serial.Controls.Add(this.cb_port);
            this.gb_serial.Location = new System.Drawing.Point(12, 198);
            this.gb_serial.Name = "gb_serial";
            this.gb_serial.Size = new System.Drawing.Size(647, 134);
            this.gb_serial.TabIndex = 5;
            this.gb_serial.TabStop = false;
            this.gb_serial.Text = "K60-BDA接收";
            // 
            // lbx_bda
            // 
            this.lbx_bda.FormattingEnabled = true;
            this.lbx_bda.ItemHeight = 12;
            this.lbx_bda.Location = new System.Drawing.Point(12, 88);
            this.lbx_bda.Name = "lbx_bda";
            this.lbx_bda.Size = new System.Drawing.Size(600, 16);
            this.lbx_bda.TabIndex = 10;
            // 
            // lb_bda
            // 
            this.lb_bda.AutoSize = true;
            this.lb_bda.Location = new System.Drawing.Point(188, 66);
            this.lb_bda.Name = "lb_bda";
            this.lb_bda.Size = new System.Drawing.Size(47, 12);
            this.lb_bda.TabIndex = 7;
            this.lb_bda.Text = "BDA数据";
            // 
            // label_serialstatus
            // 
            this.label_serialstatus.AutoSize = true;
            this.label_serialstatus.Location = new System.Drawing.Point(361, 22);
            this.label_serialstatus.Name = "label_serialstatus";
            this.label_serialstatus.Size = new System.Drawing.Size(65, 12);
            this.label_serialstatus.TabIndex = 6;
            this.label_serialstatus.Text = "串口已关闭";
            // 
            // btn_closeserial
            // 
            this.btn_closeserial.Location = new System.Drawing.Point(541, 19);
            this.btn_closeserial.Name = "btn_closeserial";
            this.btn_closeserial.Size = new System.Drawing.Size(81, 21);
            this.btn_closeserial.TabIndex = 5;
            this.btn_closeserial.Text = "CLOSE";
            this.btn_closeserial.UseVisualStyleBackColor = true;
            this.btn_closeserial.Click += new System.EventHandler(this.btn_closeserial_Click);
            // 
            // btn_openserial
            // 
            this.btn_openserial.Location = new System.Drawing.Point(452, 19);
            this.btn_openserial.Name = "btn_openserial";
            this.btn_openserial.Size = new System.Drawing.Size(83, 21);
            this.btn_openserial.TabIndex = 4;
            this.btn_openserial.Text = "OPEN";
            this.btn_openserial.UseVisualStyleBackColor = true;
            this.btn_openserial.Click += new System.EventHandler(this.btn_openserial_Click);
            // 
            // lb_bandrate
            // 
            this.lb_bandrate.AutoSize = true;
            this.lb_bandrate.Location = new System.Drawing.Point(188, 22);
            this.lb_bandrate.Name = "lb_bandrate";
            this.lb_bandrate.Size = new System.Drawing.Size(41, 12);
            this.lb_bandrate.TabIndex = 3;
            this.lb_bandrate.Text = "波特率";
            // 
            // lb_serialport
            // 
            this.lb_serialport.AutoSize = true;
            this.lb_serialport.Location = new System.Drawing.Point(22, 23);
            this.lb_serialport.Name = "lb_serialport";
            this.lb_serialport.Size = new System.Drawing.Size(29, 12);
            this.lb_serialport.TabIndex = 2;
            this.lb_serialport.Text = "端口";
            // 
            // cb_bandrate
            // 
            this.cb_bandrate.FormattingEnabled = true;
            this.cb_bandrate.Items.AddRange(new object[] {
            "115200"});
            this.cb_bandrate.Location = new System.Drawing.Point(235, 19);
            this.cb_bandrate.Name = "cb_bandrate";
            this.cb_bandrate.Size = new System.Drawing.Size(94, 20);
            this.cb_bandrate.TabIndex = 1;
            this.cb_bandrate.Text = "115200";
            // 
            // cb_port
            // 
            this.cb_port.FormattingEnabled = true;
            this.cb_port.Location = new System.Drawing.Point(69, 20);
            this.cb_port.Name = "cb_port";
            this.cb_port.Size = new System.Drawing.Size(88, 20);
            this.cb_port.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbx_scanner);
            this.groupBox1.Controls.Add(this.txt_scanner);
            this.groupBox1.Controls.Add(this.lb_scanner);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 108);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "扫码枪接收";
            // 
            // lbx_scanner
            // 
            this.lbx_scanner.FormattingEnabled = true;
            this.lbx_scanner.ItemHeight = 12;
            this.lbx_scanner.Location = new System.Drawing.Point(12, 52);
            this.lbx_scanner.Name = "lbx_scanner";
            this.lbx_scanner.Size = new System.Drawing.Size(600, 16);
            this.lbx_scanner.TabIndex = 9;
            // 
            // txt_scanner
            // 
            this.txt_scanner.Location = new System.Drawing.Point(81, 19);
            this.txt_scanner.Name = "txt_scanner";
            this.txt_scanner.Size = new System.Drawing.Size(531, 21);
            this.txt_scanner.TabIndex = 0;
            // 
            // lb_scanner
            // 
            this.lb_scanner.AutoSize = true;
            this.lb_scanner.Location = new System.Drawing.Point(10, 22);
            this.lb_scanner.Name = "lb_scanner";
            this.lb_scanner.Size = new System.Drawing.Size(65, 12);
            this.lb_scanner.TabIndex = 8;
            this.lb_scanner.Text = "扫码枪数据";
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Font = new System.Drawing.Font("隶书", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_result.Location = new System.Drawing.Point(255, 28);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(159, 35);
            this.lb_result.TabIndex = 7;
            this.lb_result.Text = "检验结果";
            // 
            // Form_mactest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 344);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_serial);
            this.Name = "Form_mactest";
            this.Text = "MAC比对工具v1.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_mactest_FormClosing);
            this.Load += new System.EventHandler(this.Form_mactest_Load);
            this.gb_serial.ResumeLayout(false);
            this.gb_serial.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_serial;
        private System.Windows.Forms.Label label_serialstatus;
        private System.Windows.Forms.Button btn_closeserial;
        private System.Windows.Forms.Button btn_openserial;
        private System.Windows.Forms.Label lb_bandrate;
        private System.Windows.Forms.Label lb_serialport;
        private System.Windows.Forms.ComboBox cb_bandrate;
        private System.Windows.Forms.ComboBox cb_port;
        private System.IO.Ports.SerialPort comm;
        private System.Windows.Forms.Label lb_bda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_scanner;
        private System.Windows.Forms.TextBox txt_scanner;
        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.ListBox lbx_bda;
        private System.Windows.Forms.ListBox lbx_scanner;
    }
}

