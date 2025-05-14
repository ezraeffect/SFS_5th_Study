using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day14
{
    // 1. 부모 클래스
    internal class Shape
    {
        // 공통으로 처리 할 것
        public string Name { get; set; }

        public void PrintName()
        {
            Console.WriteLine($"이 도형은 {Name} 입니다.");
        }

    }

    // 2. 자식 클래스 : 사각형
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        // 넓이 구하는 Method
        
        public double GetArea() {  return Width * Height; }
    }

    // 3. 자식 클래스 : 삼각형

    internal class Triangle : Shape
    {
        public double BaseLength { get; set; }
        public double Height { get; set; }

        public double GetArea()
        {
            return (BaseLength * Height) / 2;
        }
    }

    // 4. 자식 클래스 : 원
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
