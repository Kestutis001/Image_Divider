using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Emgu.CV;
using Emgu.CV.CvEnum;
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



            var IMG_PATH = "C:\\Users\\Kestutis\\Documents\\Paintings\\cool.jpg";
            var img = new Mat();

            img = CvInvoke.Imread(IMG_PATH, ImreadModes.Color);

            /*
            CvInvoke.NamedWindow("Image", NamedWindowType.Normal);
            CvInvoke.Imshow("Image", img);
            CvInvoke.WaitKey();
            CvInvoke.DestroyAllWindows(); */
        }
    }
}
