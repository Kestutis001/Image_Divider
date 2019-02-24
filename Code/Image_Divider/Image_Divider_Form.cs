using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
/* Open CV: */
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
/* Custom Classes: */
using Image_Information;
using Data;

namespace Image_Divider
{
    public partial class Form1 : Form
    {
        private Img_Settings img_info;
        private Constents img_restaints;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            img_info = new Image_Information.Img_Settings();
            img_restaints = new Data.Constents();
            img_info.NUM_COLS = TrackBar_Columns.Value;
            img_info.NUM_ROWS = TrackBar_Rows.Value;
            TextBox_Save_Path.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures).ToString();
        }

        private void Button_Accept_Click(object sender, EventArgs e)
        {
            if ( img_info.IMG_PATH == null)
            {
                MessageBox.Show("Error: Please select an Image.");
            }
            else
            {
                var Img_File_Name = Get_Name();
                string Img_File_Path = Path.Combine(img_info.SAVE_PATH, Img_File_Name + "_Divided");
                Directory.CreateDirectory(Img_File_Path);
            }
        }

        private void Button_Save_Path_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string savepath = folderBrowserDialog1.SelectedPath;
                TextBox_Save_Path.Text = savepath;
                img_info.SAVE_PATH = string.Copy(savepath);
            }
        }

        private void Button_Img_Path_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog1.Title = "Select Image";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures).ToString();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string img_path = openFileDialog1.FileName;
                TextBox_Img_Path.Text = img_path;
                img_info.IMG_PATH = string.Copy(img_path);
                Update_PictureBox();
            }
        }

        private void TrackBar_Columns_Scroll(object sender, EventArgs e)
        {
           img_info.NUM_COLS = TrackBar_Columns.Value;
           TextBox_Num_Cols.Text = TrackBar_Columns.Value.ToString();
           Update_PictureBox();
        }

        private void TrackBar_Rows_Scroll(object sender, EventArgs e)
        {
            img_info.NUM_ROWS = TrackBar_Rows.Value;
            TextBox_Num_Rows.Text = TrackBar_Rows.Value.ToString();
            Update_PictureBox();
        }

        private void Update_PictureBox()
        {
            if (img_info.IMG_PATH != null)
            {
                if (Segment_Image_Lines() == true)
                {
                    PictureBox_Image.SizeMode = PictureBoxSizeMode.Zoom;
                    Image<Bgr, Byte> buffer_im = img_info.Image_With_lines.ToImage<Bgr, byte>();
                    PictureBox_Image.Image = buffer_im.ToBitmap();
                }
            }
        }

        private string Get_Name()
        {
            var path = Path.GetFileName(img_info.IMG_PATH);
            string[] return_data = path.Split('.');
            return return_data[0];
        }

        /* Figure out the individule image sizes */
        private bool Segment_Image_Lines()
        {
            Mat img = CvInvoke.Imread(img_info.IMG_PATH, ImreadModes.Color);                                                                                               //load in image as a colored Mat.           
            if (img.Size.Height < img_restaints.ROWS_MIN || img.Size.Width < img_restaints.COLS_MIN)                                                                       //Check restrains.
            {
                MessageBox.Show("Invalid Image Size. Image Must Be " + img_restaints.COLS_MIN.ToString() + "x" + img_restaints.ROWS_MIN.ToString() + " Or Larger.");       //Tell user if Image Is too small.
                return false;
            }
            else
            {
                var Row_Size = img.Size.Height / img_info.NUM_ROWS;
                var Col_Size = img.Size.Width / img_info.NUM_COLS;

                /*
                 * Standard Def.     640x480                 Small Line Thickness
                 * High Def.         1280x720                Medium Line Thickness
                 * Full HD.          1920x1080               Large Line Thickness
                 * 4k                3840x2160               Huge Line Thickness
                 * More than 4k                              Ultra Line Thickness
                 */

                var Line_Thickness = img_restaints.Line_Thickness_Small;
                if (img.Size.Height > 480 && img.Size.Height < 720 || img.Size.Width > 640 && img.Size.Width < 1280)
                {
                    Line_Thickness = img_restaints.Line_Thickness_Medium;
                }
                else
                {
                    if (img.Size.Height > 720 && img.Size.Height < 1080 || img.Size.Width > 1280 && img.Size.Width < 1920)
                    {
                        Line_Thickness = img_restaints.Line_Thickness_Large;
                    }
                    else
                    {
                        if (img.Size.Height > 1080 && img.Size.Height < 2160 || img.Size.Width > 1920 && img.Size.Width < 3840)
                        {
                            Line_Thickness = img_restaints.Line_Thickness_Huge;
                        }
                        if (img.Size.Height > 2160 || img.Size.Width > 3840)
                        {
                            Line_Thickness = img_restaints.Line_Thickness_Ultra;
                        }
                    }
                }

                /* Draw lines on Image for COLS */
                for (int i = 1; i < img_info.NUM_COLS; i++)
                {
                    Point startPoint = new Point(Col_Size * i, 0);
                    Point endPoint = new Point(Col_Size * i, img.Size.Height);
                    CvInvoke.Line(img, startPoint, endPoint, img_restaints.Line_Color, Line_Thickness);
                }

                /* Draw lines on Image for ROWS */
                for (int i = 1; i < img_info.NUM_ROWS; i++)
                {
                    Point startPoint = new Point(0, Row_Size * i);
                    Point endPoint = new Point(img.Size.Width, Row_Size * i);
                    CvInvoke.Line(img, startPoint, endPoint, img_restaints.Line_Color, Line_Thickness);
                }

                img_info.Image_With_lines = img;
            }
            return true;
        }

        private void Segment_Image_and_Save()
        {

        }
    }
}
