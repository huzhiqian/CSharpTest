using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace CSUST.Data
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(15);

            dataGridView1.Rows[1].Cells[1].Value = 12345;
            dataGridView1.Rows[2].Cells[1].Value = 0;

            dataGridView1.Rows[1].Cells[2].Value = -12345.123;
            dataGridView1.Rows[3].Cells[2].Value = 0;

            for (int k = 0; k < dataGridView1.Columns.Count; k++)
            {
                cb_ColNo.Items.Add(k.ToString());

                DataGridViewColumn column = dataGridView1.Columns[k];
                column.DataPropertyName = column.Name;

                if (column is TNumEditDataGridViewColumn)
                {
                    dt.Columns.Add(new DataColumn(column.Name, typeof(decimal)));
                }
                else
                {
                    dt.Columns.Add(new DataColumn(column.Name, typeof(string)));
                }
            }

            for (int k = 0; k < dataGridView1.Rows.Count; k++)
            {
                cb_RowNo.Items.Add(k.ToString());

                if ((k + 1) % 4 == 0)
                {
                    continue;
                }

                Random rnd = new Random(k);
                DataRow dr = dt.NewRow();
                for (int n = 0; n < dataGridView1.Columns.Count; n++)
                {
                    TNumEditDataGridViewColumn column = dataGridView1.Columns[n] as TNumEditDataGridViewColumn;
                    if (column != null)
                    {
                        double num = rnd.NextDouble() * 100;
                        if (column.AllowNegative)
                        {
                            num *= rnd.Next(2) - 1;
                        }
                        dr[n] = num;
                    }
                    else
                    {
                        dr[n] = "text" + (k + 1).ToString();
                    }
                }
                dt.Rows.Add(dr);
            }

            TNumEditDataGridViewColumn col = dataGridView1.Columns[1] as TNumEditDataGridViewColumn;
            cb_Column1_DecimalLength.Text = col.DecimalLength.ToString();
            ck_Column1_ShowNullWhenZero.Checked = col.AllowNegative;

            col = dataGridView1.Columns[2] as TNumEditDataGridViewColumn;
            cb_Column3_DecimalLength.Text = col.DecimalLength.ToString();
            ck_Column3_ShowNullWhenZero.Checked = col.AllowNegative;

            cb_RowNo.SelectedIndex = 1;
            cb_ColNo.SelectedIndex = 1;

            dataGridView1.CellEnter += this.dataGridView1_CellEnter;
            dataGridView1.CellValueChanged += this.dataGridView1_CellEnter;

            dataGridView1.CurrentCell = dataGridView1.Rows[1].Cells[1];
        }

        private void bn_ToOneCell_Click(object sender, EventArgs e)
        {
            int rowNo = int.Parse(cb_RowNo.Text);
            int colNo = int.Parse(cb_ColNo.Text);

            if (dataGridView1.DataSource == null)
            {
                dataGridView1.Rows[rowNo].Cells[colNo].Value = tb_TextBoxValue.Text;
            }
            else
            {
                dt.Rows[rowNo][colNo] = tb_TextBoxValue.Text;
            }
        }

        private void bn_ToWhoteRow_Click(object sender, EventArgs e)
        {
            int rowNo = int.Parse(cb_RowNo.Text);
            for (int k = 0; k < dataGridView1.Columns.Count; k++)
            {
                if (dataGridView1.DataSource == null)
                {
                    dataGridView1.Rows[rowNo].Cells[k].Value = tb_TextBoxValue.Text;
                }
                else
                {
                    dt.Rows[rowNo][k] = tb_TextBoxValue.Text;
                }
            }
        }

        private void bn_ToWholeCol_Click(object sender, EventArgs e)
        {
            int colNo = int.Parse(cb_ColNo.Text);
            for (int k = 0; k < dataGridView1.Rows.Count; k++)
            {
                if (dataGridView1.DataSource == null)
                {
                    dataGridView1.Rows[k].Cells[colNo].Value = tb_TextBoxValue.Text;
                }
                else
                {
                    if (!dataGridView1.Rows[k].IsNewRow)
                    {
                        dt.Rows[k][colNo] = tb_TextBoxValue.Text;
                    }
                }
            }
        }

        private void bn_SetDecimalLength_Click(object sender, EventArgs e)
        {
        }

        private void bn_BindingDatatable_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt;
            (sender as Button).Enabled = false;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            object value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            if (value != null)
            {
                tb_CellValue.Text =dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
            else
            {
                tb_CellValue.Text = "(null)";
            }
        }

        private void cb_Column1_DecimalLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count < 2)
            {
                return;
            }

            TNumEditDataGridViewColumn column = dataGridView1.Columns[1] as TNumEditDataGridViewColumn;
            if (column != null)
            {
                column.DecimalLength = cb_Column1_DecimalLength.SelectedIndex;
            }
        }

        private void cb_Column3_DecimalLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count < 3)
            {
                return;
            }

            TNumEditDataGridViewColumn column = dataGridView1.Columns[2] as TNumEditDataGridViewColumn;
            if (column != null)
            {
                column.DecimalLength = cb_Column3_DecimalLength.SelectedIndex;
            }
        }

        private void ck_Column1_ShowNullWhenZero_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count < 2)
            {
                return;
            }

            TNumEditDataGridViewColumn column = dataGridView1.Columns[1] as TNumEditDataGridViewColumn;
            if (column != null)
            {
                column.ShowNullWhenZero = ck_Column1_ShowNullWhenZero.Checked;
            }
        }

        private void ck_Column3_ShowNullWhenZero_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count < 3)
            {
                return;
            }

            TNumEditDataGridViewColumn column = dataGridView1.Columns[2] as TNumEditDataGridViewColumn;
            if (column != null)
            {
                column.ShowNullWhenZero = ck_Column3_ShowNullWhenZero.Checked;
            }
        }
    }
}