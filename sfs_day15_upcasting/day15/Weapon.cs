using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day15
{
    public class Weapon
    {
        protected int damage;

        public string Name { get; set; }

        public Weapon() { }

        public Weapon(int damage)
        {
            this.damage = damage;
        }

        public void Attack()
        {
            Console.WriteLine($"{Name}으로 공격!");
        }

        // [추가]
        public int AttackPower() => damage;
    }

    public class Sword : Weapon
    {
        // [추가] 공격 사거리
        int attack_range = 1;

        public Sword() { }
        public Sword(int damage) : base(damage) { }

        public void Sharp() // 자식 Class의 고유 Method
        {
            Console.WriteLine("검이 날카롭게 빛납니다.");
        }

        // [추가] 범위 내 공격 데미지 리턴
        public int Slash(int range)
        {
            // 공격 사거리가 공격할 거리보다 같거나 길면 공격 성공
            if (this.attack_range >= range) return this.damage;
            return 0;
            // return 0 = 운영 체제에게 함수가 잘 종료 되었다고 보내는 신호
            // return -1, 1 = 문제가 있다
        }
    }

    public class Gun : Weapon
    {

        // [추가] 공격 범위
        int attack_range = 10;

        // [추가] 생성자
        public Gun() { }
        public Gun(int damage) : base(damage) { }

        public void Reload()
        {
            Console.WriteLine("총을 재장전 합니다.");
        }

        // [추가]
        public int Fire(int range)
        {
            if (this.attack_range >= range) return damage;
            return 0;
        }
    }

    public class Bow : Weapon
    {
        //public Gun(int damage) : base(damage) { }

        public void Shoot()
        {
            Console.WriteLine("활을 발사합니다.");
        }
    }
}
