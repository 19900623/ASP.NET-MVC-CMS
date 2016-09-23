/* http://www.zkea.net/ Copyright 2016 ZKEASOFT http://www.zkea.net/licenses */
using System.Collections.Generic;
using Easy.CMS.Common.Models;

namespace Easy.CMS.Common.ViewModels
{
    public class NavigationWidgetViewModel
    {
        public NavigationWidgetViewModel(IEnumerable<NavigationEntity> navigation, NavigationWidget widget)
        {
            Navigations = navigation;
            Widget = widget;
        }
        public IEnumerable<NavigationEntity> Navigations { get; set; }
        public NavigationWidget Widget { get; set; }
    }
}