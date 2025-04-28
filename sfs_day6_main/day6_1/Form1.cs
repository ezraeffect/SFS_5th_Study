using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Q1. 과일 이름, 가격, 수량을 변수에 저장하고 총 가격을 계산하여 출력한다.
            string fruitType = "apple";
            int fruitPrice = 1500;
            int fruitQuantity = 10;
            int totalPrice = fruitPrice * fruitQuantity;

            textBox_print.Text = $"{fruitType} {fruitQuantity}개의 총 가격은 {totalPrice}원 입니다.\r\n";

            // Q2. 문자열 + 숫자
            string q2str = "15";
            textBox_print.Text += $"{q2str}에 10을 더하면 {int.Parse(q2str) + 10} 입니다.\r\n";

            // Q3. 종합 문제
            string goodsName = "노트북";
            int goodsPrice = 1200000;
            float goodsDiscount = 0.15f;
            byte goodsQuantity = 8;
            bool isAvailable = (goodsQuantity >= 1) ? true : false;
            double discountedPrice = goodsPrice * (1 - goodsDiscount);

            textBox_print.Text += $"{(isAvailable ? "구매가능 : 할인가격은" + discountedPrice.ToString() + "원 입니다." : "품절되었습니다")}\r\n";
            textBox_print.Text += $"{((goodsQuantity >= 5) ? "여유 있음" : "소량 남음")}\r\n";
            textBox_print.Text += $"상품명 : {goodsName}, 할인된 가격 : {discountedPrice}, 재고 : {goodsQuantity}";

        }
    }
}
