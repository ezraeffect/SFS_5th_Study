using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 변수 선언
            int numOfCrew;

            // 변수 사용
            numOfCrew = 19;

            // 변수 초기화
            string className = "말하기";

            // 변수 값 덮어쓰기
            className = "수학";

            //선언보다 밑에 줄에서 사용 가능
            //lineCount = 10;
            int linecount;

            // 같은 이름 사용 불가 (선언 시)
            byte buffer;
            //float buffer;

            // 데이터 타입이 완전히 다르면 복사 불가
            int number = 10;
            string word = "안녕";
            //word = nunber; // 오류 발생

            // 같은 형식에서 데이터 타입의 크기에 따라 복사 가능, 불가능
            short word2 = 20;

            // int > short 더 큰 범위의 데이터 타입.
            number = word2; // 자료형 상이하나 복사 가능

            // 변수끼리 값 복사 (o)
            int var_x = 10;
            int var_y = var_x; // var_x의 값을 vat_y에 복사

            // 사칙 연산 및 괄호 활용
            int var_z = var_x * var_y;
            int result = var_z + (var_x + 5);

            // Scope가 다르면 사용이 불가능
            {
                int inside = 100;
            }

            // inside와 Scope가 다르기 때문에 사용 불가
            //Console.WriteLine(inside); // 오류 발생


            textBox_print.Text += numOfCrew.GetType() + " numOfCrew : " + numOfCrew.ToString() + "\r\n";
        }
    }
}
