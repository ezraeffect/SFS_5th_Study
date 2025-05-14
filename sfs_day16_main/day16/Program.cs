using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1. 기본 값 전달 방식
    * c#에서는 메서드에 값을 인자로 넘길때 (매개변수 전달) 기본적으로 값을 복사하여 전달함
    * 원본 변수와는 전혀 다른 복사본을 만들어 함수에 넘긴다는 뜻
    * 그로 인해 메서드 안에서 변수 값을 변경해도 원본 변수는 영향을 받지 않음
    */

            int num = 10;
            ChangeValue(num);

            /*
             * ref, out 키워드 값 전달 방식
             * 메서드에서 원본 값을 직접 수정하거나
             * return을 보완해서 여러 값을 반환하고 싶을 때 사용
             * 값 복사 대신 참조전달 방식**/

            /* 공통점
             * 둘 다 참조 전달 방식이므로 매서드 내부에서 변경된 값이 외부에도 반영됨
             * ref나 out을 사용할 때는 함수 정의부와 호출부 모두 키워드를 명시해야하며
             * 그렇지 않으면 컴파일 오류가 발생
             * 
             * 차이점
             * [ref]
             * 입력 + 출력 목적
             * 호출 전 변수는 반드시 초기화되어 있어야 함.
             * 메서드 안에서 값을 바꿀수도 안바꿀수도 있음(선택)
             * [out]
             * 출력 전용 목적
             * 호출 전 변수는 초기화되어 있을 필요 없음
             * 메서드 안에서 반드시 값을 할당해야 함
             * when?
             * ref:기존 값을 받아서 내부에서 수정하고 싶을 떄
             * return처럼 내부에서 새 값을 마늘어서 돌려주고 싶을때 (여러 값 반환 간능)**/

            
            int numref = 10;
            ChangeRef(ref numref);
            Console.WriteLine(numref);

            int numout = 10;
            ChangeOut(out numout);
            Console.WriteLine(numout);

            int result1, result2;


        }

        // 1. 기본 값 전달 방식
        static void ChangeValue(int x) => x = 99; // 복사된 x값만 바뀌고 num은 여전히 10

        static void ChangeRef(ref int x)
        {
            x = 99;
        }

        static void ChangeOut(out int x)
        {
            //반드시 값을 할당해야 함.
            x = 100;
        }
    }
}
