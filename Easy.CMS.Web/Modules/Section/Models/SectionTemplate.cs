﻿using Easy.MetaData;
using Easy.Models;

namespace Easy.CMS.Section.Models
{
    [DataConfigure(typeof(SectionTemplateMetaData))]
    public class SectionTemplate : EditorEntity
    {
        public string TemplateName { get; set; }
        public string Thumbnail { get; set; }
        public string ExampleData { get; set; }
    }

    internal class SectionTemplateMetaData : DataViewMetaData<SectionTemplate>
    {

        protected override void DataConfigure()
        {
            DataTable("SectionTemplate");
            DataConfig(m => m.TemplateName).AsPrimaryKey();
        }

        protected override void ViewConfigure()
        {
            
        }

    }
}