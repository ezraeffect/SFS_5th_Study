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

            /*if (result == true)
            {
                textBox_print.Text = ("승리");
            }
            else if (result == false)
            {
                textBox_print.Text = ("패배");
            }*/

            textBox_print.Text = result ? "승리" : "패배";

        }

        bool CoinFlipping(bool i)
        {
            Random rand = new Random(); // Random 클래스 선언

            bool coin = rand.Next() % 2 == 1; // 홀수일 경우 true, 짝수일 경우 false

            // 예측과 결과가 동일할 경우에만 true 반환
            if (i == coin)
            //if ((coin == true && i == true) || (coin == false && i == false))
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
