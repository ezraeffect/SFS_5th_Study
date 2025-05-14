using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day13
{
    // 실습. 학생(Student) 정보 관리
    // 1. 학생 정보를 담는 구조체를 정의
    // 2. 3명의 학생 정보를 입력 받아 출력
    // * 한 줄 코드는 표현식 본문 방법으로 처리

    // 요구사항
    // - 구조체 이름 : Student
    // - 변수 : string name, int age, double score
    // - 메서드 : 입력받은 학생들의 정보를 출력

    struct Student
    {
        public string name;
        public int age;
        public double score;

        public void PrintStudentInfo () => Console.WriteLine ($"{name} 학생의 나이는 {age}살이며 성적은 {score}점 입니다.");
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Student[] students = new Student[3];

            for ( int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i + 1} 번째 학생의 이름을 입력하세요.");
                students[i].name = Console.ReadLine();
                Console.WriteLine($"{i + 1} 번째 학생의 나이를 입력하세요.");
                students[i].age = int.Parse(Console.ReadLine());
                Console.WriteLine($"{i + 1} 번째 학생의 성적을 입력하세요.");
                students[i].score = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 3; i++)
            {
                students[i].PrintStudentInfo();
            }
        }
    }
}
