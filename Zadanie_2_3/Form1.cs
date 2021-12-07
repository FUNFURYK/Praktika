using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }

    private delegate int AsyncSumm(int a, int b);
    private int Summ(int a, int b)
    {
        System.Threading.Thread.Sleep(9000);
        return a + b;
    }
}
