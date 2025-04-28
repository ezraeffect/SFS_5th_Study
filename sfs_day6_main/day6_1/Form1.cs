using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            byte brightnessValue = 255;
            short retryCount = 435;
            int maxValue = 1000000;
            float riverTemperature = 16.5f;
            double piValue = 3.14159265358979323846;
            decimal price = 19.99m;

            textBox_print.Text += brightnessValue.GetType() + " brightnessValue : " + brightnessValue.ToString() + "\r\n";
            textBox_print.Text += retryCount.GetType() + " retryCount : " + retryCount.ToString() + "\r\n";
            textBox_print.Text += maxValue.GetType() + " maxValue : " + maxValue.ToString() + "\r\n";
            textBox_print.Text += riverTemperature.GetType() + " riverTemperature : " + riverTemperature.ToString() + "\r\n";
            textBox_print.Text += piValue.GetType() + " piValue : " + piValue.ToString() + "\r\n";
            textBox_print.Text += price.GetType() + " price : " + price.ToString() + "\r\n";
        }
    }
}
