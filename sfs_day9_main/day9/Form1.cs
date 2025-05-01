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
            int count = 0;
            for(int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0 && !(i % 5 == 0))
                {
                    Console.WriteLine(i);
                    count++;
                    result += i;
                }
            }
            Console.WriteLine($"갯수 : {count}, 총합 : {result}");
            
        }
    }
}
