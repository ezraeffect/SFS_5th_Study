using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day15
{
    public class Beverage
    { 
    
        // 오버로드
        // 같은 이름의 메서드를 매개변수만 다르게 해서 여러개 정의 하는 것

        public void Order()
        {
            Console.WriteLine("기본 음료를 주문하셨습니다.");
        }
        public void Order(string name)
        {
            Console.WriteLine($"{name} 음료를 주문하셨습니다.");
        }
        public void Order(string name, string size)
        {
            Console.WriteLine($"{size} 사이즈의 {name} 음료를 주문하셨습니다.");
        }

        // 오버로드
        // 부모 클래스의 메서드를 자식 클래스에서 다시 재정의 하는것
        // 부모 클래스가 기본 기능을 재공하되 자식 클래스에서는 그 기능을 자신만의 방식으로 바꿔야 할 때가 많을 때 사용

        // 1. 부모 메서드가 virtual 키워드로 선언되어 있어야 함
        // 2. 자식 메서드에서 override 키워드로 재정의 해야함

        // virtual : 오버라이드 허용
        public virtual void Prepare()
        {
            Console.WriteLine("음료를 준비 중입니다.");
        }
    }

    // 아메리카노 클래스
    public class Americano : Beverage
    {
        public override void Prepare()
        {
            Console.WriteLine("아메리카노를 준비하고 있습니다");
        }
    }

    // 라떼 클래스
    public class Latte : Beverage
    {
        // sealed : override 더 이상 못하게 막기
        // 여기까지만 재정의 가능하고 그 하위 자식은 이 메서드를 바꿀 수 없게 막겠다.

        public sealed override void Prepare()
        {
            Console.WriteLine("라뗴를 준비하고 있습니다.");
        }
    }

    // 콜드브루 클래스
    public class ColdBrew : Latte
    {
        // sealed를 상속받는 자식 클래스
        // override 불가능
        /*public override void Prepare()
        {
            Console.WriteLine("콜드브루를 준비하고 있습니다.");
        }*/
    }


    // 모든 메뉴가 Beverage만 상속하는 구조라면?
    public class ColdBrew2 : Beverage
    {
        // Latte 클래스를 상속 받지 않았음으로 Seeald 영향을 받지 않음
        public override void Prepare()
        {
            Console.WriteLine("콜드브루를 준비하고 있습니다.");
        }
    }
}
