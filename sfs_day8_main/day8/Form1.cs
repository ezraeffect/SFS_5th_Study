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
    enum Week
    {
        Sunday,
        Monday,
        Tuesday,    // 오타 수정: Tuseday → Tuesday
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        NotDay
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            string message = textBox_input.Text.Trim();

            Week day = GetDayFromInput(message);

            switch (day)
            {
                case Week.Sunday:
                    textBox_result.Text = "일요일 : 시간은 흐르는데 월요일이 점점 다가옴.";
                    break;
                case Week.Monday:
                    textBox_result.Text = "월요일 : 살아있음에 감사하려다 출근으로 화남.";
                    break;
                case Week.Tuesday:
                    textBox_result.Text = "화요일 : 아직도 화요일이라는 사실에 멘탈 붕괴.";
                    break;
                case Week.Wednesday:
                    textBox_result.Text = "수요일 : 주말이 보일 듯 말 듯한 신기루.";
                    break;
                case Week.Thursday:
                    textBox_result.Text = "목요일 : 일한 만큼 주말이 안 옴.";
                    break;
                case Week.Friday:
                    textBox_result.Text = "금요일 : 퇴근이 곧 해방, 몸은 회사에 마음은 집에.";
                    break;
                case Week.Saturday:
                    textBox_result.Text = "토요일 : 일찍 일어나면 손해보는 느낌.";
                    break;
                default:
                    textBox_result.Text = "잘못된 값을 입력하셨습니다.";
                    break;
            }
        }

        private Week GetDayFromInput(string input)
        {
            switch (input)
            {
                case "일요일":
                    return Week.Sunday;
                case "월요일":
                    return Week.Monday;
                case "화요일":
                    return Week.Tuesday;
                case "수요일":
                    return Week.Wednesday;
                case "목요일":
                    return Week.Thursday;
                case "금요일":
                    return Week.Friday;
                case "토요일":
                    return Week.Saturday;
                default:
                    return Week.NotDay;
            }
        }
    }

}
