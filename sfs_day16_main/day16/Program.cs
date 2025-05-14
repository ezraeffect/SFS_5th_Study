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
            int[] refArr = new int[3];

            RefArray(ref refArr);

            Console.Write($"refArr : [ ");
            foreach (int i in refArr)
            {
                Console.Write($"{i} ");
            }
            Console.Write($"]\r\n");


            int[] outArr;

            OutArray(out outArr, 5);

            Console.Write($"outArr : [ ");
            foreach (int i in outArr)
            {
                Console.Write($"{i} ");
            }
            Console.Write($"]\r\n");
        }

        /* 다음에 따라 void 형 메소드 2개를 작성할 것
         * 1. ref 키워드를 활용한 배열 채우기
         * - 배열 생성 후, new로 생성된 배열을 ref로 메서드에 전달
         * - 메서드 내부에서 배열의 요소를 1부터 배열 길이만큼 순서대로 채워넣기 (출력)
         * 예시) 배열의 길이가 5라면 [1, 2, 3, 4, 5]
         */
       static void RefArray(ref int[] arr)
        {
            for (int i = 0; arr.Length > i; i++)
            {
                arr[i] = i + 1;
            }
        }
        /*
         * 2. out 키워드를 활용한 배열 생성 및 채우기
         * - 초기화 되지 않은 배열 변수를 out으로 전달.
         * - 메서드의 두 번째 인자로 원하는 배열의 크기(int)를 함께 전달
         * - 메서드 내부에서 해당 크기만큼의 배열을 생성한 뒤, 요소를 1부터 크기만큼 순서대로 채워넣기 (출력)
         * 예시) 크기 3이면 [1, 2, 3]
         */
        static void OutArray(out int[] arr, int index)
        {
            arr = new int[index];
            for (int i = 0; arr.Length > i; i++)
            {
                arr[i] = i + 1;
            }
        }
        
    }
}
