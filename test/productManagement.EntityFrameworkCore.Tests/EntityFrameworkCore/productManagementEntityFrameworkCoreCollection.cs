using Xunit;

namespace productManagement.EntityFrameworkCore;

[CollectionDefinition(productManagementTestConsts.CollectionDefinitionName)]
public class productManagementEntityFrameworkCoreCollection : ICollectionFixture<productManagementEntityFrameworkCoreFixture>
{

}
