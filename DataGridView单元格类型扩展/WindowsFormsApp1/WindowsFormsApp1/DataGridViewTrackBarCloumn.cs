using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;
using System.Windows.Forms;
using System.ComponentModel;

//**********************************************
//文件名：DataGridViewTrackBarCloumn
//命名空间：WindowsFormsApp1
//CLR版本：4.0.30319.42000
//内容：
//功能：自定义TrackBar单元格类型
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/8/7 13:45:12
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace WindowsFormsApp1
{
   public class DataGridViewTrackBarCloumn:DataGridViewColumn
    {

        #region 构造函数

        public DataGridViewTrackBarCloumn():
            base(new DataGridViewTrackBarCell())
        {

        }

        #endregion


        #region 属性

        /// <summary>
        /// 设置单元格最小值
        /// </summary>
       [
            Category("Data"),
             Description("指示拖动值最小值."),
            RefreshProperties(RefreshProperties.All)
            ]
        public int Minimum {
            get {
                if (this.TrackBarCellTemplate == null) {
                    throw new InvalidOperationException("操作无法完成，因为此DataGridViewColumn没有CellTemplate。");
                }
                return this.TrackBarCellTemplate.MinimumValue;
            }
            set {
                if (this.TrackBarCellTemplate == null) {
                    throw new InvalidOperationException("操作无法完成，因为此DataGridViewColumn没有CellTemplate。");
                }
                this.TrackBarCellTemplate.MinimumValue = value;
                if (this.DataGridView != null) {
                    DataGridViewRowCollection dataGridViewRows = this.DataGridView.Rows;
                    int rowCount = dataGridViewRows.Count;
                    for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
                    {
                        DataGridViewRow dataGridViewRow = dataGridViewRows.SharedRow(rowIndex);
                        DataGridViewTrackBarCell dataGridViewCell = dataGridViewRow.Cells[this.Index] as DataGridViewTrackBarCell;
                        if (dataGridViewCell != null)
                        {
                            dataGridViewCell.SetMinimum(rowIndex, value);
                        }
                    }
                    this.DataGridView.InvalidateColumn(this.Index);
                }
            }
        }

        /// <summary>
        /// 设置单元格最大值
        /// </summary>
        [
             Category("Data"),
              Description("指示拖动值最大值."),
             RefreshProperties(RefreshProperties.All)
             ]
        public int Maximum
        {
            get
            {
                if (this.TrackBarCellTemplate == null)
                {
                    throw new InvalidOperationException("操作无法完成，因为此DataGridViewColumn没有CellTemplate。");
                }
                return this.TrackBarCellTemplate.MaximumValue;
            }
            set
            {
                if (this.TrackBarCellTemplate == null)
                {
                    throw new InvalidOperationException("操作无法完成，因为此DataGridViewColumn没有CellTemplate。");
                }
                this.TrackBarCellTemplate.MaximumValue = value;
                if (this.DataGridView != null)
                {
                    DataGridViewRowCollection dataGridViewRows = this.DataGridView.Rows;
                    int rowCount = dataGridViewRows.Count;
                    for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
                    {
                        DataGridViewRow dataGridViewRow = dataGridViewRows.SharedRow(rowIndex);
                        DataGridViewTrackBarCell dataGridViewCell = dataGridViewRow.Cells[this.Index] as DataGridViewTrackBarCell;
                        if (dataGridViewCell != null)
                        {
                            dataGridViewCell.SetMaximum(rowIndex, value);
                        }
                    }
                    this.DataGridView.InvalidateColumn(this.Index);
                }
            }
        }

        [
             Category("Data"),
              Description("指示单元格的默认值."),
             RefreshProperties(RefreshProperties.All)
            ]
        public int DefaultValue {
            get {
                if (this.TrackBarCellTemplate == null) {
                    throw new InvalidOperationException("操作无法完成，因为此DataGridViewColumn没有CellTemplate。");
                }
                return this.TrackBarCellTemplate.DefaultValue;
            }
            set {
                if (this.TrackBarCellTemplate == null)
                {
                    throw new InvalidOperationException("操作无法完成，因为此DataGridViewColumn没有CellTemplate。");
                }
                this.TrackBarCellTemplate.DefaultValue = value;

                if (this.DataGridView != null)
                {
                    DataGridViewRowCollection dataGridViewRows = this.DataGridView.Rows;
                    int rowCount = dataGridViewRows.Count;
                    for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
                    {
                        DataGridViewRow dataGridViewRow = dataGridViewRows.SharedRow(rowIndex);
                        DataGridViewTrackBarCell dataGridViewCell = dataGridViewRow.Cells[this.Index] as DataGridViewTrackBarCell;
                        if (dataGridViewCell != null)
                        {
                            dataGridViewCell.SetDefaultValue(rowIndex, value);
                        }
                    }
                    this.DataGridView.InvalidateColumn(this.Index);
                }
            }
        }

        [Browsable(false)]
        private DataGridViewTrackBarCell TrackBarCellTemplate {
            get { return (DataGridViewTrackBarCell)this.CellTemplate; }
        }

        #endregion

        #region 公共方法

        public override DataGridViewCell CellTemplate {
            get { return base.CellTemplate; }
            set {
                if (value != null && 
                    !value.GetType().IsAssignableFrom(typeof(DataGridViewTrackBarCell))) {
                    throw new InvalidCastException("Must be a DataGridViewTrackBarCell");
                }
                base.CellTemplate = value;
            }
        }

       
        #endregion

        #region 私有方法



        #endregion

        #region 委托



        #endregion

        #region 事件



        #endregion
    }
}
