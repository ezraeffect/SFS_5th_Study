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

            // 0. 변수 선언 및 정의
            string gongjaSay = "멈추지 않는 한 얼마나 천천히 가는지는 중요하지 않다. -공자";
            string[] practiceArray = new string[3];

            // 1-1. 특수 문자를 검색하고 "-공자" 부분을 삭제
            int nameIndex = gongjaSay.IndexOf("-");
            practiceArray[0] = gongjaSay.Remove(nameIndex, 3);

            // 1-2. 단어를 검색하고, "얼마나", "천천히", "가는지" 세 개 단어로 나누어 배열의 요소에 저장
            int[] wordIndex = new int[4];

            wordIndex[0] = gongjaSay.IndexOf("얼마나");
            string tempGongjaSay = gongjaSay.Remove(0, wordIndex[0]);

            wordIndex[1] = tempGongjaSay.LastIndexOf("가는지");
            wordIndex[2] = wordIndex[1] + "가는지".Length; // "가는지"에서 '지' 다음의 index
            wordIndex[3] = tempGongjaSay.Length - wordIndex[2]; // '지' 다음의 index 부터 끝까지의 index 갯수

            tempGongjaSay = tempGongjaSay.Remove(wordIndex[2], wordIndex[3]);

            string[] splitArray = tempGongjaSay.Split(' ');

            // 1-3. "."과 "-"를 제거하고 모든 공백 문자를 ","로 바꾸기
            int dotIndex = gongjaSay.IndexOf('.');
            tempGongjaSay = gongjaSay.Remove(dotIndex, 1);

            int dashIndex = tempGongjaSay.IndexOf('-');
            tempGongjaSay = tempGongjaSay.Remove(dashIndex, 1);

            practiceArray[2] = tempGongjaSay.Replace(' ', ',');


            // 2. 각 결과를 TextBox에 모두 출력
            textBox_print.Text = $"1.1 : {practiceArray[0]}\r\n1.2 :\r\nindex 0 : {splitArray[0]}\r\nindex 1 : {splitArray[1]}\r\nindex 2 : {splitArray[2]}\r\n1.3 : {practiceArray[2]}";
        }
    }
}
