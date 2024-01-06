using Volo.Abp.Modularity;

namespace Facil.Erp;

[DependsOn(
    typeof(ErpApplicationModule),
    typeof(ErpDomainTestModule)
)]
public class ErpApplicationTestModule : AbpModule
{

}
