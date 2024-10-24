
namespace Image_Processing_Folder
{
    partial class Image_Processing
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnGray = new System.Windows.Forms.Button();
            this.light_text = new System.Windows.Forms.Label();
            this.Light_trackBar = new System.Windows.Forms.TrackBar();
            this.btnlight = new System.Windows.Forms.Button();
            this.textBox_Light = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.duibi_trackBar = new System.Windows.Forms.TrackBar();
            this.textBox_Duibi = new System.Windows.Forms.TextBox();
            this.btnDuibi = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSpiral = new System.Windows.Forms.Button();
            this.textBoxSpiral = new System.Windows.Forms.TextBox();
            this.trackBarSpiral = new System.Windows.Forms.TrackBar();
            this.trackBar_Besmall = new System.Windows.Forms.TrackBar();
            this.textBox_Besmall = new System.Windows.Forms.TextBox();
            this.btnBesmall = new System.Windows.Forms.Button();
            this.btnBinary = new System.Windows.Forms.Button();
            this.textBox_Binary = new System.Windows.Forms.TextBox();
            this.trackBar_Binary = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.开启ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开启ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.闭合ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.边缘提取ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.二值图像边缘提取ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robert算子ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.差分梯度算子ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.拉普拉斯算子ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.加噪ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.去噪ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.高斯噪声ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.四邻域平均ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.八邻域平均ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最大值滤波ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最小值滤波ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中值滤波ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修正平均滤波ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.锐化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水平差分算法ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soble算子ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robert算子ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.prewitt算子ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.拉普拉斯算子ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robinson算子ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kirsch算子ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.模糊ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.表面模糊ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.模糊ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.表面模糊2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHSI = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duibi_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpiral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Besmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Binary)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(15, 29);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 441);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // btnGray
            // 
            this.btnGray.Location = new System.Drawing.Point(15, 58);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(75, 23);
            this.btnGray.TabIndex = 2;
            this.btnGray.Text = "灰度化";
            this.btnGray.UseVisualStyleBackColor = true;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // light_text
            // 
            this.light_text.AutoSize = true;
            this.light_text.Location = new System.Drawing.Point(6, 38);
            this.light_text.Name = "light_text";
            this.light_text.Size = new System.Drawing.Size(53, 12);
            this.light_text.TabIndex = 3;
            this.light_text.Text = "亮度调节";
            this.light_text.Click += new System.EventHandler(this.label1_Click);
            // 
            // Light_trackBar
            // 
            this.Light_trackBar.Location = new System.Drawing.Point(77, 24);
            this.Light_trackBar.Maximum = 255;
            this.Light_trackBar.Minimum = -255;
            this.Light_trackBar.Name = "Light_trackBar";
            this.Light_trackBar.Size = new System.Drawing.Size(104, 45);
            this.Light_trackBar.TabIndex = 4;
            this.Light_trackBar.Scroll += new System.EventHandler(this.Light_trackBar_Scroll);
            // 
            // btnlight
            // 
            this.btnlight.Location = new System.Drawing.Point(231, 29);
            this.btnlight.Name = "btnlight";
            this.btnlight.Size = new System.Drawing.Size(75, 23);
            this.btnlight.TabIndex = 5;
            this.btnlight.Text = "确定";
            this.btnlight.UseVisualStyleBackColor = true;
            this.btnlight.Click += new System.EventHandler(this.btnlight_Click);
            // 
            // textBox_Light
            // 
            this.textBox_Light.Location = new System.Drawing.Point(187, 29);
            this.textBox_Light.Name = "textBox_Light";
            this.textBox_Light.Size = new System.Drawing.Size(31, 21);
            this.textBox_Light.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 116);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "对比度调节";
            // 
            // duibi_trackBar
            // 
            this.duibi_trackBar.Location = new System.Drawing.Point(77, 73);
            this.duibi_trackBar.Maximum = 255;
            this.duibi_trackBar.Minimum = -255;
            this.duibi_trackBar.Name = "duibi_trackBar";
            this.duibi_trackBar.Size = new System.Drawing.Size(104, 45);
            this.duibi_trackBar.TabIndex = 9;
            this.duibi_trackBar.Scroll += new System.EventHandler(this.duibi_trackBar_Scroll);
            // 
            // textBox_Duibi
            // 
            this.textBox_Duibi.Location = new System.Drawing.Point(187, 80);
            this.textBox_Duibi.Name = "textBox_Duibi";
            this.textBox_Duibi.Size = new System.Drawing.Size(30, 21);
            this.textBox_Duibi.TabIndex = 10;
            // 
            // btnDuibi
            // 
            this.btnDuibi.Location = new System.Drawing.Point(231, 80);
            this.btnDuibi.Name = "btnDuibi";
            this.btnDuibi.Size = new System.Drawing.Size(75, 23);
            this.btnDuibi.TabIndex = 11;
            this.btnDuibi.Text = "确定";
            this.btnDuibi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDuibi.UseVisualStyleBackColor = true;
            this.btnDuibi.Click += new System.EventHandler(this.btnDuibi_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(459, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(449, 441);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSpiral);
            this.groupBox1.Controls.Add(this.textBoxSpiral);
            this.groupBox1.Controls.Add(this.trackBarSpiral);
            this.groupBox1.Controls.Add(this.trackBar_Besmall);
            this.groupBox1.Controls.Add(this.textBox_Besmall);
            this.groupBox1.Controls.Add(this.btnBesmall);
            this.groupBox1.Controls.Add(this.btnBinary);
            this.groupBox1.Controls.Add(this.textBox_Binary);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trackBar_Binary);
            this.groupBox1.Controls.Add(this.duibi_trackBar);
            this.groupBox1.Controls.Add(this.textBox_Duibi);
            this.groupBox1.Controls.Add(this.btnDuibi);
            this.groupBox1.Controls.Add(this.btnlight);
            this.groupBox1.Controls.Add(this.textBox_Light);
            this.groupBox1.Controls.Add(this.light_text);
            this.groupBox1.Controls.Add(this.Light_trackBar);
            this.groupBox1.Location = new System.Drawing.Point(12, 474);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 121);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "亮度、对比度、二值化";
            // 
            // btnSpiral
            // 
            this.btnSpiral.Location = new System.Drawing.Point(735, 33);
            this.btnSpiral.Name = "btnSpiral";
            this.btnSpiral.Size = new System.Drawing.Size(58, 23);
            this.btnSpiral.TabIndex = 24;
            this.btnSpiral.Text = "旋转";
            this.btnSpiral.UseVisualStyleBackColor = true;
            this.btnSpiral.Click += new System.EventHandler(this.btnSpiral_Click);
            // 
            // textBoxSpiral
            // 
            this.textBoxSpiral.Location = new System.Drawing.Point(696, 38);
            this.textBoxSpiral.Name = "textBoxSpiral";
            this.textBoxSpiral.Size = new System.Drawing.Size(33, 21);
            this.textBoxSpiral.TabIndex = 23;
            // 
            // trackBarSpiral
            // 
            this.trackBarSpiral.Location = new System.Drawing.Point(540, 26);
            this.trackBarSpiral.Maximum = 360;
            this.trackBarSpiral.Minimum = -360;
            this.trackBarSpiral.Name = "trackBarSpiral";
            this.trackBarSpiral.Size = new System.Drawing.Size(150, 45);
            this.trackBarSpiral.TabIndex = 22;
            this.trackBarSpiral.Scroll += new System.EventHandler(this.trackBarSpiral_Scroll);
            // 
            // trackBar_Besmall
            // 
            this.trackBar_Besmall.Location = new System.Drawing.Point(325, 70);
            this.trackBar_Besmall.Minimum = -10;
            this.trackBar_Besmall.Name = "trackBar_Besmall";
            this.trackBar_Besmall.Size = new System.Drawing.Size(104, 45);
            this.trackBar_Besmall.TabIndex = 21;
            this.trackBar_Besmall.Scroll += new System.EventHandler(this.trackBar_Besmall_Scroll);
            // 
            // textBox_Besmall
            // 
            this.textBox_Besmall.Location = new System.Drawing.Point(435, 80);
            this.textBox_Besmall.Name = "textBox_Besmall";
            this.textBox_Besmall.Size = new System.Drawing.Size(27, 21);
            this.textBox_Besmall.TabIndex = 20;
            // 
            // btnBesmall
            // 
            this.btnBesmall.Location = new System.Drawing.Point(468, 80);
            this.btnBesmall.Name = "btnBesmall";
            this.btnBesmall.Size = new System.Drawing.Size(66, 23);
            this.btnBesmall.TabIndex = 17;
            this.btnBesmall.Text = "图像缩放";
            this.btnBesmall.UseVisualStyleBackColor = true;
            this.btnBesmall.Click += new System.EventHandler(this.btnBesmall_Click);
            // 
            // btnBinary
            // 
            this.btnBinary.Location = new System.Drawing.Point(468, 35);
            this.btnBinary.Name = "btnBinary";
            this.btnBinary.Size = new System.Drawing.Size(66, 23);
            this.btnBinary.TabIndex = 16;
            this.btnBinary.Text = "二值化";
            this.btnBinary.UseVisualStyleBackColor = true;
            this.btnBinary.Click += new System.EventHandler(this.btnBinary_Click);
            // 
            // textBox_Binary
            // 
            this.textBox_Binary.Location = new System.Drawing.Point(435, 35);
            this.textBox_Binary.Name = "textBox_Binary";
            this.textBox_Binary.Size = new System.Drawing.Size(27, 21);
            this.textBox_Binary.TabIndex = 18;
            // 
            // trackBar_Binary
            // 
            this.trackBar_Binary.Location = new System.Drawing.Point(325, 26);
            this.trackBar_Binary.Maximum = 255;
            this.trackBar_Binary.Name = "trackBar_Binary";
            this.trackBar_Binary.Size = new System.Drawing.Size(104, 45);
            this.trackBar_Binary.TabIndex = 17;
            this.trackBar_Binary.Scroll += new System.EventHandler(this.trackBar_Binary_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开启ToolStripMenuItem,
            this.去噪ToolStripMenuItem,
            this.锐化ToolStripMenuItem,
            this.模糊ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1018, 25);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 开启ToolStripMenuItem
            // 
            this.开启ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开启ToolStripMenuItem1,
            this.闭合ToolStripMenuItem,
            this.边缘提取ToolStripMenuItem,
            this.加噪ToolStripMenuItem});
            this.开启ToolStripMenuItem.Name = "开启ToolStripMenuItem";
            this.开启ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.开启ToolStripMenuItem.Text = "图像形态学";
            this.开启ToolStripMenuItem.Click += new System.EventHandler(this.开启ToolStripMenuItem_Click);
            // 
            // 开启ToolStripMenuItem1
            // 
            this.开启ToolStripMenuItem1.Name = "开启ToolStripMenuItem1";
            this.开启ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.开启ToolStripMenuItem1.Text = "开启";
            this.开启ToolStripMenuItem1.Click += new System.EventHandler(this.开启ToolStripMenuItem1_Click);
            // 
            // 闭合ToolStripMenuItem
            // 
            this.闭合ToolStripMenuItem.Name = "闭合ToolStripMenuItem";
            this.闭合ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.闭合ToolStripMenuItem.Text = "闭合";
            this.闭合ToolStripMenuItem.Click += new System.EventHandler(this.闭合ToolStripMenuItem_Click);
            // 
            // 边缘提取ToolStripMenuItem
            // 
            this.边缘提取ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.二值图像边缘提取ToolStripMenuItem,
            this.robert算子ToolStripMenuItem,
            this.差分梯度算子ToolStripMenuItem,
            this.拉普拉斯算子ToolStripMenuItem1});
            this.边缘提取ToolStripMenuItem.Name = "边缘提取ToolStripMenuItem";
            this.边缘提取ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.边缘提取ToolStripMenuItem.Text = "边缘提取";
            this.边缘提取ToolStripMenuItem.Click += new System.EventHandler(this.边缘提取ToolStripMenuItem_Click);
            // 
            // 二值图像边缘提取ToolStripMenuItem
            // 
            this.二值图像边缘提取ToolStripMenuItem.Name = "二值图像边缘提取ToolStripMenuItem";
            this.二值图像边缘提取ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.二值图像边缘提取ToolStripMenuItem.Text = "二值图像边缘提取";
            this.二值图像边缘提取ToolStripMenuItem.Click += new System.EventHandler(this.二值图像边缘提取ToolStripMenuItem_Click);
            // 
            // robert算子ToolStripMenuItem
            // 
            this.robert算子ToolStripMenuItem.Name = "robert算子ToolStripMenuItem";
            this.robert算子ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.robert算子ToolStripMenuItem.Text = "robert算子";
            this.robert算子ToolStripMenuItem.Click += new System.EventHandler(this.robert算子ToolStripMenuItem_Click);
            // 
            // 差分梯度算子ToolStripMenuItem
            // 
            this.差分梯度算子ToolStripMenuItem.Name = "差分梯度算子ToolStripMenuItem";
            this.差分梯度算子ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.差分梯度算子ToolStripMenuItem.Text = "差分梯度算子";
            this.差分梯度算子ToolStripMenuItem.Click += new System.EventHandler(this.差分梯度算子ToolStripMenuItem_Click);
            // 
            // 拉普拉斯算子ToolStripMenuItem1
            // 
            this.拉普拉斯算子ToolStripMenuItem1.Name = "拉普拉斯算子ToolStripMenuItem1";
            this.拉普拉斯算子ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.拉普拉斯算子ToolStripMenuItem1.Text = "拉普拉斯算子";
            this.拉普拉斯算子ToolStripMenuItem1.Click += new System.EventHandler(this.拉普拉斯算子ToolStripMenuItem1_Click);
            // 
            // 加噪ToolStripMenuItem
            // 
            this.加噪ToolStripMenuItem.Name = "加噪ToolStripMenuItem";
            this.加噪ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.加噪ToolStripMenuItem.Text = "加噪";
            this.加噪ToolStripMenuItem.Click += new System.EventHandler(this.加噪ToolStripMenuItem_Click);
            // 
            // 去噪ToolStripMenuItem
            // 
            this.去噪ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.高斯噪声ToolStripMenuItem,
            this.四邻域平均ToolStripMenuItem,
            this.八邻域平均ToolStripMenuItem,
            this.最大值滤波ToolStripMenuItem,
            this.最小值滤波ToolStripMenuItem,
            this.中值滤波ToolStripMenuItem,
            this.修正平均滤波ToolStripMenuItem});
            this.去噪ToolStripMenuItem.Name = "去噪ToolStripMenuItem";
            this.去噪ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.去噪ToolStripMenuItem.Text = "去噪";
            // 
            // 高斯噪声ToolStripMenuItem
            // 
            this.高斯噪声ToolStripMenuItem.Name = "高斯噪声ToolStripMenuItem";
            this.高斯噪声ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.高斯噪声ToolStripMenuItem.Text = "高斯噪声";
            this.高斯噪声ToolStripMenuItem.Click += new System.EventHandler(this.高斯噪声ToolStripMenuItem_Click);
            // 
            // 四邻域平均ToolStripMenuItem
            // 
            this.四邻域平均ToolStripMenuItem.Name = "四邻域平均ToolStripMenuItem";
            this.四邻域平均ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.四邻域平均ToolStripMenuItem.Text = "四邻域平均";
            this.四邻域平均ToolStripMenuItem.Click += new System.EventHandler(this.四邻域平均ToolStripMenuItem_Click);
            // 
            // 八邻域平均ToolStripMenuItem
            // 
            this.八邻域平均ToolStripMenuItem.Name = "八邻域平均ToolStripMenuItem";
            this.八邻域平均ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.八邻域平均ToolStripMenuItem.Text = "八邻域平均";
            this.八邻域平均ToolStripMenuItem.Click += new System.EventHandler(this.八邻域平均ToolStripMenuItem_Click);
            // 
            // 最大值滤波ToolStripMenuItem
            // 
            this.最大值滤波ToolStripMenuItem.Name = "最大值滤波ToolStripMenuItem";
            this.最大值滤波ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.最大值滤波ToolStripMenuItem.Text = "最大值滤波";
            this.最大值滤波ToolStripMenuItem.Click += new System.EventHandler(this.最大值滤波ToolStripMenuItem_Click);
            // 
            // 最小值滤波ToolStripMenuItem
            // 
            this.最小值滤波ToolStripMenuItem.Name = "最小值滤波ToolStripMenuItem";
            this.最小值滤波ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.最小值滤波ToolStripMenuItem.Text = "最小值滤波";
            this.最小值滤波ToolStripMenuItem.Click += new System.EventHandler(this.最小值滤波ToolStripMenuItem_Click);
            // 
            // 中值滤波ToolStripMenuItem
            // 
            this.中值滤波ToolStripMenuItem.Name = "中值滤波ToolStripMenuItem";
            this.中值滤波ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.中值滤波ToolStripMenuItem.Text = "中值滤波";
            this.中值滤波ToolStripMenuItem.Click += new System.EventHandler(this.中值滤波ToolStripMenuItem_Click);
            // 
            // 修正平均滤波ToolStripMenuItem
            // 
            this.修正平均滤波ToolStripMenuItem.Name = "修正平均滤波ToolStripMenuItem";
            this.修正平均滤波ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.修正平均滤波ToolStripMenuItem.Text = "修正平均滤波";
            this.修正平均滤波ToolStripMenuItem.Click += new System.EventHandler(this.修正平均滤波ToolStripMenuItem_Click);
            // 
            // 锐化ToolStripMenuItem
            // 
            this.锐化ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.水平差分算法ToolStripMenuItem,
            this.soble算子ToolStripMenuItem,
            this.robert算子ToolStripMenuItem1,
            this.prewitt算子ToolStripMenuItem,
            this.拉普拉斯算子ToolStripMenuItem,
            this.robinson算子ToolStripMenuItem,
            this.kirsch算子ToolStripMenuItem});
            this.锐化ToolStripMenuItem.Name = "锐化ToolStripMenuItem";
            this.锐化ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.锐化ToolStripMenuItem.Text = "锐化";
            // 
            // 水平差分算法ToolStripMenuItem
            // 
            this.水平差分算法ToolStripMenuItem.Name = "水平差分算法ToolStripMenuItem";
            this.水平差分算法ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.水平差分算法ToolStripMenuItem.Text = "差分梯度算法";
            this.水平差分算法ToolStripMenuItem.Click += new System.EventHandler(this.水平差分算法ToolStripMenuItem_Click);
            // 
            // soble算子ToolStripMenuItem
            // 
            this.soble算子ToolStripMenuItem.Name = "soble算子ToolStripMenuItem";
            this.soble算子ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.soble算子ToolStripMenuItem.Text = "robert算子";
            this.soble算子ToolStripMenuItem.Click += new System.EventHandler(this.soble算子ToolStripMenuItem_Click);
            // 
            // robert算子ToolStripMenuItem1
            // 
            this.robert算子ToolStripMenuItem1.Name = "robert算子ToolStripMenuItem1";
            this.robert算子ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.robert算子ToolStripMenuItem1.Text = "soble算子";
            this.robert算子ToolStripMenuItem1.Click += new System.EventHandler(this.robert算子ToolStripMenuItem1_Click);
            // 
            // prewitt算子ToolStripMenuItem
            // 
            this.prewitt算子ToolStripMenuItem.Name = "prewitt算子ToolStripMenuItem";
            this.prewitt算子ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.prewitt算子ToolStripMenuItem.Text = "prewitt算子";
            this.prewitt算子ToolStripMenuItem.Click += new System.EventHandler(this.prewitt算子ToolStripMenuItem_Click);
            // 
            // 拉普拉斯算子ToolStripMenuItem
            // 
            this.拉普拉斯算子ToolStripMenuItem.Name = "拉普拉斯算子ToolStripMenuItem";
            this.拉普拉斯算子ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.拉普拉斯算子ToolStripMenuItem.Text = "拉普拉斯算子";
            this.拉普拉斯算子ToolStripMenuItem.Click += new System.EventHandler(this.拉普拉斯算子ToolStripMenuItem_Click);
            // 
            // robinson算子ToolStripMenuItem
            // 
            this.robinson算子ToolStripMenuItem.Name = "robinson算子ToolStripMenuItem";
            this.robinson算子ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.robinson算子ToolStripMenuItem.Text = "robinson算子";
            this.robinson算子ToolStripMenuItem.Click += new System.EventHandler(this.robinson算子ToolStripMenuItem_Click);
            // 
            // kirsch算子ToolStripMenuItem
            // 
            this.kirsch算子ToolStripMenuItem.Name = "kirsch算子ToolStripMenuItem";
            this.kirsch算子ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kirsch算子ToolStripMenuItem.Text = "kirsch算子";
            this.kirsch算子ToolStripMenuItem.Click += new System.EventHandler(this.kirsch算子ToolStripMenuItem_Click);
            // 
            // 模糊ToolStripMenuItem
            // 
            this.模糊ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.表面模糊ToolStripMenuItem,
            this.模糊ToolStripMenuItem1,
            this.表面模糊2ToolStripMenuItem,
            this.导入ToolStripMenuItem});
            this.模糊ToolStripMenuItem.Name = "模糊ToolStripMenuItem";
            this.模糊ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.模糊ToolStripMenuItem.Text = "模糊";
            // 
            // 表面模糊ToolStripMenuItem
            // 
            this.表面模糊ToolStripMenuItem.Name = "表面模糊ToolStripMenuItem";
            this.表面模糊ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.表面模糊ToolStripMenuItem.Text = "表面模糊";
            this.表面模糊ToolStripMenuItem.Click += new System.EventHandler(this.表面模糊ToolStripMenuItem_Click);
            // 
            // 模糊ToolStripMenuItem1
            // 
            this.模糊ToolStripMenuItem1.Name = "模糊ToolStripMenuItem1";
            this.模糊ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.模糊ToolStripMenuItem1.Text = "模糊";
            this.模糊ToolStripMenuItem1.Click += new System.EventHandler(this.模糊ToolStripMenuItem1_Click);
            // 
            // 表面模糊2ToolStripMenuItem
            // 
            this.表面模糊2ToolStripMenuItem.Name = "表面模糊2ToolStripMenuItem";
            this.表面模糊2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.表面模糊2ToolStripMenuItem.Text = "表面模糊2";
            this.表面模糊2ToolStripMenuItem.Click += new System.EventHandler(this.表面模糊2ToolStripMenuItem_Click);
            // 
            // btnHSI
            // 
            this.btnHSI.Location = new System.Drawing.Point(15, 87);
            this.btnHSI.Name = "btnHSI";
            this.btnHSI.Size = new System.Drawing.Size(75, 23);
            this.btnHSI.TabIndex = 21;
            this.btnHSI.Text = "HSI";
            this.btnHSI.UseVisualStyleBackColor = true;
            this.btnHSI.Click += new System.EventHandler(this.btnHSI_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Controls.Add(this.btnHSI);
            this.groupBox2.Controls.Add(this.btnGray);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Location = new System.Drawing.Point(914, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(104, 151);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "工具";
            // 
            // 导入ToolStripMenuItem
            // 
            this.导入ToolStripMenuItem.Name = "导入ToolStripMenuItem";
            this.导入ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.导入ToolStripMenuItem.Text = "导入";
            this.导入ToolStripMenuItem.Click += new System.EventHandler(this.导入ToolStripMenuItem_Click);
            // 
            // express1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 596);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "express1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duibi_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpiral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Besmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Binary)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.Label light_text;
        private System.Windows.Forms.TrackBar Light_trackBar;
        private System.Windows.Forms.Button btnlight;
        private System.Windows.Forms.TextBox textBox_Light;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar duibi_trackBar;
        private System.Windows.Forms.TextBox textBox_Duibi;
        private System.Windows.Forms.Button btnDuibi;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBinary;
        private System.Windows.Forms.TrackBar trackBar_Binary;
        private System.Windows.Forms.TextBox textBox_Binary;
        private System.Windows.Forms.Button btnBesmall;
        private System.Windows.Forms.TextBox textBox_Besmall;
        private System.Windows.Forms.TrackBar trackBar_Besmall;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 开启ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开启ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 闭合ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 边缘提取ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 去噪ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 高斯噪声ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 四邻域平均ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 八邻域平均ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最大值滤波ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最小值滤波ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中值滤波ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修正平均滤波ToolStripMenuItem;
        private System.Windows.Forms.Button btnHSI;
        private System.Windows.Forms.ToolStripMenuItem 二值图像边缘提取ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem robert算子ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem 模糊ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 锐化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水平差分算法ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soble算子ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem robert算子ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 表面模糊ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 模糊ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 表面模糊2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prewitt算子ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 拉普拉斯算子ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem robinson算子ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kirsch算子ToolStripMenuItem;
        private System.Windows.Forms.Button btnSpiral;
        private System.Windows.Forms.TextBox textBoxSpiral;
        private System.Windows.Forms.TrackBar trackBarSpiral;
        private System.Windows.Forms.ToolStripMenuItem 加噪ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 差分梯度算子ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 拉普拉斯算子ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 导入ToolStripMenuItem;
    }
}

