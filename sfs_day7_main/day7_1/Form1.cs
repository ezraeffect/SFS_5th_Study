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

            bool isFront = true;
            bool result = CoinFlipping(isFront);

            if (result == true)
            {
                textBox_print.Text = ("승리");
            }
            else if (result == false)
            {
                textBox_print.Text = ("패배");
            }

        }

        bool CoinFlipping(bool i)
        {
            Random rand = new Random(); // Random 클래스 선언

            bool isOdd = rand.Next(0, 11) % 2 == 1 ? true : false; // 홀수일 경우 true, 짝수일 경우 false

            if (i && isOdd)
            {
                return true;
            }
            else
            {   
                return false;
            }
        }

    }
}
