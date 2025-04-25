using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //MessageBox.Show("Hello, World!");
            String helloMsg = "안녕하세요. 반갑습니다";

            textBox_print.Text = helloMsg;

            textBox_print.Text = "안녕하세요\r\n반갑습니다";
        }
    }
}
