using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Print
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 初始化打印机名称
        /// </summary>
        private void InitPrintNames()
        {
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                comboBox1.Items.Add(printer);
            }
            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
        }
    }
}
