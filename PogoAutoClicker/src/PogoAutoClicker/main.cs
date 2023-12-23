using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PogoAutoClicker
{
    public class main
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pogo's AutoClicker 1.0.0");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WinForm());
        }
    }
}
