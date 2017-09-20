using System;
using System.Collections.Generic;
using System.Text;


namespace Rentler.Admin.Configuration
{

    public class ConfigManagerAppSettingService : IConfigManagerService
    {
        public AppSettings App { get;}

        public ConfigManagerAppSettingService(AppSettings _appsetting)
        {
            this.App = _appsetting;
        }
    }
}
