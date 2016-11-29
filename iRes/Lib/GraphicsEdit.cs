using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Title.Lib
{
    class GraphicsEdit : PictureEdit
    {
        static GraphicsEdit()
        {
            RepositoryItemGraphicsEdit.RegisterGraphicsEditor();
        }

        public override string EditorTypeName
        {
            get { return RepositoryItemGraphicsEdit.GraphicsEditorName; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemGraphicsEdit Properties
        {
            get { return base.Properties as RepositoryItemGraphicsEdit; }
        }

        protected override DevExpress.XtraEditors.Controls.PictureMenu Menu
        {
            get { return null; }
        }
    }
}
