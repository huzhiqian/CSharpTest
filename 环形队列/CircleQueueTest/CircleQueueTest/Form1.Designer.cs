namespace CircleQueueTest
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Enqueue = new System.Windows.Forms.Button();
            this.lst_EnqueueInfo = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_Dequeue = new System.Windows.Forms.Button();
            this.lst_DequeueInfo = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_queueLength = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_queueHead = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_QueueTail = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_TravelQueue = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_EnqueueInfo);
            this.groupBox1.Controls.Add(this.btn_Enqueue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "循环入队";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "循环次数：";
            // 
            // btn_Enqueue
            // 
            this.btn_Enqueue.Location = new System.Drawing.Point(38, 70);
            this.btn_Enqueue.Name = "btn_Enqueue";
            this.btn_Enqueue.Size = new System.Drawing.Size(188, 34);
            this.btn_Enqueue.TabIndex = 2;
            this.btn_Enqueue.Text = "Start";
            this.btn_Enqueue.UseVisualStyleBackColor = true;
            this.btn_Enqueue.Click += new System.EventHandler(this.btn_Enqueue_Click);
            // 
            // lst_EnqueueInfo
            // 
            this.lst_EnqueueInfo.FormattingEnabled = true;
            this.lst_EnqueueInfo.ItemHeight = 12;
            this.lst_EnqueueInfo.Location = new System.Drawing.Point(6, 115);
            this.lst_EnqueueInfo.Name = "lst_EnqueueInfo";
            this.lst_EnqueueInfo.Size = new System.Drawing.Size(266, 148);
            this.lst_EnqueueInfo.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_DequeueInfo);
            this.groupBox2.Controls.Add(this.btn_Dequeue);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(297, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 273);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "循环出队";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "循环次数：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 2;
            // 
            // btn_Dequeue
            // 
            this.btn_Dequeue.Location = new System.Drawing.Point(41, 70);
            this.btn_Dequeue.Name = "btn_Dequeue";
            this.btn_Dequeue.Size = new System.Drawing.Size(188, 34);
            this.btn_Dequeue.TabIndex = 4;
            this.btn_Dequeue.Text = "Start";
            this.btn_Dequeue.UseVisualStyleBackColor = true;
            this.btn_Dequeue.Click += new System.EventHandler(this.btn_Dequeue_Click);
            // 
            // lst_DequeueInfo
            // 
            this.lst_DequeueInfo.FormattingEnabled = true;
            this.lst_DequeueInfo.ItemHeight = 12;
            this.lst_DequeueInfo.Location = new System.Drawing.Point(6, 115);
            this.lst_DequeueInfo.Name = "lst_DequeueInfo";
            this.lst_DequeueInfo.Size = new System.Drawing.Size(266, 148);
            this.lst_DequeueInfo.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_QueueTail);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lbl_queueHead);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lbl_queueLength);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(13, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "队列信息";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "队列长度：";
            // 
            // lbl_queueLength
            // 
            this.lbl_queueLength.AutoSize = true;
            this.lbl_queueLength.Location = new System.Drawing.Point(96, 34);
            this.lbl_queueLength.Name = "lbl_queueLength";
            this.lbl_queueLength.Size = new System.Drawing.Size(11, 12);
            this.lbl_queueLength.TabIndex = 1;
            this.lbl_queueLength.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "队头：";
            // 
            // lbl_queueHead
            // 
            this.lbl_queueHead.AutoSize = true;
            this.lbl_queueHead.Location = new System.Drawing.Point(215, 34);
            this.lbl_queueHead.Name = "lbl_queueHead";
            this.lbl_queueHead.Size = new System.Drawing.Size(11, 12);
            this.lbl_queueHead.TabIndex = 3;
            this.lbl_queueHead.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "队尾：";
            // 
            // lbl_QueueTail
            // 
            this.lbl_QueueTail.AutoSize = true;
            this.lbl_QueueTail.Location = new System.Drawing.Point(323, 34);
            this.lbl_QueueTail.Name = "lbl_QueueTail";
            this.lbl_QueueTail.Size = new System.Drawing.Size(11, 12);
            this.lbl_QueueTail.TabIndex = 5;
            this.lbl_QueueTail.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_TravelQueue);
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Location = new System.Drawing.Point(13, 402);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(562, 162);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "遍历队列";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(3, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(385, 142);
            this.listBox1.TabIndex = 4;
            // 
            // btn_TravelQueue
            // 
            this.btn_TravelQueue.Location = new System.Drawing.Point(433, 38);
            this.btn_TravelQueue.Name = "btn_TravelQueue";
            this.btn_TravelQueue.Size = new System.Drawing.Size(104, 34);
            this.btn_TravelQueue.TabIndex = 4;
            this.btn_TravelQueue.Text = "Start";
            this.btn_TravelQueue.UseVisualStyleBackColor = true;
            this.btn_TravelQueue.Click += new System.EventHandler(this.btn_TravelQueue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 576);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lst_EnqueueInfo;
        private System.Windows.Forms.Button btn_Enqueue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lst_DequeueInfo;
        private System.Windows.Forms.Button btn_Dequeue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_QueueTail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_queueHead;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_queueLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_TravelQueue;
        private System.Windows.Forms.ListBox listBox1;
    }
}

