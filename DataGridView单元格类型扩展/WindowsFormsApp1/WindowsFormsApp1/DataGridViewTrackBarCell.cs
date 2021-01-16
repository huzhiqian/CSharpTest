using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;

//**********************************************
//文件名：DataGridViewTrackBarCell
//命名空间：WindowsFormsApp1
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/8/7 13:16:53
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace WindowsFormsApp1
{
    /// <summary>
    /// 为System.Windows.Forms定义一个TrackBar单元格类型
    /// </summary>
    public class DataGridViewTrackBarCell : DataGridViewTextBoxCell
    {
        //用于TranslateAlignment函数
        private static readonly DataGridViewContentAlignment anyRight =
            DataGridViewContentAlignment.TopRight | DataGridViewContentAlignment.MiddleRight |
             DataGridViewContentAlignment.BottomRight;
        private static readonly DataGridViewContentAlignment anyCenter =
            DataGridViewContentAlignment.BottomCenter | DataGridViewContentAlignment.MiddleCenter |
             DataGridViewContentAlignment.TopCenter;

        //用于绘制未编辑单元格的静态呈现位图的默认尺寸
        private const int DATAGRIDVIEWTRACKBARCELL_defaultRenderingBitmapWidth = 100;
        private const int DATAGRIDVIEWTRACKBARCELL_defaultRenderingBitmapHeight = 22;

        //默认最大值
        internal const int DATAGRIDVIEWTRACKBARCELL_defaultMaximum = 100;
        //默认最小值
        internal const int DATAGRIDVIEWTRACKBARCELL_defaultMinimum = 0;
        //新行默认值
        internal const int DATAGRIDVIEWTRACKBARCELL_defaultNewRowValue = 0;

        //单元格编辑控件类型
        private static Type defaultEditType = typeof(DataGridViewTrackBarEditingControl);
        //单元格值类型
        private static Type defaultValueType = typeof(int);

        //通过调用TrackBar.DrawToBitmap来绘制未编辑单元格的位图
        [ThreadStatic]
        private static Bitmap renderingBitmap;

        //通过调用TrackBar.DrawToBitmap来绘制未编辑的单元格的TrackBar控件
        [ThreadStatic]
        private static TrackBar paintingTrackBar;

        private int maximumValue;
        private int minimumValue;
        private int defaultValue;
        #region 构造函数

        public DataGridViewTrackBarCell()
        {
            //创建一个特定线程的位图，用于位置未编辑时的单元格
            if (renderingBitmap == null)
            {
                renderingBitmap = new Bitmap(DATAGRIDVIEWTRACKBARCELL_defaultRenderingBitmapWidth,
                    DATAGRIDVIEWTRACKBARCELL_defaultRenderingBitmapHeight);
            }

            //创建一个特定线程的TrackBar,用于绘制TrackBar位图
            if (paintingTrackBar == null)
            {
                paintingTrackBar = new TrackBar();
                paintingTrackBar.Maximum = 100;
                paintingTrackBar.Minimum = 0;
               // paintingTrackBar.Value = 100;
            }
            //设置默认值
            this.maximumValue = DATAGRIDVIEWTRACKBARCELL_defaultMaximum;
            this.minimumValue = DATAGRIDVIEWTRACKBARCELL_defaultMinimum;
            this.defaultValue = DATAGRIDVIEWTRACKBARCELL_defaultNewRowValue;
        }

        #endregion


        #region 属性

        public override object DefaultNewRowValue {
            get {
                return this.defaultValue;
            }
        }

        public override Type FormattedValueType => base.FormattedValueType;

        /// <summary>
        /// 获取或设置最大值
        /// </summary>
        [DefaultValue(DATAGRIDVIEWTRACKBARCELL_defaultMaximum)]
        public int MaximumValue
        {
            get { return this.maximumValue; }
            set
            {
                if (this.maximumValue != value)
                {
                    if (value <= 0 || value > 100)
                    {
                        throw new ArgumentOutOfRangeException("最大值不能小于等于0或大于100.");
                    }
                    if (this.maximumValue != value)
                    {
                        SetMaximum(this.RowIndex, value);
                        OnCommonChange();
                    }
                }

            }
        }

        /// <summary>
        /// 获取或设置最小值
        /// </summary>
        [DefaultValue(DATAGRIDVIEWTRACKBARCELL_defaultMinimum)]
        public int MinimumValue
        {
            get { return this.minimumValue; }
            set
            {
                if (this.minimumValue != value)
                {
                    if (value < 0 || value > 100)
                    {
                        throw new ArgumentOutOfRangeException("最小值不能小于等于0或大于100.");
                    }
                    else
                    {
                        SetMinimum(this.RowIndex, value);
                        OnCommonChange();
                    }
                }

            }
        }

        /// <summary>
        /// 获取或设置默认值
        /// </summary>
        //[DefaultValue(DATAGRIDVIEWTRACKBARCELL_defaultNewRowValue)]
        public int DefaultValue {
            get { return this.defaultValue; }
            set {
                if (this.defaultValue != value) {
                    if (value < this.minimumValue || value > this.maximumValue)
                    {
                        throw new ArgumentOutOfRangeException("默认值不能小于最小值以及大于最大值.");
                    }
                    else {
                        SetDefaultValue(this.RowIndex,value);
                        OnCommonChange();
                    }
                }
            }
        }

        /// <summary>
        /// 返回单元格编辑控件的类型
        /// </summary>
        public override Type EditType => defaultEditType;

        /// <summary>
        /// 获取单元格值类型
        /// </summary>
        public override Type ValueType
        {
            get
            {
                Type valueType = base.ValueType;
                if (valueType != null)
                {
                    return valueType;
                }
                return defaultValueType;
            }
        }

        /// <summary>
        /// 返回当前DataGridView编辑控件
        /// </summary>
        private DataGridViewTrackBarEditingControl EditTrackBar
        {
            get { return this.DataGridView.EditingControl as DataGridViewTrackBarEditingControl; }
        }
        #endregion

        #region 公共方法

        /// <summary>
        /// 初始化编辑控件
        /// 该函数由DataGridView控件在编辑会话框时调用，它确保TrackBar编辑控件是根据单元格属性来设置的
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="initialFormattedValue"></param>
        /// <param name="dataGridViewCellStyle"></param>
        public override void InitializeEditingControl(int rowIndex,
            object initialFormattedValue,
            DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);

            DataGridViewTrackBarEditingControl ctrl =
                 DataGridView.EditingControl as DataGridViewTrackBarEditingControl;
            if (ctrl != null)
            {
                ctrl.Maximum = this.maximumValue;
                ctrl.Minimum = this.minimumValue;

                int initFormattedValue = Convert.ToInt32(initialFormattedValue);
                ctrl.Value = initFormattedValue;
            }

        }

        /// <summary>
        /// 克隆一个DataGridViewTrackBarCell单元格，复制所有自定义属性
        /// </summary>
        /// <returns></returns>
        public override object Clone()
        {
            //return base.Clone();
            DataGridViewTrackBarCell dataGridViewTrackBarCell =
                base.Clone() as DataGridViewTrackBarCell;
            if (dataGridViewTrackBarCell != null)
            {
                dataGridViewTrackBarCell.minimumValue = this.minimumValue;
                dataGridViewTrackBarCell.maximumValue = this.maximumValue;
                dataGridViewTrackBarCell.defaultValue = this.defaultValue;
            }
            return dataGridViewTrackBarCell;
        }

        /// <summary>
        /// 在编辑回话框结时由DataGridView控件调用
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public override void DetachEditingControl()
        {
            DataGridView dataGridView = this.DataGridView;
            if (dataGridView == null || dataGridView.EditingControl == null)
            {
                throw new InvalidOperationException("单元格被分离或单元格内没有编辑控件.");
            }
            TrackBar trackBar = dataGridView.EditingControl as TrackBar;
            if (trackBar != null)
            {
                //编辑控件循环使用。实际上，当一个DataGridViewTrackBarCell单元格在另一个
                //DataGridViewTrackBarCell之后被编辑时，处于性能原因（以避免不必要的控制撤销和创建），
                //将重用相同的编辑控件
                
                //TextBox textBox = trackBar.Controls[1] as TextBox;
                //if (textBox != null)
                //{
                //    textBox.ClearUndo();
                //}
            }

            base.DetachEditingControl();
        }

        /// <summary>
        /// 重写KeyEntersEditMode函数，该函数由DataGridView调用，
        /// 该函数决定击键对否启用编辑会话框，在本例中按下向左或者向右的按钮时启动编辑
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public override bool KeyEntersEditMode(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                case Keys.Right:
                    return true;
                default:
                    break;
            }
            return false;
        }

        /// <summary>
        /// 当DataGridView重新调整位置和大小时，调用该方法
        /// </summary>
        /// <param name="setLocation"></param>
        /// <param name="setSize"></param>
        /// <param name="cellBounds"></param>
        /// <param name="cellClip"></param>
        /// <param name="cellStyle"></param>
        /// <param name="singleVerticalBorderAdded"></param>
        /// <param name="singleHorizontalBorderAdded"></param>
        /// <param name="isFirstDisplayedColumn"></param>
        /// <param name="isFirstDisplayedRow"></param>
        public override void PositionEditingControl(bool setLocation, 
            bool setSize, 
            Rectangle cellBounds,
            Rectangle cellClip, 
            DataGridViewCellStyle cellStyle,
            bool singleVerticalBorderAdded,
            bool singleHorizontalBorderAdded,
            bool isFirstDisplayedColumn, 
            bool isFirstDisplayedRow)
        {
            // base.PositionEditingControl(setLocation, setSize, cellBounds, cellClip, cellStyle, singleVerticalBorderAdded, singleHorizontalBorderAdded, isFirstDisplayedColumn, isFirstDisplayedRow);

            Rectangle editingControlBounds = PositionEditingPanel(cellBounds,
                                                                cellClip,
                                                                cellStyle,
                                                                singleVerticalBorderAdded,
                                                                singleHorizontalBorderAdded,
                                                                isFirstDisplayedColumn,
                                                                isFirstDisplayedRow);
            editingControlBounds = GetAdjustedEditingControlBounds(editingControlBounds,cellStyle);
            this.DataGridView.EditingControl.Location = new Point(editingControlBounds.X,editingControlBounds.Y);
            this.DataGridView.EditingControl.Size = new Size(editingControlBounds.Width,editingControlBounds.Height);
        }

        public override object ParseFormattedValue(object formattedValue, DataGridViewCellStyle cellStyle, TypeConverter formattedValueTypeConverter, TypeConverter valueTypeConverter)
        {

            string tempValue = formattedValue as string;
            if (!string.IsNullOrEmpty(tempValue as string) && formattedValue != null) {
                Console.WriteLine($"ParseFormattedValue: {tempValue}.");
                return Convert.ToInt32(tempValue);
            }
            return this.defaultValue;
        }
        #endregion

        #region 私有方法

        /// <summary>
        /// 根据单元格的对其特性调整编辑控件的位置和大小
        /// </summary>
        /// <param name="editingControlBounds"></param>
        /// <param name="cellStyle"></param>
        /// <returns></returns>
        private Rectangle GetAdjustedEditingControlBounds(
            Rectangle editingControlBounds, DataGridViewCellStyle cellStyle)
        {

            //在编辑控件的左右各添加一个像素的填充
            editingControlBounds.X += 1;
            editingControlBounds.Width = Math.Max(0, editingControlBounds.Width - 2);

            //调整编辑控件的垂直位置
            int preferredHeight = cellStyle.Font.Height + 3;
            if (preferredHeight < editingControlBounds.Height)
            {
                switch (cellStyle.Alignment)
                {
                    case DataGridViewContentAlignment.MiddleLeft:
                    case DataGridViewContentAlignment.MiddleCenter:
                    case DataGridViewContentAlignment.MiddleRight:
                        editingControlBounds.Y += (editingControlBounds.Height - preferredHeight) / 2;
                        break;
                    case DataGridViewContentAlignment.BottomLeft:
                    case DataGridViewContentAlignment.BottomCenter:
                    case DataGridViewContentAlignment.BottomRight:
                        editingControlBounds.Y += editingControlBounds.Height - preferredHeight;
                        break;
                    default:
                        break;
                }
            }
            return editingControlBounds;
        }

        /// <summary>
        /// 绘制错误图标
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="cellStyle"></param>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        protected override Rectangle GetErrorIconBounds(Graphics graphics,
            DataGridViewCellStyle cellStyle,
            int rowIndex)
        {
            const int buttonsWidth = 16;
            Rectangle errorIconBounds = base.GetErrorIconBounds(graphics, cellStyle, rowIndex);

            if (this.DataGridView.RightToLeft == RightToLeft.Yes)
            {
                errorIconBounds.X = errorIconBounds.Left + buttonsWidth;
            }
            else
            {
                errorIconBounds.X = errorIconBounds.Left - buttonsWidth;
            }

            return errorIconBounds;
        }


        protected override object GetFormattedValue(object value,
            int rowIndex,
            ref DataGridViewCellStyle cellStyle,
            TypeConverter valueTypeConverter,
            TypeConverter formattedValueTypeConverter,
            DataGridViewDataErrorContexts context)
        {
            object formattedValue= base.GetFormattedValue(value, rowIndex, ref cellStyle, valueTypeConverter, formattedValueTypeConverter, context);
           // int formattedNumber = Convert.ToInt32( formattedValue);
            if (!string.IsNullOrEmpty(formattedValue as string) && value != null) {
                Console.WriteLine($"GetFormattedValue: RowIndex{rowIndex},Value:{formattedValue}");
                return Convert.ToInt32(formattedValue);
            }
            return this.defaultValue;
        }



        /// <summary>
        /// 为单元格的最大值设置新的值。该函数被单元格和最大值属性使用，
        /// 该列使用这个方法而不是用做大值属性是基于性能考虑，这样可以是整个列失效而不是
        /// 逐个使单元格失效。行索引需要作为参数提供，因为单元格可以在多行之间共享
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="value"></param>
        internal void SetMaximum(int rowIndex, int value)
        {
            this.maximumValue = value;
            if (this.minimumValue > this.maximumValue)
            {
                this.minimumValue = this.maximumValue;
            }
            object cellValue = GetValue(rowIndex);
            if (cellValue != null)
            {
                int currentValue = System.Convert.ToInt32(cellValue);
                int constrainedValue = Constrain(currentValue);//判断值是不是介于最小值和最大值之间
                if (constrainedValue != currentValue)
                {
                    SetValue(rowIndex, constrainedValue);
                }
                Debug.Assert(this.maximumValue == value);
                if (OwnEditingTrackBar(rowIndex))
                {
                    this.EditTrackBar.Maximum = value;
                }
            }
        }

        /// <summary>
        /// 为单元格的最小值设置新的值
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="value"></param>
        internal void SetMinimum(int rowIndex, int value)
        {
            this.minimumValue = value;
            if (this.minimumValue > this.maximumValue)
            {
                this.maximumValue = value;
            }
            object cellValue = GetValue(rowIndex);
            if (cellValue != null)
            {
                int currentValue = Convert.ToInt32(cellValue);
                int constrainedValue = Constrain(currentValue);
                if (constrainedValue != currentValue)
                {
                    SetValue(rowIndex, constrainedValue);
                }
            }
            Debug.Assert(this.minimumValue == value);
            if (OwnEditingTrackBar(rowIndex))
            {
                this.EditTrackBar.Minimum = value;
            }
        }

        /// <summary>
        /// 设置单元格默认值
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="value"></param>
        internal void SetDefaultValue(int rowIndex, int value) {
            this.defaultValue = value;
            Debug.Assert(this.defaultValue == value);
        }

        /// <summary>
        /// 返回一个被限制在最大值和最小值之间的值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private int Constrain(int value)
        {
            Debug.Assert(this.minimumValue <= this.maximumValue);
            if (value < this.minimumValue)
            {
                value = minimumValue;
            }
            if (value > this.maximumValue)
            {
                value = maximumValue;
            }
            return value;
        }

        /// <summary>
        /// 重写绘制单元格函数。
        /// 首先调用DataGridViewTextBoxCell基类实现，
        /// 删除错误图标和前景内容，这两个部分由自定义实现，
        /// 在这个实例中通过调用Control.DrawToBitmap来实现，但这并不是最高性能的方式。
        /// 另外一种是绘制图片的形式
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="clipBounds"></param>
        /// <param name="cellBounds"></param>
        /// <param name="rowIndex"></param>
        /// <param name="cellState"></param>
        /// <param name="value"></param>
        /// <param name="formattedValue"></param>
        /// <param name="errorText"></param>
        /// <param name="cellStyle"></param>
        /// <param name="advancedBorderStyle"></param>
        /// <param name="paintParts"></param>
        protected override void Paint(Graphics graphics,
            Rectangle clipBounds,
            Rectangle cellBounds, 
            int rowIndex, 
            DataGridViewElementStates cellState, 
            object value, 
            object formattedValue, 
            string errorText,
            DataGridViewCellStyle cellStyle, 
            DataGridViewAdvancedBorderStyle advancedBorderStyle, 
            DataGridViewPaintParts paintParts)
        {
            if (this.DataGridView == null) {
                return;
            }
            //首先绘制单元格的边框和背景
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle,
                paintParts & ~(DataGridViewPaintParts.ErrorIcon | DataGridViewPaintParts.ContentForeground));

            Point ptCurrentCell = this.DataGridView.CurrentCellAddress;
            bool cellCurrent = ptCurrentCell.X == this.ColumnIndex && ptCurrentCell.Y == rowIndex;
            bool cellEdited = cellCurrent && this.DataGridView.EditingControl != null;

            //如果单元格处于编辑模式则不绘制任何东西
            if (!cellEdited) {
                if (PartPainted(paintParts, DataGridViewPaintParts.ContentForeground)) {
                    //绘制TrackBar,并将边界也考虑其中
                    Rectangle borderWidths = BorderWidths(advancedBorderStyle);//获取边框跨距宽度
                    Rectangle valBounds = cellBounds;
                    valBounds.Offset(borderWidths.X,borderWidths.Y);
                    valBounds.Width -= borderWidths.Right;
                    valBounds.Height -= borderWidths.Bottom;
                    //将填充也考虑在内
                    if (cellStyle.Padding != Padding.Empty) {
                        if (this.DataGridView.RightToLeft == RightToLeft.Yes)
                        {
                            valBounds.Offset(cellStyle.Padding.Right, cellStyle.Padding.Top);
                        }
                        else {
                            valBounds.Offset(cellStyle.Padding.Left,cellStyle.Padding.Top);
                        }
                        valBounds.Width -= cellStyle.Padding.Horizontal;
                        valBounds.Height -= cellStyle.Padding.Vertical;
                        
                    }
                    //
                    valBounds = GetAdjustedEditingControlBounds(valBounds,cellStyle);
                    bool cellSelected = (cellState & DataGridViewElementStates.Selected) != 0;
                    if (renderingBitmap.Width < valBounds.Width || renderingBitmap.Height < valBounds.Height) {
                        //图像太小，需重新绘制一个大点的
                        renderingBitmap.Dispose();
                        renderingBitmap = new Bitmap(valBounds.Width,valBounds.Height);
                    }
                    //确定TrackBar控件是一个可见的父控件
                    if (paintingTrackBar.Parent == null || !paintingTrackBar.Parent.Visible) {
                        paintingTrackBar.Parent = this.DataGridView;
                    }
                    //设置相关属性
                    paintingTrackBar.Width = valBounds.Width;
                    paintingTrackBar.Height = valBounds.Height;
                    paintingTrackBar.RightToLeft = this.DataGridView.RightToLeft;
                    paintingTrackBar.Location = new Point(0,-paintingTrackBar.Height-100);
                    paintingTrackBar.Value = (int)formattedValue;

                    //Color backColor;
                    //if (PartPainted(paintParts, DataGridViewPaintParts.SelectionBackground) && cellSelected)
                    //{
                    //    backColor = cellStyle.SelectionBackColor;
                    //}
                    //else {
                    //    backColor = cellStyle.BackColor;
                    //}
                    //if (PartPainted(paintParts, DataGridViewPaintParts.Background)) {
                    //    if (backColor.A < 255) {
                    //        //TrackBar不知吃透明的背景颜色
                    //        backColor = Color.FromArgb(255,backColor);
                    //    }
                    //    //TrackBar.DefaultBackColor = backColor;
                    //}

                    //最后绘制TrackBar控件
                    Rectangle srcRect = new Rectangle(0,0,valBounds.Width,valBounds.Height);
                    if (srcRect.Width > 0 && srcRect.Height > 0) {
                        paintingTrackBar.DrawToBitmap(renderingBitmap,srcRect);
                        graphics.DrawImage(renderingBitmap,new Rectangle(valBounds.Location,valBounds.Size),
                            srcRect,GraphicsUnit.Pixel);
                    }
                    if (PartPainted(paintParts, DataGridViewPaintParts.ErrorIcon)) {
                        //在TrackBar上面绘制潜在的错误图标
                        base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText,
                              cellStyle, advancedBorderStyle, DataGridViewPaintParts.ErrorIcon);
                    }
                }
            }
        }

        /// <summary>
        /// 用于判断是否绘制特定部分
        /// </summary>
        /// <param name="paintParts"></param>
        /// <param name="paintPart"></param>
        /// <returns></returns>
        private static bool PartPainted(DataGridViewPaintParts paintParts,
            DataGridViewPaintParts paintPart) {
            return (paintParts & paintPart) != 0;
        }
        /// <summary>
        /// 确定该单元格在给定行的索引处是否显示编辑控件
        /// </summary>
        /// <param name="rowIndex">行索引</param>
        /// <returns></returns>
        private bool OwnEditingTrackBar(int rowIndex)
        {
            if (rowIndex == -1 || this.DataGridView == null)
            {
                return false;
            }
            var ctrl = this.DataGridView.EditingControl as DataGridViewTrackBarEditingControl;
            return ctrl != null && rowIndex == ((IDataGridViewEditingControl)ctrl).EditingControlRowIndex;
        }

        /// <summary>
        /// 当单元格的呈现或者首选大小特征发生改变时调用
        /// 此实现只负责重新绘制单元格。在单元格自动调整大小的情况下，也需要调用DataGridView的自动调整方法
        /// </summary>
        private void OnCommonChange()
        {
            if (this.DataGridView != null && !this.DataGridView.IsDisposed &&
                !this.DataGridView.Disposing)
            {
                if (this.RowIndex == -1)
                {
                    //使列无效并自动调整单元格的大小
                    this.DataGridView.InvalidateColumn(this.ColumnIndex);
                    //TODO:添加代码来自动调整单元格的列、行和标题列的大小
                    //     行标取决于它们的自动大小设置
                }
                else
                {
                    //DataGridView控件暴露一个名为UpDateCellValue的方法，
                    //该方法使得单元格失效，因此它会被重绘，这也触发了所有必要的
                    //自动调整单元格的列、行和标题列
                    this.DataGridView.UpdateCellValue(this.ColumnIndex, this.RowIndex);
                }
            }
        }

        /// <summary>
        /// 在KeyEntersEditMode函数中使用该方法
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImport("USER32.DLL", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern short VkKeyScan(char key);

        #endregion

        #region 委托



        #endregion

        #region 事件



        #endregion
    }
}
