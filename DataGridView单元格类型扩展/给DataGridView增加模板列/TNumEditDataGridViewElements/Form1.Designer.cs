namespace CSUST.Data
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cb_RowNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_ColNo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_TextBoxValue = new System.Windows.Forms.TextBox();
            this.bn_ToOneCell = new System.Windows.Forms.Button();
            this.bn_ToWhoteRow = new System.Windows.Forms.Button();
            this.bn_ToWholeCol = new System.Windows.Forms.Button();
            this.bn_BindingDatatable = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_CellValue = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNumEditDataGridViewColumn1 = new CSUST.Data.TNumEditDataGridViewColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNumEditDataGridViewColumn2 = new CSUST.Data.TNumEditDataGridViewColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_Column1_DecimalLength = new System.Windows.Forms.ComboBox();
            this.ck_Column1_ShowNullWhenZero = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Column3_DecimalLength = new System.Windows.Forms.ComboBox();
            this.ck_Column3_ShowNullWhenZero = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new CSUST.Data.TNumEditDataGridViewColumn();
            this.Column3 = new CSUST.Data.TNumEditDataGridViewColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_RowNo
            // 
            this.cb_RowNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_RowNo.FormattingEnabled = true;
            this.cb_RowNo.Location = new System.Drawing.Point(37, 272);
            this.cb_RowNo.Name = "cb_RowNo";
            this.cb_RowNo.Size = new System.Drawing.Size(38, 20);
            this.cb_RowNo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Col";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Row";
            // 
            // cb_ColNo
            // 
            this.cb_ColNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ColNo.FormattingEnabled = true;
            this.cb_ColNo.Location = new System.Drawing.Point(110, 272);
            this.cb_ColNo.Name = "cb_ColNo";
            this.cb_ColNo.Size = new System.Drawing.Size(38, 20);
            this.cb_ColNo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "输入值";
            // 
            // tb_TextBoxValue
            // 
            this.tb_TextBoxValue.Location = new System.Drawing.Point(416, 271);
            this.tb_TextBoxValue.MaxLength = 27;
            this.tb_TextBoxValue.Name = "tb_TextBoxValue";
            this.tb_TextBoxValue.Size = new System.Drawing.Size(178, 21);
            this.tb_TextBoxValue.TabIndex = 8;
            this.tb_TextBoxValue.Text = "1234567.1234567";
            this.tb_TextBoxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bn_ToOneCell
            // 
            this.bn_ToOneCell.Location = new System.Drawing.Point(161, 307);
            this.bn_ToOneCell.Name = "bn_ToOneCell";
            this.bn_ToOneCell.Size = new System.Drawing.Size(134, 29);
            this.bn_ToOneCell.TabIndex = 10;
            this.bn_ToOneCell.Text = "赋给选择的单元格";
            this.bn_ToOneCell.UseVisualStyleBackColor = true;
            this.bn_ToOneCell.Click += new System.EventHandler(this.bn_ToOneCell_Click);
            // 
            // bn_ToWhoteRow
            // 
            this.bn_ToWhoteRow.Location = new System.Drawing.Point(459, 307);
            this.bn_ToWhoteRow.Name = "bn_ToWhoteRow";
            this.bn_ToWhoteRow.Size = new System.Drawing.Size(134, 29);
            this.bn_ToWhoteRow.TabIndex = 12;
            this.bn_ToWhoteRow.Text = "赋给选择表格行";
            this.bn_ToWhoteRow.UseVisualStyleBackColor = true;
            this.bn_ToWhoteRow.Click += new System.EventHandler(this.bn_ToWhoteRow_Click);
            // 
            // bn_ToWholeCol
            // 
            this.bn_ToWholeCol.Location = new System.Drawing.Point(310, 307);
            this.bn_ToWholeCol.Name = "bn_ToWholeCol";
            this.bn_ToWholeCol.Size = new System.Drawing.Size(134, 29);
            this.bn_ToWholeCol.TabIndex = 14;
            this.bn_ToWholeCol.Text = "赋给选择的表格列";
            this.bn_ToWholeCol.UseVisualStyleBackColor = true;
            this.bn_ToWholeCol.Click += new System.EventHandler(this.bn_ToWholeCol_Click);
            // 
            // bn_BindingDatatable
            // 
            this.bn_BindingDatatable.Location = new System.Drawing.Point(12, 307);
            this.bn_BindingDatatable.Name = "bn_BindingDatatable";
            this.bn_BindingDatatable.Size = new System.Drawing.Size(134, 29);
            this.bn_BindingDatatable.TabIndex = 23;
            this.bn_BindingDatatable.Text = "绑定Datatable";
            this.bn_BindingDatatable.UseVisualStyleBackColor = true;
            this.bn_BindingDatatable.Click += new System.EventHandler(this.bn_BindingDatatable_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "单元值";
            // 
            // tb_CellValue
            // 
            this.tb_CellValue.Location = new System.Drawing.Point(205, 271);
            this.tb_CellValue.MaxLength = 27;
            this.tb_CellValue.Name = "tb_CellValue";
            this.tb_CellValue.ReadOnly = true;
            this.tb_CellValue.Size = new System.Drawing.Size(158, 21);
            this.tb_CellValue.TabIndex = 27;
            this.tb_CellValue.Text = "1234567.1234567";
            this.tb_CellValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // tNumEditDataGridViewColumn1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.tNumEditDataGridViewColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.tNumEditDataGridViewColumn1.HeaderText = "Column2";
            this.tNumEditDataGridViewColumn1.Name = "tNumEditDataGridViewColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Column3";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // tNumEditDataGridViewColumn2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.tNumEditDataGridViewColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.tNumEditDataGridViewColumn2.HeaderText = "Column4";
            this.tNumEditDataGridViewColumn2.Name = "tNumEditDataGridViewColumn2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 33;
            this.label7.Text = "DecimalLength";
            // 
            // cb_Column1_DecimalLength
            // 
            this.cb_Column1_DecimalLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Column1_DecimalLength.FormattingEnabled = true;
            this.cb_Column1_DecimalLength.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cb_Column1_DecimalLength.Location = new System.Drawing.Point(95, 16);
            this.cb_Column1_DecimalLength.Name = "cb_Column1_DecimalLength";
            this.cb_Column1_DecimalLength.Size = new System.Drawing.Size(43, 20);
            this.cb_Column1_DecimalLength.TabIndex = 32;
            this.cb_Column1_DecimalLength.SelectedIndexChanged += new System.EventHandler(this.cb_Column1_DecimalLength_SelectedIndexChanged);
            // 
            // ck_Column1_ShowNullWhenZero
            // 
            this.ck_Column1_ShowNullWhenZero.AutoSize = true;
            this.ck_Column1_ShowNullWhenZero.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ck_Column1_ShowNullWhenZero.Location = new System.Drawing.Point(148, 18);
            this.ck_Column1_ShowNullWhenZero.Name = "ck_Column1_ShowNullWhenZero";
            this.ck_Column1_ShowNullWhenZero.Size = new System.Drawing.Size(120, 16);
            this.ck_Column1_ShowNullWhenZero.TabIndex = 34;
            this.ck_Column1_ShowNullWhenZero.Text = "ShowNullWhenZero";
            this.ck_Column1_ShowNullWhenZero.UseVisualStyleBackColor = true;
            this.ck_Column1_ShowNullWhenZero.CheckedChanged += new System.EventHandler(this.ck_Column1_ShowNullWhenZero_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cb_Column1_DecimalLength);
            this.groupBox1.Controls.Add(this.ck_Column1_ShowNullWhenZero);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 44);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Column[1]";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cb_Column3_DecimalLength);
            this.groupBox2.Controls.Add(this.ck_Column3_ShowNullWhenZero);
            this.groupBox2.Location = new System.Drawing.Point(313, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 44);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Column[2]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 33;
            this.label6.Text = "DecimalLength";
            // 
            // cb_Column3_DecimalLength
            // 
            this.cb_Column3_DecimalLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Column3_DecimalLength.FormattingEnabled = true;
            this.cb_Column3_DecimalLength.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cb_Column3_DecimalLength.Location = new System.Drawing.Point(95, 16);
            this.cb_Column3_DecimalLength.Name = "cb_Column3_DecimalLength";
            this.cb_Column3_DecimalLength.Size = new System.Drawing.Size(43, 20);
            this.cb_Column3_DecimalLength.TabIndex = 32;
            this.cb_Column3_DecimalLength.SelectedIndexChanged += new System.EventHandler(this.cb_Column3_DecimalLength_SelectedIndexChanged);
            // 
            // ck_Column3_ShowNullWhenZero
            // 
            this.ck_Column3_ShowNullWhenZero.AutoSize = true;
            this.ck_Column3_ShowNullWhenZero.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ck_Column3_ShowNullWhenZero.Location = new System.Drawing.Point(149, 18);
            this.ck_Column3_ShowNullWhenZero.Name = "ck_Column3_ShowNullWhenZero";
            this.ck_Column3_ShowNullWhenZero.Size = new System.Drawing.Size(120, 16);
            this.ck_Column3_ShowNullWhenZero.TabIndex = 34;
            this.ck_Column3_ShowNullWhenZero.Text = "ShowNullWhenZero";
            this.ck_Column3_ShowNullWhenZero.UseVisualStyleBackColor = true;
            this.ck_Column3_ShowNullWhenZero.CheckedChanged += new System.EventHandler(this.ck_Column3_ShowNullWhenZero_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(13, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(580, 197);
            this.dataGridView1.TabIndex = 43;
            // 
            // Column0
            // 
            this.Column0.HeaderText = "Column[0](TextBox)";
            this.Column0.Name = "Column0";
            this.Column0.Width = 142;
            // 
            // Column1
            // 
            this.Column1.AllowNegative = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "F0";
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "Column[1](non negative)";
            this.Column1.Name = "Column1";
            this.Column1.Width = 180;
            // 
            // Column3
            // 
            this.Column3.DecimalLength = 5;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "F5";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "Column[2](allow negative)";
            this.Column3.Name = "Column3";
            this.Column3.ShowNullWhenZero = true;
            this.Column3.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 348);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_CellValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bn_BindingDatatable);
            this.Controls.Add(this.bn_ToWholeCol);
            this.Controls.Add(this.bn_ToWhoteRow);
            this.Controls.Add(this.bn_ToOneCell);
            this.Controls.Add(this.tb_TextBoxValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_ColNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_RowNo);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "定制DataGridView的数字编辑元素——Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_RowNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_ColNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_TextBoxValue;
        private System.Windows.Forms.Button bn_ToOneCell;
        private System.Windows.Forms.Button bn_ToWhoteRow;
        private System.Windows.Forms.Button bn_ToWholeCol;
        private System.Windows.Forms.Button bn_BindingDatatable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_CellValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private TNumEditDataGridViewColumn tNumEditDataGridViewColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private TNumEditDataGridViewColumn tNumEditDataGridViewColumn2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_Column1_DecimalLength;
        private System.Windows.Forms.CheckBox ck_Column1_ShowNullWhenZero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_Column3_DecimalLength;
        private System.Windows.Forms.CheckBox ck_Column3_ShowNullWhenZero;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private TNumEditDataGridViewColumn Column1;
        private TNumEditDataGridViewColumn Column3;

    }


}

