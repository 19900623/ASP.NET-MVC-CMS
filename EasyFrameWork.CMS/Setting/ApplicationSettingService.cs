/* http://www.zkea.net/ Copyright 2016 ZKEASOFT http://www.zkea.net/licenses */
using Easy.Extend;
using Easy.RepositoryPattern;

namespace Easy.Web.CMS.Setting
{
    public class ApplicationSettingService : ServiceBase<ApplicationSetting>, IApplicationSettingService
    {
        public override void Add(ApplicationSetting item)
        {
            if (Count(m => m.SettingKey == item.SettingKey) == 0)
            {
                base.Add(item);    
            }
        }

        public string Get(string settingKey, string defaultValue)
        {
            var setting = Get(settingKey);
            if (setting == null || setting.Value.IsNullOrWhiteSpace())
            {
                if (setting == null && defaultValue.IsNotNullAndWhiteSpace())
                {
                    Add(new ApplicationSetting { SettingKey = settingKey, Value = defaultValue });
                }
                return defaultValue;
            }
            return setting.Value;
        }
    }
}