namespace FormEx
{
    partial class NBFormEx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NBFormEx));
            this.titleBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEXClose = new FormEx.FCButton();
            this.btnEXMax = new FormEx.FCButton();
            this.btnEXMin = new FormEx.FCButton();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.Turquoise;
            this.titleBar.Controls.Add(this.pictureBox1);
            this.titleBar.Controls.Add(this.label1);
            this.titleBar.Controls.Add(this.btnEXClose);
            this.titleBar.Controls.Add(this.btnEXMax);
            this.titleBar.Controls.Add(this.btnEXMin);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.titleBar.Size = new System.Drawing.Size(800, 35);
            this.titleBar.TabIndex = 0;
            this.titleBar.DoubleClick += new System.EventHandler(this.titleBar_DoubleClick);
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseMove);
            this.titleBar.Resize += new System.EventHandler(this.titleBar_Resize);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(55, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = this.Text;
            // 
            // btnEXClose
            // 
            this.btnEXClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEXClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEXClose.BackgroundImage")));
            this.btnEXClose.ButtonType = FormEx.ButtonType.Close;
            this.btnEXClose.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnEXClose.DefaultImage")));
            this.btnEXClose.Location = new System.Drawing.Point(772, 13);
            this.btnEXClose.MouseDownColor = System.Drawing.Color.Khaki;
            this.btnEXClose.MouseEnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEXClose.MouseLeaveColor = System.Drawing.Color.Transparent;
            this.btnEXClose.MouseUpColor = System.Drawing.Color.Transparent;
            this.btnEXClose.Name = "btnEXClose";
            this.btnEXClose.Size = new System.Drawing.Size(16, 15);
            this.btnEXClose.TabIndex = 2;
            this.btnEXClose.Click += new System.EventHandler(this.btnEXClose_Click);
            // 
            // btnEXMax
            // 
            this.btnEXMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEXMax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEXMax.BackgroundImage")));
            this.btnEXMax.ButtonType = FormEx.ButtonType.MaxNormal;
            this.btnEXMax.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnEXMax.DefaultImage")));
            this.btnEXMax.Location = new System.Drawing.Point(738, 13);
            this.btnEXMax.MouseDownColor = System.Drawing.Color.Khaki;
            this.btnEXMax.MouseEnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEXMax.MouseLeaveColor = System.Drawing.Color.Transparent;
            this.btnEXMax.MouseUpColor = System.Drawing.Color.Transparent;
            this.btnEXMax.Name = "btnEXMax";
            this.btnEXMax.Size = new System.Drawing.Size(16, 15);
            this.btnEXMax.TabIndex = 1;
            this.btnEXMax.Click += new System.EventHandler(this.btnEXMax_Click);
            // 
            // btnEXMin
            // 
            this.btnEXMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEXMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEXMin.BackgroundImage")));
            this.btnEXMin.ButtonType = FormEx.ButtonType.Minimize;
            this.btnEXMin.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnEXMin.DefaultImage")));
            this.btnEXMin.Location = new System.Drawing.Point(704, 13);
            this.btnEXMin.MouseDownColor = System.Drawing.Color.Khaki;
            this.btnEXMin.MouseEnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEXMin.MouseLeaveColor = System.Drawing.Color.Transparent;
            this.btnEXMin.MouseUpColor = System.Drawing.Color.Transparent;
            this.btnEXMin.Name = "btnEXMin";
            this.btnEXMin.Size = new System.Drawing.Size(16, 15);
            this.btnEXMin.TabIndex = 0;
            this.btnEXMin.Click += new System.EventHandler(this.btnEXMin_Click);
            // 
            // NBFormEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.titleBar);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NBFormEx";
            this.Text = "NBFormEx";
            this.Load += new System.EventHandler(this.NBFormEx_Load);
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titleBar;
        private FCButton btnEXMin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private FCButton btnEXClose;
        private FCButton btnEXMax;
    }
}