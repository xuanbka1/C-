using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Xml;


namespace LNA_monitor
{
    public partial class Form1 : Form
    {

        bool comStatus = true; // Com is opened//
        string InputData = String.Empty;
        delegate void SetTextCallback(string text); // Khai bao delegate SetTextCallBack voi tham so string

        public Form1()
        {
            InitializeComponent();
           // serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
            button_Write.Enabled = false;
           

        // nini file//
           
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbb_COM.DataSource = SerialPort.GetPortNames();

            // process Xml//

          //  Xml_CreateFile();
           // Xml_Read();
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           if (serialPort1.IsOpen)
              {
                serialPort1.Close();
              }
       }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_Connnect_Click(object sender, EventArgs e)
        {
           // Xml_Read();
            if (comStatus == false) comStatus = true;
            else  comStatus = false;


            if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = cbb_COM.Text;
                serialPort1.Open();
                comStatus = true;
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
                //serialPort1.WriteLine("0"); // write default DAC value

				bt_Connnect.Text = " Disconnect";
                cbb_COM.Enabled = false;
                status.Text = cbb_COM.Text + " is opened ";
                status.ForeColor = System.Drawing.Color.Green;
                bt_Connnect.ForeColor = System.Drawing.Color.Red;
                button_Write.Enabled = true;  // if not connect, disable button Write

                Xml_Read();  // show information of Serial Port
              
            }

            else
            {
                serialPort1.Close();
                comStatus = false;
				
				bt_Connnect.Text = " Connect";
                cbb_COM.Enabled = true;
                status.Text = cbb_COM.Text + " is close ";
                status.ForeColor = System.Drawing.Color.Red;
                bt_Connnect.ForeColor = System.Drawing.Color.Green;
                button_Write.Enabled = false;  // if not connect, active button Write
            }

            
        }

        private void button_Write_Click(object sender, EventArgs e)
        {
            if (textBox_DAC_value.Text =="")
                MessageBox.Show(" Nhập giá trị DAC (0-1023)");
            else
            serialPort1.WriteLine(textBox_DAC_value.Text);

        }

 //Receiver data from MCU//
        private void DataReceive(object obj, SerialDataReceivedEventArgs e)
        {

        }

        #region puts value to monitor




/// <summary>
///set value to textBox Power Status
/// </summary>
/// <param name="text"></param>
        private void SetText_Power(string text)
        {

            if (this.textBox_Power.InvokeRequired)
            {

                SetTextCallback d = new SetTextCallback(SetText_Power); // khởi tạo 1 delegate mới gọi đến SetText

                this.Invoke(d, new object[] { text });

            }

            else this.textBox_Power.Text = text;

        }
/// <summary>
/// Set value to Textbox Current LNA
/// </summary>
/// <param name="text"></param>
        private void SetText_CurrentLNA(string text)
        {

            if (this.textBox_Power.InvokeRequired)
            {

                SetTextCallback d = new SetTextCallback(SetText_CurrentLNA); // khởi tạo 1 delegate mới gọi đến SetText

                this.Invoke(d, new object[] { text });

            }

            else this.textBox_Current.Text = text;

        }
/// <summary>
/// Set value to textBox Temperature
/// </summary>
/// <param name="text"></param>
        private void SetText_Temperature(string text)
        {

            if (this.textBox_Power.InvokeRequired)
            {

                SetTextCallback d = new SetTextCallback(SetText_Temperature); // khởi tạo 1 delegate mới gọi đến SetText

                this.Invoke(d, new object[] { text });

            }

            else this.textBox_Temp.Text = text;

        }
//
        /// <summary>
        /// Set value to Textbox Current LNA
        /// </summary>
        /// <param name="text"></param>
        private void SetText_DacVoltage(string text)
        {

            if (this.textBox_Power.InvokeRequired)
            {

                SetTextCallback d = new SetTextCallback(SetText_DacVoltage); // khởi tạo 1 delegate mới gọi đến SetText

                this.Invoke(d, new object[] { text });

            }

            else
            {
                this.textBox_DacVoltage.Text = text;
            }
        }
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

////
////
        public void Xml_CreateFile()
        {
            XmlTextWriter Xml_Device = new XmlTextWriter("Device.xml", System.Text.Encoding.UTF8);
            Xml_Device.WriteStartDocument(true);
            Xml_Device.Formatting = Formatting.Indented;
            Xml_Device.Indentation = 2;

            Xml_Device.WriteStartElement("Serial");
            Xml_CreateNode("COM1","9600", "8", "None", Xml_Device);
            Xml_CreateNode("COM2","57600", "8", "None",Xml_Device);
            Xml_CreateNode("COM3","115200", "8", "None", Xml_Device);

            Xml_Device.WriteEndElement();
            Xml_Device.WriteEndDocument();
            Xml_Device.Close();
        }

/* 
 Distribute Structure stage for Xml file
 */

        
        public void Xml_CreateNode( string nameField, string Baurate, string dataSize, string Parity, XmlTextWriter Xml_file)
        {
            Xml_file.WriteStartElement(nameField);

            Xml_file.WriteStartElement("Baurate"); // item0
            Xml_file.WriteString(Baurate);
            Xml_file.WriteEndElement();

            Xml_file.WriteStartElement("DataSize");  // item1
            Xml_file.WriteString(dataSize);
            Xml_file.WriteEndElement();

            Xml_file.WriteStartElement("Parity"); // item2
            Xml_file.WriteString(Parity);
            Xml_file.WriteEndElement();

            Xml_file.WriteEndElement();
        }

 /*
  loc thong tin trong file xml  trong 
  *  GetelementBytagname/
  */

        public void Xml_Read()
        {
            // read xml //

            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            int i = 0;
            string str = null;
            FileStream fs = new FileStream("Device.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName(cbb_COM.Text);
            for (i = 0; i <= xmlnode.Count - 1; i++)
            {
                // xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                str = xmlnode[i].ChildNodes.Item(0).InnerText.Trim() + " " + xmlnode[i].ChildNodes.Item(1).InnerText.Trim() + " " + xmlnode[i].ChildNodes.Item(2).InnerText.Trim();  
                MessageBox.Show(str);

            }
        }


       
    }  // end class


} // end namespace

