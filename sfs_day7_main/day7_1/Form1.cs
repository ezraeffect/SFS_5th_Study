using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int a = 8;
            int b = 3;
            int[] result = new int[2];
            result = DivNumber(a, b);

            textBox_print.Text = "몫 : " + result[0].ToString() + " / 나머지 : " + result[1].ToString();
        }

        int[] DivNumber(int a, int b){
            int[] result = new int[2];
            result[0] = a / b;
            result[1] = a % b;
            return result;
        }

    }
}
