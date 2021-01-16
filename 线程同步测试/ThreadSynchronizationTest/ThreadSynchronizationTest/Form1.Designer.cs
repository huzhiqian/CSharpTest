namespace ThreadSynchronizationTest
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
            this.btn_TriggerCamera = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Cam1Done = new System.Windows.Forms.Button();
            this.btn_Cam2Done = new System.Windows.Forms.Button();
            this.btn_Cam3Done = new System.Windows.Forms.Button();
            this.btn_Cam5Done = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_TriggerCamera
            // 
            this.btn_TriggerCamera.Location = new System.Drawing.Point(52, 46);
            this.btn_TriggerCamera.Name = "btn_TriggerCamera";
            this.btn_TriggerCamera.Size = new System.Drawing.Size(130, 41);
            this.btn_TriggerCamera.TabIndex = 0;
            this.btn_TriggerCamera.Text = "触发相机";
            this.btn_TriggerCamera.UseVisualStyleBackColor = true;
            this.btn_TriggerCamera.Click += new System.EventHandler(this.btn_TriggerCamera_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(312, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(375, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "ms";
            // 
            // btn_Cam1Done
            // 
            this.btn_Cam1Done.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cam1Done.Location = new System.Drawing.Point(32, 216);
            this.btn_Cam1Done.Name = "btn_Cam1Done";
            this.btn_Cam1Done.Size = new System.Drawing.Size(130, 44);
            this.btn_Cam1Done.TabIndex = 3;
            this.btn_Cam1Done.Text = "Cam1Complete";
            this.btn_Cam1Done.UseVisualStyleBackColor = true;
            this.btn_Cam1Done.Click += new System.EventHandler(this.btn_Cam1Done_Click);
            // 
            // btn_Cam2Done
            // 
            this.btn_Cam2Done.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cam2Done.Location = new System.Drawing.Point(179, 216);
            this.btn_Cam2Done.Name = "btn_Cam2Done";
            this.btn_Cam2Done.Size = new System.Drawing.Size(130, 44);
            this.btn_Cam2Done.TabIndex = 4;
            this.btn_Cam2Done.Text = "Cam2Complete";
            this.btn_Cam2Done.UseVisualStyleBackColor = true;
            this.btn_Cam2Done.Click += new System.EventHandler(this.btn_Cam2Done_Click);
            // 
            // btn_Cam3Done
            // 
            this.btn_Cam3Done.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cam3Done.Location = new System.Drawing.Point(326, 216);
            this.btn_Cam3Done.Name = "btn_Cam3Done";
            this.btn_Cam3Done.Size = new System.Drawing.Size(130, 44);
            this.btn_Cam3Done.TabIndex = 5;
            this.btn_Cam3Done.Text = "Cam3Complete";
            this.btn_Cam3Done.UseVisualStyleBackColor = true;
            this.btn_Cam3Done.Click += new System.EventHandler(this.btn_Cam3Done_Click);
            // 
            // btn_Cam5Done
            // 
            this.btn_Cam5Done.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cam5Done.Location = new System.Drawing.Point(473, 216);
            this.btn_Cam5Done.Name = "btn_Cam5Done";
            this.btn_Cam5Done.Size = new System.Drawing.Size(130, 44);
            this.btn_Cam5Done.TabIndex = 6;
            this.btn_Cam5Done.Text = "Cam4Complete";
            this.btn_Cam5Done.UseVisualStyleBackColor = true;
            this.btn_Cam5Done.Click += new System.EventHandler(this.btn_Cam5Done_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 242);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 17);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(630, 222);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Cam5Done);
            this.Controls.Add(this.btn_Cam3Done);
            this.Controls.Add(this.btn_Cam2Done);
            this.Controls.Add(this.btn_Cam1Done);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_TriggerCamera);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TriggerCamera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Cam1Done;
        private System.Windows.Forms.Button btn_Cam2Done;
        private System.Windows.Forms.Button btn_Cam3Done;
        private System.Windows.Forms.Button btn_Cam5Done;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

