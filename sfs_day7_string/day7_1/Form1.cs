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

            string[] exampleString = new string[8] { "동해 물과 백두산이",
                                                    "토요일에 먹는 토마토",
                                                    "질서 있는 퇴장",
                                                    "그 사람의 그림자는 그랬다.",
                                                    "삼성 갤럭시",
                                                    "오늘은 왠지 더 배고프다",
                                                    "이름, 나이, 전화번호",
                                                    "우리 나라 만세"};
            string[] resultString = new string[10];

            // 1.IndexOf(): "동해 물과 백두산이" 에서 "백두산"의 검색 결과를 저장
            int baekdusanIndex = exampleString[0].IndexOf("백두산");
            //resultString[0] = exampleString[0].Substring(baekdusanIndex, 3);
            resultString[0] = baekdusanIndex.ToString();

            textBox_print.Text = $"Index 0 : {resultString[0]}\r\n";

            // 2.LastIndexOf(): "토요일에 먹는 토마토" 에서 "토"를 검색하여 결과를 저장
            resultString[1] = exampleString[1].LastIndexOf("토").ToString();

            textBox_print.Text += $"Index 1 : {resultString[1]}\r\n";

            // 3.Contains(): "질서 있는 퇴장" 에서 "퇴"를 검색하여 결과를 저장
            resultString[2] = exampleString[2].Contains("퇴").ToString();

            textBox_print.Text += $"Index 2 : {resultString[2]}\r\n";

            // 4.Replace(): "그 사람의 그림자는 그랬다." 에서 "그"를 "이"로 변경
            resultString[3] = exampleString[3].Replace("그", "이");

            textBox_print.Text += $"Index 3 : {resultString[3]}\r\n";

            // 5.Insert(): "삼성 갤럭시" 에서 "삼성" 과 "갤럭시" 사이에 "애플"을 넣기
            int samsungIndex = exampleString[4].IndexOf("삼성");
            int galaxyIndex = exampleString[4].IndexOf("갤럭시");
            resultString[4] = exampleString[4].Insert(galaxyIndex, "애플");

            textBox_print.Text += $"Index 4 : {resultString[4]}\r\n";

            // 6.Remove(): "오늘은 왠지 더 배고프다" 에서 "더"를 삭제
            int theIndex = exampleString[5].LastIndexOf("더");
            resultString[5] = exampleString[5].Remove(theIndex, 2);

            textBox_print.Text += $"Index 5 : {resultString[5]}\r\n";

            // 7.Split(): "이름, 나이, 전화번호" 를 ","를 기준으로 분리하여 저장(배열 3칸 소모)
            string[] splitedString = exampleString[6].Split(',');
            resultString[6] = splitedString[0];
            resultString[7] = splitedString[1];
            resultString[8] = splitedString[2];

            textBox_print.Text += $"Index 6 : {resultString[6]}\r\n";
            textBox_print.Text += $"Index 7 : {resultString[7]}\r\n";
            textBox_print.Text += $"Index 8 : {resultString[8]}\r\n";

            // 8.SubString(): "우리 나라 만세" 에서 "나라" 만 꺼내서 저장
            int naraIndex = exampleString[7].IndexOf("나라");
            resultString[9] = exampleString[7].Substring(naraIndex, 2);

            textBox_print.Text += $"Index 9 : {resultString[9]}\r\n";
        }
    }
}
