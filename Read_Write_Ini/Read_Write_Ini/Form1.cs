using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Read_Write_Ini
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // setup to INI//
            //IniPa

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            INI ini = new INI("C:\\xuan.ini");

            string st = ini.IniReadValue("Info", "Name") +" " +ini.IniReadValue("Info", "LastName") + " "+ ini.IniReadValue("Info", "Age") +" " + ini.IniReadValue("Job", "ss");
            textBox1.Text = st;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //INI ini = new INI("\test.ini");
            INI ini  = new INI("C:\\xuan.ini");
            ini.IniWriteValue("Info", "Name", "      --Trieu");
            ini.IniWriteValue("Info", "LastName", "Xuan");
            ini.IniWriteValue("Info", "Age", "1993");

            ini.IniWriteValue("Job", "ss", "1000");
        }


    }
    
}
