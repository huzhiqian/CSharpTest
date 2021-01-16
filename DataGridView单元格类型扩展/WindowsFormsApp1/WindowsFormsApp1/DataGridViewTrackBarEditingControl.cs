using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;
using System.Windows.Forms;

//**********************************************
//文件名：DataGridViewTrackBarEditingControl
//命名空间：WindowsFormsApp1
//CLR版本：4.0.30319.42000
//内容：
//功能：拖动条控件，继承自TrackBar,并实现DataGridView的单元格Neo的控件常见功能接口
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/8/7 13:20:14
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace WindowsFormsApp1
{
    public class DataGridViewTrackBarEditingControl : TrackBar, IDataGridViewEditingControl
    {
        private DataGridView dataGridView;
        private bool valueChanged = false;
        private int rowIndex;
        #region 构造函数

        public DataGridViewTrackBarEditingControl()
        {
            this.Maximum = 100;
            this.Minimum = 1;
        }



        #endregion


        #region 属性

        /// <summary>
        /// 获取或设置当前控件所属的DataGridView对象
        /// </summary>
        public virtual DataGridView EditingControlDataGridView
        {
            get { return dataGridView; }
            set
            {
                dataGridView = value;
            }
        }

        /// <summary>
        /// 获取或设置控件的值
        /// </summary>
        public object EditingControlFormattedValue
        {
            get { return this.Value.ToString(); }
            set
            {
                int val = (int)value;
                if (val >= 0)
                {
                    this.Value = val;
                }
            }
        }

        /// <summary>
        /// 获取或设置当前控件的行索引
        /// </summary>
        public int EditingControlRowIndex
        {
            get { return rowIndex; }
            set
            {
                rowIndex = value;
            }
        }


        /// <summary>
        /// 获取或设控件值修改状态
        /// </summary>
        public bool EditingControlValueChanged
        {
            get { return valueChanged; }
            set
            {
                valueChanged = value;
            }
        }

        public Cursor EditingPanelCursor => base.Cursor;

        /// <summary>
        /// 将控件值放回时激发的属性
        /// </summary>
        public bool RepositionEditingControlOnValueChange => false;

        #endregion

        #region 公共方法



        /// <summary>
        /// 设置控件字体样式
        /// </summary>
        /// <param name="dataGridViewCellStyle"></param>
        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {

        }

        public virtual bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey)
        {

            switch (keyData & Keys.KeyCode)
            {
                case Keys.Left:
                    if (this.Value > this.Minimum)
                        return true;
                    return false;
                case Keys.Right:
                    if (this.Value < this.Maximum)
                        return true;
                    return false;
                default:
                    return false;
            }
        }

        /// <summary>
        /// 获得编辑时控件的值
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        {
            return EditingControlFormattedValue;
        }

        /// <summary>
        /// 准备编辑控件，得到焦点
        /// </summary>
        /// <param name="selectAll"></param>
        public void PrepareEditingControlForEdit(bool selectAll)
        {
            //throw new NotImplementedException();
        }

        #endregion

        #region 私有方法

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

        }

        protected override void OnValueChanged(EventArgs e)
        {
            base.OnValueChanged(e);
            if (this.Focused) {
                valueChanged = true;
                this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
            }
        }

        //将键盘消息发送到编辑控件
        [System.Runtime.InteropServices.DllImport("USER32.DLL", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr IParam);
        #endregion

        #region 委托



        #endregion

        #region 事件



        #endregion
    }
}
