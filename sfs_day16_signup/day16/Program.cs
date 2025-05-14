using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace day16
{
    internal class Program
    {

        /*
         * 실습. 예외처리 - 회원가입 닉네임 검사
         * 사용자가 입력한 닉네임을 검사하는 프로그램 작성
         * 특정 조건을 만족하지 않으면 예외를 발생시키고, 예외에 맞는 메세지 출력하기
         * 1. 사용자로부터 닉네임을 한 줄 입력 받기
         * 2. 다음 조건을 검사하여, 해당하지 않을 경우 직접 예외 발생시키기
         * 검사 조건, 예외클래스, 예외 메세지
         * 닉네임이 비어 있음, Excption, "닉네임을 입력해주세요"
         * 닉네임 길이가 2자 미만, Execption, "닉네임은 2글자 이상이여야 합니다"
         * 닉네임에 admin 포함, Exception, "닉네임에 'admin'은 포함할 수 없습니다"
         * 3. 조건에 해당하지 않으면 "닉네임 등록 완료!"를 출력
         * 4. 모든 예외는 try~catch로 처리, 예외 발생시 ex.Message 출력.
         * 5. 마지막에는 "프로그램을 종료합니다"를 Finally로 구현
         */
        static void Main(string[] args)
        {
            // 1.사용자로부터 닉네임을 한 줄 입력 받기
            Console.Write("닉네임을 작성해주세요 : ");
            string nickname = Console.ReadLine();

            // 4-1. 모든 예외는 try~catch로 처리
            try
            {
                // 2.다음 조건을 검사하여, 해당하지 않을 경우 직접 예외 발생시키기
                if (string.IsNullOrWhiteSpace(nickname)) throw new Exception("닉네임을 입력해주세요"); // 닉네임이 비어 있음, Excption, "닉네임을 입력해주세요"
                else if (nickname.Length < 2) throw new Exception("닉네임은 2글자 이상이여야 합니다"); // 닉네임 길이가 2자 미만, Execption, "닉네임은 2글자 이상이여야 합니다"
                else if (nickname.ToLower().Contains("admin")) throw new Exception("닉네임에 'admin'은 포함할 수 없습니다"); // 닉네임에 admin 포함, Exception, "닉네임에 'admin'은 포함할 수 없습니다"
                else Console.WriteLine($"{nickname}으로 닉네임 등록 완료!"); // 3.조건에 해당하지 않으면 "닉네임 등록 완료!"를 출력
            }
            catch (Exception ex)
            {
                // 4-2. 예외 발생시 ex.Message 출력
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // 5.마지막에는 "프로그램을 종료합니다"를 Finally로 구현
                Console.WriteLine("프로그램을 종료합니다.");
            }
        }
    }
}
