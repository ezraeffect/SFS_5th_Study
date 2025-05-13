using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 1. 자식 개체 생성
            Sword sword = new Sword();
            sword.Name = "롱소드";
            sword.Attack();
            sword.Sharp();

            Console.WriteLine("==========================");

            // 2. Upcasting
            // 자식 클래스를 부모 클래스 타입으로 참조
            // 다형성을 위해 사용 : 여러 자식 객체를 부모 타입 하나로 통합하여 유연하고 재사용 가능한 코드로 작성하기 위함

            // Upcasing의 방식 3가지
            // 3-1. 묵시적 Upcasting (중간 변수 활용)
            Weapon weapon1 = sword;
            weapon1.Attack();
            // weapon1.Sharp(); <= 자식 클래스가 부모 클래스 타입으로 참조 되었기에 자식 클래스의 Method를 사용할 수 없다.

            // 3-2. Direct Upcasting
            Weapon weapon2 = new Gun();
            weapon2.Name = "M416";
            weapon2.Attack();
            // weapon2.Reload(); <= 마찬가지로 Method 사용할 수 없다.

            // 3-3. 명시적 Upcasting (잘 사용하지 않음)
            Weapon weapon3 = (Weapon) new Bow();
            weapon3.Name = "석궁";
            weapon3.Attack();
            // weapon3.Shoot();

            Console.WriteLine("==========================");

            Sword sword2 = new Sword(30); // 데미지가 30인 검 생성
            sword2.Name = "롱소드";
            sword2.Attack();
            Console.WriteLine($"검 공격 데미지 : {sword2.Slash(1)}");

            Console.WriteLine("==========================");

            // Upcasting
            Weapon weapon4 = sword2;
            weapon4.Attack(); // 부모 메서드 호출
            //weapon4.Slash(1);
            Console.WriteLine($"검 공격 데미지 : {((Sword)weapon4).Slash(1)}");
            // Down Casting으로 사용 가능하나 사용 권장되지 않음
            // 실제 타입을 정확히 알고 있을 때는 안전
            // 실행 중 타입이 맞지 않으면 예외 발생, 안정성 떨어지며 유지보수와 확장성에서 불리함.

            Console.WriteLine("==========================");

            // 인스턴스를 덮어 씌우는 것으로 자식 클래스를 변경 가능.
            weapon4 = new Gun(100);
            weapon4.Name = "기본활";
            weapon4.Attack();
            Console.WriteLine($"활 공격 데미지 : {((Gun)weapon4).Fire(1)}");
        }
    }
}
