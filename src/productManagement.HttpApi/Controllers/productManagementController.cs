using productManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace productManagement.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class productManagementController : AbpControllerBase
{
    protected productManagementController()
    {
        LocalizationResource = typeof(productManagementResource);
    }
}
