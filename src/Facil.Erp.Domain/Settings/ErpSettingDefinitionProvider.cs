﻿using Volo.Abp.Settings;

namespace Facil.Erp.Settings;

public class ErpSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ErpSettings.MySetting1));
    }
}
