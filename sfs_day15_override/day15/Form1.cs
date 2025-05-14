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

            Beverage basic = new Beverage();

            basic.Order();
            basic.Order("말차라떼");
            basic.Order("자몽 허니 블랙 티", "벤티");


            Beverage americano = new Americano();

            // americano 변수는 부모 타입인 Beverge로 선언되어 있지만 실제로는 자식 객체인 Americano를 가리키고 있음
            americano.Prepare(); // Override 된 Method 호출

            Beverage latte = new Latte();
            latte.Prepare();

            Beverage coldbrew = new ColdBrew();
            coldbrew.Prepare();
            // 클래스에 아무것도 정의하지 않았음으로 가장 가까운 조상인 Latte 메서드가 실행
            // sealed는 override만 불가능 할 뿐, 호출은 가능하다.

            Beverage coldbrew2 = new ColdBrew2();
            coldbrew2.Prepare();
        }
    }
}
