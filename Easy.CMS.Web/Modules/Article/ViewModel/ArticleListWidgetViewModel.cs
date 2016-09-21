﻿using System.Collections.Generic;
using Easy.CMS.Article.Models;
using Easy.Data;
using Easy.Web.CMS.Article.Models;

namespace Easy.CMS.Article.ViewModel
{
    public class ArticleListWidgetViewModel
    {
        public Pagination Pagin { get; set; }
        public string CategoryTitle { get; set; }
        public ArticleListWidget Widget { get; set; }
        public IEnumerable<ArticleEntity> Articles { get; set; }
        public int CurrentCategory { get; set; }
        public bool IsPageable { get; set; }
    }
}