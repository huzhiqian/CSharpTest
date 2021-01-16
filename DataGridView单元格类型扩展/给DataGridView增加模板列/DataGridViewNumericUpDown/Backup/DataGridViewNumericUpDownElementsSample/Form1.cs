using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataGridViewNumericUpDownElementsSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetDecimalPlaces_Click(object sender, EventArgs e)
        {
            this.txtDecimalPlaces.Text = this.dataGridViewNumericUpDownColumn1.DecimalPlaces.ToString();
        }

        private void btnSetDecimalPlaces_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataGridViewNumericUpDownColumn1.DecimalPlaces = System.Convert.ToInt32(this.txtDecimalPlaces.Text);
            }
            catch
            {
            }
        }

        private void btnGetIncrement_Click(object sender, EventArgs e)
        {
            this.txtIncrement.Text = this.dataGridViewNumericUpDownColumn1.Increment.ToString();
        }

        private void btnSetIncrement_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataGridViewNumericUpDownColumn1.Increment = System.Convert.ToDecimal(this.txtIncrement.Text);
            }
            catch
            {
            }
        }

        private void btnGetMaximum_Click(object sender, EventArgs e)
        {
            this.txtMaximum.Text = this.dataGridViewNumericUpDownColumn1.Maximum.ToString();
        }

        private void btnSetMaximum_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataGridViewNumericUpDownColumn1.Maximum = System.Convert.ToDecimal(this.txtMaximum.Text);
            }
            catch
            {
            }
        }

        private void btnGetMinimum_Click(object sender, EventArgs e)
        {
            this.txtMinimum.Text = this.dataGridViewNumericUpDownColumn1.Minimum.ToString();
        }

        private void btnSetMinimum_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataGridViewNumericUpDownColumn1.Minimum = System.Convert.ToDecimal(this.txtMinimum.Text);
            }
            catch
            {
            }
        }

        private void chkThousandsSeparator_CheckedChanged(object sender, EventArgs e)
        {
            this.dataGridViewNumericUpDownColumn1.ThousandsSeparator = this.chkThousandsSeparator.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtDecimalPlaces.Text = this.dataGridViewNumericUpDownColumn1.DecimalPlaces.ToString();
            this.txtIncrement.Text = this.dataGridViewNumericUpDownColumn1.Increment.ToString();
            this.txtMaximum.Text = this.dataGridViewNumericUpDownColumn1.Maximum.ToString();
            this.txtMinimum.Text = this.dataGridViewNumericUpDownColumn1.Minimum.ToString();
            this.chkThousandsSeparator.Checked = this.dataGridViewNumericUpDownColumn1.ThousandsSeparator;
        }
    }
}