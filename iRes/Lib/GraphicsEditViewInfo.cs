using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Title.Lib
{
    class GraphicsEditViewInfo : PictureEditViewInfo
    {
        public GraphicsEditViewInfo(RepositoryItem item)
            : base(item)
        {
        }

        public override object EditValue
        {
            get { return base.EditValue; }
            set
            {
                if (value != null && value.GetType() == typeof(System.String))
                {
                    try
                    {
                        base.EditValue = new Bitmap(value.ToString());
                    }
                    catch
                    {
                        base.EditValue = Item.ErrorImage;
                    }
                }
                else
                {
                    base.EditValue = value;
                }
            }
        }
    }
}
