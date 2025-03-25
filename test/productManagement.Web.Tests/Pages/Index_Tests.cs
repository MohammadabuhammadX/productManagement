using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace productManagement.Pages;

[Collection(productManagementTestConsts.CollectionDefinitionName)]
public class Index_Tests : productManagementWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
