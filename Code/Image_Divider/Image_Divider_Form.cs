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
        }

        private void Button_Save_Path_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string savepath = folderBrowserDialog1.SelectedPath;
                textBox2.Text = savepath;
                img_info.SAVE_PATH = string.Copy(savepath);
            }
        }

        private void Button_Img_Path_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string img_path = openFileDialog1.FileName;
                textBox1.Text = img_path;
                img_info.IMG_PATH = string.Copy(img_path);
            }
        }

        private void TrackBar_Columns_Scroll(object sender, EventArgs e)
        {

        }

        private void TrackBar_Rows_Scroll(object sender, EventArgs e)
        {

        }
    }
}
