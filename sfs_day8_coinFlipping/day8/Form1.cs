using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            bool isCoinFront;
            bool result;

            if (textBox_input.Text == "true" || textBox_input.Text == "false") // textBox_input에 입력된 문자열이 있다면 우선적으로 처리
            {
                isCoinFront = bool.Parse(textBox_input.Text);
                result = CoinFlipping(isCoinFront);
                textBox_result.Text = $"textBox로 입력하신 값은 {isCoinFront.ToString()} 입니다.\r\n동전 던지기 결과...\r\n";
                textBox_result.Text += result ? "승리" : "패배";
            }
            else if (radioButtonFront.Checked || radioButtonBack.Checked) // textBox_input에 값을 입력하지 않아도 라디오 버튼의 상태에 따라 true 또는 false 값이 입력되도록 처리
            {
                isCoinFront = radioButtonFront.Checked || !radioButtonBack.Checked;
                result = CoinFlipping(isCoinFront);
                textBox_result.Text = $"radioButton으로 입력하신 값은 {isCoinFront.ToString()} 입니다.\r\n동전 던지기 결과...\r\n";
                textBox_result.Text += result ? "승리" : "패배";
            }
            else // 사용자가 true 또는 false 이외의 값을 입력했다면 적당한 에러 메시지를 textBox_result에 출력
            {
                textBox_result.Text = "올바르지 않은 입력 값 입니다.";
            }
        }

        bool CoinFlipping(bool i)
        {
            Random rand = new Random(); // Random 클래스 선언

            bool coin = rand.Next() % 2 == 1; // 홀수일 경우 true, 짝수일 경우 false

            // 예측과 결과가 동일할 경우에만 true 반환
            if (i == coin)
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
