namespace NoneBorderWndTest
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fcButton3 = new FormEx.FCButton();
            this.fcButton2 = new FormEx.FCButton();
            this.fcButton1 = new FormEx.FCButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fcButton3
            // 
            this.fcButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fcButton3.BackgroundImage")));
            this.fcButton3.ButtonType = FormEx.ButtonType.Minimize;
            this.fcButton3.DefaultImage = ((System.Drawing.Image)(resources.GetObject("fcButton3.DefaultImage")));
            this.fcButton3.Location = new System.Drawing.Point(261, 134);
            this.fcButton3.MouseDownColor = System.Drawing.Color.DodgerBlue;
            this.fcButton3.MouseEnterColor = System.Drawing.Color.White;
            this.fcButton3.MouseLeaveColor = System.Drawing.Color.White;
            this.fcButton3.MouseUpColor = System.Drawing.Color.White;
            this.fcButton3.Name = "fcButton3";
            this.fcButton3.Size = new System.Drawing.Size(16, 16);
            this.fcButton3.TabIndex = 2;
            // 
            // fcButton2
            // 
            this.fcButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fcButton2.BackgroundImage")));
            this.fcButton2.ButtonType = FormEx.ButtonType.MaxNormal;
            this.fcButton2.DefaultImage = ((System.Drawing.Image)(resources.GetObject("fcButton2.DefaultImage")));
            this.fcButton2.Location = new System.Drawing.Point(297, 134);
            this.fcButton2.MouseDownColor = System.Drawing.Color.Blue;
            this.fcButton2.MouseEnterColor = System.Drawing.Color.White;
            this.fcButton2.MouseLeaveColor = System.Drawing.Color.White;
            this.fcButton2.MouseUpColor = System.Drawing.Color.Blue;
            this.fcButton2.Name = "fcButton2";
            this.fcButton2.Size = new System.Drawing.Size(16, 16);
            this.fcButton2.TabIndex = 1;
            // 
            // fcButton1
            // 
            this.fcButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fcButton1.BackgroundImage")));
            this.fcButton1.ButtonType = FormEx.ButtonType.Close;
            this.fcButton1.DefaultImage = ((System.Drawing.Image)(resources.GetObject("fcButton1.DefaultImage")));
            this.fcButton1.Location = new System.Drawing.Point(330, 134);
            this.fcButton1.MouseDownColor = System.Drawing.Color.Blue;
            this.fcButton1.MouseEnterColor = System.Drawing.Color.White;
            this.fcButton1.MouseLeaveColor = System.Drawing.Color.White;
            this.fcButton1.MouseUpColor = System.Drawing.Color.Blue;
            this.fcButton1.Name = "fcButton1";
            this.fcButton1.Size = new System.Drawing.Size(16, 16);
            this.fcButton1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "ShowForm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "ShowMessageBox";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(141, 326);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 47);
            this.button3.TabIndex = 5;
            this.button3.Text = "Test";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 394);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fcButton3);
            this.Controls.Add(this.fcButton2);
            this.Controls.Add(this.fcButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.fcButton1, 0);
            this.Controls.SetChildIndex(this.fcButton2, 0);
            this.Controls.SetChildIndex(this.fcButton3, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private FormEx.FCButton fcButton1;
        private FormEx.FCButton fcButton2;
        private FormEx.FCButton fcButton3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

