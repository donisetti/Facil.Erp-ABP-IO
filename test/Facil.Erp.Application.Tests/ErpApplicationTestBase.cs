using Volo.Abp.Modularity;

namespace Facil.Erp;

public abstract class ErpApplicationTestBase<TStartupModule> : ErpTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
