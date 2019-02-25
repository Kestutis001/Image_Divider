using System;
using Emgu.CV;

namespace  Image_Information
{
    public class Img_Settings
    {
        /* Path of the image to divide. */
        public string IMG_PATH { get; set; }

        /* Path of the save folder. Default to MyPictures file. */
        public string SAVE_PATH { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures).ToString();

        /* Number of rows. Between 0 and 8. */
        public int NUM_ROWS { get; set; } = 0;

        /* Number of colunms. Between 0 and 8. */
        public int NUM_COLS { get; set; } = 0;

        /* Image with segmented lines. */
        public Mat Image_With_lines { get; set; }
    }
}

