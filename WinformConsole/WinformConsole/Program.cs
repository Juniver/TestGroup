using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormWithConsole;

namespace WinformConsole
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#if DEBUG
            NativeMethods.AllocConsole();
            Console.WriteLine("Debug Console");
#endif
            Application.Run(new Form1());
#if DEBUG
            NativeMethods.FreeConsole();
#endif
        }
    }
}
