﻿using Volo.Abp.Settings;

namespace ZapierDemo.Settings;

public class ZapierDemoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ZapierDemoSettings.MySetting1));
    }
}
