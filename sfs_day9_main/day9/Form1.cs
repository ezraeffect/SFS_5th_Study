using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace day9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for(int i = 0; i <= 5; i++)
            {
                for (int j = 0; j < 5 - i; j++) Console.Write(" ");
                for (int j = 0; j < i - 1; j++) Console.Write("*");
                Console.WriteLine("\r\n");
            }
        }
    }
}
