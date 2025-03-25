using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using productManagement.Localization;

namespace productManagement.Web;

[Dependency(ReplaceServices = true)]
public class productManagementBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<productManagementResource> _localizer;

    public productManagementBrandingProvider(IStringLocalizer<productManagementResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
