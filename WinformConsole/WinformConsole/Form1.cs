using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformConsole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("test1234");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("test1234");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("test1234");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("test1234");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("test1234");
        }
    }
}
