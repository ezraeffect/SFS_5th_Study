using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace day9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int[] scores = { 85, 90, 78, 92, 88 };
            int sum = 0;
            foreach (int score in scores) sum += score;
            double avg = (double)sum / scores.Length;
            Console.WriteLine($"총합 : {sum}, 평균 : {avg}");

       
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            int studentNumber;
            string studentName;
            Random rnd = new Random();

            // 1.학생수를 입력
            if (int.TryParse(textBox_input.Text, out studentNumber) == true)
            {
                string[,] studentArray = new string[studentNumber,2];

                for (int i = 0; studentNumber > i; i++)
                {
                    // 2. 입력된 학생 수 만큼 0~100점 사이의 랜덤한 점수를 생성하고 각 학생 에게 점수를 할당
                    int rndScore = rnd.Next(0, 101);
                    studentArray[i,1] = rndScore.ToString();
                    // 3. 학생의 이름은 “학생1”, “학생2”, ... 와 같이 숫자만 붙여서 표기
                    studentName = $"학생{i+1}";
                    studentArray[i, 0] = studentName;

                    //textBox_result.AppendText($"{studentArray[i, 1]}\r\n");
                    textBox_result.AppendText($"{NotifyScore(studentArray[i,0], studentArray[i,1])}\r\n");

                }
            }
            else
            {
                textBox_result.AppendText("입력 형식이 잘못되었습니다.\r\n");
            }
        }

        private string NotifyScore(string name, string score)
        {
            // 4. 모든 학생에 대해 “학생1의 점수: 42점” 과 같은 형태로 결과를 표시
            // 이름과 성적을 입력하면 위와 같은 문자열을 만들어주는 함수를 작성하여 사용
            string notifyString = $"{name}의 점수: {score}점";
            return notifyString;
        }
    }
}
