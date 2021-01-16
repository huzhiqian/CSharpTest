namespace SerializeTest2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Serialize = new System.Windows.Forms.Button();
            this.btn_Deserialize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_main_Int = new System.Windows.Forms.TextBox();
            this.tbx_main_Double = new System.Windows.Forms.TextBox();
            this.tbx_main_String = new System.Windows.Forms.TextBox();
            this.tbx_Inner_String = new System.Windows.Forms.TextBox();
            this.tbx_Inner_Double = new System.Windows.Forms.TextBox();
            this.tbx_Inner_Int = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_main_String);
            this.groupBox1.Controls.Add(this.tbx_main_Double);
            this.groupBox1.Controls.Add(this.tbx_main_Int);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MainObject";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbx_Inner_String);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbx_Inner_Double);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbx_Inner_Int);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(264, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 202);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "InnerObject";
            // 
            // btn_Serialize
            // 
            this.btn_Serialize.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Serialize.Location = new System.Drawing.Point(75, 220);
            this.btn_Serialize.Name = "btn_Serialize";
            this.btn_Serialize.Size = new System.Drawing.Size(136, 42);
            this.btn_Serialize.TabIndex = 2;
            this.btn_Serialize.Text = "序列化保存";
            this.btn_Serialize.UseVisualStyleBackColor = true;
            this.btn_Serialize.Click += new System.EventHandler(this.btn_Serialize_Click);
            // 
            // btn_Deserialize
            // 
            this.btn_Deserialize.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Deserialize.Location = new System.Drawing.Point(309, 220);
            this.btn_Deserialize.Name = "btn_Deserialize";
            this.btn_Deserialize.Size = new System.Drawing.Size(136, 42);
            this.btn_Deserialize.TabIndex = 3;
            this.btn_Deserialize.Text = "反序列化加载";
            this.btn_Deserialize.UseVisualStyleBackColor = true;
            this.btn_Deserialize.Click += new System.EventHandler(this.btn_Deserialize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Int_Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Double_Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "String_Value:";
            // 
            // tbx_main_Int
            // 
            this.tbx_main_Int.Location = new System.Drawing.Point(127, 45);
            this.tbx_main_Int.Name = "tbx_main_Int";
            this.tbx_main_Int.Size = new System.Drawing.Size(110, 26);
            this.tbx_main_Int.TabIndex = 3;
            this.tbx_main_Int.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_main_Int_KeyDown);
            // 
            // tbx_main_Double
            // 
            this.tbx_main_Double.Location = new System.Drawing.Point(127, 90);
            this.tbx_main_Double.Name = "tbx_main_Double";
            this.tbx_main_Double.Size = new System.Drawing.Size(110, 26);
            this.tbx_main_Double.TabIndex = 4;
            this.tbx_main_Double.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_main_Double_KeyDown);
            // 
            // tbx_main_String
            // 
            this.tbx_main_String.Location = new System.Drawing.Point(127, 138);
            this.tbx_main_String.Name = "tbx_main_String";
            this.tbx_main_String.Size = new System.Drawing.Size(110, 26);
            this.tbx_main_String.TabIndex = 5;
            this.tbx_main_String.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_main_String_KeyDown);
            // 
            // tbx_Inner_String
            // 
            this.tbx_Inner_String.Location = new System.Drawing.Point(123, 131);
            this.tbx_Inner_String.Name = "tbx_Inner_String";
            this.tbx_Inner_String.Size = new System.Drawing.Size(110, 26);
            this.tbx_Inner_String.TabIndex = 11;
            this.tbx_Inner_String.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_Inner_String_KeyDown);
            // 
            // tbx_Inner_Double
            // 
            this.tbx_Inner_Double.Location = new System.Drawing.Point(123, 83);
            this.tbx_Inner_Double.Name = "tbx_Inner_Double";
            this.tbx_Inner_Double.Size = new System.Drawing.Size(110, 26);
            this.tbx_Inner_Double.TabIndex = 10;
            this.tbx_Inner_Double.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_Inner_Double_KeyDown);
            // 
            // tbx_Inner_Int
            // 
            this.tbx_Inner_Int.Location = new System.Drawing.Point(123, 38);
            this.tbx_Inner_Int.Name = "tbx_Inner_Int";
            this.tbx_Inner_Int.Size = new System.Drawing.Size(110, 26);
            this.tbx_Inner_Int.TabIndex = 9;
            this.tbx_Inner_Int.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_Inner_Int_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "String_Value:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Double_Value:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Int_Value:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 283);
            this.Controls.Add(this.btn_Deserialize);
            this.Controls.Add(this.btn_Serialize);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "序列化测试";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbx_main_String;
        private System.Windows.Forms.TextBox tbx_main_Double;
        private System.Windows.Forms.TextBox tbx_main_Int;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbx_Inner_String;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_Inner_Double;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_Inner_Int;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Serialize;
        private System.Windows.Forms.Button btn_Deserialize;
    }
}

