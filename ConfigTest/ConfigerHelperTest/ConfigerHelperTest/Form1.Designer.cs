namespace ConfigerHelperTest
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
            this.btn_Write = new System.Windows.Forms.Button();
            this.tbx_Write_Key = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_write_Value = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbx_Read_Value = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Read = new System.Windows.Forms.Button();
            this.tbx_Read_Key = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_StopTest = new System.Windows.Forms.Button();
            this.btn_StartTest = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbx_ReadData = new System.Windows.Forms.ListBox();
            this.lbx_WriteData = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_Speed_key = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Write
            // 
            this.btn_Write.Location = new System.Drawing.Point(416, 32);
            this.btn_Write.Name = "btn_Write";
            this.btn_Write.Size = new System.Drawing.Size(94, 29);
            this.btn_Write.TabIndex = 0;
            this.btn_Write.Text = "写入";
            this.btn_Write.UseVisualStyleBackColor = true;
            this.btn_Write.Click += new System.EventHandler(this.btn_Write_Click);
            // 
            // tbx_Write_Key
            // 
            this.tbx_Write_Key.Location = new System.Drawing.Point(59, 37);
            this.tbx_Write_Key.Name = "tbx_Write_Key";
            this.tbx_Write_Key.Size = new System.Drawing.Size(100, 21);
            this.tbx_Write_Key.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_write_Value);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Write);
            this.groupBox1.Controls.Add(this.tbx_Write_Key);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "写入配置项";
            // 
            // tbx_write_Value
            // 
            this.tbx_write_Value.Location = new System.Drawing.Point(233, 37);
            this.tbx_write_Value.Name = "tbx_write_Value";
            this.tbx_write_Value.Size = new System.Drawing.Size(142, 21);
            this.tbx_write_Value.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Value:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Key:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbx_Read_Value);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_Read);
            this.groupBox2.Controls.Add(this.tbx_Read_Key);
            this.groupBox2.Location = new System.Drawing.Point(12, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 81);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "读取配置项";
            // 
            // tbx_Read_Value
            // 
            this.tbx_Read_Value.Location = new System.Drawing.Point(233, 37);
            this.tbx_Read_Value.Name = "tbx_Read_Value";
            this.tbx_Read_Value.Size = new System.Drawing.Size(142, 21);
            this.tbx_Read_Value.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Value:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Key:";
            // 
            // btn_Read
            // 
            this.btn_Read.Location = new System.Drawing.Point(416, 32);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(94, 29);
            this.btn_Read.TabIndex = 0;
            this.btn_Read.Text = "读取";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // tbx_Read_Key
            // 
            this.tbx_Read_Key.Location = new System.Drawing.Point(59, 37);
            this.tbx_Read_Key.Name = "tbx_Read_Key";
            this.tbx_Read_Key.Size = new System.Drawing.Size(100, 21);
            this.tbx_Read_Key.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_StopTest);
            this.groupBox3.Controls.Add(this.btn_StartTest);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lbx_ReadData);
            this.groupBox3.Controls.Add(this.lbx_WriteData);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbx_Speed_key);
            this.groupBox3.Location = new System.Drawing.Point(12, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(538, 266);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "速度与性能测试";
            // 
            // btn_StopTest
            // 
            this.btn_StopTest.BackColor = System.Drawing.Color.White;
            this.btn_StopTest.Location = new System.Drawing.Point(394, 148);
            this.btn_StopTest.Name = "btn_StopTest";
            this.btn_StopTest.Size = new System.Drawing.Size(116, 49);
            this.btn_StopTest.TabIndex = 10;
            this.btn_StopTest.Text = "停止测试";
            this.btn_StopTest.UseVisualStyleBackColor = false;
            this.btn_StopTest.Click += new System.EventHandler(this.btn_StopTest_Click);
            // 
            // btn_StartTest
            // 
            this.btn_StartTest.BackColor = System.Drawing.Color.White;
            this.btn_StartTest.Location = new System.Drawing.Point(394, 78);
            this.btn_StartTest.Name = "btn_StartTest";
            this.btn_StartTest.Size = new System.Drawing.Size(116, 49);
            this.btn_StartTest.TabIndex = 9;
            this.btn_StartTest.Text = "开始测试";
            this.btn_StartTest.UseVisualStyleBackColor = false;
            this.btn_StartTest.Click += new System.EventHandler(this.btn_StaetTest_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "读取值";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "写入值";
            // 
            // lbx_ReadData
            // 
            this.lbx_ReadData.FormattingEnabled = true;
            this.lbx_ReadData.ItemHeight = 12;
            this.lbx_ReadData.Location = new System.Drawing.Point(202, 78);
            this.lbx_ReadData.Name = "lbx_ReadData";
            this.lbx_ReadData.Size = new System.Drawing.Size(159, 172);
            this.lbx_ReadData.TabIndex = 6;
            // 
            // lbx_WriteData
            // 
            this.lbx_WriteData.FormattingEnabled = true;
            this.lbx_WriteData.ItemHeight = 12;
            this.lbx_WriteData.Location = new System.Drawing.Point(26, 78);
            this.lbx_WriteData.Name = "lbx_WriteData";
            this.lbx_WriteData.Size = new System.Drawing.Size(170, 172);
            this.lbx_WriteData.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Key:";
            // 
            // tbx_Speed_key
            // 
            this.tbx_Speed_key.Location = new System.Drawing.Point(59, 20);
            this.tbx_Speed_key.Name = "tbx_Speed_key";
            this.tbx_Speed_key.Size = new System.Drawing.Size(100, 21);
            this.tbx_Speed_key.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 537);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Write;
        private System.Windows.Forms.TextBox tbx_Write_Key;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbx_write_Value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbx_Read_Value;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.TextBox tbx_Read_Key;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_StopTest;
        private System.Windows.Forms.Button btn_StartTest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbx_ReadData;
        private System.Windows.Forms.ListBox lbx_WriteData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_Speed_key;
    }
}

