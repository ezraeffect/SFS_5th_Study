using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day14
{
    // 다단계 상속 (조부모 - 손자)

    /* 접근제한자 오류?
    * Parent는 외부에 공개된 Class인데, 상위 Class인 GrandParent가 Private여서 외부에 접근이 불가능함.
    * 외부에서 사용할 수 없는 클래스를 기반으로 한 공개 클래스라는 컴파일 오류 발생.
    */

    //1. 최상위 클래스
    public class GrandParent
    {
        public GrandParent() { Console.WriteLine("GrandParent 생성자 호출됨"); }

        /* 2. Base 키워드
        * 상속된 클래스의 자식 생성자에서 부모 생성자를 선택적으로 호출하고 싶을 때 사용.
        * 손자 -> 조성 (X) 직접 상속 받은 부모 클래스의 생성자만
        * 기본 생성자 이외의 특정 매개변수가 있는 부모 생성자를 명확히 지정하고 싶을 때
        * 자식 생성자가 받은 값을 부모 생성자에게 넘기고 싶을 때
        */

        public GrandParent(string name, int age)
        {
            Console.WriteLine("GrandParent 매개변수 생성자 호출됨");
            Console.WriteLine($"이름은 {name}, 나이는 {age} 입니다.");
        }

        public void SayHello() { Console.WriteLine("할아버지입니다"); }
    }

    public class Parent : GrandParent
    {
        public Parent() { Console.WriteLine("Parent 생성자 호출됨"); }

        /* 2-1. Base 키워드 사용해 부모 클래스에서 조상 매개변수 생성자 호출*/
        public Parent(string name, int age) : base(name, age) {
            Console.WriteLine("Parnet 매개변수 생성자 호출됨");
        }
        public void SayHello2() { Console.WriteLine("아버지입니다"); }
    }

    public class Child : Parent
    {
        public Child() { Console.WriteLine("Child 생성자 호출됨"); }

        // 2-3 Base 키워드는 자신의 "부모"만 호출 가능하기에 손자 클래스에서 먼 조상 생성자 호출하려면 부모클래스에도 똑같이 호출해줘야함. 
        
        public Child(string name, int age) : base(name, age)
        {
            Console.WriteLine("Child 매개변수 생성자 호출됨");
        }
        // 3. 자식 클래스의 기본 생성자가 없고, 매개변수 생성자만 존재 할 때.
        // 손자 클래스에서 반드시 자식 클래스(=부모)의 생성자를 호출해야 함.
        // 기본 생성자 작성 안해도 자동으로 생성해주지않냐?
        // 생성자가 하나라도 없으면 c#이 자동으로 기본 새엉자를 만들어옴
        // 그러나 생성자가 하나라도 존재한다면 자동으로 만들어주지 않으ㅡㅁ

        public Child(string name)
        {
            Console.WriteLine("child 기본 생성자 x 매개변수 생성자 o 호출됨");
        }

        public void SayHello3() { Console.WriteLine("아들입니다"); }
    }

    public class GrandChild : Child
    {
        public GrandChild() { Console.WriteLine("GrandChild 생성자 호출됨"); }

        // 2-2 Base 키워드 사용해 손자 클래스에서 조상 매개변수 생성자 호출
        public GrandChild(string name, int age) : base(name, age)
        {
            Console.WriteLine("GrandChild 매개변수 생성자 호출됨");
        }
        //public GrandChild(string name, int age) { }
        // 위 처럼 매개변수가 동일한 생성자 두개는 공존 할 수 없음
        // 구분자 매개변수 추가, 하나의 생성자에서 분기 처리(조건문)

        // 3. 손자클래스에도 기본 생성자 (X) - 기본 생성자 주석처리 하던가
        // 자식 클래스에 기본 생성자 추가
        // 손자 클래스 생성자에서 base 키어드로 부모 매개변수 생성자 명시 호출
        public GrandChild(string name) : base(name)
        {
            Console.WriteLine("GrandChild 기본 생성자 x 매개변수 생성자 o 호출됨.");
        }

        public void SayHello4() { Console.WriteLine("손자입니다"); }
    }
}