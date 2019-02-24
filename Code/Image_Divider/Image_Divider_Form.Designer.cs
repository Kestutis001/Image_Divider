namespace Image_Divider
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PictureBox_Image = new System.Windows.Forms.PictureBox();
            this.Button_Accept = new System.Windows.Forms.Button();
            this.TrackBar_Rows = new System.Windows.Forms.TrackBar();
            this.TrackBar_Columns = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Button_Browse_Img_Path = new System.Windows.Forms.Button();
            this.Button_Browse_Save_Path = new System.Windows.Forms.Button();
            this.TextBox_Img_Path = new System.Windows.Forms.TextBox();
            this.TextBox_Save_Path = new System.Windows.Forms.TextBox();
            this.TextBox_Num_Cols = new System.Windows.Forms.TextBox();
            this.TextBox_Num_Rows = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Columns)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Image Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Save Path:";
            // 
            // PictureBox_Image
            // 
            this.PictureBox_Image.Location = new System.Drawing.Point(136, 131);
            this.PictureBox_Image.Name = "PictureBox_Image";
            this.PictureBox_Image.Size = new System.Drawing.Size(838, 440);
            this.PictureBox_Image.TabIndex = 4;
            this.PictureBox_Image.TabStop = false;
            // 
            // Button_Accept
            // 
            this.Button_Accept.Location = new System.Drawing.Point(789, 35);
            this.Button_Accept.Name = "Button_Accept";
            this.Button_Accept.Size = new System.Drawing.Size(185, 50);
            this.Button_Accept.TabIndex = 5;
            this.Button_Accept.Text = "Accept";
            this.Button_Accept.UseVisualStyleBackColor = true;
            this.Button_Accept.Click += new System.EventHandler(this.Button_Accept_Click);
            // 
            // TrackBar_Rows
            // 
            this.TrackBar_Rows.Location = new System.Drawing.Point(77, 131);
            this.TrackBar_Rows.Maximum = 8;
            this.TrackBar_Rows.Minimum = 1;
            this.TrackBar_Rows.Name = "TrackBar_Rows";
            this.TrackBar_Rows.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBar_Rows.Size = new System.Drawing.Size(56, 440);
            this.TrackBar_Rows.TabIndex = 6;
            this.TrackBar_Rows.Value = 1;
            this.TrackBar_Rows.Scroll += new System.EventHandler(this.TrackBar_Rows_Scroll);
            // 
            // TrackBar_Columns
            // 
            this.TrackBar_Columns.Location = new System.Drawing.Point(136, 577);
            this.TrackBar_Columns.Maximum = 8;
            this.TrackBar_Columns.Minimum = 1;
            this.TrackBar_Columns.Name = "TrackBar_Columns";
            this.TrackBar_Columns.Size = new System.Drawing.Size(838, 56);
            this.TrackBar_Columns.TabIndex = 7;
            this.TrackBar_Columns.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.TrackBar_Columns.Value = 1;
            this.TrackBar_Columns.Scroll += new System.EventHandler(this.TrackBar_Columns_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(521, 614);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Columns";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(47, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 80);
            this.label4.TabIndex = 9;
            this.label4.Text = "R\r\no\r\nw\r\ns";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Button_Browse_Img_Path
            // 
            this.Button_Browse_Img_Path.Location = new System.Drawing.Point(419, 41);
            this.Button_Browse_Img_Path.Name = "Button_Browse_Img_Path";
            this.Button_Browse_Img_Path.Size = new System.Drawing.Size(75, 23);
            this.Button_Browse_Img_Path.TabIndex = 10;
            this.Button_Browse_Img_Path.Text = "Browse";
            this.Button_Browse_Img_Path.UseVisualStyleBackColor = true;
            this.Button_Browse_Img_Path.Click += new System.EventHandler(this.Button_Img_Path_Click);
            // 
            // Button_Browse_Save_Path
            // 
            this.Button_Browse_Save_Path.Location = new System.Drawing.Point(419, 79);
            this.Button_Browse_Save_Path.Name = "Button_Browse_Save_Path";
            this.Button_Browse_Save_Path.Size = new System.Drawing.Size(75, 23);
            this.Button_Browse_Save_Path.TabIndex = 11;
            this.Button_Browse_Save_Path.Text = "Browse";
            this.Button_Browse_Save_Path.UseVisualStyleBackColor = true;
            this.Button_Browse_Save_Path.Click += new System.EventHandler(this.Button_Save_Path_Click);
            // 
            // TextBox_Img_Path
            // 
            this.TextBox_Img_Path.Location = new System.Drawing.Point(102, 42);
            this.TextBox_Img_Path.Name = "TextBox_Img_Path";
            this.TextBox_Img_Path.ReadOnly = true;
            this.TextBox_Img_Path.Size = new System.Drawing.Size(311, 22);
            this.TextBox_Img_Path.TabIndex = 12;
            // 
            // TextBox_Save_Path
            // 
            this.TextBox_Save_Path.Location = new System.Drawing.Point(102, 80);
            this.TextBox_Save_Path.Name = "TextBox_Save_Path";
            this.TextBox_Save_Path.ReadOnly = true;
            this.TextBox_Save_Path.Size = new System.Drawing.Size(311, 22);
            this.TextBox_Save_Path.TabIndex = 13;
            // 
            // TextBox_Num_Cols
            // 
            this.TextBox_Num_Cols.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.TextBox_Num_Cols.Location = new System.Drawing.Point(136, 614);
            this.TextBox_Num_Cols.Name = "TextBox_Num_Cols";
            this.TextBox_Num_Cols.ReadOnly = true;
            this.TextBox_Num_Cols.Size = new System.Drawing.Size(18, 21);
            this.TextBox_Num_Cols.TabIndex = 14;
            this.TextBox_Num_Cols.Text = "1";
            // 
            // TextBox_Num_Rows
            // 
            this.TextBox_Num_Rows.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.TextBox_Num_Rows.Location = new System.Drawing.Point(53, 550);
            this.TextBox_Num_Rows.Name = "TextBox_Num_Rows";
            this.TextBox_Num_Rows.ReadOnly = true;
            this.TextBox_Num_Rows.Size = new System.Drawing.Size(18, 21);
            this.TextBox_Num_Rows.TabIndex = 15;
            this.TextBox_Num_Rows.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 676);
            this.Controls.Add(this.TextBox_Num_Rows);
            this.Controls.Add(this.TextBox_Num_Cols);
            this.Controls.Add(this.TextBox_Save_Path);
            this.Controls.Add(this.TextBox_Img_Path);
            this.Controls.Add(this.Button_Browse_Save_Path);
            this.Controls.Add(this.Button_Browse_Img_Path);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TrackBar_Columns);
            this.Controls.Add(this.TrackBar_Rows);
            this.Controls.Add(this.Button_Accept);
            this.Controls.Add(this.PictureBox_Image);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Image Divider";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Columns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PictureBox_Image;
        private System.Windows.Forms.Button Button_Accept;
        private System.Windows.Forms.TrackBar TrackBar_Rows;
        private System.Windows.Forms.TrackBar TrackBar_Columns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button_Browse_Img_Path;
        private System.Windows.Forms.Button Button_Browse_Save_Path;
        private System.Windows.Forms.TextBox TextBox_Img_Path;
        private System.Windows.Forms.TextBox TextBox_Save_Path;
        private System.Windows.Forms.TextBox TextBox_Num_Cols;
        private System.Windows.Forms.TextBox TextBox_Num_Rows;
    }
}