/* http://www.zkea.net/ Copyright 2016 ZKEASOFT http://www.zkea.net/licenses */
using Easy.Constant;
using Easy.MetaData;
using Easy.Web.CMS.Widget;

namespace Easy.Web.CMS.MetaData
{
    public abstract class WidgetMetaData<T> : DataViewMetaData<T> where T : WidgetBase
    {
        int orderStart;
        protected override bool IsIgnoreBase()
        {
            return true;
        }
        protected int NextOrder()
        {
            return ++orderStart;
        }
        private void InitViewBase()
        {
            ViewConfig(m => m.WidgetName).AsTextBox().Order(NextOrder()).Required();
            ViewConfig(m => m.Title).AsTextBox().Order(NextOrder());
            ViewConfig(m => m.ZoneID).AsDropDownList().Order(NextOrder()).DataSource(ViewDataKeys.Zones, SourceType.ViewData).Required();
            ViewConfig(m => m.Position).AsTextBox().Order(NextOrder()).RegularExpression(RegularExpression.Integer);
            ViewConfig(m => m.IsTemplate).AsCheckBox().Order(NextOrder());
            ViewConfig(m => m.Thumbnail).AsTextBox().Order(NextOrder()).AddClass(StringKeys.SelectImageClass).AddProperty("data-url", Urls.SelectMedia);
            ViewConfig(m => m.StyleClass).AsTextBox().Order(NextOrder()).AddClass(StringKeys.StyleEditor).AddProperty("data-url", Urls.StyleEditor).AddProperty("data-width", "1024").MaxLength(1000);
            ViewConfig(m => m.CustomClass).AsHidden().Ignore();
            ViewConfig(m => m.CustomStyle).AsHidden().Ignore();
            ViewConfig(m => m.ExtendFields).AsListEditor();
            
        }

        protected override void DataConfigure()
        {
            DataTable(TargetType.Name);
            DataConfig(m => m.ID).AsPrimaryKey();
            DataConfig(m => m.CustomClass).Ignore();
            DataConfig(m => m.CustomStyle).Ignore();
            DataConfig(m => m.ExtendFields).Ignore();
        }

        protected override void ViewConfigure()
        {
            InitViewBase();
        }
    }
}
