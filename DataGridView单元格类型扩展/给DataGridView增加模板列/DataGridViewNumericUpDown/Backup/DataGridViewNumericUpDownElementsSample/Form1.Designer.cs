namespace DataGridViewNumericUpDownElementsSample
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewNumericUpDownColumn1 = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this.lblDecimalPlaces = new System.Windows.Forms.Label();
            this.lblIncrement = new System.Windows.Forms.Label();
            this.txtIncrement = new System.Windows.Forms.TextBox();
            this.lblMaximum = new System.Windows.Forms.Label();
            this.btnGetIncrement = new System.Windows.Forms.Button();
            this.btnSetIncrement = new System.Windows.Forms.Button();
            this.txtDecimalPlaces = new System.Windows.Forms.TextBox();
            this.btnGetDecimalPlaces = new System.Windows.Forms.Button();
            this.btnSetDecimalPlaces = new System.Windows.Forms.Button();
            this.txtMaximum = new System.Windows.Forms.TextBox();
            this.btnGetMaximum = new System.Windows.Forms.Button();
            this.btnSetMaximum = new System.Windows.Forms.Button();
            this.txtMinimum = new System.Windows.Forms.TextBox();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.btnGetMinimum = new System.Windows.Forms.Button();
            this.btnSetMinimum = new System.Windows.Forms.Button();
            this.chkThousandsSeparator = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewNumericUpDownColumn1});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(279, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewNumericUpDownColumn1
            // 
            this.dataGridViewNumericUpDownColumn1.HeaderText = "NumericUpDown Column";
            this.dataGridViewNumericUpDownColumn1.Name = "dataGridViewNumericUpDownColumn1";
            this.dataGridViewNumericUpDownColumn1.Width = 200;
            // 
            // lblDecimalPlaces
            // 
            this.lblDecimalPlaces.AutoSize = true;
            this.lblDecimalPlaces.Location = new System.Drawing.Point(13, 184);
            this.lblDecimalPlaces.Name = "lblDecimalPlaces";
            this.lblDecimalPlaces.Size = new System.Drawing.Size(82, 17);
            this.lblDecimalPlaces.TabIndex = 1;
            this.lblDecimalPlaces.Text = "DecimalPlaces:";
            this.lblDecimalPlaces.UseCompatibleTextRendering = true;
            // 
            // lblIncrement
            // 
            this.lblIncrement.AutoSize = true;
            this.lblIncrement.Location = new System.Drawing.Point(13, 210);
            this.lblIncrement.Name = "lblIncrement";
            this.lblIncrement.Size = new System.Drawing.Size(58, 17);
            this.lblIncrement.TabIndex = 5;
            this.lblIncrement.Text = "Increment:";
            this.lblIncrement.UseCompatibleTextRendering = true;
            // 
            // txtIncrement
            // 
            this.txtIncrement.Location = new System.Drawing.Point(101, 207);
            this.txtIncrement.Name = "txtIncrement";
            this.txtIncrement.Size = new System.Drawing.Size(100, 20);
            this.txtIncrement.TabIndex = 6;
            // 
            // lblMaximum
            // 
            this.lblMaximum.AutoSize = true;
            this.lblMaximum.Location = new System.Drawing.Point(13, 236);
            this.lblMaximum.Name = "lblMaximum";
            this.lblMaximum.Size = new System.Drawing.Size(56, 17);
            this.lblMaximum.TabIndex = 9;
            this.lblMaximum.Text = "Maximum:";
            this.lblMaximum.UseCompatibleTextRendering = true;
            // 
            // btnGetIncrement
            // 
            this.btnGetIncrement.Location = new System.Drawing.Point(217, 205);
            this.btnGetIncrement.Name = "btnGetIncrement";
            this.btnGetIncrement.Size = new System.Drawing.Size(32, 23);
            this.btnGetIncrement.TabIndex = 7;
            this.btnGetIncrement.Text = "Get";
            this.btnGetIncrement.UseCompatibleTextRendering = true;
            this.btnGetIncrement.UseVisualStyleBackColor = true;
            this.btnGetIncrement.Click += new System.EventHandler(this.btnGetIncrement_Click);
            // 
            // btnSetIncrement
            // 
            this.btnSetIncrement.Location = new System.Drawing.Point(260, 205);
            this.btnSetIncrement.Name = "btnSetIncrement";
            this.btnSetIncrement.Size = new System.Drawing.Size(32, 23);
            this.btnSetIncrement.TabIndex = 8;
            this.btnSetIncrement.Text = "Set";
            this.btnSetIncrement.UseCompatibleTextRendering = true;
            this.btnSetIncrement.UseVisualStyleBackColor = true;
            this.btnSetIncrement.Click += new System.EventHandler(this.btnSetIncrement_Click);
            // 
            // txtDecimalPlaces
            // 
            this.txtDecimalPlaces.Location = new System.Drawing.Point(101, 181);
            this.txtDecimalPlaces.Name = "txtDecimalPlaces";
            this.txtDecimalPlaces.Size = new System.Drawing.Size(100, 20);
            this.txtDecimalPlaces.TabIndex = 2;
            // 
            // btnGetDecimalPlaces
            // 
            this.btnGetDecimalPlaces.Location = new System.Drawing.Point(217, 179);
            this.btnGetDecimalPlaces.Name = "btnGetDecimalPlaces";
            this.btnGetDecimalPlaces.Size = new System.Drawing.Size(32, 23);
            this.btnGetDecimalPlaces.TabIndex = 3;
            this.btnGetDecimalPlaces.Text = "Get";
            this.btnGetDecimalPlaces.UseCompatibleTextRendering = true;
            this.btnGetDecimalPlaces.UseVisualStyleBackColor = true;
            this.btnGetDecimalPlaces.Click += new System.EventHandler(this.btnGetDecimalPlaces_Click);
            // 
            // btnSetDecimalPlaces
            // 
            this.btnSetDecimalPlaces.Location = new System.Drawing.Point(260, 179);
            this.btnSetDecimalPlaces.Name = "btnSetDecimalPlaces";
            this.btnSetDecimalPlaces.Size = new System.Drawing.Size(32, 23);
            this.btnSetDecimalPlaces.TabIndex = 4;
            this.btnSetDecimalPlaces.Text = "Set";
            this.btnSetDecimalPlaces.UseCompatibleTextRendering = true;
            this.btnSetDecimalPlaces.UseVisualStyleBackColor = true;
            this.btnSetDecimalPlaces.Click += new System.EventHandler(this.btnSetDecimalPlaces_Click);
            // 
            // txtMaximum
            // 
            this.txtMaximum.Location = new System.Drawing.Point(101, 233);
            this.txtMaximum.Name = "txtMaximum";
            this.txtMaximum.Size = new System.Drawing.Size(100, 20);
            this.txtMaximum.TabIndex = 10;
            // 
            // btnGetMaximum
            // 
            this.btnGetMaximum.Location = new System.Drawing.Point(217, 231);
            this.btnGetMaximum.Name = "btnGetMaximum";
            this.btnGetMaximum.Size = new System.Drawing.Size(32, 23);
            this.btnGetMaximum.TabIndex = 11;
            this.btnGetMaximum.Text = "Get";
            this.btnGetMaximum.UseCompatibleTextRendering = true;
            this.btnGetMaximum.UseVisualStyleBackColor = true;
            this.btnGetMaximum.Click += new System.EventHandler(this.btnGetMaximum_Click);
            // 
            // btnSetMaximum
            // 
            this.btnSetMaximum.Location = new System.Drawing.Point(260, 231);
            this.btnSetMaximum.Name = "btnSetMaximum";
            this.btnSetMaximum.Size = new System.Drawing.Size(32, 23);
            this.btnSetMaximum.TabIndex = 12;
            this.btnSetMaximum.Text = "Set";
            this.btnSetMaximum.UseCompatibleTextRendering = true;
            this.btnSetMaximum.UseVisualStyleBackColor = true;
            this.btnSetMaximum.Click += new System.EventHandler(this.btnSetMaximum_Click);
            // 
            // txtMinimum
            // 
            this.txtMinimum.Location = new System.Drawing.Point(101, 259);
            this.txtMinimum.Name = "txtMinimum";
            this.txtMinimum.Size = new System.Drawing.Size(100, 20);
            this.txtMinimum.TabIndex = 14;
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Location = new System.Drawing.Point(13, 262);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(53, 17);
            this.lblMinimum.TabIndex = 13;
            this.lblMinimum.Text = "Minimum:";
            this.lblMinimum.UseCompatibleTextRendering = true;
            // 
            // btnGetMinimum
            // 
            this.btnGetMinimum.Location = new System.Drawing.Point(217, 258);
            this.btnGetMinimum.Name = "btnGetMinimum";
            this.btnGetMinimum.Size = new System.Drawing.Size(32, 23);
            this.btnGetMinimum.TabIndex = 15;
            this.btnGetMinimum.Text = "Get";
            this.btnGetMinimum.UseCompatibleTextRendering = true;
            this.btnGetMinimum.UseVisualStyleBackColor = true;
            this.btnGetMinimum.Click += new System.EventHandler(this.btnGetMinimum_Click);
            // 
            // btnSetMinimum
            // 
            this.btnSetMinimum.Location = new System.Drawing.Point(260, 258);
            this.btnSetMinimum.Name = "btnSetMinimum";
            this.btnSetMinimum.Size = new System.Drawing.Size(32, 23);
            this.btnSetMinimum.TabIndex = 16;
            this.btnSetMinimum.Text = "Set";
            this.btnSetMinimum.UseCompatibleTextRendering = true;
            this.btnSetMinimum.UseVisualStyleBackColor = true;
            this.btnSetMinimum.Click += new System.EventHandler(this.btnSetMinimum_Click);
            // 
            // chkThousandsSeparator
            // 
            this.chkThousandsSeparator.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkThousandsSeparator.Location = new System.Drawing.Point(13, 285);
            this.chkThousandsSeparator.Name = "chkThousandsSeparator";
            this.chkThousandsSeparator.Size = new System.Drawing.Size(188, 24);
            this.chkThousandsSeparator.TabIndex = 17;
            this.chkThousandsSeparator.Text = "ThousandsSeparator?";
            this.chkThousandsSeparator.UseCompatibleTextRendering = true;
            this.chkThousandsSeparator.UseVisualStyleBackColor = true;
            this.chkThousandsSeparator.CheckedChanged += new System.EventHandler(this.chkThousandsSeparator_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 313);
            this.Controls.Add(this.chkThousandsSeparator);
            this.Controls.Add(this.btnSetMinimum);
            this.Controls.Add(this.btnGetMinimum);
            this.Controls.Add(this.lblMinimum);
            this.Controls.Add(this.txtMinimum);
            this.Controls.Add(this.btnSetMaximum);
            this.Controls.Add(this.btnGetMaximum);
            this.Controls.Add(this.txtMaximum);
            this.Controls.Add(this.btnSetDecimalPlaces);
            this.Controls.Add(this.btnGetDecimalPlaces);
            this.Controls.Add(this.txtDecimalPlaces);
            this.Controls.Add(this.btnSetIncrement);
            this.Controls.Add(this.btnGetIncrement);
            this.Controls.Add(this.lblMaximum);
            this.Controls.Add(this.txtIncrement);
            this.Controls.Add(this.lblIncrement);
            this.Controls.Add(this.lblDecimalPlaces);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "NumericUpDown Cell/Col. Sample";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDecimalPlaces;
        private System.Windows.Forms.Label lblIncrement;
        private System.Windows.Forms.TextBox txtIncrement;
        private System.Windows.Forms.Label lblMaximum;
        private System.Windows.Forms.Button btnGetIncrement;
        private System.Windows.Forms.Button btnSetIncrement;
        private System.Windows.Forms.TextBox txtDecimalPlaces;
        private System.Windows.Forms.Button btnGetDecimalPlaces;
        private System.Windows.Forms.Button btnSetDecimalPlaces;
        private System.Windows.Forms.TextBox txtMaximum;
        private System.Windows.Forms.Button btnGetMaximum;
        private System.Windows.Forms.Button btnSetMaximum;
        private System.Windows.Forms.TextBox txtMinimum;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.Button btnGetMinimum;
        private System.Windows.Forms.Button btnSetMinimum;
        private System.Windows.Forms.CheckBox chkThousandsSeparator;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn dataGridViewNumericUpDownColumn1;
    }
}

