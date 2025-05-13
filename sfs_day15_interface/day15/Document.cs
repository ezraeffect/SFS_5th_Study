using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day15
{
    // 인터페이스 선언
    // 공통 기능을 강제하기 위해 (일종의 규칙, 계약)
    // 다형성을 가능하게 하기 위해
    // 유연한 구조 -> 유지보수를 용이하게 하기 위해
    // 메서드만 정의 (기능은 없음)
    public interface IReadable
    {
        void Read();
    }

    public interface IWriteable
    {
        void Write();
    }

    public interface IPrintable
    {
        void Print();
    }

    public class Document : IReadable, IWriteable, IPrintable
    {
        public void Read()
        {
            Console.WriteLine("문서를 읽고 있습니다.");
        }

        public void Write()
        {
            Console.WriteLine("문서를 쓰고 있습니다.");
        }

        public void Print()
        {
            Console.WriteLine("문서를 출력하고 있습니다.");
        }
    }

    public class PdfDocument : IReadable
    {
        public void Read()
        {
            Console.WriteLine("PDF 문서를 읽고 있습니다.");
        }
    }

    public class HwpDocument : IReadable
    {
        public void Read()
        {
            Console.WriteLine("Hwp 문서를 읽고 있습니다.");
        }
    }
}
