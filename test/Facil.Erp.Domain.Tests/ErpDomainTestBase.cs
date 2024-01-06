using Volo.Abp.Modularity;

namespace Facil.Erp;

/* Inherit from this class for your domain layer tests. */
public abstract class ErpDomainTestBase<TStartupModule> : ErpTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
