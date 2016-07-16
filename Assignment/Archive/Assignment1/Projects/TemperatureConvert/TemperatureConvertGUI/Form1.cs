using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TemperatureConvertGUI
{
    public partial class Form1 : Form
    {
        TemperatureConvertService.ServiceClient myClient = new TemperatureConvertService.ServiceClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(this.textBox1.Text);
            int result = myClient.c2f(number);
            this.label1.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            int number = Convert.ToInt32(this.textBox2.Text);
            int result = myClient.f2c(number);
            this.label2.Text = result.ToString();
        }
    }
}
