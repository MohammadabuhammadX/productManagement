using productManagement.Samples;
using Xunit;

namespace productManagement.EntityFrameworkCore.Domains;

[Collection(productManagementTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<productManagementEntityFrameworkCoreTestModule>
{

}
