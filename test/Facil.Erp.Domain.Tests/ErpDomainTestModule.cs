using Volo.Abp.Modularity;

namespace Facil.Erp;

[DependsOn(
    typeof(ErpDomainModule),
    typeof(ErpTestBaseModule)
)]
public class ErpDomainTestModule : AbpModule
{

}
