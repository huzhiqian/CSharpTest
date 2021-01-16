namespace CustomSerializationTest
{
    partial class SerializeObjInfoCtrl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.hWindowControl1 = new HalconDotNet.HWindowControl();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_ImageName = new System.Windows.Forms.TextBox();
            this.tbx_ImageID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_CreateTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_SerializeType = new System.Windows.Forms.TextBox();
            this.btn_SerializeSave = new System.Windows.Forms.Button();
            this.btn_DeserializeLoad = new System.Windows.Forms.Button();
            this.lst_Info = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_HTuple = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // hWindowControl1
            // 
            this.hWindowControl1.BackColor = System.Drawing.Color.Black;
            this.hWindowControl1.BorderColor = System.Drawing.Color.Black;
            this.hWindowControl1.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindowControl1.Location = new System.Drawing.Point(5, 5);
            this.hWindowControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hWindowControl1.Name = "hWindowControl1";
            this.hWindowControl1.Size = new System.Drawing.Size(203, 195);
            this.hWindowControl1.TabIndex = 0;
            this.hWindowControl1.WindowSize = new System.Drawing.Size(203, 195);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "图片名称：";
            // 
            // tbx_ImageName
            // 
            this.tbx_ImageName.Location = new System.Drawing.Point(290, 13);
            this.tbx_ImageName.Name = "tbx_ImageName";
            this.tbx_ImageName.Size = new System.Drawing.Size(100, 26);
            this.tbx_ImageName.TabIndex = 2;
            this.tbx_ImageName.Leave += new System.EventHandler(this.tbx_ImageName_Leave);
            // 
            // tbx_ImageID
            // 
            this.tbx_ImageID.Location = new System.Drawing.Point(290, 56);
            this.tbx_ImageID.Name = "tbx_ImageID";
            this.tbx_ImageID.Size = new System.Drawing.Size(100, 26);
            this.tbx_ImageID.TabIndex = 4;
            this.tbx_ImageID.Leave += new System.EventHandler(this.tbx_ImageID_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "图片ID：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "创建时间：";
            // 
            // tbx_CreateTime
            // 
            this.tbx_CreateTime.Location = new System.Drawing.Point(290, 91);
            this.tbx_CreateTime.Name = "tbx_CreateTime";
            this.tbx_CreateTime.Size = new System.Drawing.Size(100, 26);
            this.tbx_CreateTime.TabIndex = 6;
            this.tbx_CreateTime.Leave += new System.EventHandler(this.tbx_CreateTime_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "序列化格式：";
            // 
            // tbx_SerializeType
            // 
            this.tbx_SerializeType.Location = new System.Drawing.Point(303, 128);
            this.tbx_SerializeType.Name = "tbx_SerializeType";
            this.tbx_SerializeType.Size = new System.Drawing.Size(87, 26);
            this.tbx_SerializeType.TabIndex = 8;
            this.tbx_SerializeType.Leave += new System.EventHandler(this.tbx_SerializeType_Leave);
            // 
            // btn_SerializeSave
            // 
            this.btn_SerializeSave.Location = new System.Drawing.Point(3, 224);
            this.btn_SerializeSave.Name = "btn_SerializeSave";
            this.btn_SerializeSave.Size = new System.Drawing.Size(161, 44);
            this.btn_SerializeSave.TabIndex = 9;
            this.btn_SerializeSave.Text = "序列化保存";
            this.btn_SerializeSave.UseVisualStyleBackColor = true;
            this.btn_SerializeSave.Click += new System.EventHandler(this.btn_SerializeSave_Click);
            // 
            // btn_DeserializeLoad
            // 
            this.btn_DeserializeLoad.Location = new System.Drawing.Point(218, 224);
            this.btn_DeserializeLoad.Name = "btn_DeserializeLoad";
            this.btn_DeserializeLoad.Size = new System.Drawing.Size(161, 44);
            this.btn_DeserializeLoad.TabIndex = 10;
            this.btn_DeserializeLoad.Text = "反序列化加载";
            this.btn_DeserializeLoad.UseVisualStyleBackColor = true;
            this.btn_DeserializeLoad.Click += new System.EventHandler(this.btn_DeserializeLoad_Click);
            // 
            // lst_Info
            // 
            this.lst_Info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lst_Info.FormattingEnabled = true;
            this.lst_Info.ItemHeight = 19;
            this.lst_Info.Location = new System.Drawing.Point(0, 275);
            this.lst_Info.Name = "lst_Info";
            this.lst_Info.Size = new System.Drawing.Size(395, 175);
            this.lst_Info.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "HTuple值：";
            // 
            // tbx_HTuple
            // 
            this.tbx_HTuple.Location = new System.Drawing.Point(301, 167);
            this.tbx_HTuple.Name = "tbx_HTuple";
            this.tbx_HTuple.Size = new System.Drawing.Size(87, 26);
            this.tbx_HTuple.TabIndex = 13;
            this.tbx_HTuple.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_HTuple_KeyDown);
            this.tbx_HTuple.Leave += new System.EventHandler(this.tbx_HTuple_Leave);
            // 
            // SerializeObjInfoCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbx_HTuple);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lst_Info);
            this.Controls.Add(this.btn_DeserializeLoad);
            this.Controls.Add(this.btn_SerializeSave);
            this.Controls.Add(this.tbx_SerializeType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_CreateTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_ImageID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_ImageName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hWindowControl1);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SerializeObjInfoCtrl";
            this.Size = new System.Drawing.Size(395, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HalconDotNet.HWindowControl hWindowControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_ImageName;
        private System.Windows.Forms.TextBox tbx_ImageID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_CreateTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_SerializeType;
        private System.Windows.Forms.Button btn_SerializeSave;
        private System.Windows.Forms.Button btn_DeserializeLoad;
        private System.Windows.Forms.ListBox lst_Info;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_HTuple;
    }
}
