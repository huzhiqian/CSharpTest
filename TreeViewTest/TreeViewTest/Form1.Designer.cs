namespace TreeViewTest
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_AddChildNode = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_ChildNodeValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Create = new System.Windows.Forms.Button();
            this.tbx_RootValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DeleteNode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_SelectNodeName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(378, 616);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btn_AddChildNode
            // 
            this.btn_AddChildNode.Location = new System.Drawing.Point(224, 76);
            this.btn_AddChildNode.Name = "btn_AddChildNode";
            this.btn_AddChildNode.Size = new System.Drawing.Size(130, 53);
            this.btn_AddChildNode.TabIndex = 1;
            this.btn_AddChildNode.Text = "Add";
            this.btn_AddChildNode.UseVisualStyleBackColor = true;
            this.btn_AddChildNode.Click += new System.EventHandler(this.btn_AddChildNode_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_ChildNodeValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_AddChildNode);
            this.groupBox1.Location = new System.Drawing.Point(405, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 135);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加节点";
            // 
            // tbx_ChildNodeValue
            // 
            this.tbx_ChildNodeValue.Location = new System.Drawing.Point(84, 35);
            this.tbx_ChildNodeValue.Name = "tbx_ChildNodeValue";
            this.tbx_ChildNodeValue.Size = new System.Drawing.Size(216, 25);
            this.tbx_ChildNodeValue.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Value:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Create);
            this.groupBox2.Controls.Add(this.tbx_RootValue);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(405, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 135);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "创建根节点";
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(221, 76);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(130, 53);
            this.btn_Create.TabIndex = 2;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // tbx_RootValue
            // 
            this.tbx_RootValue.Location = new System.Drawing.Point(84, 31);
            this.tbx_RootValue.Name = "tbx_RootValue";
            this.tbx_RootValue.Size = new System.Drawing.Size(216, 25);
            this.tbx_RootValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value:";
            // 
            // btn_DeleteNode
            // 
            this.btn_DeleteNode.Location = new System.Drawing.Point(459, 327);
            this.btn_DeleteNode.Name = "btn_DeleteNode";
            this.btn_DeleteNode.Size = new System.Drawing.Size(260, 59);
            this.btn_DeleteNode.TabIndex = 4;
            this.btn_DeleteNode.Text = "删除节点";
            this.btn_DeleteNode.UseVisualStyleBackColor = true;
            this.btn_DeleteNode.Click += new System.EventHandler(this.btn_DeleteNode_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "TreeViewSelectNode:";
            // 
            // tbx_SelectNodeName
            // 
            this.tbx_SelectNodeName.BackColor = System.Drawing.SystemColors.Window;
            this.tbx_SelectNodeName.Enabled = false;
            this.tbx_SelectNodeName.Location = new System.Drawing.Point(434, 497);
            this.tbx_SelectNodeName.Name = "tbx_SelectNodeName";
            this.tbx_SelectNodeName.Size = new System.Drawing.Size(230, 25);
            this.tbx_SelectNodeName.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 59);
            this.button1.TabIndex = 7;
            this.button1.Text = "ClearAllNodes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 640);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbx_SelectNodeName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_DeleteNode);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TreeViewForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btn_AddChildNode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbx_ChildNodeValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.TextBox tbx_RootValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DeleteNode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_SelectNodeName;
        private System.Windows.Forms.Button button1;
    }
}

