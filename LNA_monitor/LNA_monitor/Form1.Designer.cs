namespace LNA_monitor
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.cbb_COM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Connnect = new System.Windows.Forms.Button();
            this.textBox_DAC_value = new System.Windows.Forms.TextBox();
            this.textBox_Power = new System.Windows.Forms.TextBox();
            this.textBox_Temp = new System.Windows.Forms.TextBox();
            this.textBox_Current = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Write = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.status = new System.Windows.Forms.Label();
            this.textBox_DacVoltage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_DataReceived = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbb_COM
            // 
            this.cbb_COM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_COM.FormattingEnabled = true;
            this.cbb_COM.Location = new System.Drawing.Point(39, 62);
            this.cbb_COM.Name = "cbb_COM";
            this.cbb_COM.Size = new System.Drawing.Size(170, 28);
            this.cbb_COM.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select COM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bt_Connnect
            // 
            this.bt_Connnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Connnect.Location = new System.Drawing.Point(225, 58);
            this.bt_Connnect.Name = "bt_Connnect";
            this.bt_Connnect.Size = new System.Drawing.Size(124, 35);
            this.bt_Connnect.TabIndex = 2;
            this.bt_Connnect.Text = "Connect";
            this.bt_Connnect.UseVisualStyleBackColor = false;
            this.bt_Connnect.Click += new System.EventHandler(this.bt_Connnect_Click);
            // 
            // textBox_DAC_value
            // 
            this.textBox_DAC_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DAC_value.Location = new System.Drawing.Point(38, 131);
            this.textBox_DAC_value.Name = "textBox_DAC_value";
            this.textBox_DAC_value.Size = new System.Drawing.Size(171, 26);
            this.textBox_DAC_value.TabIndex = 3;
            // 
            // textBox_Power
            // 
            this.textBox_Power.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Power.Location = new System.Drawing.Point(421, 233);
            this.textBox_Power.Name = "textBox_Power";
            this.textBox_Power.Size = new System.Drawing.Size(79, 26);
            this.textBox_Power.TabIndex = 4;
            // 
            // textBox_Temp
            // 
            this.textBox_Temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Temp.Location = new System.Drawing.Point(421, 369);
            this.textBox_Temp.Name = "textBox_Temp";
            this.textBox_Temp.Size = new System.Drawing.Size(79, 26);
            this.textBox_Temp.TabIndex = 5;
            // 
            // textBox_Current
            // 
            this.textBox_Current.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Current.Location = new System.Drawing.Point(421, 305);
            this.textBox_Current.Name = "textBox_Current";
            this.textBox_Current.Size = new System.Drawing.Size(79, 26);
            this.textBox_Current.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "DAC value";
            // 
            // button_Write
            // 
            this.button_Write.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Write.Location = new System.Drawing.Point(236, 128);
            this.button_Write.Name = "button_Write";
            this.button_Write.Size = new System.Drawing.Size(75, 28);
            this.button_Write.TabIndex = 8;
            this.button_Write.Text = "Write";
            this.button_Write.UseVisualStyleBackColor = true;
            this.button_Write.Click += new System.EventHandler(this.button_Write_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(299, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Power Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(299, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Current LNA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(296, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Temperature";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(355, 68);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 22);
            this.status.TabIndex = 12;
            // 
            // textBox_DacVoltage
            // 
            this.textBox_DacVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DacVoltage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox_DacVoltage.Location = new System.Drawing.Point(38, 210);
            this.textBox_DacVoltage.Name = "textBox_DacVoltage";
            this.textBox_DacVoltage.Size = new System.Drawing.Size(94, 26);
            this.textBox_DacVoltage.TabIndex = 13;
            this.textBox_DacVoltage.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(34, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "DAC Voltage";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_DataReceived);
            this.groupBox1.Location = new System.Drawing.Point(22, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 294);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data received";
            // 
            // textBox_DataReceived
            // 
            this.textBox_DataReceived.Location = new System.Drawing.Point(6, 23);
            this.textBox_DataReceived.Multiline = true;
            this.textBox_DataReceived.Name = "textBox_DataReceived";
            this.textBox_DataReceived.Size = new System.Drawing.Size(256, 270);
            this.textBox_DataReceived.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 565);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_DacVoltage);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Write);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Current);
            this.Controls.Add(this.textBox_Temp);
            this.Controls.Add(this.textBox_Power);
            this.Controls.Add(this.textBox_DAC_value);
            this.Controls.Add(this.bt_Connnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_COM);
            this.Name = "Form1";
            this.Text = "LNA Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_COM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Connnect;
        private System.Windows.Forms.TextBox textBox_DAC_value;
        private System.Windows.Forms.TextBox textBox_Power;
        private System.Windows.Forms.TextBox textBox_Temp;
        private System.Windows.Forms.TextBox textBox_Current;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Write;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.TextBox textBox_DacVoltage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_DataReceived;
    }
}

