namespace RoundButtonTestProj
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
            this.button1 = new System.Windows.Forms.Button();
            this.roundButton3 = new RoundButton.RoundButton();
            this.roundButton2 = new RoundButton.RoundButton();
            this.roundButton1 = new RoundButton.RoundButton();
            this.rectButton1 = new RectButton.RectButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(61, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 131);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // roundButton3
            // 
            this.roundButton3.BorderWidth = 4;
            this.roundButton3.DistanceToBorder = 4;
            this.roundButton3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.roundButton3.Location = new System.Drawing.Point(386, 124);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(148, 148);
            this.roundButton3.TabIndex = 2;
            this.roundButton3.Text = "测试";
            this.roundButton3.UseVisualStyleBackColor = true;
            // 
            // roundButton2
            // 
            this.roundButton2.BorderWidth = 4;
            this.roundButton2.ButtonCenterColorEnd = System.Drawing.Color.Red;
            this.roundButton2.ButtonCenterColorStart = System.Drawing.Color.DeepPink;
            this.roundButton2.DistanceToBorder = 4;
            this.roundButton2.FocusBorderColor = System.Drawing.Color.Black;
            this.roundButton2.IsShowIcon = true;
            this.roundButton2.Location = new System.Drawing.Point(278, 157);
            this.roundButton2.Margin = new System.Windows.Forms.Padding(2);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(47, 47);
            this.roundButton2.TabIndex = 1;
            this.roundButton2.Text = "roundButton2";
            this.roundButton2.UseVisualStyleBackColor = true;
            // 
            // roundButton1
            // 
            this.roundButton1.BorderWidth = 4;
            this.roundButton1.ButtonCenterColorEnd = System.Drawing.Color.Red;
            this.roundButton1.ButtonCenterColorStart = System.Drawing.Color.DeepPink;
            this.roundButton1.DistanceToBorder = 4;
            this.roundButton1.FocusBorderColor = System.Drawing.Color.Black;
            this.roundButton1.Location = new System.Drawing.Point(252, 40);
            this.roundButton1.Margin = new System.Windows.Forms.Padding(2);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(97, 97);
            this.roundButton1.TabIndex = 0;
            this.roundButton1.Text = "roundButton1";
            this.roundButton1.UseVisualStyleBackColor = true;
            // 
            // rectButton1
            // 
            this.rectButton1.BorderWidth = 4;
            this.rectButton1.DistanceToBorder = 4;
            this.rectButton1.Location = new System.Drawing.Point(257, 256);
            this.rectButton1.Name = "rectButton1";
            this.rectButton1.Size = new System.Drawing.Size(110, 83);
            this.rectButton1.TabIndex = 4;
            this.rectButton1.Text = "rectButton1";
            this.rectButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.rectButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.roundButton3);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RoundButton.RoundButton roundButton1;
        private RoundButton.RoundButton roundButton2;
        private RoundButton.RoundButton roundButton3;
        private System.Windows.Forms.Button button1;
        private RectButton.RectButton rectButton1;
    }
}

