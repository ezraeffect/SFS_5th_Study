using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace day6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[,] korean = {{"가","나","다"},
                                {"라","마","바"},
                                {"사","아","자"}};

            textBox_print.Text = korean[1, 2];

            int[,,] nums = new int[,,]
            {
                {
                    {1, 2, 3},
                    {4, 5, 6}
                },
                {
                    {7, 8, 9},
                    {10, 11, 12}
                }
            };

            textBox_print.Text += nums[1, 0, 1];
        }
    }
}
