using Facil.Erp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Facil.Erp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ErpEntityFrameworkCoreModule),
    typeof(ErpApplicationContractsModule)
    )]
public class ErpDbMigratorModule : AbpModule
{
}
