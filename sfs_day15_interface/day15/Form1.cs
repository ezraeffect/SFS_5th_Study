using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            // 다형성
            // 하나의 인터페이스로 여러 개의 서로 다른 객체를 동일하게 다루는 것.

            // 클래스 타입으로 사용 (모든 기능 다 사용 가능)
            // 다형성 적용 X
            Document doc = new Document();
            doc.Read();
            doc.Write();
            doc.Print();

            /* 인터페이스 타입으로 각각 제어 */
            // 인터페이스 타입으로 사용, 해당 인터페이스에 정의된 기능만 사용 할 수 있게 제한 됨
            // 다형성 적용 O
            IReadable reader = new Document();
            IWriteable writer = new Document();
            IPrintable printer = new Document();

            reader.Read();
            // reader.Write(); <= 인터페이스에 명시되지 않은 Method이므로 사용 불가능

            reader.Read();      // Read만 가능
            writer.Write();     // Write만 가능
            printer.Print();    // Print만 가능

            // [참고] 하나의 인터페이스 타입으로 다양한 객체를 만들면?

            IReadable reader1 = new Document();
            IReadable reader2 = new PdfDocument();
            IReadable reader3 = new HwpDocument();

            reader1.Read();
            reader2.Read();
            reader3.Read();

            // IReadable이라는 하나의 타입으로 서로 다른 클래스 객체를 동일하게 제어하면서, 동작은 다르게 나오는것 => 다형성
        }
    }
}
