using productManagement.Samples;
using Xunit;

namespace productManagement.EntityFrameworkCore.Applications;

[Collection(productManagementTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<productManagementEntityFrameworkCoreTestModule>
{

}
