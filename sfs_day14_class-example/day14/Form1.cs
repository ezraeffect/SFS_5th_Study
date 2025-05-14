using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Rectangle rect = new Rectangle()
            {
                // 객체 이니셜라이저, 객체를 만들자마자 속성 값을 한꺼번에 초기화하는 문법.
                // Property가 public { get; set; } 처럼 외부에서 설정 가능해야함
                Name = "사각형",
                Width = 4,
                Height = 5
            };

            Triangle tri = new Triangle()
            { 
                Name = "삼각형",
                BaseLength = 4,
                Height = 5
            };

            Circle circle = new Circle()
            {
                Name = "원",
                Radius = 2
            };

            rect.PrintName();
            Console.WriteLine($"{rect.GetArea()}");
            tri.PrintName();
            Console.WriteLine($"{tri.GetArea()}");
            circle.PrintName();
            Console.WriteLine($"{circle.GetArea()}");

            Console.WriteLine("========================");

            GrandChild gc = new GrandChild();
            gc.SayHello();
            gc.SayHello2();
            gc.SayHello3();
            gc.SayHello4();

            /* 부모 생성자가 먼저 호출될까?
            * 자식 클래스는 부모의 필드와 메소드를 물려받기 때문에
            * 객체를 생성하기 전에 부모 부분부터 먼저 초기화해야 자식 클래스가 안정적으로 작동할 수 있음.
            * 객체는 아래에서 생성되지만, 생성자는 위에서 호출된다.
            */

            Console.WriteLine("========================");

            Parent dad = new Parent("홍길동", 60);

            /* 그냥 부모 객체를 따로 만들면 안되는가?
             * 부모 객체를 따로 만든다는 건 부모 객체와 자식 객체를 분리해서 만들겠다는 의미
             * = 상속의 의미가 없어짐
             * GrandChild gc = new GrandChild();
             * = 조상부터 부모, 자식까지 포함한 손자 객체 하나를 만든다는 것
             */
            Console.WriteLine("========================");
            GrandChild gc2 = new GrandChild("김민수", 8);

            Console.WriteLine("========================");
            GrandChild gc3 = new GrandChild("Sam");

            
        }
    }
}
