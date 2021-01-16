using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CustomDataGridView
{
    /// <summary>
    /// 时间控件单元格类，继承自 DataGridView 控件中的可编辑文本单元格。
    /// </summary>
    class CalendarCell : DataGridViewCell
    {

        public CalendarCell()
            : base()
        {
            //设置数据格式
            this.Style.Format = "d";
        }

        public override void InitializeEditingControl(int rowIndex, object
            initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            // 修改初始化控件值
            base.InitializeEditingControl(rowIndex, initialFormattedValue,
                dataGridViewCellStyle);
            CalendarEditingControl ctl =
                DataGridView.EditingControl as CalendarEditingControl;
            ctl.Value = (DateTime)this.Value;
        }

        public override Type EditType
        {
            get
            {
                // 返回编辑时所显示的控件类型
                return typeof(CalendarEditingControl);
            }
        }

        public override Type ValueType
        {
            get
            {
                //返回单元格包含值的类型
                return typeof(DateTime);
            }
        }

        public override object DefaultNewRowValue
        {
            get
            {
                // 返回默认值
                return DateTime.Now;
            }
        }
    }
}
