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
            String helloMsg = "안녕하세요. test branch에서 수정했습니다.";
            //String helloMsg2 = "Ipsum lorem";
            String helloMsg3 = "안녕하세요 aranghong입니다.";

            textBox_print.Text = helloMsg;
            MessageBox.Show(helloMsg3);
        }
    }
}
