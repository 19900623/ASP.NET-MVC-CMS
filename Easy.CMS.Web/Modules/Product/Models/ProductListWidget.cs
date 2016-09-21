﻿using System;
using System.Collections.Generic;
using System.IO;
using Easy.Extend;
using Easy.MetaData;
using Easy.Web.CMS;
using Easy.Web.CMS.MetaData;
using Easy.Web.CMS.Product.Service;
using Easy.Web.CMS.Widget;
using Microsoft.Practices.ServiceLocation;

namespace Easy.CMS.Product.Models
{
    [DataConfigure(typeof(ProductListWidgetMetaData)), Serializable]
    public class ProductListWidget : WidgetBase
    {
        public bool IsPageable { get; set; }
        public int ProductCategoryID { get; set; }
        public string DetailPageUrl { get; set; }
        public string Columns { get; set; }
        public int? PageSize { get; set; }
    }

    class ProductListWidgetMetaData : WidgetMetaData<ProductListWidget>
    {
        protected override void ViewConfigure()
        {
            base.ViewConfigure();
            ViewConfig(m => m.ProductCategoryID).AsDropDownList().DataSource(() =>
            {
                var dicts = new Dictionary<string, string>();
                ServiceLocator.Current.GetInstance<IProductCategoryService>().Get().Each(m => { dicts.Add(m.ID.ToString(), m.Title); });
                return dicts;
            }).Required().Order(NextOrder());
            ViewConfig(m => m.DetailPageUrl).AsTextBox().Order(NextOrder()).AddClass("select").AddProperty("data-url", Urls.SelectPage);
            ViewConfig(m => m.PageSize).AsTextBox().Order(NextOrder()).Range(1, 50);
            ViewConfig(m => m.Columns).AsDropDownList().Order(NextOrder()).DataSource(new Dictionary<string, string>
            {
                { "col-xs-12 col-sm-6 col-md-4", "3 列" }, 
                { "col-xs-12 col-sm-6 col-md-4 col-lg-3", "4 列" }
            });
            ViewConfig(m => m.PartialView).AsDropDownList().Order(NextOrder()).DataSource(() =>
            {
                var path = (ServiceLocator.Current.GetInstance<IApplicationContext>() as CMSApplicationContext).MapPath("~/Modules/Product/Views");
                Dictionary<string, string> templates = new Dictionary<string, string>();
                Directory.GetFiles(path, "Widget.ProductList*.cshtml").Each(f =>
                {
                    string fileName = Path.GetFileNameWithoutExtension(f);
                    templates.Add(fileName, fileName.Replace("Widget.", ""));

                });
                return templates;
            });
        }
    }

}