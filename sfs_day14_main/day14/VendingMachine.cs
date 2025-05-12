using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day14
{
    internal class VendingMachine
    {
        // 필드
        private int balance;
        private int itemsLeft;
        private int itemPrice;
        private int refund;

        // 속성
        public int Balance
        {
            get { return balance; }
            set
            {
                if (value < 0) balance = 0;
                else balance = value;
            }
        }
        public int ItemsLeft
        {
            get { return itemsLeft; }
            set
            {
                if (value < 0) itemsLeft = 0;
                else itemsLeft = value;
            }
        }

        public int ItemPrice
        {
            get { return itemPrice; }
            set
            {
                if (value < 0) itemPrice = 0;
                else itemPrice = value;
            }
        }

        public int Refund
        {
            get { return refund; }
            set
            {
                if (value < 0) refund = 0;
                else refund = value;
            }
        }

        // 생성자
        // 소멸자
        // 메소드


        /*
         * 1. 계산기에 돈을 넣는다
         * 2. 음료수 갯수를 입력한다
         * 3. 음료수를 받는다
         * 4. 남은 돈은 돌려받는다
         */
        public void GetMoney(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("잘못된 금액을 입력하셨습니다");
            }
            else
            {
                this.Balance += amount; // 자판기 돈통에 돈 저장
                this.Refund = amount; // 반환해줄 금액 기록
            }

        }

        public int DischargeDrink(int amount)
        {
            // 재고량이 갯수보다 많다면 (정상)
            if ((amount > 0) && (ItemsLeft >= amount))
            {
                ItemsLeft -= amount;
                Console.WriteLine($"음료 {amount}개를 배출했습니다.");

                this.Refund = Refund - (itemPrice * amount); // 입금액 - ( 상품 가격 * 갯수)
            }
            // 재고량이 갯수보다 작다면 (갯수부족)
            else if ((amount > 0) && (ItemsLeft <= amount))
            {
                Console.WriteLine($"자판기 내 음료 재고가 부족합니다.");
            }
            // 재고량이 없다면 (매진)
            else if (ItemsLeft == 0)
            {
                Console.WriteLine($"상품이 매진입니다.");
            }

            return this.Refund; // 반환 금액을 return한다.
        }
    }
}
