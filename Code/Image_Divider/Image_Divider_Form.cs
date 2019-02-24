using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Image_Information;

namespace Image_Divider
{
    public partial class Form1 : Form
    {
        private Img_Settings img_info;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            img_info = new Image_Information.Img_Settings();
            TextBox_Save_Path.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures).ToString();
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
            PictureBox_Image.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox_Image.Image = new Bitmap(img_info.IMG_PATH);
        }
    }
}
