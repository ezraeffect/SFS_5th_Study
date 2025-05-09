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
    // 실습. 좌표(Point) 구조체 만들기
    // 1. x, y 좌표값을 가지는 Point 구조체를 만든다
    // 2. 사용자에게 좌표 두 개를 입력는다
    // 3. 두 점 사이의 거리 를 구하세요.

    struct Point
    {
        public int x;
        public int y;
    }

    public partial class Form1 : Form
    {
        static double GetBetweenDistance(int x, int y, int x2, int y2) => Math.Sqrt(Math.Pow(x2 - x, 2) + Math.Pow(y2 - y, 2));

        public Form1()
        {
            InitializeComponent();

            while (true)
            {
                Point[] p = new Point[2];

                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("X좌표와 Y좌표를 입력하세요.");
                    string[] inputStr = Console.ReadLine().Split(' ');
                    if (inputStr.Length == 2)
                    {
                        if (!int.TryParse(inputStr[0], out p[i].x)) Console.WriteLine("인자값의 형식이 잘못되었습니다");
                        if (!int.TryParse(inputStr[1], out p[i].x)) Console.WriteLine("인자값의 형식이 잘못되었습니다");
                    }
                    else Console.WriteLine("인자값의 갯수가 잘못되었습니다");
                }
                Console.WriteLine($"두 점 사이의 거리는 {GetBetweenDistance(p[0].x, p[0].y, p[1].x, p[1].y)}");
            }
        }
    }
}
