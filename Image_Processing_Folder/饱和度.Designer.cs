
namespace Image_Processing_Folder
{
    partial class 饱和度
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
            this.button1 = new System.Windows.Forms.Button();
            this.trackBarH = new System.Windows.Forms.TrackBar();
            this.trackBarS = new System.Windows.Forms.TrackBar();
            this.trackBarI = new System.Windows.Forms.TrackBar();
            this.textBox_H = new System.Windows.Forms.TextBox();
            this.textBox_S = new System.Windows.Forms.TextBox();
            this.textBox_I = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarI)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBarH
            // 
            this.trackBarH.Location = new System.Drawing.Point(166, 46);
            this.trackBarH.Maximum = 360;
            this.trackBarH.Name = "trackBarH";
            this.trackBarH.Size = new System.Drawing.Size(104, 45);
            this.trackBarH.TabIndex = 1;
            this.trackBarH.Scroll += new System.EventHandler(this.trackBarH_Scroll);
            // 
            // trackBarS
            // 
            this.trackBarS.Location = new System.Drawing.Point(166, 97);
            this.trackBarS.Maximum = 100;
            this.trackBarS.Minimum = -100;
            this.trackBarS.Name = "trackBarS";
            this.trackBarS.Size = new System.Drawing.Size(104, 45);
            this.trackBarS.TabIndex = 2;
            this.trackBarS.Scroll += new System.EventHandler(this.trackBarS_Scroll);
            // 
            // trackBarI
            // 
            this.trackBarI.Location = new System.Drawing.Point(166, 148);
            this.trackBarI.Maximum = 100;
            this.trackBarI.Minimum = -100;
            this.trackBarI.Name = "trackBarI";
            this.trackBarI.Size = new System.Drawing.Size(104, 45);
            this.trackBarI.TabIndex = 3;
            this.trackBarI.Scroll += new System.EventHandler(this.trackBarI_Scroll);
            // 
            // textBox_H
            // 
            this.textBox_H.Location = new System.Drawing.Point(294, 46);
            this.textBox_H.Name = "textBox_H";
            this.textBox_H.Size = new System.Drawing.Size(43, 21);
            this.textBox_H.TabIndex = 4;
            // 
            // textBox_S
            // 
            this.textBox_S.Location = new System.Drawing.Point(294, 97);
            this.textBox_S.Name = "textBox_S";
            this.textBox_S.Size = new System.Drawing.Size(43, 21);
            this.textBox_S.TabIndex = 5;
            // 
            // textBox_I
            // 
            this.textBox_I.Location = new System.Drawing.Point(294, 157);
            this.textBox_I.Name = "textBox_I";
            this.textBox_I.Size = new System.Drawing.Size(43, 21);
            this.textBox_I.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "H";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "S";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "I";
            // 
            // 饱和度
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 258);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_I);
            this.Controls.Add(this.textBox_S);
            this.Controls.Add(this.textBox_H);
            this.Controls.Add(this.trackBarI);
            this.Controls.Add(this.trackBarS);
            this.Controls.Add(this.trackBarH);
            this.Controls.Add(this.button1);
            this.Name = "饱和度";
            this.Text = "饱和度";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TrackBar trackBarH;
        public System.Windows.Forms.TrackBar trackBarS;
        public System.Windows.Forms.TrackBar trackBarI;
        private System.Windows.Forms.TextBox textBox_H;
        private System.Windows.Forms.TextBox textBox_S;
        private System.Windows.Forms.TextBox textBox_I;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button button1;
    }
}