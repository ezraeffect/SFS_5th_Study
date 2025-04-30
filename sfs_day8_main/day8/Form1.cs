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
        enum Week
        {
            Sunday,
            Monday,
            Tuseday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            NotDay

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button_input_Click(object sender, EventArgs e)
        {

            // 1. 사용자는 요일을 입력할 수 있음
            // 2. 사용자가 요일 이외의 문자열을 입력하면 오류를 출력
            // 3. 각 요일별로 재미난 메시지를 화면에 출력

            int day;

            if (textBox_input.Text == "일요일" || radioButton1.Checked) day = (int)Week.Sunday;
            else if (textBox_input.Text == "월요일" || radioButton2.Checked) day = (int)Week.Monday;
            else if (textBox_input.Text == "화요일" || radioButton3.Checked) day = (int)Week.Tuseday;
            else if (textBox_input.Text == "수요일" || radioButton4.Checked) day = (int)Week.Wednesday;
            else if (textBox_input.Text == "목요일" || radioButton5.Checked) day = (int)Week.Thursday;
            else if (textBox_input.Text == "금요일" || radioButton6.Checked) day = (int)Week.Friday;
            else if (textBox_input.Text == "토요일" || radioButton7.Checked) day = (int)Week.Saturday;
            else day = (int)Week.NotDay;

            switch(day){
                case (int)Week.Sunday:
                    textBox_result.Text = "일요일 : 시간은 흐르는데 월요일이 점점 다가옴.";
                    return;
                case (int)Week.Monday:
                    textBox_result.Text = "월요일 : 살아있음에 감사하려다 출근으로 화남.";
                    return;
                case (int)Week.Tuseday:
                    textBox_result.Text = "화요일 : 아직도 화요일이라는 사실에 멘탈 붕괴.";
                    return;
                case (int)Week.Wednesday:
                    textBox_result.Text = "수요일 : 주말이 보일 듯 말 듯한 신기루.";
                    return;
                case (int)Week.Thursday:
                    textBox_result.Text = "목요일 : 일한 만큼 주말이 안 옴.";
                    return;
                case (int)Week.Friday:
                    textBox_result.Text = "금요일 : 퇴근이 곧 해방, 몸은 회사에 마음은 집에.";
                    return;
                case (int)Week.Saturday:
                    textBox_result.Text = "일요일 : 시간은 흐르는데 월요일이 점점 다가옴.";
                    return;
                case (int)Week.NotDay:
                    textBox_result.Text = "잘못된 값을 입력하셨습니다.";
                    return;


            }

        }
    }
}
