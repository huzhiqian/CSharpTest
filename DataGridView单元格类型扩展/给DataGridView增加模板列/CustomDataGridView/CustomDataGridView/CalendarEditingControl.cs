using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CustomDataGridView
{
    /// <summary>
    /// 时间控件编辑类，继承自 DateTimePicker时间控件，并实现 DataGridView 的单元格内的控件的常见功能接口
    /// </summary>
    class CalendarEditingControl : DateTimePicker, IDataGridViewEditingControl
    {
        DataGridView dataGridView;
        private bool valueChanged = false;
        int rowIndex;

        public CalendarEditingControl()
        {
            this.Format = DateTimePickerFormat.Short;
        }

        //获取或设置控件的值
        public object EditingControlFormattedValue
        {
            get
            {
                return this.Value.ToShortDateString();
            }
            set
            {
                String newValue = value as String;
                if (newValue != null)
                {
                    this.Value = DateTime.Parse(newValue);
                }
            }
        }

        //获得编辑时控件值
        public object GetEditingControlFormattedValue(
            DataGridViewDataErrorContexts context)
        {
            return EditingControlFormattedValue;
        }

        //设置控件字体样式
        public void ApplyCellStyleToEditingControl(
            DataGridViewCellStyle dataGridViewCellStyle)
        {
            this.Font = dataGridViewCellStyle.Font;
            this.CalendarForeColor = dataGridViewCellStyle.ForeColor;
            this.CalendarMonthBackground = dataGridViewCellStyle.BackColor;
        }

        //获取或设置当前控件行索引
        public int EditingControlRowIndex
        {
            get
            {
                return rowIndex;
            }
            set
            {
                rowIndex = value;
            }
        }

        // 设置控件得到焦点时相应键盘按键，返回true是当前控件相应操作，返回false是当前DataGridView相应操作
        public bool EditingControlWantsInputKey(
            Keys key, bool dataGridViewWantsInputKey)
        {
            switch (key & Keys.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                case Keys.PageDown:
                case Keys.PageUp:
                    return true;
                default:
                    return false;
            }
        }

        // 准备编辑控件得到焦点
        public void PrepareEditingControlForEdit(bool selectAll)
        {
            
        }

        // 将控件值放回时激发的属性
        public bool RepositionEditingControlOnValueChange
        {
            get
            {
                return false;
            }
        }

        // 获取或设置当前控件所属DataGridView对象
        public DataGridView EditingControlDataGridView
        {
            get
            {
                return dataGridView;
            }
            set
            {
                dataGridView = value;
            }
        }

        // 获取或设置当前编辑控件值修改状态
        public bool EditingControlValueChanged
        {
            get
            {
                return valueChanged;
            }
            set
            {
                valueChanged = value;
            }
        }

        // 获取的当前编辑面板源
        public Cursor EditingPanelCursor
        {
            get
            {
                return base.Cursor;
            }
        }

        //重写DateTimePicker.OnValueChanged方法，当值改变时设置当前DataGridView为修改状态。
        protected override void OnValueChanged(EventArgs eventargs)
        {
            // 通知当前 DataGridView 在单元格内有改变
            valueChanged = true;
            this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
            base.OnValueChanged(eventargs);
        }
    }
}
