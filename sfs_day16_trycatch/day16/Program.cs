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
            try
            {
                Console.Write("숫자를 입력하세요 : ");
                string input = Console.ReadLine();

                // 문자열을 정수로 변환
                int number = int.Parse(input);

                // 입력받은 숫자로 100을 나눔
                int result = 100 / number;

                if (number < 0)
                {
                    throw new Exception("예외 발생! 이거 일부러 던진거임");
                }


                Console.WriteLine($"100 / {number} = {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("오류 : 0으로 나눌 수 없습니다.");
                Console.WriteLine($"[예외 메세지]");
            }
            catch (FormatException)
            {
                Console.WriteLine("오류: 숫자가 아닌 값을 입력하셨습니다");
                Console.WriteLine($"[예외 메세지]");
            }
            catch (Exception ex)
            {
                /*
                 * 그 외 모든 예외 처리 (예외의 최상위 클래스 Exception 사용)
                 * 발생한 예외 객체를 Excption 타입으로 받아서 ex라는 객체명을 사용
                 * Exception ex 객체로 가능한것
                 * ex.Message : 예외 메세지
                 * ex.StackTrace : 예외 발생 구간 추적 정보
                 * ex.GetType : 예외의 정확한 타입 반환
                 * 
                 * ex 객체 찍어볼수있다
                 * Exception 객체는 닷넷 프레임워크의 내부 클래스이긴 하지만
                 * 우리가 직접 볼 수 없는건 아니다. 하지만 내부적인 모든 내용을 볼 수 있는건 아니다
                 * 
                 * 사실 Exception 클래스는 MSDN 문서와 오픈소스 레포를 통해 전체 속성, 메소드, 클래스를 확인 가능하다
                 * 
                 * catch (Exception ex)는 마지막에 배치해야 한다.
                 * 구체적인 예외를 먼저 처리하되 범용적인 Exception은 마지막에
                 * 예외를 너무 광범위하게 처리하면 디버깅이 어려워지고 어떤 예외가 발생헀는지 알기 어려워진다
                 * 
                 */
                Console.WriteLine("오류: 예기치 못한 문제가 발생했습니다.");
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.GetType());
            }

            finally
            {
                // 예외 발생 여부와 관계 없이 무조건 실행되는 블록  
            }
        }
    }
}
