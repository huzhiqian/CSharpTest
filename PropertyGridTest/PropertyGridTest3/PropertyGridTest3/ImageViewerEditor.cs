using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;
using System.Drawing.Design;
using System.ComponentModel;
using System.Windows.Forms.Design;
using System.Drawing;


//**********************************************
//文件名：ImageViewerEditor
//命名空间：PropertyGridTest3
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/3/5 9:54:29
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace PropertyGridTest3
{
    class ImageViewerEditor: UITypeEditor
    {

        #region 构造函数

        public ImageViewerEditor()
        {

        }

        #endregion


        #region 属性



        #endregion

        #region 公共方法

        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand)]
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            if (context != null && context.Instance != null)
            {
                //这里设置下拉模式和弹框模式
                return UITypeEditorEditStyle.Modal;
            }
            return base.GetEditStyle(context);
        }

        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand)]
        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService windowsFormsEditorService = null;
            if (context != null && context.Instance != null && provider != null)
            {
                windowsFormsEditorService = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
                if (windowsFormsEditorService != null)
                {
                    //自定义控件
                    ImageViewer imageViewer = new ImageViewer(value as Bitmap);
                    windowsFormsEditorService.DropDownControl(imageViewer);
                    return imageViewer.Image;
                }
            }
            return base.EditValue(context, provider, value);
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
