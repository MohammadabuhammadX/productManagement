using Volo.Abp.Settings;

namespace productManagement.Settings;

public class productManagementSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(productManagementSettings.MySetting1));
    }
}
