using productManagement.Localization;
using Volo.Abp.Application.Services;

namespace productManagement;

/* Inherit your application services from this class.
 */
public abstract class productManagementAppService : ApplicationService
{
    protected productManagementAppService()
    {
        LocalizationResource = typeof(productManagementResource);
    }
}
