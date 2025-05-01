using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int result = 0;
            for(int i = 1; i <= 20; i++)if (i % 2 == 0) result += i;
            Console.WriteLine($"1부터 20까지 수 중 짝수의 합은 {result}입니다.");
            
        }
    }
}
