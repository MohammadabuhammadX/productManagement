using Microsoft.AspNetCore.Builder;
using productManagement;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("productManagement.Web.csproj"); 
await builder.RunAbpModuleAsync<productManagementWebTestModule>(applicationName: "productManagement.Web");

public partial class Program
{
}
