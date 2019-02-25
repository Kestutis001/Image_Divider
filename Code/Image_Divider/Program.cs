using System;
using System.Windows.Forms;

namespace Image_Divider
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            /* Set up and run Windows Form:*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
