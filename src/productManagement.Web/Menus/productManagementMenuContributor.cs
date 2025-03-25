using System.Threading.Tasks;
using productManagement.Localization;
using productManagement.Permissions;
using productManagement.MultiTenancy;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.UI.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;

namespace productManagement.Web.Menus
{
    public class productManagementMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private static Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            var l = context.GetLocalizer<productManagementResource>();

            // Home
            context.Menu.AddItem(
                new ApplicationMenuItem(
                    productManagementMenus.Home,
                    l["Menu:Home"],
                    "~/",
                    icon: "fa fa-home",
                    order: 1
                )
            );

            context.Menu.AddItem(
                new ApplicationMenuItem(
                    "ProductManagement",
                    l["Menu:ProductManagement"],
                    icon: "fas fa-shopping-cart"
                ).AddItem(
                    new ApplicationMenuItem(
                        "ProductManagement.Products",
                        l["Menu:Products"],
                        url: "/Products"
                    )
                )
            );

            // Administration
            var administration = context.Menu.GetAdministration();
            administration.Order = 5;

            // Administration -> Identity
            administration.SetSubItemOrder(IdentityMenuNames.GroupName, 1);

            if (MultiTenancyConsts.IsEnabled)
            {
                administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
            }
            else
            {
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);

            // Administration -> Settings
            administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 7);

            return Task.CompletedTask;
        }
    }
}