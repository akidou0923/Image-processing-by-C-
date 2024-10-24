using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Processing_Folder
{
    public partial class Image_Processing : Form
    {
        private Bitmap bt2;
        private Bitmap bt3;

        public BitmapData originalData { get; private set; }
        public BitmapData NewData { get; private set; }

        private Bitmap bt1;

        public Bitmap originalBt { get; private set; }

        public Image_Processing()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();//定义一个打开文件类/Define an open file class
            ofd.Filter = "所有文件(*.*)|*.*|Jpeg文件(*.jpg)|*.jpg|PNG文件|*.png";//判断是否为指定类型的图像文件/Determine whether it is an image file of a specified type
            ofd.FilterIndex = 2; //打开文件的对话框将弹出，供使用者选择/A dialog box to open the file will pop up for the user to choose
            if (ofd.ShowDialog() == DialogResult.OK) //如果选择了某个文件，并点击了OK后，那么将选择的文件返回/If you select a file and click OK, the selected file will be returned
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(ofd.FileName.ToString());//将图像文件赋给图片框“pictureBox1”/Assign the image file to the picture box "pictureBox1"

            }
            originalBt = new Bitmap(pictureBox1.Image);//将图片框内的图像赋给一个位图变量对象“originalBt”以用于后续处理/The image in the picture box is assigned to a bitmap variable object "originalBt" for subsequent processing

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //如果选择了某个文件夹并取了一个合法的文件名，并点击了“OK”/If you select a folder, take a legal file name, and click "OK"
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName); //保存文件到指定的文件夹/Save the file to the specified folder
            }

        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("错误，没有导入图片！");//判断图片框是否有图片，如果无图片，则给出错误信息/Determine whether there is a picture in the picture box, and if there is no picture, give an error message
                return;
            }
            Bitmap bt = new Bitmap(pictureBox1.Image);
            Bitmap bt1 = new Bitmap(pictureBox1.Image); //定义并初始化两个位图对象/Define and initialize two bitmap objects
            Color color = new Color();//定义一个颜色对象/Define a color object
            for (int i = 0; i < bt.Width; i++)
            {
                for (int j = 0; j < bt.Height; j++)
                {
                    color = bt.GetPixel(i, j); //遍历整张图像，获取每个像素的色彩信息/Traverse the entire image to obtain color information for each pixel
                    int n = (int)((color.G * 59 + color.R * 30 + color.B * 11) / 100); //根据GRB的不同的权值计算每个像素点的亮度，利用该亮度作为灰度图像中每个像素的灰度值/The brightness of each pixel is calculated according to the different weights of the GRB, and the brightness is used as the gray value of each pixel in the gray image
                    bt1.SetPixel(i, j, Color.FromArgb(n, n, n)); //给该像素的每种色彩分量均赋予相同的灰度值，完成灰度图像的转换/Each color component of the pixel is assigned the same gray value to complete the conversion of the gray image
                }
                pictureBox1.Refresh();//刷新图片框/Refresh picture box
                pictureBox1.Image = bt1;
            }

        }
        private void Light_trackBar_Scroll(object sender, EventArgs e)
        {
            textBox_Light.Text = Light_trackBar.Value.ToString();
        }

        private void btnlight_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Error！No Pictures！");
                return;
            }
            int value = int.Parse(textBox_Light.Text);
            Bitmap bt = new Bitmap(pictureBox1.Image);
            Bitmap bt1 = new Bitmap(pictureBox1.Image);
            int r, g, b;
            for (int i = 0; i < bt1.Width; i++)
            {
                for (int j = 0; j < bt1.Height; j++)
                {
                    Color color = bt.GetPixel(i, j);
                    r = color.R;
                    g = color.G;
                    b = color.B;
                    r += value;
                    g += value;
                    b += value;
                    if (r > 255) r = 255;
                    if (r < 0) r = 0;
                    if (g > 255) g = 255;
                    if (g < 0) g = 0;
                    if (b > 255) b = 255;
                    if (b < 0) b = 0;
                    Color c1 = Color.FromArgb(r, g, b);
                    bt1.SetPixel(i, j, c1);
                }
                pictureBox2.Refresh();
                pictureBox2.Image = bt1;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void duibi_trackBar_Scroll(object sender, EventArgs e)
        {
            textBox_Duibi.Text = duibi_trackBar.Value.ToString();
        }

        private void btnDuibi_Click(object sender, EventArgs e)
        {
            Bitmap originalBt = new Bitmap(pictureBox1.Image);
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Error！No Pictures！");
                return;
            }
            int degree = int.Parse(textBox_Duibi.Text);
            int r, g, b;
            Bitmap bt = originalBt;
            Bitmap bt1 = new Bitmap(pictureBox1.Image);
            for (int i = 0; i < bt1.Width; i++)
            {
                for (int j = 0; j < bt1.Height; j++)
                {
                    Color c = bt.GetPixel(i, j);
                    r = c.R;
                    g = c.G;
                    b = c.B;
                    int rg = (Math.Abs(127 - r) * degree) / 255;
                    int gg = (Math.Abs(127 - r) * degree) / 255;
                    int bg = (Math.Abs(127 - r) * degree) / 255;
                    if (r > 127) r = r + rg;
                    else r = r - rg;
                    if (g > 127) g = g + gg;
                    else g = g - gg;
                    if (b > 127) b = b + bg;
                    else b = b - bg;
                    if (r > 255) r = 255;
                    if (r < 0) r = 0;
                    if (g > 255) g = 255;
                    if (g < 0) g = 0;
                    if (b > 255) b = 255;
                    if (b < 0) b = 0;
                    Color c1 = Color.FromArgb(r, g, b);
                    bt1.SetPixel(i, j, c1);
                }
                pictureBox2.Refresh();
                pictureBox2.Image = bt1;
            }
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            Color ColorOrigin = new Color();//定义一个色彩变量对象/Define a color variable object
            double Red, Green, Blue, Y; //定义红、绿、蓝三色和亮度/Define red, green, blue colors and brightness
            Bitmap Bmp1 = new Bitmap(pictureBox1.Image); //定义一个位图文件并将图片框内的图像赋值给它/Define a bitmap file and assign the image in the picture box to it
            int brightThreshole = new int();//定义整型的二值化阈值/Define binarization thresholds for integer types
            brightThreshole = trackBar_Binary.Value;
            for (int i = 0; i <= pictureBox1.Image.Width - 1; i++)
            {
                for (int j = 0; j <= pictureBox1.Image.Height - 1; j++)//循环处理图像中的每一个像素点/Loop every pixel in the image
                {
                    ColorOrigin = originalBt.GetPixel(i, j); //获取当前像素点的色彩信息/Obtain color information of the current pixel
                    Red = ColorOrigin.R; //获取当前像素点的红色分量/Gets the red component of the current pixel
                    Green = ColorOrigin.G; //获取当前像素点的绿色分量/Gets the green component of the current pixel
                    Blue = ColorOrigin.B; //获取当前像素点的蓝色分量/Gets the blue component of the current pixel
                    Y = 0.59 * Red + 0.3 * Green + 0.11 * Blue; //计算当前像素点的亮度/Calculate the brightness of the current pixel
                    if (Y > brightThreshole) //如果当前像素点的亮度大于指定阈值/If the brightness of the current pixel is greater than the specified threshold
                    {
                        Color ColorProcessed = Color.FromArgb(255, 255, 255); //那么定义一个纯白的色彩变量，即各分量均为255/If the brightness of the current pixel is greater than the specified threshold
                        Bmp1.SetPixel(i, j, ColorProcessed); //将白色变量赋给当前像素点/Assign the white variable to the current pixel
                    }
                    if (Y <= brightThreshole) //如果当前像素点的亮度小于指定阈值/Assign the white variable to the current pixel
                    {
                        Color ColorProcessed = Color.FromArgb(0, 0, 0); //那么定义一个纯黑的色彩变量，即各分量均为0/Then define a pure black color variable, that is, each component is 0
                        Bmp1.SetPixel(i, j, ColorProcessed); //将黑色变量赋给当前像素点/Then define a pure black color variable, that is, each component is 0
                    }
                }
                pictureBox1.Refresh();//刷新图片框/Refresh picture box
                pictureBox1.Image = Bmp1; //将重新生成的图片赋值给图片框/Assign the regenerated image to the image box
            }
        }

        private void trackBar_Binary_Scroll(object sender, EventArgs e)
        {
            textBox_Binary.Text = trackBar_Binary.Value.ToString();
        }



        private void btnBesmall_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Error!No Pictures!");
                return;
            }
            Bitmap bt1 = new Bitmap(pictureBox1.Image);
            Bitmap bt2 = (Bitmap)bt1.Clone();
            double rW = int.Parse(textBox_Besmall.Text);
            double rH = int.Parse(textBox_Besmall.Text);

            //判定缩放值
            if (rW == 0)
            {
                MessageBox.Show("缩放量不能为0/Zoom amount cannot be 0！");
                return;
            }
            if ((rW == 1.0) && rH == 1.0)
            {
                bt2 = new Bitmap(bt1);
                pictureBox2.Image = bt2;
                return;
            }
            if (rW < 0)
            {
                rW = (10 - Math.Abs(rW)) / 10;
                rH = (10 - Math.Abs(rH)) / 10;
            }
                
            double height = rH * (double)bt1.Height;//计算缩放后的图像大小/Calculate the size of the zoomed image
            double width = rW * (double)bt1.Width;
            bt2 = new Bitmap((int)width, (int)height);
            BitmapData bt1Data = bt1.LockBits(new Rectangle(0, 0, bt1.Width, bt1.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bt2Data = bt2.LockBits(new Rectangle(0, 0, bt2.Width, bt2.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            //最邻近像元插值/Nearest neighbor pixel interpolation
            unsafe
            {
                byte* srcPtr = null;
                byte* dstPtr = null;
                int srcI = 0;               
                for (int i = 0; i < bt2.Height; i++)
                {
                    srcI = (int)(i / rH);//srcI是此时的i对应的原图像的高/srcI is the height of the original image corresponding to i at this time
                    srcPtr = (byte*)bt1Data.Scan0 + srcI * bt1Data.Stride;
                    dstPtr = (byte*)bt2Data.Scan0 + i * bt2Data.Stride;
                    for (int j = 0; j < bt2.Width; j++)
                    {
                        dstPtr[j * 3] = srcPtr[(int)(j / rW) * 3];//j / rW求出此时j对应的原图像的宽/j / rW Find the width of the original image corresponding to j at this time
                        dstPtr[j * 3 + 1] = srcPtr[(int)(j / rW) * 3 + 1];
                        dstPtr[j * 3 + 2] = srcPtr[(int)(j / rW) * 3 + 2];
                    }
                }
                bt1.UnlockBits(bt1Data);
                bt2.UnlockBits(bt2Data);
                pictureBox2.Image = bt2;
            }
            原图 sfqtx = new 原图();
            sfqtx.pictureBox1.Image = pictureBox1.Image;
            sfqtx.ShowDialog();

            新图 sfhtx = new 新图();
            sfhtx.pictureBox1.Image = pictureBox2.Image;
            sfhtx.ShowDialog();
        }

        private void trackBar_Besmall_Scroll(object sender, EventArgs e)
        {
            textBox_Besmall.Text = trackBar_Besmall.Value.ToString();
        }


        public void BinaryDilation()//二值图像的膨胀函数(膨胀白色)/Dilation function of binary image (Dilated white)
        {
            int R;
            for (int i = 1; i < bt1.Width - 1; i++)
            {
                for (int j = 1; j < bt1.Height - 1; j++)
                {
                    R = bt1.GetPixel(i, j).R;
                    if (R == 255)
                    {
                        bt2.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                        bt2.SetPixel(i - 1, j - 1, Color.FromArgb(255, 255, 255));
                        bt2.SetPixel(i, j - 1, Color.FromArgb(255, 255, 255));
                        bt2.SetPixel(i + 1, j - 1, Color.FromArgb(255, 255, 255));
                        bt2.SetPixel(i - 1, j, Color.FromArgb(255, 255, 255));
                        bt2.SetPixel(i + 1, j, Color.FromArgb(255, 255, 255));
                        bt2.SetPixel(i - 1, j + 1, Color.FromArgb(255, 255, 255));
                        bt2.SetPixel(i, j + 1, Color.FromArgb(255, 255, 255));
                        bt2.SetPixel(i + 1, j + 1, Color.FromArgb(255, 255, 255));
                    }
                }
                pictureBox2.Refresh();//刷新图片框/Refresh picture box
                pictureBox2.Image = bt2;
            }
        }
        public void BinaryErosion()//二值图像的腐蚀函数(腐蚀白色)/Refresh picture box
        {
            int R1, R2, R3;
            for (int i = 0; i < bt1.Width - 1; i++)
            {
                for (int j = 0; j < bt1.Height - 1; j++)
                {
                    R1 = bt1.GetPixel(i, j).R;
                    if (R1 == 255)
                    {
                        R2 = bt1.GetPixel(i, j + 1).R;
                        R3 = bt1.GetPixel(i + 1, j).R;
                        if (R2 == 255 && R3 == 255)
                        {
                            bt2.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                        }
                        else
                        {
                            bt2.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                        }
                    }
                }
                pictureBox2.Refresh();//刷新图片框/Refresh picture box
                pictureBox2.Image = bt2;
            }
        }

        private void 开启ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 开启ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Error!No Pictures!！");//判断图片框是否有图片，如果无图片，则给出错误信息/Determine whether there is a picture in the picture box, and if there is no picture, give an error message
                return;
            }
            bt1 = new Bitmap(pictureBox1.Image);
            bt2 = new Bitmap(pictureBox1.Image); //定义两个位图对象/Define two bitmap objects
            BinaryErosion(); //先腐蚀/Erosion first
            bt1 = new Bitmap(pictureBox2.Image);
            bt2 = new Bitmap(pictureBox2.Image);
            BinaryDilation(); //再膨胀/Dilation then
        }

        private void 闭合ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Error!No Pictures!！");//判断图片框是否有图片，如果无图片，则给出错误信息/Determine whether there is a picture in the picture box, and if there is no picture, give an error message
                return;
            }
            bt1 = new Bitmap(pictureBox1.Image);
            bt2 = new Bitmap(pictureBox1.Image); //定义两个位图对象//Define two bitmap objects
            BinaryDilation(); //先膨胀
            bt1 = new Bitmap(pictureBox2.Image);
            bt2 = new Bitmap(pictureBox2.Image);
            BinaryErosion(); //再腐蚀
        }

        private void 边缘提取ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 高斯噪声ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Error!No Pictures!");
                return;
            }
            Bitmap bt1 = new Bitmap(pictureBox1.Image);
            Bitmap bt2 = new Bitmap(pictureBox1.Image);
            Random random = new Random();
            Random rd = new Random();
            for (int i = 0; i < bt1.Width; i++)
            {
                for (int j = 0; j < bt1.Height; j++)
                {
                    int R, G, B;
                    double ran = random.NextDouble();
                    R = bt1.GetPixel(i, j).R;
                    G = bt1.GetPixel(i, j).G;
                    B = bt1.GetPixel(i, j).B;
                    if (ran > 0.98)
                    {
                        R = rd.Next(0, 255);
                        G = rd.Next(0, 255);
                        B = rd.Next(0, 255);
                        R = (int)((G * 59 + R * 30 + B * 11) / 100);
                        G = (int)((G * 59 + R * 30 + B * 11) / 100);
                        B = (int)((G * 59 + R * 30 + B * 11) / 100);
                    }
                    if (ran < 0.02)
                    {
                        R = rd.Next(0, 255);
                        G = rd.Next(0, 255);
                        B = rd.Next(0, 255);
                        R = (int)((G * 59 + R * 30 + B * 11) / 100);
                        G = (int)((G * 59 + R * 30 + B * 11) / 100);
                        B = (int)((G * 59 + R * 30 + B * 11) / 100);
                    }
                    bt2.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
                pictureBox2.Refresh();
                pictureBox2.Image = bt2;
            }
        }

        private void 四邻域平均ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Error!No Pictures!");
                return;
            }
            Bitmap bt1 = new Bitmap(pictureBox2.Image);
            Bitmap bt2 = new Bitmap(pictureBox2.Image);
            int R1, R2, R3, R4, Red;
            int G1, G2, G3, G4, Green;
            int B1, B2, B3, B4, Blue;
            for (int i = 1; i < bt1.Width - 1; i++)
            {
                for (int j = 1; j < bt1.Height - 1; j++)
                {
                    R1 = bt1.GetPixel(i, j - 1).R;
                    R2 = bt1.GetPixel(i, j + 1).R;
                    R3 = bt1.GetPixel(i - 1, j).R;
                    R4 = bt1.GetPixel(i + 1, j).R;
                    Red = (R1 + R2 + R3 + R4) / 4;

                    G1 = bt1.GetPixel(i, j - 1).G;
                    G2 = bt1.GetPixel(i, j + 1).G;
                    G3 = bt1.GetPixel(i - 1, j).G;
                    G4 = bt1.GetPixel(i + 1, j).G;
                    Green = (G1 + G2 + G3 + G4) / 4;

                    B1 = bt1.GetPixel(i, j - 1).B;
                    B2 = bt1.GetPixel(i, j + 1).B;
                    B3 = bt1.GetPixel(i - 1, j).B;
                    B4 = bt1.GetPixel(i + 1, j).B;
                    Blue = (B1 + B2 + B3 + B4) / 4;

                    bt2.SetPixel(i, j, Color.FromArgb(Red, Green, Blue));
                }
                pictureBox2.Refresh();
                pictureBox2.Image = bt2;
            }

        }

        private void 八邻域平均ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Error!No Pictures!");
                return;
            }
            bt1 = new Bitmap(pictureBox2.Image);
            bt2 = new Bitmap(pictureBox2.Image); //定义两个位图对象
            int R1, R2, R3, R4, R5, R6, R7, R8, Red;
            int G1, G2, G3, G4, G5, G6, G7, G8, Green;
            int B1, B2, B3, B4, B5, B6, B7, B8, Blue;
            for (int i = 1; i < bt1.Width - 1; i++)
            {
                for (int j = 1; j < bt1.Height - 1; j++)
                {
                    R1 = bt1.GetPixel(i - 1, j - 1).R;
                    R2 = bt1.GetPixel(i, j - 1).R;
                    R3 = bt1.GetPixel(i + 1, j - 1).R;
                    R4 = bt1.GetPixel(i - 1, j).R;
                    R5 = bt1.GetPixel(i + 1, j).R;
                    R6 = bt1.GetPixel(i - 1, j + 1).R;
                    R7 = bt1.GetPixel(i, j + 1).R;
                    R8 = bt1.GetPixel(i + 1, j + 1).R;
                    Red = (int)(R1 + R2 + R3 + R4 + R5 + R6 + R7 + R8) / 8;
                    G1 = bt1.GetPixel(i - 1, j - 1).G;
                    G2 = bt1.GetPixel(i, j - 1).G;
                    G3 = bt1.GetPixel(i + 1, j - 1).G;
                    G4 = bt1.GetPixel(i - 1, j).G;
                    G5 = bt1.GetPixel(i + 1, j).G;
                    G6 = bt1.GetPixel(i - 1, j + 1).G;
                    G7 = bt1.GetPixel(i, j + 1).G;
                    G8 = bt1.GetPixel(i + 1, j + 1).G;
                    Green = (int)(G1 + G2 + G3 + G4 + G5 + G6 + G7 + G8) / 8;
                    B1 = bt1.GetPixel(i - 1, j - 1).B;
                    B2 = bt1.GetPixel(i, j - 1).B;
                    B3 = bt1.GetPixel(i + 1, j - 1).B;
                    B4 = bt1.GetPixel(i - 1, j).B;
                    B5 = bt1.GetPixel(i + 1, j).B;
                    B6 = bt1.GetPixel(i - 1, j + 1).B;
                    B7 = bt1.GetPixel(i, j + 1).B;
                    B8 = bt1.GetPixel(i + 1, j + 1).B;
                    Blue = (int)(B1 + B2 + B3 + B4 + B5 + B6 + B7 + B8) / 8;
                    bt2.SetPixel(i, j, Color.FromArgb(Red, Green, Blue));
                }
                pictureBox2.Refresh();//刷新图片框
                pictureBox2.Image = bt2;
            }
        }

        private void 最大值滤波ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Error!No Pictures!");
                return;
            }
            Color c = new Color();
            bt1 = new Bitmap(pictureBox2.Image);
            bt2 = new Bitmap(pictureBox2.Image);
            int rr, r1;
            //扫描图像的每个像素/Scan every pixel of the image
            for (int i = 1; i < bt1.Width - 1; i++)
            {
                for (int j = 1; j < bt1.Height - 1; j++)
                {
                    rr = 0; //设定一个0初值，取邻域中的每个值与它比较，哪个更大就赋值给它/Set an initial value of 0, compare each value in the neighborhood with it, and assign it to whichever is larger
                            //为了处理3×3的像素块设置一个循环，实际就是实现8邻域的最大值滤波/To process a 3×3 pixel block, setting up a loop is actually to achieve maximum filtering in 8 neighborhoods
                    for (int m = -1; m < 2; m++)
                    {
                        for (int n = -1; n < 2; n++)
                        {
                            //获取该坐标的像素/Gets the pixel of this coordinate
                            c = bt1.GetPixel(i + m, j + n);
                            r1 = c.R;
                            if (r1 > rr)
                                rr = r1;
                        }
                    }
                    bt2.SetPixel(i, j, Color.FromArgb(rr, rr, rr));
                }
                pictureBox2.Refresh();
                pictureBox2.Image = bt2;
            }
        }

        private void 最小值滤波ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Error!No Pictures!");
                return;
            }
            Color c = new Color();
            bt1 = new Bitmap(pictureBox2.Image);
            bt2 = new Bitmap(pictureBox2.Image);
            int rr, r1;
            //扫描图像的每个像素/Scan every pixel of the image
            for (int i = 1; i < bt1.Width - 1; i++)
            {
                for (int j = 1; j < bt1.Height - 1; j++)
                {
                    rr = 255; //设定一个255初值，取邻域中的每个值与它比较，哪个更小就赋值给它/Set an initial value of 255, compare it with every value in the neighborhood, and assign it to whichever is smaller
                              //为了处理3×3的像素块设置一个循环，实际就是实现8邻域的最小值滤波/Set an initial value of 255, compare it with every value in the neighborhood, and assign it to whichever is smaller
                    for (int m = -1; m < 2; m++)
                    {
                        for (int n = -1; n < 2; n++)
                        {
                            //获取该坐标的像素/Gets the pixel of this coordinate
                            c = bt1.GetPixel(i + m, j + n);
                            r1 = c.R;
                            if (r1 < rr)
                                rr = r1;
                        }
                    }
                    bt2.SetPixel(i, j, Color.FromArgb(rr, rr, rr));
                }
                pictureBox2.Refresh();
                pictureBox2.Image = bt2;
            }
        }

        private void 中值滤波ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Error!No Pictures!");
                return;
            }
            Color c = new Color();
            bt1 = new Bitmap(pictureBox2.Image);
            bt2 = new Bitmap(pictureBox2.Image);
            int rr, r1, dm, m;
            //设置一个数组用于储存3×3像素快的r分量值/Set up an array to store the r-component values of 3×3 pixels fast
            int[] dt = new int[20];
            for (int i = 1; i < bt1.Width - 1; i++)
            {
                for (int j = 1; j < bt1.Height - 1; j++)
                {
                    rr = 0; m = 0;
                    for (int k = -1; k < 2; k++)
                    {
                        for (int n = -1; n < 2; n++)
                        {
                            //获取该坐标的像素并存入数组dt[]中/Get the pixel of this coordinate and store it in the array dt[]
                            c = bt1.GetPixel(i + k, j + n);
                            r1 = c.R;
                            dt[m++] = r1;
                        }
                    }
                    for (int p = 0; p < m - 1; p++)
                    {
                        for (int q = p + 1; q < m; q++)
                        {
                            //对存与数组里的数据进行从大到小的排序/Sort the data in the storage and array from large to small
                            if (dt[p] > dt[q])
                            {
                                dm = dt[p];
                                dt[p] = dt[q];
                                dt[q] = dm;
                            }
                        }
                    }
                    //获取数值所有存储数据的中间值/Gets the intermediate value of all stored data
                    rr = dt[(int)(m / 2)];
                    bt2.SetPixel(i, j, Color.FromArgb(rr, rr, rr));
                }
                pictureBox2.Refresh();
                pictureBox2.Image = bt2;
            }
        }

        private void 修正平均滤波ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Error!No Pictures!");
                return;
            }
            Color c = new Color();
            bt1 = new Bitmap(pictureBox2.Image);
            bt2 = new Bitmap(pictureBox2.Image);
            int rr, r1, dm, m;
            //设置一个数组用于储存3×3像素快的r分量值/Set up an array to store the r-component values of 3×3 pixels fast
            int[] dt = new int[20];
            for (int i = 1; i < bt1.Width - 1; i++)
            {
                for (int j = 1; j < bt1.Height - 1; j++)
                {
                    rr = 0; m = 0;
                    for (int k = -1; k < 2; k++)
                    {
                        for (int n = -1; n < 2; n++)
                        {
                            //获取该坐标的像素/Set up an array to store the r-component values of 3×3 pixels fast
                            c = bt1.GetPixel(i + k, j + n);
                            r1 = c.R;
                            dt[m] = r1;
                            m++;
                        }
                    }
                    for (int p = 0; p < m - 1; p++)
                    {
                        for (int q = p + 1; q < m; q++)
                        {
                            //对存与数组里的数据进行从大到小的排序/Sort the data in the storage and array from large to small
                            if (dt[p] > dt[q])
                            {
                                dm = dt[p];
                                dt[p] = dt[q];
                                dt[q] = dm;
                            }
                        }
                    }
                    //获取去掉最大、最小值后的所有数的平均值，即修正后的平均值/Gets the average of all numbers after removing the maximum and minimum values, that is, the revised average
                    for (int l = 1; l < m - 1; l++)
                        rr += dt[l];
                    rr = (int)(rr / (m - 2));
                    bt2.SetPixel(i, j, Color.FromArgb(rr, rr, rr));
                }
                pictureBox2.Refresh();
                pictureBox2.Image = bt2;
            }
        }

        private void btnHSI_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Error!No Pictures!");
                return;
            }
            Color color = new Color();
            饱和度 bhd = new 饱和度();
            if (bhd.ShowDialog() == DialogResult.OK)
            {
                bt2 = new Bitmap(pictureBox1.Image);
                bt1 = new Bitmap(pictureBox1.Image);
                int H = bhd.trackBarH.Value;
                int S = bhd.trackBarS.Value;
                int I = bhd.trackBarI.Value;
                int Red, Green, Blue;
                double Hudu = Math.PI / 180;
                if (H >= 0 && H <= 120)
                {
                    for (int i = 0; i < bt1.Width; i++)
                    {
                        for (int j = 0; j < bt1.Height; j++)
                        {
                            int R, G, B;
                            color = bt1.GetPixel(i, j);
                            R = color.R;
                            G = color.G;
                            B = color.B;
                            Blue = B + (I * (I - S) / 5); //根据转换公式，在原各RGB分量基础上加上调整的值/According to the conversion formula, add the adjusted values to the original RGB components
                            Red = (int)(R + (I * (1 + (S * Math.Cos(H * Hudu) / (Math.Cos((60 - H) * Hudu))))) / 5);
                            Green = G + (3 * I - (Blue + Red) / 5);
                            if (Red > 255) Red = 255; //判断是否超出各分量允许的范围，如果大于255则只能等于255/Determine whether it exceeds the allowable range of each component. If it is greater than 255, it can only be equal to 255.
                            if (Red < 0) Red = 0; //如果小于0则只能等于0/If less than 0, it can only be equal to 0
                            if (Green > 255) Green = 255;
                            if (Green < 0) Green = 0;
                            if (Blue > 255) Blue = 255;
                            if (Blue < 0) Blue = 0;
                            bt2.SetPixel(i, j, Color.FromArgb(Red, Green, Blue));
                        }
                        pictureBox2.Refresh();
                        pictureBox2.Image = bt2;
                    }
                }
                if (H > 120 && H <= 240)
                {
                    for (int i = 0; i < bt1.Width; i++)
                    {
                        for (int j = 0; j < bt1.Height; j++)
                        {
                            int R, G, B;
                            color = bt1.GetPixel(i, j);
                            R = color.R;
                            G = color.G;
                            B = color.B;
                            Red = R + (I * (I - S)); //根据转换公式，在原各RGB分量基础上加上调整的值/According to the conversion formula, add the adjusted values to the original RGB components
                            Green = (int)(G + I * (1 + (S * Math.Cos((H - 120) * Hudu) / (Math.Cos((180 - H) * Hudu)))));
                            Blue = B + 3 * I - (Green + Red);
                            if (Red > 255) Red = 255; //判断是否超出各分量允许的范围，如果大于255则只能等于255
                            if (Red < 0) Red = 0; //如果小于0则只能等于0
                            if (Green > 255) Green = 255;
                            if (Green < 0) Green = 0;
                            if (Blue > 255) Blue = 255;
                            if (Blue < 0) Blue = 0;
                            bt2.SetPixel(i, j, Color.FromArgb(Red, Green, Blue));
                        }
                        pictureBox2.Refresh();
                        pictureBox2.Image = bt2;
                    }
                }
                if (H > 240 && H <= 360)
                {
                    for (int i = 0; i < bt1.Width; i++)
                    {
                        for (int j = 0; j < bt1.Height; j++)
                        {
                            int R, G, B;
                            color = bt1.GetPixel(i, j);
                            R = color.R;
                            G = color.G;
                            B = color.B;
                            Green = G + I * (I - S); //根据转换公式，在原各RGB分量基础上加上调整的值
                            Blue = (int)(B + I * (1 + (S * Math.Cos((H - 120) * Hudu) / (Math.Cos((300 - H) * Hudu)))));
                            Red = R + 3 * I - (Blue + Green);
                            if (Red > 255) Red = 255; //判断是否超出各分量允许的范围，如果大于255则只能等于255
                            if (Red < 0) Red = 0; //如果小于0则只能等于0
                            if (Green > 255) Green = 255;
                            if (Green < 0) Green = 0;
                            if (Blue > 255) Blue = 255;
                            if (Blue < 0) Blue = 0;
                            bt2.SetPixel(i, j, Color.FromArgb(Red, Green, Blue));
                        }
                        pictureBox2.Refresh();//另外建立了一个图片框用于显示处理后的图像
                        pictureBox2.Image = bt2;
                    }
                }
            }
        }

        private void 二值图像边缘提取ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Error!No Pictures!！");//判断图片框是否有图片，如果无图片，则给出错误信息
                return;
            }
            bt1 = new Bitmap(pictureBox1.Image);
            bt2 = new Bitmap(pictureBox1.Image); //定义两个位图对象
            Bitmap bt3 = new Bitmap(pictureBox1.Image);
            BinaryErosion(); //先腐蚀
            bt1 = new Bitmap(pictureBox2.Image);
            bt2 = new Bitmap(pictureBox2.Image);
            int R1, R2, R3;
            for (int i = 0; i < bt1.Width; i++)
            {
                for (int j = 0; j < bt1.Height; j++)
                {
                    R1 = bt1.GetPixel(i, j).R;
                    R2 = bt3.GetPixel(i, j).R;
                    R3 = R2 - R1;
                    if (R3 <= 0) R3 = 255;
                    else R3 = 0;
                    bt2.SetPixel(i, j, Color.FromArgb(R3, R3, R3));
                }
                pictureBox2.Refresh();//刷新图片框
                pictureBox2.Image = bt2;
            }
        }

        private void robert算子ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Error!No Pictures!！");//判断图片框是否有图片，如果无图片，则给出错误信息
                return;
            }
            int Height = pictureBox1.Image.Height;
            int Width = pictureBox1.Image.Width;
            bt1 = new Bitmap(Width, Height, PixelFormat.Format24bppRgb);
            bt2 = new Bitmap(pictureBox1.Image);
            originalData = bt2.LockBits(new Rectangle(0, 0, Width, Height), System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            NewData = bt1.LockBits(new Rectangle(0, 0, Width, Height), System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* pin_1 = (byte*)(originalData.Scan0.ToPointer());
                byte* pin_2 = pin_1 + (originalData.Stride);
                byte* pout = (byte*)(NewData.Scan0.ToPointer());
                for (int y = 0; y < originalData.Height - 1; y++)
                {
                    for (int x = 0; x < originalData.Width - 1; x++)
                    {
                        //robert算子
                        double b = System.Math.Sqrt(((double)pin_1[0] - (double)(pin_2[0] + 3)) * ((double)pin_1[0]));
                        double g = System.Math.Sqrt(((double)pin_1[0] - (double)(pin_2[0] + 3)) * ((double)pin_1[0]));
                        double r = System.Math.Sqrt(((double)pin_1[2] - (double)(pin_2[2] + 3)) * ((double)pin_1[2] - (double)(pin_2[2] + 3)) + ((double)(pin_1[2] + 3) - (double)pin_2[2]) * ((double)(pin_1[2] + 3) - (double)pin_2[2]));
                        double bgr = b + g + r;
                        if (bgr > 90) //阈值，超过阈值判定为边缘（选取适当的阈值）
                        {
                            b = 0;
                            g = 0;
                            r = 0;
                        }
                        else
                        {
                            b = 255;
                            g = 255;
                            r = 255;
                        }
                        pout[0] = (byte)(b);
                        pout[1] = (byte)(g);
                        pout[2] = (byte)(r);
                        pin_1 = pin_1 + 3;
                        pin_2 = pin_2 + 3;
                        pout = pout + 3;
                    }
                    pin_1 += originalData.Stride - originalData.Width * 3;
                    pin_2 += originalData.Stride - originalData.Width * 3;
                    pout += NewData.Stride - NewData.Width * 3;
                }
                bt1.UnlockBits(NewData);
                bt2.UnlockBits(originalData);
                pictureBox2.Image = bt1;
            }
        }

        private void 水平差分算法ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Error!No Pictures!");
                return;
            }
            bt1 = new Bitmap(pictureBox1.Image);
            bt2 = new Bitmap(pictureBox1.Image);
            int R, G, B;
            int R1, R2, R3, R4;
            int G1, G2, G3, G4;
            int B1, B2, B3, B4;
            for (int i = 0; i < bt1.Width - 1; i++)
            {
                for (int j = 0; j < bt1.Height - 1; j++)
                {
                    R = bt1.GetPixel(i, j).R;
                    G = bt1.GetPixel(i, j).G;
                    B = bt1.GetPixel(i, j).B;
                    R1 = bt1.GetPixel(i, j).R;
                    R2 = bt1.GetPixel(i + 1, j).R;
                    R3 = bt1.GetPixel(i, j + 1).R;
                    R4 = Math.Abs(-R1 + R2) + Math.Abs(R1 - R3);
                    G1 = bt1.GetPixel(i, j).G;
                    G2 = bt1.GetPixel(i + 1, j).G;
                    G3 = bt1.GetPixel(i, j + 1).G;
                    G4 = Math.Abs(-G1 + G2) + Math.Abs(G1 - G3);
                    B1 = bt1.GetPixel(i, j).B;
                    B2 = bt1.GetPixel(i + 1, j).B;
                    B3 = bt1.GetPixel(i, j + 1).B;
                    B4 = Math.Abs(-B1 + B2) + Math.Abs(B1 - B3);
                    if (R4 <= 60 && G4 <= 60 && B4 <= 60)
                    {
                       R4 = 0;
                       G4 = 0;
                       B4 = 0;
                    }
                    R = R - R4;
                    G = G - G4;
                    B = B - B4;
                    if (R >= 255) R = 255;
                    if (G >= 255) G = 255;//判断是否超出各分量允许的范围，如果大于255则只能等于255
                    if (B >= 255) B = 255;
                    if (R <= 0) R = 0;
                    if (G <= 0) G = 0;//判断是否超出各分量允许的范围，如果大于255则只能等于255
                    if (B <= 0) B = 0;
                    bt2.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
                pictureBox2.Refresh();
                pictureBox2.Image = bt2;
            }
        }

        private void soble算子ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Error!No Pictures!");
                return;
            }
            bt1 = new Bitmap(pictureBox1.Image);
            bt2 = new Bitmap(pictureBox1.Image);
            int R, G, B;
            int R0, R1, R2, R3, R4;
            int G0, G1, G2, G3, G4;
            int B0, B1, B2, B3, B4;
            for (int i = 0; i < bt1.Width - 1; i++)
            {
                for (int j = 0; j < bt1.Height - 1; j++)
                {
                    R = bt1.GetPixel(i, j).R;
                    G = bt1.GetPixel(i, j).G;
                    B = bt1.GetPixel(i, j).B;
                    R1 = bt1.GetPixel(i, j).R;
                    R2 = bt1.GetPixel(i + 1, j).R;
                    R3 = bt1.GetPixel(i, j + 1).R;
                    R0 = bt1.GetPixel(i + 1, j + 1).R;
                    R4 = Math.Abs(R1 - R0) + Math.Abs(R2 - R3);
                    G1 = bt1.GetPixel(i, j).G;
                    G2 = bt1.GetPixel(i + 1, j).G;
                    G3 = bt1.GetPixel(i, j + 1).G;
                    G0 = bt1.GetPixel(i + 1, j + 1).G;
                    G4 = Math.Abs(G1 - G0) + Math.Abs(G2 - G3);
                    B1 = bt1.GetPixel(i, j).B;
                    B2 = bt1.GetPixel(i + 1, j).B;
                    B3 = bt1.GetPixel(i, j + 1).B;
                    B0 = bt1.GetPixel(i + 1, j + 1).B;
                    B4 = Math.Abs(B1 - B0) + Math.Abs(B2 - B3);
                    if (R4 <= 60 && G4 <= 60 && B4 <= 60)
                    {
                        R4 = 0;
                        G4 = 0;
                        B4 = 0;
                    }
                    R = R - R4;
                    G = G - G4;
                    B = B - B4;
                    if (R >= 255) R = 255;
                    if (G >= 255) G = 255;//判断是否超出各分量允许的范围，如果大于255则只能等于255
                    if (B >= 255) B = 255;
                    if (R <= 0) R = 0;
                    if (G <= 0) G = 0;//判断是否超出各分量允许的范围，如果大于255则只能等于255
                    if (B <= 0) B = 0;
                    bt2.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
                pictureBox2.Refresh();
                pictureBox2.Image = bt2;
            }
        }

        private void robert算子ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Error!No Pictures!");
                return;
            }
            bt1 = new Bitmap(pictureBox1.Image);
            bt2 = new Bitmap(pictureBox1.Image);
            int R, G, B;
            int R1, R2, R3, R4, R5, R6, R7, R8, R0;
            int G1, G2, G3, G4, G5, G6, G7, G8, G0;
            int B1, B2, B3, B4, B5, B6, B7, B8, B0;
            int Sxr, Sxg, Sxb, Syr, Syg, Syb;
            for (int i = 1; i < bt1.Width - 1; i++)
            {
                for (int j = 1; j < bt1.Height - 1; j++)
                {
                    R = bt1.GetPixel(i, j).R;
                    G = bt1.GetPixel(i, j).G;
                    B = bt1.GetPixel(i, j).B;
                    R1 = bt1.GetPixel(i - 1, j - 1).R;
                    R2 = bt1.GetPixel(i, j - 1).R;
                    R3 = bt1.GetPixel(i + 1, j - 1).R;
                    R4 = bt1.GetPixel(i, j - 1).R;
                    R5 = bt1.GetPixel(i, j + 1).R;
                    R6 = bt1.GetPixel(i + 1, j - 1).R;
                    R7 = bt1.GetPixel(i + 1, j).R;
                    R8 = bt1.GetPixel(i + 1, j + 1).R;
                    Sxr = (R6 + 2 * R7 + R8) - (R1 + 2 * R2 + R3);
                    Syr = (R3 + 2 * R5 + R8) - (R1 + 2 * R4 + R6);
                    R0 = Math.Abs(Sxr) + Math.Abs(Syr);
                    G1 = bt1.GetPixel(i - 1, j - 1).G;
                    G2 = bt1.GetPixel(i, j - 1).G;
                    G3 = bt1.GetPixel(i + 1, j - 1).G;
                    G4 = bt1.GetPixel(i, j - 1).G;
                    G5 = bt1.GetPixel(i, j + 1).G;
                    G6 = bt1.GetPixel(i + 1, j - 1).G;
                    G7 = bt1.GetPixel(i + 1, j).G;
                    G8 = bt1.GetPixel(i + 1, j + 1).G;
                    Sxg = (G6 + 2 * G7 + G8) - (G1 + 2 * G2 + G3);
                    Syg = (G3 + 2 * G5 + G8) - (G1 + 2 * G4 + G6);
                    G0 = Math.Abs(Sxg) + Math.Abs(Syg);
                    B1 = bt1.GetPixel(i - 1, j - 1).B;
                    B2 = bt1.GetPixel(i, j - 1).B;
                    B3 = bt1.GetPixel(i + 1, j - 1).B;
                    B4 = bt1.GetPixel(i, j - 1).B;
                    B5 = bt1.GetPixel(i, j + 1).B;
                    B6 = bt1.GetPixel(i + 1, j - 1).B;
                    B7 = bt1.GetPixel(i + 1, j).B;
                    B8 = bt1.GetPixel(i + 1, j + 1).B;
                    Sxb = (B6 + 2 * B7 + B8) - (B1 + 2 * B2 + B3);
                    Syb = (B3 + 2 * B5 + B8) - (B1 + 2 * B4 + B6);
                    B0 = Math.Abs(Sxb) + Math.Abs(Syb);
                    if (R0 <= 250 && G0 <= 250 && B0 <= 250)
                    {
                        R0 = 0;
                        G0 = 0;
                        B0 = 0;
                    }
                    R = R - R0;
                    G = G - G0;
                    B = B - B0;
                    if (R >= 255) R = 255;
                    if (G >= 255) G = 255;//判断是否超出各分量允许的范围，如果大于255则只能等于255
                    if (B >= 255) B = 255;
                    if (R <= 0) R = 0;
                    if (G <= 0) G = 0;//判断是否超出各分量允许的范围，如果大于255则只能等于255
                    if (B <= 0) B = 0;
                    bt2.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
                pictureBox2.Refresh();
                pictureBox2.Image = bt2;
            }
        }

        private void 表面模糊ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Error!No Pictures!");
                return;
            }
            bt1 = new Bitmap(pictureBox1.Image);
            bt2 = new Bitmap(pictureBox1.Image);
            bt3 = new Bitmap(pictureBox1.Image);
            int width = bt1.Width;
            int height = bt1.Height;
            float sumr = 0, sumrw = 0, sumg = 0, sumgw = 0, sumb = 0, sumbw = 0, k, r, g, b;
            int R, G, B, R0, G0, B0, R1, G1, B1;
            表面模糊 bmmh = new 表面模糊();
            if (bmmh.ShowDialog() == DialogResult.OK)
            {
                int radius = bmmh.trackBar1.Value;
                int Y = bmmh.trackBarY.Value;
                    for (int i = 1+radius; i < (width-radius); i++)
                    {
                        for (int j = 1+radius; j < (height-radius); j++)
                        {
                            R0 = bt2.GetPixel(i, j).R;
                            G0 = bt2.GetPixel(i, j).G;
                            B0 = bt2.GetPixel(i, j).B;
                            for (int n = i-radius; n <= i+radius; n++)
                            {
                                for (int m = j-radius; m <= j+radius; m++)
                                {                                 
                                    R1 = bt1.GetPixel(n, m).R;
                                    k = 1.0f - (Math.Abs(R1 - R0) / (2.5f * Y));
                                    k = Math.Max(k, 0);
                                    sumr += k * R1;
                                    sumrw += k;

                                    G1 = bt1.GetPixel(n, m).G;
                                    k = 1.0f - (Math.Abs(G1 - G0) / (2.5f * Y));
                                    k = Math.Max(k, 0);
                                    sumg += k * G1;
                                    sumgw += k;

                                    B1 = bt1.GetPixel(n, m).B;
                                    k = 1.0f - (Math.Abs(B1 - B0) / (2.5f * Y));
                                    k = Math.Max(k, 0);
                                    sumb += k * B1;
                                    sumbw += k;
                                }
                            }
                            r = Math.Min(Math.Max(0, (sumr / sumrw)), 255);
                            if (r == 0) R = R0;
                            else R = (int)r;

                            g = Math.Min(Math.Max(0, (sumg / sumgw)), 255);
                            if (g == 0) G = G0;
                            else G = (int)g;

                            b = Math.Min(Math.Max(0, (sumb / sumbw)), 255);
                            if (b == 0) B = B0;
                            else B = (int)b;
                            bt3.SetPixel(i, j, Color.FromArgb(R, G, B));
                        pictureBox2.Refresh();
                        pictureBox2.Image = bt3;
                    }
                }
            }
        }

        private void 模糊ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Error!No Pictures!");
                return;
            }
            bt1 = new Bitmap(pictureBox1.Image);
            bt2 = new Bitmap(pictureBox1.Image);
            int width = bt1.Width;
            int height = bt1.Height;

            try
            {
                Bitmap bmpReturn = new Bitmap(width, height, PixelFormat.Format24bppRgb);
                BitmapData srcBits = bt1.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                BitmapData targetBits = bmpReturn.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

                unsafe
                {
                    byte* pSrcBits = (byte*)srcBits.Scan0.ToPointer();
                    byte* pTargetBits = (byte*)targetBits.Scan0.ToPointer();
                    int stride = srcBits.Stride;
                    byte* pTemp;

                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            if (x == 0 || x == width - 1 || y == 0 || y == height - 1)
                            {
                                //最边上的像素不处理
                                pTargetBits[0] = pSrcBits[0];
                                pTargetBits[1] = pSrcBits[1];
                                pTargetBits[2] = pSrcBits[2];
                            }
                            else
                            {
                                //取周围9点的值
                                int r1, r2, r3, r4, r5, r6, r7, r8, r9;
                                int g1, g2, g3, g4, g5, g6, g7, g8, g9;
                                int b1, b2, b3, b4, b5, b6, b7, b8, b9;

                                float fR, fG, fB;

                                //左上
                                pTemp = pSrcBits - stride - 3;
                                r1 = pTemp[2];
                                g1 = pTemp[1];
                                b1 = pTemp[0];

                                //正上
                                pTemp = pSrcBits - stride;
                                r2 = pTemp[2];
                                g2 = pTemp[1];
                                b2 = pTemp[0];

                                //右上
                                pTemp = pSrcBits - stride + 3;
                                r3 = pTemp[2];
                                g3 = pTemp[1];
                                b3 = pTemp[0];

                                //左侧
                                pTemp = pSrcBits - 3;
                                r4 = pTemp[2];
                                g4 = pTemp[1];
                                b4 = pTemp[0];

                                //右侧
                                pTemp = pSrcBits + 3;
                                r5 = pTemp[2];
                                g5 = pTemp[1];
                                b5 = pTemp[0];

                                //右下
                                pTemp = pSrcBits + stride - 3;
                                r6 = pTemp[2];
                                g6 = pTemp[1];
                                b6 = pTemp[0];

                                //正下
                                pTemp = pSrcBits + stride;
                                r7 = pTemp[2];
                                g7 = pTemp[1];
                                b7 = pTemp[0];

                                //右下
                                pTemp = pSrcBits + stride + 3;
                                r8 = pTemp[2];
                                g8 = pTemp[1];
                                b8 = pTemp[0];

                                //自己
                                pTemp = pSrcBits;
                                r9 = pTemp[2];
                                g9 = pTemp[1];
                                b9 = pTemp[0];

                                fR = (float)(r1 + r2 + r3 + r4 + r5 + r6 + r7 + r8 + r9);
                                fG = (float)(g1 + g2 + g3 + g4 + g5 + g6 + g7 + g8 + g9);
                                fB = (float)(b1 + b2 + b3 + b4 + b5 + b6 + b7 + b8 + b9);

                                fR /= 9;
                                fG /= 9;
                                fB /= 9;

                                pTargetBits[0] = (byte)fB;
                                pTargetBits[1] = (byte)fG;
                                pTargetBits[2] = (byte)fR;

                            }

                            pSrcBits += 3;
                            pTargetBits += 3;
                        }

                        pSrcBits += srcBits.Stride - width * 3;
                        pTargetBits += srcBits.Stride - width * 3;
                    }
                }
                bt1.UnlockBits(srcBits);
                bmpReturn.UnlockBits(targetBits);
                pictureBox1.Image = bmpReturn;

                return;
            }
            catch
            {
                return;
            }
        }

        private void 表面模糊2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Error!No Pictures!");
                return;
            }
            bt1 = new Bitmap(pictureBox1.Image);
            bt2 = new Bitmap(pictureBox1.Image);
            int width = bt1.Width;
            int height = bt1.Height;
            int radius = 20;
            int Y = 30;
            int R, G, B, R0, G0, B0, R1, G1, B1;
            float sumr = 0, sumrw = 0, sumg = 0, sumgw = 0, sumb = 0, sumbw = 0, k, r, g, b;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    R0 = bt1.GetPixel(i, j).R;
                    G0 = bt1.GetPixel(i, j).G;
                    B0 = bt1.GetPixel(i, j).B;
                    for (int n = radius; n <= 2*radius+1; n++)
                    {
                        for (int m = radius; m <= 2*radius+1; m++)
                        {
                            //左下
                            int x = Math.Min(Math.Max(0, i + m), width - 1);
                            int y = Math.Min(Math.Max(0, j - n), height - 1);
                            R1 = bt1.GetPixel(x, y).R;
                            k = 1.0f - (Math.Abs(R1 - R0) / (2.5f * Y));
                            sumr += k * R1;
                            sumrw += k;

                            G1 = bt1.GetPixel(x, y).G;
                            k = 1.0f - (Math.Abs(G1 - G0) / (2.5f * Y));
                            sumg += k * G1;
                            sumgw += k;

                            B1 = bt1.GetPixel(x, y).B;
                            k = 1.0f - (Math.Abs(B1 - B0) / (2.5f * Y));
                            sumb += k * B1;
                            sumbw += k;

                            //左上
                            x = Math.Min(Math.Max(1, i - m), width - 1);
                            y = Math.Min(Math.Max(1, j + n), height - 1);
                            R1 = bt2.GetPixel(x, y).R;
                            k = 1.0f - (Math.Abs(R1 - R0) / (2.5f * Y));
                            sumr += k * R1;
                            sumrw += k;

                            G1 = bt1.GetPixel(x, y).G;
                            k = 1.0f - (Math.Abs(G1 - G0) / (2.5f * Y));
                            sumg += k * G1;
                            sumgw += k;

                            B1 = bt1.GetPixel(x, y).B;
                            k = 1.0f - (Math.Abs(B1 - B0) / (2.5f * Y));
                            sumb += k * B1;
                            sumbw += k;

                            //右上
                            x = Math.Min(Math.Max(1, i + m), width - 1);
                            y = Math.Min(Math.Max(1, j + n), height - 1);
                            R1 = bt1.GetPixel(x, y).R;
                            k = 1.0f - (Math.Abs(R1 - R0) / (2.5f * Y));
                            sumr += k * R1;
                            sumrw += k;

                            G1 = bt1.GetPixel(x, y).G;
                            k = 1.0f - (Math.Abs(G1 - G0) / (2.5f * Y));
                            sumg += k * G1;
                            sumgw += k;

                            B1 = bt1.GetPixel(x, y).B;
                            k = 1.0f - (Math.Abs(B1 - B0) / (2.5f * Y));
                            sumb += k * B1;
                            sumbw += k;

                            //右下
                            x = Math.Min(Math.Max(1, i + m), width - 1);
                            y = Math.Min(Math.Max(1, j - n), height - 1);
                            R1 = bt1.GetPixel(x, y).R;
                            k = 1.0f - (Math.Abs(R1 - R0) / (2.5f * Y));
                            sumr += k * R1;
                            sumrw += k;

                            G1 = bt1.GetPixel(x, y).G;
                            k = 1.0f - (Math.Abs(G1 - G0) / (2.5f * Y));
                            sumg += k * G1;
                            sumgw += k;

                            B1 = bt1.GetPixel(x, y).B;
                            k = 1.0f - (Math.Abs(B1 - B0) / (2.5f * Y));
                            sumb += k * B1;
                            sumbw += k;

                        }
                    }
                    r = Math.Min(Math.Max(0, sumr / sumrw), 255);
                    if (r == 0) R = R0;
                    else R = (int)r;

                    g = Math.Min(Math.Max(0, sumg / sumgw), 255);
                    if (r == 0) G = G0;
                    else G = (int)g;

                    b = Math.Min(Math.Max(0, sumb / sumbw), 255);
                    if (r == 0) B = B0;
                    else B = (int)b;
                    bt2.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
                pictureBox2.Refresh();
                pictureBox2.Image = bt2;
            }

        }

        private void prewitt算子ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Error!No Pictures!");
                return;
            }
            bt1 = new Bitmap(pictureBox1.Image);
            bt2 = new Bitmap(pictureBox1.Image);
            int R, G, B;
            int R1, R2, R3, R4, R5, R6, R7, R8, R0;
            int G1, G2, G3, G4, G5, G6, G7, G8, G0;
            int B1, B2, B3, B4, B5, B6, B7, B8, B0;
            int Sxr, Sxg, Sxb, Syr, Syg, Syb;
            for (int i = 1; i < bt1.Width - 1; i++)
            {
                for (int j = 1; j < bt1.Height - 1; j++)
                {
                    R = bt1.GetPixel(i, j).R;
                    G = bt1.GetPixel(i, j).G;
                    B = bt1.GetPixel(i, j).B;
                    R1 = bt1.GetPixel(i - 1, j - 1).R;
                    R2 = bt1.GetPixel(i, j - 1).R;
                    R3 = bt1.GetPixel(i + 1, j - 1).R;
                    R4 = bt1.GetPixel(i, j - 1).R;
                    R5 = bt1.GetPixel(i, j + 1).R;
                    R6 = bt1.GetPixel(i + 1, j - 1).R;
                    R7 = bt1.GetPixel(i + 1, j).R;
                    R8 = bt1.GetPixel(i + 1, j + 1).R;
                    Sxr = (R6 + R7 + R8) - (R1 + R2 + R3);
                    Syr = (R3 + R5 + R8) - (R1 + R4 + R6);
                    R0 = Math.Abs(Sxr) + Math.Abs(Syr);
                    G1 = bt1.GetPixel(i - 1, j - 1).G;
                    G2 = bt1.GetPixel(i, j - 1).G;
                    G3 = bt1.GetPixel(i + 1, j - 1).G;
                    G4 = bt1.GetPixel(i, j - 1).G;
                    G5 = bt1.GetPixel(i, j + 1).G;
                    G6 = bt1.GetPixel(i + 1, j - 1).G;
                    G7 = bt1.GetPixel(i + 1, j).G;
                    G8 = bt1.GetPixel(i + 1, j + 1).G;
                    Sxg = (G6 + G7 + G8) - (G1 + G2 + G3);
                    Syg = (G3 + G5 + G8) - (G1 + G4 + G6);
                    G0 = Math.Abs(Sxg) + Math.Abs(Syg);
                    B1 = bt1.GetPixel(i - 1, j - 1).B;
                    B2 = bt1.GetPixel(i, j - 1).B;
                    B3 = bt1.GetPixel(i + 1, j - 1).B;
                    B4 = bt1.GetPixel(i, j - 1).B;
                    B5 = bt1.GetPixel(i, j + 1).B;
                    B6 = bt1.GetPixel(i + 1, j - 1).B;
                    B7 = bt1.GetPixel(i + 1, j).B;
                    B8 = bt1.GetPixel(i + 1, j + 1).B;
                    Sxb = (B6 + B7 + B8) - (B1 + B2 + B3);
                    Syb = (B3 + B5 + B8) - (B1 + B4 + B6);
                    B0 = Math.Abs(Sxb) + Math.Abs(Syb);
                    if (R0 <= 240 && G0 <= 240 && B0 <= 240)
                    {
                        R0 = 0;
                        G0 = 0;
                        B0 = 0;
                    }
                    R = R - R0;
                    G = G - G0;
                    B = B - B0;
                    if (R >= 255) R = 255;
                    if (G >= 255) G = 255;//判断是否超出各分量允许的范围，如果大于255则只能等于255
                    if (B >= 255) B = 255;
                    if (R <= 0) R = 0;
                    if (G <= 0) G = 0;//判断是否超出各分量允许的范围，如果大于255则只能等于255
                    if (B <= 0) B = 0;
                    bt2.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
                pictureBox2.Refresh();
                pictureBox2.Image = bt2;
            }
        }

        private void 拉普拉斯算子ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Error!No Pictures!");
                return;
            }
            bt1 = new Bitmap(pictureBox1.Image);
            bt2 = new Bitmap(pictureBox1.Image);
            int R, G, B;
            int R1, R2, R3, R4, R5, R6, R7, R8, R9, R0;
            int G1, G2, G3, G4, G5, G6, G7, G8, G9, G0;
            int B1, B2, B3, B4, B5, B6, B7, B8, B9, B0;
            for (int i = 1; i < bt1.Width - 1; i++)
            {
                for (int j = 1; j < bt1.Height - 1; j++)
                {
                    R = bt1.GetPixel(i, j).R;
                    G = bt1.GetPixel(i, j).G;
                    B = bt1.GetPixel(i, j).B;
                    R1 = bt1.GetPixel(i - 1, j - 1).R;
                    R2 = bt1.GetPixel(i - 1, j).R;
                    R3 = bt1.GetPixel(i - 1, j + 1).R;
                    R4 = bt1.GetPixel(i, j - 1).R;
                    R5 = bt1.GetPixel(i, j).R;
                    R6 = bt1.GetPixel(i, j + 1).R;
                    R7 = bt1.GetPixel(i + 1, j - 1).R;
                    R8 = bt1.GetPixel(i + 1, j).R;
                    R9 = bt1.GetPixel(i + 1, j + 1).R;
                    R0 = Math.Abs(R1 + R2 + R3 + R4 + R6 + R7 + R8 + R9 - 8 * R5);
                    G1 = bt1.GetPixel(i - 1, j - 1).G;
                    G2 = bt1.GetPixel(i - 1, j).G;
                    G3 = bt1.GetPixel(i - 1, j + 1).G;
                    G4 = bt1.GetPixel(i, j - 1).G;
                    G5 = bt1.GetPixel(i, j).G;
                    G6 = bt1.GetPixel(i, j + 1).G;
                    G7 = bt1.GetPixel(i + 1, j - 1).G;
                    G8 = bt1.GetPixel(i + 1, j).G;
                    G9 = bt1.GetPixel(i + 1, j + 1).G;
                    G0 = Math.Abs(G1 + G2 + G3 + G4 + G6 + G7 + G8 + G9 - 8 * G5);
                    B1 = bt1.GetPixel(i - 1, j - 1).B;
                    B2 = bt1.GetPixel(i - 1, j).B;
                    B3 = bt1.GetPixel(i - 1, j + 1).B;
                    B4 = bt1.GetPixel(i, j - 1).B;
                    B5 = bt1.GetPixel(i, j).B;
                    B6 = bt1.GetPixel(i, j + 1).B;
                    B7 = bt1.GetPixel(i + 1, j - 1).B;
                    B8 = bt1.GetPixel(i + 1, j).B;
                    B9 = bt1.GetPixel(i + 1, j + 1).B;
                    B0 = Math.Abs(B1 + B2 + B3 + B4 + B6 + B7 + B8 + B9 - 8 * B5);
                    if (R0 <= 230 && G0 <= 230 && B0 <= 230)
                    {
                        R0 = 0;
                        G0 = 0;
                        B0 = 0;
                    }
                    R = R - R0;
                    G = G - G0;
                    B = B - B0;
                    if (R >= 255) R = 255;
                    if (G >= 255) G = 255;//判断是否超出各分量允许的范围，如果大于255则只能等于255
                    if (B >= 255) B = 255;
                    if (R <= 0) R = 0;
                    if (G <= 0) G = 0;//判断是否超出各分量允许的范围，如果大于255则只能等于255
                    if (B <= 0) B = 0;
                    bt2.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
                pictureBox2.Refresh();
                pictureBox2.Image = bt2;
            }
        }

        private void robinson算子ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Error!No Pictures!");
                return;
            }
            bt1 = new Bitmap(pictureBox1.Image);
            bt2 = new Bitmap(pictureBox1.Image);
            int R, G, B;
            int R1, R2, R3, R4, R5, R6, R0;
            int G1, G2, G3, G4, G5, G6, G0;
            int B1, B2, B3, B4, B5, B6, B0;
            for (int i = 1; i < bt1.Width - 1; i++)
            {
                for (int j = 1; j < bt1.Height - 1; j++)
                {
                    R = bt1.GetPixel(i, j).R;
                    G = bt1.GetPixel(i, j).G;
                    B = bt1.GetPixel(i, j).B;
                    R1 = bt1.GetPixel(i - 1, j - 1).R;
                    R2 = bt1.GetPixel(i - 1, j).R;
                    R3 = bt1.GetPixel(i - 1, j + 1).R;
                    R4 = bt1.GetPixel(i + 1, j - 1).R;
                    R5 = bt1.GetPixel(i + 1, j).R;
                    R6 = bt1.GetPixel(i + 1, j + 1).R;
                    R0 = Math.Abs(R1 + 2 * R2 + R3 - R4 - 2 * R5 - R6);
                    G1 = bt1.GetPixel(i - 1, j - 1).G;
                    G2 = bt1.GetPixel(i - 1, j).G;
                    G3 = bt1.GetPixel(i - 1, j + 1).G;
                    G4 = bt1.GetPixel(i + 1, j - 1).G;
                    G5 = bt1.GetPixel(i + 1, j).G;
                    G6 = bt1.GetPixel(i + 1, j + 1).G;
                    G0 = Math.Abs(G1 + 2 * G2 + G3 - G4 - 2 * G5 - G6);
                    B1 = bt1.GetPixel(i - 1, j - 1).B;
                    B2 = bt1.GetPixel(i - 1, j).B;
                    B3 = bt1.GetPixel(i - 1, j + 1).B;
                    B4 = bt1.GetPixel(i + 1, j - 1).B;
                    B5 = bt1.GetPixel(i + 1, j).B;
                    B6 = bt1.GetPixel(i + 1, j + 1).B;
                    B0 = Math.Abs(B1 + 2 * B2 + B3 - B4 - 2 * B5 - B6);
                    if (R0 <= 230 && G0 <= 230 && B0 <= 230)
                    {
                        R0 = 0;
                        G0 = 0;
                        B0 = 0;
                    }
                    R = R - R0;
                    G = G - G0;
                    B = B - B0;
                    if (R >= 255) R = 255;
                    if (G >= 255) G = 255;//判断是否超出各分量允许的范围，如果大于255则只能等于255
                    if (B >= 255) B = 255;
                    if (R <= 0) R = 0;
                    if (G <= 0) G = 0;//判断是否超出各分量允许的范围，如果大于255则只能等于255
                    if (B <= 0) B = 0;
                    bt2.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
                pictureBox2.Refresh();
                pictureBox2.Image = bt2;
            }
        }

        private void kirsch算子ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Error!No Pictures!");
                return;
            }
            bt1 = new Bitmap(pictureBox1.Image);
            bt2 = new Bitmap(pictureBox1.Image);
            int R, G, B;
            int R1, R2, R3, R4, R6, R7, R8, R9, R0;
            int G1, G2, G3, G4, G6, G7, G8, G9, G0;
            int B1, B2, B3, B4, B6, B7, B8, B9, B0;
            for (int i = 1; i < bt1.Width - 1; i++)
            {
                for (int j = 1; j < bt1.Height - 1; j++)
                {
                    R = bt1.GetPixel(i, j).R;
                    G = bt1.GetPixel(i, j).G;
                    B = bt1.GetPixel(i, j).B;
                    R1 = bt1.GetPixel(i - 1, j - 1).R;
                    R2 = bt1.GetPixel(i - 1, j).R;
                    R3 = bt1.GetPixel(i - 1, j + 1).R;
                    R4 = bt1.GetPixel(i, j - 1).R;
                    R6 = bt1.GetPixel(i, j + 1).R;
                    R7 = bt1.GetPixel(i + 1, j - 1).R;
                    R8 = bt1.GetPixel(i + 1, j).R;
                    R9 = bt1.GetPixel(i + 1, j + 1).R;
                    R0 = Math.Abs(5 * R1 + 5 * R2 + 5 * R3 - 3 * R4 - 3 * R6 - 3 * R7 - 3 * R8 - 3 * R9);
                    G1 = bt1.GetPixel(i - 1, j - 1).G;
                    G2 = bt1.GetPixel(i - 1, j).G;
                    G3 = bt1.GetPixel(i - 1, j + 1).G;
                    G4 = bt1.GetPixel(i, j - 1).G;
                    G6 = bt1.GetPixel(i, j + 1).G;
                    G7 = bt1.GetPixel(i + 1, j - 1).G;
                    G8 = bt1.GetPixel(i + 1, j).G;
                    G9 = bt1.GetPixel(i + 1, j + 1).G;
                    G0 = Math.Abs(5 * G1 + 5 * G2 + 5 * G3 - 3 * G4 - 3 * G6 - 3 * G7 - 3 * G8 - 3 * G9);
                    B1 = bt1.GetPixel(i - 1, j - 1).B;
                    B2 = bt1.GetPixel(i - 1, j).B;
                    B3 = bt1.GetPixel(i - 1, j + 1).B;
                    B4 = bt1.GetPixel(i, j - 1).B;
                    B6 = bt1.GetPixel(i, j + 1).B;
                    B7 = bt1.GetPixel(i + 1, j - 1).B;
                    B8 = bt1.GetPixel(i + 1, j).B;
                    B9 = bt1.GetPixel(i + 1, j + 1).B;
                    B0 = Math.Abs(5 * B1 + 5 * B2 + 5 * B3 - 3 * B4 - 3 * B6 - 3 * B7 - 3 * B8 - 3 * B9);
                    if (R0 <= 254 && G0 <= 254 && B0 <= 254)
                    {
                        R0 = 0;
                        G0 = 0;
                        B0 = 0;
                    }
                    R = R - R0;
                    G = G - G0;
                    B = B - B0;
                    if (R >= 255) R = 255;
                    if (G >= 255) G = 255;//判断是否超出各分量允许的范围，如果大于255则只能等于255
                    if (B >= 255) B = 255;
                    if (R <= 0) R = 0;
                    if (G <= 0) G = 0;//判断是否超出各分量允许的范围，如果大于255则只能等于255
                    if (B <= 0) B = 0;
                    bt2.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
                pictureBox2.Refresh();
                pictureBox2.Image = bt2;
            }
        }

        private void trackBarSpiral_Scroll(object sender, EventArgs e)
        {
            textBoxSpiral.Text = trackBarSpiral.Value.ToString();
        }

        private void btnSpiral_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Error!No Pictures!");
                return;
            }
            int degree = trackBarSpiral.Value;
            Bitmap srcBmp = new Bitmap(pictureBox1.Image);
            Bitmap dstBmp = (Bitmap)srcBmp.Clone();
            dstBmp = null;
            BitmapData srcBmpData = null;
            BitmapData dstBmpData = null;
            switch (degree)
            {
                case 0:
                    dstBmp = new Bitmap(srcBmp);
                    pictureBox2.Image = dstBmp;
                    break;
                case 360:
                    dstBmp = new Bitmap(srcBmp);
                    pictureBox2.Image = dstBmp;
                    break;
                case -360:
                    dstBmp = new Bitmap(srcBmp);
                    pictureBox2.Image = dstBmp;
                    break;
                case -90:
                    dstBmp = new Bitmap(srcBmp.Height, srcBmp.Width);
                    srcBmpData = srcBmp.LockBits(new Rectangle(0, 0, srcBmp.Width, srcBmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                    dstBmpData = dstBmp.LockBits(new Rectangle(0, 0, dstBmp.Width, dstBmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                    unsafe
                    {
                        byte* ptrSrc = (byte*)srcBmpData.Scan0;
                        byte* ptrDst = (byte*)dstBmpData.Scan0;
                        for (int i = 0; i < srcBmp.Height; i++)
                        {
                            for (int j = 0; j < srcBmp.Width; j++)
                            {
                                ptrDst[j * dstBmpData.Stride + (dstBmp.Height - i - 1) * 3] = ptrSrc[i * srcBmpData.Stride + j * 3];
                                ptrDst[j * dstBmpData.Stride + (dstBmp.Height - i - 1) * 3 + 1] = ptrSrc[i * srcBmpData.Stride + j * 3 + 1];
                                ptrDst[j * dstBmpData.Stride + (dstBmp.Height - i - 1) * 3 + 2] = ptrSrc[i * srcBmpData.Stride + j * 3 + 2];
                            }
                        }
                    }
                    srcBmp.UnlockBits(srcBmpData);
                    dstBmp.UnlockBits(dstBmpData);
                    pictureBox2.Image = dstBmp;
                    break;
                case 90:
                    dstBmp = new Bitmap(srcBmp.Height, srcBmp.Width);
                    srcBmpData = srcBmp.LockBits(new Rectangle(0, 0, srcBmp.Width, srcBmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                    dstBmpData = dstBmp.LockBits(new Rectangle(0, 0, dstBmp.Width, dstBmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                    unsafe
                    {
                        byte* ptrSrc = (byte*)srcBmpData.Scan0;
                        byte* ptrDst = (byte*)dstBmpData.Scan0;
                        for (int i = 0; i < srcBmp.Height; i++)
                        {
                            for (int j = 0; j < srcBmp.Width; j++)
                            {
                                ptrDst[(srcBmp.Width - j - 1) * dstBmpData.Stride + i * 3] = ptrSrc[i * srcBmpData.Stride + j * 3];
                                ptrDst[(srcBmp.Width - j - 1) * dstBmpData.Stride + i * 3 + 1] = ptrSrc[i * srcBmpData.Stride + j * 3 + 1];
                                ptrDst[(srcBmp.Width - j - 1) * dstBmpData.Stride + i * 3 + 2] = ptrSrc[i * srcBmpData.Stride + j * 3 + 2];
                            }
                        }
                    }
                    srcBmp.UnlockBits(srcBmpData);
                    dstBmp.UnlockBits(dstBmpData);
                    pictureBox2.Image = dstBmp;
                    break;
                case 180:
                case -180:
                    dstBmp = new Bitmap(srcBmp.Width, srcBmp.Height);
                    srcBmpData = srcBmp.LockBits(new Rectangle(0, 0, srcBmp.Width, srcBmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                    dstBmpData = dstBmp.LockBits(new Rectangle(0, 0, dstBmp.Width, dstBmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                    unsafe
                    {
                        byte* ptrSrc = (byte*)srcBmpData.Scan0;
                        byte* ptrDst = (byte*)dstBmpData.Scan0;
                        for (int i = 0; i < srcBmp.Height; i++)
                        {
                            for (int j = 0; j < srcBmp.Width; j++)
                            {
                                ptrDst[(srcBmp.Width - i - 1) * dstBmpData.Stride + (dstBmp.Height - j - 1) * 3] = ptrSrc[i * srcBmpData.Stride + j * 3];
                                ptrDst[(srcBmp.Width - i - 1) * dstBmpData.Stride + (dstBmp.Height - j - 1) * 3 + 1] = ptrSrc[i * srcBmpData.Stride + j * 3 + 1];
                                ptrDst[(srcBmp.Width - i - 1) * dstBmpData.Stride + (dstBmp.Height - j - 1) * 3 + 2] = ptrSrc[i * srcBmpData.Stride + j * 3 + 2];
                            }
                        }
                    }
                    srcBmp.UnlockBits(srcBmpData);
                    dstBmp.UnlockBits(dstBmpData);
                    pictureBox2.Image = dstBmp;
                    break;
                default://任意角度
                    double radian = degree * Math.PI / 180.0;//将角度转换为弧度
                                                             //计算正弦和余弦
                    double sin = Math.Sin(radian);
                    double cos = Math.Cos(radian);
                    //计算旋转后的图像大小
                    int widthDst = (int)(srcBmp.Height * Math.Abs(sin) + srcBmp.Width * Math.Abs(cos));
                    int heightDst = (int)(srcBmp.Width * Math.Abs(sin) + srcBmp.Height * Math.Abs(cos));

                    dstBmp = new Bitmap(widthDst, heightDst);
                    //确定旋转点
                    int dx = (int)(srcBmp.Width / 2 * (1 - cos) + srcBmp.Height / 2 * sin);
                    int dy = (int)(srcBmp.Width / 2 * (0 - sin) + srcBmp.Height / 2 * (1 - cos));

                    int insertBeginX = srcBmp.Width / 2 - widthDst / 2;
                    int insertBeginY = srcBmp.Height / 2 - heightDst / 2;

                    //插值公式所需参数
                    double ku = insertBeginX * cos - insertBeginY * sin + dx;
                    double kv = insertBeginX * sin + insertBeginY * cos + dy;
                    double cu1 = cos, cu2 = sin;
                    double cv1 = sin, cv2 = cos;

                    double fu, fv, a, b, F1, F2;
                    int Iu, Iv;
                    srcBmpData = srcBmp.LockBits(new Rectangle(0, 0, srcBmp.Width, srcBmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                    dstBmpData = dstBmp.LockBits(new Rectangle(0, 0, dstBmp.Width, dstBmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

                    unsafe
                    {
                        byte* ptrSrc = (byte*)srcBmpData.Scan0;
                        byte* ptrDst = (byte*)dstBmpData.Scan0;
                        for (int i = 0; i < heightDst; i++)
                        {
                            for (int j = 0; j < widthDst; j++)
                            {
                                fu = j * cu1 - i * cu2 + ku;
                                fv = j * cv1 + i * cv2 + kv;
                                if ((fv < 1) || (fv > srcBmp.Height - 1) || (fu < 1) || (fu > srcBmp.Width - 1))
                                {

                                    ptrDst[i * dstBmpData.Stride + j * 3] = 150;
                                    ptrDst[i * dstBmpData.Stride + j * 3 + 1] = 150;
                                    ptrDst[i * dstBmpData.Stride + j * 3 + 2] = 150;
                                }
                                else
                                {//双线性插值
                                    Iu = (int)fu;
                                    Iv = (int)fv;
                                    a = fu - Iu;
                                    b = fv - Iv;
                                    for (int k = 0; k < 3; k++)
                                    {
                                        F1 = (1 - b) * *(ptrSrc + Iv * srcBmpData.Stride + Iu * 3 + k) + b * *(ptrSrc + (Iv + 1) * srcBmpData.Stride + Iu * 3 + k);
                                        F2 = (1 - b) * *(ptrSrc + Iv * srcBmpData.Stride + (Iu + 1) * 3 + k) + b * *(ptrSrc + (Iv + 1) * srcBmpData.Stride + (Iu + 1) * 3 + k);
                                        *(ptrDst + i * dstBmpData.Stride + j * 3 + k) = (byte)((1 - a) * F1 + a * F2);
                                    }
                                }
                            }
                        }
                    }
                    srcBmp.UnlockBits(srcBmpData);
                    dstBmp.UnlockBits(dstBmpData);
                    pictureBox2.Image = dstBmp;
                    break;
            }
        }

        private void 加噪ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Error!No Pictures!");
                return;
            }
            Bitmap bt1 = new Bitmap(pictureBox1.Image);
            Bitmap bt2 = new Bitmap(pictureBox1.Image);
            Random random = new Random();
            Random rd = new Random();
            for (int i = 0; i < bt1.Width; i++)
            {
                for (int j = 0; j < bt1.Height; j++)
                {
                    int R, G, B;
                    double ran = random.NextDouble();
                    R = bt1.GetPixel(i, j).R;
                    G = bt1.GetPixel(i, j).G;
                    B = bt1.GetPixel(i, j).B;
                    if (ran > 0.98)
                    {
                        R = rd.Next(0, 255);
                        G = rd.Next(0, 255);
                        B = rd.Next(0, 255);
                        R = (int)((G * 59 + R * 30 + B * 11) / 100);
                        G = (int)((G * 59 + R * 30 + B * 11) / 100);
                        B = (int)((G * 59 + R * 30 + B * 11) / 100);
                    }
                    if (ran < 0.02)
                    {
                        R = rd.Next(0, 255);
                        G = rd.Next(0, 255);
                        B = rd.Next(0, 255);
                        R = (int)((G * 59 + R * 30 + B * 11) / 100);
                        G = (int)((G * 59 + R * 30 + B * 11) / 100);
                        B = (int)((G * 59 + R * 30 + B * 11) / 100);
                    }
                    bt2.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
                pictureBox1.Refresh();
                pictureBox1.Image = bt2;
            }
        }

        private void 差分梯度算子ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Error!No Pictures!");
                return;
            }
            bt1 = new Bitmap(pictureBox1.Image);
            bt2 = new Bitmap(pictureBox1.Image);
            int R, G, B;
            int R1, R2, R3, R4;
            int G1, G2, G3, G4;
            int B1, B2, B3, B4;
            for (int i = 0; i < bt1.Width - 1; i++)
            {
                for (int j = 0; j < bt1.Height - 1; j++)
                {
                    R1 = bt1.GetPixel(i, j).R;
                    R2 = bt1.GetPixel(i + 1, j).R;
                    R3 = bt1.GetPixel(i, j + 1).R;
                    R4 = Math.Abs(-R1 + R2) + Math.Abs(R1 - R3);
                    G1 = bt1.GetPixel(i, j).G;
                    G2 = bt1.GetPixel(i + 1, j).G;
                    G3 = bt1.GetPixel(i, j + 1).G;
                    G4 = Math.Abs(-G1 + G2) + Math.Abs(G1 - G3);
                    B1 = bt1.GetPixel(i, j).B;
                    B2 = bt1.GetPixel(i + 1, j).B;
                    B3 = bt1.GetPixel(i, j + 1).B;
                    B4 = Math.Abs(-B1 + B2) + Math.Abs(B1 - B3);
                    if (R4 <= 40 && G4 <= 40 && B4 <= 40)
                    {
                        R4 = 0;
                        G4 = 0;
                        B4 = 0;
                    }
                    if(R4==0)
                    {
                        R4 = 255;
                        G4 = 255;
                        B4 = 255;
                    }
                    else
                    {
                        R4 = 0;
                        G4 = 0;
                        B4 = 0;
                    }
                    bt2.SetPixel(i, j, Color.FromArgb(R4, G4, B4));
                }
                pictureBox2.Refresh();
                pictureBox2.Image = bt2;
            }
        }

        private void 拉普拉斯算子ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Error!No Pictures!");
                return;
            }
            bt1 = new Bitmap(pictureBox1.Image);
            bt2 = new Bitmap(pictureBox1.Image);
            int R, G, B;
            int R1, R2, R3, R4, R5, R6, R7, R8, R9, R0;
            int G1, G2, G3, G4, G5, G6, G7, G8, G9, G0;
            int B1, B2, B3, B4, B5, B6, B7, B8, B9, B0;
            for (int i = 1; i < bt1.Width - 1; i++)
            {
                for (int j = 1; j < bt1.Height - 1; j++)
                {
                    R = bt1.GetPixel(i, j).R;
                    G = bt1.GetPixel(i, j).G;
                    B = bt1.GetPixel(i, j).B;
                    R1 = bt1.GetPixel(i - 1, j - 1).R;
                    R2 = bt1.GetPixel(i - 1, j).R;
                    R3 = bt1.GetPixel(i - 1, j + 1).R;
                    R4 = bt1.GetPixel(i, j - 1).R;
                    R5 = bt1.GetPixel(i, j).R;
                    R6 = bt1.GetPixel(i, j + 1).R;
                    R7 = bt1.GetPixel(i + 1, j - 1).R;
                    R8 = bt1.GetPixel(i + 1, j).R;
                    R9 = bt1.GetPixel(i + 1, j + 1).R;
                    R0 = Math.Abs(R1 + R2 + R3 + R4 + R6 + R7 + R8 + R9 - 8 * R5);
                    G1 = bt1.GetPixel(i - 1, j - 1).G;
                    G2 = bt1.GetPixel(i - 1, j).G;
                    G3 = bt1.GetPixel(i - 1, j + 1).G;
                    G4 = bt1.GetPixel(i, j - 1).G;
                    G5 = bt1.GetPixel(i, j).G;
                    G6 = bt1.GetPixel(i, j + 1).G;
                    G7 = bt1.GetPixel(i + 1, j - 1).G;
                    G8 = bt1.GetPixel(i + 1, j).G;
                    G9 = bt1.GetPixel(i + 1, j + 1).G;
                    G0 = Math.Abs(G1 + G2 + G3 + G4 + G6 + G7 + G8 + G9 - 8 * G5);
                    B1 = bt1.GetPixel(i - 1, j - 1).B;
                    B2 = bt1.GetPixel(i - 1, j).B;
                    B3 = bt1.GetPixel(i - 1, j + 1).B;
                    B4 = bt1.GetPixel(i, j - 1).B;
                    B5 = bt1.GetPixel(i, j).B;
                    B6 = bt1.GetPixel(i, j + 1).B;
                    B7 = bt1.GetPixel(i + 1, j - 1).B;
                    B8 = bt1.GetPixel(i + 1, j).B;
                    B9 = bt1.GetPixel(i + 1, j + 1).B;
                    B0 = Math.Abs(B1 + B2 + B3 + B4 + B6 + B7 + B8 + B9 - 8 * B5);
                    if (R0 <= 100 && G0 <= 100 && B0 <= 100)
                    {
                        R0 = 0;
                        G0 = 0;
                        B0 = 0;
                    }
                    if (R0 == 0)
                    {
                        R0 = 255;
                        G0 = 255;
                        B0 = 255;
                    }
                    else
                    {
                        R0 = 0;
                        G0 = 0;
                        B0 = 0;
                    }
                    bt2.SetPixel(i, j, Color.FromArgb(R0, G0, B0));
                }
                pictureBox2.Refresh();
                pictureBox2.Image = bt2;
            }
        }

        private void 导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();//定义一个打开文件类
            ofd.Filter = "所有文件(*.*)|*.*|Jpeg文件(*.jpg)|*.jpg|PNG文件|*.png";//判断是否为指定类型的图像文件
            ofd.FilterIndex = 2; //打开文件的对话框将弹出，供使用者选择
            if (ofd.ShowDialog() == DialogResult.OK) //如果选择了某个文件，并点击了OK后，那么将选择的文件返回
            {
                pictureBox2.Image = System.Drawing.Image.FromFile(ofd.FileName.ToString());//将图像文件赋给图片框“pictureBox1”

            }
            originalBt = new Bitmap(pictureBox2.Image);//将图片框内的图像赋给一个位图变量对象“originalBt”以用于后续处理
        }
    }
       
}
