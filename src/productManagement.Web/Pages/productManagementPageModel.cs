using productManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace productManagement.Web.Pages;

public abstract class productManagementPageModel : AbpPageModel
{
    protected productManagementPageModel()
    {
        LocalizationResourceType = typeof(productManagementResource);
    }
}
