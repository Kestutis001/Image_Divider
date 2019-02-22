using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Emgu.CV;
using Emgu.CV.CvEnum;

namespace Image_Divider
{
    class Program
    {
        static void Main(string[] args)
        {
            var IMG_PATH = "C:\\Users\\Kestutis\\Documents\\Paintings\\IMG_4073.jpg";
            var img = new Mat();

            img = CvInvoke.Imread(IMG_PATH, ImreadModes.Color);


            CvInvoke.NamedWindow("Image", NamedWindowType.Normal);
            CvInvoke.Imshow("Image", img);
            CvInvoke.WaitKey();
            CvInvoke.DestroyAllWindows();
        }
    }
}
