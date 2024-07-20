using Volo.Abp.Modularity;

namespace TeduEcommerce.Admin;

public abstract class TeduEcommerceAdminApplicationTestBase<TStartupModule> : TeduEcommerceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
